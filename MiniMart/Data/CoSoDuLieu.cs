using Microsoft.EntityFrameworkCore;
using MiniMart.Model;
using MiniMart.Services;

namespace MiniMart.Data;

public class CoSoDuLieu : DbContext
{
    private static readonly string Folder =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MiniMart");

    public static string DbPath => Path.Combine(Folder, "minimart.db");

    // Mỗi DbSet là một bảng (tên bảng giữ nguyên như bản SQL cũ)
    public DbSet<NguoiDung> NguoiDungs => Set<NguoiDung>();
    public DbSet<SanPham> SanPhams => Set<SanPham>();
    public DbSet<HoaDon> HoaDons => Set<HoaDon>();
    public DbSet<ChiTietHoaDon> ChiTietHoaDons => Set<ChiTietHoaDon>();
    public DbSet<PhieuNhapKho> PhieuNhapKhos => Set<PhieuNhapKho>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        Directory.CreateDirectory(Folder);
        options.UseSqlite($"Data Source={DbPath}");
    }

    // SQLite không có kiểu decimal thật: lưu decimal dưới dạng REAL (giống schema cũ)
    protected override void ConfigureConventions(ModelConfigurationBuilder builder)
    {
        builder.Properties<decimal>().HaveConversion<double>();
    }

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<NguoiDung>(e =>
        {
            e.ToTable("NguoiDung");
            e.HasIndex(x => x.TenNguoiDung).IsUnique();
        });

        mb.Entity<SanPham>(e =>
        {
            e.ToTable("SanPham");
            e.HasIndex(x => x.Ma).IsUnique();
        });

        mb.Entity<HoaDon>(e =>
        {
            e.ToTable("HoaDon");
            e.HasIndex(x => x.MaHoaDon).IsUnique();
        });

        mb.Entity<ChiTietHoaDon>(e =>
        {
            e.ToTable("ChiTietHoaDon");
            e.HasOne(x => x.HoaDon).WithMany(x => x.Items).HasForeignKey(x => x.IdHoaDon);
            // Không cho xóa sản phẩm đã phát sinh hóa đơn (giống hành vi cũ)
            e.HasOne<SanPham>().WithMany().HasForeignKey(x => x.IdSanPham).OnDelete(DeleteBehavior.Restrict);
        });

        mb.Entity<PhieuNhapKho>(e =>
        {
            e.ToTable("PhieuNhapKho");
            e.HasOne<SanPham>().WithMany().HasForeignKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);
        });

        // Dữ liệu mẫu (chỉ chèn khi database được tạo mới)
        var ngay = new DateTime(2026, 1, 1);

        mb.Entity<NguoiDung>().HasData(new NguoiDung
        {
            Id = 1, TenNguoiDung = "admin", MatKhauBam = DichVuTaiKhoan.BamMatKhau("admin123"),
            TenHienThi = "Quản trị viên", VaiTro = "Admin", DangHoatDong = true, DuocTaoVao = ngay
        });

        mb.Entity<SanPham>().HasData(
            new SanPham { Id = 1, Ma = "SP001", Ten = "Nước suối 500ml", DonVi = "Chai", GiaVon = 4000,  GiaBan = 7000,  CoPhan = 50, TonKhoToiThieu = 10 },
            new SanPham { Id = 2, Ma = "SP002", Ten = "Mì ăn liền",      DonVi = "Gói",  GiaVon = 3500,  GiaBan = 5000,  CoPhan = 80, TonKhoToiThieu = 15 },
            new SanPham { Id = 3, Ma = "SP003", Ten = "Bánh quy",        DonVi = "Gói",  GiaVon = 12000, GiaBan = 16000, CoPhan = 25, TonKhoToiThieu = 5 },
            new SanPham { Id = 4, Ma = "SP004", Ten = "Sữa tươi",        DonVi = "Hộp",  GiaVon = 6500,  GiaBan = 9000,  CoPhan = 8,  TonKhoToiThieu = 10 });
    }

    /// <summary>
    /// Gọi một lần khi khởi động app. Nếu file database cũ có cấu trúc bảng không khớp model hiện tại
    /// (vd. tạo từ bản SQL cũ), file cũ được đổi tên thành minimart_cu_*.db và database mới được tạo lại.
    /// </summary>
    public static void KhoiTao()
    {
        using (var db = new CoSoDuLieu())
        {
            db.Database.EnsureCreated();
            if (SchemaHopLe(db)) return;
        }

        Microsoft.Data.Sqlite.SqliteConnection.ClearAllPools();
        string sao = Path.Combine(Folder, $"minimart_cu_{DateTime.Now:yyyyMMddHHmmss}.db");
        File.Move(DbPath, sao);

        using var moi = new CoSoDuLieu();
        moi.Database.EnsureCreated();
    }

    /// <summary>Kiểm tra mọi bảng trong file .db có đủ cột của model và không có cột bắt buộc thừa.</summary>
    private static bool SchemaHopLe(CoSoDuLieu db)
    {
        var conn = db.Database.GetDbConnection();
        conn.Open();
        try
        {
            foreach (var entity in db.Model.GetEntityTypes())
            {
                string? bang = entity.GetTableName();
                if (bang == null) continue;
                var store = Microsoft.EntityFrameworkCore.Metadata.StoreObjectIdentifier.Table(bang, entity.GetSchema());
                var cotModel = entity.GetProperties()
                    .Select(p => p.GetColumnName(store))
                    .Where(c => c != null)
                    .ToHashSet(StringComparer.OrdinalIgnoreCase);

                var cotThucTe = new Dictionary<string, (bool NotNull, bool CoMacDinh, bool KhoaChinh)>(StringComparer.OrdinalIgnoreCase);
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = $"PRAGMA table_info(\"{bang}\")";
                    using var rd = cmd.ExecuteReader();
                    while (rd.Read())
                        cotThucTe[rd.GetString(1)] = (rd.GetInt32(3) == 1, !rd.IsDBNull(4), rd.GetInt32(5) > 0);
                }

                if (cotThucTe.Count == 0) return false;                       // thiếu bảng
                if (cotModel.Any(c => !cotThucTe.ContainsKey(c!))) return false; // thiếu cột
                if (cotThucTe.Any(kv => !cotModel.Contains(kv.Key)
                                        && kv.Value.NotNull && !kv.Value.CoMacDinh && !kv.Value.KhoaChinh))
                    return false;                                             // thừa cột NOT NULL không có mặc định
            }
            return true;
        }
        finally { conn.Close(); }
    }
}

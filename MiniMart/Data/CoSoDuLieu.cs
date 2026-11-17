using Microsoft.EntityFrameworkCore;
using MiniMart.Model;
using MiniMart.Services;

namespace MiniMart.Data;

public class CoSoDuLieu : DbContext
{
    private static readonly string Folder =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MiniMart");

    public static string DbPath => Path.Combine(Folder, "minimart.db");

    // Mỗi DbSet là một bảng 
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

    // quy ước chuyển đổi kiểu dữ liệu decimal sang double
    protected override void ConfigureConventions(ModelConfigurationBuilder builder)
    {
        builder.Properties<decimal>().HaveConversion<double>();
    }
    // cấu hình cấu trúc các bảng, khóa chính, khóa ngoại, ràng buộc dữ liệu và dữ liệu mẫu
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
            // Không cho xóa sản phẩm đã có sinh hóa đơn 
            e.HasOne<SanPham>().WithMany().HasForeignKey(x => x.IdSanPham).OnDelete(DeleteBehavior.Restrict);
        });

        mb.Entity<PhieuNhapKho>(e =>
        {
            e.ToTable("PhieuNhapKho");
            e.HasOne<SanPham>().WithMany().HasForeignKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);
        });

        // Tạo dư liệu mẫu
        var ngay = new DateTime(2026, 1, 1);

        mb.Entity<NguoiDung>().HasData(new NguoiDung
        {
            Id = 1, TenNguoiDung = "quanly", MatKhauBam = DichVuTaiKhoan.BamMatKhau("quanly123"),
            TenHienThi = "Quản Lý", VaiTro = "Quản Lý", DangHoatDong = true, DuocTaoVao = ngay
        });
        mb.Entity<NguoiDung>().HasData(new NguoiDung
        {
            Id = 2, TenNguoiDung = "nhanvien", MatKhauBam = DichVuTaiKhoan.BamMatKhau("nhanvien123"),
            TenHienThi = "Nhân Viên A", VaiTro = "Nhân Viên", DangHoatDong = true, DuocTaoVao = ngay
        });

        mb.Entity<SanPham>().HasData(
            new SanPham { Id = 1,  Ma = "SP001", Ten = "Nước suối 500ml",       DonVi = "Chai", GiaVon = 4000,  GiaBan = 7000,  CoPhan = 50, TonKhoToiThieu = 10 },
            new SanPham { Id = 2,  Ma = "SP002", Ten = "Mì ăn liền",            DonVi = "Gói",  GiaVon = 3500,  GiaBan = 5000,  CoPhan = 80, TonKhoToiThieu = 15 },
            new SanPham { Id = 3,  Ma = "SP003", Ten = "Bánh quy",              DonVi = "Gói",  GiaVon = 12000, GiaBan = 16000, CoPhan = 25, TonKhoToiThieu = 5 },
            new SanPham { Id = 4,  Ma = "SP004", Ten = "Sữa tươi",              DonVi = "Hộp",  GiaVon = 6500,  GiaBan = 9000,  CoPhan = 8,  TonKhoToiThieu = 10 },
            new SanPham { Id = 5,  Ma = "SP005", Ten = "Coca Cola 330ml",       DonVi = "Lon",  GiaVon = 7000,  GiaBan = 10000, CoPhan = 40, TonKhoToiThieu = 10 },
            new SanPham { Id = 6,  Ma = "SP006", Ten = "Pepsi 330ml",           DonVi = "Lon",  GiaVon = 7000,  GiaBan = 10000, CoPhan = 35, TonKhoToiThieu = 10 },
            new SanPham { Id = 7,  Ma = "SP007", Ten = "Trà xanh 0 độ",         DonVi = "Chai", GiaVon = 8000,  GiaBan = 12000, CoPhan = 30, TonKhoToiThieu = 10 },
            new SanPham { Id = 8,  Ma = "SP008", Ten = "Bánh Oreo",             DonVi = "Gói",  GiaVon = 9000,  GiaBan = 13000, CoPhan = 25, TonKhoToiThieu = 8 },
            new SanPham { Id = 9,  Ma = "SP009", Ten = "Bánh Chocopie",         DonVi = "Hộp",  GiaVon = 25000, GiaBan = 32000, CoPhan = 20, TonKhoToiThieu = 5 },
            new SanPham { Id = 10, Ma = "SP010", Ten = "Sữa đặc Ông Thọ",       DonVi = "Lon",  GiaVon = 18000, GiaBan = 23000, CoPhan = 15, TonKhoToiThieu = 5 },
            new SanPham { Id = 11, Ma = "SP011", Ten = "Nước tăng lực Red Bull",DonVi = "Lon",  GiaVon = 9000,  GiaBan = 13000, CoPhan = 30, TonKhoToiThieu = 10 },
            new SanPham { Id = 12, Ma = "SP012", Ten = "Khăn giấy",             DonVi = "Gói",  GiaVon = 5000,  GiaBan = 8000,  CoPhan = 50, TonKhoToiThieu = 10 },
            new SanPham { Id = 13, Ma = "SP013", Ten = "Mì Hảo Hảo",            DonVi = "Gói",  GiaVon = 3500,  GiaBan = 5000,  CoPhan = 100,TonKhoToiThieu = 20 },
            new SanPham {Id = 14,  Ma = "SP014", Ten = "Nước rửa chén",         DonVi = "Chai", GiaVon = 15000, GiaBan = 20000, CoPhan = 20, TonKhoToiThieu = 5 });
    }

    
    /// Gọi một lần khi khởi động app
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

   //Kiểm tra mọi bảng trong file .db có đủ cột của model và không có cột bắt buộc thừa
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

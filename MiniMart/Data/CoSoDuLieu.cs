using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MiniMart.Model;

namespace MiniMart.Data;

public class CoSoDuLieu : DbContext
{
    private static readonly string Folder =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MiniMart");
    public static string DbPath => Path.Combine(Folder, "minimart.db");
    
    //Mỗi Dbset là mô bảng (tên bảng giữ nguyên như bản sql cũ)
    public DbSet<NguoiDung> NguoiDungs => Set<NguoiDung>();
    public DbSet<SanPham> SanPhams => Set<SanPham>();
    public DbSet<HoaDon> HoaDons => Set<HoaDon>();
    public DbSet<ChiTietHoaDon> ChiTietHoaDons => Set<ChiTietHoaDon>();
    public DbSet<PhieuNhapKho> PhieuNhapKhos => Set<PhieuNhapKho>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Directory.CreateDirectory(Folder);
        Options.UseSqlite($"Data Source={DbPath};");
    }
    //SQL không có kiểu decimal thật: lưu decimal dưới dạng REAL (giống schema cũ)
    protected override void Configureventions(ModelConfigurationBuilder builder)
    {
        builder.Properties<decimal>().HaveConversion<double>();
    }

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<NguoiDung>(e =>
        {
            e.ToTable("NguoiDung");
            e.HasIndex(x=>x.TenNguoiDung).IsUnique();
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
            e.HasOne(x => x.HoaDon).WithMany(x => x.MaHoaDon).HasForeignKey(x => x.MaHoaDon);
            //khong cho xoa san pham da phat sinh hoa don (giong hanh vi cu)
            e.HasOne<SanPham>().WithMany().HasForeignKey(x=>x.MaHoaDon).OnDelete(DeleteBehavior.Restrict);
        });
        mb.Entity<PhieuNhapKho>(e =>
        {
            e.ToTable("PhieuNhapKho");
            e.HasOne<SanPham>().WithMany().HasForeignKey(x => x.MaSanPham).OnDelete(DeleteBehavior.Restrict);
        });
        var ngay = new DateTime(2026, 01, 01);
        mb.Entity<NguoiDung>().HasData(new NguoiDung
        {
            Id = 1, TenNguoiDung = "admin", MatKhauBam =DichVuTaiKhoan.MatKhauBam("admin123") ,
            TenHienThi = "quan tri vien", VaiTro = "Admin", IsActive = true, DuocTaoVao = ngay
        });
        mb.Entity<SanPham>().HasData(
            new SanPham
            {
                Id = 1, Ma = "SP001", Ten = "Nuoc suoi 500ml", DonVi = "Chai", GiaVon = 4000, GiaBan = 7000,
                CoPhan = 50, TonKhoToiThieu = 10
            },
            new SanPham
            {
                Id = 2, Ma = "SP002", Ten = "Mi an lien", DonVi = "goi", GiaVon = 3500, GiaBan = 5000, CoPhan = 80,
                TonKhoToiThieu = 15
            },
            new SanPham
            {
                Id = 3, Ma = "SP003", Ten = "Banh quy", DonVi = "goi", GiaVon = 12000, GiaBan = 16000, CoPhan = 20,
                TonKhoToiThieu = 5
            },
            new SanPham
            {
                Id = 4, Ma = "SP004", Ten = "Sua tuoi", DonVi = "hop", GiaVon = 65000, GiaBan = 9000, CoPhan = 90,
                TonKhoToiThieu = 10
            });

    
    }

    public static void Khoitao()
    {
        using var db = new CoSoDuLieu();
        db.Database.EnsureCreated();
    }
}
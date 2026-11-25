using Microsoft.EntityFrameworkCore;
using MiniMart.Model;
using MiniMart.Services;

namespace MiniMart.Data;

public class CoSoDuLieu : DbContext
{
    private static readonly string Folder = Path.Combine(AppContext.BaseDirectory, "Data");
    

    public static string DbPath => Path.Combine(Folder, "minimart.db");

    public DbSet<NguoiDung> NguoiDungs => Set<NguoiDung>();
    public DbSet<SanPham> SanPhams => Set<SanPham>();
    public DbSet<HoaDon> HoaDons => Set<HoaDon>();
    public DbSet<ChiTietHoaDon> ChiTietHoaDons => Set<ChiTietHoaDon>();
    public DbSet<PhieuNhapKho> PhieuNhapKhos => Set<PhieuNhapKho>();
    public DbSet<KhachHang> KhachHangs => Set<KhachHang>();
    public DbSet<LichSuHoatDong> LichSuHoatDongs => Set<LichSuHoatDong>();
    public DbSet<LoHang> LoHangs => Set<LoHang>();
    public DbSet<KhuyenMai> KhuyenMais => Set<KhuyenMai>();
    public DbSet<CaLamViec> CaLamViecs => Set<CaLamViec>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        Directory.CreateDirectory(Folder);
        options.UseSqlite($"Data Source={DbPath}");
    }

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
        
        mb.Entity<KhachHang>(e =>
        {
            e.ToTable("KhachHang");
            e.HasIndex(x => x.SoDienThoai).IsUnique();
        });
        mb.Entity<LichSuHoatDong>().ToTable("LichSuHoatDong");
        mb.Entity<LoHang>(e =>
        {
            e.ToTable("LoHang");
            e.HasIndex(x => x.MaLo).IsUnique();
            e.HasOne(x => x.SanPham).WithMany().HasForeignKey(x => x.IdSanPham).OnDelete(DeleteBehavior.Restrict);
        });
        mb.Entity<KhuyenMai>(e => { e.ToTable("KhuyenMai"); e.HasIndex(x => x.MaCode).IsUnique(); });
        mb.Entity<CaLamViec>(e => e.ToTable("CaLamViec"));


        mb.Entity<HoaDon>(e =>
        {
            e.ToTable("HoaDon");
            e.HasIndex(x => x.MaHoaDon).IsUnique();
        });

        mb.Entity<ChiTietHoaDon>(e =>
        {
            e.ToTable("ChiTietHoaDon");
            e.HasOne(x => x.HoaDon).WithMany(x => x.Items).HasForeignKey(x => x.IdHoaDon);
         
            e.HasOne<SanPham>().WithMany().HasForeignKey(x => x.IdSanPham).OnDelete(DeleteBehavior.Restrict);
        });

        mb.Entity<PhieuNhapKho>(e =>
        {
            e.ToTable("PhieuNhapKho");
            e.HasOne<SanPham>().WithMany().HasForeignKey(x => x.MaSanPham).OnDelete(DeleteBehavior.Restrict);
        });

    
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
            new SanPham { Id = 1,  Ma = "SP001", Ten = "Nước suối 500ml",       DonVi = "Chai", GiaVon = 4000,  GiaBan = 7000,  SoLuongHangTon = 50, TonKhoToiThieu = 10 },
            new SanPham { Id = 2,  Ma = "SP002", Ten = "Mì ăn liền",            DonVi = "Gói",  GiaVon = 3500,  GiaBan = 5000,  SoLuongHangTon = 80, TonKhoToiThieu = 15 },
            new SanPham { Id = 3,  Ma = "SP003", Ten = "Bánh quy",              DonVi = "Gói",  GiaVon = 12000, GiaBan = 16000, SoLuongHangTon = 25, TonKhoToiThieu = 5 },
            new SanPham { Id = 4,  Ma = "SP004", Ten = "Sữa tươi",              DonVi = "Hộp",  GiaVon = 6500,  GiaBan = 9000,  SoLuongHangTon = 8,  TonKhoToiThieu = 10 },
            new SanPham { Id = 5,  Ma = "SP005", Ten = "Coca Cola 330ml",       DonVi = "Lon",  GiaVon = 7000,  GiaBan = 10000, SoLuongHangTon = 40, TonKhoToiThieu = 10 },
            new SanPham { Id = 6,  Ma = "SP006", Ten = "Pepsi 330ml",           DonVi = "Lon",  GiaVon = 7000,  GiaBan = 10000, SoLuongHangTon = 35, TonKhoToiThieu = 10 },
            new SanPham { Id = 7,  Ma = "SP007", Ten = "Trà xanh 0 độ",         DonVi = "Chai", GiaVon = 8000,  GiaBan = 12000, SoLuongHangTon = 30, TonKhoToiThieu = 10 },
            new SanPham { Id = 8,  Ma = "SP008", Ten = "Bánh Oreo",             DonVi = "Gói",  GiaVon = 9000,  GiaBan = 13000, SoLuongHangTon = 25, TonKhoToiThieu = 8 },
            new SanPham { Id = 9,  Ma = "SP009", Ten = "Bánh Chocopie",         DonVi = "Hộp",  GiaVon = 25000, GiaBan = 32000, SoLuongHangTon = 20, TonKhoToiThieu = 5 },
            new SanPham { Id = 10, Ma = "SP010", Ten = "Sữa đặc Ông Thọ",       DonVi = "Lon",  GiaVon = 18000, GiaBan = 23000, SoLuongHangTon = 15, TonKhoToiThieu = 5 },
            new SanPham { Id = 11, Ma = "SP011", Ten = "Nước tăng lực Red Bull",DonVi = "Lon",  GiaVon = 9000,  GiaBan = 13000, SoLuongHangTon = 30, TonKhoToiThieu = 10 },
            new SanPham { Id = 12, Ma = "SP012", Ten = "Khăn giấy",             DonVi = "Gói",  GiaVon = 5000,  GiaBan = 8000,  SoLuongHangTon = 50, TonKhoToiThieu = 10 },
            new SanPham { Id = 13, Ma = "SP013", Ten = "Mì Hảo Hảo",            DonVi = "Gói",  GiaVon = 3500,  GiaBan = 5000,  SoLuongHangTon = 100,TonKhoToiThieu = 20 },
            new SanPham { Id = 14, Ma = "SP014", Ten = "Nước rửa chén",         DonVi = "Chai", GiaVon = 15000, GiaBan = 20000, SoLuongHangTon = 20, TonKhoToiThieu = 5 });
    }

    
    public static void KhoiTao()
    {
        using (var db = new CoSoDuLieu())
        {
            db.Database.EnsureCreated();
            BoSungCotMoi(db);
            if (SchemaHopLe(db))
            {
                db.Dispose();
                NapDuLieuMau(); 
                return;
            }
        }

        Microsoft.Data.Sqlite.SqliteConnection.ClearAllPools();
        string sao = Path.Combine(Folder, $"minimart_cu_{DateTime.Now:yyyyMMddHHmmss}.db");
        File.Move(DbPath, sao);

        using (var moi = new CoSoDuLieu())
            moi.Database.EnsureCreated();
        NapDuLieuMau();
    }

    private static void BoSungCotMoi(CoSoDuLieu db)
    {
        ThemCotNeuThieu(db, "KhachHang", "HangThanhVien", "TEXT NOT NULL DEFAULT 'Thành viên mới'",
          
            "UPDATE \"KhachHang\" SET \"HangThanhVien\" = CASE " +
            "WHEN CAST(\"TongGiaTriMuaHang\" AS REAL) >= 10000000 THEN 'Kim cương' " +
            "WHEN CAST(\"TongGiaTriMuaHang\" AS REAL) >= 5000000 THEN 'Vàng' " +
            "WHEN CAST(\"TongGiaTriMuaHang\" AS REAL) >= 1000000 THEN 'Bạc' " +
            "ELSE 'Thành viên mới' END");
        
        ThemCotNeuThieu(db, "NguoiDung", "PhaiDoiMatKhau", "INTEGER NOT NULL DEFAULT 0", null);
    }

    private static void ThemCotNeuThieu(CoSoDuLieu db, string bang, string cot, string kieu, string? lenhSauKhiThem)
    {
        var conn = db.Database.GetDbConnection();
        conn.Open();
        try
        {
            bool coBang = false, coCot = false;
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = $"PRAGMA table_info(\"{bang}\")";
                using var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    coBang = true;
                    if (string.Equals(rd.GetString(1), cot, StringComparison.OrdinalIgnoreCase)) coCot = true;
                }
            }
            if (!coBang || coCot) return; 

            using var them = conn.CreateCommand();
            them.CommandText = $"ALTER TABLE \"{bang}\" ADD COLUMN \"{cot}\" {kieu}";
            them.ExecuteNonQuery();
            if (lenhSauKhiThem != null)
            {
                them.CommandText = lenhSauKhiThem;
                them.ExecuteNonQuery();
            }
        }
        finally { conn.Close(); }
    }


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

                if (cotThucTe.Count == 0) return false;                       
                if (cotModel.Any(c => !cotThucTe.ContainsKey(c!))) return false; 
                if (cotThucTe.Any(kv => !cotModel.Contains(kv.Key)
                                        && kv.Value.NotNull && !kv.Value.CoMacDinh && !kv.Value.KhoaChinh))
                    return false;                                             
            }
            return true;
        }
        finally { conn.Close(); }
    }

   
    public const string MatKhauMau = "123456";

    private static void NapDuLieuMau()
    {
        using var db = new CoSoDuLieu();
        DateTime homNay = DateTime.Today;

        NapTaiKhoan(db, homNay);
        NapKhachHang(db, homNay);
        NapKhuyenMai(db, homNay);
        NapLoHang(db, homNay);
        NapPhieuNhapKho(db, homNay);
        NapCaVaHoaDon(db, homNay);
        NapLichSuHoatDong(db, homNay);
    }

    private static void NapTaiKhoan(CoSoDuLieu db, DateTime homNay)
    {
        var mau = new[]
        {
            ("quanly2",   "Phạm Minh Đức",   "Quản Lý",   true),
            ("nhanvien2", "Trần Thị Bình",   "Nhân Viên", true),
            ("nhanvien3", "Lê Văn Cường",    "Nhân Viên", true),
            ("nhanvien4", "Ngô Thị Dung",    "Nhân Viên", false), 
        };
        foreach (var (ten, hoTen, vaiTro, hoatDong) in mau)
        {
            if (db.NguoiDungs.Any(x => x.TenNguoiDung == ten)) continue;
            db.NguoiDungs.Add(new NguoiDung
            {
                TenNguoiDung = ten, TenHienThi = hoTen, VaiTro = vaiTro, DangHoatDong = hoatDong,
                MatKhauBam = DichVuTaiKhoan.BamMatKhau(MatKhauMau), DuocTaoVao = homNay.AddDays(-20),
                PhaiDoiMatKhau = true
            });
        }

        var macDinh = new Dictionary<string, string>
        {
            ["quanly"] = DichVuTaiKhoan.BamMatKhau("quanly123"),
            ["nhanvien"] = DichVuTaiKhoan.BamMatKhau("nhanvien123"),
        };
        foreach (var u in db.NguoiDungs.Where(x => x.TenNguoiDung == "quanly" || x.TenNguoiDung == "nhanvien").ToList())
            if (macDinh[u.TenNguoiDung] == u.MatKhauBam) u.PhaiDoiMatKhau = true;

        db.SaveChanges();
    }

    private static void NapKhachHang(CoSoDuLieu db, DateTime homNay)
    {
        if (db.KhachHangs.Any()) return;
        db.KhachHangs.AddRange(
            new KhachHang { HoTen = "Nguyễn Văn An",   SoDienThoai = "0901234567", DiaChi = "12 Lê Lợi, Q.1, TP.HCM",        HangThanhVien = "Kim cương",      NgayTao = homNay.AddDays(-60) },
            new KhachHang { HoTen = "Trần Thị Bích",   SoDienThoai = "0912345678", DiaChi = "45 Nguyễn Trãi, Q.5, TP.HCM",   HangThanhVien = "Vàng",           NgayTao = homNay.AddDays(-45) },
            new KhachHang { HoTen = "Lê Hoàng Cường",  SoDienThoai = "0923456789", DiaChi = "",                              HangThanhVien = "Bạc",            NgayTao = homNay.AddDays(-30) },
            new KhachHang { HoTen = "Phạm Thu Hà",     SoDienThoai = "0934567890", DiaChi = "8 Hai Bà Trưng, Q.3, TP.HCM",   HangThanhVien = "Thành viên mới", NgayTao = homNay.AddDays(-20) },
            new KhachHang { HoTen = "Võ Minh Khang",   SoDienThoai = "0945678901", DiaChi = "",                              HangThanhVien = "Thành viên mới", NgayTao = homNay.AddDays(-10) },
            new KhachHang { HoTen = "Đặng Ngọc Lan",   SoDienThoai = "0956789012", DiaChi = "102 Cách Mạng Tháng 8, Q.10",   HangThanhVien = "Bạc",            NgayTao = homNay.AddDays(-5) });
        db.SaveChanges();
    }

   
    private static void NapKhuyenMai(CoSoDuLieu db, DateTime homNay)
    {
        if (db.KhuyenMais.Any()) return;
        DateTime CuoiNgay(DateTime d) => d.Date.AddDays(1).AddTicks(-1);
        db.KhuyenMais.AddRange(
          
            new KhuyenMai { MaCode = "SALE10",   TenKhuyenMai = "Giảm 10% mọi đơn",            LoaiGiam = "PhanTram", GiaTriGiam = 10,    DonHangToiThieu = 0,      TuNgay = homNay.AddDays(-7),  DenNgay = CuoiNgay(homNay.AddDays(30)), DangHoatDong = true },
            new KhuyenMai { MaCode = "GIAM20K",  TenKhuyenMai = "Giảm 20.000đ đơn từ 100.000đ", LoaiGiam = "SoTien",   GiaTriGiam = 20000, DonHangToiThieu = 100000, TuNgay = homNay.AddDays(-3),  DenNgay = CuoiNgay(homNay.AddDays(14)), DangHoatDong = true },
            new KhuyenMai { MaCode = "VIP15",    TenKhuyenMai = "Giảm 15% đơn từ 200.000đ",     LoaiGiam = "PhanTram", GiaTriGiam = 15,    DonHangToiThieu = 200000, TuNgay = homNay.AddDays(-1),  DenNgay = CuoiNgay(homNay.AddDays(60)), DangHoatDong = true },
           
            new KhuyenMai { MaCode = "TET2026",  TenKhuyenMai = "Khuyến mãi Tết (đã hết hạn)",  LoaiGiam = "PhanTram", GiaTriGiam = 20,    DonHangToiThieu = 0,      TuNgay = homNay.AddDays(-60), DenNgay = CuoiNgay(homNay.AddDays(-30)), DangHoatDong = true },
            new KhuyenMai { MaCode = "SAPTOI",   TenKhuyenMai = "Chương trình sắp diễn ra",     LoaiGiam = "SoTien",   GiaTriGiam = 10000, DonHangToiThieu = 50000,  TuNgay = homNay.AddDays(5),   DenNgay = CuoiNgay(homNay.AddDays(20)), DangHoatDong = true },
            new KhuyenMai { MaCode = "TAMNGUNG", TenKhuyenMai = "Mã đang tạm ngưng",            LoaiGiam = "PhanTram", GiaTriGiam = 5,     DonHangToiThieu = 0,      TuNgay = homNay.AddDays(-10), DenNgay = CuoiNgay(homNay.AddDays(10)), DangHoatDong = false });
        db.SaveChanges();
    }

   
    private static void NapLoHang(CoSoDuLieu db, DateTime homNay)
    {
        if (db.LoHangs.Any()) return;
       
        var mau = new[]
        {
            ("SP004", "LO-SUA-01",   10, 5,  -20, -2),   
            ("SP004", "LO-SUA-02",   10, 3,  -5,  5),    
            ("SP003", "LO-BANH-01",  20, 15, -30, 20),   
            ("SP001", "LO-NUOC-01",  30, 30, -10, 365),  
            ("SP002", "LO-MI-01",    50, 40, -15, 180),  
            ("SP010", "LO-SUADAC-01", 10, 10, -40, 300), 
        };
        foreach (var (ma, maLo, nhap, con, nsx, hsd) in mau)
        {
            var sp = db.SanPhams.FirstOrDefault(x => x.Ma == ma);
            if (sp == null) continue;
            int soLuongCon = Math.Min(con, sp.SoLuongHangTon); 
            db.LoHangs.Add(new LoHang
            {
                IdSanPham = sp.Id, MaLo = maLo, SoLuongNhap = Math.Max(nhap, soLuongCon), SoLuongConLai = soLuongCon,
                NgaySanXuat = homNay.AddDays(nsx), NgayHetHan = homNay.AddDays(hsd), NgayNhap = homNay.AddDays(nsx + 1)
            });
        }
        db.SaveChanges();
    }

    
    private static void NapPhieuNhapKho(CoSoDuLieu db, DateTime homNay)
    {
        if (db.PhieuNhapKhos.Any()) return;
        var ncc = new[]
        {
            ("NCC01", "Công ty TNHH Lavie",        "02838123456", "KCN Long Hậu, Long An",       "sales@lavie.vn"),
            ("NCC02", "Acecook Việt Nam",          "02838154064", "Lô II-3, KCN Tân Bình, TP.HCM", "info@acecookvietnam.vn"),
            ("NCC03", "Vinamilk",                  "19006061",    "10 Tân Trào, Q.7, TP.HCM",    "vinamilk@vinamilk.com.vn"),
            ("NCC04", "Đại lý Bánh kẹo Minh Phát", "0909111222",  "Chợ Bình Tây, Q.6, TP.HCM",   ""),
            ("NCC05", "Suntory PepsiCo",           "02838219437", "88 Đồng Khởi, Q.1, TP.HCM",   "lienhe@suntorypepsico.vn"),
        };
        
        var mau = new[]
        {
            ("SP001", 0, 48, -25, "Nhập đầu tháng"),
            ("SP002", 1, 60, -20, ""),
            ("SP004", 2, 20, -12, "Hàng lạnh, kiểm tra HSD"),
            ("SP003", 3, 24, -8,  ""),
            ("SP006", 4, 36, -4,  "Khuyến mãi tặng 1 thùng"),
            ("SP010", 2, 12, -2,  ""),
        };
        int i = 1;
        foreach (var (ma, n, sl, ngay, ghiChu) in mau)
        {
            var sp = db.SanPhams.FirstOrDefault(x => x.Ma == ma);
            if (sp == null) continue;
            var (maNcc, tenNcc, sdt, diaChi, email) = ncc[n];
            var thoiGian = homNay.AddDays(ngay).AddHours(8 + i);
            db.PhieuNhapKhos.Add(new PhieuNhapKho
            {
                MaBienNhan = $"PN{thoiGian:yyyyMMddHHmm}{i:00}", MaSanPham = sp.Id, SoLuong = sl, GiaVon = sp.GiaVon,
                DuocTaoVao = thoiGian, MaNhaCungCap = maNcc, TenNhaCungCap = tenNcc, SoDienThoaiNhaCungCap = sdt,
                DiaChiNhaCungCap = diaChi, EmailNhaCungCap = email, GhiChu = ghiChu
            });
            i++;
        }
        db.SaveChanges();
    }

    private static void NapCaVaHoaDon(CoSoDuLieu db, DateTime homNay)
    {
        bool napCa = !db.CaLamViecs.Any();
        bool napHoaDon = !db.HoaDons.Any();
        if (!napCa && !napHoaDon) return;

        var caMau = new[]
        {
            (-6, "nhanvien", 500000m,       0m, ""),
            (-5, "nhanvien", 500000m,  -20000m, "Thiếu 20.000đ, đã báo quản lý"),
            (-4, "quanly",   300000m,       0m, ""),
            (-3, "nhanvien", 500000m,   10000m, "Dư 10.000đ"),
            (-2, "quanly",   1000000m, -1000000m, "Rút tiền nộp ngân hàng: tiền đóng ca bé hơn tiền mở ca"),
        };
        var dsCa = new List<CaLamViec>();
        if (napCa)
        {
            foreach (var (ngay, nv, dau, _, ghiChu) in caMau)
            {
                var moCa = homNay.AddDays(ngay).AddHours(7);
                var ca = new CaLamViec
                {
                    MaCa = $"CA{moCa:yyyyMMddHHmm}", TenDangNhap = nv, GioMoCa = moCa, GioDongCa = moCa.AddHours(9),
                    TienDauCa = dau, GhiChu = ghiChu, DangMo = false
                };
                db.CaLamViecs.Add(ca);
                dsCa.Add(ca);
            }
            db.SaveChanges();
        }

        if (napHoaDon)
        {
            var sp = db.SanPhams.ToDictionary(x => x.Ma);
            var khach = db.KhachHangs.ToDictionary(x => x.SoDienThoai);
          
            var hdMau = new (int Ca, int Gio, string Sdt, string MaKm, decimal Giam, (string Ma, int Sl)[] Hang)[]
            {
                (0, 1, "0901234567", "",       0, new[] { ("SP001", 6), ("SP002", 10), ("SP005", 4) }),
                (0, 3, "",           "",       0, new[] { ("SP013", 5), ("SP012", 2) }),
                (1, 2, "0912345678", "SALE10", 0, new[] { ("SP009", 3), ("SP004", 4), ("SP007", 6) }),
                (1, 5, "0923456789", "",       5, new[] { ("SP003", 4), ("SP006", 6) }),
                (2, 1, "",           "",       0, new[] { ("SP011", 4), ("SP008", 2) }),
                (2, 4, "0901234567", "GIAM20K",0, new[] { ("SP014", 3), ("SP010", 2), ("SP002", 12) }),
                (3, 2, "0956789012", "",       0, new[] { ("SP005", 12), ("SP001", 12) }),
                (3, 6, "",           "",       0, new[] { ("SP007", 2) }),
                (4, 3, "0934567890", "SALE10", 0, new[] { ("SP009", 2), ("SP003", 2), ("SP012", 3) }),
            };
       
            var caTheoThuTu = dsCa;
            int stt = 1;
            foreach (var m in hdMau)
            {
                var ca = m.Ca < caTheoThuTu.Count ? caTheoThuTu[m.Ca] : null;
                var thoiGian = (ca?.GioMoCa ?? homNay.AddDays(-6 + m.Ca).AddHours(7)).AddHours(m.Gio).AddMinutes(stt * 7);
                var hd = new HoaDon { MaHoaDon = $"HD{thoiGian:yyyyMMddHHmm}{stt:00}", NgayLapHoaDon = thoiGian, IdCaLamViec = ca?.Id };

                foreach (var (ma, sl) in m.Hang)
                {
                    if (!sp.TryGetValue(ma, out var p)) continue;
                    hd.Items.Add(new ChiTietHoaDon
                    {
                        IdSanPham = p.Id, MaSanPham = p.Ma, TenSanPham = p.Ten, SoLuong = sl, DonGia = p.GiaBan,
                        ChietKhau = 0, ThanhTienDong = sl * p.GiaBan
                    });
                }
                if (hd.Items.Count == 0) continue;

                hd.TamTinh = hd.Items.Sum(x => x.ThanhTienDong);
                decimal sauGiam = hd.TamTinh * (1 - m.Giam / 100m);
                decimal giamKm = m.MaKm switch
                {
                    "SALE10" => Math.Round(sauGiam * 0.10m),
                    "GIAM20K" when hd.TamTinh >= 100000 => 20000m,
                    _ => 0m
                };
                hd.MaKhuyenMai = giamKm > 0 ? m.MaKm : "";
                hd.TongTien = Math.Max(0, sauGiam - giamKm);
                hd.ChietKhau = hd.TamTinh - hd.TongTien;
                hd.TienDaTra = Math.Ceiling(hd.TongTien / 50000m) * 50000m;
                hd.TienThua = hd.TienDaTra - hd.TongTien;

                if (m.Sdt.Length > 0 && khach.TryGetValue(m.Sdt, out var kh))
                {
                    hd.IdKhachHang = kh.Id; hd.tenKhachHang = kh.HoTen; hd.SDTkhachHang = kh.SoDienThoai;
                }
                else
                {
                    hd.tenKhachHang = "Khách lẻ"; hd.SDTkhachHang = "";
                }

                db.HoaDons.Add(hd);
                if (ca != null) ca.DoanhThu += hd.TongTien;
                stt++;
            }
            db.SaveChanges();

            foreach (var kh in khach.Values)
            {
                var ds = db.HoaDons.Where(x => x.IdKhachHang == kh.Id).ToList();
                if (ds.Count == 0) continue;
                kh.TongSoDonHang += ds.Count;
                kh.TongGiaTriMuaHang += ds.Sum(x => x.TongTien);
                kh.DiemTichLuy = (int)(kh.TongGiaTriMuaHang / 10000m);
                string hangMoi = KhachHang.HangTheoChiTieu(kh.TongGiaTriMuaHang);
                if (Array.IndexOf(KhachHang.DanhSachHang, hangMoi) > Array.IndexOf(KhachHang.DanhSachHang, kh.HangThanhVien))
                    kh.HangThanhVien = hangMoi;
            }
        }

        if (napCa)
            for (int i = 0; i < dsCa.Count; i++)
                dsCa[i].TienCuoiCa = Math.Max(0, dsCa[i].TienDauCa + dsCa[i].DoanhThu + caMau[i].Item4);

        db.SaveChanges();
    }

   
    private static void NapLichSuHoatDong(CoSoDuLieu db, DateTime homNay)
    {
        if (db.LichSuHoatDongs.Any()) return;
        db.LichSuHoatDongs.AddRange(
            new LichSuHoatDong { TenDangNhap = "quanly",   HanhDong = "Đăng nhập",       NoiDung = "Đăng nhập hệ thống thành công", ThoiGian = homNay.AddDays(-6).AddHours(7) },
            new LichSuHoatDong { TenDangNhap = "nhanvien", HanhDong = "Mở ca",           NoiDung = "Tiền đầu ca 500.000",           ThoiGian = homNay.AddDays(-6).AddHours(7).AddMinutes(5) },
            new LichSuHoatDong { TenDangNhap = "quanly",   HanhDong = "Nhập kho",        NoiDung = "Nước suối 500ml +48 (NCC01)",    ThoiGian = homNay.AddDays(-5).AddHours(9) },
            new LichSuHoatDong { TenDangNhap = "quanly",   HanhDong = "Tạo khuyến mãi",  NoiDung = "SALE10",                         ThoiGian = homNay.AddDays(-5).AddHours(10) },
            new LichSuHoatDong { TenDangNhap = "nhanvien", HanhDong = "Thêm khách hàng", NoiDung = "Đặng Ngọc Lan - 0956789012",     ThoiGian = homNay.AddDays(-4).AddHours(14) },
            new LichSuHoatDong { TenDangNhap = "quanly",   HanhDong = "Đóng ca",         NoiDung = "Rút tiền nộp ngân hàng",         ThoiGian = homNay.AddDays(-2).AddHours(16) },
            new LichSuHoatDong { TenDangNhap = "quanly",   HanhDong = "Khóa tài khoản",  NoiDung = "nhanvien4",                      ThoiGian = homNay.AddDays(-1).AddHours(8) });
        db.SaveChanges();
    }
}

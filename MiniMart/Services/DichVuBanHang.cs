using Microsoft.EntityFrameworkCore;
using MiniMart.Data;
using MiniMart.Model;

namespace MiniMart.Services;

public class DichVuBanHang
{
  
    public int ThanhToan(List<MatHangGioHang> items, decimal phanTramChietKhauTrenHoaDon, decimal tienDaTra,string tenKhachHang,String SDTkhachHang, string maKhuyenMai = "")
    {
        if (items.Count == 0) throw new InvalidOperationException("Giỏ hàng đang trống.");
        if (phanTramChietKhauTrenHoaDon is < 0 or > 100)
            throw new InvalidOperationException("Phần trăm chiết khấu phải từ 0 đến 100.");
        
        string tenKhach = (tenKhachHang ?? "").Trim();
        if (tenKhach.Length == 0) throw new InvalidOperationException("Vui lòng nhập tên khách hàng.");
        if (tenKhach.Length > 100) throw new InvalidOperationException("Tên khách hàng tối đa 100 ký tự.");
        string sdtKhach = ChuanHoaSoDienThoai(SDTkhachHang);
        
        decimal tamTinh = items.Sum(x => x.SoLuong * x.DonGia);
        decimal chietKhauSauDong = items.Sum(x => x.ThanhTienDong);
        decimal chietKhau = tamTinh - chietKhauSauDong + chietKhauSauDong * phanTramChietKhauTrenHoaDon / 100m;
        decimal tongTien = chietKhauSauDong * (1 - phanTramChietKhauTrenHoaDon / 100m);
        KhuyenMai? km = null;
        if (!string.IsNullOrWhiteSpace(maKhuyenMai))
        {
            km = new DichVuKhuyenMai().TimMaHopLe(maKhuyenMai, chietKhauSauDong);
            if (km == null) throw new InvalidOperationException("Mã khuyến mãi không hợp lệ, hết hạn hoặc chưa đạt đơn tối thiểu.");
            decimal giamKm = DichVuKhuyenMai.TinhTienGiam(km, tongTien);
            chietKhau += giamKm;
            tongTien = Math.Max(0, tongTien - giamKm);
        }
        if (tienDaTra < tongTien) throw new InvalidOperationException("Số tiền khách đưa chưa đủ.");
        
        using var db = new CoSoDuLieu();
        using var transaction = db.Database.BeginTransaction();
        string sdtTim = new((sdtKhach ?? "").Where(char.IsAsciiDigit).ToArray());
        var khach = db.KhachHangs.FirstOrDefault(x => x.SoDienThoai == sdtTim);
        if (khach == null)
        {
            khach = new KhachHang { HoTen = tenKhach, SoDienThoai = sdtTim, NgayTao = DateTime.Now };
            db.KhachHangs.Add(khach);
            db.SaveChanges(); 
        }
        else
        {
            khach.HoTen = tenKhach;
        }
        var ca = db.CaLamViecs.FirstOrDefault(x => x.TenDangNhap == MiniMart.Forms.FormDangNhap.hienThiTen && x.DangMo);
        if (ca == null) throw new InvalidOperationException("Bạn cần mở ca làm việc trước khi thanh toán.");

        var hoaDon = new HoaDon
        {
            MaHoaDon = "HD" + DateTime.Now.ToString("yyyyMMddHHmmssfff"),
            NgayLapHoaDon = DateTime.Now,
            TamTinh = tamTinh,
            ChietKhau = chietKhau,
            TongTien = tongTien,
            TienDaTra = tienDaTra,
            TienThua = tienDaTra - tongTien,
            tenKhachHang = tenKhach,
            SDTkhachHang  = sdtKhach,
            IdKhachHang = khach.Id, MaKhuyenMai = km?.MaCode ?? "", IdCaLamViec = ca.Id
        };

        foreach (var item in items)
        {
            var sp = db.SanPhams.Find(item.IdSanPham) ?? throw new InvalidOperationException($"Không tìm thấy sản phẩm {item.Ten}.");
            if (sp.SoLuongHangTon < item.SoLuong)
                throw new InvalidOperationException($"Sản phẩm {item.Ten} không đủ tồn kho. Còn {sp.SoLuongHangTon}.");
            
            var cacLo = db.LoHangs.Where(x => x.IdSanPham == sp.Id && x.SoLuongConLai > 0)
                .OrderBy(x => x.NgayHetHan).ThenBy(x => x.NgayNhap).ToList();
            if (cacLo.Count > 0)
            {
                int tongDaGanLo = cacLo.Sum(x => x.SoLuongConLai);
                int tonChuaGanLo = Math.Max(0, sp.SoLuongHangTon - tongDaGanLo);
                int tonLoConHan = cacLo.Where(x => x.NgayHetHan.Date >= DateTime.Today).Sum(x => x.SoLuongConLai);
                int coTheBan = tonChuaGanLo + tonLoConHan;
                if (coTheBan < item.SoLuong)
                    throw new InvalidOperationException($"Sản phẩm {item.Ten} không đủ hàng còn hạn sử dụng. Có thể bán: {coTheBan}.");
                int canTru = Math.Min(item.SoLuong, tonLoConHan);
                foreach (var lo in cacLo.Where(x => x.NgayHetHan.Date >= DateTime.Today).OrderBy(x => x.NgayHetHan).ThenBy(x => x.NgayNhap))
                {
                    if (canTru <= 0) break;
                    int tru = Math.Min(lo.SoLuongConLai, canTru);
                    lo.SoLuongConLai -= tru; canTru -= tru;
                }
            }
            sp.SoLuongHangTon -= item.SoLuong;
            hoaDon.Items.Add(new ChiTietHoaDon
            {
                IdSanPham = item.IdSanPham,
                MaSanPham = item.Ma,
                TenSanPham = item.Ten,
                SoLuong = item.SoLuong,
                DonGia = item.DonGia,
                ChietKhau = item.PhanTramChietKhau,
                ThanhTienDong = item.ThanhTienDong
            });
        }

        db.HoaDons.Add(hoaDon);
        db.SaveChanges();
        DichVuKhachHang.CapNhatSauMua(db, khach.Id, tongTien);
        DichVuCaLamViec.CongDoanhThu(db, ca.Id, tongTien);
        db.SaveChanges();
        transaction.Commit();
        DichVuLichSuHoatDong.Ghi("Bán hàng", $"Hóa đơn {hoaDon.MaHoaDon}; tổng {tongTien:N0}");
        return hoaDon.Id;
    }

    private string ChuanHoaSoDienThoai(string so)
    {
        string s = new((so ?? "").Where(c => !char.IsWhiteSpace(c) && c is not ('.' or '-' or '(' or ')')).ToArray());
        if (s.Length == 0) throw new InvalidOperationException("Vui lòng nhập số điện thoại khách hàng.");
        if (s.StartsWith("+84")) s = "0" + s[3..];
        else if (s.StartsWith("84") && s.Length >= 11) s = "0" + s[2..];
        if (!s.All(char.IsAsciiDigit) || s[0] != '0' || s.Length is < 10 or > 11)
            throw new InvalidOperationException("Số điện thoại không hợp lệ. Hãy nhập 10-11 chữ số, bắt đầu bằng số 0 (vd. 0912345678).");
        return s;
    }
    
    public List<HoaDon> LayLichSuHoaDon(DateTime tuNgay, DateTime denNgay, string tuKhoa = "")
    {
        using var db = new CoSoDuLieu();
        var batDau = tuNgay.Date;
        var ketThuc = denNgay.Date.AddDays(1);

        var danhSach = db.HoaDons.AsNoTracking()
            .Where(x => x.NgayLapHoaDon >= batDau && x.NgayLapHoaDon < ketThuc)
            .OrderByDescending(x => x.NgayLapHoaDon)
            .ToList();

        string k = (tuKhoa ?? "").Trim();
        if (k.Length == 0) return danhSach;
        
        return danhSach.Where(x => x.MaHoaDon.Contains(k, StringComparison.CurrentCultureIgnoreCase)
                                || x.tenKhachHang.Contains(k, StringComparison.CurrentCultureIgnoreCase)
                                || x.SDTkhachHang.Contains(k))
                       .ToList();
    }

    public List<ChiTietHoaDon> LayChiTietHoaDon(int idHoaDon)
    {
        using var db = new CoSoDuLieu();
        return db.ChiTietHoaDons.AsNoTracking()
            .Where(x => x.IdHoaDon == idHoaDon)
            .OrderBy(x => x.Id)
            .ToList();
    }

    public string XuatHoaDon(int maHoaDon)
    {
        using var db = new CoSoDuLieu();
        var h = db.HoaDons.AsNoTracking().FirstOrDefault(x => x.Id == maHoaDon)
                ?? throw new InvalidOperationException("Không tìm thấy hóa đơn");

        var lines = new List<string>
        {
            "MINIMART - HÓA ĐƠN BÁN HÀNG",
            "Mã hóa đơn: " + h.MaHoaDon,
            "Thời gian: "  + h.NgayLapHoaDon.ToString("yyyy-MM-dd  HH:mm:ss"),
            "Khách Hàng: " + h.tenKhachHang,
            "SDT:  "       + h.SDTkhachHang,
            "Mã khuyến mãi: " + (string.IsNullOrWhiteSpace(h.MaKhuyenMai) ? "Không áp dụng" : h.MaKhuyenMai),
            "------------------------------",
            $"Tạm tính:  {h.TamTinh:N0} VND",
            $"Giảm giá:  {h.ChietKhau:N0} VND",
            $"Tổng tiền: {h.TongTien:N0} VND",
            $"Khách đưa: {h.TienDaTra:N0} VND",
            $"Tiền thừa: {h.TienThua:N0} VND",
            "Cảm ơn quý khách!"
        };
        string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Biên lai MiniMart");
        Directory.CreateDirectory(folder);
        string path = Path.Combine(folder, h.MaHoaDon + ".txt");
        File.WriteAllLines(path, lines);
        return string.Join(Environment.NewLine, lines);
    }
}
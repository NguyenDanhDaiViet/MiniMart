using Microsoft.EntityFrameworkCore;
using MiniMart.Data;
using MiniMart.Model;

namespace MiniMart.Services;

public class DichVuBanHang
{
    public int ThanhToan(List<MatHangGioHang> items, decimal phanTramChietKhauTrenHoaDon, decimal tienDaTra,string tenKhachHang,String SDTkhachHang)
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
        if (tienDaTra < tongTien) throw new InvalidOperationException("Số tiền khách đưa chưa đủ.");
        
        using var db = new CoSoDuLieu();
        using var transaction = db.Database.BeginTransaction();

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
            SDTkhachHang  = sdtKhach
        };

        foreach (var item in items)
        {
            var sp = db.SanPhams.Find(item.IdSanPham) ?? throw new InvalidOperationException($"Không tìm thấy sản phẩm {item.Ten}.");
            if (sp.SoLuongHangTon < item.SoLuong)
                throw new InvalidOperationException($"Sản phẩm {item.Ten} không đủ tồn kho. Còn {sp.SoLuongHangTon}.");

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
        transaction.Commit();
        return hoaDon.Id;
    }

    private string ChuanHoaSoDienThoai(string so)
    {
        string s = new((so ?? "").Where(c => !char.IsWhiteSpace(c) && c is not ('.' or '-' or '(' or ')')).ToArray());
        if (s.Length == 0) throw new InvalidOperationException("Vui lòng nhập số điện thoại khách hàng.");
        if (s.StartsWith("+84")) s = "0" + s[3..];
        if (!s.All(char.IsAsciiDigit) || s[0] != '0' || s.Length is < 10 or > 11)
            throw new InvalidOperationException("Số điện thoại không hợp lệ. Hãy nhập 10-11 chữ số, bắt đầu bằng số 0 (vd. 0912345678).");
        return s;
    }

    // lichsu hoa don
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

        // Lọc không phân biệt chữ hoa thường kể cả chữ có dấu 
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
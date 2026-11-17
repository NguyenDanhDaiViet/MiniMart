using Microsoft.EntityFrameworkCore;
using MiniMart.Data;
using MiniMart.Model;

namespace MiniMart.Services;

public class DichVuBanHang
{
    public int ThanhToan(List<MatHangGioHang> items, decimal phanTramChietKhauTrenHoaDon, decimal tienDaTra)
    {
        if (items.Count == 0) throw new InvalidOperationException("Giỏ hàng đang trống.");
        if (phanTramChietKhauTrenHoaDon is < 0 or > 100)
            throw new InvalidOperationException("Phần trăm chiết khấu phải từ 0 đến 100.");

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
            TienThua = tienDaTra - tongTien
        };

        foreach (var item in items)
        {
            var sp = db.SanPhams.Find(item.IdSanPham) ?? throw new InvalidOperationException($"Không tìm thấy sản phẩm {item.Ten}.");
            if (sp.SoLuongHangTon < item.SoLuong)
                throw new InvalidOperationException(
                    $"Sản phẩm {item.Ten} không đủ tồn kho. Còn {item.SoLuongHangTon}.");

            sp.SoLuongHangTon -= item.SoLuong;
            hoaDon.Items.Add(new ChiTietHoaDon
            {
                IdSanPham = item.IdSanPham,
                MaSanPham = item.Ma,
                TenSanPham = item.Ten,
                SoLuong = item.SoLuong,
                DonGia = item.DonGia,
                ChietKhau = item.PhanTramChietKhau,
                ThanhTienDong = item.ThanhTienDong,
            });
        }

        db.HoaDons.Add(hoaDon);
        db.SaveChanges();
        transaction.Commit();
        return hoaDon.Id;
    }
    
    public string XuatHoaDon(int maHoaDon)
    {
        using var db = new CoSoDuLieu();
        var h = db.HoaDons.AsNoTracking().FirstOrDefault(x => x.Id == maHoaDon)
                ?? throw new InvalidOperationException("Không tìm thấy hóa đơn.");

        var lines = new List<string>
        {
            "MINIMART - HOA DON BAN HANG",
            "Ma hoa don: " + h.MaHoaDon,
            "Thoi gian: " + h.NgayLapHoaDon.ToString("yyyy-MM-dd HH:mm:ss"),
            "--------------------------------------",
            $"Tam tinh: {h.TamTinh:N0} VND",
            $"Giam gia: {h.ChietKhau:NO} VND",
            $"Tong tien {h.TongTien:N0} VND",
            $"Khach dua {h.TienDaTra:N0} VND",
            $"Tien thua {h.TienThua:N0} VND",
            "Cam on quy khach!"
        };
        string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Biên lai MiniMart");
        Directory.CreateDirectory(folder);
        string path = Path.Combine(folder, h.MaHoaDon + ".txt");
        File.WriteAllLines(path, lines);
        return path;
    }
}
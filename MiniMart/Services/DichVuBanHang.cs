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

        decimal tongPhu = items.Sum(x => x.SoLuong * x.DonGia);
        decimal chietKhauSauDong = items.Sum(x => x.ThanhTienDong);
        decimal chietKhau = tongPhu - chietKhauSauDong + chietKhauSauDong * phanTramChietKhauTrenHoaDon / 100m;
        decimal tongTien = chietKhauSauDong * (1 - phanTramChietKhauTrenHoaDon / 100m);
        if (tienDaTra < tongTien) throw new InvalidOperationException("Số tiền khách đưa chưa đủ.");

        var hoaDon = new HoaDon
        {
            MaHoaDon = "HD" + DateTime.Now.ToString("yyyyMMddHHmmssfff"),
            NgayLapHoaDon = DateTime.Now,
            TongPhu = tongPhu,
            ChietKhau = chietKhau,
            TongTien = tongTien,
            TienDaTra = tienDaTra,
            TienThua = tienDaTra - tongTien
        };
    }
}
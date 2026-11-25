using Microsoft.EntityFrameworkCore;
using MiniMart.Data;
using MiniMart.Model;

namespace MiniMart.Services;

public class DichVuBaoCao
{
    public (decimal Doanhthu, int Sohoadon) LayTongQuan(DateTime tuNgay, DateTime denNgay)
    {
        using var db = new CoSoDuLieu();
        var batDau = tuNgay.Date;
        var ketThuc = denNgay.AddDays(1);


        var tongTien = db.HoaDons.AsNoTracking()
            .Where(x => x.NgayLapHoaDon >= batDau && x.NgayLapHoaDon <= ketThuc)
            .Select(x => x.TongTien)
            .ToList();

        return (tongTien.Sum(), tongTien.Count);
    }

    public List<ThongKeSanPham> LayThongKeSanPham(DateTime tuNgay, DateTime denNgay)
    {
        using var db = new CoSoDuLieu();
        var batDau = tuNgay.Date;
        var ketThuc = denNgay.Date.AddDays(1);

        var dong = db.ChiTietHoaDons.AsNoTracking()
            .Join(db.HoaDons.AsNoTracking().Where(h => h.NgayLapHoaDon >= batDau && h.NgayLapHoaDon < ketThuc),
                ct => ct.IdHoaDon, h => h.Id,
                (ct, h) => new { ct.IdHoaDon, ct.IdSanPham, ct.MaSanPham, ct.TenSanPham, ct.SoLuong, ct.ThanhTienDong, TongTienHoaDon = h.TongTien })
            .ToList();

        var heSo = dong
            .GroupBy(x => x.IdHoaDon)
            .ToDictionary(g => g.Key, g =>
            {
                decimal sauChietKhauDong = g.Sum(x => x.ThanhTienDong);
                return sauChietKhauDong == 0 ? 1m : g.First().TongTienHoaDon / sauChietKhauDong;
            });

        return dong
            .GroupBy(x => x.IdSanPham)
            .Select(g => new ThongKeSanPham(
                g.Key,
                g.First().MaSanPham,
                g.First().TenSanPham,
                g.Sum(x => x.SoLuong),
                g.Sum(x => x.ThanhTienDong * heSo[x.IdHoaDon])))
            .ToList();
    }

    public List<(string Ten, int Cophan, int Tonkhotoithieu )> LaySanPhamSapHet()
    {
        using var db = new CoSoDuLieu();
        return db.SanPhams.AsNoTracking()
            .Where(x=>x.SoLuongHangTon <=x.TonKhoToiThieu)
            .OrderBy(x=> x.SoLuongHangTon)
            .Select(x=> new { x.Ten, x.SoLuongHangTon, x.TonKhoToiThieu})
            .ToList()
            .Select(x=>(x.Ten, x.SoLuongHangTon, x.TonKhoToiThieu))
            .ToList();
    }

    public List<(string Ten, int SoLuong)> LaySanPhamBanChay(DateTime tuNgay, DateTime denNgay)
    {
        using var db = new CoSoDuLieu();
        var batDau = tuNgay.Date;
        var ketThuc = denNgay.Date.AddDays(1);
        
        var dong = db.ChiTietHoaDons.AsNoTracking()
            .Join(db.HoaDons.AsNoTracking().Where(h => h.NgayLapHoaDon >= batDau && h.NgayLapHoaDon < ketThuc),
                ct => ct.IdHoaDon, h => h.Id,
                (ct, h) => new { ct.IdSanPham, ct.TenSanPham, ct.SoLuong })
            .ToList();

        return dong
            .GroupBy(x => x.IdSanPham)
            .Select(g => (Ten: g.First().TenSanPham, SoLuong: g.Sum(x => x.SoLuong)))
            .OrderByDescending(x => x.SoLuong)
            .ThenBy(x => x.Ten)
            .Take(10)
            .ToList();
    }
}
    

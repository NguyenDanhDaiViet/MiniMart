using Microsoft.EntityFrameworkCore;
using MiniMart.Data;

namespace MiniMart.Services;

public class DichVuBaoCao
{
    public (decimal Doanhthu, int Sohoadon) LayTongQuan(DateTime Tungay, DateTime Denngay)
    {
        using var db = new CoSoDuLieu();
        var start = Tungay.Date;
        var end = Denngay.AddDays(1);


        var totals = db.HoaDons.AsNoTracking()
            .Where(x => x.NgayLapHoaDon >= start && x.NgayLapHoaDon <= end)
            .Select(x => x.TongTien)
            .ToList();

        return (totals.Sum(), totals.Count);
    }

    public List<(String Ten, int Soluong)> LaySamPhamBanChay(DateTime Tungay, DateTime denNgay)
    {
        using var db = new CoSoDuLieu();
        var start = Tungay.Date;
        var end = denNgay.Date.AddDays(1);

        return db.ChiTietHoaDons.AsNoTracking()
            .Where(x => x.HoaDon!.NgayLapHoaDon >= start && x.HoaDon.NgayLapHoaDon < end)
            .GroupBy(x => new { x.IdSanPham, x.TenSanPham })
            .Select(g => new { g.Key.TenSanPham, Qty = g.Sum(x => x.SoLuong) })
            .OrderByDescending(x => x.Qty)
            .Take(10)
            .ToList()
            .Select(x=>(x.TenSanPham, x.Qty))
            .ToList();
    }

    public List<(string Ten, int Cophan, int Tonkhotoithieu )> LaySanPhamSapHet()
    {
        using var db = new CoSoDuLieu();
        return db.SanPhams.AsNoTracking()
            .Where(x=>x.CoPhan <=x.TonKhoToiThieu)
            .OrderBy(x=> x.CoPhan)
            .Select(x=> new { x.Ten, x.CoPhan, x.TonKhoToiThieu})
            .ToList()
            .Select(x=>(x.Ten, x.CoPhan, x.TonKhoToiThieu))
            .ToList();
    }
}
    

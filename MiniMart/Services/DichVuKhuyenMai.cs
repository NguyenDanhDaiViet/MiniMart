using Microsoft.EntityFrameworkCore;
using MiniMart.Data;
using MiniMart.Model;
namespace MiniMart.Services;
public class DichVuKhuyenMai
{
    public List<KhuyenMai> LayDanhSach(string key = "")
    {
        using var db = new CoSoDuLieu();
        string k = (key ?? "").Trim();

        var ds = db.KhuyenMais.AsNoTracking()
            .OrderByDescending(x => x.TuNgay)
            .ToList();

        if (k == "") return ds;

        return ds.Where(x => x.MaCode.Contains(k, StringComparison.OrdinalIgnoreCase)
                             || x.TenKhuyenMai.Contains(k, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
    public void Luu(KhuyenMai km)
    {
        km.MaCode=(km.MaCode??"").Trim().ToUpperInvariant();
        km.TenKhuyenMai=(km.TenKhuyenMai??"").Trim();
        
        if(km.MaCode.Length==0||km.TenKhuyenMai.Length==0) throw new InvalidOperationException("Vui lòng nhập mã và tên khuyến mãi.");
        
        if((km.LoaiGiam != "PhanTram" && km.LoaiGiam != "SoTien") || km.GiaTriGiam<=0 || (km.LoaiGiam=="PhanTram" && km.GiaTriGiam>100) || km.DonHangToiThieu<0)
            throw new InvalidOperationException("Giá trị giảm không hợp lệ.");
        
        if(km.DenNgay<km.TuNgay) throw new InvalidOperationException("Ngày kết thúc phải sau ngày bắt đầu.");
        
        using var db=new CoSoDuLieu();
        if(db.KhuyenMais.Any(x=>x.Id!=km.Id&&x.MaCode==km.MaCode)) throw new InvalidOperationException("Mã khuyến mãi đã tồn tại.");
        
        var e=km.Id==0?new KhuyenMai():db.KhuyenMais.Find(km.Id)??throw new InvalidOperationException("Không tìm thấy khuyến mãi.");
        
        if(km.Id==0) db.KhuyenMais.Add(e);
        
        e.MaCode=km.MaCode;
        e.TenKhuyenMai=km.TenKhuyenMai;
        e.LoaiGiam=km.LoaiGiam;
        e.GiaTriGiam=km.GiaTriGiam;
        e.DonHangToiThieu=km.DonHangToiThieu;
        e.TuNgay=km.TuNgay;
        e.DenNgay=km.DenNgay;
        e.DangHoatDong=km.DangHoatDong;
        
        db.SaveChanges();
        
        DichVuLichSuHoatDong.Ghi(km.Id==0?"Tạo khuyến mãi":"Sửa khuyến mãi",km.MaCode);
    }

    public void Xoa(int id)
    {
        using var db = new CoSoDuLieu();
        var km = db.KhuyenMais.Find(id) ?? throw new InvalidOperationException("Không tìm thấy mã khuyến mãi.");
        db.KhuyenMais.Remove(km);
        db.SaveChanges();
        DichVuLichSuHoatDong.Ghi("Xóa khuyến mãi", km.MaCode);
    }

    public KhuyenMai? TimMaHopLe(string ma, decimal tamTinh)
    {
        using var db=new CoSoDuLieu(); string code=(ma??"").Trim().ToUpperInvariant();
        var km=db.KhuyenMais.AsNoTracking().
            FirstOrDefault(x=>x.MaCode==code&&x.DangHoatDong&&x.TuNgay<=DateTime.Now&&x.DenNgay>=DateTime.Now);
        
        if(km==null)return null; 
        return tamTinh>=km.DonHangToiThieu? km: null;
    }
    public static decimal TinhTienGiam(KhuyenMai km, decimal tamTinh) => Math.Min(tamTinh, km.LoaiGiam=="PhanTram"?tamTinh*km.GiaTriGiam/100m:km.GiaTriGiam);
}

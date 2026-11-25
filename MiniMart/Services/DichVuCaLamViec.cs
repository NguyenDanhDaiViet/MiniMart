using Microsoft.EntityFrameworkCore;
using MiniMart.Data;
using MiniMart.Forms;
using MiniMart.Model;
namespace MiniMart.Services;

public class DichVuCaLamViec
{
    public CaLamViec? LayCaDangMo(string user)
    {
        using var db=new CoSoDuLieu(); 
        return db.CaLamViecs.AsNoTracking().FirstOrDefault(x=> x.TenDangNhap == user && x.DangMo);
    }
    
    public void MoCa(decimal tienDau)
    { 
        if (tienDau<0) throw new InvalidOperationException("Tiền đầu ca không được âm."); 
        using var db = new CoSoDuLieu();
        string u = FormDangNhap.hienThiTen; 
        
        if(db.CaLamViecs.Any(x=> x.TenDangNhap == u && x.DangMo))
            throw new InvalidOperationException("Bạn đang có ca chưa đóng."); 
        db.CaLamViecs.Add(new CaLamViec{MaCa = "CA" + DateTime.Now.ToString("yyyyMMddHHmmssfff"),TenDangNhap = u,TienDauCa = tienDau,GioMoCa = DateTime.Now, DangMo = true});
        db.SaveChanges();
        DichVuLichSuHoatDong.Ghi("Mở ca",$"Tiền đầu ca: {tienDau:N0}"); 
    }
    
    public void DongCa(decimal tienCuoi, string ghiChu ="")
    { 
        using var db = new CoSoDuLieu();
        string u = FormDangNhap.hienThiTen;
        var ca = db.CaLamViecs.FirstOrDefault(x=> x.TenDangNhap == u && x.DangMo)
               ?? throw new InvalidOperationException("Không có ca đang mở."); 
        
        if(tienCuoi<0) throw new InvalidOperationException("Tiền cuối ca không được âm."); 
            ca.TienCuoiCa = tienCuoi;
            ca.GhiChu = ghiChu;
            ca.GioDongCa=DateTime.Now;
            ca.DangMo=false;db.SaveChanges();
            
        DichVuLichSuHoatDong.Ghi("Đóng ca",$"Doanh thu {ca.DoanhThu:N0}; tiền cuối ca {tienCuoi:N0}");
    }
    
    public List<CaLamViec> LayDanhSach(DateTime tu, DateTime den) { 
        using var db = new CoSoDuLieu();
        return db.CaLamViecs.AsNoTracking()
            .Where(x=> x.GioMoCa >= tu.Date && x.GioMoCa < den.Date.AddDays(1))
            .OrderByDescending(x=> x.GioMoCa)
            .ToList(); 
    }
    
    public static void CongDoanhThu(CoSoDuLieu db, int? idCa, decimal tong) 
    { 
        if (idCa.HasValue){
            var ca = db.CaLamViecs.Find(idCa.Value);
            
        if (ca!=null && ca.DangMo)
            ca.DoanhThu += tong;
        }
    }
}

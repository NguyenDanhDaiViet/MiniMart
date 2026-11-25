using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using MiniMart.Data;
using MiniMart.Model;

namespace MiniMart.Services;

public class DichVuSanPham
{
    public List<SanPham> LayTatCa(string keywork = "")
    {
        using var db = new CoSoDuLieu();
        string q = $"%{keywork}%";
        return db.SanPhams.AsNoTracking()
            .Where(x=>EF.Functions.Like(x.Ma,q)|| EF.Functions.Like(x.Ten,q))
            .OrderBy(x=>x.Ten)
            .ToList();
    }

    public SanPham? layTheoMa(string ma)
    {
        using var db = new CoSoDuLieu();
        string c = ma.Trim().ToLower();
        return db.SanPhams.AsNoTracking().FirstOrDefault(x=>x.Ma.ToLower() == c) ;
    }

    public void LuuSp(SanPham sp)
    {
        if (string.IsNullOrWhiteSpace(sp.Ma) || string.IsNullOrWhiteSpace(sp.Ten))
            throw new InvalidOleVariantTypeException("Mã và tên sản phẩm không được để trống.");
        
        if(sp.GiaVon<=0 || sp.GiaBan<=0 || sp.GiaBan<=sp.GiaVon || sp.TonKhoToiThieu<0 || sp.SoLuongHangTon<0)
            throw new InvalidOleVariantTypeException("Giá nhập phải lớn hơn 0; giá bán phải lớn hơn giá nhập; số lượng không được âm.");
        
        using var db = new CoSoDuLieu();
        bool laThemMoi = sp.Id == 0;
        string ma = sp.Ma.Trim();
        if(db.SanPhams.Any(x=>x.Id !=sp.Id && x.Ma.ToLower()==ma.ToLower()))
            throw new InvalidOleVariantTypeException("Mã sản phẩm đã tồn tại.");

        SanPham entity;
        if (sp.Id == 0)
        {
            entity = new SanPham();
            db.SanPhams.Add(entity);
        }
        else
        {
            entity = db.SanPhams.Find(sp.Id) ?? throw new InvalidOleVariantTypeException("Không tìm thấy sản phẩm");;
        }
        entity.Ma = ma;
        entity.Ten = sp.Ten.Trim();
        entity.DonVi = sp.DonVi.Trim();
        entity.GiaBan = sp.GiaBan;
        entity.GiaVon = sp.GiaVon;
        entity.SoLuongHangTon = sp.SoLuongHangTon;
        entity.TonKhoToiThieu = sp.TonKhoToiThieu;
        db.SaveChanges();
        DichVuLichSuHoatDong.Ghi(laThemMoi ? "Thêm sản phẩm" : "Cập nhật sản phẩm", sp.Ma + " - " + sp.Ten);
    }

    public void Xoa(int id)
    {
        using var db = new CoSoDuLieu();
        var sp = db.SanPhams.AsNoTracking().FirstOrDefault(x => x.Id == id);
        db.SanPhams.Where(x => x.Id == id).ExecuteDelete();
        if (sp != null) DichVuLichSuHoatDong.Ghi("Xóa sản phẩm", sp.Ma + " - " + sp.Ten);
    }
}
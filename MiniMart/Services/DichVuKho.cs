using MiniMart.Data;
using MiniMart.Model;

namespace MiniMart.Services;

public class DichVuKho
{
    public void NhapKho(int IdSanPham, int SoLuong, decimal GiaVon)
    {
        if (SoLuong <= 0 || GiaVon < 0)
        {
            throw new InvalidOperationException("Số lượng nhập phải lớn hơn 0 và giá nhập không được âm");
        }

        using var db = new CoSoDuLieu();
        var sp = db.SanPhams.Find(IdSanPham)?? throw new InvalidOperationException("Không tìm thấy sản phẩm");
        
        sp.TonKho += SoLuong;
        sp.GiaBan = GiaVon;
        db.PhieuNhapKhos.Add(new PhieuNhapKho
        {
            MaBienNhan = "PN" + DateTime.Now.ToString("yyyyMMddHHmmss"),
            MaSanPham = IdSanPham,
            SoLuong = SoLuong,
            GiaVon = GiaVon,
            DuocTaoVao = DateTime.Now
        });
        db.SaveChanges();
    }
}
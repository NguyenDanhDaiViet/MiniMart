using Microsoft.EntityFrameworkCore;
using MiniMart.Data;
using MiniMart.Model;
namespace MiniMart.Services;

public class DichVuHanSuDung
{
    public void TaoLo(int idSp, string maLo, int soLuong, DateTime? nsx, DateTime hsd)
    {
        if (soLuong <= 0) throw new InvalidOperationException("Số lượng lô phải lớn hơn 0.");
        if (hsd.Date < DateTime.Today) throw new InvalidOperationException("Hạn sử dụng không thể ở quá khứ.");
        if (nsx.HasValue && nsx.Value.Date > hsd.Date) throw new InvalidOperationException("Ngày sản xuất không được sau hạn sử dụng.");
        
        using var db = new CoSoDuLieu();
        var sanPham = db.SanPhams.Find(idSp) ?? throw new InvalidOperationException("Không tìm thấy sản phẩm.");
        
        int daTheoDoi = db.LoHangs.
            Where(x=> x.IdSanPham == idSp).
            Sum(x=> x.SoLuongConLai);
        
        if (daTheoDoi + soLuong > sanPham.SoLuongHangTon)
            throw new InvalidOperationException("Số lượng lô vượt quá tồn kho chưa được phân lô. Hãy nhập kho hoặc kiểm tra lại số lượng.");
        
        string maChuan = string.IsNullOrWhiteSpace(maLo) ? "LO" +DateTime.Now.ToString("yyyyMMddHHmmssfff"):maLo.Trim();
        
        if (db.LoHangs.Any(x=> x.MaLo == maChuan)) throw new InvalidOperationException("Mã lô đã tồn tại.");
        
        db.LoHangs.Add(new LoHang
        {
            IdSanPham = idSp,
            MaLo = maChuan,
            SoLuongNhap = soLuong,
            SoLuongConLai = soLuong,
            NgaySanXuat = nsx,
            NgayHetHan = hsd
        });
        db.SaveChanges();
        
        DichVuLichSuHoatDong.Ghi("Tạo lô hàng",maLo); 
    }
    
    public void Xoa(string maLo)
    {
        using var db = new CoSoDuLieu();
        
        var lo = db.LoHangs.FirstOrDefault(x => x.MaLo == maLo) ?? throw new InvalidOperationException("Không tìm thấy lô hàng.");
        
        if (lo.SoLuongConLai != lo.SoLuongNhap)
            throw new InvalidOperationException("Lô này đã phát sinh xuất bán hoặc điều chỉnh. Không thể xóa để bảo toàn lịch sử tồn kho.");
        
        db.LoHangs.Remove(lo); 
        db.SaveChanges();
        
        DichVuLichSuHoatDong.Ghi("Xóa lô hàng", maLo);
    }

    public List<LoHang> LayDanhSach(string key = "")
    {
        using var db=new CoSoDuLieu();
        var list=db.LoHangs.Include(x=>x.SanPham).
            AsNoTracking().OrderBy(x=>x.NgayHetHan).
            ToList();
        
        string k = (key??"").Trim();
        return k == ""? list : list.
            Where(x=> x.MaLo.Contains(k,StringComparison.CurrentCultureIgnoreCase) || (x.SanPham?.Ten??"").
                Contains(k,StringComparison.CurrentCultureIgnoreCase)).
            ToList();
    }
    
    public static string TrangThai(LoHang lo) => lo.NgayHetHan.Date<DateTime.Today? "ĐÃ QUÁ HẠN" : lo.NgayHetHan.Date <= DateTime.Today.AddDays(30) ? "SẮP HẾT HẠN" : "Còn hạn";
}

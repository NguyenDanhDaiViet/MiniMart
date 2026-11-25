using Microsoft.EntityFrameworkCore;
using MiniMart.Data;
using MiniMart.Model;
namespace MiniMart.Services;

public class DichVuKhachHang
{
    public List<KhachHang> LayDanhSach(string tuKhoa = "")
    {
        using var db = new CoSoDuLieu(); string k = (tuKhoa ?? "").Trim();
        return db.KhachHangs.AsNoTracking().Where(x => k == "" || x.HoTen.Contains(k) || x.SoDienThoai.Contains(k)).OrderBy(x => x.HoTen).ToList();
    }
    public void Luu(KhachHang kh)
    {
        string ten = (kh.HoTen ?? "").Trim(); string sdt = new((kh.SoDienThoai ?? "").
            Where(char.IsAsciiDigit).
            ToArray());
        
        if (sdt.StartsWith("84")) sdt = "0" + sdt[2..];
        
        if (ten.Length == 0) throw new InvalidOperationException("Vui lòng nhập họ tên khách hàng.");
        if (sdt.Length is < 10 or > 11) throw new InvalidOperationException("Số điện thoại phải có 10-11 chữ số.");
        
        using var db = new CoSoDuLieu();
        
        if (db.KhachHangs.Any(x => x.Id != kh.Id && x.SoDienThoai == sdt)) throw new InvalidOperationException("Số điện thoại đã tồn tại.");
        
        KhachHang e = kh.Id == 0 ? new KhachHang() : db.KhachHangs.Find(kh.Id) ?? throw new InvalidOperationException("Không tìm thấy khách hàng.");
        
        if (kh.Id == 0) db.KhachHangs.Add(e);
        e.HoTen = ten; e.SoDienThoai = sdt;
        e.DiaChi = (kh.DiaChi ?? "").Trim(); 
        e.HangThanhVien = KhachHang.DanhSachHang.Contains(kh.HangThanhVien) ? kh.HangThanhVien : KhachHang.DanhSachHang[0];
        db.SaveChanges();
        if (kh.Id == 0)
        {
            var hoaDonsCu = db.HoaDons.Where(x => x.IdKhachHang == null && x.SDTkhachHang == sdt).ToList();
            foreach (var hd in hoaDonsCu) hd.IdKhachHang = e.Id;
            e.TongSoDonHang = hoaDonsCu.Count;
            e.TongGiaTriMuaHang = hoaDonsCu.Sum(x => x.TongTien);
            e.DiemTichLuy = (int)(e.TongGiaTriMuaHang / 10000m);
            db.SaveChanges();
        }
        DichVuLichSuHoatDong.Ghi(kh.Id == 0 ? "Thêm khách hàng" : "Sửa khách hàng", ten + " - " + sdt);
    }

    public void Xoa(int id)
    {
        using var db = new CoSoDuLieu();
        
        var kh = db.KhachHangs.Find(id) ?? throw new InvalidOperationException("Không tìm thấy khách hàng.");
        var hoaDons = db.HoaDons.Where(x => x.IdKhachHang == id).ToList();
        foreach (var hd in hoaDons) hd.IdKhachHang = null; 
        db.KhachHangs.Remove(kh);
        
        db.SaveChanges();
        DichVuLichSuHoatDong.Ghi("Xóa khách hàng", kh.HoTen + " - " + kh.SoDienThoai);
    }

    public KhachHang? TimTheoSoDienThoai(string sdt)
    {
        using var db = new CoSoDuLieu();
        
        string n = new((sdt ?? "").
            Where(char.IsAsciiDigit).
            ToArray());
        
        if (n.StartsWith("84")) n = "0" + n[2..];
        
        return db.KhachHangs.AsNoTracking().FirstOrDefault(x => x.SoDienThoai == n);
    }
    public List<HoaDon> LayLichSuMua(int id)
    {
        using var db = new CoSoDuLieu();
        return db.HoaDons.AsNoTracking().
            Where(x => x.IdKhachHang == id).
            OrderByDescending(x => x.NgayLapHoaDon).
            ToList();
    }
    public static void CapNhatSauMua(CoSoDuLieu db, int idKhachHang, decimal tongTien)
    {
        var kh = db.KhachHangs.Find(idKhachHang);
        if (kh == null) return;
        kh.TongSoDonHang++;
        kh.TongGiaTriMuaHang += tongTien;
        kh.DiemTichLuy = (int)(kh.TongGiaTriMuaHang / 10000m);
      
        string hangMoi = KhachHang.HangTheoChiTieu(kh.TongGiaTriMuaHang);
        if (Array.IndexOf(KhachHang.DanhSachHang, hangMoi) > Array.IndexOf(KhachHang.DanhSachHang, kh.HangThanhVien))
            kh.HangThanhVien = hangMoi;
    }
}

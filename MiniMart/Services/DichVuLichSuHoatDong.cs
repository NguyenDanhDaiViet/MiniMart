using Microsoft.EntityFrameworkCore;
using MiniMart.Data;
using MiniMart.Forms;
using MiniMart.Model;
namespace MiniMart.Services;

public class DichVuLichSuHoatDong
{
    public static void Ghi(string hanhDong, string noiDung = "")
    {
        try
        {
            using var db = new CoSoDuLieu();
            db.LichSuHoatDongs.Add(new LichSuHoatDong
            {
                TenDangNhap = FormDangNhap.hienThiTen, HanhDong = hanhDong, NoiDung = noiDung, ThoiGian = DateTime.Now
            });
            db.SaveChanges();
        }
        catch { /* Không để lỗi nhật ký chặn bán hàng/nhập kho. */ }
    }
    public List<LichSuHoatDong> LayDanhSach(DateTime tu, DateTime den, string tuKhoa = "")
    {
        using var db = new CoSoDuLieu();
        var q = db.LichSuHoatDongs.AsNoTracking().
            Where(x => x.ThoiGian >= tu.Date && x.ThoiGian < den.Date.AddDays(1));
        
        string k = (tuKhoa ?? "").Trim();
        if (k.Length > 0) q = q.Where(x => x.TenDangNhap.Contains(k) || x.HanhDong.Contains(k) || x.NoiDung.Contains(k));
        
        return q.OrderByDescending(x => x.ThoiGian).Take(3000).ToList();
    }
}
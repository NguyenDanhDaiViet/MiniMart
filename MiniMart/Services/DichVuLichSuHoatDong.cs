using System.Globalization;
using System.Text;
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
        
        var ds = db.LichSuHoatDongs.AsNoTracking()
            .Where(x => x.ThoiGian >= tu.Date && x.ThoiGian < den.Date.AddDays(1))
            .OrderByDescending(x => x.ThoiGian)
            .ToList();
        
        string k = BoDau(tuKhoa);
        if (k.Length > 0)
            ds = ds.Where(x => BoDau(x.TenDangNhap).Contains(k)
                               || BoDau(x.HanhDong).Contains(k)
                               || BoDau(x.NoiDung).Contains(k))
                .ToList();

        return ds.Take(3000).ToList();
    }
    public static string BoDau(string? s)
    {
        if (string.IsNullOrWhiteSpace(s)) return "";
        string chuan = s.Trim().ToLowerInvariant().Normalize(NormalizationForm.FormD);
        var sb = new StringBuilder();
        foreach (char c in chuan)
            if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                sb.Append(c);
        return sb.ToString().Replace('đ', 'd');
    }
}
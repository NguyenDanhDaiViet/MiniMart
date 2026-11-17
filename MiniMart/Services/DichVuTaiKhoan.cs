using System.Data;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MiniMart.Data;
using MiniMart.Model;

namespace MiniMart.Services;

public class DichVuTaiKhoan
{
    public static string BamMatKhau(String value) => Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(value)));

    public static bool DangNhap(String tenNguoiDung, String matKhau, out string tenHienThi, out string vaiTro)
    {
        tenHienThi = "";vaiTro = "";
        using var db = new CoSoDuLieu();
        string nguoiDung = tenNguoiDung.Trim();
        string pass = BamMatKhau(matKhau);
        var user = db.NguoiDungs.AsNoTracking()
            .FirstOrDefault(x => x.TenNguoiDung == nguoiDung && x.MatKhauBam == pass && x.DangHoatDong);
        if (user == null) return false;
        tenHienThi = user.TenHienThi;
        vaiTro = user.VaiTro;
        return true;

    }

    public static DataTable LayTatCa(string timKiem = "")
    {
        using var db = new CoSoDuLieu();
        string s = $"%{timKiem}%";
        var user = db.NguoiDungs.AsNoTracking()
            .Where(x => EF.Functions.Like(x.TenNguoiDung, s) || EF.Functions.Like(x.TenHienThi, s))
            .OrderBy(x => x.Id)
            .ToList();
        var table = new DataTable();
        table.Columns.Add("ID", typeof(int));
        table.Columns.Add("TenNguoiDung", typeof(string));
        table.Columns.Add("TenHienThi", typeof(string));
        table.Columns.Add("VaiTro", typeof(string));
        table.Columns.Add("Trạng thái", typeof(string));
        foreach (var u in user)
            table.Rows.Add(u.Id, u.TenNguoiDung, u.TenHienThi, u.VaiTro, u.DangHoatDong ? "Hoạt động" : "Đã khóa");
        return table;
    }

    public static void Luu(int id, string tenNguoiDung, string tenHienThi, string vaiTro, string matKhau)
    {
        if (string.IsNullOrWhiteSpace(tenNguoiDung) || string.IsNullOrWhiteSpace(tenHienThi))
            throw new Exception("Vui lòng nhập tên đăng nhập và họ tên.");
        
        using var db = new CoSoDuLieu();
        string u = tenNguoiDung.Trim();
        if (db.NguoiDungs.Any(x => x.Id != id && x.TenNguoiDung == u))
            throw new Exception("Tên đăng nhập đã tồn tại.");

        NguoiDung user;
        if (id == 0)
        {
            if(string.IsNullOrWhiteSpace(matKhau)) throw new Exception("Tài khoản mới cần có mật khẩu.");
            user = new NguoiDung{ MatKhauBam = BamMatKhau(matKhau), DangHoatDong = true, DuocTaoVao = DateTime.Now };
            db.NguoiDungs.Add(user);
        }
        else
        {
            user = db.NguoiDungs.Find(id) ?? throw new Exception("Không tìm thấy tài khoản.");
            if(!string.IsNullOrWhiteSpace(matKhau)) user.MatKhauBam = BamMatKhau(matKhau);
        }

        user.TenNguoiDung = u;
        user.TenHienThi = tenHienThi.Trim();
        user.VaiTro = vaiTro;
        db.SaveChanges();
    }

    public static void ChuyenTrangThaiHoatDong(int id)
    {
        using var db = new CoSoDuLieu();
        var user = db.NguoiDungs.FirstOrDefault(x=>x.Id==id && x.TenNguoiDung !="quanLy");
        if(user == null) return;
        user.DangHoatDong = !user.DangHoatDong;
        db.SaveChanges();
    }
}
namespace MiniMart.Model;

public sealed class TaiKhoanNguoiDung
{
    public int Id { get; set; }
    public string TenTaiKhoan { get; set; } = "";
    public string HoVaTen { get; set; } = "";
    public string VaiTro { get; set; } = "Người lao động";
    public bool CoHoatDong { get; set; } 
    public string HienThiVaiTro => VaiTro == "Admin" ? "Quản trị viên" : "Nhân viên";
    public string HienThiTrangThai => CoHoatDong ? "Đang hoạt động" : "Đã khóa";
}
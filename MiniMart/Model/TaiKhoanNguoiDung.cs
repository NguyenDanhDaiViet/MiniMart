namespace MiniMart.Model;

public sealed class TaiKhoanNguoiDung
{
    public int Id { get; set; }
    public string TenTaiKhoan { get; set; } = "";
    public string HoVaTen { get; set; } = "";
    public string VaiTro { get; set; } = "";
    public bool CoHoatDong { get; set; } 
    public string HienThiTrangThai { get; set; } = "";
}
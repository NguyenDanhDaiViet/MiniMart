namespace MiniMart.Model;

public class NguoiDung
{
    public int Id { get; set; }
    public string TenNguoiDung { get; set; } = "";
    public string MatKhauBam { get; set; } = "";
    public string TenHienThi { get; set; } = "";
    public string VaiTro { get; set; } = "Nhân viên";
    public bool DangHoatDong { get; set; } = true;
    public DateTime DuocTaoVao { get; set; }= DateTime.Now;
    
}
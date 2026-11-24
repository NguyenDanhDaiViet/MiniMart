namespace MiniMart.Model;

public class LichSuHoatHong
{
    public int Id { get; set; }
    public string TenDangNhap { get; set; } = "";
    public string HanhDong { get; set; } = "";
    public string NoiDung { get; set; } = "";
    public DateTime ThoiGian { get; set; } = DateTime.Now;
}
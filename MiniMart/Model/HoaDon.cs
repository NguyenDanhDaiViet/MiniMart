namespace MiniMart.Model;

public class HoaDon
{
    public int Id { get; set; }
    public string MaHoaDon { get; set; } = "";
    public DateTime NgayLapHoaDon { get; set; } = DateTime.Now;
    public decimal TongPhu { get; set; }
    public decimal ChietKhau { get; set; }
    public decimal TongTien { get; set; }
    public decimal TienDaTra { get; set; }
    public decimal TienThua { get; set; }

    public List<ChiTietHoaDon> Items { get; set; } = new();
}
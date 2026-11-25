namespace MiniMart.Model;

public class HoaDon
{
    public int Id { get; set; }
    public string MaHoaDon { get; set; } = "";
    public DateTime NgayLapHoaDon { get; set; } = DateTime.Now;
    
    public string tenKhachHang  { get; set; } = "";
    public string SDTkhachHang  { get; set; } = "";
    public int? IdKhachHang { get; set; }
    
    public KhachHang? KhachHang { get; set; }
    public string MaKhuyenMai { get; set; } = "";
    public int? IdCaLamViec { get; set; }
    public decimal TamTinh { get; set; }
    public decimal ChietKhau { get; set; }
    public decimal TongTien { get; set; }
    public decimal TienDaTra { get; set; }
    public decimal TienThua { get; set; }

    public List<ChiTietHoaDon> Items { get; set; } = new();
}
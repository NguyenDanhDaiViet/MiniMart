namespace MiniMart.Model;

public class ChiTietHoaDon
{
    public int Id { get; set; }
    public int MaHoaDon { get; set; }
    public int IdSanPham { get; set; }
    public string MaSanPham { get; set; } = "";
    public string TenSanPham { get; set; } = "";
    public int SoLuong { get; set; }
    public decimal DonGia { get; set; }
    public decimal GiamGia { get; set; }
    public decimal ThanhTien { get; set; }
    
    public HoaDon? HonDon { get; set; }
    
}
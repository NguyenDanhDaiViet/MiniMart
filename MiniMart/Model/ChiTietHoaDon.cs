namespace MiniMart.Model;

public class ChiTietHoaDon
{
    public int Id { get; set; }
    public int IdHoaDon { get; set; }
    public int IdSanPham { get; set; }
    public string MaSanPham { get; set; }
    public string TenSanPham { get; set; }
    public int SoLuong { get; set; }
    public decimal DonGia { get; set; }
    public decimal ChietKhau { get; set; }
    public decimal ThanhTienDong { get; set; }
    
    public HoaDon? HoaDon { get; set; }
}
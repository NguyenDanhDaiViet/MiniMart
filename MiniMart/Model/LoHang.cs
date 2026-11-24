namespace MiniMart.Model;

public class LoHang
{
    public int Id { get; set; }
    public int IdSanPham { get; set; }
    public string MaLo { get; set; } = "";
    public int SoLuongNhap { get; set; }
    public int SoLuongConLai { get; set; }
    public DateTime? NgaySanXuat { get; set; }
    public DateTime NgayHetHan { get; set; }
    public DateTime NgayNhap { get; set; } = DateTime.Now;
    public SanPham? SanPham { get; set; }  
}
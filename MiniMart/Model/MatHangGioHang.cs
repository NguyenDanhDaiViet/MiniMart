namespace MiniMart.Model;

public class MatHangGioHang
{
    public int IdSanPham { get; set; }
    public string Ma { get; set; } = "";
    public string Ten { get; set; } = "";
    public string DonVi { get; set; } = "";
    public int SoLuong { get; set; }
    public int SoLuongHangTon { get; set; }
    public decimal DonGia { get; set; }
    public decimal TyLeChietKhau { get; set; }
    public decimal ThanhTienDong => SoLuong * DonGia * (1 - TyLeChietKhau / 100m);
    
    
}
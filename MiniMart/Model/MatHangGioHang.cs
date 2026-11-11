namespace MiniMart.Model;

public class MatHangGioHang
{
    public int IdSanPham { get; set; }
    public string Code { get; set; } = "";
    public string Ten { get; set; } = "";
    public string DonVi { get; set; } = "";
    public int SoLuong { get; set; }
    public int SoLuongHangTon { get; set; }
    public decimal DonGia { get; set; }
    public decimal TiLeChietKhau { get; set; }
    public decimal ThanhTienDong => SoLuong * DonGia * (1 - TiLeChietKhau / 100m);
}
namespace MiniMart.Model;

public class KhuyenMai
{
    public int Id { get; set; }
    public string MaCode { get; set; } = "";
    public string TenKhuyenMai { get; set; } = "";
    public string LoaiGiam { get; set; } = "PhanTram"; // PhanTram | SoTien
    public decimal GiaTriGiam { get; set; }
    public decimal DonHangToiThieu { get; set; }
    public DateTime TuNgay { get; set; }
    public DateTime DenNgay { get; set; }
    public bool DangHoatDong { get; set; } = true;
}
namespace MiniMart.Model;

public class KhachHang
{
    public int Id { get; set; }
    public string HoTen { get; set; } = "";
    public string SoDienThoai { get; set; } = "";
    public string DiaChi { get; set; } = "";
    public int TongSoDonHang { get; set; }
    public decimal TongGiaTriMuaHang { get; set; }
    public int DiemTichLuy { get; set; }
    public DateTime NgayTao { get; set; } = DateTime.Now;
    public List<HoaDon> HoaDons { get; set; } = new();
   
    public string HangThanhVien { get; set; } = "Thành viên mới";

    public static readonly string[] DanhSachHang = { "Thành viên mới", "Bạc", "Vàng", "Kim cương" };

    public static string HangTheoChiTieu(decimal tongChiTieu) =>
        tongChiTieu >= 10000000m ? "Kim cương" : tongChiTieu >= 5000000m ? "Vàng" : tongChiTieu >= 1000000m ? "Bạc" : "Thành viên mới";
}
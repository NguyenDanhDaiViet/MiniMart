namespace MiniMart.Model;

public class KhachHangThanThiet
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
    [System.ComponentModel.DataAnnotations.Schema.NotMapped]
    public string HangThanhVien => TongGiaTriMuaHang >= 10000000m ? "Kim cương" : TongGiaTriMuaHang >= 5000000m ? "Vàng" : TongGiaTriMuaHang >= 1000000m ? "Bạc" : "Thành viên mới";
}
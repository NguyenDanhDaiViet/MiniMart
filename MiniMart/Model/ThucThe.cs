namespace MiniMart.Model;


public class SanPham
{
    public int Id { get; set; }
    public string MaHang { get; set; } = "";
    public string MaVach { get; set; } = "";
    public string TenHang { get; set; } = "";
    public string DonVi { get; set; } = "Cái";
    public decimal GiaVon { get; set; } 
    public decimal GiaBan { get; set; }
    public decimal CoPhan { get; set; }
    public decimal ChungKhoanToiThieu { get; set; }
}

public sealed class DonngSanPham
{
   public  int MaSanPham { get; set; }
   public string MaHang { get; set; } = "";
   public string TenHang { get; set; } = "";
   public string DonVi { get; set; } = "";
   public decimal SoLuong { get; set; } = 1;
   public decimal DonGia { get; set; }
   public decimal PhanTramChietKhau { get; set; }
   public decimal SoTienChietKhau { get; set; }

   public decimal TongTienDongHang
   {
       get
       {
           var tong = SoLuong * DonGia;
           var phanTramPhiaSau= tong * (1-PhanTramChietKhau/100m);
           return Math.Max(0,Math.Round(phanTramPhiaSau-SoTienChietKhau,0));
       }
   }

}

public sealed class HoaDon
{
    public int Id { get; set; }
    public string SoHoaDon { get; set; } = "";
    public DateTime ThoiDiemtao { get; set; }
    public decimal TongPhu { get; set; }
    public decimal TongChietKhau { get; set; }    
    public decimal TongCong { get; set; }
    public decimal SoTienDaThanhToan { get; set; }
    public decimal SoTienThayDoi { get; set; }
    
}

public sealed class DoanhThuHang
{
    public string GiaiDoan { get; set; }
    public int SoLuongHoaDon { get; set; }
    public decimal DoanhThu { get; set; }
    public decimal SoLuongDaBan { get; set; }
    
}

public sealed class SanPhamHangDau
{
    public string MaHang { get; set; } = "";
    public string TenHang { get; set; } = "";
    public decimal SoLuongDaBan { get; set; }
    public decimal DoanhThu { get; set; }
    
}

public sealed class HangTonKho
{
    public string MaHang { get; set; } = "";
    public string TenHang { get; set; } = "";
    public decimal CoPhan { get; set; }
    public decimal GiaTriTheoGiaVon { get; set; }
    public DateTime LanBanGanNhat { get; set; }
    public int SoNgayKhongHoatDong  { get; set; }
    
}

public sealed class ChiTietPhieuNhapKho
{
    public  int MaSanPham { get; set; }
    public string MaHang { get; set; } = "";
    public string TenHang { get; set; } = "";
    public decimal SoLuong { get; set; }
    public decimal GiaVon { get; set; }
    public decimal TongTienDongHang
    {
             get
        {
            return Math.Round(SoLuong * GiaVon, 0);
        }
    }
    
}

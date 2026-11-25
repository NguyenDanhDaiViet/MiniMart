namespace MiniMart.Model;

public class PhieuNhapKho
{
    public int Id { get; set; }
    public string MaBienNhan { get; set; } = "";
    public int MaSanPham { get; set; } 
    public int SoLuong { get; set; }
    public decimal GiaVon { get; set; }
    public DateTime DuocTaoVao { get; set; } = DateTime.Now;
    
    public string MaNhaCungCap { get; set; } = "";
    public string TenNhaCungCap { get; set; } = "";
    public string SoDienThoaiNhaCungCap { get; set; } = "";
    public string DiaChiNhaCungCap { get; set; } = "";
    public string EmailNhaCungCap { get; set; } = "";
    public string GhiChu { get; set; } = "";
}
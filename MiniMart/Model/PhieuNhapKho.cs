namespace MiniMart.Model;

public class PhieuNhapKho
{
    public int Id { get; set; }
    public string MaBienNhan { get; set; } = "";
    public int MaSanPham { get; set; } 
    public int SoLuong { get; set; }
    public decimal GiaVon { get; set; }
    public DateTime DuocTaoVao { get; set; } = DateTime.Now;
}
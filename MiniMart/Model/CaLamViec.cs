namespace MiniMart.Model;

public class CaLamViec
{
    public int Id { get; set; }
    public string MaCa { get; set; } = "";
    public string TenDangNhap { get; set; } = "";
    public DateTime GioMoCa { get; set; } = DateTime.Now;
    public DateTime? GioDongCa { get; set; }
    public decimal TienDauCa { get; set; }
    public decimal TienCuoiCa { get; set; }
    public decimal DoanhThu { get; set; }
    public string GhiChu { get; set; } = "";
    public bool DangMo { get; set; } = true;
    [System.ComponentModel.DataAnnotations.Schema.NotMapped]
    public decimal TienMatDuKien => TienDauCa + DoanhThu;
    [System.ComponentModel.DataAnnotations.Schema.NotMapped]
    public decimal ChenhLechTienMat => TienCuoiCa - TienMatDuKien;
}
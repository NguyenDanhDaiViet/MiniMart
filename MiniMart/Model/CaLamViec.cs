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
    public decimal TienMatDuKien => TienDauCa + DoanhThu;
    public decimal ChenhLechTienMat => TienCuoiCa - TienMatDuKien;
}
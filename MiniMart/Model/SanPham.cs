namespace MiniMart.Model;

public class SanPham
{
    public int Id { get; set; }
    public string Ma { get; set; } = "";
    public string Ten { get; set; } = "";
    public string DonVi { get; set; } = "Cái";
    public decimal GiaVon { get; set; }   
    public decimal GiaBan { get; set; }
    public int CoPhan { get; set; }
    public int TonKhoToiThieu { get; set; }
}
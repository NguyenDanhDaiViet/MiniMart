using MiniMart.Services;
using MiniMart.Ui;

namespace MiniMart.Forms;

public partial class FormLichSuMuaHang : Form
{
    private readonly DichVuKhachHang _dichVu = new();

    public FormLichSuMuaHang() : this(0, "", "") { }

    public FormLichSuMuaHang(int idKhachHang, string hoTen, string soDienThoai)
    {
        InitializeComponent();
        if (TienIchGiaoDien.DangThietKe) return;

        TienIchGiaoDien.CauHinhLuoi(dgvLichSuMua);
        var ds = _dichVu.LayLichSuMua(idKhachHang);
        dgvLichSuMua.DataSource = ds
            .Select(x => new
            {
                x.MaHoaDon, x.NgayLapHoaDon, x.TamTinh, x.ChietKhau, x.TongTien,
                KhuyenMai = string.IsNullOrWhiteSpace(x.MaKhuyenMai) ? "—" : x.MaKhuyenMai
            })
            .ToList();
        TienIchGiaoDien.DatTieuDe(dgvLichSuMua,
            ("MaHoaDon", "Mã hóa đơn"), ("NgayLapHoaDon", "Thời gian"), ("TamTinh", "Tạm tính"),
            ("ChietKhau", "Giảm giá"), ("TongTien", "Tổng tiền"), ("KhuyenMai", "Mã khuyến mãi"));
        TienIchGiaoDien.DinhDangSo(dgvLichSuMua, "TamTinh", "ChietKhau", "TongTien");
        if (dgvLichSuMua.Columns["NgayLapHoaDon"] != null)
            dgvLichSuMua.Columns["NgayLapHoaDon"]!.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

        lblKhachHang.Text = $"Khách hàng: {hoTen} - {soDienThoai}    |    Số đơn: {ds.Count}    |    Tổng chi tiêu: {ds.Sum(x => x.TongTien):N0} đ";
    }
}
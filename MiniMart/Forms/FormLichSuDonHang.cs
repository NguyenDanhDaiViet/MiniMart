using MiniMart.Services;
using MiniMart.Ui;

namespace MiniMart.Forms;

public partial class FormLichSuDonHang : Form
{
    private readonly DichVuBanHang _banHang = new();
    public FormLichSuDonHang()
    {
       InitializeComponent();
        if (TienIchGiaoDien.DangThietKe) return;

        TienIchGiaoDien.CauHinhLuoi(dgvDonHang);
        TienIchGiaoDien.CauHinhLuoi(dgvChiTiet);

        dtpTuNgay.Value = DateTime.Today.AddDays(-30);
        dtpDenNgay.Value = DateTime.Today;

        btnTimKiem.Click += XuLyTimKiem_Click;
        txtTimKiem.KeyDown += XuLyTimKiem_KeyDown;
        dgvDonHang.SelectionChanged += XuLyChonDonHang_SelectionChanged;

        TaiDanhSach();
    }

    private void TaiDanhSach()
    {
        if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
        {
            MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc.", "Chọn khoản ngày không hợp lệ",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var danhSach = _banHang.LayLichSuHoaDon(dtpTuNgay.Value.Date, dtpDenNgay.Value.Date, txtTimKiem.Text);

        dgvDonHang.DataSource = danhSach
            .Select(x => new
            {
                x.Id,
                x.MaHoaDon,
                x.NgayLapHoaDon,
                KhachHang = string.IsNullOrWhiteSpace(x.tenKhachHang) ? "Khách Hàng" : x.tenKhachHang,
                SoDienThoai = x.SDTkhachHang,
                x.TamTinh,
                x.ChietKhau,
                x.TongTien,
                x.TienDaTra,
                x.TienThua
            })
            .ToList();

        TienIchGiaoDien.AnCot(dgvDonHang, "Id");
        TienIchGiaoDien.DatTieuDe(dgvDonHang,
            ("MaHoaDon", "Mã đơn"), ("NgayLapHoaDon", "Thời gian"), ("KhachHang", "Khách hàng"),
            ("SoDienThoai", "Số điện thoại"), ("TamTinh", "Tạm tính"), ("ChietKhau", "Giảm giá"),
            ("TongTien", "Tổng tiền"), ("TienDaTra", "Khách đưa"), ("TienThua", "Tiền thừa"));
        TienIchGiaoDien.DinhDangSo(dgvDonHang, "TamTinh", "ChietKhau", "TongTien", "TienDaTra", "TienThua");
        if (dgvDonHang.Columns["NgayLapHoaDon"] != null)
            dgvDonHang.Columns["NgayLapHoaDon"]!.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

        lblTongKet.Text = $"Số đơn: {danhSach.Count} - Tổng tiền: {danhSach.Sum(x => x.TongTien):N0} đ";
        HienChiTiet();
    }

    private void HienChiTiet()
    {
        var dong = dgvDonHang.CurrentRow;
        if (dong == null || !dgvDonHang.Columns.Contains("Id") || dong.Cells["Id"].Value == null)
        {
            dgvChiTiet.DataSource = null;
            lblChiTiet.Text = "CHI TIẾT ĐƠN HÀNG";
            return;
        }

        int id = Convert.ToInt32(dong.Cells["Id"].Value);
        string ma = Convert.ToString(dong.Cells["MaHoaDon"].Value) ?? "";
        string khach = Convert.ToString(dong.Cells["KhachHang"].Value) ?? "";
        string sdt = Convert.ToString(dong.Cells["SoDienThoai"].Value) ?? "";
        lblChiTiet.Text = string.IsNullOrWhiteSpace(sdt)
            ? $"CHI TIẾT ĐƠN {ma} - Khách hàng: {khach}"
            : $"CHI TIẾT ĐƠN {ma} - Khách hàng: {khach} ({sdt})";

        dgvChiTiet.DataSource = _banHang.LayChiTietHoaDon(id)
            .Select(x => new { x.MaSanPham, x.TenSanPham, x.SoLuong, x.DonGia, x.ChietKhau, x.ThanhTienDong })
            .ToList();

        TienIchGiaoDien.DatTieuDe(dgvChiTiet,
            ("MaSanPham", "Mã SP"), ("TenSanPham", "Tên sản phẩm"), ("SoLuong", "Số lượng"),
            ("DonGia", "Đơn giá"), ("ChietKhau", "Giảm giá (%)"), ("ThanhTienDong", "Thành tiền"));
        TienIchGiaoDien.DinhDangSo(dgvChiTiet, "DonGia", "ThanhTienDong");
    }

    private void XuLyTimKiem_Click(object? sender, EventArgs e) => TaiDanhSach();

    private void XuLyTimKiem_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter) return;
        e.SuppressKeyPress = true;
        TaiDanhSach();
    }

    private void XuLyChonDonHang_SelectionChanged(object? sender, EventArgs e) => HienChiTiet();
}
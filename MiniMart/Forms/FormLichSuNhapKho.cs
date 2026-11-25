using MiniMart.Model;
using MiniMart.Services;
using MiniMart.Ui;

namespace MiniMart.Forms;

public partial class FormLichSuNhapKho : Form
{
    private readonly DichVuKho _kho = new();
    private List<PhieuNhapKhoChiTiet> _danhSach = new();

    public FormLichSuNhapKho()
    {
        InitializeComponent();
        if (TienIchGiaoDien.DangThietKe) return;

        TienIchGiaoDien.CauHinhLuoi(dgvPhieuNhap);
        TienIchGiaoDien.CauHinhLuoi(dgvChiTiet);

        dtpTuNgay.Value = DateTime.Today.AddDays(-30); 
        dtpDenNgay.Value = DateTime.Today;
        
        btnTimKiem.Click += (_, _) => TaiDanhSach();
        txtTimKiem.TextChanged += (_, _) => TaiDanhSach(baoLoiNgay: false);
        txtTimKiem.KeyDown += XuLyTimKiem_KeyDown;
        dtpTuNgay.ValueChanged += (_, _) => TaiDanhSach();
        dtpDenNgay.ValueChanged += (_, _) => TaiDanhSach();
        dgvPhieuNhap.SelectionChanged += XuLyChonPhieuNhap_SelectionChanged;

        TaiDanhSach();
    }

    private void TaiDanhSach(bool baoLoiNgay = true)
    {
        if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
        {
            if (baoLoiNgay) MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.", "Khoảng ngày không hợp lệ",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _danhSach = _kho.LayLichSuNhapKho(dtpTuNgay.Value.Date, dtpDenNgay.Value.Date, txtTimKiem.Text);

        dgvPhieuNhap.DataSource = _danhSach
            .Select(x => new
            {
                x.Id,
                x.MaBienNhan,
                x.NgayNhap,
                x.MaNhaCungCap,
                NhaCungCap = string.IsNullOrWhiteSpace(x.TenNhaCungCap) ? "Chưa ghi nhận" : x.TenNhaCungCap,
                SoDienThoai = x.SoDienThoaiNhaCungCap,
                SanPham = x.TenSanPham,
                x.SoLuong,
                x.ThanhTien
            })
            .ToList();

        TienIchGiaoDien.AnCot(dgvPhieuNhap, "Id");
        TienIchGiaoDien.DatTieuDe(dgvPhieuNhap,
            ("MaBienNhan", "Mã phiếu"), ("NgayNhap", "Thời gian"), ("MaNhaCungCap", "Mã NCC"),
            ("NhaCungCap", "Nhà cung cấp"), ("SoDienThoai", "Số điện thoại"), ("SanPham", "Sản phẩm"),
            ("SoLuong", "Số lượng"), ("ThanhTien", "Thành tiền"));
        TienIchGiaoDien.DinhDangSo(dgvPhieuNhap, "ThanhTien");
        if (dgvPhieuNhap.Columns["NgayNhap"] != null)
            dgvPhieuNhap.Columns["NgayNhap"]!.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

        lblTongKet.Text = $"Số phiếu: {_danhSach.Count} - Tổng tiền nhập: {_danhSach.Sum(x => x.ThanhTien):N0} đ";
        HienChiTiet();
    }

    private void HienChiTiet()
    {
        var dong = dgvPhieuNhap.CurrentRow;
        if (dong == null || !dgvPhieuNhap.Columns.Contains("Id") || dong.Cells["Id"].Value == null)
        {
            XoaChiTiet();
            return;
        }

        int id = Convert.ToInt32(dong.Cells["Id"].Value);
        var phieu = _danhSach.FirstOrDefault(x => x.Id == id);
        if (phieu == null)
        {
            XoaChiTiet();
            return;
        }

        lblChiTiet.Text = $"CHI TIẾT PHIẾU {phieu.MaBienNhan} - Ngày nhập: {phieu.NgayNhap:dd/MM/yyyy HH:mm}";

        txtThongTinNhaCungCap.Text =
            $"Mã NCC: {HienGiaTri(phieu.MaNhaCungCap)}    |    Tên nhà cung cấp: {HienGiaTri(phieu.TenNhaCungCap)}    |    Số điện thoại: {HienGiaTri(phieu.SoDienThoaiNhaCungCap)}"
            + Environment.NewLine
            + $"Địa chỉ: {HienGiaTri(phieu.DiaChiNhaCungCap)}    |    Email: {HienGiaTri(phieu.EmailNhaCungCap)}"
            + Environment.NewLine
            + $"Ghi chú: {HienGiaTri(phieu.GhiChu)}";

        dgvChiTiet.DataSource = new[]
        {
            new { phieu.MaSanPham, phieu.TenSanPham, phieu.DonVi, phieu.SoLuong, phieu.GiaNhap, phieu.ThanhTien }
        }.ToList();

        TienIchGiaoDien.DatTieuDe(dgvChiTiet,
            ("MaSanPham", "Mã SP"), ("TenSanPham", "Tên sản phẩm"), ("DonVi", "Đơn vị"),
            ("SoLuong", "Số lượng"), ("GiaNhap", "Giá nhập"), ("ThanhTien", "Thành tiền"));
        TienIchGiaoDien.DinhDangSo(dgvChiTiet, "GiaNhap", "ThanhTien");
    }

    private void XoaChiTiet()
    {
        dgvChiTiet.DataSource = null;
        txtThongTinNhaCungCap.Clear();
        lblChiTiet.Text = "CHI TIẾT PHIẾU NHẬP";
    }

    private static string HienGiaTri(string giaTri) => string.IsNullOrWhiteSpace(giaTri) ? "—" : giaTri;

    private void XuLyTimKiem_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter) return;
        e.SuppressKeyPress = true;
        TaiDanhSach();
    }

    private void XuLyChonPhieuNhap_SelectionChanged(object? sender, EventArgs e) => HienChiTiet();
}

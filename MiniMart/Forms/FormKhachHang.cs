using MiniMart.Model;
using MiniMart.Services;
using MiniMart.Ui;

namespace MiniMart.Forms;

public partial class FormKhachHang : Form
{
    private readonly DichVuKhachHang _dichVu = new();
    private int _idDuocChon;

    public FormKhachHang()
    {
        InitializeComponent();
        if (TienIchGiaoDien.DangThietKe) return;

        TienIchGiaoDien.CauHinhLuoi(dgvKhachHang);

        cboHangThanhVien.SelectedIndex = 0; 

       
        btnTimKiem.Click += (_, _) => TaiDanhSach();
        txtTimKiem.TextChanged += (_, _) => TaiDanhSach();
        txtTimKiem.KeyDown += XuLyTimKiem_KeyDown;
        btnLuu.Click += XuLyLuu_Click;
        btnLamMoi.Click += (_, _) => LamMoi();
        btnLichSuMua.Click += XuLyLichSuMua_Click;
        btnXoa.Click += XuLyXoa_Click;
        dgvKhachHang.CellClick += XuLyChonKhachHang_CellClick;

        TaiDanhSach();
    }

    private void TaiDanhSach()
    {
        dgvKhachHang.DataSource = _dichVu.LayDanhSach(txtTimKiem.Text);
        TienIchGiaoDien.AnCot(dgvKhachHang, "Id", "HoaDons");
        TienIchGiaoDien.DatTieuDe(dgvKhachHang,
            ("HoTen", "Họ và tên"), ("SoDienThoai", "Số điện thoại"), ("DiaChi", "Địa chỉ"),
            ("TongSoDonHang", "Số lần mua"), ("TongGiaTriMuaHang", "Tổng chi tiêu"),
            ("DiemTichLuy", "Điểm tích lũy"), ("HangThanhVien", "Hạng thành viên"), ("NgayTao", "Ngày tham gia"));
        TienIchGiaoDien.DinhDangSo(dgvKhachHang, "TongGiaTriMuaHang");
        if (dgvKhachHang.Columns["NgayTao"] != null)
            dgvKhachHang.Columns["NgayTao"]!.DefaultCellStyle.Format = "dd/MM/yyyy";
    }

    private void XuLyTimKiem_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter) return;
        e.SuppressKeyPress = true;
        TaiDanhSach();
    }

    private void LamMoi()
    {
        _idDuocChon = 0;
        txtHoTen.Clear();
        txtSoDienThoai.Clear();
        txtDiaChi.Clear();
        cboHangThanhVien.SelectedIndex = 0;
        dgvKhachHang.ClearSelection();
        txtHoTen.Focus();
    }

    private void XuLyLuu_Click(object? sender, EventArgs e)
    {
        try
        {
            _dichVu.Luu(new KhachHang
            {
                Id = _idDuocChon, HoTen = txtHoTen.Text, SoDienThoai = txtSoDienThoai.Text, DiaChi = txtDiaChi.Text,
                HangThanhVien = Convert.ToString(cboHangThanhVien.SelectedItem) ?? KhachHang.DanhSachHang[0]
            });
            bool laThemMoi = _idDuocChon == 0;
            TaiDanhSach();
            LamMoi();
            MessageBox.Show(laThemMoi ? "Thêm khách hàng thành công." : "Cập nhật khách hàng thành công.", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Không thể lưu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

   
    private void XuLyXoa_Click(object? sender, EventArgs e)
    {
        if (_idDuocChon == 0) { MessageBox.Show("Hãy chọn khách hàng cần xóa."); return; }
        if (MessageBox.Show("Xóa hồ sơ khách hàng này? Lịch sử hóa đơn vẫn được giữ.", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
        try
        {
            _dichVu.Xoa(_idDuocChon);
            TaiDanhSach();
            LamMoi();
            MessageBox.Show("Xóa khách hàng thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void XuLyLichSuMua_Click(object? sender, EventArgs e)
    {
        if (_idDuocChon == 0) { MessageBox.Show("Vui lòng chọn khách hàng trong danh sách trước."); return; }
        using var f = new FormLichSuMuaHang(_idDuocChon, txtHoTen.Text, txtSoDienThoai.Text);
        f.ShowDialog(this);
    }

    private void XuLyChonKhachHang_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || dgvKhachHang.Rows[e.RowIndex].DataBoundItem is not KhachHang k) return;
        _idDuocChon = k.Id;
        txtHoTen.Text = k.HoTen;
        txtSoDienThoai.Text = k.SoDienThoai;
        txtDiaChi.Text = k.DiaChi;
        int viTri = cboHangThanhVien.Items.IndexOf(k.HangThanhVien);
        cboHangThanhVien.SelectedIndex = viTri >= 0 ? viTri : 0;
    }
}

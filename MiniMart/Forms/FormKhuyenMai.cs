using MiniMart.Model;
using MiniMart.Services;
using MiniMart.Ui;

namespace MiniMart.Forms;

public partial class FormKhuyenMai : Form
{
    private readonly DichVuKhuyenMai _dichVu = new();
    private int _idDuocChon;

    public FormKhuyenMai()
    {
        InitializeComponent();
        if (TienIchGiaoDien.DangThietKe) return;

        TienIchGiaoDien.CauHinhLuoi(dgvKhuyenMai);
        cboLoaiGiam.Items.AddRange(new object[] { "Phần trăm", "Số tiền" });
        cboLoaiGiam.SelectedIndex = 0;
        cboLoaiGiam.SelectedIndexChanged += XuLyDoiLoaiGiam_SelectedIndexChanged;
        dtpTuNgay.Value = DateTime.Today;
        dtpDenNgay.Value = DateTime.Today.AddMonths(1);

        btnLuu.Click += XuLyLuu_Click;
        btnTaoMoi.Click += (_, _) => LamMoi();
        btnXoa.Click += XuLyXoa_Click;
      
        btnTim.Click += (_, _) => TaiDanhSach();
        txtTimKiem.TextChanged += (_, _) => TaiDanhSach();
        btnLamMoiDanhSach.Click += (_, _) => { txtTimKiem.Clear(); TaiDanhSach(); };
        dgvKhuyenMai.CellClick += XuLyChonKhuyenMai_CellClick;

        TaiDanhSach();
    }

    private void XuLyDoiLoaiGiam_SelectedIndexChanged(object? sender, EventArgs e)
    {
        nudGiaTriGiam.Maximum = cboLoaiGiam.SelectedIndex == 0 ? 100 : 100000000;
        nudGiaTriGiam.Value = Math.Min(nudGiaTriGiam.Value, nudGiaTriGiam.Maximum);
    }

    private void TaiDanhSach()
    {
        dgvKhuyenMai.DataSource = _dichVu.LayDanhSach(txtTimKiem.Text);
        TienIchGiaoDien.AnCot(dgvKhuyenMai, "Id");
        TienIchGiaoDien.DatTieuDe(dgvKhuyenMai,
            ("MaCode", "Mã khuyến mãi"), ("TenKhuyenMai", "Tên chương trình"), ("LoaiGiam", "Hình thức"),
            ("GiaTriGiam", "Mức giảm"), ("DonHangToiThieu", "Đơn tối thiểu"), ("TuNgay", "Bắt đầu"),
            ("DenNgay", "Kết thúc"), ("DangHoatDong", "Đang bật"));
        TienIchGiaoDien.DinhDangSo(dgvKhuyenMai, "GiaTriGiam", "DonHangToiThieu");
        foreach (var cot in new[] { "TuNgay", "DenNgay" })
            if (dgvKhuyenMai.Columns[cot] != null) dgvKhuyenMai.Columns[cot]!.DefaultCellStyle.Format = "dd/MM/yyyy";
    }

    private void LamMoi()
    {
        _idDuocChon = 0;
        txtMaKhuyenMai.Clear();
        txtTenKhuyenMai.Clear();
        cboLoaiGiam.SelectedIndex = 0;
        nudGiaTriGiam.Value = 1;
        nudDonToiThieu.Value = 0;
        dtpTuNgay.Value = DateTime.Today;
        dtpDenNgay.Value = DateTime.Today.AddMonths(1);
        chkDangHoatDong.Checked = true;
        dgvKhuyenMai.ClearSelection();
        txtMaKhuyenMai.Focus();
    }

    private void XuLyChonKhuyenMai_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || dgvKhuyenMai.Rows[e.RowIndex].DataBoundItem is not KhuyenMai k) return;
        _idDuocChon = k.Id;
        txtMaKhuyenMai.Text = k.MaCode;
        txtTenKhuyenMai.Text = k.TenKhuyenMai;
        cboLoaiGiam.SelectedIndex = k.LoaiGiam == "PhanTram" ? 0 : 1;
        TienIchGiaoDien.GanGiaTri(nudGiaTriGiam, k.GiaTriGiam);
        TienIchGiaoDien.GanGiaTri(nudDonToiThieu, k.DonHangToiThieu);
        dtpTuNgay.Value = k.TuNgay;
        dtpDenNgay.Value = k.DenNgay;
        chkDangHoatDong.Checked = k.DangHoatDong;
    }

    private void XuLyLuu_Click(object? sender, EventArgs e)
    {
        try
        {
            bool laThemMoi = _idDuocChon == 0;
            _dichVu.Luu(new KhuyenMai
            {
                Id = _idDuocChon,
                MaCode = txtMaKhuyenMai.Text,
                TenKhuyenMai = txtTenKhuyenMai.Text,
                LoaiGiam = cboLoaiGiam.SelectedIndex == 0 ? "PhanTram" : "SoTien",
                GiaTriGiam = nudGiaTriGiam.Value,
                DonHangToiThieu = nudDonToiThieu.Value,
                TuNgay = dtpTuNgay.Value.Date,
                DenNgay = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1),
                DangHoatDong = chkDangHoatDong.Checked
            });
            TaiDanhSach();
            MessageBox.Show(laThemMoi ? "Thêm chương trình khuyến mãi thành công." : "Cập nhật chương trình khuyến mãi thành công.",
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Không thể lưu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    
    private void XuLyXoa_Click(object? sender, EventArgs e)
    {
        if (_idDuocChon == 0) { MessageBox.Show("Hãy chọn mã khuyến mãi cần xóa."); return; }
        if (MessageBox.Show("Bạn chắc chắn muốn xóa mã này?", "Xác nhận xóa", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes) return;
        try
        {
            _dichVu.Xoa(_idDuocChon);
            LamMoi();
            TaiDanhSach();
            MessageBox.Show("Xóa mã khuyến mãi thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

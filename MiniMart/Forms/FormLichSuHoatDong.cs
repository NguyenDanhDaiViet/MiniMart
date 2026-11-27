using MiniMart.Services;
using MiniMart.Ui;

namespace MiniMart.Forms;

public partial class FormLichSuHoatDong : Form
{
    private readonly DichVuLichSuHoatDong _dichVu = new();

    public FormLichSuHoatDong()
    {
        InitializeComponent();
        if (TienIchGiaoDien.DangThietKe) return;

        TienIchGiaoDien.CauHinhLuoi(dgvLichSu);
        dtpTuNgay.Value = DateTime.Today.AddDays(-30);
        dtpDenNgay.Value = DateTime.Today;
        
        
        btnLoc.Click += (_, _) => TaiDanhSach();
        txtTuKhoa.KeyDown += (_, e) =>
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            TaiDanhSach();
        };

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

        var ds = _dichVu.LayDanhSach(dtpTuNgay.Value, dtpDenNgay.Value, txtTuKhoa.Text);
        dgvLichSu.DataSource = ds;
        TienIchGiaoDien.AnCot(dgvLichSu, "Id");
        TienIchGiaoDien.DatTieuDe(dgvLichSu,
            ("TenDangNhap", "Nhân viên"), ("HanhDong", "Thao tác"), ("NoiDung", "Chi tiết"), ("ThoiGian", "Thời gian"));
        if (dgvLichSu.Columns["ThoiGian"] != null)
            dgvLichSu.Columns["ThoiGian"]!.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
        lblTongKet.Text = $"Số thao tác: {ds.Count}";
    }
}
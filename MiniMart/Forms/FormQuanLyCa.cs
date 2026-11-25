using MiniMart.Services;
using MiniMart.Ui;

namespace MiniMart.Forms;

public partial class FormQuanLyCa : Form
{
    private readonly DichVuCaLamViec _dichVu = new();

    public FormQuanLyCa()
    {
        InitializeComponent();
        if (TienIchGiaoDien.DangThietKe) return;

        TienIchGiaoDien.CauHinhLuoi(dgvCaLamViec);
        dtpTuNgay.Value = DateTime.Today.AddDays(-30);
        dtpDenNgay.Value = DateTime.Today;

        btnMoCa.Click += XuLyMoCa_Click;
        btnDongCa.Click += XuLyDongCa_Click;
        btnTaiLichSu.Click += (_, _) => TaiDanhSach();

        TaiDanhSach();
        CapNhatTrangThai();
    }

    private void XuLyMoCa_Click(object? sender, EventArgs e)
    {
        try
        {
            _dichVu.MoCa(nudTienDauCa.Value);
            CapNhatTrangThai();
            TaiDanhSach();
            MessageBox.Show("Mở ca thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Không thể mở ca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void XuLyDongCa_Click(object? sender, EventArgs e)
    {
        try
        {
            var caDangMo = _dichVu.LayCaDangMo(FormDangNhap.hienThiTen);
            if (caDangMo != null && nudTienCuoiCa.Value < caDangMo.TienDauCa)
            {
                MessageBox.Show(
                    $"Số tiền đóng ca ({nudTienCuoiCa.Value:N0} đ) đang bé hơn số tiền mở ca ({caDangMo.TienDauCa:N0} đ).\n" +
                    $"Chênh lệch: {nudTienCuoiCa.Value - caDangMo.TienDauCa:N0} đ. Ca vẫn sẽ được đóng.",
                    "Tiền đóng ca bé hơn tiền mở ca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            _dichVu.DongCa(nudTienCuoiCa.Value, txtGhiChu.Text);
            CapNhatTrangThai();
            TaiDanhSach();
            txtGhiChu.Clear();
            MessageBox.Show("Đóng ca thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Không thể đóng ca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void CapNhatTrangThai()
    {
        var ca = _dichVu.LayCaDangMo(FormDangNhap.hienThiTen);
        lblTrangThai.Text = ca == null
            ? "CHƯA MỞ CA  •  Vui lòng nhập tiền đầu ca và chọn Mở ca."
            : $"ĐANG MỞ CA: {ca.MaCa}  •  Nhân viên: {ca.TenDangNhap}  •  Doanh thu: {ca.DoanhThu:N0} đ  •  Tiền mặt dự kiến: {ca.TienMatDuKien:N0} đ";
    }

    private void TaiDanhSach()
    {
        if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
        {
            MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.", "Khoảng ngày không hợp lệ",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        dgvCaLamViec.DataSource = _dichVu.LayDanhSach(dtpTuNgay.Value, dtpDenNgay.Value);
        TienIchGiaoDien.AnCot(dgvCaLamViec, "Id");
        TienIchGiaoDien.DatTieuDe(dgvCaLamViec,
            ("MaCa", "Mã ca"), 
            ("TenDangNhap", "Nhân viên"), 
            ("GioMoCa", "Giờ mở"), 
            ("GioDongCa", "Giờ đóng"),
            ("TienDauCa", "Tiền đầu ca"), 
            ("DoanhThu", "Doanh thu"), 
            ("TienCuoiCa", "Tiền cuối ca"),
            ("TienMatDuKien", "Tiền mặt dự kiến"), 
            ("ChenhLechTienMat", "Chênh lệch"), 
            ("GhiChu", "Ghi chú"), 
            ("DangMo", "Đang mở"));
        TienIchGiaoDien.DinhDangSo(dgvCaLamViec, "TienDauCa", "DoanhThu", "TienCuoiCa", "TienMatDuKien", "ChenhLechTienMat");
        foreach (var cot in new[] { "GioMoCa", "GioDongCa" })
            if (dgvCaLamViec.Columns[cot] != null) dgvCaLamViec.Columns[cot]!.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
    }
}

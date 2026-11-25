using MiniMart.Services;
using MiniMart.Ui;

namespace MiniMart.Forms;

// [MỚI] Quản lý lô hàng và hạn sử dụng. Control nằm trong FormHanSuDung.Designer.cs:
// cboSanPham / txtMaLo / nudSoLuong / dtpNgaySanXuat / dtpHanSuDung + btnTaoLo = tạo lô,
// txtTimKiem + btnLoc = tìm, btnXoaLo = xóa lô chưa xuất, dgvLoHang = danh sách lô.
public partial class FormHanSuDung : Form
{
    private readonly DichVuHanSuDung _dichVu = new();
    private readonly DichVuSanPham _sanPham = new();

    public FormHanSuDung()
    {
        InitializeComponent();
        if (TienIchGiaoDien.DangThietKe) return;

        TienIchGiaoDien.CauHinhLuoi(dgvLoHang);
        cboSanPham.DataSource = _sanPham.LayTatCa();
        cboSanPham.DisplayMember = "Ten";
        cboSanPham.ValueMember = "Id";
        dtpHanSuDung.Value = DateTime.Today.AddMonths(6);

        btnTaoLo.Click += XuLyTaoLo_Click;
        btnLoc.Click += (_, _) => TaiDanhSach();
        btnXoaLo.Click += XuLyXoaLo_Click;
        txtTimKiem.KeyDown += (_, e) =>
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            TaiDanhSach();
        };

        TaiDanhSach();
    }

    private void TaiDanhSach()
    {
        dgvLoHang.DataSource = _dichVu.LayDanhSach(txtTimKiem.Text)
            .Select(x => new
            {
                x.MaLo, SanPham = x.SanPham?.Ten, x.SoLuongNhap, x.SoLuongConLai, x.NgaySanXuat, x.NgayHetHan,
                TrangThai = DichVuHanSuDung.TrangThai(x)
            })
            .ToList();
        TienIchGiaoDien.DatTieuDe(dgvLoHang,
            ("MaLo", "Mã lô"), ("SanPham", "Sản phẩm"), ("SoLuongNhap", "SL ban đầu"), ("SoLuongConLai", "SL còn lại"),
            ("NgaySanXuat", "Ngày sản xuất"), ("NgayHetHan", "Hạn sử dụng"), ("TrangThai", "Tình trạng"));
        foreach (var cot in new[] { "NgaySanXuat", "NgayHetHan" })
            if (dgvLoHang.Columns[cot] != null) dgvLoHang.Columns[cot]!.DefaultCellStyle.Format = "dd/MM/yyyy";
    }

    private void XuLyTaoLo_Click(object? sender, EventArgs e)
    {
        try
        {
            if (cboSanPham.SelectedValue is not int idSanPham)
            {
                MessageBox.Show("Hãy chọn sản phẩm.");
                return;
            }
            _dichVu.TaoLo(idSanPham, txtMaLo.Text, (int)nudSoLuong.Value,
                dtpNgaySanXuat.Checked ? dtpNgaySanXuat.Value.Date : null, dtpHanSuDung.Value.Date);
            TaiDanhSach();
            txtMaLo.Clear();
            nudSoLuong.Value = 1;
            MessageBox.Show("Đã tạo lô hàng.");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Không thể tạo lô", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    // Chỉ xóa được lô chưa phát sinh xuất bán/điều chỉnh.
    private void XuLyXoaLo_Click(object? sender, EventArgs e)
    {
        if (dgvLoHang.CurrentRow == null || !dgvLoHang.Columns.Contains("MaLo") || dgvLoHang.CurrentRow.Cells["MaLo"].Value == null)
        {
            MessageBox.Show("Hãy chọn một lô hàng.");
            return;
        }
        string maLo = Convert.ToString(dgvLoHang.CurrentRow.Cells["MaLo"].Value) ?? "";
        if (MessageBox.Show($"Xóa lô {maLo}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
        try
        {
            _dichVu.Xoa(maLo);
            TaiDanhSach();
            MessageBox.Show("Đã xóa lô hàng.");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

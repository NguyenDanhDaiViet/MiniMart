using MiniMart.Model;
using MiniMart.Services;
using MiniMart.Ui;

namespace MiniMart.Forms;

public partial class FormSanPham : Form
{
    public readonly DichVuSanPham _dichVu = new();
    public int _idDuocChon;
    
    public FormSanPham()
    {
        InitializeComponent();
        if (TienIchGiaoDien.DangThietKe) return;
        
        TienIchGiaoDien.CauHinhLuoi(dgvSanPham);
        TienIchGiaoDien.DatGoiY(txtTimKiem);
        
        btnTimKiem.Click += XuLyTimKiem_Click;
        btnMoi.Click += XuLyTaoMoi_Click;
        btnLuu.Click += XuLyLuu_Click;
        btnXoa.Click += XuLyXoaSanPham_Click;
        dgvSanPham.CellClick += XuLyChonSanPham_CellClick; 
        
        XoaDuLieuNhap();
        TaiDanhSachSanPham();
    }

    private void XuLyTimKiem_Click(object? sender, EventArgs e) => TaiDanhSachSanPham();

    private void TaiDanhSachSanPham()
    {
        dgvSanPham.DataSource = _dichVu.LayTatCa(txtTimKiem.Text);
        TienIchGiaoDien.AnCot(dgvSanPham, "Id");
        TienIchGiaoDien.DatTieuDe(dgvSanPham,
            ("Ma", "Mã SP"), ("Ten", "Tên sản phẩm"), ("DonVi", "Đon vị"),
            ("GiaNhap", "Giá nhập"), ("GiaBan", "Giá bán"),
            ("SoLuongHangTon", "Tồn kho"), ("TonKhoToiThieu", "Tồn tối thiểu"));
        TienIchGiaoDien.DinhDangSo(dgvSanPham, "GiaNhap", "GiaBan");
    }

    private void XuLyTaoMoi_Click(object? sender, EventArgs e) => XoaDuLieuNhap();

    private void XoaDuLieuNhap()
    {
        _idDuocChon = 0;
        txtMaSP.Clear();
        txtTenSanPham.Clear();
        txtDonVi.Text = "Cái";
        TienIchGiaoDien.GanGiaTri(nudGiaNhap, 0);
        TienIchGiaoDien.GanGiaTri(nudGiaBan, 0);
        TienIchGiaoDien.GanGiaTri(nudTonKho, 0);
        TienIchGiaoDien.GanGiaTri(nudTonToiThieu, 0);
        dgvSanPham.ClearSelection();
    }
    
    private void XuLyLuu_Click(object? sender, EventArgs e)
    {
        try
        {
            _dichVu.LuuSp(new SanPham()
            {
                Id = _idDuocChon,
                Ma = txtMaSP.Text,
                Ten = txtTenSanPham.Text,
                DonVi = txtDonVi.Text,
                GiaVon = nudGiaNhap.Value,
                GiaBan = nudGiaBan.Value,
                SoLuongHangTon = (int) nudTonKho.Value,
                TonKhoToiThieu = (int) nudTonToiThieu.Value
            });
            TaiDanhSachSanPham();
            XoaDuLieuNhap();
            MessageBox.Show("Đã lưu sản phẩm.");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Không thể lưu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    
    private void XuLyXoaSanPham_Click(object? sender, EventArgs e)
    {
        if (_idDuocChon == 0) return;
        if (MessageBox.Show("Xóa sản phẩm đang chọn?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
        try
        {
            _dichVu.Xoa(_idDuocChon);
            TaiDanhSachSanPham();
            XoaDuLieuNhap();
        }
        catch
        {
            MessageBox.Show("Không thể xóa sản phẩm đã phát sinh hóa đơn. Hãy giữ sản phẩm trong danh mục.");
        }
    }

    private void XuLyChonSanPham_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        if (dgvSanPham.Rows[e.RowIndex].DataBoundItem is not SanPham p) return;

        _idDuocChon = p.Id;
        txtMaSP.Text = p.Ma;
        txtTenSanPham.Text = p.Ten;
        txtDonVi.Text = p.DonVi;
        TienIchGiaoDien.GanGiaTri(nudGiaNhap, p.GiaVon);
        TienIchGiaoDien.GanGiaTri(nudGiaBan, p.GiaBan);
        TienIchGiaoDien.GanGiaTri(nudTonKho, p.SoLuongHangTon);
        TienIchGiaoDien.GanGiaTri(nudTonToiThieu, p.TonKhoToiThieu);
    }
}
using MiniMart.Model;
using MiniMart.Services;
using MiniMart.Ui;

namespace MiniMart.Forms;

public partial class FormNhapKho : Form
{
    private readonly DichVuSanPham danhSachSanPham = new();
    private readonly DichVuKho danhSachKho = new();
    
    public FormNhapKho()
    {
        InitializeComponent();
        if(TienIchGiaoDien.DangThietKe) return;
        
        TienIchGiaoDien.CauHinhLuoi(dgvSanPham);
        TienIchGiaoDien.DatGoiY(txtTimKiem);

        btnTimKiem.Click += XuLyTimKiem_Click;
        btnXacNhan.Click += XuLyNhapKho_Click;
        dgvSanPham.CellClick += XuLyChonSanPham_CellClick;
        txtMaSanPham.Leave += XuLyNhapMaSanPham_Leave;

        TaiDanhSachSanPham();
    }

    private void TaiDanhSachSanPham()
    {
        dgvSanPham.DataSource = danhSachSanPham.LayTatCa(txtTimKiem.Text);
        TienIchGiaoDien.AnCot(dgvSanPham,"ID", "Giá Bán", "Tồn Kho Tối Thiểu");
        TienIchGiaoDien.DatTieuDe(dgvSanPham,("Ma", "Mã Sản Phẩm"),("Ten","Tên Sản Phẩm")
            ,("DonVi","Đơn Vị"),("GiaVon","Giá Nhập"),("SoLuongHangTon","Tồn Kho"));
        TienIchGiaoDien.DinhDangSo(dgvSanPham,"GiaVon");
    }

    private void XuLyNhapMaSanPham_Leave(object? sender, EventArgs e)
    {
        var sp = string.IsNullOrWhiteSpace(txtMaSanPham.Text) ? null : danhSachSanPham.layTheoMa(txtMaSanPham.Text);
        lblTenSanPham.Text = sp ?.Ten ?? "Chưa Chọn";
        if(sp != null) TienIchGiaoDien.GanGiaTri(nudGiaNhap,sp.GiaVon);
    }

    private void XuLyChonSanPham_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if(e.RowIndex<0) return;
        if(dgvSanPham.Rows[e.RowIndex].DataBoundItem is not SanPham p) return;

        txtMaSanPham.Text = p.Ma;
        lblTenSanPham.Text = p.Ten;
        TienIchGiaoDien.GanGiaTri(nudGiaNhap,p.GiaVon);
    }

    private void XuLyNhapKho_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaSanPham.Text))
        {
            MessageBox.Show("Hãy chọn sản phẩm trong danh sách hoặc nhập mã sản phẩm");
            return;
        }

        var sp = danhSachSanPham.layTheoMa(txtMaSanPham.Text);
        if (sp == null)
        {
            MessageBox.Show("không tìm thấy sản phẩm có mã trên vui lòng nhập lại.");
            return;
        }

        try
        {
            danhSachKho.NhapKho(sp.Id,(int)nudSoLuong.Value,nudGiaNhap.Value);
            MessageBox.Show($"Nhập Kho Thành Công{sp.Ten}+{nudSoLuong.Value:N0}.");
            nudSoLuong.Value = 1;
            TaiDanhSachSanPham();

        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message,"Không thể nhập kho",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }

    private void XuLyTimKiem_Click(object? sender, EventArgs e)
    {
        TaiDanhSachSanPham();
    }
}
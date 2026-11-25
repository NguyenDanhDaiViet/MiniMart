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
        dtpHanSuDung.Value = DateTime.Today.AddMonths(6);
        
        btnTimKiem.Click += (_, _) => TaiDanhSachSanPham();
        txtTimKiem.TextChanged += XuLyTimKiem_TextChanged;
        btnXacNhan.Click += XuLyNhapKho_Click;
        dgvSanPham.CellClick += XuLyChonSanPham_CellClick;
        txtMaSanPham.Leave += XuLyNhapMaSanPham_Leave;
        txtMaNhaCungCap.Leave += XuLyNhapMaNhaCungCap_Leave;

        TaiDanhSachSanPham();
    }

    private void TaiDanhSachSanPham()
    {
        dgvSanPham.DataSource = danhSachSanPham.LayTatCa(txtTimKiem.Text);
        TienIchGiaoDien.AnCot(dgvSanPham,"Id", "GiaBan", "TonKhoToiThieu");
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
    
    private void XuLyNhapMaNhaCungCap_Leave(object? sender, EventArgs e)
    {
        var ncc = danhSachKho.LayNhaCungCapTheoMa(txtMaNhaCungCap.Text);
        if (ncc == null) return;

        txtTenNhaCungCap.Text = ncc.Ten;
        txtSoDienThoaiNhaCungCap.Text = ncc.SoDienThoai;
        txtDiaChiNhaCungCap.Text = ncc.DiaChi;
        txtEmailNhaCungCap.Text = ncc.Email;
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
            var nhaCungCap = new ThongTinNhaCungCap(
                txtMaNhaCungCap.Text, txtTenNhaCungCap.Text, txtSoDienThoaiNhaCungCap.Text,
                txtDiaChiNhaCungCap.Text, txtEmailNhaCungCap.Text, txtGhiChu.Text);

            string maPhieu = danhSachKho.NhapKho(sp.Id, (int)nudSoLuong.Value, nudGiaNhap.Value, nhaCungCap,
                txtMaLo.Text, dtpNgaySanXuat.Checked ? dtpNgaySanXuat.Value.Date : null,
                dtpHanSuDung.Checked ? dtpHanSuDung.Value.Date : null);
            MessageBox.Show($"Nhập kho thành công: {sp.Ten} +{nudSoLuong.Value:N0}.\nNhà cung cấp: {txtTenNhaCungCap.Text.Trim()}\nMã phiếu: {maPhieu}",
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            nudSoLuong.Value = 1;
            txtMaLo.Clear(); dtpNgaySanXuat.Checked = false; dtpHanSuDung.Checked = false;
            txtGhiChu.Clear(); 
            TaiDanhSachSanPham();

        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message,"Không thể nhập kho",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }

    private void XuLyTimKiem_TextChanged(object? sender, EventArgs e)
    {
        TaiDanhSachSanPham();
    }
}
using MiniMart.Services;
using MiniMart.Ui;

namespace MiniMart.Forms;

public partial class FormQuanLyTaiKhoan : Form
{
    private const string VaiTroQuanLy = "Quản Lý";
    private const string VaiTroNhanVien = "Nhân viên";
    
    private int Iddachon;
    private string Tennguoidungdachon= "";
    public FormQuanLyTaiKhoan()
    {
        InitializeComponent();
        if(TienIchGiaoDien.DangThietKe) return;
        
        TienIchGiaoDien.CauHinhLuoi(dgvTaiKhoan);
        TienIchGiaoDien.DatGoiY(txtTimKiem);
        
        cboVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
        cboVaiTro.Items.AddRange(new object[] {VaiTroQuanLy,VaiTroNhanVien});
        txtMatKhau.UseSystemPasswordChar = true;

        btnTimKiem.Click += XuLyTimKiem_Click;
        btnLamMoi.Click += XuLyTaoMoi_Click;
        btnLuu.Click += XuLyLuu_Click;
        btnKhoaMoKhoa.Click += XuLyKhoaTaiKhoan_Click;
        dgvTaiKhoan.CellClick += XuLyChonTaiKhoan_CellClick;

        XoaDuLieuNhap();
        TaiDanhSachTaiKhoan();
        
    }

    private void TaiDanhSachTaiKhoan()
    {
        dgvTaiKhoan.DataSource = DichVuTaiKhoan.LayTatCa(txtTimKiem.Text);
        TienIchGiaoDien.AnCot(dgvTaiKhoan, "Id");
        TienIchGiaoDien.DatTieuDe(dgvTaiKhoan, ("TenNguoiDung", "Tên đăng nhập"), ("TenHienThi", "Họ và tên"),
            ("VaiTro", "Vai trò"), ("TrangThai", "Trạng thái"));
    }

    public void XoaDuLieuNhap()
    {
        Iddachon=0;
        Tennguoidungdachon="";
        textBox2.Clear();
        txtHoTen.Clear();
        txtMatKhau.Clear();
        cboVaiTro.SelectedIndex = 1;//mặc định nhân viên
        dgvTaiKhoan.ClearSelection();
    }
    private void XuLyTimKiem_Click(object? sender, EventArgs e)=> TaiDanhSachTaiKhoan();
    private void XuLyTaoMoi_Click(object? sender, EventArgs e)=> XoaDuLieuNhap();

    private void XuLyLuu_Click(object? sender, EventArgs e)
    {
        try
        {
            DichVuTaiKhoan.Luu(Iddachon, textBox2.Text, txtHoTen.Text,
               Convert.ToString(cboVaiTro.SelectedItem)?? VaiTroNhanVien, txtMatKhau.Text );
            TaiDanhSachTaiKhoan();
            XoaDuLieuNhap();
            MessageBox.Show("Đã lưu tài khoản.");
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, "Không thể  lưu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void XuLyKhoaTaiKhoan_Click(object? sender, EventArgs e)
    {
        if (Iddachon == 0) return;
        if (Tennguoidungdachon=="quanly")
        {
            MessageBox.Show("Không tể khóa tài khoản quản trị mặc định (quanly).");
            return;
        }

        if (MessageBox.Show("Thay đổi trạng thái khóa/mở tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo)!=DialogResult.Yes) return;
        
        DichVuTaiKhoan.ChuyenTrangThaiHoatDong(Iddachon);
        TaiDanhSachTaiKhoan();
      
    }

    private void XuLyChonTaiKhoan_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        var row = dgvTaiKhoan.Rows[e.RowIndex];

        Iddachon = Convert.ToInt32(row.Cells["Id"].Value);
        Tennguoidungdachon = Convert.ToString(row.Cells["TenNguoiDung"].Value);
        textBox2.Text = Tennguoidungdachon;
        txtHoTen.Text = Convert.ToString(row.Cells["TenHienThi"].Value);
        
        int viTri = cboVaiTro.FindStringExact(Convert.ToString(row.Cells["VaiTro"].Value));
        cboVaiTro.SelectedIndex = viTri >= 0 ? viTri : 1;
        txtMatKhau.Clear(); 
    }
}
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
        cboVaiTro.Items.AddRange(new object[] {VaiTroQuanLy, VaiTroNhanVien});
        txtMatKhau.UseSystemPasswordChar = true;
        
        btnTimKiem.Click += (_, _) => TaiDanhSachTaiKhoan();
        btnLamMoi.Click += XuLyTaoMoi_Click;
        btnLuu.Click += XuLyLuu_Click;
        btnKhoaMoKhoa.Click += XuLyKhoaTaiKhoan_Click;
        dgvTaiKhoan.CellClick += XuLyChonTaiKhoan_CellClick;
        chkHienMatKhau.CheckedChanged += XuLyHienMatKhau_CheckedChanged;

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
        txtTenDangNhap.Clear();
        txtHoTen.Clear();
        txtMatKhau.Clear();
        chkHienMatKhau.Checked = false;
        cboVaiTro.SelectedIndex = 1;
        dgvTaiKhoan.ClearSelection();
    }

    private void XuLyHienMatKhau_CheckedChanged(object? sender, EventArgs e)
        => txtMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked;
    private void XuLyTaoMoi_Click(object? sender, EventArgs e)=> XoaDuLieuNhap();

    private void XuLyLuu_Click(object? sender, EventArgs e)
    {
        try
        {
            bool laThemMoi = Iddachon == 0;
            bool datLaiMatKhau = !string.IsNullOrWhiteSpace(txtMatKhau.Text);
            DichVuTaiKhoan.Luu(Iddachon, txtTenDangNhap.Text, txtHoTen.Text,
               Convert.ToString(cboVaiTro.SelectedItem)?? VaiTroNhanVien, txtMatKhau.Text );
            TaiDanhSachTaiKhoan();
            XoaDuLieuNhap();
            string thongBao = laThemMoi ? "Thêm tài khoản thành công." : "Cập nhật tài khoản thành công.";
            if (datLaiMatKhau) thongBao += "\nNgười dùng sẽ phải đổi mật khẩu ở lần đăng nhập tới.";
            MessageBox.Show(thongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, "Không thể lưu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void XuLyKhoaTaiKhoan_Click(object? sender, EventArgs e)
    {
        if (Iddachon == 0) return;
        if (Tennguoidungdachon=="quanly")
        {
            MessageBox.Show("Không thể khóa tài khoản quản lý mặc định (quanly).");
            return;
        }

        if (MessageBox.Show("Thay đổi trạng thái khóa/mở tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo)!=DialogResult.Yes) return;
        
        DichVuTaiKhoan.ChuyenTrangThaiHoatDong(Iddachon);
        TaiDanhSachTaiKhoan();
        MessageBox.Show("Khóa / mở khóa tài khoản thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
      
    }

    private void XuLyChonTaiKhoan_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        var row = dgvTaiKhoan.Rows[e.RowIndex];

        Iddachon = Convert.ToInt32(row.Cells["Id"].Value);
        Tennguoidungdachon = Convert.ToString(row.Cells["TenNguoiDung"].Value) ?? "";
        txtTenDangNhap.Text = Tennguoidungdachon;
        txtHoTen.Text = Convert.ToString(row.Cells["TenHienThi"].Value);
        
        int viTri = cboVaiTro.FindStringExact(Convert.ToString(row.Cells["VaiTro"].Value));
        cboVaiTro.SelectedIndex = viTri >= 0 ? viTri : 1;
        txtMatKhau.Clear();
    }
}

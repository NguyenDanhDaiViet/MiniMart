using MiniMart.Services;
using MiniMart.Ui;

namespace MiniMart.Forms;

public partial class FormThongTinTaiKhoan : Form
{
    public FormThongTinTaiKhoan()
    {
        InitializeComponent();
        if (TienIchGiaoDien.DangThietKe) return;
        
        txtTenDangNhap.Text = FormDangNhap.hienThiTen;
        txtHoTen.Text = FormDangNhap.hienTenHienTai;
        txtVaiTro.Text = FormDangNhap.VaiTro;

        btnDoiMatKhau.Click += XuLyDoiMatKhau_Click;
        btnDong.Click += XuLyDong_Click;
        chkHienMatKhau.CheckedChanged += XuLyHienMatKhau_CheckedChanged;
    }

    private void XuLyDong_Click(object? sender, EventArgs e) => Close();

    private void XuLyDoiMatKhau_Click(object? sender, EventArgs e)
    {
        if (txtMatKhauCu.Text.Length == 0 || txtMatKhauMoi.Text.Length == 0 || txtXacNhanMatKhau.Text.Length == 0)
        {
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin.",
                "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (txtMatKhauMoi.Text != txtXacNhanMatKhau.Text)
        {
            MessageBox.Show("Mật khẩu mới và phần nhập lại không khớp.",
                "Không thể đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtXacNhanMatKhau.Focus();
            return;
        }

        if (txtMatKhauMoi.Text == txtMatKhauCu.Text)
        {
            MessageBox.Show("Mật khẩu mới phải khác mật khẩu hiện tại.",
                "Không thể đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMatKhauMoi.Focus();
            return;
        }

        try
        {
            DichVuTaiKhoan.DoiMatKhau(FormDangNhap.hienThiTen, txtMatKhauCu.Text, txtMatKhauMoi.Text);
            MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Không thể đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMatKhauCu.Focus();
        }
    }

    private void XuLyHienMatKhau_CheckedChanged(object? sender, EventArgs e)
    {
        bool an = !chkHienMatKhau.Checked;
        txtMatKhauCu.UseSystemPasswordChar = an;
        txtMatKhauMoi.UseSystemPasswordChar = an;
        txtXacNhanMatKhau.UseSystemPasswordChar = an;
    }
}
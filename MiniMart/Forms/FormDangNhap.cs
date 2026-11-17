using MiniMart.Services;
using MiniMart.Ui;

namespace MiniMart.Forms;

public partial class FormDangNhap : Form
{
    public static string hienThiTen { get; private set; } = "";
    public static string VaiTro { get; private set; } = "";
    public FormDangNhap()
    {
        InitializeComponent();
        if(TienIchGiaoDien.DangThietKe) return;

        AcceptButton = btDangNhap; // nhan enter de dang nhap
        btDangNhap.Click += XuLyDangNhap_Click;
        hienMatKhau.CheckedChanged += XuLyHienMatKhau_CheckedChanged;
    }

    private void XuLyDangNhap_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(tenDangNhap.Text) || string.IsNullOrWhiteSpace(matKhau.Text))
        {
            MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thiếu thông tin", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return;
        }

        if (DichVuTaiKhoan.DangNhap(tenDangNhap.Text, matKhau.Text, out var name, out var vaitro))
        {
            hienThiTen = name;
            VaiTro = vaitro;
            DialogResult = DialogResult.OK;
            Close();
        }
        else
        {
            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng hoặc tài khoản đã bị khóa.",
                "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void XuLyHienMatKhau_CheckedChanged(object? sender, EventArgs e)
        => matKhau.PasswordChar = hienMatKhau.Checked ? '\0' : '*';
}
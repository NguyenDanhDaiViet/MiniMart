using MiniMart.Services;
using MiniMart.Ui;

namespace MiniMart.Forms;

public partial class FormDangNhap : Form
{
    public static string hienThiTen { get; private set; } = "";
    public static string hienTenHienTai { get; private set; } = "";
    public static string VaiTro { get; private set; } = "";

    public static void XoaPhienDangNhap()
    {
        hienThiTen = "";
        hienTenHienTai = "";
        VaiTro = "";
    }

    public FormDangNhap()
    {
        InitializeComponent();
        if(TienIchGiaoDien.DangThietKe) return;

        AcceptButton = btDangNhap; 
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
            hienThiTen = tenDangNhap.Text.Trim();
            hienTenHienTai = name;
            VaiTro = vaitro;
            
            if (DichVuTaiKhoan.CanDoiMatKhau(hienThiTen))
            {
                MessageBox.Show("Đây là lần đăng nhập đầu tiên. Vui lòng đổi mật khẩu để tiếp tục.",
                    "Yêu cầu đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using var doiMatKhau = new FormThongTinTaiKhoan(batBuocDoiMatKhau: true);
                if (doiMatKhau.ShowDialog(this) != DialogResult.OK)
                {
                    XoaPhienDangNhap();
                    MessageBox.Show("Bạn chưa đổi mật khẩu nên chưa thể vào hệ thống.", "Chưa đổi mật khẩu",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    matKhau.Clear();
                    matKhau.Focus();
                    return;
                }
            }

            DichVuLichSuHoatDong.Ghi("Đăng nhập", "Đăng nhập hệ thống thành công");
            MessageBox.Show($"Đăng nhập thành công. Xin chào {name}!", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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
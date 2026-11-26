using MiniMart.Ui;

namespace MiniMart.Forms;

public partial class MainForm : Form
{
    private bool DangTrongCheDoThietke() => DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime;
    private Form? _activeFrom;
    private Button? _nutDangChon;
    
    private static readonly Color MauNutMenu = Color.FromArgb(0, 0, 192);

    public bool DangXuat { get; private set; }

    public MainForm()
    {
        InitializeComponent();
        if (DangTrongCheDoThietke()) return;
        
        btBanHang.Click += btBanHang_Click;
        btnLichSuDon.Click += btnLichSuDon_Click;
        btSanPham.Click += btSanPham_Click;
        btNhapKho.Click += btNhapKho_Click;
        btnLichSuNhapKho.Click += btnLichSuNhapKho_Click;
        btCanhBao.Click += btCanhBao_Click;
        btBaoCao.Click += btBaoCao_Click;
        btTaiKhoan.Click += btTaiKhoan_Click;
        btnKhachHang.Click += btnKhachHang_Click;
        btnLichSuHoatDong.Click += btnLichSuHoatDong_Click;
        btnHanSuDung.Click += btnHanSuDung_Click;
        btnKhuyenMai.Click += btnKhuyenMai_Click;
        btnQuanLyCa.Click += btnQuanLyCa_Click;
        btnDangXuat.Click += btnDangXuat_Click;
        btnNguoiDung.Click += btNguoiDung_Click;

        MoManHinh(new FormBanHang());
        ChonNut(btBanHang);
    }
    

    private void btnDangXuat_Click(object? sender, EventArgs e)
    {
        if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

        FormDangNhap.XoaPhienDangNhap();
        MessageBox.Show("Đăng xuất thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        DangXuat = true;
        Close();
    }

    private void btNguoiDung_Click(object? sender, EventArgs e)
    {
        using var f = new FormThongTinTaiKhoan();
        f.ShowDialog(this);
    }
    
    private void ChonNut(Button nut)
    {
        if (_nutDangChon != null)
        {
            _nutDangChon.BackColor = MauNutMenu;
            _nutDangChon.ForeColor = Color.White;
        }
        _nutDangChon = nut;
        _nutDangChon.BackColor = TienIchGiaoDien.VangDangChon;
        _nutDangChon.ForeColor = TienIchGiaoDien.XanhDam;
    }

    private void MoManHinh(Form page)
    {
        _activeFrom?.Close();
        _activeFrom = page;
        page.WindowState = FormWindowState.Normal;
        page.TopLevel = false;
        page.FormBorderStyle = FormBorderStyle.None;
        page.Dock = DockStyle.Fill;

        manHinh.AutoScroll = true;
        manHinh.Controls.Clear();
        manHinh.Controls.Add(page);
        page.Show();
    }

    private void Mo(Button nut, Func<Form> taoForm)
    {
        ChonNut(nut);
        MoManHinh(taoForm());
    }

    private void btBanHang_Click(object? sender, EventArgs e) => Mo(btBanHang, () => new FormBanHang());
    private void btnLichSuDon_Click(object? sender, EventArgs e) => Mo(btnLichSuDon, () => new FormLichSuDonHang());
    private void btSanPham_Click(object? sender, EventArgs e) => Mo(btSanPham, () => new FormSanPham());
    private void btNhapKho_Click(object? sender, EventArgs e) => Mo(btNhapKho, () => new FormNhapKho());
    private void btnLichSuNhapKho_Click(object? sender, EventArgs e) => Mo(btnLichSuNhapKho, () => new FormLichSuNhapKho());
    private void btCanhBao_Click(object? sender, EventArgs e) => Mo(btCanhBao, () => new FormCanhBao());
    private void btBaoCao_Click(object? sender, EventArgs e) => Mo(btBaoCao, () => new FormBaoCaoThongKe());
    private void btTaiKhoan_Click(object? sender, EventArgs e) => Mo(btTaiKhoan, () => new FormQuanLyTaiKhoan());
    
    private void btnKhachHang_Click(object? sender, EventArgs e) => Mo(btnKhachHang, () => new FormKhachHang());
    private void btnLichSuHoatDong_Click(object? sender, EventArgs e) => Mo(btnLichSuHoatDong, () => new FormLichSuHoatDong());
    private void btnHanSuDung_Click(object? sender, EventArgs e) => Mo(btnHanSuDung, () => new FormHanSuDung());
    private void btnKhuyenMai_Click(object? sender, EventArgs e) => Mo(btnKhuyenMai, () => new FormKhuyenMai());
    private void btnQuanLyCa_Click(object? sender, EventArgs e) => Mo(btnQuanLyCa, () => new FormQuanLyCa());

    private void MainForm_Load(object? sender, EventArgs e)
    {
        if (DangTrongCheDoThietke()) return;
        Text = $"MiniMart - {FormDangNhap.hienTenHienTai}";
        btnNguoiDung.Text = string.IsNullOrWhiteSpace(FormDangNhap.hienTenHienTai)
            ? FormDangNhap.hienThiTen
            : FormDangNhap.hienTenHienTai;
        btTaiKhoan.Visible = FormDangNhap.VaiTro == "Quản Lý";
    }
}

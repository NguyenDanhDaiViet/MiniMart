namespace MiniMart.Forms;

public partial class MainForm : Form
{
    private bool DangTrongCheDoThietke() => DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime;
    private Form? _activeFrom;
    
    public bool DangXuat { get; private set; }
    public MainForm()
    {
        InitializeComponent();
        if(DangTrongCheDoThietke()) return;
        
        btBanHang.Click += btBanHang_Click;
        
        btSanPham.Click += btSanPham_Click;
        btNhapKho.Click += btNhapKho_Click;
        btnLichSuDon.Click += btnLichSuDon_Click;
        btCanhBao.Click += btCanhBao_Click;
        btBaoCao.Click += btBaoCao_Click;
        btTaiKhoan.Click += btTaiKhoan_Click;
        btnNguoiDung.Click += btNguoiDung_Click;
        btnDangXuat.Click += btnDangXuat_Click;
        
        MoManHinh(new FormBanHang());
        
        
    }

    private void btnDangXuat_Click(object? sender, EventArgs e)
    { 
       if(MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
       
       FormDangNhap.XoaPhienDangNhap();
       DangXuat = true;
       Close();
    }

    private void btNguoiDung_Click(object? sender, EventArgs e)
    {
        using var f = new FormThongTinTaiKhoan();
        f.ShowDialog(this);
    }

    private void MoManHinh(Form page)
    {
        _activeFrom?.Close();
        _activeFrom = page;
        page.WindowState = FormWindowState.Normal;
        page.TopLevel= false;
        page.FormBorderStyle = FormBorderStyle.None;
        page.Dock = DockStyle.Fill;
        
        manHinh.AutoScroll = true;
        manHinh.Controls.Clear();
        manHinh.Controls.Add(page);
        page.Show();
    }
    private void btnLichSuDon_Click(object? sender, EventArgs e)
    {
        MoManHinh(new FormLichSuDonHang());
    }


    private void btBanHang_Click(object? sender, EventArgs e)
    {
        MoManHinh(new FormBanHang());
    }

    private void btSanPham_Click(object? sender, EventArgs e)
    {
        MoManHinh(new FormSanPham());
    }

    private void btNhapKho_Click(object? sender, EventArgs e)
    {
        MoManHinh(new FormNhapKho());
    }

    private void btCanhBao_Click(object? sender, EventArgs e)
    {
        MoManHinh(new FormCanhBao());
    }

    private void btBaoCao_Click(object? sender, EventArgs e)
    {
        MoManHinh(new FormBaoCaoThongKe());
    }

    private void btTaiKhoan_Click(object? sender, EventArgs e)
    {
        MoManHinh(new FormQuanLyTaiKhoan());
    }

    private void MainForm_Load(object? sender, EventArgs e)
    {
        if(DangTrongCheDoThietke()) return;
        Text = $"MiniMart - {FormDangNhap.hienTenHienTai}";
        btnNguoiDung.Text = string.IsNullOrWhiteSpace(FormDangNhap.hienTenHienTai)
            ? FormDangNhap.hienThiTen
            : FormDangNhap.hienTenHienTai;
        btTaiKhoan.Visible = FormDangNhap.VaiTro == "Quản Lý";
    }
}
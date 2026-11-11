namespace MiniMart.Forms;

public partial class MainForm : Form
{
    private bool DangTrongCheDoThietke() => DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime;
    private Form? _activeFrom;
    public MainForm()
    {
        InitializeComponent();
        if(DangTrongCheDoThietke()) return;
        
        btBanHang.Click += btBanHang_Click;
        btSanPham.Click += btSanPham_Click;
        btNhapKho.Click += btNhapKho_Click;
        btCanhBao.Click += btCanhBao_Click;
        btBaoCao.Click += btBaoCao_Click;
        btTaiKhoan.Click += btTaiKhoan_Click;
        MoManHinh(new FormBanHang());
        
        
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
        Text = $"MiniMart - {FormDangNhap.hienThiTen}";
        btTaiKhoan.Visible = FormDangNhap.tenThi == "Quản Lý";
    }
}
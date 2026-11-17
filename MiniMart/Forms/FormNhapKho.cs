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
        
        TienIchGiaoDien.CauHinhLuoi(dataGridView1);
        TienIchGiaoDien.DatGoiY(textBox1);

        button1.Click += XuLyTimKiem_Click;
        button2.Click += XuLyNhapKho_Click;
        dataGridView1.CellClick += XuLyChonSanPham_CellClick;
        textBox2.Leave += XuLyNhapMaSanPham_Leave;

        TaiDanhSachSanPham();
    }

    private void TaiDanhSachSanPham()
    {
        dataGridView1.DataSource = danhSachSanPham.LayTatCa(textBox1.Text);
        TienIchGiaoDien.AnCot(dataGridView1,"ID", "Giá Bán", "Tồn Kho Tối Thiểu");
        TienIchGiaoDien.DatTieuDe(dataGridView1,("Ma", "Mã Sản Phẩm"),("Ten","Tên Sản Phẩm")
            ,("DonVi","Đơn Vị"),("GiaNhap","Giá Nhập"),("TonKho","Tồn Kho"));
        TienIchGiaoDien.DinhDangSo(dataGridView1,"GiaNhap");
    }

    private void XuLyNhapMaSanPham_Leave(object? sender, EventArgs e)
    {
        var sp = string.IsNullOrWhiteSpace(textBox2.Text) ? null : danhSachSanPham.layTheoMa(textBox2.Text);
        label3.Text = sp ?.Ten ?? "Chưa Chọn";
        if(sp != null) TienIchGiaoDien.GanGiaTri(numericUpDown2,sp.GiaVon);
    }

    private void XuLyChonSanPham_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if(e.RowIndex<0) return;
        if(dataGridView1.Rows[e.RowIndex].DataBoundItem is not SanPham p) return;

        textBox2.Text = p.Ma;
        label3.Text = p.Ten;
        TienIchGiaoDien.GanGiaTri(numericUpDown2,p.GiaVon);
    }

    private void XuLyNhapKho_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBox2.Text))
        {
            MessageBox.Show("Hãy chọn sản phẩm trong danh sách hoặc nhập mã sản phẩm");
            return;
        }

        var sp = danhSachSanPham.layTheoMa(textBox2.Text);
        if (sp == null)
        {
            MessageBox.Show("không tìm thấy sản phẩm có mã trên vui lòng nhập lại.");
            return;
        }

        try
        {
            danhSachKho.NhapKho(sp.Id,(int)numericUpDown1.Value,numericUpDown2.Value);
            MessageBox.Show($"Nhập Kho Thành Công{sp.Ten}+{numericUpDown1.Value:N0}.");
            numericUpDown1.Value = 1;
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
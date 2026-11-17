using MiniMart.Model;
using MiniMart.Services;
using MiniMart.Ui;

namespace MiniMart.Forms;

public partial class FormCanhBao : Form
{
    private readonly DichVuBaoCao _canhBao = new();
    public FormCanhBao()
    {
        InitializeComponent();
        if(TienIchGiaoDien.DangThietKe) return;
        
        TienIchGiaoDien.CauHinhLuoi(dataGridView1);
        button1.Click += XuLyLamMoi_Click;
        TaiDanhSachCanhBao();
    }
    private void TaiDanhSachCanhBao()
    {
        var data = _canhBao.LaySanPhamSapHet()
            .Select(x => new { SanPham = x.Ten, tonKhoHienTai = x.Cophan, TonKhoToiThieu = x.Tonkhotoithieu })
            .ToList();
        dataGridView1.DataSource = data;
        TienIchGiaoDien.DatTieuDe(dataGridView1,("SanPham","Sản Phẩm"),("tonKhoHienTai","Tồn Kho Hiện Tại"),
            ("TonKhoToiThieu","Tồn Kho Tối Thiểu"));
        label2.Text = $"Có {data.Count} sản phẩm cần chú ý nhập thêm.";
    }

    private void XuLyLamMoi_Click(object? sender, EventArgs e)
    {
        TaiDanhSachCanhBao();
    }
}
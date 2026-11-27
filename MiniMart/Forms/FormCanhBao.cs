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
        
        TienIchGiaoDien.CauHinhLuoi(dgvCanhBao);
        btnLamMoi.Click += XuLyLamMoi_Click;
    }
    private void TaiDanhSachCanhBao()
    {
        var data = _canhBao.LaySanPhamSapHet()
            .Select(x => new { SanPham = x.Ten, tonKhoHienTai = x.Cophan, TonKhoToiThieu = x.Tonkhotoithieu })
            .ToList();
        dgvCanhBao.DataSource = data;
        TienIchGiaoDien.DatTieuDe(dgvCanhBao,("SanPham","Sản Phẩm"),("tonKhoHienTai","Tồn Kho Hiện Tại"),
            ("TonKhoToiThieu","Tồn Kho Tối Thiểu"));
        lblSoLuongCanhBao.Text = $"Có {data.Count} sản phẩm cần chú ý nhập thêm.";
    }

    private void XuLyLamMoi_Click(object? sender, EventArgs e)
    {
        TaiDanhSachCanhBao();
    }
}
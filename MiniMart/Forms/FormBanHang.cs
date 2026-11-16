using MiniMart.Model;
using MiniMart.Services;
using MiniMart.Ui;

namespace MiniMart.Forms;

public partial class FormBanHang : Form
{
    public readonly DichVuBanHang _sales = new();
    public readonly List<MatHangGioHang> _cart = new();
    public FormBanHang()
    {
        InitializeComponent();
        if (TienIchGiaoDien.DangThietKe) return;
        
        TienIchGiaoDien.CauHinhLuoi(dgvSanPham);
        TienIchGiaoDien.CauHinhLuoi(dgvGioHang);
        TienIchGiaoDien.DatGoiY(txtTimKiem);
        
        btnThemVaoGio.Click += XuLyThemSanPham_Click;
    }

    private void ThemSanPhamDaChon()
    {
        if (dgvSanPham.CurrentRow?.DataBoundItem is not SanPham p)
        {
            MessageBox.Show("Hãy chọn một sản phẩm trong danh sách.");
            return;
        }

        if (p.SoLuongHangTon <= 0)
        {
            MessageBox.Show("Sản phẩm đã hết hàng.");
            return;
        }

        var item = _cart.FirstOrDefault(x => x.IdSanPham == p.Id);
        if (item == null)
            _cart.Add(new MatHangGioHang(){ IdSanPham = p.Id, Ma = p.Ma, Ten = p.Ten, DonVi = p.DonVi, SoLuong = 1, SoLuongHangTon = p.SoLuongHangTon, DonGia = p.GiaBan});
        else if (item.SoLuong < item.SoLuongHangTon)
            item.SoLuong++;
        else
        {
            MessageBox.Show("Số lượng hàng trong giỏ vượt quá lượng hàng tồn kho");
            return;
        }
    }
    
    private void XuLyThemSanPham_Click(Object? sender, EventArgs e) => ThemSanPhamDaChon();
}
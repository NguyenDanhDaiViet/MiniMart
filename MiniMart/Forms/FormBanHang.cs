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
        btnCapNhat.Click += XuLyCapNhatSoLuong_Click;
        btnBoDong.Click += XuLyBoDong_Click;
        btnThanhToan.Click += XuLyThanhToan_Click;
    }
    
    private void XuLyThemSanPham_Click(Object? sender, EventArgs e) => ThemSanPhamDaChon();
    
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
    private void XuLyCapNhatSoLuong_Click(Object? sender, EventArgs e)
    {
        if (dgvSanPham.CurrentRow == null) return;
        int id = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["IdSanPham"].Value);
        var item = _cart.FirstOrDefault(x => x.IdSanPham == id);
        if (item == null) return;

        int qty = (int) nudSoLuong.Value;
        item.PhanTramChietKhau = nudGiamGia.Value;
    }

    private void XuLyBoDong_Click(Object? sender, EventArgs e)
    {
        if (dgvSanPham.CurrentCell == null) return;
        int id = Convert.ToInt32(dgvGioHang.CurrentRow.Cells["IdSanPham"].Value);
        _cart.RemoveAll(x => x.IdSanPham == id);
    }
    
    private void XyLyThanhToan_Click(Object? sender, EventArgs e)
    {
        try
        {
            decimal KhachDua = TienIchGiaoDien.DocSoTien(txtKhachDua.Text);
            decimal Tong = TinhTongCong();

            int id = _sales.ThanhToan(_cart, nudGiamGia.Value, KhachDua);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Thanh toán thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    
}
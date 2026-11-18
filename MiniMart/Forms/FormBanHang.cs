using MiniMart.Model;
using MiniMart.Services;
using MiniMart.Ui;

namespace MiniMart.Forms;

public partial class FormBanHang : Form
{
    public readonly DichVuBanHang _sales = new();
    public readonly DichVuSanPham _products = new();
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
        dgvSanPham.CellDoubleClick += XuLyNhanDoiSanPham_CellDoubleClick;
        dgvGioHang.CellClick += XuLyChonDongGioHang_CellClick;
        nudGiamGia.ValueChanged += XuLyThayDoiGiamGiaHoaDon_ValueChanged;
        txtKhachDua.Leave += XuLyDinhDangTienKhachDua_Leave;
        
        TaiDanhSachSanPham();
        CapNhatGioHang();
    }
    
    private void XuLyThemSanPham_Click(object? sender, EventArgs e) => ThemSanPhamDaChon();
    
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
        CapNhatGioHang();
    }
    private void XuLyCapNhatSoLuong_Click(object? sender, EventArgs e)
    {
        if (dgvSanPham.CurrentRow == null) return;
        int id = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["IdSanPham"].Value);
        var item = _cart.FirstOrDefault(x => x.IdSanPham == id);
        if (item == null) return;

        int qty = (int) nudSoLuong.Value;
        if (qty > item.SoLuongHangTon)
        {
            MessageBox.Show("Số lượng vượt tồn kho");
            return;
        }

        item.SoLuong = qty;
        item.PhanTramChietKhau = nudGiamGia.Value;
        CapNhatGioHang();
    }

    private void XuLyBoDong_Click(object? sender, EventArgs e)
    {
        if (dgvSanPham.CurrentCell == null) return;
        int id = Convert.ToInt32(dgvGioHang.CurrentRow.Cells["IdSanPham"].Value);
        _cart.RemoveAll(x => x.IdSanPham == id);
        CapNhatGioHang();
    }
    
    private void XuLyThanhToan_Click(object? sender, EventArgs e)
    {
        try
        {
            decimal khachDua = TienIchGiaoDien.DocSoTien(txtKhachDua.Text);
            decimal tong = TinhTongCong();

            int id = _sales.ThanhToan(_cart, nudGiamGia.Value, khachDua);
            string hoaDon = _sales.XuatHoaDon(id);
            MessageBox.Show($"Thanh toán thành công\nTiền thừa: {khachDua - tong:NO}đ\nHóa đơn: {hoaDon}");
            
            _cart.Clear();
            txtKhachDua.Text = "0";
            nudGiamGia.Value = 0;
            CapNhatGioHang();
            TaiDanhSachSanPham();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Thanh toán thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    private decimal TinhTongCong() => _cart.Sum(x => x.ThanhTienDong) * (1 - nudGiamGia.Value / 100m);

    private void XuLyNhanDoiSanPham_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0) ThemSanPhamDaChon();
    }

    private void XuLyChonDongGioHang_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        int id = Convert.ToInt32(dgvGioHang.Rows[e.RowIndex].Cells["IdSanPham"].Value);
        var item = _cart.FirstOrDefault(x => x.IdSanPham == id);
        if (item == null) return;
        
        TienIchGiaoDien.GanGiaTri(nudSoLuong, item.SoLuong);
        TienIchGiaoDien.GanGiaTri(nudGiamGia, item.PhanTramChietKhau);
    }

    private void XuLyThayDoiGiamGiaHoaDon_ValueChanged(object? sender, EventArgs e) => CapNhatGioHang();

    private void CapNhatGioHang()
    {
        int dongDangChon = dgvGioHang.CurrentRow?.Index ?? -1;

        dgvGioHang.DataSource = null;
        dgvGioHang.DataSource = _cart.Select(x => new { x.IdSanPham, x.Ma, x.Ten, x.DonVi, x.SoLuong, x.SoLuongHangTon, x.DonGia, x.PhanTramChietKhau, x.ThanhTienDong}).ToList();
        
        TienIchGiaoDien.AnCot(dgvGioHang, "IdSanPham", "SoLuongHangTon");
        TienIchGiaoDien.DatTieuDe(dgvGioHang, ("Ma", "Mã SP: "), ("Ten", "Tên sản phẩm"), ("DonVi", "Đơn vị"), 
            ("SoLuong", "Số lượng"), ("DonGia", "Đơn giá"), ("PhanTramChietKhau", "Giảm giá (%)"), ("ThanhTienDong", "Thành tiền"));
        TienIchGiaoDien.DinhDangSo(dgvGioHang, "DonGia", "ThanhTienDong");

        if (dongDangChon >= 0 && dongDangChon < dgvGioHang.Rows.Count)
            dgvGioHang.CurrentCell = dgvGioHang.Rows[dongDangChon].Cells["Mã"];

        lblTongCong.Text = $"Tổng cộng: {TinhTongCong():N0}đ";
    }

    private void XuLyDinhDangTienKhachDua_Leave(object? sender, EventArgs e)
        => txtKhachDua.Text = TienIchGiaoDien.DocSoTien(txtKhachDua.Text).ToString("N0");

    private void TaiDanhSachSanPham()
    {
        dgvSanPham.DataSource = _products.LayTatCa(txtTimKiem.Text);
        TienIchGiaoDien.AnCot(dgvSanPham, "Id", "GiaVon", "TonKhoTonThieu");
        TienIchGiaoDien.DatTieuDe(dgvSanPham, ("Ma", "Mã SP"), ("Ten", "Tên sản phẩm"), ("DonVi", "Đơn vị"),
            ("GiaBan", "Giá bán"), ("SoLuongHangTon", "Tồn kho"));
        TienIchGiaoDien.DinhDangSo(dgvSanPham, "GiaBan");
    }
    
}
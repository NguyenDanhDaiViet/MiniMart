using MiniMart.Model;
using MiniMart.Services;
using MiniMart.Ui;

namespace MiniMart.Forms;

public partial class FormBanHang : Form
{
    
    private readonly DichVuBanHang _banHang = new();
    private readonly DichVuSanPham _sanPham = new();
    private readonly List<MatHangGioHang> _gioHang = new();

    private readonly DichVuKhuyenMai _dichVuKhuyenMai = new();
    private readonly DichVuKhachHang _dichVuKhachHang = new();
    private string _maKhuyenMai = "";
    private decimal _tienGiamKhuyenMai;
    private string _tenTuDongNhanDien = "";

    public FormBanHang()
    {
        InitializeComponent();
        if (TienIchGiaoDien.DangThietKe) return;
        
        TienIchGiaoDien.CauHinhLuoi(dgvSanPham);
        TienIchGiaoDien.CauHinhLuoi(dgvGioHang);
      
        foreach (var nut in new[] { btnTien10k, btnTien20k, btnTien50k, btnTien100k, btnTien200k, btnTien500k })
            nut.Click += XuLyTienNhanh_Click;
        btnDuTien.Click += (_, _) => { txtKhachDua.Text = TinhTongCong().ToString("N0");
            CapNhatTienThua(); };
        
        txtKhachDua.TextChanged += (_, _) => CapNhatTienThua();
        
        TienIchGiaoDien.DatGoiY(txtTimKiem);
        
        btnApDungKhuyenMai.Click += (_, _) => ApDungKhuyenMai();
        txtSoDienThoai.Leave += (_, _) => TuTimKhachHang();
        btnThemVaoGio.Click += XuLyThemSanPham_Click;
        btnCapNhat.Click += XuLyCapNhatSoLuong_Click;
        btnBoDong.Click += XuLyBoDong_Click;
        btnThanhToan.Click += XuLyThanhToan_Click;
        dgvSanPham.CellDoubleClick += XuLyNhanDoiSanPham_CellDoubleClick;
        dgvGioHang.CellClick += XuLyChonDongGioHang_CellClick;
        nudGiamGiaHoaDon.ValueChanged += XuLyThayDoiGiamGiaHoaDon_ValueChanged;
        txtKhachDua.Leave += XuLyDinhDangTienKhachDua_Leave;
        txtTimKiem.TextChanged += XuLyTimKiemSanPham_TextChanged;
        txtTimKiem.KeyDown += XuLyTimKiemSanPham_KeyDown;
        
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
        
        int soLuongThem = (int)nudSoLuong.Value;
        var item = _gioHang.FirstOrDefault(x => x.IdSanPham == p.Id);
        int soLuongHienTai = item?.SoLuong ?? 0;
        if (soLuongHienTai + soLuongThem > p.SoLuongHangTon)
        {
            MessageBox.Show($"Không đủ tồn kho. Hiện có {p.SoLuongHangTon}, trong giỏ đã có {soLuongHienTai}.",
                "Vượt tồn kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (item == null)
            _gioHang.Add(new MatHangGioHang { IdSanPham = p.Id, Ma = p.Ma, Ten = p.Ten, DonVi = p.DonVi,
                SoLuong = soLuongThem, SoLuongHangTon = p.SoLuongHangTon, DonGia = p.GiaBan });
        else
            item.SoLuong += soLuongThem;

        nudSoLuong.Value = 1;
        CapNhatGioHang();
    }
    private void XuLyCapNhatSoLuong_Click(object? sender, EventArgs e)
    {
        if (dgvGioHang.CurrentRow == null) return;
        int id = Convert.ToInt32(dgvGioHang.CurrentRow.Cells["IdSanPham"].Value);
        var item = _gioHang.FirstOrDefault(x => x.IdSanPham == id);
        if (item == null) return;

        int qty = (int) nudSoLuong.Value;
        if (qty > item.SoLuongHangTon)
        {
            MessageBox.Show("Số lượng vượt tồn kho");
            return;
        }

        item.SoLuong = qty;
        item.PhanTramChietKhau = nudGiamGiaDong.Value;
        CapNhatGioHang();
    }

    private void XuLyBoDong_Click(object? sender, EventArgs e)
    {
        if (dgvGioHang.CurrentRow == null) return;
        int id = Convert.ToInt32(dgvGioHang.CurrentRow.Cells["IdSanPham"].Value);
        _gioHang.RemoveAll(x => x.IdSanPham == id);
        CapNhatGioHang();
    }
    
    private void XuLyThanhToan_Click(object? sender, EventArgs e)
    {
        try
        {
            // Mỗi đơn hàng phải có tên và số điện thoại khách hàng
            if (_gioHang.Count > 0 && string.IsNullOrWhiteSpace(txtTenKhachHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Thiếu thông tin", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtTenKhachHang.Focus();
                return;
            }
            if (_gioHang.Count > 0 && string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng.", "Thiếu thông tin", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtSoDienThoai.Focus();
                return;
            }
            
            decimal khachDua = TienIchGiaoDien.DocSoTien(txtKhachDua.Text);
            decimal tong = TinhTongCong();

            int id = _banHang.ThanhToan(_gioHang, nudGiamGiaHoaDon.Value, khachDua, txtTenKhachHang.Text,txtSoDienThoai.Text, _maKhuyenMai);
            string hoaDon = _banHang.XuatHoaDon(id);
            MessageBox.Show($"Thanh toán thành công\nTiền thừa: {khachDua - tong:N0}đ\n\n{hoaDon}");
            
            _gioHang.Clear();
            _maKhuyenMai = ""; _tienGiamKhuyenMai = 0; txtMaKhuyenMai.Clear(); lblKhuyenMai.Text = "Chưa áp dụng mã";
            txtKhachDua.Text = "0";
            txtTenKhachHang.Clear();
            txtSoDienThoai.Clear();
            nudGiamGiaHoaDon.Value = 0;
            CapNhatGioHang();
            TaiDanhSachSanPham();
        }
        catch (Exception ex)
        {
            string chiTiet = ex.InnerException?.Message ?? ex.Message; // lỗi gốc từ database (nếu có)
            MessageBox.Show(chiTiet, "Thanh toán thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    private decimal TinhTongCong()
    {
        decimal sauGiamHoaDon = _gioHang.Sum(x => x.ThanhTienDong) * (1 - nudGiamGiaHoaDon.Value / 100m);
        if (!string.IsNullOrWhiteSpace(_maKhuyenMai))
        {
            var km = _dichVuKhuyenMai.TimMaHopLe(_maKhuyenMai, _gioHang.Sum(x => x.ThanhTienDong));
            _tienGiamKhuyenMai = km == null ? 0 : DichVuKhuyenMai.TinhTienGiam(km, sauGiamHoaDon);
        }
        return Math.Max(0, sauGiamHoaDon - _tienGiamKhuyenMai);
    }
    
    private void ApDungKhuyenMai()
    {
        try
        {
            decimal tamTinh = _gioHang.Sum(x => x.ThanhTienDong);
            if (tamTinh <= 0) throw new InvalidOperationException("Hãy thêm sản phẩm vào giỏ trước.");
            var km = _dichVuKhuyenMai.TimMaHopLe(txtMaKhuyenMai.Text, tamTinh);
            if (km == null) throw new InvalidOperationException("Mã không hợp lệ, hết hạn hoặc chưa đạt giá trị đơn tối thiểu.");
            decimal sauGiamHoaDon = tamTinh * (1 - nudGiamGiaHoaDon.Value / 100m);
            _tienGiamKhuyenMai = DichVuKhuyenMai.TinhTienGiam(km, sauGiamHoaDon);
            _maKhuyenMai = km.MaCode;
            lblKhuyenMai.Text = $"{km.MaCode}: giảm {_tienGiamKhuyenMai:N0}đ";
            CapNhatGioHang();
        }
        catch (Exception ex) { _maKhuyenMai = ""; _tienGiamKhuyenMai = 0; lblKhuyenMai.Text = "Mã không hợp lệ"; MessageBox.Show(ex.Message); CapNhatGioHang(); }
    }
    
    private void TuTimKhachHang()
    {
        var kh = _dichVuKhachHang.TimTheoSoDienThoai(txtSoDienThoai.Text);
        if (kh != null)
        {
            txtTenKhachHang.Text = kh.HoTen;
            _tenTuDongNhanDien = kh.HoTen;
            txtTenKhachHang.PlaceholderText = $"Khách thân thiết • {kh.TongSoDonHang} đơn • {kh.DiemTichLuy} điểm";
        }
        else
        {
            // Nếu tên trước đó được tự điền từ khách cũ thì xóa để tránh gắn nhầm khách.
            if (_tenTuDongNhanDien.Length > 0 && txtTenKhachHang.Text == _tenTuDongNhanDien) txtTenKhachHang.Clear();
            _tenTuDongNhanDien = "";
            txtTenKhachHang.PlaceholderText = "Khách mới • nhập họ tên để tự lưu";
        }
    }

    private void XuLyTienNhanh_Click(object? sender, EventArgs e)
    {
        if (sender is not Button nut || !int.TryParse(Convert.ToString(nut.Tag), out int menhGia)) return;
        txtKhachDua.Text = menhGia.ToString("N0");
        CapNhatTienThua();
    }
    
    private void CapNhatTienThua()
    {
        if (lblTienThua.IsDisposed) return;
        decimal thua = TienIchGiaoDien.DocSoTien(txtKhachDua.Text) - TinhTongCong();
        lblTienThua.Text = thua >= 0 ? $"Tiền thừa: {thua:N0}đ" : $"Còn thiếu: {Math.Abs(thua):N0}đ";
        lblTienThua.ForeColor = thua >= 0 ? Color.FromArgb(22, 100, 70) : Color.Firebrick;
    }

    private void XuLyNhanDoiSanPham_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0) ThemSanPhamDaChon();
    }
    
    private void XuLyChonDongGioHang_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        int id = Convert.ToInt32(dgvGioHang.Rows[e.RowIndex].Cells["IdSanPham"].Value);
        var item = _gioHang.FirstOrDefault(x => x.IdSanPham == id);
        if (item == null) return;
        
        TienIchGiaoDien.GanGiaTri(nudSoLuong, item.SoLuong);
        TienIchGiaoDien.GanGiaTri(nudGiamGiaDong, item.PhanTramChietKhau);
    }

    private void XuLyThayDoiGiamGiaHoaDon_ValueChanged(object? sender, EventArgs e) => CapNhatGioHang();

    private void CapNhatGioHang()
    {
        int dongDangChon = dgvGioHang.CurrentRow?.Index ?? -1;

        dgvGioHang.DataSource = null;
        dgvGioHang.DataSource = _gioHang.Select(x => new { x.IdSanPham, x.Ma, x.Ten, x.DonVi, x.SoLuong, x.SoLuongHangTon, x.DonGia, x.PhanTramChietKhau, x.ThanhTienDong}).ToList();
        
        TienIchGiaoDien.AnCot(dgvGioHang, "IdSanPham", "SoLuongHangTon");
        TienIchGiaoDien.DatTieuDe(dgvGioHang, ("Ma", "Mã SP"), ("Ten", "Tên sản phẩm"), ("DonVi", "Đơn vị"), 
            ("SoLuong", "Số lượng"), ("DonGia", "Đơn giá"), ("PhanTramChietKhau", "Giảm giá (%)"), ("ThanhTienDong", "Thành tiền"));
        TienIchGiaoDien.DinhDangSo(dgvGioHang, "DonGia", "ThanhTienDong");

        if (dongDangChon >= 0 && dongDangChon < dgvGioHang.Rows.Count)
            dgvGioHang.CurrentCell = dgvGioHang.Rows[dongDangChon].Cells["Ma"];

        lblTongCong.Text = $"Tổng cộng: {TinhTongCong():N0}đ";
        CapNhatTienThua();
    }
    
    private void XuLyDinhDangTienKhachDua_Leave(object? sender, EventArgs e)
        => txtKhachDua.Text = TienIchGiaoDien.DocSoTien(txtKhachDua.Text).ToString("N0");

    private void TaiDanhSachSanPham()
    {
        dgvSanPham.DataSource = _sanPham.LayTatCa(txtTimKiem.Text);
        TienIchGiaoDien.AnCot(dgvSanPham, "Id", "GiaVon", "TonKhoToiThieu");
        TienIchGiaoDien.DatTieuDe(dgvSanPham, ("Ma", "Mã SP"), ("Ten", "Tên sản phẩm"), ("DonVi", "Đơn vị"),
            ("GiaBan", "Giá bán"), ("SoLuongHangTon", "Tồn kho"));
        TienIchGiaoDien.DinhDangSo(dgvSanPham, "GiaBan");
    }
    private void XuLyTimKiemSanPham_TextChanged(object? sender, EventArgs e)
        => TaiDanhSachSanPham();

    private void XuLyTimKiemSanPham_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
        {
            txtTimKiem.Clear();
            TaiDanhSachSanPham();
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }
}
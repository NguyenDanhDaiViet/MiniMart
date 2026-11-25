using MiniMart.Model;
using MiniMart.Services;
using MiniMart.Ui;

namespace MiniMart.Forms;

public partial class FormTopSanPham : Form
{
    private readonly DichVuBaoCao _baoCao = new();
     public FormTopSanPham(DateTime tuNgay, DateTime denNgay)
    {
        InitializeComponent();
        if (TienIchGiaoDien.DangThietKe) return;

        TienIchGiaoDien.CauHinhLuoi(dgvTop);

        dtpTuNgay.Value = tuNgay;
        dtpDenNgay.Value = denNgay;
        cboSapXep.SelectedIndex = 0;  // Doanh thu
        cboHienThi.SelectedIndex = 1; // Top 20

        btnXem.Click += XuLyXem_Click;

        TaiDuLieu();
    }

    private int SoDongHienThi() => cboHienThi.SelectedIndex switch
    {
        0 => 10,
        1 => 20,
        2 => 50,
        _ => int.MaxValue
    };

    private void TaiDuLieu()
    {
        if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
        {
            MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.", "Khoảng ngày không hợp lệ",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var tatCa = _baoCao.LayThongKeSanPham(dtpTuNgay.Value.Date, dtpDenNgay.Value.Date);

        IOrderedEnumerable<ThongKeSanPham> sapXep = cboSapXep.SelectedIndex == 1
            ? tatCa.OrderByDescending(x => x.SoLuong).ThenByDescending(x => x.DoanhThu)
            : tatCa.OrderByDescending(x => x.DoanhThu).ThenByDescending(x => x.SoLuong);
        var top = sapXep.ThenBy(x => x.Ten).Take(SoDongHienThi()).ToList();

        dgvTop.DataSource = top
            .Select((x, i) => new { Hang = i + 1, x.Ma, x.Ten, x.SoLuong, x.DoanhThu })
            .ToList();

        TienIchGiaoDien.DatTieuDe(dgvTop,
            ("Hang", "Hạng"), ("Ma", "Mã SP"), ("Ten", "Tên sản phẩm"),
            ("SoLuong", "Số lượng bán"), ("DoanhThu", "Doanh thu (đ)"));
        TienIchGiaoDien.DinhDangSo(dgvTop, "SoLuong", "DoanhThu");
        if (dgvTop.Columns["Hang"] != null) dgvTop.Columns["Hang"]!.FillWeight = 20;
        if (dgvTop.Columns["Ma"] != null) dgvTop.Columns["Ma"]!.FillWeight = 50;
        if (dgvTop.Columns["Ten"] != null) dgvTop.Columns["Ten"]!.FillWeight = 200;

        lblTongKet.Text = tatCa.Count == 0
            ? "Chưa có đơn hàng nào trong khoảng ngày này."
            : $"Hiển thị {top.Count}/{tatCa.Count} sản phẩm - Tổng số lượng bán: {tatCa.Sum(x => x.SoLuong):N0}"
              + $" - Tổng doanh thu: {tatCa.Sum(x => x.DoanhThu):N0} đ";
    }

    private void XuLyXem_Click(object? sender, EventArgs e) => TaiDuLieu();

    private void label2_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }


}
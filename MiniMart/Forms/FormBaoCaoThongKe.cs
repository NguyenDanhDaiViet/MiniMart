using System.Drawing.Printing;
using MiniMart.Services;
using MiniMart.Ui;

namespace MiniMart.Forms;

public partial class FormBaoCaoThongKe : Form
{
    private readonly DichVuBaoCao _baoCao = new();
    
    public FormBaoCaoThongKe()
    {
        InitializeComponent();
        if (TienIchGiaoDien.DangThietKe)return;
        
        TienIchGiaoDien.CauHinhLuoi(dgvTopSanPham);
        btXembaocao.Click += XuLyXemBaoCao_Click;
        btInbaocao.Click += XuLyInBaoCao_Click;
        btXemtop.Click += XuLyXemTop_Click;
    }
    private void FormBaoCaoThongKe_Load(object? sender, EventArgs e)
    {
        if (TienIchGiaoDien.DangThietKe) return;

        var homNay = DateTime.Today;
        dtpTuNgay.Value = new DateTime(homNay.Year, homNay.Month, 1); 
        dtpDenNgay.Value = homNay;
        TaiBaoCao();
    }

    private bool KhoangNgayHopLe()
    {
        if (dtpTuNgay.Value.Date <= dtpDenNgay.Value.Date) return true;
        MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.", "Khoảng ngày không hợp lệ",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
    }

    private void TaiBaoCao()
    {
        if (!KhoangNgayHopLe()) return;

        var tuNgay = dtpTuNgay.Value.Date;
        var denNgay = dtpDenNgay.Value.Date;

        var tongQuan = _baoCao.LayTongQuan(tuNgay, denNgay);
        lbDoanhThu.Text = $"Doanh thu: {tongQuan.DoanhThu:N0}đ";
        lbSohoadon.Text = $"Số hóa đơn: {tongQuan.SoHoaDon}";

        var top = _baoCao.LaySanPhamBanChay(tuNgay, denNgay);
        dgvTopSanPham.DataSource = top
            .Select((x, i) => new { Hang = i + 1, SanPham = x.Ten, SoLuongBan = x.SoLuong })
            .ToList();
        TienIchGiaoDien.DatTieuDe(dgvTopSanPham, ("Hang", "Hạng"), ("SanPham", "Sản phẩm"), ("SoLuongBan", "Số lượng bán"));
        if (dgvTopSanPham.Columns["Hang"] != null) dgvTopSanPham.Columns["Hang"]!.FillWeight = 25;

        lbTopsanphambanchay.Text = top.Count == 0
            ? "TOP SẢN PHẨM BÁN CHẠY (trống)"
            : "TOP SẢN PHẨM BÁN CHẠY";
    }

    private void XuLyXemBaoCao_Click(object? sender, EventArgs e) => TaiBaoCao();
    
    private void XuLyXemTop_Click(object? sender, EventArgs e)
    {
        if (!KhoangNgayHopLe()) return;

        using var f = new FormTopSanPham(dtpTuNgay.Value.Date, dtpDenNgay.Value.Date);
        f.ShowDialog();
    }

    private void XuLyInBaoCao_Click(object? sender, EventArgs e)
    {
        if (!KhoangNgayHopLe()) return;

        var tuNgay = dtpTuNgay.Value.Date;
        var denNgay = dtpDenNgay.Value.Date;

        try
        {
            var tongQuan = _baoCao.LayTongQuan(tuNgay, denNgay);
            var top = _baoCao.LaySanPhamBanChay(tuNgay, denNgay);
            DichVuInBaoCao.In(this, tuNgay, denNgay, tongQuan.DoanhThu, tongQuan.SoHoaDon, top);
        }
        catch (InvalidPrinterException)
        {
            MessageBox.Show("Máy tính chưa có máy in nào. Hãy cài máy in (hoặc dùng Microsoft Print to PDF) rồi thử lại.",
                "Không thể in báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Không thể in báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

using System.Drawing.Printing;
using System.Globalization;

namespace MiniMart.Services;

public class DichVuInBaoCao
{
    private static readonly CultureInfo Vn = new("vi-VN");

    // Mở cửa sổ xem trước, người dùng bấm nút máy in trên cửa sổ đó để in
    public static void In(IWin32Window owner, DateTime tuNgay, DateTime denNgay,
        decimal doanhThu, int soHoaDon, List<(string Ten, int SoLuong)> topSanPham)
    {
        using var doc = new PrintDocument();
        doc.DocumentName = $"BaoCao_{tuNgay:yyyyMMdd}_{denNgay:yyyyMMdd}";
        doc.PrintPage += (_, e) => VeBaoCao(e.Graphics!, e.MarginBounds, tuNgay, denNgay, doanhThu, soHoaDon, topSanPham);

        using var xemTruoc = new PrintPreviewDialog();
        xemTruoc.Document = doc;
        xemTruoc.Width = 800;
        xemTruoc.Height = 900;
        xemTruoc.ShowDialog(owner);
    }

    private static void VeBaoCao(Graphics g, Rectangle vung, DateTime tuNgay, DateTime denNgay,
        decimal doanhThu, int soHoaDon, List<(string Ten, int SoLuong)> topSanPham)
    {
        using var fontTieuDe = new Font("Segoe UI", 18, FontStyle.Bold);
        using var fontDam = new Font("Segoe UI", 11, FontStyle.Bold);
        using var fontThuong = new Font("Segoe UI", 11);
        using var fontNghieng = new Font("Segoe UI", 11, FontStyle.Italic);
        using var canhGiua = new StringFormat { Alignment = StringAlignment.Center };
        using var canhPhai = new StringFormat { Alignment = StringAlignment.Far };

        var x = vung.Left;
        var y = (float)vung.Top;
        var rong = vung.Width;
        const int dong = 24;

        // Các cột của bảng: Hạng | Sản phẩm | Số lượng bán
        var cotSanPham = x + rong * 0.12f;
        var cotSoLuong = x + rong * 0.75f;
        var cuoiCot = x + rong;

        void Chu(string s, Font f, float left, float width, StringFormat? sf = null)
        {
            g.DrawString(s, f, Brushes.Black, new RectangleF(left, y, width, dong), sf ?? StringFormat.GenericDefault);
        }

        void KeNgang()
        {
            g.DrawLine(Pens.Black, x, y, cuoiCot, y);
        }

        void DongTongKet(string nhan, string giaTri, Font f)
        {
            Chu(nhan, f, x, cotSoLuong - x);
            Chu(giaTri, f, cotSoLuong, cuoiCot - cotSoLuong, canhPhai);
            y += dong;
        }

        g.DrawString("MINIMART", fontDam, Brushes.Black, new RectangleF(x, y, rong, dong), canhGiua);
        y += dong;
        g.DrawString("BÁO CÁO THỐNG KÊ", fontTieuDe, Brushes.Black, new RectangleF(x, y, rong, 36), canhGiua);
        y += 40;
        g.DrawString($"Từ ngày {tuNgay:dd/MM/yyyy} đến ngày {denNgay:dd/MM/yyyy}", fontThuong,
            Brushes.Black, new RectangleF(x, y, rong, dong), canhGiua);
        y += dong * 2;

        DongTongKet("Doanh thu:", $"{doanhThu.ToString("N0", Vn)} đ", fontDam);
        DongTongKet("Số hóa đơn:", soHoaDon.ToString("N0", Vn), fontThuong);
        y += dong * 0.5f;

        Chu("TOP SẢN PHẨM BÁN CHẠY", fontDam, x, rong);
        y += dong;

        if (topSanPham.Count == 0)
        {
            Chu("Không có đơn hàng nào trong khoảng ngày này.", fontNghieng, x, rong);
            y += dong;
        }
        else
        {
            KeNgang();
            y += 4;
            Chu("Hạng", fontDam, x, cotSanPham - x);
            Chu("Sản phẩm", fontDam, cotSanPham, cotSoLuong - cotSanPham);
            Chu("Số lượng bán", fontDam, cotSoLuong, cuoiCot - cotSoLuong, canhPhai);
            y += dong;
            KeNgang();
            y += 4;

            for (var i = 0; i < topSanPham.Count; i++)
            {
                Chu($"{i + 1}", fontThuong, x, cotSanPham - x);
                Chu(topSanPham[i].Ten, fontThuong, cotSanPham, cotSoLuong - cotSanPham);
                Chu(topSanPham[i].SoLuong.ToString("N0", Vn), fontThuong, cotSoLuong, cuoiCot - cotSoLuong, canhPhai);
                y += dong;
            }
        }

        KeNgang();
        y += dong;
        Chu($"In lúc: {DateTime.Now:dd/MM/yyyy HH:mm}", fontThuong, x, rong);
        y += dong * 2;
        g.DrawString("Báo cáo hệ thống MiniMart", fontDam, Brushes.Black, new RectangleF(x, y, rong, dong), canhGiua);
    }
}
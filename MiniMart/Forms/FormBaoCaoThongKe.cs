using System.Text;
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
        
        TienIchGiaoDien.CauHinhLuoi(dataGridView2);
        btXembaocao.Click += XuLyXemBaoCao_Click;
        btXuatfilecsv.Click += XuLyXuatBaoCao_Click;
    }

    private void FormBaoCaoThongKe_Load(object sender, EventArgs e)
    {
        if (TienIchGiaoDien.DangThietKe) return;

        var homnay = DateTime.Today; 
            dateTimePicker1.Value= new DateTime(homnay.Year, homnay.Month, 1);
            dateTimePicker2.Value = homnay;
            TaiBaoCao();
    }

    private bool KhoangNgayHopLe()
    {
        if (dateTimePicker1.Value.Date <= dateTimePicker2.Value.Date) return true;
        MessageBox.Show("Ngàu bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.", "Khoảng ngày không hợp lệ",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
        
    }

    private void TaiBaoCao()
    {
        if (!KhoangNgayHopLe())return;

        var Tungay = dateTimePicker1.Value.Date;
        var Denngay = dateTimePicker2.Value.Date;

        var tongQuan = _baoCao.LayTongQuan(Tungay, Denngay);
            lbDoanhThu.Text= $"Doanh thu: {tongQuan.Doanhthu:N0}đ";
            lbSohoadon.Text = $"Số hóa đơn: {tongQuan.Sohoadon}";

            dataGridView2.DataSource = _baoCao.LaySamPhamBanChay(Tungay, Denngay)
                .Select(x => new { Sanpham =x.Ten, SoLuongBan =x.Soluong })
                .ToList();
            TienIchGiaoDien.DatTieuDe(dataGridView2, ("SanPham", "Sản Phẩm"), ("SoLuongban", "Số Lượng Bán"));
    }

    private void XuLyXemBaoCao_Click(object? sender, EventArgs e) => TaiBaoCao();

    private void XuLyXuatBaoCao_Click(object? sender, EventArgs e)
    {
        if (!KhoangNgayHopLe())return;

        using var dialog = new SaveFileDialog {Filter = "CSV (*.csv)|*.csv", FileName ="BaoCaoMiniMart.csv"};
        if (dialog.ShowDialog() == DialogResult.OK)return;
            
            var rows = _baoCao.LaySamPhamBanChay(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            var lines = new[] { "Sảm phẩm,Số lượng bán" }
                .Concat(rows.Select(x => $"\"{x.Ten.Replace("\"", "\"\"")}, {x.Soluong}"));
            
            File.WriteAllLines(dialog.FileName, lines, new UTF8Encoding(true));
            MessageBox.Show("Đã xuát báo cáo");
            
    }


}
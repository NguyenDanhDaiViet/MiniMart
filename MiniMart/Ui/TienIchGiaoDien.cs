using System.ComponentModel;

namespace MiniMart.Ui;

public class TienIchGiaoDien
{
    public static readonly Color XanhDam = Color.FromArgb(22, 65, 112);
    public static readonly Color VangDangChon = Color.FromArgb(255, 232, 145);
    public static readonly Color ChuDam = Color.FromArgb(35, 48, 65);
    public static bool DangThietKe => LicenseManager.UsageMode == LicenseUsageMode.Designtime;

    public static void CauHinhLuoi(DataGridView grid)
    {
        grid.AutoGenerateColumns = true;
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;
        grid.ReadOnly = true;
        grid.MultiSelect = false;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.RowHeadersVisible = false;
        grid.BackgroundColor = Color.White;
        grid.BorderStyle = BorderStyle.None;
        grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        grid.GridColor = Color.FromArgb(226, 233, 241);
        grid.EnableHeadersVisualStyles = false;
        grid.ColumnHeadersDefaultCellStyle.BackColor = XanhDam;
        grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = XanhDam;
        grid.DefaultCellStyle.BackColor = Color.White;
        grid.DefaultCellStyle.ForeColor = ChuDam;
        grid.DefaultCellStyle.SelectionBackColor = VangDangChon;
        grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(70, 52, 0);
        grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(244, 248, 253);
        grid.RowTemplate.Height = 30;
        grid.ColumnHeadersHeight = 36;
        grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        grid.AllowUserToResizeRows = false;
        grid.DefaultCellStyle.Padding = new Padding(5, 2, 5, 2);
    }
    public static void AnCot(DataGridView grid,params string[] tenCot)
    {
        foreach (var ten in tenCot)
        {
            if(grid.Columns[ten]!=null) grid.Columns[ten]!.Visible= false;
        }
    }
    public static void DatTieuDe(DataGridView grid,params (string Cot,string tieuDe)[] danhSach)
    {
        foreach (var (cot,tieuDe) in danhSach)
        {
            if(grid.Columns[cot]!=null) grid.Columns[cot]!.HeaderText= tieuDe;
        }
    }
    public static void DinhDangSo(DataGridView grid,params string[] tenCot)
    {
        foreach (var ten in tenCot)
        {
            if(grid.Columns[ten]!=null) grid.Columns[ten]!.DefaultCellStyle.Format= "N0";
        }
    }

    public static void DatGoiY(TextBox box)
    {
        if(box.Text.Length==0) return;
        box.PlaceholderText = box.Text;
        box.Text = "";
    }
    public static void GanGiaTri(NumericUpDown nud,decimal giaTri) 
        => nud.Value = Math.Clamp(giaTri,nud.Minimum,nud.Maximum);

    public static decimal DocSoTien(string text)
    {
        string chuSo = new(text.Where(char.IsDigit).ToArray());
        return decimal.TryParse(chuSo, out var value) ? value : 0m;
    }
}

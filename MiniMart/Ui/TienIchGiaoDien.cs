using System.ComponentModel;

namespace MiniMart.Ui;

public class TienIchGiaoDien
{
    public static bool DangThietKe => LicenseManager.UsageMode == LicenseUsageMode.Designtime;

    public static void CauHinhLuoi(DataGridView grid)
    {
        grid.AutoGenerateColumns = true;
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;
        grid.ReadOnly = true;
        grid.MultiSelect= false;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.RowHeadersVisible = false;
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
            if(grid.Columns[ten]!=null) grid.Columns[ten]!.DefaultCellStyle.Format= "No";
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

    public static decimal DocSoTien(String text)
    {
        string chuSo = new(text.Where(char.IsDigit).ToArray());
        return decimal.TryParse(chuSo, out var value) ? value : 0m;
    }
}

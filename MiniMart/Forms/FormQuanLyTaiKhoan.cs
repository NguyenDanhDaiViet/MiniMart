using MiniMart.Services;
using MiniMart.Ui;

namespace MiniMart.Forms;

public partial class FormQuanLyTaiKhoan : Form
{
    private int Iddachon;
    private string Tennguoidungdachon;
    public FormQuanLyTaiKhoan()
    {
        InitializeComponent();
        if(TienIchGiaoDien.DangThietKe) return;
        
        TienIchGiaoDien.CauHinhLuoi(dataGridView1);
        TienIchGiaoDien.DatGoiY(textBox1);
        
        comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBox1.Items.AddRange(new object[] {"Admin","Nhân viên"});
        textBox4.UseSystemPasswordChar = true;

        button1.Click += XuLyTimKiem_Click;
        button2.Click += XuLyTaoMoi_Click;
        button3.Click += XuLyLuu_Click;
        button4.Click += XuLyKhoaTaiKhoan_Click;
        dataGridView1.CellClick += XuLyChonTaiKhoan_CellClick;

        XoaDuLieuNhap();
        TaiDanhSachTaiKhoan();
        
    }

    private void TaiDanhSachTaiKhoan()
    {
        dataGridView1.DataSource = DichVuTaiKhoan.LayTatCa(textBox1.Text);
        TienIchGiaoDien.AnCot(dataGridView1, "Id");
        TienIchGiaoDien.DatTieuDe(dataGridView1, ("Username", "Tên đăng nhập"), ("DisplayName", "Họ và tên"),
            ("Role", "Vai trò"), ("status", "Trạng thái"));
    }

    public void XoaDuLieuNhap()
    {
        Iddachon=0;
        Tennguoidungdachon="";
        textBox2.Clear();
        textBox3.Clear();
        textBox4.Clear();
        comboBox1.SelectedIndex = 1;//mặc định nhân viên
        dataGridView1.ClearSelection();
    }
    private void XuLyTimKiem_Click(object? sender, EventArgs e)=> TaiDanhSachTaiKhoan();
    private void XuLyTaoMoi_Click(object? sender, EventArgs e)=> XoaDuLieuNhap();

    private void XuLyLuu_Click(object? sender, EventArgs e)
    {
        try
        {
            DichVuTaiKhoan.Luu(Iddachon, textBox2.Text, textBox3.Text,
               Convert.ToString(comboBox1.SelectedItem)?? "Nhân viên", textBox4.Text );
            TaiDanhSachTaiKhoan();
            XoaDuLieuNhap();
            MessageBox.Show("Đã lưu tài khoản.");
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, "Không thể  lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void XuLyKhoaTaiKhoan_Click(object? sender, EventArgs e)
    {
        if (Iddachon == 0) ;
        if (Tennguoidungdachon=="admin")
        {
            MessageBox.Show("Không tể khóa tài khoản quản trị mặc định (admin).");
            return;
        }

        if (MessageBox.Show("Thay đổi trạng thái khóa/mở tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo)!=DialogResult.Yes) return;
        
        DichVuTaiKhoan.ChuyenTrangThaiHoatDong(Iddachon);
        TaiDanhSachTaiKhoan();
      
    }

    private void XuLyChonTaiKhoan_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        var row = dataGridView1.Rows[e.RowIndex];

        Iddachon = Convert.ToInt32(row.Cells["Id"].Value);
        Tennguoidungdachon = Convert.ToString(row.Cells["DisplayName"].Value);
        textBox2.Text = Tennguoidungdachon;
        textBox3.Text = Convert.ToString(row.Cells["DisplayName"].Value);
        comboBox1.SelectedItem = Convert.ToString(row.Cells["Role"].Value);
        if (comboBox1.SelectedIndex < 0) comboBox1.SelectedIndex = 1;
        textBox4.Clear(); //để trống giữ nguyên mật khẩu cũ
    }
}
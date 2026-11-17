using System.ComponentModel;

namespace MiniMart.Forms;

partial class FormBanHang
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        panel1 = new System.Windows.Forms.Panel();
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
        lblDanhSachSanPham = new System.Windows.Forms.Label();
        tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
        txtTraCuu = new System.Windows.Forms.TextBox();
        btnTimKiem = new System.Windows.Forms.Button();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
        lblGioHang = new System.Windows.Forms.Label();
        dataGridView2 = new System.Windows.Forms.DataGridView();
        tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
        lblSoLuong = new System.Windows.Forms.Label();
        nudSoLuong = new System.Windows.Forms.NumericUpDown();
        lblGiamGia = new System.Windows.Forms.Label();
        nudGiamGia = new System.Windows.Forms.NumericUpDown();
        btnCapNhat = new System.Windows.Forms.Button();
        txtKhachDua = new System.Windows.Forms.TextBox();
        lblTongCong = new System.Windows.Forms.Label();
        lblKhachDua = new System.Windows.Forms.Label();
        tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
        panel2 = new System.Windows.Forms.Panel();
        btnThemVaoGio = new System.Windows.Forms.Button();
        panel3 = new System.Windows.Forms.Panel();
        btnThanhToan = new System.Windows.Forms.Button();
        btnBoDong = new System.Windows.Forms.Button();
        lblBanHang = new System.Windows.Forms.Label();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        tableLayoutPanel5.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        tableLayoutPanel6.SuspendLayout();
        tableLayoutPanel7.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
        tableLayoutPanel8.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudGiamGia).BeginInit();
        tableLayoutPanel9.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(tableLayoutPanel1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(1196, 773);
        panel1.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
        tableLayoutPanel1.Controls.Add(lblBanHang, 0, 0);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.070867F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.92913F));
        tableLayoutPanel1.Size = new System.Drawing.Size(1196, 773);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.467476F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.532524F));
        tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
        tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 1, 0);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(3, 104);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.Size = new System.Drawing.Size(1190, 666);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
        tableLayoutPanel3.Controls.Add(dataGridView1, 0, 1);
        tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 2;
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.148148F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.85185F));
        tableLayoutPanel3.Size = new System.Drawing.Size(439, 660);
        tableLayoutPanel3.TabIndex = 0;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 1;
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.Controls.Add(lblDanhSachSanPham, 0, 0);
        tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
        tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 2;
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.Size = new System.Drawing.Size(433, 113);
        tableLayoutPanel4.TabIndex = 0;
        // 
        // lblDanhSachSanPham
        // 
        lblDanhSachSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        lblDanhSachSanPham.AutoSize = true;
        lblDanhSachSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblDanhSachSanPham.Location = new System.Drawing.Point(3, 12);
        lblDanhSachSanPham.Name = "lblDanhSachSanPham";
        lblDanhSachSanPham.Size = new System.Drawing.Size(427, 32);
        lblDanhSachSanPham.TabIndex = 0;
        lblDanhSachSanPham.Text = "Danh sách sản phẩm";
        // 
        // tableLayoutPanel5
        // 
        tableLayoutPanel5.ColumnCount = 2;
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.733025F));
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.26698F));
        tableLayoutPanel5.Controls.Add(txtTraCuu, 0, 0);
        tableLayoutPanel5.Controls.Add(btnTimKiem, 1, 0);
        tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel5.Location = new System.Drawing.Point(3, 59);
        tableLayoutPanel5.Name = "tableLayoutPanel5";
        tableLayoutPanel5.RowCount = 1;
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel5.Size = new System.Drawing.Size(427, 51);
        tableLayoutPanel5.TabIndex = 1;
        // 
        // txtTraCuu
        // 
        txtTraCuu.Dock = System.Windows.Forms.DockStyle.Fill;
        txtTraCuu.Location = new System.Drawing.Point(3, 3);
        txtTraCuu.Name = "txtTraCuu";
        txtTraCuu.Size = new System.Drawing.Size(343, 31);
        txtTraCuu.TabIndex = 0;
        txtTraCuu.Text = "Nhập mã hoặc tên sản phẩm";
        // 
        // btnTimKiem
        // 
        btnTimKiem.AutoSize = true;
        btnTimKiem.BackColor = System.Drawing.Color.DarkGreen;
        btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTimKiem.ForeColor = System.Drawing.Color.White;
        btnTimKiem.Location = new System.Drawing.Point(352, 3);
        btnTimKiem.Name = "btnTimKiem";
        btnTimKiem.Size = new System.Drawing.Size(72, 35);
        btnTimKiem.TabIndex = 1;
        btnTimKiem.Text = "Tìm";
        btnTimKiem.UseVisualStyleBackColor = false;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
        dataGridView1.Location = new System.Drawing.Point(3, 122);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 62;
        dataGridView1.Size = new System.Drawing.Size(433, 535);
        dataGridView1.TabIndex = 1;
        dataGridView1.Text = "dataGridView1";
        // 
        // tableLayoutPanel6
        // 
        tableLayoutPanel6.ColumnCount = 1;
        tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 0);
        tableLayoutPanel6.Controls.Add(tableLayoutPanel8, 0, 1);
        tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel6.Location = new System.Drawing.Point(448, 3);
        tableLayoutPanel6.Name = "tableLayoutPanel6";
        tableLayoutPanel6.RowCount = 2;
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.136116F));
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.863884F));
        tableLayoutPanel6.Size = new System.Drawing.Size(739, 660);
        tableLayoutPanel6.TabIndex = 1;
        // 
        // tableLayoutPanel7
        // 
        tableLayoutPanel7.ColumnCount = 1;
        tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel7.Controls.Add(lblGioHang, 0, 0);
        tableLayoutPanel7.Controls.Add(dataGridView2, 0, 1);
        tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel7.Name = "tableLayoutPanel7";
        tableLayoutPanel7.RowCount = 2;
        tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.114537F));
        tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.88546F));
        tableLayoutPanel7.Size = new System.Drawing.Size(733, 489);
        tableLayoutPanel7.TabIndex = 0;
        // 
        // lblGioHang
        // 
        lblGioHang.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        lblGioHang.AutoSize = true;
        lblGioHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblGioHang.Location = new System.Drawing.Point(3, 13);
        lblGioHang.Name = "lblGioHang";
        lblGioHang.Size = new System.Drawing.Size(727, 32);
        lblGioHang.TabIndex = 0;
        lblGioHang.Text = "Giỏ hàng";
        // 
        // dataGridView2
        // 
        dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
        dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
        dataGridView2.Location = new System.Drawing.Point(3, 62);
        dataGridView2.Name = "dataGridView2";
        dataGridView2.RowHeadersWidth = 62;
        dataGridView2.Size = new System.Drawing.Size(727, 424);
        dataGridView2.TabIndex = 1;
        dataGridView2.Text = "dataGridView2";
        // 
        // tableLayoutPanel8
        // 
        tableLayoutPanel8.ColumnCount = 5;
        tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.41036F));
        tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.58964F));
        tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
        tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
        tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
        tableLayoutPanel8.Controls.Add(lblSoLuong, 0, 0);
        tableLayoutPanel8.Controls.Add(nudSoLuong, 1, 0);
        tableLayoutPanel8.Controls.Add(lblGiamGia, 0, 1);
        tableLayoutPanel8.Controls.Add(nudGiamGia, 1, 1);
        tableLayoutPanel8.Controls.Add(btnCapNhat, 2, 0);
        tableLayoutPanel8.Controls.Add(txtKhachDua, 3, 1);
        tableLayoutPanel8.Controls.Add(lblTongCong, 4, 1);
        tableLayoutPanel8.Controls.Add(lblKhachDua, 2, 1);
        tableLayoutPanel8.Controls.Add(tableLayoutPanel9, 4, 0);
        tableLayoutPanel8.Controls.Add(btnBoDong, 3, 0);
        tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel8.Location = new System.Drawing.Point(3, 498);
        tableLayoutPanel8.Name = "tableLayoutPanel8";
        tableLayoutPanel8.RowCount = 2;
        tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel8.Size = new System.Drawing.Size(733, 159);
        tableLayoutPanel8.TabIndex = 1;
        // 
        // lblSoLuong
        // 
        lblSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblSoLuong.AutoSize = true;
        lblSoLuong.Location = new System.Drawing.Point(3, 27);
        lblSoLuong.Name = "lblSoLuong";
        lblSoLuong.Size = new System.Drawing.Size(85, 25);
        lblSoLuong.TabIndex = 0;
        lblSoLuong.Text = "Số lượng";
        lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // nudSoLuong
        // 
        nudSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        nudSoLuong.Location = new System.Drawing.Point(122, 24);
        nudSoLuong.Name = "nudSoLuong";
        nudSoLuong.Size = new System.Drawing.Size(126, 31);
        nudSoLuong.TabIndex = 1;
        // 
        // lblGiamGia
        // 
        lblGiamGia.Dock = System.Windows.Forms.DockStyle.Fill;
        lblGiamGia.Location = new System.Drawing.Point(3, 79);
        lblGiamGia.Name = "lblGiamGia";
        lblGiamGia.Size = new System.Drawing.Size(113, 80);
        lblGiamGia.TabIndex = 2;
        lblGiamGia.Text = "Giảm giá (%)";
        // 
        // nudGiamGia
        // 
        nudGiamGia.Dock = System.Windows.Forms.DockStyle.Fill;
        nudGiamGia.Location = new System.Drawing.Point(122, 82);
        nudGiamGia.Name = "nudGiamGia";
        nudGiamGia.Size = new System.Drawing.Size(126, 31);
        nudGiamGia.TabIndex = 3;
        // 
        // btnCapNhat
        // 
        btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnCapNhat.BackColor = System.Drawing.Color.LightGray;
        btnCapNhat.Location = new System.Drawing.Point(254, 22);
        btnCapNhat.Name = "btnCapNhat";
        btnCapNhat.Size = new System.Drawing.Size(101, 35);
        btnCapNhat.TabIndex = 5;
        btnCapNhat.Text = "Cập nhật";
        btnCapNhat.UseVisualStyleBackColor = false;
        // 
        // txtKhachDua
        // 
        txtKhachDua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtKhachDua.Location = new System.Drawing.Point(361, 82);
        txtKhachDua.Name = "txtKhachDua";
        txtKhachDua.Size = new System.Drawing.Size(108, 31);
        txtKhachDua.TabIndex = 7;
        // 
        // lblTongCong
        // 
        lblTongCong.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTongCong.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTongCong.ForeColor = System.Drawing.Color.DarkGreen;
        lblTongCong.Location = new System.Drawing.Point(475, 79);
        lblTongCong.Name = "lblTongCong";
        lblTongCong.Size = new System.Drawing.Size(255, 80);
        lblTongCong.TabIndex = 8;
        lblTongCong.Text = "Tổng cộng: 0đ";
        // 
        // lblKhachDua
        // 
        lblKhachDua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblKhachDua.AutoSize = true;
        lblKhachDua.Location = new System.Drawing.Point(254, 79);
        lblKhachDua.Name = "lblKhachDua";
        lblKhachDua.Size = new System.Drawing.Size(101, 25);
        lblKhachDua.TabIndex = 4;
        lblKhachDua.Text = "Khách đưa";
        lblKhachDua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tableLayoutPanel9
        // 
        tableLayoutPanel9.ColumnCount = 2;
        tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.199203F));
        tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.800797F));
        tableLayoutPanel9.Controls.Add(panel2, 0, 0);
        tableLayoutPanel9.Controls.Add(panel3, 1, 0);
        tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel9.Location = new System.Drawing.Point(475, 3);
        tableLayoutPanel9.Name = "tableLayoutPanel9";
        tableLayoutPanel9.RowCount = 1;
        tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel9.Size = new System.Drawing.Size(255, 73);
        tableLayoutPanel9.TabIndex = 9;
        // 
        // panel2
        // 
        panel2.Controls.Add(btnThemVaoGio);
        panel2.Location = new System.Drawing.Point(3, 3);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(122, 67);
        panel2.TabIndex = 0;
        // 
        // btnThemVaoGio
        // 
        btnThemVaoGio.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnThemVaoGio.Location = new System.Drawing.Point(0, 29);
        btnThemVaoGio.Name = "btnThemVaoGio";
        btnThemVaoGio.Size = new System.Drawing.Size(122, 35);
        btnThemVaoGio.TabIndex = 0;
        btnThemVaoGio.Text = "Thêm vào giỏ";
        btnThemVaoGio.UseVisualStyleBackColor = true;
        // 
        // panel3
        // 
        panel3.Controls.Add(btnThanhToan);
        panel3.Location = new System.Drawing.Point(131, 3);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(121, 67);
        panel3.TabIndex = 1;
        // 
        // btnThanhToan
        // 
        btnThanhToan.BackColor = System.Drawing.Color.DarkGreen;
        btnThanhToan.ForeColor = System.Drawing.Color.White;
        btnThanhToan.Location = new System.Drawing.Point(7, 29);
        btnThanhToan.Name = "btnThanhToan";
        btnThanhToan.Size = new System.Drawing.Size(111, 35);
        btnThanhToan.TabIndex = 0;
        btnThanhToan.Text = "Thanh toán";
        btnThanhToan.UseVisualStyleBackColor = false;
        // 
        // btnBoDong
        // 
        btnBoDong.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnBoDong.BackColor = System.Drawing.Color.DarkGreen;
        btnBoDong.ForeColor = System.Drawing.Color.White;
        btnBoDong.Location = new System.Drawing.Point(361, 22);
        btnBoDong.Name = "btnBoDong";
        btnBoDong.Size = new System.Drawing.Size(108, 35);
        btnBoDong.TabIndex = 6;
        btnBoDong.Text = "Bỏ dòng";
        btnBoDong.UseVisualStyleBackColor = false;
        // 
        // lblBanHang
        // 
        lblBanHang.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblBanHang.ForeColor = System.Drawing.Color.DarkGreen;
        lblBanHang.Location = new System.Drawing.Point(3, 0);
        lblBanHang.Name = "lblBanHang";
        lblBanHang.Size = new System.Drawing.Size(262, 100);
        lblBanHang.TabIndex = 1;
        lblBanHang.Text = "BÁN HÀNG";
        lblBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // FormBanHang
        // 
        ClientSize = new System.Drawing.Size(1196, 773);
        Controls.Add(panel1);
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        tableLayoutPanel4.ResumeLayout(false);
        tableLayoutPanel4.PerformLayout();
        tableLayoutPanel5.ResumeLayout(false);
        tableLayoutPanel5.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        tableLayoutPanel6.ResumeLayout(false);
        tableLayoutPanel7.ResumeLayout(false);
        tableLayoutPanel7.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
        tableLayoutPanel8.ResumeLayout(false);
        tableLayoutPanel8.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudGiamGia).EndInit();
        tableLayoutPanel9.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel3.ResumeLayout(false);
        ResumeLayout(false);
    }
    private System.Windows.Forms.Button btnThemVaoGio;
    private System.Windows.Forms.Button btnThanhToan;
    private System.Windows.Forms.Button btnBoDong;
    private System.Windows.Forms.Label lblBanHang ;
    
     private System.Windows.Forms.Label lblSoLuong;
     private System.Windows.Forms.NumericUpDown nudSoLuong;
     private System.Windows.Forms.Label lblGiamGia;
    
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridView dataGridView2;
    
     private System.Windows.Forms.Button btnCapNhat;
    private System.Windows.Forms.TextBox txtKhachDua ;
    private System.Windows.Forms.Label lblTongCong;
    private System.Windows.Forms.Label lblKhachDua;
    
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    
    private System.Windows.Forms.Label lblDanhSachSanPham;
    
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

    private System.Windows.Forms.TextBox txtTraCuu;
    private System.Windows.Forms.NumericUpDown nudGiamGia;

    private System.Windows.Forms.DataGridView dgvGioHang;

    private System.Windows.Forms.DataGridView dgvSanPham;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Button btnTimKiem;

    private System.Windows.Forms.TextBox txtTimKiem;

    private System.Windows.Forms.Panel pnlTimKiem;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    private System.Windows.Forms.Label lblGioHang;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Label lblDanhSachSP;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Label lblTitle;

    private System.Windows.Forms.Panel pnlHeader;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    #endregion
}
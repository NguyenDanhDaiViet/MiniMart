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
        txtTimKiem = new System.Windows.Forms.TextBox();
        btnTimKiem = new System.Windows.Forms.Button();
        btnThemVaoGio = new System.Windows.Forms.Button();
        dgvSanPham = new System.Windows.Forms.DataGridView();
        tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
        dgvGioHang = new System.Windows.Forms.DataGridView();
        tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
        txtSoDienThoai = new System.Windows.Forms.TextBox();
        lblSoDienThoai = new System.Windows.Forms.Label();
        lblGioHang = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        txtTenKhachHang = new System.Windows.Forms.TextBox();
        tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
        label4 = new System.Windows.Forms.Label();
        nudSoLuong = new System.Windows.Forms.NumericUpDown();
        btnCapNhat = new System.Windows.Forms.Button();
        txtKhachDua = new System.Windows.Forms.TextBox();
        tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
        btnThanhToan = new System.Windows.Forms.Button();
        btnBoDong = new System.Windows.Forms.Button();
        lblTongCong = new System.Windows.Forms.Label();
        tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
        nudGiamGiaDong = new System.Windows.Forms.NumericUpDown();
        lblGiamGiaDong = new System.Windows.Forms.Label();
        panel4 = new System.Windows.Forms.Panel();
        lblKhachDua = new System.Windows.Forms.Label();
        nudGiamGiaHoaDon = new System.Windows.Forms.NumericUpDown();
        panel5 = new System.Windows.Forms.Panel();
        lblGiamGiaHoaDon = new System.Windows.Forms.Label();
        lblBanHang = new System.Windows.Forms.Label();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        tableLayoutPanel5.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
        tableLayoutPanel6.SuspendLayout();
        tableLayoutPanel7.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
        tableLayoutPanel10.SuspendLayout();
        tableLayoutPanel8.SuspendLayout();
        tableLayoutPanel12.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
        tableLayoutPanel9.SuspendLayout();
        tableLayoutPanel11.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudGiamGiaDong).BeginInit();
        panel4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudGiamGiaHoaDon).BeginInit();
        panel5.SuspendLayout();
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
        tableLayoutPanel3.Controls.Add(dgvSanPham, 0, 1);
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
        lblDanhSachSanPham.Location = new System.Drawing.Point(3, 14);
        lblDanhSachSanPham.Name = "lblDanhSachSanPham";
        lblDanhSachSanPham.Size = new System.Drawing.Size(427, 28);
        lblDanhSachSanPham.TabIndex = 0;
        lblDanhSachSanPham.Text = "Danh sách sản phẩm";
        // 
        // tableLayoutPanel5
        // 
        tableLayoutPanel5.ColumnCount = 3;
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.89028F));
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.10972F));
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
        tableLayoutPanel5.Controls.Add(txtTimKiem, 0, 0);
        tableLayoutPanel5.Controls.Add(btnTimKiem, 1, 0);
        tableLayoutPanel5.Controls.Add(btnThemVaoGio, 2, 0);
        tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel5.Location = new System.Drawing.Point(3, 59);
        tableLayoutPanel5.Name = "tableLayoutPanel5";
        tableLayoutPanel5.RowCount = 1;
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel5.Size = new System.Drawing.Size(427, 51);
        tableLayoutPanel5.TabIndex = 1;
        // 
        // txtTimKiem
        // 
        txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtTimKiem.Location = new System.Drawing.Point(3, 12);
        txtTimKiem.Name = "txtTimKiem";
        txtTimKiem.Size = new System.Drawing.Size(196, 27);
        txtTimKiem.TabIndex = 0;
        txtTimKiem.Text = "Nhập mã hoặc tên sản phẩm";
        // 
        // btnTimKiem
        // 
        btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        btnTimKiem.AutoSize = true;
        btnTimKiem.BackColor = System.Drawing.Color.Navy;
        btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTimKiem.ForeColor = System.Drawing.Color.White;
        btnTimKiem.Location = new System.Drawing.Point(205, 8);
        btnTimKiem.Name = "btnTimKiem";
        btnTimKiem.Size = new System.Drawing.Size(103, 35);
        btnTimKiem.TabIndex = 1;
        btnTimKiem.Text = "Tìm";
        btnTimKiem.UseVisualStyleBackColor = false;
        // 
        // btnThemVaoGio
        // 
        btnThemVaoGio.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        btnThemVaoGio.BackColor = System.Drawing.Color.Navy;
        btnThemVaoGio.FlatAppearance.BorderColor = System.Drawing.Color.White;
        btnThemVaoGio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
        btnThemVaoGio.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnThemVaoGio.ForeColor = System.Drawing.Color.Snow;
        btnThemVaoGio.Location = new System.Drawing.Point(314, 6);
        btnThemVaoGio.Name = "btnThemVaoGio";
        btnThemVaoGio.Size = new System.Drawing.Size(110, 39);
        btnThemVaoGio.TabIndex = 2;
        btnThemVaoGio.Text = "Thêm vào giỏ";
        btnThemVaoGio.UseVisualStyleBackColor = false;
        // 
        // dgvSanPham
        // 
        dgvSanPham.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
        dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvSanPham.Location = new System.Drawing.Point(3, 122);
        dgvSanPham.Name = "dgvSanPham";
        dgvSanPham.RowHeadersWidth = 62;
        dgvSanPham.Size = new System.Drawing.Size(433, 535);
        dgvSanPham.TabIndex = 1;
        dgvSanPham.Text = "dataGridView1";
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
        tableLayoutPanel7.Controls.Add(dgvGioHang, 0, 1);
        tableLayoutPanel7.Controls.Add(tableLayoutPanel10, 0, 0);
        tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel7.Name = "tableLayoutPanel7";
        tableLayoutPanel7.RowCount = 2;
        tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.114537F));
        tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.88546F));
        tableLayoutPanel7.Size = new System.Drawing.Size(733, 489);
        tableLayoutPanel7.TabIndex = 0;
        // 
        // dgvGioHang
        // 
        dgvGioHang.BackgroundColor = System.Drawing.Color.White;
        dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvGioHang.Location = new System.Drawing.Point(3, 62);
        dgvGioHang.Name = "dgvGioHang";
        dgvGioHang.RowHeadersWidth = 62;
        dgvGioHang.Size = new System.Drawing.Size(727, 424);
        dgvGioHang.TabIndex = 1;
        dgvGioHang.Text = "dataGridView2";
        // 
        // tableLayoutPanel10
        // 
        tableLayoutPanel10.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        tableLayoutPanel10.ColumnCount = 5;
        tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.231087F));
        tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.658873F));
        tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel10.Controls.Add(txtSoDienThoai, 4, 0);
        tableLayoutPanel10.Controls.Add(lblSoDienThoai, 3, 0);
        tableLayoutPanel10.Controls.Add(lblGioHang, 0, 0);
        tableLayoutPanel10.Controls.Add(label2, 1, 0);
        tableLayoutPanel10.Controls.Add(txtTenKhachHang, 2, 0);
        tableLayoutPanel10.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel10.Name = "tableLayoutPanel10";
        tableLayoutPanel10.RowCount = 1;
        tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel10.Size = new System.Drawing.Size(727, 53);
        tableLayoutPanel10.TabIndex = 2;
        // 
        // txtSoDienThoai
        // 
        txtSoDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtSoDienThoai.Location = new System.Drawing.Point(583, 13);
        txtSoDienThoai.MaxLength = 100;
        txtSoDienThoai.Name = "txtSoDienThoai";
        txtSoDienThoai.Size = new System.Drawing.Size(141, 27);
        txtSoDienThoai.TabIndex = 23;
        // 
        // lblSoDienThoai
        // 
        lblSoDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        lblSoDienThoai.Location = new System.Drawing.Point(438, 15);
        lblSoDienThoai.Name = "lblSoDienThoai";
        lblSoDienThoai.Size = new System.Drawing.Size(139, 23);
        lblSoDienThoai.TabIndex = 22;
        lblSoDienThoai.Text = "Số điện thoại:";
        lblSoDienThoai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblGioHang
        // 
        lblGioHang.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        lblGioHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblGioHang.Location = new System.Drawing.Point(3, 7);
        lblGioHang.Name = "lblGioHang";
        lblGioHang.Size = new System.Drawing.Size(139, 38);
        lblGioHang.TabIndex = 0;
        lblGioHang.Text = "Giỏ hàng";
        lblGioHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label2
        // 
        label2.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        label2.Location = new System.Drawing.Point(148, 15);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(112, 23);
        label2.TabIndex = 1;
        label2.Text = "Khách hàng:";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtTenKhachHang
        // 
        txtTenKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtTenKhachHang.Location = new System.Drawing.Point(266, 13);
        txtTenKhachHang.MaxLength = 100;
        txtTenKhachHang.Name = "txtTenKhachHang";
        txtTenKhachHang.Size = new System.Drawing.Size(166, 27);
        txtTenKhachHang.TabIndex = 21;
        // 
        // tableLayoutPanel8
        // 
        tableLayoutPanel8.ColumnCount = 5;
        tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.94382F));
        tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.05618F));
        tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
        tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
        tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
        tableLayoutPanel8.Controls.Add(tableLayoutPanel12, 0, 0);
        tableLayoutPanel8.Controls.Add(btnCapNhat, 2, 0);
        tableLayoutPanel8.Controls.Add(txtKhachDua, 3, 1);
        tableLayoutPanel8.Controls.Add(tableLayoutPanel9, 4, 0);
        tableLayoutPanel8.Controls.Add(btnBoDong, 3, 0);
        tableLayoutPanel8.Controls.Add(lblTongCong, 4, 1);
        tableLayoutPanel8.Controls.Add(tableLayoutPanel11, 1, 0);
        tableLayoutPanel8.Controls.Add(panel4, 2, 1);
        tableLayoutPanel8.Controls.Add(nudGiamGiaHoaDon, 1, 1);
        tableLayoutPanel8.Controls.Add(panel5, 0, 1);
        tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel8.Location = new System.Drawing.Point(3, 498);
        tableLayoutPanel8.Name = "tableLayoutPanel8";
        tableLayoutPanel8.RowCount = 2;
        tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel8.Size = new System.Drawing.Size(733, 159);
        tableLayoutPanel8.TabIndex = 1;
        // 
        // tableLayoutPanel12
        // 
        tableLayoutPanel12.ColumnCount = 1;
        tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel12.Controls.Add(label4, 0, 0);
        tableLayoutPanel12.Controls.Add(nudSoLuong, 0, 1);
        tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel12.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel12.Name = "tableLayoutPanel12";
        tableLayoutPanel12.RowCount = 2;
        tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.39726F));
        tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.60274F));
        tableLayoutPanel12.Size = new System.Drawing.Size(89, 73);
        tableLayoutPanel12.TabIndex = 11;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new System.Drawing.Point(3, 0);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(69, 20);
        label4.TabIndex = 13;
        label4.Text = "Số lượng";
        // 
        // nudSoLuong
        // 
        nudSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        nudSoLuong.AutoSize = true;
        nudSoLuong.Location = new System.Drawing.Point(3, 23);
        nudSoLuong.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
        nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudSoLuong.Name = "nudSoLuong";
        nudSoLuong.Size = new System.Drawing.Size(83, 27);
        nudSoLuong.TabIndex = 8;
        nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // btnCapNhat
        // 
        btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnCapNhat.BackColor = System.Drawing.Color.LightGray;
        btnCapNhat.Location = new System.Drawing.Point(214, 22);
        btnCapNhat.Name = "btnCapNhat";
        btnCapNhat.Size = new System.Drawing.Size(101, 35);
        btnCapNhat.TabIndex = 5;
        btnCapNhat.Text = "Cập nhật";
        btnCapNhat.UseVisualStyleBackColor = false;
        // 
        // txtKhachDua
        // 
        txtKhachDua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtKhachDua.Location = new System.Drawing.Point(322, 82);
        txtKhachDua.Name = "txtKhachDua";
        txtKhachDua.Size = new System.Drawing.Size(147, 27);
        txtKhachDua.TabIndex = 7;
        // 
        // tableLayoutPanel9
        // 
        tableLayoutPanel9.ColumnCount = 2;
        tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.199203F));
        tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.800797F));
        tableLayoutPanel9.Controls.Add(btnThanhToan, 1, 0);
        tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel9.Location = new System.Drawing.Point(475, 3);
        tableLayoutPanel9.Name = "tableLayoutPanel9";
        tableLayoutPanel9.RowCount = 1;
        tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel9.Size = new System.Drawing.Size(255, 73);
        tableLayoutPanel9.TabIndex = 9;
        // 
        // btnThanhToan
        // 
        btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        btnThanhToan.BackColor = System.Drawing.Color.Navy;
        btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnThanhToan.ForeColor = System.Drawing.Color.White;
        btnThanhToan.Location = new System.Drawing.Point(131, 15);
        btnThanhToan.Name = "btnThanhToan";
        btnThanhToan.Size = new System.Drawing.Size(121, 42);
        btnThanhToan.TabIndex = 2;
        btnThanhToan.Text = "Thanh toán";
        btnThanhToan.UseVisualStyleBackColor = false;
        // 
        // btnBoDong
        // 
        btnBoDong.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnBoDong.BackColor = System.Drawing.Color.Navy;
        btnBoDong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnBoDong.ForeColor = System.Drawing.Color.White;
        btnBoDong.Location = new System.Drawing.Point(331, 22);
        btnBoDong.Name = "btnBoDong";
        btnBoDong.Size = new System.Drawing.Size(128, 35);
        btnBoDong.TabIndex = 6;
        btnBoDong.Text = "Bỏ dòng";
        btnBoDong.UseVisualStyleBackColor = false;
        // 
        // lblTongCong
        // 
        lblTongCong.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblTongCong.AutoSize = true;
        lblTongCong.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTongCong.ForeColor = System.Drawing.Color.Navy;
        lblTongCong.Location = new System.Drawing.Point(475, 98);
        lblTongCong.Name = "lblTongCong";
        lblTongCong.Size = new System.Drawing.Size(220, 41);
        lblTongCong.TabIndex = 8;
        lblTongCong.Text = "Tổng cộng: 0đ";
        lblTongCong.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // tableLayoutPanel11
        // 
        tableLayoutPanel11.ColumnCount = 1;
        tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel11.Controls.Add(nudGiamGiaDong, 0, 1);
        tableLayoutPanel11.Controls.Add(lblGiamGiaDong, 0, 0);
        tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel11.Location = new System.Drawing.Point(98, 3);
        tableLayoutPanel11.Name = "tableLayoutPanel11";
        tableLayoutPanel11.RowCount = 2;
        tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.39726F));
        tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.60274F));
        tableLayoutPanel11.Size = new System.Drawing.Size(110, 73);
        tableLayoutPanel11.TabIndex = 10;
        // 
        // nudGiamGiaDong
        // 
        nudGiamGiaDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        nudGiamGiaDong.AutoSize = true;
        nudGiamGiaDong.Location = new System.Drawing.Point(3, 23);
        nudGiamGiaDong.Name = "nudGiamGiaDong";
        nudGiamGiaDong.Size = new System.Drawing.Size(104, 27);
        nudGiamGiaDong.TabIndex = 15;
        // 
        // lblGiamGiaDong
        // 
        lblGiamGiaDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblGiamGiaDong.AutoSize = true;
        lblGiamGiaDong.Location = new System.Drawing.Point(3, 0);
        lblGiamGiaDong.Name = "lblGiamGiaDong";
        lblGiamGiaDong.Size = new System.Drawing.Size(104, 20);
        lblGiamGiaDong.TabIndex = 13;
        lblGiamGiaDong.Text = "Giảm giá từng món";
        // 
        // panel4
        // 
        panel4.Controls.Add(lblKhachDua);
        panel4.Location = new System.Drawing.Point(214, 82);
        panel4.Name = "panel4";
        panel4.Size = new System.Drawing.Size(102, 74);
        panel4.TabIndex = 16;
        // 
        // lblKhachDua
        // 
        lblKhachDua.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblKhachDua.AutoSize = true;
        lblKhachDua.Location = new System.Drawing.Point(0, 3);
        lblKhachDua.Name = "lblKhachDua";
        lblKhachDua.Size = new System.Drawing.Size(102, 20);
        lblKhachDua.TabIndex = 5;
        lblKhachDua.Text = "Khách đưa (đ)\r\n";
        lblKhachDua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // nudGiamGiaHoaDon
        // 
        nudGiamGiaHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        nudGiamGiaHoaDon.Location = new System.Drawing.Point(98, 82);
        nudGiamGiaHoaDon.Name = "nudGiamGiaHoaDon";
        nudGiamGiaHoaDon.Size = new System.Drawing.Size(110, 27);
        nudGiamGiaHoaDon.TabIndex = 15;
        // 
        // panel5
        // 
        panel5.Controls.Add(lblGiamGiaHoaDon);
        panel5.Location = new System.Drawing.Point(3, 82);
        panel5.Name = "panel5";
        panel5.Size = new System.Drawing.Size(89, 74);
        panel5.TabIndex = 17;
        // 
        // lblGiamGiaHoaDon
        // 
        lblGiamGiaHoaDon.AutoSize = true;
        lblGiamGiaHoaDon.Location = new System.Drawing.Point(0, 2);
        lblGiamGiaHoaDon.Name = "lblGiamGiaHoaDon";
        lblGiamGiaHoaDon.Size = new System.Drawing.Size(95, 20);
        lblGiamGiaHoaDon.TabIndex = 13;
        lblGiamGiaHoaDon.Text = "Giảm giá (%)";
        lblGiamGiaHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblBanHang
        // 
        lblBanHang.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblBanHang.ForeColor = System.Drawing.Color.Navy;
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
        ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
        tableLayoutPanel6.ResumeLayout(false);
        tableLayoutPanel7.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
        tableLayoutPanel10.ResumeLayout(false);
        tableLayoutPanel10.PerformLayout();
        tableLayoutPanel8.ResumeLayout(false);
        tableLayoutPanel8.PerformLayout();
        tableLayoutPanel12.ResumeLayout(false);
        tableLayoutPanel12.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
        tableLayoutPanel9.ResumeLayout(false);
        tableLayoutPanel11.ResumeLayout(false);
        tableLayoutPanel11.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudGiamGiaDong).EndInit();
        panel4.ResumeLayout(false);
        panel4.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudGiamGiaHoaDon).EndInit();
        panel5.ResumeLayout(false);
        panel5.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Label lblKhachDua;
    private System.Windows.Forms.Panel panel5;

    private System.Windows.Forms.TextBox txtSoDienThoai;

    private System.Windows.Forms.Label lblGiamGiaDong;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown nudSoLuong;
    private System.Windows.Forms.NumericUpDown nudGiamGiaDong;
    private System.Windows.Forms.NumericUpDown nudGiamGiaHoaDon;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
    private System.Windows.Forms.Label lblGiamGiaHoaDon;
    
    private System.Windows.Forms.Label lblSoDienThoai;

    private System.Windows.Forms.TextBox txtTenKhachHang;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label lblGioHang;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
    private System.Windows.Forms.Button btnThemVaoGio;
    private System.Windows.Forms.Button btnThanhToan;
    private System.Windows.Forms.Button btnBoDong;
    private System.Windows.Forms.Label lblBanHang;
    
    
     private System.Windows.Forms.Button btnCapNhat;
    private System.Windows.Forms.TextBox txtKhachDua;
    private System.Windows.Forms.Label lblTongCong;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    
    private System.Windows.Forms.Label lblDanhSachSanPham;
    
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    

    private System.Windows.Forms.DataGridView dgvGioHang;

    private System.Windows.Forms.DataGridView dgvSanPham;

    private System.Windows.Forms.Button btnTimKiem;

    private System.Windows.Forms.TextBox txtTimKiem;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;


    private System.Windows.Forms.Panel panel1;
    
    

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    #endregion
}
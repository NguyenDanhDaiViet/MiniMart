using System.ComponentModel;

namespace MiniMart.Forms;

partial class FormBanHang
{
 
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
        grpDongGioHang = new System.Windows.Forms.GroupBox();
        tlpDongGioHang = new System.Windows.Forms.TableLayoutPanel();
        label4 = new System.Windows.Forms.Label();
        lblGiamGiaDong = new System.Windows.Forms.Label();
        nudSoLuong = new System.Windows.Forms.NumericUpDown();
        nudGiamGiaDong = new System.Windows.Forms.NumericUpDown();
        btnCapNhat = new System.Windows.Forms.Button();
        btnBoDong = new System.Windows.Forms.Button();
        grpThanhToan = new System.Windows.Forms.GroupBox();
        tlpThanhToan = new System.Windows.Forms.TableLayoutPanel();
        flpKhuyenMai = new System.Windows.Forms.FlowLayoutPanel();
        lblGiamGiaHoaDon = new System.Windows.Forms.Label();
        nudGiamGiaHoaDon = new System.Windows.Forms.NumericUpDown();
        lblMaKhuyenMai = new System.Windows.Forms.Label();
        txtMaKhuyenMai = new System.Windows.Forms.TextBox();
        btnApDungKhuyenMai = new System.Windows.Forms.Button();
        lblKhuyenMai = new System.Windows.Forms.Label();
        flpKhachDua = new System.Windows.Forms.FlowLayoutPanel();
        lblKhachDua = new System.Windows.Forms.Label();
        txtKhachDua = new System.Windows.Forms.TextBox();
        lblTienThua = new System.Windows.Forms.Label();
        lblTongCong = new System.Windows.Forms.Label();
        flpTienNhanh = new System.Windows.Forms.FlowLayoutPanel();
        lblTienNhanh = new System.Windows.Forms.Label();
        btnTien10k = new System.Windows.Forms.Button();
        btnTien20k = new System.Windows.Forms.Button();
        btnTien50k = new System.Windows.Forms.Button();
        btnTien100k = new System.Windows.Forms.Button();
        btnTien200k = new System.Windows.Forms.Button();
        btnTien500k = new System.Windows.Forms.Button();
        btnDuTien = new System.Windows.Forms.Button();
        btnThanhToan = new System.Windows.Forms.Button();
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
        grpDongGioHang.SuspendLayout();
        tlpDongGioHang.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudGiamGiaDong).BeginInit();
        grpThanhToan.SuspendLayout();
        tlpThanhToan.SuspendLayout();
        flpKhuyenMai.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudGiamGiaHoaDon).BeginInit();
        flpKhachDua.SuspendLayout();
        flpTienNhanh.SuspendLayout();
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
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
        tableLayoutPanel2.Location = new System.Drawing.Point(3, 73);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.Size = new System.Drawing.Size(1190, 697);
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
        tableLayoutPanel3.Size = new System.Drawing.Size(439, 691);
        tableLayoutPanel3.TabIndex = 0;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.BackColor = System.Drawing.Color.White;
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
        tableLayoutPanel4.Size = new System.Drawing.Size(433, 119);
        tableLayoutPanel4.TabIndex = 0;
        // 
        // lblDanhSachSanPham
        // 
        lblDanhSachSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        lblDanhSachSanPham.AutoSize = true;
        lblDanhSachSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblDanhSachSanPham.Location = new System.Drawing.Point(3, 15);
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
        tableLayoutPanel5.Location = new System.Drawing.Point(3, 62);
        tableLayoutPanel5.Name = "tableLayoutPanel5";
        tableLayoutPanel5.RowCount = 1;
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel5.Size = new System.Drawing.Size(427, 54);
        tableLayoutPanel5.TabIndex = 1;
        // 
        // txtTimKiem
        // 
        txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtTimKiem.Location = new System.Drawing.Point(3, 13);
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
        btnTimKiem.Location = new System.Drawing.Point(205, 9);
        btnTimKiem.Name = "btnTimKiem";
        btnTimKiem.Size = new System.Drawing.Size(103, 35);
        btnTimKiem.TabIndex = 1;
        btnTimKiem.Text = "Tìm";
        btnTimKiem.UseVisualStyleBackColor = false;
        // 
        // btnThemVaoGio
        // 
        btnThemVaoGio.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnThemVaoGio.BackColor = System.Drawing.Color.Red;
        btnThemVaoGio.FlatAppearance.BorderColor = System.Drawing.Color.White;
        btnThemVaoGio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
        btnThemVaoGio.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnThemVaoGio.ForeColor = System.Drawing.Color.White;
        btnThemVaoGio.Location = new System.Drawing.Point(314, 7);
        btnThemVaoGio.Name = "btnThemVaoGio";
        btnThemVaoGio.Size = new System.Drawing.Size(110, 39);
        btnThemVaoGio.TabIndex = 2;
        btnThemVaoGio.Text = "Thêm vào giỏ";
        btnThemVaoGio.UseVisualStyleBackColor = false;
        // 
        // dgvSanPham
        // 
        dgvSanPham.BackgroundColor = System.Drawing.Color.White;
        dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvSanPham.Location = new System.Drawing.Point(3, 128);
        dgvSanPham.Name = "dgvSanPham";
        dgvSanPham.RowHeadersWidth = 62;
        dgvSanPham.Size = new System.Drawing.Size(433, 560);
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
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 330F));
        tableLayoutPanel6.Size = new System.Drawing.Size(739, 691);
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
        tableLayoutPanel7.Size = new System.Drawing.Size(733, 355);
        tableLayoutPanel7.TabIndex = 0;
        // 
        // dgvGioHang
        // 
        dgvGioHang.BackgroundColor = System.Drawing.Color.White;
        dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvGioHang.Location = new System.Drawing.Point(3, 46);
        dgvGioHang.Name = "dgvGioHang";
        dgvGioHang.RowHeadersWidth = 62;
        dgvGioHang.Size = new System.Drawing.Size(727, 306);
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
        tableLayoutPanel10.Size = new System.Drawing.Size(727, 37);
        tableLayoutPanel10.TabIndex = 2;
        // 
        // txtSoDienThoai
        // 
        txtSoDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtSoDienThoai.Location = new System.Drawing.Point(583, 5);
        txtSoDienThoai.MaxLength = 100;
        txtSoDienThoai.Name = "txtSoDienThoai";
        txtSoDienThoai.Size = new System.Drawing.Size(141, 27);
        txtSoDienThoai.TabIndex = 23;
        // 
        // lblSoDienThoai
        // 
        lblSoDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        lblSoDienThoai.Location = new System.Drawing.Point(438, 7);
        lblSoDienThoai.Name = "lblSoDienThoai";
        lblSoDienThoai.Size = new System.Drawing.Size(139, 23);
        lblSoDienThoai.TabIndex = 22;
        lblSoDienThoai.Text = "Số điện thoại:";
        lblSoDienThoai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblGioHang
        // 
        lblGioHang.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        lblGioHang.BackColor = System.Drawing.Color.White;
        lblGioHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblGioHang.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)0)), ((int)((byte)192)));
        lblGioHang.Location = new System.Drawing.Point(3, 0);
        lblGioHang.Name = "lblGioHang";
        lblGioHang.Size = new System.Drawing.Size(139, 37);
        lblGioHang.TabIndex = 0;
        lblGioHang.Text = "Giỏ hàng";
        lblGioHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label2
        // 
        label2.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        label2.Location = new System.Drawing.Point(148, 7);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(112, 23);
        label2.TabIndex = 1;
        label2.Text = "Khách hàng:";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtTenKhachHang
        // 
        txtTenKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtTenKhachHang.Location = new System.Drawing.Point(266, 5);
        txtTenKhachHang.MaxLength = 100;
        txtTenKhachHang.Name = "txtTenKhachHang";
        txtTenKhachHang.Size = new System.Drawing.Size(166, 27);
        txtTenKhachHang.TabIndex = 21;
        // 
        // tableLayoutPanel8
        // 
        tableLayoutPanel8.ColumnCount = 1;
        tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel8.Controls.Add(grpDongGioHang, 0, 0);
        tableLayoutPanel8.Controls.Add(grpThanhToan, 0, 1);
        tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel8.Location = new System.Drawing.Point(3, 364);
        tableLayoutPanel8.Name = "tableLayoutPanel8";
        tableLayoutPanel8.RowCount = 2;
        tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
        tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel8.Size = new System.Drawing.Size(733, 324);
        tableLayoutPanel8.TabIndex = 1;
        // 
        // grpDongGioHang
        // 
        grpDongGioHang.Controls.Add(tlpDongGioHang);
        grpDongGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
        grpDongGioHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        grpDongGioHang.ForeColor = System.Drawing.Color.Navy;
        grpDongGioHang.Location = new System.Drawing.Point(3, 3);
        grpDongGioHang.Name = "grpDongGioHang";
        grpDongGioHang.Size = new System.Drawing.Size(727, 107);
        grpDongGioHang.TabIndex = 0;
        grpDongGioHang.TabStop = false;
        grpDongGioHang.Text = "Dòng đang chọn trong giỏ";
        // 
        // tlpDongGioHang
        // 
        tlpDongGioHang.ColumnCount = 5;
        tlpDongGioHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
        tlpDongGioHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
        tlpDongGioHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
        tlpDongGioHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
        tlpDongGioHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpDongGioHang.Controls.Add(label4, 0, 0);
        tlpDongGioHang.Controls.Add(lblGiamGiaDong, 1, 0);
        tlpDongGioHang.Controls.Add(nudSoLuong, 0, 1);
        tlpDongGioHang.Controls.Add(nudGiamGiaDong, 1, 1);
        tlpDongGioHang.Controls.Add(btnCapNhat, 2, 1);
        tlpDongGioHang.Controls.Add(btnBoDong, 3, 1);
        tlpDongGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpDongGioHang.Location = new System.Drawing.Point(3, 26);
        tlpDongGioHang.Name = "tlpDongGioHang";
        tlpDongGioHang.RowCount = 2;
        tlpDongGioHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
        tlpDongGioHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpDongGioHang.Size = new System.Drawing.Size(721, 78);
        tlpDongGioHang.TabIndex = 0;
        // 
        // label4
        // 
        label4.Dock = System.Windows.Forms.DockStyle.Fill;
        label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(3, 0);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(144, 24);
        label4.TabIndex = 0;
        label4.Text = "Số lượng";
        label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // lblGiamGiaDong
        // 
        lblGiamGiaDong.Dock = System.Windows.Forms.DockStyle.Fill;
        lblGiamGiaDong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblGiamGiaDong.Location = new System.Drawing.Point(153, 0);
        lblGiamGiaDong.Name = "lblGiamGiaDong";
        lblGiamGiaDong.Size = new System.Drawing.Size(144, 24);
        lblGiamGiaDong.TabIndex = 0;
        lblGiamGiaDong.Text = "Giảm giá món (%)";
        lblGiamGiaDong.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // nudSoLuong
        // 
        nudSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        nudSoLuong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        nudSoLuong.Location = new System.Drawing.Point(3, 36);
        nudSoLuong.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
        nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudSoLuong.Name = "nudSoLuong";
        nudSoLuong.Size = new System.Drawing.Size(144, 30);
        nudSoLuong.TabIndex = 1;
        nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // nudGiamGiaDong
        // 
        nudGiamGiaDong.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        nudGiamGiaDong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        nudGiamGiaDong.Location = new System.Drawing.Point(153, 36);
        nudGiamGiaDong.Name = "nudGiamGiaDong";
        nudGiamGiaDong.Size = new System.Drawing.Size(144, 30);
        nudGiamGiaDong.TabIndex = 2;
        // 
        // btnCapNhat
        // 
        btnCapNhat.BackColor = System.Drawing.Color.Navy;
        btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
        btnCapNhat.Dock = System.Windows.Forms.DockStyle.Fill;
        btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnCapNhat.ForeColor = System.Drawing.Color.White;
        btnCapNhat.Location = new System.Drawing.Point(303, 27);
        btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
        btnCapNhat.Name = "btnCapNhat";
        btnCapNhat.Size = new System.Drawing.Size(121, 48);
        btnCapNhat.TabIndex = 3;
        btnCapNhat.Text = "Cập nhật";
        btnCapNhat.UseVisualStyleBackColor = false;
        // 
        // btnBoDong
        // 
        btnBoDong.BackColor = System.Drawing.Color.White;
        btnBoDong.Cursor = System.Windows.Forms.Cursors.Hand;
        btnBoDong.Dock = System.Windows.Forms.DockStyle.Fill;
        btnBoDong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnBoDong.ForeColor = System.Drawing.Color.Red;
        btnBoDong.Location = new System.Drawing.Point(433, 27);
        btnBoDong.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
        btnBoDong.Name = "btnBoDong";
        btnBoDong.Size = new System.Drawing.Size(121, 48);
        btnBoDong.TabIndex = 4;
        btnBoDong.Text = "Bỏ dòng";
        btnBoDong.UseVisualStyleBackColor = false;
        // 
        // grpThanhToan
        // 
        grpThanhToan.Controls.Add(tlpThanhToan);
        grpThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
        grpThanhToan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        grpThanhToan.ForeColor = System.Drawing.Color.Navy;
        grpThanhToan.Location = new System.Drawing.Point(3, 116);
        grpThanhToan.Name = "grpThanhToan";
        grpThanhToan.Size = new System.Drawing.Size(727, 205);
        grpThanhToan.TabIndex = 1;
        grpThanhToan.TabStop = false;
        grpThanhToan.Text = "Thanh toán";
        // 
        // tlpThanhToan
        // 
        tlpThanhToan.ColumnCount = 2;
        tlpThanhToan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpThanhToan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
        tlpThanhToan.Controls.Add(flpKhuyenMai, 0, 0);
        tlpThanhToan.Controls.Add(flpKhachDua, 0, 1);
        tlpThanhToan.Controls.Add(lblTongCong, 1, 1);
        tlpThanhToan.Controls.Add(flpTienNhanh, 0, 2);
        tlpThanhToan.Controls.Add(btnThanhToan, 1, 2);
        tlpThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpThanhToan.Location = new System.Drawing.Point(3, 26);
        tlpThanhToan.Name = "tlpThanhToan";
        tlpThanhToan.RowCount = 3;
        tlpThanhToan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
        tlpThanhToan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
        tlpThanhToan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpThanhToan.Size = new System.Drawing.Size(721, 176);
        tlpThanhToan.TabIndex = 0;
        // 
        // flpKhuyenMai
        // 
        tlpThanhToan.SetColumnSpan(flpKhuyenMai, 2);
        flpKhuyenMai.Controls.Add(lblGiamGiaHoaDon);
        flpKhuyenMai.Controls.Add(nudGiamGiaHoaDon);
        flpKhuyenMai.Controls.Add(lblMaKhuyenMai);
        flpKhuyenMai.Controls.Add(txtMaKhuyenMai);
        flpKhuyenMai.Controls.Add(btnApDungKhuyenMai);
        flpKhuyenMai.Controls.Add(lblKhuyenMai);
        flpKhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill;
        flpKhuyenMai.Location = new System.Drawing.Point(0, 0);
        flpKhuyenMai.Margin = new System.Windows.Forms.Padding(0);
        flpKhuyenMai.Name = "flpKhuyenMai";
        flpKhuyenMai.Size = new System.Drawing.Size(721, 40);
        flpKhuyenMai.TabIndex = 0;
        flpKhuyenMai.WrapContents = false;
        // 
        // lblGiamGiaHoaDon
        // 
        lblGiamGiaHoaDon.AutoSize = true;
        lblGiamGiaHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblGiamGiaHoaDon.Location = new System.Drawing.Point(3, 0);
        lblGiamGiaHoaDon.Name = "lblGiamGiaHoaDon";
        lblGiamGiaHoaDon.Padding = new System.Windows.Forms.Padding(0, 7, 4, 0);
        lblGiamGiaHoaDon.Size = new System.Drawing.Size(184, 30);
        lblGiamGiaHoaDon.TabIndex = 0;
        lblGiamGiaHoaDon.Text = "Giảm giá hóa đơn (%):";
        lblGiamGiaHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // nudGiamGiaHoaDon
        // 
        nudGiamGiaHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        nudGiamGiaHoaDon.Location = new System.Drawing.Point(193, 4);
        nudGiamGiaHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 18, 3);
        nudGiamGiaHoaDon.Name = "nudGiamGiaHoaDon";
        nudGiamGiaHoaDon.Size = new System.Drawing.Size(70, 30);
        nudGiamGiaHoaDon.TabIndex = 1;
        // 
        // lblMaKhuyenMai
        // 
        lblMaKhuyenMai.AutoSize = true;
        lblMaKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblMaKhuyenMai.Location = new System.Drawing.Point(284, 0);
        lblMaKhuyenMai.Name = "lblMaKhuyenMai";
        lblMaKhuyenMai.Padding = new System.Windows.Forms.Padding(0, 7, 4, 0);
        lblMaKhuyenMai.Size = new System.Drawing.Size(135, 30);
        lblMaKhuyenMai.TabIndex = 0;
        lblMaKhuyenMai.Text = "Mã khuyến mãi:";
        lblMaKhuyenMai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtMaKhuyenMai
        // 
        txtMaKhuyenMai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        txtMaKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtMaKhuyenMai.Location = new System.Drawing.Point(425, 4);
        txtMaKhuyenMai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
        txtMaKhuyenMai.Name = "txtMaKhuyenMai";
        txtMaKhuyenMai.PlaceholderText = "VD: SALE10";
        txtMaKhuyenMai.Size = new System.Drawing.Size(140, 30);
        txtMaKhuyenMai.TabIndex = 2;
        // 
        // btnApDungKhuyenMai
        // 
        btnApDungKhuyenMai.Anchor = System.Windows.Forms.AnchorStyles.Left;
        btnApDungKhuyenMai.BackColor = System.Drawing.Color.Navy;
        btnApDungKhuyenMai.Cursor = System.Windows.Forms.Cursors.Hand;
        btnApDungKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnApDungKhuyenMai.ForeColor = System.Drawing.Color.White;
        btnApDungKhuyenMai.Location = new System.Drawing.Point(571, 3);
        btnApDungKhuyenMai.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
        btnApDungKhuyenMai.Name = "btnApDungKhuyenMai";
        btnApDungKhuyenMai.Size = new System.Drawing.Size(96, 32);
        btnApDungKhuyenMai.TabIndex = 3;
        btnApDungKhuyenMai.Text = "Áp dụng";
        btnApDungKhuyenMai.UseVisualStyleBackColor = false;
        // 
        // lblKhuyenMai
        // 
        lblKhuyenMai.AutoSize = true;
        lblKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblKhuyenMai.ForeColor = System.Drawing.Color.Navy;
        lblKhuyenMai.Location = new System.Drawing.Point(676, 0);
        lblKhuyenMai.Name = "lblKhuyenMai";
        lblKhuyenMai.Padding = new System.Windows.Forms.Padding(4, 7, 0, 0);
        lblKhuyenMai.Size = new System.Drawing.Size(157, 30);
        lblKhuyenMai.TabIndex = 0;
        lblKhuyenMai.Text = "Chưa áp dụng mã";
        lblKhuyenMai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // flpKhachDua
        // 
        flpKhachDua.Controls.Add(lblKhachDua);
        flpKhachDua.Controls.Add(txtKhachDua);
        flpKhachDua.Controls.Add(lblTienThua);
        flpKhachDua.Dock = System.Windows.Forms.DockStyle.Fill;
        flpKhachDua.Location = new System.Drawing.Point(0, 40);
        flpKhachDua.Margin = new System.Windows.Forms.Padding(0);
        flpKhachDua.Name = "flpKhachDua";
        flpKhachDua.Size = new System.Drawing.Size(421, 50);
        flpKhachDua.TabIndex = 3;
        flpKhachDua.WrapContents = false;
        // 
        // lblKhachDua
        // 
        lblKhachDua.AutoSize = true;
        lblKhachDua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblKhachDua.Location = new System.Drawing.Point(3, 0);
        lblKhachDua.Name = "lblKhachDua";
        lblKhachDua.Padding = new System.Windows.Forms.Padding(0, 7, 4, 0);
        lblKhachDua.Size = new System.Drawing.Size(124, 30);
        lblKhachDua.TabIndex = 0;
        lblKhachDua.Text = "Khách đưa (đ):";
        lblKhachDua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtKhachDua
        // 
        txtKhachDua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtKhachDua.Location = new System.Drawing.Point(133, 4);
        txtKhachDua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
        txtKhachDua.Name = "txtKhachDua";
        txtKhachDua.PlaceholderText = "0";
        txtKhachDua.Size = new System.Drawing.Size(200, 30);
        txtKhachDua.TabIndex = 1;
        txtKhachDua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // lblTienThua
        // 
        lblTienThua.AutoSize = true;
        lblTienThua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTienThua.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)100)), ((int)((byte)70)));
        lblTienThua.Location = new System.Drawing.Point(352, 0);
        lblTienThua.Margin = new System.Windows.Forms.Padding(16, 0, 3, 0);
        lblTienThua.Name = "lblTienThua";
        lblTienThua.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
        lblTienThua.Size = new System.Drawing.Size(139, 35);
        lblTienThua.TabIndex = 0;
        lblTienThua.Text = "Tiền thừa: 0đ";
        lblTienThua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblTongCong
        // 
        lblTongCong.Anchor = System.Windows.Forms.AnchorStyles.None;
        lblTongCong.AutoSize = true;
        lblTongCong.BackColor = System.Drawing.SystemColors.ButtonFace;
        lblTongCong.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTongCong.ForeColor = System.Drawing.Color.Red;
        lblTongCong.Location = new System.Drawing.Point(487, 49);
        lblTongCong.Name = "lblTongCong";
        lblTongCong.Size = new System.Drawing.Size(168, 31);
        lblTongCong.TabIndex = 0;
        lblTongCong.Text = "Tổng cộng: 0đ";
        lblTongCong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // flpTienNhanh
        // 
        flpTienNhanh.Controls.Add(lblTienNhanh);
        flpTienNhanh.Controls.Add(btnTien10k);
        flpTienNhanh.Controls.Add(btnTien20k);
        flpTienNhanh.Controls.Add(btnTien50k);
        flpTienNhanh.Controls.Add(btnTien100k);
        flpTienNhanh.Controls.Add(btnTien200k);
        flpTienNhanh.Controls.Add(btnTien500k);
        flpTienNhanh.Controls.Add(btnDuTien);
        flpTienNhanh.Dock = System.Windows.Forms.DockStyle.Fill;
        flpTienNhanh.Location = new System.Drawing.Point(0, 90);
        flpTienNhanh.Margin = new System.Windows.Forms.Padding(0);
        flpTienNhanh.Name = "flpTienNhanh";
        flpTienNhanh.Size = new System.Drawing.Size(421, 86);
        flpTienNhanh.TabIndex = 5;
        flpTienNhanh.WrapContents = false;
        // 
        // lblTienNhanh
        // 
        lblTienNhanh.AutoSize = true;
        lblTienNhanh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTienNhanh.Location = new System.Drawing.Point(3, 0);
        lblTienNhanh.Name = "lblTienNhanh";
        lblTienNhanh.Padding = new System.Windows.Forms.Padding(0, 7, 4, 0);
        lblTienNhanh.Size = new System.Drawing.Size(104, 30);
        lblTienNhanh.TabIndex = 0;
        lblTienNhanh.Text = "Tiền nhanh:";
        lblTienNhanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btnTien10k
        // 
        btnTien10k.Anchor = System.Windows.Forms.AnchorStyles.Left;
        btnTien10k.BackColor = System.Drawing.Color.Navy;
        btnTien10k.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTien10k.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTien10k.ForeColor = System.Drawing.Color.White;
        btnTien10k.Location = new System.Drawing.Point(113, 3);
        btnTien10k.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
        btnTien10k.Name = "btnTien10k";
        btnTien10k.Size = new System.Drawing.Size(62, 32);
        btnTien10k.TabIndex = 1;
        btnTien10k.Tag = "10000";
        btnTien10k.Text = "10k";
        btnTien10k.UseVisualStyleBackColor = false;
        // 
        // btnTien20k
        // 
        btnTien20k.Anchor = System.Windows.Forms.AnchorStyles.Left;
        btnTien20k.BackColor = System.Drawing.Color.Navy;
        btnTien20k.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTien20k.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTien20k.ForeColor = System.Drawing.Color.White;
        btnTien20k.Location = new System.Drawing.Point(184, 3);
        btnTien20k.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
        btnTien20k.Name = "btnTien20k";
        btnTien20k.Size = new System.Drawing.Size(62, 32);
        btnTien20k.TabIndex = 2;
        btnTien20k.Tag = "20000";
        btnTien20k.Text = "20k";
        btnTien20k.UseVisualStyleBackColor = false;
        // 
        // btnTien50k
        // 
        btnTien50k.Anchor = System.Windows.Forms.AnchorStyles.Left;
        btnTien50k.BackColor = System.Drawing.Color.Navy;
        btnTien50k.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTien50k.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTien50k.ForeColor = System.Drawing.Color.White;
        btnTien50k.Location = new System.Drawing.Point(255, 3);
        btnTien50k.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
        btnTien50k.Name = "btnTien50k";
        btnTien50k.Size = new System.Drawing.Size(62, 32);
        btnTien50k.TabIndex = 3;
        btnTien50k.Tag = "50000";
        btnTien50k.Text = "50k";
        btnTien50k.UseVisualStyleBackColor = false;
        // 
        // btnTien100k
        // 
        btnTien100k.Anchor = System.Windows.Forms.AnchorStyles.Left;
        btnTien100k.BackColor = System.Drawing.Color.Navy;
        btnTien100k.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTien100k.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTien100k.ForeColor = System.Drawing.Color.White;
        btnTien100k.Location = new System.Drawing.Point(326, 3);
        btnTien100k.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
        btnTien100k.Name = "btnTien100k";
        btnTien100k.Size = new System.Drawing.Size(62, 32);
        btnTien100k.TabIndex = 4;
        btnTien100k.Tag = "100000";
        btnTien100k.Text = "100k";
        btnTien100k.UseVisualStyleBackColor = false;
        // 
        // btnTien200k
        // 
        btnTien200k.Anchor = System.Windows.Forms.AnchorStyles.Left;
        btnTien200k.BackColor = System.Drawing.Color.Navy;
        btnTien200k.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTien200k.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTien200k.ForeColor = System.Drawing.Color.White;
        btnTien200k.Location = new System.Drawing.Point(397, 3);
        btnTien200k.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
        btnTien200k.Name = "btnTien200k";
        btnTien200k.Size = new System.Drawing.Size(62, 32);
        btnTien200k.TabIndex = 5;
        btnTien200k.Tag = "200000";
        btnTien200k.Text = "200k";
        btnTien200k.UseVisualStyleBackColor = false;
        // 
        // btnTien500k
        // 
        btnTien500k.Anchor = System.Windows.Forms.AnchorStyles.Left;
        btnTien500k.BackColor = System.Drawing.Color.Navy;
        btnTien500k.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTien500k.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTien500k.ForeColor = System.Drawing.Color.White;
        btnTien500k.Location = new System.Drawing.Point(468, 3);
        btnTien500k.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
        btnTien500k.Name = "btnTien500k";
        btnTien500k.Size = new System.Drawing.Size(62, 32);
        btnTien500k.TabIndex = 6;
        btnTien500k.Tag = "500000";
        btnTien500k.Text = "500k";
        btnTien500k.UseVisualStyleBackColor = false;
        // 
        // btnDuTien
        // 
        btnDuTien.Anchor = System.Windows.Forms.AnchorStyles.Left;
        btnDuTien.BackColor = System.Drawing.Color.Navy;
        btnDuTien.Cursor = System.Windows.Forms.Cursors.Hand;
        btnDuTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnDuTien.ForeColor = System.Drawing.Color.White;
        btnDuTien.Location = new System.Drawing.Point(539, 3);
        btnDuTien.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
        btnDuTien.Name = "btnDuTien";
        btnDuTien.Size = new System.Drawing.Size(90, 32);
        btnDuTien.TabIndex = 7;
        btnDuTien.Text = "Đủ tiền";
        btnDuTien.UseVisualStyleBackColor = false;
        // 
        // btnThanhToan
        // 
        btnThanhToan.Anchor = System.Windows.Forms.AnchorStyles.Right;
        btnThanhToan.BackColor = System.Drawing.Color.Red;
        btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
        btnThanhToan.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnThanhToan.ForeColor = System.Drawing.Color.White;
        btnThanhToan.Location = new System.Drawing.Point(515, 108);
        btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
        btnThanhToan.Name = "btnThanhToan";
        btnThanhToan.Size = new System.Drawing.Size(200, 50);
        btnThanhToan.TabIndex = 6;
        btnThanhToan.Text = "Thanh toán";
        btnThanhToan.UseVisualStyleBackColor = false;
        // 
        // lblBanHang
        // 
        lblBanHang.Anchor = System.Windows.Forms.AnchorStyles.None;
        lblBanHang.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblBanHang.ForeColor = System.Drawing.Color.Navy;
        lblBanHang.Location = new System.Drawing.Point(467, 0);
        lblBanHang.Name = "lblBanHang";
        lblBanHang.Size = new System.Drawing.Size(262, 70);
        lblBanHang.TabIndex = 1;
        lblBanHang.Text = "BÁN HÀNG";
        lblBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
        grpDongGioHang.ResumeLayout(false);
        tlpDongGioHang.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudGiamGiaDong).EndInit();
        grpThanhToan.ResumeLayout(false);
        tlpThanhToan.ResumeLayout(false);
        tlpThanhToan.PerformLayout();
        flpKhuyenMai.ResumeLayout(false);
        flpKhuyenMai.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudGiamGiaHoaDon).EndInit();
        flpKhachDua.ResumeLayout(false);
        flpKhachDua.PerformLayout();
        flpTienNhanh.ResumeLayout(false);
        flpTienNhanh.PerformLayout();
        ResumeLayout(false);
    }

    
    private System.Windows.Forms.FlowLayoutPanel flpKhuyenMai;
    private System.Windows.Forms.Label lblMaKhuyenMai;
    private System.Windows.Forms.TextBox txtMaKhuyenMai;
    private System.Windows.Forms.Button btnApDungKhuyenMai;
    private System.Windows.Forms.Label lblKhuyenMai;
    private System.Windows.Forms.FlowLayoutPanel flpTienNhanh;
    private System.Windows.Forms.Label lblTienNhanh;
    private System.Windows.Forms.Button btnTien10k;
    private System.Windows.Forms.Button btnTien20k;
    private System.Windows.Forms.Button btnTien50k;
    private System.Windows.Forms.Button btnTien100k;
    private System.Windows.Forms.Button btnTien200k;
    private System.Windows.Forms.Button btnTien500k;
    private System.Windows.Forms.Button btnDuTien;
    private System.Windows.Forms.Label lblTienThua;
    private System.Windows.Forms.Label lblKhachDua;

    private System.Windows.Forms.TextBox txtSoDienThoai;

    private System.Windows.Forms.Label lblGiamGiaDong;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown nudSoLuong;
    private System.Windows.Forms.NumericUpDown nudGiamGiaDong;
    private System.Windows.Forms.NumericUpDown nudGiamGiaHoaDon;
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

    private System.Windows.Forms.GroupBox grpDongGioHang;
    private System.Windows.Forms.TableLayoutPanel tlpDongGioHang;
    private System.Windows.Forms.GroupBox grpThanhToan;
    private System.Windows.Forms.TableLayoutPanel tlpThanhToan;
    private System.Windows.Forms.FlowLayoutPanel flpKhachDua;

    #endregion
}
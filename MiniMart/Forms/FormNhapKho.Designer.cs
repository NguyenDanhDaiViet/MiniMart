using System.ComponentModel;

namespace MiniMart.Forms;

partial class FormNhapKho
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
        lblTieuDe = new System.Windows.Forms.Label();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        txtTimKiem = new System.Windows.Forms.TextBox();
        btnTimKiem = new System.Windows.Forms.Button();
        tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
        grpThongTinPhieuNhap = new System.Windows.Forms.GroupBox();
        tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
        lblSanPham = new System.Windows.Forms.Label();
        lblTenSanPham = new System.Windows.Forms.Label();
        tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
        lblMaSanPham = new System.Windows.Forms.Label();
        lblSoLuong = new System.Windows.Forms.Label();
        txtMaSanPham = new System.Windows.Forms.TextBox();
        nudSoLuong = new System.Windows.Forms.NumericUpDown();
        lblGiaNhap = new System.Windows.Forms.Label();
        nudGiaNhap = new System.Windows.Forms.NumericUpDown();
        btnXacNhan = new System.Windows.Forms.Button();
        dgvSanPham = new System.Windows.Forms.DataGridView();
        pnlPhieuNhap = new System.Windows.Forms.Panel();
        tlpPhieuNhap = new System.Windows.Forms.TableLayoutPanel();
        grpNhaCungCap = new System.Windows.Forms.GroupBox();
        tlpNhaCungCap = new System.Windows.Forms.TableLayoutPanel();
        lblMaNhaCungCap = new System.Windows.Forms.Label();
        txtMaNhaCungCap = new System.Windows.Forms.TextBox();
        lblTenNhaCungCap = new System.Windows.Forms.Label();
        txtTenNhaCungCap = new System.Windows.Forms.TextBox();
        lblSoDienThoaiNhaCungCap = new System.Windows.Forms.Label();
        txtSoDienThoaiNhaCungCap = new System.Windows.Forms.TextBox();
        lblDiaChiNhaCungCap = new System.Windows.Forms.Label();
        txtDiaChiNhaCungCap = new System.Windows.Forms.TextBox();
        lblEmailNhaCungCap = new System.Windows.Forms.Label();
        txtEmailNhaCungCap = new System.Windows.Forms.TextBox();
        lblGhiChu = new System.Windows.Forms.Label();
        txtGhiChu = new System.Windows.Forms.TextBox();
        tlpLoHang = new System.Windows.Forms.TableLayoutPanel();
        lblMaLo = new System.Windows.Forms.Label();
        txtMaLo = new System.Windows.Forms.TextBox();
        lblNgaySanXuat = new System.Windows.Forms.Label();
        dtpNgaySanXuat = new System.Windows.Forms.DateTimePicker();
        lblHanSuDung = new System.Windows.Forms.Label();
        dtpHanSuDung = new System.Windows.Forms.DateTimePicker();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        grpThongTinPhieuNhap.SuspendLayout();
        tableLayoutPanel5.SuspendLayout();
        tableLayoutPanel6.SuspendLayout();
        tableLayoutPanel7.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudGiaNhap).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
        pnlPhieuNhap.SuspendLayout();
        tlpPhieuNhap.SuspendLayout();
        grpNhaCungCap.SuspendLayout();
        tlpNhaCungCap.SuspendLayout();
        tlpLoHang.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(tableLayoutPanel1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(960, 626);
        panel1.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 1);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.571884F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.428116F));
        tableLayoutPanel1.Size = new System.Drawing.Size(960, 626);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.Controls.Add(lblTieuDe, 0, 0);
        tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.Size = new System.Drawing.Size(954, 103);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // lblTieuDe
        // 
        lblTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblTieuDe.AutoSize = true;
        lblTieuDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTieuDe.ImageAlign = System.Drawing.ContentAlignment.TopRight;
        lblTieuDe.Location = new System.Drawing.Point(3, 5);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new System.Drawing.Size(344, 41);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "NHẬP HÀNG VÀO KHO";
        lblTieuDe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 2;
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.3555F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.6445F));
        tableLayoutPanel3.Controls.Add(txtTimKiem, 0, 0);
        tableLayoutPanel3.Controls.Add(btnTimKiem, 1, 0);
        tableLayoutPanel3.Location = new System.Drawing.Point(3, 54);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 1;
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.Size = new System.Drawing.Size(906, 46);
        tableLayoutPanel3.TabIndex = 1;
        // 
        // txtTimKiem
        // 
        txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtTimKiem.Location = new System.Drawing.Point(3, 3);
        txtTimKiem.Name = "txtTimKiem";
        txtTimKiem.PlaceholderText = "Tìm sản phẩm...";
        txtTimKiem.RightToLeft = System.Windows.Forms.RightToLeft.No;
        txtTimKiem.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
        txtTimKiem.Size = new System.Drawing.Size(640, 27);
        txtTimKiem.TabIndex = 0;
        // 
        // btnTimKiem
        // 
        btnTimKiem.Location = new System.Drawing.Point(649, 3);
        btnTimKiem.Name = "btnTimKiem";
        btnTimKiem.Size = new System.Drawing.Size(106, 27);
        btnTimKiem.TabIndex = 1;
        btnTimKiem.Text = "Tìm";
        btnTimKiem.UseVisualStyleBackColor = true;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 2;
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
        tableLayoutPanel4.Controls.Add(pnlPhieuNhap, 1, 0);
        tableLayoutPanel4.Controls.Add(dgvSanPham, 0, 0);
        tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel4.Location = new System.Drawing.Point(3, 112);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 1;
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel4.Size = new System.Drawing.Size(954, 511);
        tableLayoutPanel4.TabIndex = 1;
        // 
        // grpThongTinPhieuNhap
        // 
        grpThongTinPhieuNhap.Controls.Add(tableLayoutPanel5);
        grpThongTinPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
        grpThongTinPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        grpThongTinPhieuNhap.Location = new System.Drawing.Point(3, 3);
        grpThongTinPhieuNhap.Name = "grpThongTinPhieuNhap";
        grpThongTinPhieuNhap.Size = new System.Drawing.Size(344, 384);
        grpThongTinPhieuNhap.TabIndex = 0;
        grpThongTinPhieuNhap.TabStop = false;
        grpThongTinPhieuNhap.Text = "Thông tin phiếu nhập";
        // 
        // tableLayoutPanel5
        // 
        tableLayoutPanel5.ColumnCount = 1;
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 0);
        tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 0, 1);
        tableLayoutPanel5.Controls.Add(lblGiaNhap, 0, 2);
        tableLayoutPanel5.Controls.Add(nudGiaNhap, 0, 3);
        tableLayoutPanel5.Controls.Add(tlpLoHang, 0, 4);
        tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel5.Location = new System.Drawing.Point(3, 26);
        tableLayoutPanel5.Name = "tableLayoutPanel5";
        tableLayoutPanel5.RowCount = 5;
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel5.Size = new System.Drawing.Size(338, 355);
        tableLayoutPanel5.TabIndex = 0;
        // 
        // tableLayoutPanel6
        // 
        tableLayoutPanel6.ColumnCount = 1;
        tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel6.Controls.Add(lblSanPham, 0, 0);
        tableLayoutPanel6.Controls.Add(lblTenSanPham, 0, 1);
        tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel6.Name = "tableLayoutPanel6";
        tableLayoutPanel6.RowCount = 2;
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel6.Size = new System.Drawing.Size(332, 64);
        tableLayoutPanel6.TabIndex = 0;
        // 
        // lblSanPham
        // 
        lblSanPham.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblSanPham.Location = new System.Drawing.Point(3, 8);
        lblSanPham.Name = "lblSanPham";
        lblSanPham.Size = new System.Drawing.Size(100, 23);
        lblSanPham.TabIndex = 0;
        lblSanPham.Text = "Sản Phẩm:";
        lblSanPham.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // lblTenSanPham
        // 
        lblTenSanPham.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblTenSanPham.Location = new System.Drawing.Point(3, 48);
        lblTenSanPham.Name = "lblTenSanPham";
        lblTenSanPham.Size = new System.Drawing.Size(320, 23);
        lblTenSanPham.TabIndex = 1;
        lblTenSanPham.Text = "Chưa Chọn";
        lblTenSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // tableLayoutPanel7
        // 
        tableLayoutPanel7.ColumnCount = 2;
        tableLayoutPanel5.SetColumnSpan(tableLayoutPanel7, 2);
        tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel7.Controls.Add(lblMaSanPham, 0, 0);
        tableLayoutPanel7.Controls.Add(lblSoLuong, 1, 0);
        tableLayoutPanel7.Controls.Add(txtMaSanPham, 0, 1);
        tableLayoutPanel7.Controls.Add(nudSoLuong, 1, 1);
        tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel7.Location = new System.Drawing.Point(3, 89);
        tableLayoutPanel7.Name = "tableLayoutPanel7";
        tableLayoutPanel7.RowCount = 2;
        tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel7.Size = new System.Drawing.Size(332, 76);
        tableLayoutPanel7.TabIndex = 1;
        // 
        // lblMaSanPham
        // 
        lblMaSanPham.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblMaSanPham.Location = new System.Drawing.Point(3, 12);
        lblMaSanPham.Name = "lblMaSanPham";
        lblMaSanPham.Size = new System.Drawing.Size(100, 23);
        lblMaSanPham.TabIndex = 0;
        lblMaSanPham.Text = "Mã Sản Phẩm";
        lblMaSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblSoLuong
        // 
        lblSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblSoLuong.Location = new System.Drawing.Point(146, 12);
        lblSoLuong.Name = "lblSoLuong";
        lblSoLuong.Size = new System.Drawing.Size(100, 23);
        lblSoLuong.TabIndex = 1;
        lblSoLuong.Text = "Số Lượng";
        lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtMaSanPham
        // 
        txtMaSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtMaSanPham.Location = new System.Drawing.Point(3, 51);
        txtMaSanPham.Name = "txtMaSanPham";
        txtMaSanPham.Size = new System.Drawing.Size(137, 30);
        txtMaSanPham.TabIndex = 2;
        // 
        // nudSoLuong
        // 
        nudSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        nudSoLuong.Location = new System.Drawing.Point(146, 51);
        nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudSoLuong.Name = "nudSoLuong";
        nudSoLuong.Size = new System.Drawing.Size(138, 30);
        nudSoLuong.TabIndex = 3;
        nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblGiaNhap
        // 
        lblGiaNhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblGiaNhap.Location = new System.Drawing.Point(3, 189);
        lblGiaNhap.Name = "lblGiaNhap";
        lblGiaNhap.Size = new System.Drawing.Size(100, 23);
        lblGiaNhap.TabIndex = 2;
        lblGiaNhap.Text = "Giá Nhập";
        lblGiaNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // nudGiaNhap
        // 
        nudGiaNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        nudGiaNhap.Location = new System.Drawing.Point(3, 215);
        nudGiaNhap.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        nudGiaNhap.Name = "nudGiaNhap";
        nudGiaNhap.Size = new System.Drawing.Size(326, 30);
        nudGiaNhap.TabIndex = 3;
        // 
        // btnXacNhan
        // 
        btnXacNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnXacNhan.BackColor = System.Drawing.Color.Navy;
        btnXacNhan.ForeColor = System.Drawing.Color.White;
        btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnXacNhan.Location = new System.Drawing.Point(105, 699);
        btnXacNhan.Name = "btnXacNhan";
        btnXacNhan.Size = new System.Drawing.Size(140, 40);
        btnXacNhan.TabIndex = 2;
        btnXacNhan.Text = "Xác Nhận";
        btnXacNhan.UseVisualStyleBackColor = false;
        // 
        // pnlPhieuNhap
        // 
        pnlPhieuNhap.AutoScroll = true;
        pnlPhieuNhap.Controls.Add(tlpPhieuNhap);
        pnlPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlPhieuNhap.Location = new System.Drawing.Point(575, 3);
        pnlPhieuNhap.Name = "pnlPhieuNhap";
        pnlPhieuNhap.Size = new System.Drawing.Size(376, 505);
        pnlPhieuNhap.TabIndex = 4;
        // 
        // tlpPhieuNhap
        // 
        tlpPhieuNhap.ColumnCount = 1;
        tlpPhieuNhap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpPhieuNhap.Controls.Add(grpThongTinPhieuNhap, 0, 0);
        tlpPhieuNhap.Controls.Add(grpNhaCungCap, 0, 1);
        tlpPhieuNhap.Controls.Add(btnXacNhan, 0, 2);
        tlpPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
        tlpPhieuNhap.Location = new System.Drawing.Point(0, 0);
        tlpPhieuNhap.Name = "tlpPhieuNhap";
        tlpPhieuNhap.RowCount = 3;
        tlpPhieuNhap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 390F));
        tlpPhieuNhap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
        tlpPhieuNhap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
        tlpPhieuNhap.Size = new System.Drawing.Size(350, 746);
        tlpPhieuNhap.TabIndex = 0;
        // 
        // grpNhaCungCap
        // 
        grpNhaCungCap.Controls.Add(tlpNhaCungCap);
        grpNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
        grpNhaCungCap.ForeColor = System.Drawing.Color.Navy;
        grpNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        grpNhaCungCap.Location = new System.Drawing.Point(3, 393);
        grpNhaCungCap.Name = "grpNhaCungCap";
        grpNhaCungCap.Size = new System.Drawing.Size(344, 294);
        grpNhaCungCap.TabIndex = 1;
        grpNhaCungCap.TabStop = false;
        grpNhaCungCap.Text = "Thông tin nhà cung cấp";
        // 
        // tlpNhaCungCap
        // 
        tlpNhaCungCap.ColumnCount = 2;
        tlpNhaCungCap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
        tlpNhaCungCap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpNhaCungCap.Controls.Add(lblMaNhaCungCap, 0, 0);
        tlpNhaCungCap.Controls.Add(txtMaNhaCungCap, 1, 0);
        tlpNhaCungCap.Controls.Add(lblTenNhaCungCap, 0, 1);
        tlpNhaCungCap.Controls.Add(txtTenNhaCungCap, 1, 1);
        tlpNhaCungCap.Controls.Add(lblSoDienThoaiNhaCungCap, 0, 2);
        tlpNhaCungCap.Controls.Add(txtSoDienThoaiNhaCungCap, 1, 2);
        tlpNhaCungCap.Controls.Add(lblDiaChiNhaCungCap, 0, 3);
        tlpNhaCungCap.Controls.Add(txtDiaChiNhaCungCap, 1, 3);
        tlpNhaCungCap.Controls.Add(lblEmailNhaCungCap, 0, 4);
        tlpNhaCungCap.Controls.Add(txtEmailNhaCungCap, 1, 4);
        tlpNhaCungCap.Controls.Add(lblGhiChu, 0, 5);
        tlpNhaCungCap.Controls.Add(txtGhiChu, 1, 5);
        tlpNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpNhaCungCap.Location = new System.Drawing.Point(3, 26);
        tlpNhaCungCap.Name = "tlpNhaCungCap";
        tlpNhaCungCap.RowCount = 6;
        tlpNhaCungCap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
        tlpNhaCungCap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
        tlpNhaCungCap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
        tlpNhaCungCap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
        tlpNhaCungCap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
        tlpNhaCungCap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpNhaCungCap.Size = new System.Drawing.Size(338, 265);
        tlpNhaCungCap.TabIndex = 0;
        // 
        // lblMaNhaCungCap
        // 
        lblMaNhaCungCap.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblMaNhaCungCap.Location = new System.Drawing.Point(3, 7);
        lblMaNhaCungCap.Name = "lblMaNhaCungCap";
        lblMaNhaCungCap.Size = new System.Drawing.Size(124, 23);
        lblMaNhaCungCap.TabIndex = 0;
        lblMaNhaCungCap.Text = "Mã NCC:";
        lblMaNhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtMaNhaCungCap
        // 
        txtMaNhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtMaNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtMaNhaCungCap.Location = new System.Drawing.Point(133, 4);
        txtMaNhaCungCap.MaxLength = 30;
        txtMaNhaCungCap.Name = "txtMaNhaCungCap";
        txtMaNhaCungCap.PlaceholderText = "VD: NCC001";
        txtMaNhaCungCap.Size = new System.Drawing.Size(209, 30);
        txtMaNhaCungCap.TabIndex = 1;
        // 
        // lblTenNhaCungCap
        // 
        lblTenNhaCungCap.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblTenNhaCungCap.Location = new System.Drawing.Point(3, 45);
        lblTenNhaCungCap.Name = "lblTenNhaCungCap";
        lblTenNhaCungCap.Size = new System.Drawing.Size(124, 23);
        lblTenNhaCungCap.TabIndex = 2;
        lblTenNhaCungCap.Text = "Tên NCC:";
        lblTenNhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtTenNhaCungCap
        // 
        txtTenNhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtTenNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtTenNhaCungCap.Location = new System.Drawing.Point(133, 42);
        txtTenNhaCungCap.MaxLength = 100;
        txtTenNhaCungCap.Name = "txtTenNhaCungCap";
        txtTenNhaCungCap.Size = new System.Drawing.Size(209, 30);
        txtTenNhaCungCap.TabIndex = 3;
        // 
        // lblSoDienThoaiNhaCungCap
        // 
        lblSoDienThoaiNhaCungCap.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblSoDienThoaiNhaCungCap.Location = new System.Drawing.Point(3, 83);
        lblSoDienThoaiNhaCungCap.Name = "lblSoDienThoaiNhaCungCap";
        lblSoDienThoaiNhaCungCap.Size = new System.Drawing.Size(124, 23);
        lblSoDienThoaiNhaCungCap.TabIndex = 4;
        lblSoDienThoaiNhaCungCap.Text = "Số điện thoại:";
        lblSoDienThoaiNhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtSoDienThoaiNhaCungCap
        // 
        txtSoDienThoaiNhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtSoDienThoaiNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtSoDienThoaiNhaCungCap.Location = new System.Drawing.Point(133, 80);
        txtSoDienThoaiNhaCungCap.MaxLength = 20;
        txtSoDienThoaiNhaCungCap.Name = "txtSoDienThoaiNhaCungCap";
        txtSoDienThoaiNhaCungCap.PlaceholderText = "VD: 0912345678";
        txtSoDienThoaiNhaCungCap.Size = new System.Drawing.Size(209, 30);
        txtSoDienThoaiNhaCungCap.TabIndex = 5;
        // 
        // lblDiaChiNhaCungCap
        // 
        lblDiaChiNhaCungCap.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblDiaChiNhaCungCap.Location = new System.Drawing.Point(3, 121);
        lblDiaChiNhaCungCap.Name = "lblDiaChiNhaCungCap";
        lblDiaChiNhaCungCap.Size = new System.Drawing.Size(124, 23);
        lblDiaChiNhaCungCap.TabIndex = 6;
        lblDiaChiNhaCungCap.Text = "Địa chỉ:";
        lblDiaChiNhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtDiaChiNhaCungCap
        // 
        txtDiaChiNhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtDiaChiNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtDiaChiNhaCungCap.Location = new System.Drawing.Point(133, 118);
        txtDiaChiNhaCungCap.MaxLength = 200;
        txtDiaChiNhaCungCap.Name = "txtDiaChiNhaCungCap";
        txtDiaChiNhaCungCap.Size = new System.Drawing.Size(209, 30);
        txtDiaChiNhaCungCap.TabIndex = 7;
        // 
        // lblEmailNhaCungCap
        // 
        lblEmailNhaCungCap.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblEmailNhaCungCap.Location = new System.Drawing.Point(3, 159);
        lblEmailNhaCungCap.Name = "lblEmailNhaCungCap";
        lblEmailNhaCungCap.Size = new System.Drawing.Size(124, 23);
        lblEmailNhaCungCap.TabIndex = 8;
        lblEmailNhaCungCap.Text = "Email:";
        lblEmailNhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtEmailNhaCungCap
        // 
        txtEmailNhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtEmailNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtEmailNhaCungCap.Location = new System.Drawing.Point(133, 156);
        txtEmailNhaCungCap.MaxLength = 100;
        txtEmailNhaCungCap.Name = "txtEmailNhaCungCap";
        txtEmailNhaCungCap.PlaceholderText = "VD: ncc@example.com";
        txtEmailNhaCungCap.Size = new System.Drawing.Size(209, 30);
        txtEmailNhaCungCap.TabIndex = 9;
        // 
        // lblGhiChu
        // 
        lblGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
        lblGhiChu.Location = new System.Drawing.Point(3, 197);
        lblGhiChu.Name = "lblGhiChu";
        lblGhiChu.Size = new System.Drawing.Size(124, 23);
        lblGhiChu.TabIndex = 10;
        lblGhiChu.Text = "Ghi chú:";
        lblGhiChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtGhiChu
        // 
        txtGhiChu.Dock = System.Windows.Forms.DockStyle.Fill;
        txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtGhiChu.Location = new System.Drawing.Point(133, 194);
        txtGhiChu.MaxLength = 500;
        txtGhiChu.Multiline = true;
        txtGhiChu.Name = "txtGhiChu";
        txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtGhiChu.Size = new System.Drawing.Size(209, 60);
        txtGhiChu.TabIndex = 11;
        // 
        // tlpLoHang
        // 
        tlpLoHang.ColumnCount = 2;
        tlpLoHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
        tlpLoHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpLoHang.Controls.Add(lblMaLo, 0, 0);
        tlpLoHang.Controls.Add(txtMaLo, 1, 0);
        tlpLoHang.Controls.Add(lblNgaySanXuat, 0, 1);
        tlpLoHang.Controls.Add(dtpNgaySanXuat, 1, 1);
        tlpLoHang.Controls.Add(lblHanSuDung, 0, 2);
        tlpLoHang.Controls.Add(dtpHanSuDung, 1, 2);
        tlpLoHang.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpLoHang.Location = new System.Drawing.Point(3, 221);
        tlpLoHang.Name = "tlpLoHang";
        tlpLoHang.RowCount = 3;
        tlpLoHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        tlpLoHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        tlpLoHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        tlpLoHang.Size = new System.Drawing.Size(332, 131);
        tlpLoHang.TabIndex = 5;
        // 
        // lblMaLo
        // 
        lblMaLo.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblMaLo.Location = new System.Drawing.Point(3, 10);
        lblMaLo.Name = "lblMaLo";
        lblMaLo.Size = new System.Drawing.Size(124, 23);
        lblMaLo.TabIndex = 0;
        lblMaLo.Text = "Mã lô:";
        lblMaLo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtMaLo
        // 
        txtMaLo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtMaLo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtMaLo.Location = new System.Drawing.Point(133, 6);
        txtMaLo.MaxLength = 40;
        txtMaLo.Name = "txtMaLo";
        txtMaLo.PlaceholderText = "Để trống để tự tạo";
        txtMaLo.Size = new System.Drawing.Size(196, 30);
        txtMaLo.TabIndex = 1;
        // 
        // lblNgaySanXuat
        // 
        lblNgaySanXuat.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblNgaySanXuat.Location = new System.Drawing.Point(3, 53);
        lblNgaySanXuat.Name = "lblNgaySanXuat";
        lblNgaySanXuat.Size = new System.Drawing.Size(124, 23);
        lblNgaySanXuat.TabIndex = 2;
        lblNgaySanXuat.Text = "Ngày SX:";
        lblNgaySanXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // dtpNgaySanXuat
        // 
        dtpNgaySanXuat.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        dtpNgaySanXuat.Checked = false;
        dtpNgaySanXuat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpNgaySanXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpNgaySanXuat.Location = new System.Drawing.Point(133, 49);
        dtpNgaySanXuat.Name = "dtpNgaySanXuat";
        dtpNgaySanXuat.ShowCheckBox = true;
        dtpNgaySanXuat.Size = new System.Drawing.Size(196, 30);
        dtpNgaySanXuat.TabIndex = 3;
        // 
        // lblHanSuDung
        // 
        lblHanSuDung.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblHanSuDung.Location = new System.Drawing.Point(3, 96);
        lblHanSuDung.Name = "lblHanSuDung";
        lblHanSuDung.Size = new System.Drawing.Size(124, 23);
        lblHanSuDung.TabIndex = 4;
        lblHanSuDung.Text = "Hạn sử dụng:";
        lblHanSuDung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // dtpHanSuDung
        // 
        dtpHanSuDung.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        dtpHanSuDung.Checked = false;
        dtpHanSuDung.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpHanSuDung.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpHanSuDung.Location = new System.Drawing.Point(133, 92);
        dtpHanSuDung.Name = "dtpHanSuDung";
        dtpHanSuDung.ShowCheckBox = true;
        dtpHanSuDung.Size = new System.Drawing.Size(196, 30);
        dtpHanSuDung.TabIndex = 5;
        // 
        // dgvSanPham
        // 
        dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvSanPham.Location = new System.Drawing.Point(3, 3);
        dgvSanPham.Name = "dgvSanPham";
        dgvSanPham.RowHeadersWidth = 51;
        dgvSanPham.Size = new System.Drawing.Size(566, 505);
        dgvSanPham.TabIndex = 3;
        dgvSanPham.Text = "dataGridView1";
        // 
        // FormNhapKho
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(960, 626);
        Controls.Add(panel1);
        MinimizeBox = false;
        Text = "FormNhapKho";
        WindowState = System.Windows.Forms.FormWindowState.Maximized;
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        tableLayoutPanel3.ResumeLayout(false);
        tableLayoutPanel3.PerformLayout();
        tableLayoutPanel4.ResumeLayout(false);
        grpThongTinPhieuNhap.ResumeLayout(false);
        tableLayoutPanel5.ResumeLayout(false);
        tableLayoutPanel6.ResumeLayout(false);
        tableLayoutPanel7.ResumeLayout(false);
        tableLayoutPanel7.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudGiaNhap).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
        pnlPhieuNhap.ResumeLayout(false);
        tlpPhieuNhap.ResumeLayout(false);
        grpNhaCungCap.ResumeLayout(false);
        tlpNhaCungCap.ResumeLayout(false);
        tlpNhaCungCap.PerformLayout();
        tlpLoHang.ResumeLayout(false);
        tlpLoHang.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnXacNhan;

    private System.Windows.Forms.NumericUpDown nudGiaNhap;

    private System.Windows.Forms.Label lblGiaNhap;

    private System.Windows.Forms.Label lblSoLuong;
    private System.Windows.Forms.TextBox txtMaSanPham;
    private System.Windows.Forms.NumericUpDown nudSoLuong;

    private System.Windows.Forms.Label lblMaSanPham;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;

    private System.Windows.Forms.Label lblTenSanPham;

    private System.Windows.Forms.Label lblSanPham;

    private System.Windows.Forms.DataGridView dgvSanPham;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;

    private System.Windows.Forms.GroupBox grpThongTinPhieuNhap;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

    private System.Windows.Forms.Button btnTimKiem;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.TextBox txtTimKiem;

    private System.Windows.Forms.Label lblTieuDe;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.Panel panel1;
    
    private System.Windows.Forms.Panel pnlPhieuNhap;
    
    private System.Windows.Forms.TableLayoutPanel tlpPhieuNhap;
    private System.Windows.Forms.GroupBox grpNhaCungCap;
    
    private System.Windows.Forms.TableLayoutPanel tlpNhaCungCap;
    private System.Windows.Forms.Label lblMaNhaCungCap;
    private System.Windows.Forms.TextBox txtMaNhaCungCap;
    
    private System.Windows.Forms.Label lblTenNhaCungCap;
    
    private System.Windows.Forms.TextBox txtTenNhaCungCap;
    private System.Windows.Forms.Label lblSoDienThoaiNhaCungCap;
    private System.Windows.Forms.TextBox txtSoDienThoaiNhaCungCap;
    
    private System.Windows.Forms.Label lblDiaChiNhaCungCap;
    private System.Windows.Forms.TextBox txtDiaChiNhaCungCap;
    private System.Windows.Forms.Label lblEmailNhaCungCap;
    private System.Windows.Forms.TextBox txtEmailNhaCungCap;
    
    private System.Windows.Forms.Label lblGhiChu;
    private System.Windows.Forms.TextBox txtGhiChu;
    private System.Windows.Forms.TableLayoutPanel tlpLoHang;
    private System.Windows.Forms.Label lblMaLo;
    
    private System.Windows.Forms.TextBox txtMaLo;
    private System.Windows.Forms.Label lblNgaySanXuat;
    private System.Windows.Forms.DateTimePicker dtpNgaySanXuat;
    
    private System.Windows.Forms.Label lblHanSuDung;
    private System.Windows.Forms.DateTimePicker dtpHanSuDung;

    #endregion
    
}
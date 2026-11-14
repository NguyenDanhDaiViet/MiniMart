using System.ComponentModel;

namespace MiniMart.Forms;

partial class FormSanPham
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
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        pnlHeader = new System.Windows.Forms.Panel();
        lblTitle = new System.Windows.Forms.Label();
        pnlTimKiem = new System.Windows.Forms.Panel();
        tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
        btnTimKiem = new System.Windows.Forms.Button();
        textBox1 = new System.Windows.Forms.TextBox();
        tableLayoutPanelThongTin = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        panel1 = new System.Windows.Forms.Panel();
        lblMaSP = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        txtMaSP = new System.Windows.Forms.TextBox();
        pnlTenSP = new System.Windows.Forms.Panel();
        lblTenSanPham = new System.Windows.Forms.Label();
        panel4 = new System.Windows.Forms.Panel();
        textBox2 = new System.Windows.Forms.TextBox();
        pnlDonVi = new System.Windows.Forms.Panel();
        lblDonVi = new System.Windows.Forms.Label();
        panel3 = new System.Windows.Forms.Panel();
        txtDonVi = new System.Windows.Forms.TextBox();
        pnlGiaNhap = new System.Windows.Forms.Panel();
        lblGiaNhap = new System.Windows.Forms.Label();
        panel6 = new System.Windows.Forms.Panel();
        nudGiaNhap = new System.Windows.Forms.NumericUpDown();
        pnlTonKho = new System.Windows.Forms.Panel();
        lblTonKho = new System.Windows.Forms.Label();
        panel5 = new System.Windows.Forms.Panel();
        nudTonKho = new System.Windows.Forms.NumericUpDown();
        panel9 = new System.Windows.Forms.Panel();
        lblTonToiThieu = new System.Windows.Forms.Label();
        panel10 = new System.Windows.Forms.Panel();
        nudTonToiThieu = new System.Windows.Forms.NumericUpDown();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        pnlMoi = new System.Windows.Forms.Panel();
        btnMoi = new System.Windows.Forms.Button();
        pnlLuu = new System.Windows.Forms.Panel();
        button2 = new System.Windows.Forms.Button();
        pnlXoa = new System.Windows.Forms.Panel();
        btnXoa = new System.Windows.Forms.Button();
        pnlSanPham = new System.Windows.Forms.Panel();
        dgvSanPham = new System.Windows.Forms.DataGridView();
        pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
        tableLayoutPanel1.SuspendLayout();
        pnlHeader.SuspendLayout();
        pnlTimKiem.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        tableLayoutPanelThongTin.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        pnlTenSP.SuspendLayout();
        panel4.SuspendLayout();
        pnlDonVi.SuspendLayout();
        panel3.SuspendLayout();
        pnlGiaNhap.SuspendLayout();
        panel6.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudGiaNhap).BeginInit();
        pnlTonKho.SuspendLayout();
        panel5.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudTonKho).BeginInit();
        panel9.SuspendLayout();
        panel10.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudTonToiThieu).BeginInit();
        tableLayoutPanel2.SuspendLayout();
        pnlMoi.SuspendLayout();
        pnlLuu.SuspendLayout();
        pnlXoa.SuspendLayout();
        pnlSanPham.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(pnlHeader, 0, 0);
        tableLayoutPanel1.Controls.Add(pnlTimKiem, 0, 1);
        tableLayoutPanel1.Controls.Add(tableLayoutPanelThongTin, 0, 2);
        tableLayoutPanel1.Controls.Add(pnlSanPham, 0, 3);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.7451F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.2549F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 334F));
        tableLayoutPanel1.Size = new System.Drawing.Size(1178, 644);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // pnlHeader
        // 
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlHeader.Location = new System.Drawing.Point(3, 3);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new System.Drawing.Size(1172, 90);
        pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTitle.ForeColor = System.Drawing.Color.Black;
        lblTitle.Location = new System.Drawing.Point(30, 25);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(421, 54);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "QUẢN LÝ SẢN PHẨM";
        // 
        // pnlTimKiem
        // 
        pnlTimKiem.Controls.Add(tableLayoutPanel4);
        pnlTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlTimKiem.Location = new System.Drawing.Point(3, 99);
        pnlTimKiem.Name = "pnlTimKiem";
        pnlTimKiem.Size = new System.Drawing.Size(1172, 51);
        pnlTimKiem.TabIndex = 1;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 2;
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.6314F));
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.3686F));
        tableLayoutPanel4.Controls.Add(btnTimKiem, 1, 0);
        tableLayoutPanel4.Controls.Add(textBox1, 0, 0);
        tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 1;
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.980392F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.019608F));
        tableLayoutPanel4.Size = new System.Drawing.Size(1172, 51);
        tableLayoutPanel4.TabIndex = 0;
        // 
        // btnTimKiem
        // 
        btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Left;
        btnTimKiem.BackColor = System.Drawing.Color.Gainsboro;
        btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTimKiem.Location = new System.Drawing.Point(655, 8);
        btnTimKiem.Name = "btnTimKiem";
        btnTimKiem.Size = new System.Drawing.Size(120, 34);
        btnTimKiem.TabIndex = 1;
        btnTimKiem.Text = "Tìm kiếm";
        btnTimKiem.UseVisualStyleBackColor = false;
        // 
        // textBox1
        // 
        textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        textBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        textBox1.ForeColor = System.Drawing.Color.Gray;
        textBox1.Location = new System.Drawing.Point(3, 8);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(646, 34);
        textBox1.TabIndex = 0;
        textBox1.Text = "Tìm theo mã hoặc tên";
        // 
        // tableLayoutPanelThongTin
        // 
        tableLayoutPanelThongTin.ColumnCount = 1;
        tableLayoutPanelThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanelThongTin.Controls.Add(tableLayoutPanel3, 0, 0);
        tableLayoutPanelThongTin.Controls.Add(tableLayoutPanel2, 0, 1);
        tableLayoutPanelThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanelThongTin.Location = new System.Drawing.Point(3, 156);
        tableLayoutPanelThongTin.Name = "tableLayoutPanelThongTin";
        tableLayoutPanelThongTin.RowCount = 2;
        tableLayoutPanelThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.235294F));
        tableLayoutPanelThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.764706F));
        tableLayoutPanelThongTin.Size = new System.Drawing.Size(1172, 150);
        tableLayoutPanelThongTin.TabIndex = 2;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 6;
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.91684F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.08316F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel3.Controls.Add(panel1, 0, 0);
        tableLayoutPanel3.Controls.Add(panel2, 0, 1);
        tableLayoutPanel3.Controls.Add(pnlTenSP, 1, 0);
        tableLayoutPanel3.Controls.Add(panel4, 1, 1);
        tableLayoutPanel3.Controls.Add(pnlDonVi, 2, 0);
        tableLayoutPanel3.Controls.Add(panel3, 2, 1);
        tableLayoutPanel3.Controls.Add(pnlGiaNhap, 3, 0);
        tableLayoutPanel3.Controls.Add(panel6, 3, 1);
        tableLayoutPanel3.Controls.Add(pnlTonKho, 4, 0);
        tableLayoutPanel3.Controls.Add(panel5, 4, 1);
        tableLayoutPanel3.Controls.Add(panel9, 5, 0);
        tableLayoutPanel3.Controls.Add(panel10, 5, 1);
        tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 2;
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.Size = new System.Drawing.Size(1166, 88);
        tableLayoutPanel3.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.Controls.Add(lblMaSP);
        panel1.Location = new System.Drawing.Point(3, 3);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(186, 38);
        panel1.TabIndex = 0;
        // 
        // lblMaSP
        // 
        lblMaSP.AutoSize = true;
        lblMaSP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblMaSP.Location = new System.Drawing.Point(35, 6);
        lblMaSP.Name = "lblMaSP";
        lblMaSP.Size = new System.Drawing.Size(67, 28);
        lblMaSP.TabIndex = 0;
        lblMaSP.Text = "Mã SP";
        lblMaSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel2
        // 
        panel2.Controls.Add(txtMaSP);
        panel2.Location = new System.Drawing.Point(3, 47);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(186, 38);
        panel2.TabIndex = 1;
        // 
        // txtMaSP
        // 
        txtMaSP.Dock = System.Windows.Forms.DockStyle.Fill;
        txtMaSP.Location = new System.Drawing.Point(0, 0);
        txtMaSP.Name = "txtMaSP";
        txtMaSP.Size = new System.Drawing.Size(186, 31);
        txtMaSP.TabIndex = 0;
        // 
        // pnlTenSP
        // 
        pnlTenSP.Controls.Add(lblTenSanPham);
        pnlTenSP.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlTenSP.Location = new System.Drawing.Point(195, 3);
        pnlTenSP.Name = "pnlTenSP";
        pnlTenSP.Size = new System.Drawing.Size(283, 38);
        pnlTenSP.TabIndex = 2;
        // 
        // lblTenSanPham
        // 
        lblTenSanPham.AutoSize = true;
        lblTenSanPham.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTenSanPham.Location = new System.Drawing.Point(3, 6);
        lblTenSanPham.Name = "lblTenSanPham";
        lblTenSanPham.Size = new System.Drawing.Size(130, 28);
        lblTenSanPham.TabIndex = 0;
        lblTenSanPham.Text = "Tên sản phẩm";
        // 
        // panel4
        // 
        panel4.Controls.Add(textBox2);
        panel4.Dock = System.Windows.Forms.DockStyle.Fill;
        panel4.Location = new System.Drawing.Point(195, 47);
        panel4.Name = "panel4";
        panel4.Size = new System.Drawing.Size(283, 38);
        panel4.TabIndex = 3;
        // 
        // textBox2
        // 
        textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        textBox2.Location = new System.Drawing.Point(0, 0);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(283, 31);
        textBox2.TabIndex = 0;
        // 
        // pnlDonVi
        // 
        pnlDonVi.Controls.Add(lblDonVi);
        pnlDonVi.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlDonVi.Location = new System.Drawing.Point(484, 3);
        pnlDonVi.Name = "pnlDonVi";
        pnlDonVi.Size = new System.Drawing.Size(130, 38);
        pnlDonVi.TabIndex = 4;
        // 
        // lblDonVi
        // 
        lblDonVi.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblDonVi.AutoSize = true;
        lblDonVi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblDonVi.Location = new System.Drawing.Point(12, 6);
        lblDonVi.Name = "lblDonVi";
        lblDonVi.Size = new System.Drawing.Size(69, 28);
        lblDonVi.TabIndex = 0;
        lblDonVi.Text = "Đơn vị";
        // 
        // panel3
        // 
        panel3.Controls.Add(txtDonVi);
        panel3.Dock = System.Windows.Forms.DockStyle.Fill;
        panel3.Location = new System.Drawing.Point(484, 47);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(130, 38);
        panel3.TabIndex = 5;
        // 
        // txtDonVi
        // 
        txtDonVi.Dock = System.Windows.Forms.DockStyle.Fill;
        txtDonVi.Location = new System.Drawing.Point(0, 0);
        txtDonVi.Name = "txtDonVi";
        txtDonVi.Size = new System.Drawing.Size(130, 31);
        txtDonVi.TabIndex = 0;
        // 
        // pnlGiaNhap
        // 
        pnlGiaNhap.Controls.Add(lblGiaNhap);
        pnlGiaNhap.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlGiaNhap.Location = new System.Drawing.Point(620, 3);
        pnlGiaNhap.Name = "pnlGiaNhap";
        pnlGiaNhap.Size = new System.Drawing.Size(193, 38);
        pnlGiaNhap.TabIndex = 6;
        // 
        // lblGiaNhap
        // 
        lblGiaNhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblGiaNhap.AutoSize = true;
        lblGiaNhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblGiaNhap.Location = new System.Drawing.Point(6, 6);
        lblGiaNhap.Name = "lblGiaNhap";
        lblGiaNhap.Size = new System.Drawing.Size(90, 28);
        lblGiaNhap.TabIndex = 0;
        lblGiaNhap.Text = "Giá nhập";
        // 
        // panel6
        // 
        panel6.Controls.Add(nudGiaNhap);
        panel6.Dock = System.Windows.Forms.DockStyle.Fill;
        panel6.Location = new System.Drawing.Point(620, 47);
        panel6.Name = "panel6";
        panel6.Size = new System.Drawing.Size(193, 38);
        panel6.TabIndex = 7;
        // 
        // nudGiaNhap
        // 
        nudGiaNhap.Dock = System.Windows.Forms.DockStyle.Fill;
        nudGiaNhap.Location = new System.Drawing.Point(0, 0);
        nudGiaNhap.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        nudGiaNhap.Name = "nudGiaNhap";
        nudGiaNhap.Size = new System.Drawing.Size(193, 31);
        nudGiaNhap.TabIndex = 0;
        nudGiaNhap.ThousandsSeparator = true;
        // 
        // pnlTonKho
        // 
        pnlTonKho.Controls.Add(lblTonKho);
        pnlTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlTonKho.Location = new System.Drawing.Point(819, 3);
        pnlTonKho.Name = "pnlTonKho";
        pnlTonKho.Size = new System.Drawing.Size(137, 38);
        pnlTonKho.TabIndex = 8;
        // 
        // lblTonKho
        // 
        lblTonKho.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblTonKho.AutoSize = true;
        lblTonKho.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTonKho.Location = new System.Drawing.Point(6, 6);
        lblTonKho.Name = "lblTonKho";
        lblTonKho.Size = new System.Drawing.Size(83, 28);
        lblTonKho.TabIndex = 0;
        lblTonKho.Text = "Tồn kho";
        // 
        // panel5
        // 
        panel5.Controls.Add(nudTonKho);
        panel5.Dock = System.Windows.Forms.DockStyle.Fill;
        panel5.Location = new System.Drawing.Point(819, 47);
        panel5.Name = "panel5";
        panel5.Size = new System.Drawing.Size(137, 38);
        panel5.TabIndex = 9;
        // 
        // nudTonKho
        // 
        nudTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
        nudTonKho.Location = new System.Drawing.Point(0, 0);
        nudTonKho.Name = "nudTonKho";
        nudTonKho.Size = new System.Drawing.Size(137, 31);
        nudTonKho.TabIndex = 0;
        // 
        // panel9
        // 
        panel9.Controls.Add(lblTonToiThieu);
        panel9.Dock = System.Windows.Forms.DockStyle.Fill;
        panel9.Location = new System.Drawing.Point(962, 3);
        panel9.Name = "panel9";
        panel9.Size = new System.Drawing.Size(201, 38);
        panel9.TabIndex = 12;
        // 
        // lblTonToiThieu
        // 
        lblTonToiThieu.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblTonToiThieu.AutoSize = true;
        lblTonToiThieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTonToiThieu.Location = new System.Drawing.Point(6, 6);
        lblTonToiThieu.Name = "lblTonToiThieu";
        lblTonToiThieu.Size = new System.Drawing.Size(123, 28);
        lblTonToiThieu.TabIndex = 0;
        lblTonToiThieu.Text = "Tồn tối thiểu";
        // 
        // panel10
        // 
        panel10.Controls.Add(nudTonToiThieu);
        panel10.Dock = System.Windows.Forms.DockStyle.Fill;
        panel10.Location = new System.Drawing.Point(962, 47);
        panel10.Name = "panel10";
        panel10.Size = new System.Drawing.Size(201, 38);
        panel10.TabIndex = 13;
        // 
        // nudTonToiThieu
        // 
        nudTonToiThieu.Dock = System.Windows.Forms.DockStyle.Fill;
        nudTonToiThieu.Location = new System.Drawing.Point(0, 0);
        nudTonToiThieu.Name = "nudTonToiThieu";
        nudTonToiThieu.Size = new System.Drawing.Size(201, 31);
        nudTonToiThieu.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 3;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.836502F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.163498F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 902F));
        tableLayoutPanel2.Controls.Add(pnlMoi, 0, 0);
        tableLayoutPanel2.Controls.Add(pnlLuu, 1, 0);
        tableLayoutPanel2.Controls.Add(pnlXoa, 2, 0);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(3, 97);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.Size = new System.Drawing.Size(1166, 50);
        tableLayoutPanel2.TabIndex = 1;
        // 
        // pnlMoi
        // 
        pnlMoi.Controls.Add(btnMoi);
        pnlMoi.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlMoi.Location = new System.Drawing.Point(3, 3);
        pnlMoi.Name = "pnlMoi";
        pnlMoi.Size = new System.Drawing.Size(154, 44);
        pnlMoi.TabIndex = 0;
        // 
        // btnMoi
        // 
        btnMoi.BackColor = System.Drawing.Color.Gainsboro;
        btnMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnMoi.Location = new System.Drawing.Point(41, 0);
        btnMoi.Name = "btnMoi";
        btnMoi.Size = new System.Drawing.Size(90, 42);
        btnMoi.TabIndex = 0;
        btnMoi.Text = "Mới";
        btnMoi.UseVisualStyleBackColor = false;
        // 
        // pnlLuu
        // 
        pnlLuu.Controls.Add(button2);
        pnlLuu.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlLuu.Location = new System.Drawing.Point(163, 3);
        pnlLuu.Name = "pnlLuu";
        pnlLuu.Size = new System.Drawing.Size(97, 44);
        pnlLuu.TabIndex = 1;
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.Color.Gainsboro;
        button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button2.Location = new System.Drawing.Point(0, 0);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(90, 42);
        button2.TabIndex = 0;
        button2.Text = "Lưu";
        button2.UseVisualStyleBackColor = false;
        // 
        // pnlXoa
        // 
        pnlXoa.Controls.Add(btnXoa);
        pnlXoa.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlXoa.Location = new System.Drawing.Point(266, 3);
        pnlXoa.Name = "pnlXoa";
        pnlXoa.Size = new System.Drawing.Size(897, 44);
        pnlXoa.TabIndex = 2;
        // 
        // btnXoa
        // 
        btnXoa.BackColor = System.Drawing.Color.Gainsboro;
        btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnXoa.Location = new System.Drawing.Point(10, 0);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new System.Drawing.Size(90, 42);
        btnXoa.TabIndex = 0;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = false;
        // 
        // pnlSanPham
        // 
        pnlSanPham.Controls.Add(dgvSanPham);
        pnlSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlSanPham.Location = new System.Drawing.Point(3, 312);
        pnlSanPham.Name = "pnlSanPham";
        pnlSanPham.Size = new System.Drawing.Size(1172, 329);
        pnlSanPham.TabIndex = 3;
        // 
        // dgvSanPham
        // 
        dgvSanPham.AllowUserToAddRows = false;
        dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvSanPham.BackgroundColor = System.Drawing.Color.White;
        dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvSanPham.Location = new System.Drawing.Point(0, 0);
        dgvSanPham.Name = "dgvSanPham";
        dgvSanPham.ReadOnly = true;
        dgvSanPham.RowHeadersVisible = false;
        dgvSanPham.RowHeadersWidth = 62;
        dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvSanPham.Size = new System.Drawing.Size(1172, 329);
        dgvSanPham.TabIndex = 0;
        dgvSanPham.Text = "dataGridView1";
        // 
        // FormSanPham
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.WhiteSmoke;
        ClientSize = new System.Drawing.Size(1178, 644);
        Controls.Add(tableLayoutPanel1);
        MinimumSize = new System.Drawing.Size(1200, 700);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "MiniMart - Quản lý sản phẩm";
        WindowState = System.Windows.Forms.FormWindowState.Maximized;
        tableLayoutPanel1.ResumeLayout(false);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlTimKiem.ResumeLayout(false);
        tableLayoutPanel4.ResumeLayout(false);
        tableLayoutPanel4.PerformLayout();
        tableLayoutPanelThongTin.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        pnlTenSP.ResumeLayout(false);
        pnlTenSP.PerformLayout();
        panel4.ResumeLayout(false);
        panel4.PerformLayout();
        pnlDonVi.ResumeLayout(false);
        pnlDonVi.PerformLayout();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        pnlGiaNhap.ResumeLayout(false);
        pnlGiaNhap.PerformLayout();
        panel6.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)nudGiaNhap).EndInit();
        pnlTonKho.ResumeLayout(false);
        pnlTonKho.PerformLayout();
        panel5.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)nudTonKho).EndInit();
        panel9.ResumeLayout(false);
        panel9.PerformLayout();
        panel10.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)nudTonToiThieu).EndInit();
        tableLayoutPanel2.ResumeLayout(false);
        pnlMoi.ResumeLayout(false);
        pnlLuu.ResumeLayout(false);
        pnlXoa.ResumeLayout(false);
        pnlSanPham.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

    private System.Windows.Forms.DataGridView dgvSanPham;

    private System.Windows.Forms.Panel pnlSanPham;

    private System.Windows.Forms.Button btnXoa;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button btnMoi;

    private System.Windows.Forms.Panel pnlXoa;

    private System.Windows.Forms.Panel pnlLuu;

    private System.Windows.Forms.Panel pnlMoi;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.NumericUpDown nudTonToiThieu;

    private System.Windows.Forms.Label lblTonToiThieu;

    private System.Windows.Forms.Panel panel10;

    private System.Windows.Forms.Panel panel9;

    private System.Windows.Forms.PageSetupDialog pageSetupDialog1;

    private System.Windows.Forms.Label lblGiaNhap;

    private System.Windows.Forms.NumericUpDown nudTonKho;

    private System.Windows.Forms.Panel panel5;

    private System.Windows.Forms.Panel pnlGiaNhap;

    private System.Windows.Forms.NumericUpDown nudGiaNhap;

    private System.Windows.Forms.Panel panel6;

    private System.Windows.Forms.Label lblTonKho;

    private System.Windows.Forms.Panel pnlTonKho;

    private System.Windows.Forms.TextBox txtDonVi;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Label lblTenSanPham;

    private System.Windows.Forms.Panel pnlDonVi;

    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.Panel panel4;

    private System.Windows.Forms.Label lblDonVi;

    private System.Windows.Forms.Panel pnlTenSP;

    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox txtMaSP;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelThongTin;

    private System.Windows.Forms.Button btnTimKiem;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Panel pnlTimKiem;

    private System.Windows.Forms.Label lblTitle;

    private System.Windows.Forms.Label lblMaSP;

    private System.Windows.Forms.Panel pnlHeader;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    #endregion
}
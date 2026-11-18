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
        pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
        panel1 = new System.Windows.Forms.Panel();
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        dgvSanPham = new System.Windows.Forms.DataGridView();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        lblHeader = new System.Windows.Forms.Label();
        tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
        btnTimKiem = new System.Windows.Forms.Button();
        txtTimKiem = new System.Windows.Forms.TextBox();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
        nudTonToiThieu = new System.Windows.Forms.NumericUpDown();
        nudTonKho = new System.Windows.Forms.NumericUpDown();
        txtDonVi = new System.Windows.Forms.TextBox();
        txtTenSanPham = new System.Windows.Forms.TextBox();
        lblTonToiThieu = new System.Windows.Forms.Label();
        lblTonKho = new System.Windows.Forms.Label();
        lblGiaBan = new System.Windows.Forms.Label();
        lblGiaNhap = new System.Windows.Forms.Label();
        lblDonVi = new System.Windows.Forms.Label();
        lblTenSanPham = new System.Windows.Forms.Label();
        lblMaSP = new System.Windows.Forms.Label();
        txtMaSP = new System.Windows.Forms.TextBox();
        nudGiaBan = new System.Windows.Forms.NumericUpDown();
        tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
        btnXoa = new System.Windows.Forms.Button();
        btnLuu = new System.Windows.Forms.Button();
        btnMoi = new System.Windows.Forms.Button();
        nudGiaNhap = new System.Windows.Forms.NumericUpDown();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        tableLayoutPanel5.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudTonToiThieu).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudTonKho).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudGiaBan).BeginInit();
        tableLayoutPanel6.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudGiaNhap).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(tableLayoutPanel1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(1178, 644);
        panel1.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(dgvSanPham, 0, 2);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.038216F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.961784F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 329F));
        tableLayoutPanel1.Size = new System.Drawing.Size(1178, 644);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // dgvSanPham
        // 
        dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvSanPham.Location = new System.Drawing.Point(3, 317);
        dgvSanPham.Name = "dgvSanPham";
        dgvSanPham.RowHeadersWidth = 62;
        dgvSanPham.Size = new System.Drawing.Size(1172, 324);
        dgvSanPham.TabIndex = 0;
        dgvSanPham.Text = "dataGridView1";
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.Controls.Add(lblHeader, 0, 0);
        tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.617645F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.382355F));
        tableLayoutPanel2.Size = new System.Drawing.Size(1172, 126);
        tableLayoutPanel2.TabIndex = 1;
        // 
        // lblHeader
        // 
        lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblHeader.AutoSize = true;
        lblHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblHeader.Location = new System.Drawing.Point(3, 17);
        lblHeader.Name = "lblHeader";
        lblHeader.Size = new System.Drawing.Size(421, 54);
        lblHeader.TabIndex = 0;
        lblHeader.Text = "QUẢN LÝ SẢN PHẨM";
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 2;
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.3259F));
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.674099F));
        tableLayoutPanel4.Controls.Add(btnTimKiem, 1, 0);
        tableLayoutPanel4.Controls.Add(txtTimKiem, 0, 0);
        tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel4.Location = new System.Drawing.Point(3, 74);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 1;
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.Size = new System.Drawing.Size(1166, 49);
        tableLayoutPanel4.TabIndex = 1;
        // 
        // btnTimKiem
        // 
        btnTimKiem.AutoSize = true;
        btnTimKiem.BackColor = System.Drawing.Color.Gainsboro;
        btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTimKiem.Location = new System.Drawing.Point(823, 3);
        btnTimKiem.Name = "btnTimKiem";
        btnTimKiem.Size = new System.Drawing.Size(101, 38);
        btnTimKiem.TabIndex = 0;
        btnTimKiem.Text = "Tìm kiếm";
        btnTimKiem.UseVisualStyleBackColor = false;
        // 
        // txtTimKiem
        // 
        txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtTimKiem.Location = new System.Drawing.Point(3, 3);
        txtTimKiem.Name = "txtTimKiem";
        txtTimKiem.Size = new System.Drawing.Size(814, 34);
        txtTimKiem.TabIndex = 1;
        txtTimKiem.Text = "Tìm theo mã hoặc tên";
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 0);
        tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 1);
        tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel3.Location = new System.Drawing.Point(3, 135);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 2;
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.86364F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.136364F));
        tableLayoutPanel3.Size = new System.Drawing.Size(1172, 176);
        tableLayoutPanel3.TabIndex = 2;
        // 
        // tableLayoutPanel5
        // 
        tableLayoutPanel5.ColumnCount = 7;
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.897434F));
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.10256F));
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
        tableLayoutPanel5.Controls.Add(nudTonToiThieu, 6, 1);
        tableLayoutPanel5.Controls.Add(nudTonKho, 5, 1);
        tableLayoutPanel5.Controls.Add(txtDonVi, 2, 1);
        tableLayoutPanel5.Controls.Add(txtTenSanPham, 1, 1);
        tableLayoutPanel5.Controls.Add(lblTonToiThieu, 6, 0);
        tableLayoutPanel5.Controls.Add(lblTonKho, 5, 0);
        tableLayoutPanel5.Controls.Add(lblGiaBan, 4, 0);
        tableLayoutPanel5.Controls.Add(lblGiaNhap, 3, 0);
        tableLayoutPanel5.Controls.Add(lblDonVi, 2, 0);
        tableLayoutPanel5.Controls.Add(lblTenSanPham, 1, 0);
        tableLayoutPanel5.Controls.Add(lblMaSP, 0, 0);
        tableLayoutPanel5.Controls.Add(txtMaSP, 0, 1);
        tableLayoutPanel5.Controls.Add(nudGiaBan, 4, 1);
        tableLayoutPanel5.Controls.Add(nudGiaNhap, 3, 1);
        tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel5.Name = "tableLayoutPanel5";
        tableLayoutPanel5.RowCount = 2;
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel5.Size = new System.Drawing.Size(1166, 124);
        tableLayoutPanel5.TabIndex = 0;
        // 
        // nudTonToiThieu
        // 
        nudTonToiThieu.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        nudTonToiThieu.Location = new System.Drawing.Point(987, 77);
        nudTonToiThieu.Name = "nudTonToiThieu";
        nudTonToiThieu.Size = new System.Drawing.Size(176, 31);
        nudTonToiThieu.TabIndex = 13;
        // 
        // nudTonKho
        // 
        nudTonKho.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        nudTonKho.Location = new System.Drawing.Point(810, 77);
        nudTonKho.Name = "nudTonKho";
        nudTonKho.Size = new System.Drawing.Size(171, 31);
        nudTonKho.TabIndex = 12;
        // 
        // txtDonVi
        // 
        txtDonVi.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtDonVi.Location = new System.Drawing.Point(358, 77);
        txtDonVi.Name = "txtDonVi";
        txtDonVi.Size = new System.Drawing.Size(104, 31);
        txtDonVi.TabIndex = 9;
        // 
        // txtTenSanPham
        // 
        txtTenSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtTenSanPham.Location = new System.Drawing.Point(130, 77);
        txtTenSanPham.Name = "txtTenSanPham";
        txtTenSanPham.Size = new System.Drawing.Size(222, 31);
        txtTenSanPham.TabIndex = 8;
        // 
        // lblTonToiThieu
        // 
        lblTonToiThieu.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTonToiThieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTonToiThieu.Location = new System.Drawing.Point(987, 0);
        lblTonToiThieu.Name = "lblTonToiThieu";
        lblTonToiThieu.Size = new System.Drawing.Size(176, 62);
        lblTonToiThieu.TabIndex = 6;
        lblTonToiThieu.Text = "Tồn tối thiểu";
        lblTonToiThieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblTonKho
        // 
        lblTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTonKho.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTonKho.Location = new System.Drawing.Point(810, 0);
        lblTonKho.Name = "lblTonKho";
        lblTonKho.Size = new System.Drawing.Size(171, 62);
        lblTonKho.TabIndex = 5;
        lblTonKho.Text = "Tồn kho";
        lblTonKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblGiaBan
        // 
        lblGiaBan.Dock = System.Windows.Forms.DockStyle.Fill;
        lblGiaBan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblGiaBan.Location = new System.Drawing.Point(682, 0);
        lblGiaBan.Name = "lblGiaBan";
        lblGiaBan.Size = new System.Drawing.Size(122, 62);
        lblGiaBan.TabIndex = 4;
        lblGiaBan.Text = "Giá bán";
        lblGiaBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblGiaNhap
        // 
        lblGiaNhap.Dock = System.Windows.Forms.DockStyle.Fill;
        lblGiaNhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblGiaNhap.Location = new System.Drawing.Point(468, 0);
        lblGiaNhap.Name = "lblGiaNhap";
        lblGiaNhap.Size = new System.Drawing.Size(208, 62);
        lblGiaNhap.TabIndex = 3;
        lblGiaNhap.Text = "Giá nhập";
        lblGiaNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblDonVi
        // 
        lblDonVi.Dock = System.Windows.Forms.DockStyle.Fill;
        lblDonVi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblDonVi.Location = new System.Drawing.Point(358, 0);
        lblDonVi.Name = "lblDonVi";
        lblDonVi.Size = new System.Drawing.Size(104, 62);
        lblDonVi.TabIndex = 2;
        lblDonVi.Text = "Đơn vị";
        lblDonVi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblTenSanPham
        // 
        lblTenSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTenSanPham.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTenSanPham.Location = new System.Drawing.Point(130, 0);
        lblTenSanPham.Name = "lblTenSanPham";
        lblTenSanPham.Size = new System.Drawing.Size(222, 62);
        lblTenSanPham.TabIndex = 1;
        lblTenSanPham.Text = "Tên sản phẩm";
        lblTenSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblMaSP
        // 
        lblMaSP.Dock = System.Windows.Forms.DockStyle.Fill;
        lblMaSP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblMaSP.Location = new System.Drawing.Point(3, 0);
        lblMaSP.Name = "lblMaSP";
        lblMaSP.Size = new System.Drawing.Size(121, 62);
        lblMaSP.TabIndex = 0;
        lblMaSP.Text = "Mã SP";
        lblMaSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtMaSP
        // 
        txtMaSP.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtMaSP.Location = new System.Drawing.Point(3, 77);
        txtMaSP.Name = "txtMaSP";
        txtMaSP.Size = new System.Drawing.Size(121, 31);
        txtMaSP.TabIndex = 7;
        // 
        // nudGiaBan
        // 
        nudGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        nudGiaBan.Location = new System.Drawing.Point(682, 77);
        nudGiaBan.Name = "nudGiaBan";
        nudGiaBan.Size = new System.Drawing.Size(122, 31);
        nudGiaBan.TabIndex = 11;
        // 
        // tableLayoutPanel6
        // 
        tableLayoutPanel6.ColumnCount = 3;
        tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.014492F));
        tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.985508F));
        tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 889F));
        tableLayoutPanel6.Controls.Add(btnXoa, 2, 0);
        tableLayoutPanel6.Controls.Add(btnLuu, 1, 0);
        tableLayoutPanel6.Controls.Add(btnMoi, 0, 0);
        tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel6.Location = new System.Drawing.Point(3, 133);
        tableLayoutPanel6.Name = "tableLayoutPanel6";
        tableLayoutPanel6.RowCount = 1;
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel6.Size = new System.Drawing.Size(1166, 40);
        tableLayoutPanel6.TabIndex = 1;
        // 
        // btnXoa
        // 
        btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Left;
        btnXoa.Location = new System.Drawing.Point(279, 4);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new System.Drawing.Size(75, 32);
        btnXoa.TabIndex = 2;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = true;
        // 
        // btnLuu
        // 
        btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnLuu.Location = new System.Drawing.Point(164, 4);
        btnLuu.Name = "btnLuu";
        btnLuu.Size = new System.Drawing.Size(75, 32);
        btnLuu.TabIndex = 1;
        btnLuu.Text = "Lưu";
        btnLuu.UseVisualStyleBackColor = true;
        // 
        // btnMoi
        // 
        btnMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnMoi.Location = new System.Drawing.Point(26, 4);
        btnMoi.Name = "btnMoi";
        btnMoi.Size = new System.Drawing.Size(75, 32);
        btnMoi.TabIndex = 0;
        btnMoi.Text = "Mới";
        btnMoi.UseVisualStyleBackColor = true;
        // 
        // nudGiaNhap
        // 
        nudGiaNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        nudGiaNhap.Location = new System.Drawing.Point(468, 77);
        nudGiaNhap.Name = "nudGiaNhap";
        nudGiaNhap.Size = new System.Drawing.Size(208, 31);
        nudGiaNhap.TabIndex = 14;
        // 
        // FormSanPham
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.WhiteSmoke;
        ClientSize = new System.Drawing.Size(1178, 644);
        Controls.Add(panel1);
        MinimumSize = new System.Drawing.Size(1200, 700);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "MiniMart - Quản lý sản phẩm";
        WindowState = System.Windows.Forms.FormWindowState.Maximized;
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        tableLayoutPanel4.ResumeLayout(false);
        tableLayoutPanel4.PerformLayout();
        tableLayoutPanel3.ResumeLayout(false);
        tableLayoutPanel5.ResumeLayout(false);
        tableLayoutPanel5.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudTonToiThieu).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudTonKho).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudGiaBan).EndInit();
        tableLayoutPanel6.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)nudGiaNhap).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.NumericUpDown nudGiaNhap;


    private System.Windows.Forms.Button btnLuu;
    private System.Windows.Forms.Button btnXoa;

    private System.Windows.Forms.NumericUpDown nudTonKho;
    private System.Windows.Forms.NumericUpDown nudTonToiThieu;
    private System.Windows.Forms.Button btnMoi;

    private System.Windows.Forms.TextBox txtDonVi;
    private System.Windows.Forms.NumericUpDown nudGiaBan;

    private System.Windows.Forms.TextBox txtTenSanPham;

    private System.Windows.Forms.Label lblTenSanPham;
    private System.Windows.Forms.Label lblDonVi;
    private System.Windows.Forms.Label lblGiaNhap;
    private System.Windows.Forms.Label lblGiaBan;
    private System.Windows.Forms.Label lblTonKho;
    private System.Windows.Forms.Label lblTonToiThieu;
    private System.Windows.Forms.TextBox txtMaSP;

    private System.Windows.Forms.Label lblMaSP;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;

    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.TextBox txtTimKiem;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

    private System.Windows.Forms.Label lblHeader;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.DataGridView dgvSanPham;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.PageSetupDialog pageSetupDialog1;

    #endregion
}
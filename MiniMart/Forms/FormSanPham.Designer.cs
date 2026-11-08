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
        btnTimKiem = new System.Windows.Forms.Button();
        txtTimKiem = new System.Windows.Forms.TextBox();
        pnlThongTin = new System.Windows.Forms.Panel();
        lblTenSP = new System.Windows.Forms.Label();
        lblMaSP = new System.Windows.Forms.Label();
        lblDonVi = new System.Windows.Forms.Label();
        lblGiaNhap = new System.Windows.Forms.Label();
        lblGiaBan = new System.Windows.Forms.Label();
        lblTonKho = new System.Windows.Forms.Label();
        lblTonToiThieu = new System.Windows.Forms.Label();
        txtMaSP = new System.Windows.Forms.TextBox();
        txtTenSP = new System.Windows.Forms.TextBox();
        txtDonVi = new System.Windows.Forms.TextBox();
        nudGiaNhap = new System.Windows.Forms.NumericUpDown();
        nudGiaBan = new System.Windows.Forms.NumericUpDown();
        nudTonKho = new System.Windows.Forms.NumericUpDown();
        nudTonToiThieu = new System.Windows.Forms.NumericUpDown();
        btnMoi = new System.Windows.Forms.Button();
        btnLuu = new System.Windows.Forms.Button();
        btnXoa = new System.Windows.Forms.Button();
        pnlSanPham = new System.Windows.Forms.Panel();
        dgvSanPham = new System.Windows.Forms.DataGridView();
        tableLayoutPanel1.SuspendLayout();
        pnlHeader.SuspendLayout();
        pnlTimKiem.SuspendLayout();
        pnlThongTin.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudGiaNhap).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudGiaBan).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudTonKho).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudTonToiThieu).BeginInit();
        pnlSanPham.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.36674F));
        tableLayoutPanel1.Controls.Add(pnlHeader, 0, 0);
        tableLayoutPanel1.Controls.Add(pnlTimKiem, 0, 1);
        tableLayoutPanel1.Controls.Add(pnlThongTin, 0, 2);
        tableLayoutPanel1.Controls.Add(pnlSanPham, 0, 3);
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.979168F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.020832F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 151F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 391F));
        tableLayoutPanel1.Size = new System.Drawing.Size(1377, 691);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // pnlHeader
        // 
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlHeader.Location = new System.Drawing.Point(3, 3);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new System.Drawing.Size(1371, 86);
        pnlHeader.TabIndex = 0;
        pnlHeader.Paint += pnlHeader_Paint;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTitle.ForeColor = System.Drawing.Color.Black;
        lblTitle.Location = new System.Drawing.Point(35, 25);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(421, 54);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "QUẢN LÝ SẢN PHẨM";
        // 
        // pnlTimKiem
        // 
        pnlTimKiem.Controls.Add(btnTimKiem);
        pnlTimKiem.Controls.Add(txtTimKiem);
        pnlTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlTimKiem.Location = new System.Drawing.Point(3, 95);
        pnlTimKiem.Name = "pnlTimKiem";
        pnlTimKiem.Size = new System.Drawing.Size(1371, 50);
        pnlTimKiem.TabIndex = 1;
        // 
        // btnTimKiem
        // 
        btnTimKiem.BackColor = System.Drawing.Color.Gainsboro;
        btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTimKiem.Location = new System.Drawing.Point(378, 13);
        btnTimKiem.Name = "btnTimKiem";
        btnTimKiem.Size = new System.Drawing.Size(105, 34);
        btnTimKiem.TabIndex = 1;
        btnTimKiem.Text = "Tìm kiếm";
        btnTimKiem.UseVisualStyleBackColor = false;
        // 
        // txtTimKiem
        // 
        txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtTimKiem.Location = new System.Drawing.Point(47, 13);
        txtTimKiem.Name = "txtTimKiem";
        txtTimKiem.Size = new System.Drawing.Size(320, 34);
        txtTimKiem.TabIndex = 0;
        txtTimKiem.Text = "Tìm theo mã hoặc tên";
        // 
        // pnlThongTin
        // 
        pnlThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        pnlThongTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        pnlThongTin.Controls.Add(btnXoa);
        pnlThongTin.Controls.Add(btnLuu);
        pnlThongTin.Controls.Add(btnMoi);
        pnlThongTin.Controls.Add(nudTonToiThieu);
        pnlThongTin.Controls.Add(nudTonKho);
        pnlThongTin.Controls.Add(nudGiaBan);
        pnlThongTin.Controls.Add(nudGiaNhap);
        pnlThongTin.Controls.Add(txtDonVi);
        pnlThongTin.Controls.Add(txtTenSP);
        pnlThongTin.Controls.Add(txtMaSP);
        pnlThongTin.Controls.Add(lblTonToiThieu);
        pnlThongTin.Controls.Add(lblTonKho);
        pnlThongTin.Controls.Add(lblGiaBan);
        pnlThongTin.Controls.Add(lblGiaNhap);
        pnlThongTin.Controls.Add(lblDonVi);
        pnlThongTin.Controls.Add(lblTenSP);
        pnlThongTin.Controls.Add(lblMaSP);
        pnlThongTin.Location = new System.Drawing.Point(3, 151);
        pnlThongTin.Name = "pnlThongTin";
        pnlThongTin.Size = new System.Drawing.Size(1371, 145);
        pnlThongTin.TabIndex = 2;
        // 
        // lblTenSP
        // 
        lblTenSP.AutoSize = true;
        lblTenSP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTenSP.Location = new System.Drawing.Point(205, 15);
        lblTenSP.Name = "lblTenSP";
        lblTenSP.Size = new System.Drawing.Size(130, 28);
        lblTenSP.TabIndex = 1;
        lblTenSP.Text = "Tên sản phẩm";
        // 
        // lblMaSP
        // 
        lblMaSP.AutoSize = true;
        lblMaSP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblMaSP.Location = new System.Drawing.Point(42, 15);
        lblMaSP.Name = "lblMaSP";
        lblMaSP.Size = new System.Drawing.Size(67, 28);
        lblMaSP.TabIndex = 0;
        lblMaSP.Text = "Mã SP";
        // 
        // lblDonVi
        // 
        lblDonVi.AutoSize = true;
        lblDonVi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblDonVi.Location = new System.Drawing.Point(480, 15);
        lblDonVi.Name = "lblDonVi";
        lblDonVi.Size = new System.Drawing.Size(69, 28);
        lblDonVi.TabIndex = 2;
        lblDonVi.Text = "Đơn vị";
        // 
        // lblGiaNhap
        // 
        lblGiaNhap.AutoSize = true;
        lblGiaNhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblGiaNhap.Location = new System.Drawing.Point(610, 15);
        lblGiaNhap.Name = "lblGiaNhap";
        lblGiaNhap.Size = new System.Drawing.Size(90, 28);
        lblGiaNhap.TabIndex = 3;
        lblGiaNhap.Text = "Giá nhập";
        // 
        // lblGiaBan
        // 
        lblGiaBan.AutoSize = true;
        lblGiaBan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblGiaBan.Location = new System.Drawing.Point(785, 15);
        lblGiaBan.Name = "lblGiaBan";
        lblGiaBan.Size = new System.Drawing.Size(79, 28);
        lblGiaBan.TabIndex = 4;
        lblGiaBan.Text = "Giá bán";
        // 
        // lblTonKho
        // 
        lblTonKho.AutoSize = true;
        lblTonKho.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTonKho.Location = new System.Drawing.Point(960, 15);
        lblTonKho.Name = "lblTonKho";
        lblTonKho.Size = new System.Drawing.Size(83, 28);
        lblTonKho.TabIndex = 5;
        lblTonKho.Text = "Tồn kho";
        // 
        // lblTonToiThieu
        // 
        lblTonToiThieu.AutoSize = true;
        lblTonToiThieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTonToiThieu.Location = new System.Drawing.Point(1090, 15);
        lblTonToiThieu.Name = "lblTonToiThieu";
        lblTonToiThieu.Size = new System.Drawing.Size(123, 28);
        lblTonToiThieu.TabIndex = 6;
        lblTonToiThieu.Text = "Tồn tối thiểu";
        // 
        // txtMaSP
        // 
        txtMaSP.Location = new System.Drawing.Point(47, 50);
        txtMaSP.Name = "txtMaSP";
        txtMaSP.Size = new System.Drawing.Size(142, 31);
        txtMaSP.TabIndex = 7;
        // 
        // txtTenSP
        // 
        txtTenSP.Location = new System.Drawing.Point(210, 50);
        txtTenSP.Name = "txtTenSP";
        txtTenSP.Size = new System.Drawing.Size(255, 31);
        txtTenSP.TabIndex = 8;
        // 
        // txtDonVi
        // 
        txtDonVi.Location = new System.Drawing.Point(485, 50);
        txtDonVi.Name = "txtDonVi";
        txtDonVi.Size = new System.Drawing.Size(110, 31);
        txtDonVi.TabIndex = 9;
        // 
        // nudGiaNhap
        // 
        nudGiaNhap.Location = new System.Drawing.Point(615, 50);
        nudGiaNhap.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        nudGiaNhap.Name = "nudGiaNhap";
        nudGiaNhap.Size = new System.Drawing.Size(150, 31);
        nudGiaNhap.TabIndex = 10;
        nudGiaNhap.ThousandsSeparator = true;
        // 
        // nudGiaBan
        // 
        nudGiaBan.Location = new System.Drawing.Point(790, 50);
        nudGiaBan.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        nudGiaBan.Name = "nudGiaBan";
        nudGiaBan.Size = new System.Drawing.Size(150, 31);
        nudGiaBan.TabIndex = 11;
        nudGiaBan.ThousandsSeparator = true;
        // 
        // nudTonKho
        // 
        nudTonKho.Location = new System.Drawing.Point(965, 50);
        nudTonKho.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nudTonKho.Name = "nudTonKho";
        nudTonKho.Size = new System.Drawing.Size(110, 31);
        nudTonKho.TabIndex = 12;
        nudTonKho.ThousandsSeparator = true;
        // 
        // nudTonToiThieu
        // 
        nudTonToiThieu.Location = new System.Drawing.Point(1095, 50);
        nudTonToiThieu.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nudTonToiThieu.Name = "nudTonToiThieu";
        nudTonToiThieu.Size = new System.Drawing.Size(120, 31);
        nudTonToiThieu.TabIndex = 13;
        nudTonToiThieu.ThousandsSeparator = true;
        // 
        // btnMoi
        // 
        btnMoi.BackColor = System.Drawing.Color.Gainsboro;
        btnMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnMoi.Location = new System.Drawing.Point(47, 95);
        btnMoi.Name = "btnMoi";
        btnMoi.Size = new System.Drawing.Size(90, 42);
        btnMoi.TabIndex = 14;
        btnMoi.Text = "Mới";
        btnMoi.UseVisualStyleBackColor = false;
        // 
        // btnLuu
        // 
        btnLuu.BackColor = System.Drawing.Color.Gainsboro;
        btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnLuu.Location = new System.Drawing.Point(156, 95);
        btnLuu.Name = "btnLuu";
        btnLuu.Size = new System.Drawing.Size(90, 42);
        btnLuu.TabIndex = 15;
        btnLuu.Text = "Lưu";
        btnLuu.UseVisualStyleBackColor = false;
        // 
        // btnXoa
        // 
        btnXoa.BackColor = System.Drawing.Color.Gainsboro;
        btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnXoa.Location = new System.Drawing.Point(265, 95);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new System.Drawing.Size(90, 42);
        btnXoa.TabIndex = 16;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = false;
        // 
        // pnlSanPham
        // 
        pnlSanPham.Controls.Add(dgvSanPham);
        pnlSanPham.Location = new System.Drawing.Point(3, 302);
        pnlSanPham.Name = "pnlSanPham";
        pnlSanPham.Size = new System.Drawing.Size(1371, 386);
        pnlSanPham.TabIndex = 3;
        // 
        // dgvSanPham
        // 
        dgvSanPham.AllowUserToAddRows = false;
        dgvSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvSanPham.BackgroundColor = System.Drawing.Color.White;
        dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSanPham.Location = new System.Drawing.Point(47, 15);
        dgvSanPham.Name = "dgvSanPham";
        dgvSanPham.ReadOnly = true;
        dgvSanPham.RowHeadersVisible = false;
        dgvSanPham.RowHeadersWidth = 62;
        dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvSanPham.Size = new System.Drawing.Size(1316, 368);
        dgvSanPham.TabIndex = 0;
        dgvSanPham.Text = "dataGridView1";
        // 
        // FormSanPham
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.WhiteSmoke;
        ClientSize = new System.Drawing.Size(1378, 694);
        Controls.Add(tableLayoutPanel1);
        MinimumSize = new System.Drawing.Size(1200, 700);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "MiniMart - Quản lý sản phẩm";
        WindowState = System.Windows.Forms.FormWindowState.Maximized;
        tableLayoutPanel1.ResumeLayout(false);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlTimKiem.ResumeLayout(false);
        pnlTimKiem.PerformLayout();
        pnlThongTin.ResumeLayout(false);
        pnlThongTin.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudGiaNhap).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudGiaBan).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudTonKho).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudTonToiThieu).EndInit();
        pnlSanPham.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dgvSanPham;

    private System.Windows.Forms.Panel pnlSanPham;

    private System.Windows.Forms.Button btnXoa;

    private System.Windows.Forms.Button btnLuu;

    private System.Windows.Forms.Button btnMoi;

    private System.Windows.Forms.NumericUpDown nudTonToiThieu;

    private System.Windows.Forms.NumericUpDown nudTonKho;

    private System.Windows.Forms.NumericUpDown nudGiaBan;

    private System.Windows.Forms.NumericUpDown nudGiaNhap;

    private System.Windows.Forms.TextBox txtDonVi;

    private System.Windows.Forms.TextBox txtTenSP;

    private System.Windows.Forms.TextBox txtMaSP;

    private System.Windows.Forms.Label lblTonToiThieu;

    private System.Windows.Forms.Label lblTonKho;

    private System.Windows.Forms.Label lblGiaBan;

    private System.Windows.Forms.Label lblGiaNhap;

    private System.Windows.Forms.Label lblDonVi;

    private System.Windows.Forms.Label lblTenSP;

    private System.Windows.Forms.Label lblMaSP;

    private System.Windows.Forms.Panel pnlThongTin;

    private System.Windows.Forms.Button btnTimKiem;

    private System.Windows.Forms.TextBox txtTimKiem;

    private System.Windows.Forms.Panel pnlTimKiem;

    private System.Windows.Forms.Label lblTitle;

    private System.Windows.Forms.Panel pnlHeader;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    #endregion
}
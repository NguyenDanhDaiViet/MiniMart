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
        pnlHeader = new System.Windows.Forms.Panel();
        lblTitle = new System.Windows.Forms.Label();
        lblDanhSach = new System.Windows.Forms.Label();
        txtTimKiem = new System.Windows.Forms.TextBox();
        btnTimKiem = new System.Windows.Forms.Button();
        dgvSanPham = new System.Windows.Forms.DataGridView();
        lblGioHang = new System.Windows.Forms.Label();
        dgvGioHang = new System.Windows.Forms.DataGridView();
        labelSoLuong = new System.Windows.Forms.Label();
        nudSoLuong = new System.Windows.Forms.NumericUpDown();
        lblGiamGiaDong = new System.Windows.Forms.Label();
        nudGiamGiaDong = new System.Windows.Forms.NumericUpDown();
        btnCapNhat = new System.Windows.Forms.Button();
        btnBoDong = new System.Windows.Forms.Button();
        lblGiamGiaHoaDon = new System.Windows.Forms.Label();
        nudGiamGiaHoaDon = new System.Windows.Forms.NumericUpDown();
        lblKhachDua = new System.Windows.Forms.Label();
        txtTienKhachDua = new System.Windows.Forms.TextBox();
        lblTongCong = new System.Windows.Forms.Label();
        pnlHeader.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudGiamGiaDong).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudGiamGiaHoaDon).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Location = new System.Drawing.Point(15, 10);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new System.Drawing.Size(1360, 65);
        pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTitle.ForeColor = System.Drawing.Color.DarkGreen;
        lblTitle.Location = new System.Drawing.Point(48, 11);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(239, 54);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "BÁN HÀNG";
        // 
        // lblDanhSach
        // 
        lblDanhSach.AutoSize = true;
        lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblDanhSach.Location = new System.Drawing.Point(20, 90);
        lblDanhSach.Name = "lblDanhSach";
        lblDanhSach.Size = new System.Drawing.Size(248, 32);
        lblDanhSach.TabIndex = 1;
        lblDanhSach.Text = "Danh sách sán phẩm";
        // 
        // txtTimKiem
        // 
        txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtTimKiem.Location = new System.Drawing.Point(20, 125);
        txtTimKiem.Name = "txtTimKiem";
        txtTimKiem.Size = new System.Drawing.Size(342, 34);
        txtTimKiem.TabIndex = 2;
        txtTimKiem.Text = "Nhập mã hoặc tên sản phẩm";
        // 
        // btnTimKiem
        // 
        btnTimKiem.BackColor = System.Drawing.Color.DarkGreen;
        btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTimKiem.ForeColor = System.Drawing.Color.White;
        btnTimKiem.Location = new System.Drawing.Point(368, 125);
        btnTimKiem.Name = "btnTimKiem";
        btnTimKiem.Size = new System.Drawing.Size(80, 35);
        btnTimKiem.TabIndex = 3;
        btnTimKiem.Text = "Tìm";
        btnTimKiem.UseVisualStyleBackColor = false;
        // 
        // dgvSanPham
        // 
        dgvSanPham.AllowUserToAddRows = false;
        dgvSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left));
        dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvSanPham.BackgroundColor = System.Drawing.Color.DarkGray;
        dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSanPham.Location = new System.Drawing.Point(20, 175);
        dgvSanPham.Name = "dgvSanPham";
        dgvSanPham.ReadOnly = true;
        dgvSanPham.RowHeadersWidth = 62;
        dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvSanPham.Size = new System.Drawing.Size(428, 480);
        dgvSanPham.TabIndex = 4;
        dgvSanPham.Text = "dataGridView1";
        // 
        // lblGioHang
        // 
        lblGioHang.AutoSize = true;
        lblGioHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblGioHang.Location = new System.Drawing.Point(472, 90);
        lblGioHang.Name = "lblGioHang";
        lblGioHang.Size = new System.Drawing.Size(117, 32);
        lblGioHang.TabIndex = 5;
        lblGioHang.Text = "Giỏ hàng";
        // 
        // dgvGioHang
        // 
        dgvGioHang.AllowUserToAddRows = false;
        dgvGioHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvGioHang.BackgroundColor = System.Drawing.Color.White;
        dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvGioHang.Location = new System.Drawing.Point(472, 136);
        dgvGioHang.Name = "dgvGioHang";
        dgvGioHang.ReadOnly = true;
        dgvGioHang.RowHeadersWidth = 62;
        dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvGioHang.Size = new System.Drawing.Size(863, 390);
        dgvGioHang.TabIndex = 6;
        dgvGioHang.Text = "dataGridView1";
        // 
        // labelSoLuong
        // 
        labelSoLuong.Location = new System.Drawing.Point(467, 545);
        labelSoLuong.Name = "labelSoLuong";
        labelSoLuong.Size = new System.Drawing.Size(100, 25);
        labelSoLuong.TabIndex = 7;
        labelSoLuong.Text = "Số lượng";
        // 
        // nudSoLuong
        // 
        nudSoLuong.Location = new System.Drawing.Point(472, 575);
        nudSoLuong.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
        nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudSoLuong.Name = "nudSoLuong";
        nudSoLuong.Size = new System.Drawing.Size(105, 31);
        nudSoLuong.TabIndex = 8;
        nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblGiamGiaDong
        // 
        lblGiamGiaDong.Location = new System.Drawing.Point(600, 545);
        lblGiamGiaDong.Name = "lblGiamGiaDong";
        lblGiamGiaDong.Size = new System.Drawing.Size(150, 25);
        lblGiamGiaDong.TabIndex = 9;
        lblGiamGiaDong.Text = "Giảm giá dòng ";
        // 
        // nudGiamGiaDong
        // 
        nudGiamGiaDong.Location = new System.Drawing.Point(605, 575);
        nudGiamGiaDong.Name = "nudGiamGiaDong";
        nudGiamGiaDong.Size = new System.Drawing.Size(105, 31);
        nudGiamGiaDong.TabIndex = 10;
        // 
        // btnCapNhat
        // 
        btnCapNhat.BackColor = System.Drawing.Color.LightGray;
        btnCapNhat.Location = new System.Drawing.Point(745, 565);
        btnCapNhat.Name = "btnCapNhat";
        btnCapNhat.Size = new System.Drawing.Size(120, 40);
        btnCapNhat.TabIndex = 11;
        btnCapNhat.Text = "Cập nhật";
        btnCapNhat.UseVisualStyleBackColor = false;
        // 
        // btnBoDong
        // 
        btnBoDong.BackColor = System.Drawing.Color.DarkGreen;
        btnBoDong.ForeColor = System.Drawing.Color.White;
        btnBoDong.Location = new System.Drawing.Point(880, 565);
        btnBoDong.Name = "btnBoDong";
        btnBoDong.Size = new System.Drawing.Size(120, 40);
        btnBoDong.TabIndex = 12;
        btnBoDong.Text = "Bỏ dòng";
        btnBoDong.UseVisualStyleBackColor = false;
        // 
        // lblGiamGiaHoaDon
        // 
        lblGiamGiaHoaDon.Location = new System.Drawing.Point(472, 625);
        lblGiamGiaHoaDon.Name = "lblGiamGiaHoaDon";
        lblGiamGiaHoaDon.Size = new System.Drawing.Size(120, 25);
        lblGiamGiaHoaDon.TabIndex = 13;
        lblGiamGiaHoaDon.Text = "Giảm giá (%)";
        // 
        // nudGiamGiaHoaDon
        // 
        nudGiamGiaHoaDon.Location = new System.Drawing.Point(605, 620);
        nudGiamGiaHoaDon.Name = "nudGiamGiaHoaDon";
        nudGiamGiaHoaDon.Size = new System.Drawing.Size(105, 31);
        nudGiamGiaHoaDon.TabIndex = 14;
        // 
        // lblKhachDua
        // 
        lblKhachDua.Location = new System.Drawing.Point(745, 625);
        lblKhachDua.Name = "lblKhachDua";
        lblKhachDua.Size = new System.Drawing.Size(129, 25);
        lblKhachDua.TabIndex = 15;
        lblKhachDua.Text = "Khách đưa (đ)";
        // 
        // txtTienKhachDua
        // 
        txtTienKhachDua.Location = new System.Drawing.Point(880, 620);
        txtTienKhachDua.Name = "txtTienKhachDua";
        txtTienKhachDua.Size = new System.Drawing.Size(120, 31);
        txtTienKhachDua.TabIndex = 16;
        txtTienKhachDua.Text = "0";
        // 
        // lblTongCong
        // 
        lblTongCong.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTongCong.ForeColor = System.Drawing.Color.DarkGreen;
        lblTongCong.Location = new System.Drawing.Point(1050, 610);
        lblTongCong.Name = "lblTongCong";
        lblTongCong.Size = new System.Drawing.Size(300, 50);
        lblTongCong.TabIndex = 17;
        lblTongCong.Text = "Tổng cộng: 0đ";
        lblTongCong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // FormBanHang
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.WhiteSmoke;
        ClientSize = new System.Drawing.Size(1378, 694);
        Controls.Add(lblTongCong);
        Controls.Add(txtTienKhachDua);
        Controls.Add(lblKhachDua);
        Controls.Add(nudGiamGiaHoaDon);
        Controls.Add(lblGiamGiaHoaDon);
        Controls.Add(btnBoDong);
        Controls.Add(btnCapNhat);
        Controls.Add(nudGiamGiaDong);
        Controls.Add(lblGiamGiaDong);
        Controls.Add(nudSoLuong);
        Controls.Add(labelSoLuong);
        Controls.Add(dgvGioHang);
        Controls.Add(lblGioHang);
        Controls.Add(dgvSanPham);
        Controls.Add(btnTimKiem);
        Controls.Add(txtTimKiem);
        Controls.Add(lblDanhSach);
        Controls.Add(pnlHeader);
        MinimumSize = new System.Drawing.Size(1200, 700);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "MiniMart - Bán hàng";
        WindowState = System.Windows.Forms.FormWindowState.Maximized;
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudGiamGiaDong).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudGiamGiaHoaDon).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label lblTongCong;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox txtTienKhachDua;

    private System.Windows.Forms.Label lblKhachDua;

    private System.Windows.Forms.NumericUpDown nudGiamGiaHoaDon;

    private System.Windows.Forms.Label lblGiamGiaHoaDon;

    private System.Windows.Forms.Button btnBoDong;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Button btnCapNhat;

    private System.Windows.Forms.NumericUpDown nudGiamGiaDong;

    private System.Windows.Forms.Label lblGiamGiaDong;

    private System.Windows.Forms.NumericUpDown nudSoLuong;

    private System.Windows.Forms.Label labelSoLuong;

    private System.Windows.Forms.DataGridView dgvGioHang;

    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.Label lblGioHang;

    private System.Windows.Forms.DataGridView dgvSanPham;

    private System.Windows.Forms.Button btnTimKiem;

    private System.Windows.Forms.TextBox txtTimKiem;

    private System.Windows.Forms.Label lblDanhSach;

    private System.Windows.Forms.Label lblTitle;

    private System.Windows.Forms.Panel pnlHeader;

    #endregion
}
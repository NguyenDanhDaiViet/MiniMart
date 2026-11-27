using System.ComponentModel;

namespace MiniMart.Forms;

partial class FormQuanLyTaiKhoan
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
        btnTimKiem = new System.Windows.Forms.Button();
        txtTimKiem = new System.Windows.Forms.TextBox();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
        btnKhoaMoKhoa = new System.Windows.Forms.Button();
        btnLuu = new System.Windows.Forms.Button();
        btnLamMoi = new System.Windows.Forms.Button();
        tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
        txtMatKhau = new System.Windows.Forms.TextBox();
        txtHoTen = new System.Windows.Forms.TextBox();
        lblVaiTro = new System.Windows.Forms.Label();
        lblMatKhau = new System.Windows.Forms.Label();
        lblHoTen = new System.Windows.Forms.Label();
        lblTenDangNhap = new System.Windows.Forms.Label();
        txtTenDangNhap = new System.Windows.Forms.TextBox();
        cboVaiTro = new System.Windows.Forms.ComboBox();
        chkHienMatKhau = new System.Windows.Forms.CheckBox();
        panel3 = new System.Windows.Forms.Panel();
        dgvTaiKhoan = new System.Windows.Forms.DataGridView();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        tableLayoutPanel5.SuspendLayout();
        panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(tableLayoutPanel1);
        panel1.Dock = System.Windows.Forms.DockStyle.Top;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(1119, 350);
        panel1.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new System.Drawing.Size(1119, 350);
        tableLayoutPanel1.TabIndex = 1;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.22891F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.771084F));
        tableLayoutPanel2.Controls.Add(lblTieuDe, 0, 0);
        tableLayoutPanel2.Controls.Add(btnTimKiem, 1, 1);
        tableLayoutPanel2.Controls.Add(txtTimKiem, 0, 1);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.Size = new System.Drawing.Size(1113, 169);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // lblTieuDe
        // 
        lblTieuDe.Anchor = System.Windows.Forms.AnchorStyles.None;
        lblTieuDe.AutoSize = true;
        lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTieuDe.ForeColor = System.Drawing.Color.Navy;
        lblTieuDe.Location = new System.Drawing.Point(308, 23);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new System.Drawing.Size(299, 38);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "QUẢN LÝ TÀI KHOẢN";
        lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btnTimKiem
        // 
        btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnTimKiem.AutoSize = true;
        btnTimKiem.BackColor = System.Drawing.Color.Navy;
        btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTimKiem.ForeColor = System.Drawing.Color.White;
        btnTimKiem.Location = new System.Drawing.Point(926, 105);
        btnTimKiem.Name = "btnTimKiem";
        btnTimKiem.Size = new System.Drawing.Size(176, 42);
        btnTimKiem.TabIndex = 2;
        btnTimKiem.Text = "Tìm kiếm";
        btnTimKiem.UseVisualStyleBackColor = false;
        // 
        // txtTimKiem
        // 
        txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtTimKiem.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtTimKiem.Location = new System.Drawing.Point(3, 113);
        txtTimKiem.Name = "txtTimKiem";
        txtTimKiem.Size = new System.Drawing.Size(909, 27);
        txtTimKiem.TabIndex = 3;
        txtTimKiem.Text = "Tìm tên đăng nhập hoặc họ tên";
        txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
        tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 0);
        tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel3.Location = new System.Drawing.Point(3, 178);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 2;
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.21622F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.783783F));
        tableLayoutPanel3.Size = new System.Drawing.Size(1113, 169);
        tableLayoutPanel3.TabIndex = 1;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 3;
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
        tableLayoutPanel4.Controls.Add(btnKhoaMoKhoa, 2, 0);
        tableLayoutPanel4.Controls.Add(btnLuu, 1, 0);
        tableLayoutPanel4.Controls.Add(btnLamMoi, 0, 0);
        tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel4.Location = new System.Drawing.Point(3, 114);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 1;
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel4.Size = new System.Drawing.Size(1107, 52);
        tableLayoutPanel4.TabIndex = 0;
        // 
        // btnKhoaMoKhoa
        // 
        btnKhoaMoKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnKhoaMoKhoa.AutoSize = true;
        btnKhoaMoKhoa.Location = new System.Drawing.Point(843, 11);
        btnKhoaMoKhoa.Name = "btnKhoaMoKhoa";
        btnKhoaMoKhoa.Size = new System.Drawing.Size(162, 30);
        btnKhoaMoKhoa.TabIndex = 2;
        btnKhoaMoKhoa.Text = "Khóa / Mở khóa";
        btnKhoaMoKhoa.UseVisualStyleBackColor = true;
        // 
        // btnLuu
        // 
        btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnLuu.AutoSize = true;
        btnLuu.Location = new System.Drawing.Point(453, 9);
        btnLuu.Name = "btnLuu";
        btnLuu.Size = new System.Drawing.Size(200, 34);
        btnLuu.TabIndex = 1;
        btnLuu.Text = "Lưu";
        btnLuu.UseVisualStyleBackColor = true;
        // 
        // btnLamMoi
        // 
        btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnLamMoi.AutoSize = true;
        btnLamMoi.Location = new System.Drawing.Point(82, 9);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new System.Drawing.Size(200, 34);
        btnLamMoi.TabIndex = 0;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.UseVisualStyleBackColor = true;
        // 
        // tableLayoutPanel5
        // 
        tableLayoutPanel5.ColumnCount = 4;
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.751581F));
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.112917F));
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel5.Controls.Add(txtMatKhau, 2, 1);
        tableLayoutPanel5.Controls.Add(txtHoTen, 1, 1);
        tableLayoutPanel5.Controls.Add(lblVaiTro, 3, 0);
        tableLayoutPanel5.Controls.Add(lblMatKhau, 2, 0);
        tableLayoutPanel5.Controls.Add(lblHoTen, 1, 0);
        tableLayoutPanel5.Controls.Add(lblTenDangNhap, 0, 0);
        tableLayoutPanel5.Controls.Add(txtTenDangNhap, 0, 1);
        tableLayoutPanel5.Controls.Add(cboVaiTro, 3, 1);
        tableLayoutPanel5.Controls.Add(chkHienMatKhau, 2, 2);
        tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel5.Name = "tableLayoutPanel5";
        tableLayoutPanel5.RowCount = 3;
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
        tableLayoutPanel5.Size = new System.Drawing.Size(1107, 105);
        tableLayoutPanel5.TabIndex = 1;
        // 
        // txtMatKhau
        // 
        txtMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
        txtMatKhau.Location = new System.Drawing.Point(573, 39);
        txtMatKhau.Name = "txtMatKhau";
        txtMatKhau.Size = new System.Drawing.Size(234, 27);
        txtMatKhau.TabIndex = 6;
        // 
        // txtHoTen
        // 
        txtHoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
        txtHoTen.Location = new System.Drawing.Point(301, 39);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.Size = new System.Drawing.Size(224, 27);
        txtHoTen.TabIndex = 5;
        // 
        // lblVaiTro
        // 
        lblVaiTro.Anchor = System.Windows.Forms.AnchorStyles.None;
        lblVaiTro.Location = new System.Drawing.Point(918, 6);
        lblVaiTro.Name = "lblVaiTro";
        lblVaiTro.Size = new System.Drawing.Size(100, 23);
        lblVaiTro.TabIndex = 3;
        lblVaiTro.Text = "Vai trò";
        lblVaiTro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblMatKhau
        // 
        lblMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
        lblMatKhau.Location = new System.Drawing.Point(574, 6);
        lblMatKhau.Name = "lblMatKhau";
        lblMatKhau.Size = new System.Drawing.Size(232, 23);
        lblMatKhau.TabIndex = 2;
        lblMatKhau.Text = "Mật khẩu";
        // 
        // lblHoTen
        // 
        lblHoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
        lblHoTen.Location = new System.Drawing.Point(301, 6);
        lblHoTen.Name = "lblHoTen";
        lblHoTen.Size = new System.Drawing.Size(223, 23);
        lblHoTen.TabIndex = 1;
        lblHoTen.Text = "Họ và tên";
        // 
        // lblTenDangNhap
        // 
        lblTenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
        lblTenDangNhap.Location = new System.Drawing.Point(23, 6);
        lblTenDangNhap.Name = "lblTenDangNhap";
        lblTenDangNhap.Size = new System.Drawing.Size(228, 23);
        lblTenDangNhap.TabIndex = 0;
        lblTenDangNhap.Text = "Tên đăng nhập";
        // 
        // txtTenDangNhap
        // 
        txtTenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
        txtTenDangNhap.Location = new System.Drawing.Point(22, 39);
        txtTenDangNhap.Name = "txtTenDangNhap";
        txtTenDangNhap.Size = new System.Drawing.Size(229, 27);
        txtTenDangNhap.TabIndex = 4;
        // 
        // cboVaiTro
        // 
        cboVaiTro.Anchor = System.Windows.Forms.AnchorStyles.None;
        cboVaiTro.FormattingEnabled = true;
        cboVaiTro.Location = new System.Drawing.Point(862, 38);
        cboVaiTro.Name = "cboVaiTro";
        cboVaiTro.Size = new System.Drawing.Size(212, 28);
        cboVaiTro.TabIndex = 7;
        // 
        // chkHienMatKhau
        // 
        chkHienMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
        chkHienMatKhau.AutoSize = true;
        chkHienMatKhau.Location = new System.Drawing.Point(627, 75);
        chkHienMatKhau.Name = "chkHienMatKhau";
        chkHienMatKhau.Size = new System.Drawing.Size(127, 24);
        chkHienMatKhau.TabIndex = 8;
        chkHienMatKhau.Text = "Hiện mật khẩu";
        chkHienMatKhau.UseVisualStyleBackColor = true;
        // 
        // panel3
        // 
        panel3.Controls.Add(dgvTaiKhoan);
        panel3.Dock = System.Windows.Forms.DockStyle.Fill;
        panel3.Location = new System.Drawing.Point(0, 350);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(1119, 378);
        panel3.TabIndex = 2;
        // 
        // dgvTaiKhoan
        // 
        dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvTaiKhoan.Location = new System.Drawing.Point(0, 0);
        dgvTaiKhoan.Name = "dgvTaiKhoan";
        dgvTaiKhoan.RowHeadersWidth = 51;
        dgvTaiKhoan.Size = new System.Drawing.Size(1119, 378);
        dgvTaiKhoan.TabIndex = 0;
        dgvTaiKhoan.Text = "dataGridView1";
        // 
        // FormQuanLyTaiKhoan
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1119, 728);
        Controls.Add(panel3);
        Controls.Add(panel1);
        Text = "FormQuanLyTaiKhoan";
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        tableLayoutPanel3.ResumeLayout(false);
        tableLayoutPanel4.ResumeLayout(false);
        tableLayoutPanel4.PerformLayout();
        tableLayoutPanel5.ResumeLayout(false);
        tableLayoutPanel5.PerformLayout();
        panel3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.TextBox txtMatKhau;
    private System.Windows.Forms.ComboBox cboVaiTro;
    private System.Windows.Forms.CheckBox chkHienMatKhau;

    private System.Windows.Forms.TextBox txtTenDangNhap;

    private System.Windows.Forms.Label lblTenDangNhap;
    private System.Windows.Forms.Label lblHoTen;
    private System.Windows.Forms.Label lblMatKhau;
    private System.Windows.Forms.Label lblVaiTro;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;

    private System.Windows.Forms.Button btnLuu;
    private System.Windows.Forms.Button btnKhoaMoKhoa;

    private System.Windows.Forms.Button btnLamMoi;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.DataGridView dgvTaiKhoan;

    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.TextBox txtTimKiem;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Panel panel1;

    #endregion
}
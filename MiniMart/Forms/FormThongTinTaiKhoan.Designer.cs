using System.ComponentModel;

namespace MiniMart.Forms;

partial class FormThongTinTaiKhoan
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
        lblTenDangNhap = new System.Windows.Forms.Label();
        lblHoTen = new System.Windows.Forms.Label();
        lblVaiTro = new System.Windows.Forms.Label();
        txtTenDangNhap = new System.Windows.Forms.TextBox();
        txtHoTen = new System.Windows.Forms.TextBox();
        txtVaiTro = new System.Windows.Forms.TextBox();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        grpDoiMatKhau = new System.Windows.Forms.GroupBox();
        tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
        textBox3 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        lblMatKhauCu = new System.Windows.Forms.Label();
        lblMatKhauMoi = new System.Windows.Forms.Label();
        lblXacNhanMatKhau = new System.Windows.Forms.Label();
        txtMatKhauCu = new System.Windows.Forms.TextBox();
        chkHienMatKhau = new System.Windows.Forms.CheckBox();
        btnDoiMatKhau = new System.Windows.Forms.Button();
        panel2 = new System.Windows.Forms.Panel();
        btnDong = new System.Windows.Forms.Button();
        lblTieuDe = new System.Windows.Forms.Label();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        grpDoiMatKhau.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(tableLayoutPanel1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(540, 580);
        panel1.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
        tableLayoutPanel1.Controls.Add(lblTieuDe, 0, 0);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.348017F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.651985F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 330F));
        tableLayoutPanel1.Size = new System.Drawing.Size(540, 580);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.274548F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.725452F));
        tableLayoutPanel2.Controls.Add(lblTenDangNhap, 0, 0);
        tableLayoutPanel2.Controls.Add(lblHoTen, 0, 1);
        tableLayoutPanel2.Controls.Add(lblVaiTro, 0, 2);
        tableLayoutPanel2.Controls.Add(txtTenDangNhap, 1, 0);
        tableLayoutPanel2.Controls.Add(txtHoTen, 1, 1);
        tableLayoutPanel2.Controls.Add(txtVaiTro, 1, 2);
        tableLayoutPanel2.Location = new System.Drawing.Point(20, 72);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 3;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
        tableLayoutPanel2.Size = new System.Drawing.Size(499, 163);
        tableLayoutPanel2.TabIndex = 1;
        // 
        // lblTenDangNhap
        // 
        lblTenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
        lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTenDangNhap.Location = new System.Drawing.Point(3, 4);
        lblTenDangNhap.Name = "lblTenDangNhap";
        lblTenDangNhap.Size = new System.Drawing.Size(180, 40);
        lblTenDangNhap.TabIndex = 0;
        lblTenDangNhap.Text = "Tên đăng nhập";
        lblTenDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblHoTen
        // 
        lblHoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
        lblHoTen.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblHoTen.Location = new System.Drawing.Point(3, 52);
        lblHoTen.Name = "lblHoTen";
        lblHoTen.Size = new System.Drawing.Size(180, 40);
        lblHoTen.TabIndex = 1;
        lblHoTen.Text = "Họ và tên";
        lblHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblVaiTro
        // 
        lblVaiTro.Anchor = System.Windows.Forms.AnchorStyles.None;
        lblVaiTro.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblVaiTro.Location = new System.Drawing.Point(3, 109);
        lblVaiTro.Name = "lblVaiTro";
        lblVaiTro.Size = new System.Drawing.Size(180, 40);
        lblVaiTro.TabIndex = 2;
        lblVaiTro.Text = "Vai trò";
        lblVaiTro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtTenDangNhap
        // 
        txtTenDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtTenDangNhap.BackColor = System.Drawing.SystemColors.Control;
        txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtTenDangNhap.Location = new System.Drawing.Point(189, 8);
        txtTenDangNhap.Name = "txtTenDangNhap";
        txtTenDangNhap.ReadOnly = true;
        txtTenDangNhap.Size = new System.Drawing.Size(307, 31);
        txtTenDangNhap.TabIndex = 2;
        txtTenDangNhap.TabStop = false;
        // 
        // txtHoTen
        // 
        txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtHoTen.BackColor = System.Drawing.SystemColors.Control;
        txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtHoTen.Location = new System.Drawing.Point(189, 56);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.ReadOnly = true;
        txtHoTen.Size = new System.Drawing.Size(307, 31);
        txtHoTen.TabIndex = 4;
        txtHoTen.TabStop = false;
        // 
        // txtVaiTro
        // 
        txtVaiTro.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtVaiTro.BackColor = System.Drawing.SystemColors.Control;
        txtVaiTro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        txtVaiTro.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtVaiTro.Location = new System.Drawing.Point(189, 114);
        txtVaiTro.Name = "txtVaiTro";
        txtVaiTro.ReadOnly = true;
        txtVaiTro.Size = new System.Drawing.Size(307, 31);
        txtVaiTro.TabIndex = 6;
        txtVaiTro.TabStop = false;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.Controls.Add(grpDoiMatKhau, 0, 0);
        tableLayoutPanel3.Controls.Add(panel2, 0, 1);
        tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        tableLayoutPanel3.Location = new System.Drawing.Point(3, 252);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 2;
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.46154F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.538462F));
        tableLayoutPanel3.Size = new System.Drawing.Size(534, 325);
        tableLayoutPanel3.TabIndex = 2;
        // 
        // grpDoiMatKhau
        // 
        grpDoiMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
        grpDoiMatKhau.Controls.Add(tableLayoutPanel4);
        grpDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        grpDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        grpDoiMatKhau.Location = new System.Drawing.Point(18, 3);
        grpDoiMatKhau.Name = "grpDoiMatKhau";
        grpDoiMatKhau.Size = new System.Drawing.Size(498, 249);
        grpDoiMatKhau.TabIndex = 7;
        grpDoiMatKhau.TabStop = false;
        grpDoiMatKhau.Text = "Đổi mật khẩu";
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 2;
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.54032F));
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.45968F));
        tableLayoutPanel4.Controls.Add(textBox3, 1, 2);
        tableLayoutPanel4.Controls.Add(textBox2, 1, 1);
        tableLayoutPanel4.Controls.Add(lblMatKhauCu, 0, 0);
        tableLayoutPanel4.Controls.Add(lblMatKhauMoi, 0, 1);
        tableLayoutPanel4.Controls.Add(lblXacNhanMatKhau, 0, 2);
        tableLayoutPanel4.Controls.Add(txtMatKhauCu, 1, 0);
        tableLayoutPanel4.Controls.Add(chkHienMatKhau, 1, 3);
        tableLayoutPanel4.Controls.Add(btnDoiMatKhau, 1, 4);
        tableLayoutPanel4.Location = new System.Drawing.Point(2, 30);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 5;
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel4.Size = new System.Drawing.Size(496, 213);
        tableLayoutPanel4.TabIndex = 0;
        // 
        // textBox3
        // 
        textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        textBox3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        textBox3.Location = new System.Drawing.Point(214, 89);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(279, 31);
        textBox3.TabIndex = 5;
        textBox3.UseSystemPasswordChar = true;
        // 
        // textBox2
        // 
        textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        textBox2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        textBox2.Location = new System.Drawing.Point(214, 47);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(279, 31);
        textBox2.TabIndex = 3;
        textBox2.UseSystemPasswordChar = true;
        // 
        // lblMatKhauCu
        // 
        lblMatKhauCu.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblMatKhauCu.Location = new System.Drawing.Point(3, 5);
        lblMatKhauCu.Name = "lblMatKhauCu";
        lblMatKhauCu.Size = new System.Drawing.Size(205, 32);
        lblMatKhauCu.TabIndex = 0;
        lblMatKhauCu.Text = "Mật khẩu hiện tại";
        lblMatKhauCu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblMatKhauMoi
        // 
        lblMatKhauMoi.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblMatKhauMoi.Location = new System.Drawing.Point(3, 47);
        lblMatKhauMoi.Name = "lblMatKhauMoi";
        lblMatKhauMoi.Size = new System.Drawing.Size(187, 32);
        lblMatKhauMoi.TabIndex = 2;
        lblMatKhauMoi.Text = "Mật khẩu mới";
        lblMatKhauMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblXacNhanMatKhau
        // 
        lblXacNhanMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblXacNhanMatKhau.Location = new System.Drawing.Point(3, 89);
        lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
        lblXacNhanMatKhau.Size = new System.Drawing.Size(187, 32);
        lblXacNhanMatKhau.TabIndex = 1;
        lblXacNhanMatKhau.Text = "Nhập lại mật khẩu mới";
        lblXacNhanMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtMatKhauCu
        // 
        txtMatKhauCu.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtMatKhauCu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        txtMatKhauCu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtMatKhauCu.Location = new System.Drawing.Point(214, 5);
        txtMatKhauCu.Name = "txtMatKhauCu";
        txtMatKhauCu.Size = new System.Drawing.Size(279, 31);
        txtMatKhauCu.TabIndex = 1;
        txtMatKhauCu.UseSystemPasswordChar = true;
        // 
        // chkHienMatKhau
        // 
        chkHienMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        chkHienMatKhau.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        chkHienMatKhau.Location = new System.Drawing.Point(214, 131);
        chkHienMatKhau.Name = "chkHienMatKhau";
        chkHienMatKhau.Size = new System.Drawing.Size(279, 32);
        chkHienMatKhau.TabIndex = 6;
        chkHienMatKhau.Text = "Hiện mật khẩu";
        chkHienMatKhau.UseVisualStyleBackColor = true;
        // 
        // btnDoiMatKhau
        // 
        btnDoiMatKhau.BackColor = System.Drawing.Color.Green;
        btnDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
        btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
        btnDoiMatKhau.Location = new System.Drawing.Point(214, 171);
        btnDoiMatKhau.Name = "btnDoiMatKhau";
        btnDoiMatKhau.Size = new System.Drawing.Size(279, 39);
        btnDoiMatKhau.TabIndex = 7;
        btnDoiMatKhau.Text = "Đổi mật khẩu";
        btnDoiMatKhau.UseVisualStyleBackColor = false;
        // 
        // panel2
        // 
        panel2.Controls.Add(btnDong);
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(3, 258);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(528, 64);
        panel2.TabIndex = 8;
        // 
        // btnDong
        // 
        btnDong.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnDong.Location = new System.Drawing.Point(387, 16);
        btnDong.Name = "btnDong";
        btnDong.Size = new System.Drawing.Size(126, 42);
        btnDong.TabIndex = 0;
        btnDong.Text = "Đóng";
        btnDong.UseVisualStyleBackColor = true;
        // 
        // lblTieuDe
        // 
        lblTieuDe.Anchor = System.Windows.Forms.AnchorStyles.None;
        lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTieuDe.ForeColor = System.Drawing.Color.Green;
        lblTieuDe.Location = new System.Drawing.Point(20, 4);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new System.Drawing.Size(499, 49);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "THÔNG TIN TÀI KHOẢN";
        lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // FormThongTinTaiKhoan
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(540, 580);
        Controls.Add(panel1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "FormThongTinTaiKhoan";
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        tableLayoutPanel3.ResumeLayout(false);
        grpDoiMatKhau.ResumeLayout(false);
        tableLayoutPanel4.ResumeLayout(false);
        tableLayoutPanel4.PerformLayout();
        panel2.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnDoiMatKhau;

    private System.Windows.Forms.CheckBox chkHienMatKhau;

    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;

    private System.Windows.Forms.Label lblXacNhanMatKhau;
    private System.Windows.Forms.Label lblMatKhauMoi;
    private System.Windows.Forms.TextBox txtMatKhauCu;

    private System.Windows.Forms.Label lblMatKhauCu;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

    private System.Windows.Forms.Button btnDong;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.GroupBox grpDoiMatKhau;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.TextBox txtVaiTro;
    private System.Windows.Forms.TextBox txtTenDangNhap;

    private System.Windows.Forms.Label lblHoTen;
    private System.Windows.Forms.Label lblVaiTro;

    private System.Windows.Forms.Label lblTenDangNhap;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.Label lblTieuDe;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.Panel panel1;

    #endregion
}
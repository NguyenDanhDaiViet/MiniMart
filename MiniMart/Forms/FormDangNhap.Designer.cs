using System.ComponentModel;

namespace MiniMart.Forms;

partial class FormDangNhap
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
        lblTenUngDung = new System.Windows.Forms.Label();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        lblTieuDe = new System.Windows.Forms.Label();
        tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
        lblMatKhau = new System.Windows.Forms.Label();
        matKhau = new System.Windows.Forms.TextBox();
        tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
        tenDangNhap = new System.Windows.Forms.TextBox();
        lblTenDangNhap = new System.Windows.Forms.Label();
        tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
        hienMatKhau = new System.Windows.Forms.CheckBox();
        btDangNhap = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        tableLayoutPanel6.SuspendLayout();
        tableLayoutPanel5.SuspendLayout();
        tableLayoutPanel7.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(tableLayoutPanel1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(639, 537);
        panel1.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.438305F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.56169F));
        tableLayoutPanel1.Controls.Add(lblTenUngDung, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new System.Drawing.Size(639, 537);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // lblTenUngDung
        // 
        lblTenUngDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblTenUngDung.AutoSize = true;
        lblTenUngDung.BackColor = System.Drawing.Color.Navy;
        lblTenUngDung.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTenUngDung.ForeColor = System.Drawing.Color.White;
        lblTenUngDung.Location = new System.Drawing.Point(3, 0);
        lblTenUngDung.Name = "lblTenUngDung";
        lblTenUngDung.Size = new System.Drawing.Size(214, 537);
        lblTenUngDung.TabIndex = 3;
        lblTenUngDung.Text = "MiniMart";
        lblTenUngDung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
        tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
        tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 0, 2);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(223, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 3;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.696629F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.30337F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 246F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.Size = new System.Drawing.Size(413, 531);
        tableLayoutPanel2.TabIndex = 2;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.Controls.Add(lblTieuDe, 0, 0);
        tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 1;
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.Size = new System.Drawing.Size(407, 58);
        tableLayoutPanel3.TabIndex = 0;
        // 
        // lblTieuDe
        // 
        lblTieuDe.Anchor = System.Windows.Forms.AnchorStyles.None;
        lblTieuDe.AutoSize = true;
        lblTieuDe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        lblTieuDe.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTieuDe.ForeColor = System.Drawing.Color.Navy;
        lblTieuDe.Location = new System.Drawing.Point(37, 0);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new System.Drawing.Size(332, 58);
        lblTieuDe.TabIndex = 2;
        lblTieuDe.Text = "ĐĂNG NHẬP HỆ THỐNG QUẢN LÝ";
        lblTieuDe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        tableLayoutPanel4.ColumnCount = 1;
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 1);
        tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
        tableLayoutPanel4.Location = new System.Drawing.Point(3, 67);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 2;
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.Size = new System.Drawing.Size(407, 193);
        tableLayoutPanel4.TabIndex = 1;
        // 
        // tableLayoutPanel6
        // 
        tableLayoutPanel6.AutoSize = true;
        tableLayoutPanel6.ColumnCount = 1;
        tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel6.Controls.Add(lblMatKhau, 0, 0);
        tableLayoutPanel6.Controls.Add(matKhau, 0, 1);
        tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel6.Location = new System.Drawing.Point(3, 99);
        tableLayoutPanel6.Name = "tableLayoutPanel6";
        tableLayoutPanel6.RowCount = 2;
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.774193F));
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.225807F));
        tableLayoutPanel6.Size = new System.Drawing.Size(401, 91);
        tableLayoutPanel6.TabIndex = 2;
        // 
        // lblMatKhau
        // 
        lblMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
        lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblMatKhau.Location = new System.Drawing.Point(48, 0);
        lblMatKhau.Name = "lblMatKhau";
        lblMatKhau.Size = new System.Drawing.Size(304, 42);
        lblMatKhau.TabIndex = 0;
        lblMatKhau.Text = "Mật Khẩu";
        // 
        // matKhau
        // 
        matKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
        matKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        matKhau.Location = new System.Drawing.Point(51, 53);
        matKhau.Name = "matKhau";
        matKhau.PasswordChar = '*';
        matKhau.Size = new System.Drawing.Size(298, 27);
        matKhau.TabIndex = 1;
        // 
        // tableLayoutPanel5
        // 
        tableLayoutPanel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        tableLayoutPanel5.ColumnCount = 1;
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel5.Controls.Add(tenDangNhap, 0, 1);
        tableLayoutPanel5.Controls.Add(lblTenDangNhap, 0, 0);
        tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel5.Name = "tableLayoutPanel5";
        tableLayoutPanel5.RowCount = 2;
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.827587F));
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.172413F));
        tableLayoutPanel5.Size = new System.Drawing.Size(401, 90);
        tableLayoutPanel5.TabIndex = 0;
        // 
        // tenDangNhap
        // 
        tenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
        tenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        tenDangNhap.Location = new System.Drawing.Point(51, 51);
        tenDangNhap.Name = "tenDangNhap";
        tenDangNhap.Size = new System.Drawing.Size(298, 27);
        tenDangNhap.TabIndex = 0;
        // 
        // lblTenDangNhap
        // 
        lblTenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
        lblTenDangNhap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTenDangNhap.Location = new System.Drawing.Point(51, 5);
        lblTenDangNhap.Name = "lblTenDangNhap";
        lblTenDangNhap.Size = new System.Drawing.Size(299, 30);
        lblTenDangNhap.TabIndex = 1;
        lblTenDangNhap.Text = "Tên Đăng Nhập";
        // 
        // tableLayoutPanel7
        // 
        tableLayoutPanel7.ColumnCount = 1;
        tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel7.Controls.Add(hienMatKhau, 0, 0);
        tableLayoutPanel7.Controls.Add(btDangNhap, 0, 1);
        tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel7.Location = new System.Drawing.Point(3, 287);
        tableLayoutPanel7.Name = "tableLayoutPanel7";
        tableLayoutPanel7.RowCount = 2;
        tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.651453F));
        tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.34855F));
        tableLayoutPanel7.Size = new System.Drawing.Size(407, 241);
        tableLayoutPanel7.TabIndex = 2;
        // 
        // hienMatKhau
        // 
        hienMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
        hienMatKhau.Location = new System.Drawing.Point(54, 18);
        hienMatKhau.Name = "hienMatKhau";
        hienMatKhau.Size = new System.Drawing.Size(298, 21);
        hienMatKhau.TabIndex = 0;
        hienMatKhau.Text = "Hiện thị mật khẩu";
        hienMatKhau.UseVisualStyleBackColor = true;
        // 
        // btDangNhap
        // 
        btDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
        btDangNhap.BackColor = System.Drawing.Color.Navy;
        btDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btDangNhap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btDangNhap.ForeColor = System.Drawing.Color.White;
        btDangNhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
        btDangNhap.Location = new System.Drawing.Point(67, 60);
        btDangNhap.Name = "btDangNhap";
        btDangNhap.Size = new System.Drawing.Size(272, 41);
        btDangNhap.TabIndex = 1;
        btDangNhap.Text = "Đăng Nhập";
        btDangNhap.UseVisualStyleBackColor = false;
        // 
        // FormDangNhap
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(639, 537);
        Controls.Add(panel1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "FormDangNhap";
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        tableLayoutPanel3.PerformLayout();
        tableLayoutPanel4.ResumeLayout(false);
        tableLayoutPanel4.PerformLayout();
        tableLayoutPanel6.ResumeLayout(false);
        tableLayoutPanel6.PerformLayout();
        tableLayoutPanel5.ResumeLayout(false);
        tableLayoutPanel5.PerformLayout();
        tableLayoutPanel7.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Label lblTenUngDung;
    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    private System.Windows.Forms.TextBox tenDangNhap;
    private System.Windows.Forms.Label lblTenDangNhap;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    private System.Windows.Forms.TextBox matKhau;
    private System.Windows.Forms.Label lblMatKhau;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    private System.Windows.Forms.CheckBox hienMatKhau;
    private System.Windows.Forms.Button btDangNhap;

    private System.Windows.Forms.CheckBox checkBox1;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.Panel panel1;

    #endregion
}
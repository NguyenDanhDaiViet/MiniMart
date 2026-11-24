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
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.02935F));
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.97065F));
        tableLayoutPanel4.Controls.Add(grpThongTinPhieuNhap, 1, 0);
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
        grpThongTinPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        grpThongTinPhieuNhap.Controls.Add(tableLayoutPanel5);
        grpThongTinPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        grpThongTinPhieuNhap.Location = new System.Drawing.Point(652, 3);
        grpThongTinPhieuNhap.Name = "grpThongTinPhieuNhap";
        grpThongTinPhieuNhap.Size = new System.Drawing.Size(299, 335);
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
        tableLayoutPanel5.Controls.Add(btnXacNhan, 0, 4);
        tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel5.Location = new System.Drawing.Point(3, 26);
        tableLayoutPanel5.Name = "tableLayoutPanel5";
        tableLayoutPanel5.RowCount = 5;
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.614037F));
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.385963F));
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
        tableLayoutPanel5.Size = new System.Drawing.Size(293, 306);
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
        tableLayoutPanel6.Size = new System.Drawing.Size(287, 80);
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
        lblTenSanPham.Size = new System.Drawing.Size(100, 23);
        lblTenSanPham.TabIndex = 1;
        lblTenSanPham.Text = "Chưa Chọn";
        lblTenSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
        tableLayoutPanel7.Size = new System.Drawing.Size(287, 97);
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
        txtMaSanPham.Location = new System.Drawing.Point(3, 51);
        txtMaSanPham.Name = "txtMaSanPham";
        txtMaSanPham.Size = new System.Drawing.Size(137, 30);
        txtMaSanPham.TabIndex = 2;
        // 
        // nudSoLuong
        // 
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
        nudGiaNhap.Location = new System.Drawing.Point(3, 215);
        nudGiaNhap.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        nudGiaNhap.Name = "nudGiaNhap";
        nudGiaNhap.Size = new System.Drawing.Size(271, 30);
        nudGiaNhap.TabIndex = 3;
        // 
        // btnXacNhan
        // 
        btnXacNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnXacNhan.BackColor = System.Drawing.Color.Navy;
        btnXacNhan.ForeColor = System.Drawing.Color.White;
        btnXacNhan.Location = new System.Drawing.Point(99, 267);
        btnXacNhan.Name = "btnXacNhan";
        btnXacNhan.Size = new System.Drawing.Size(94, 34);
        btnXacNhan.TabIndex = 4;
        btnXacNhan.Text = "Xác Nhận";
        btnXacNhan.UseVisualStyleBackColor = false;
        // 
        // dgvSanPham
        // 
        dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvSanPham.Location = new System.Drawing.Point(3, 3);
        dgvSanPham.Name = "dgvSanPham";
        dgvSanPham.RowHeadersWidth = 51;
        dgvSanPham.Size = new System.Drawing.Size(643, 505);
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

    #endregion
    
}
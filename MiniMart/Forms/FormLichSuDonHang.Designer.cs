using System.ComponentModel;

namespace MiniMart.Forms;

partial class FormLichSuDonHang
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
        lblTieuDe = new System.Windows.Forms.Label();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
        lblTimKiem = new System.Windows.Forms.Label();
        lblTuNgay = new System.Windows.Forms.Label();
        lblDenNgay = new System.Windows.Forms.Label();
        txtTimKiem = new System.Windows.Forms.TextBox();
        dtpTuNgay = new System.Windows.Forms.DateTimePicker();
        btnTimKiem = new System.Windows.Forms.Button();
        dtpDenNgay = new System.Windows.Forms.DateTimePicker();
        lblTongKet = new System.Windows.Forms.Label();
        dgvDonHang = new System.Windows.Forms.DataGridView();
        tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
        dgvChiTiet = new System.Windows.Forms.DataGridView();
        lblChiTiet = new System.Windows.Forms.Label();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDonHang).BeginInit();
        tableLayoutPanel5.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(tableLayoutPanel1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(980, 661);
        panel1.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(lblTieuDe, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 2);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
        tableLayoutPanel1.Size = new System.Drawing.Size(980, 661);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // lblTieuDe
        // 
        lblTieuDe.BackColor = System.Drawing.Color.White;
        lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 19.800001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTieuDe.ForeColor = System.Drawing.Color.Navy;
        lblTieuDe.Location = new System.Drawing.Point(3, 0);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new System.Drawing.Size(974, 66);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "LỊCH SỬ ĐƠN HÀNG";
        lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
        tableLayoutPanel2.Controls.Add(dgvDonHang, 0, 1);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(3, 69);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.037037F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.962963F));
        tableLayoutPanel2.Size = new System.Drawing.Size(974, 324);
        tableLayoutPanel2.TabIndex = 1;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
        tableLayoutPanel3.Controls.Add(lblTongKet, 0, 1);
        tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 2;
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.42056F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.57944F));
        tableLayoutPanel3.Size = new System.Drawing.Size(968, 114);
        tableLayoutPanel3.TabIndex = 0;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 4;
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel4.Controls.Add(lblTimKiem, 2, 0);
        tableLayoutPanel4.Controls.Add(lblTuNgay, 0, 0);
        tableLayoutPanel4.Controls.Add(lblDenNgay, 1, 0);
        tableLayoutPanel4.Controls.Add(txtTimKiem, 2, 1);
        tableLayoutPanel4.Controls.Add(dtpTuNgay, 0, 1);
        tableLayoutPanel4.Controls.Add(btnTimKiem, 3, 1);
        tableLayoutPanel4.Controls.Add(dtpDenNgay, 1, 1);
        tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 2;
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.0625F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.9375F));
        tableLayoutPanel4.Size = new System.Drawing.Size(962, 68);
        tableLayoutPanel4.TabIndex = 1;
        // 
        // lblTimKiem
        // 
        lblTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTimKiem.Location = new System.Drawing.Point(387, 1);
        lblTimKiem.Name = "lblTimKiem";
        lblTimKiem.Size = new System.Drawing.Size(378, 25);
        lblTimKiem.TabIndex = 3;
        lblTimKiem.Text = "Tìm kiếm:";
        // 
        // lblTuNgay
        // 
        lblTuNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left));
        lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTuNgay.Location = new System.Drawing.Point(3, 0);
        lblTuNgay.Name = "lblTuNgay";
        lblTuNgay.Size = new System.Drawing.Size(186, 26);
        lblTuNgay.TabIndex = 1;
        lblTuNgay.Text = "Từ ngày:";
        // 
        // lblDenNgay
        // 
        lblDenNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblDenNgay.Location = new System.Drawing.Point(195, 1);
        lblDenNgay.Name = "lblDenNgay";
        lblDenNgay.Size = new System.Drawing.Size(186, 25);
        lblDenNgay.TabIndex = 2;
        lblDenNgay.Text = "Đến ngày:";
        // 
        // txtTimKiem
        // 
        txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
        txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtTimKiem.Location = new System.Drawing.Point(387, 35);
        txtTimKiem.Name = "txtTimKiem";
        txtTimKiem.PlaceholderText = "Mã đơn, tên khách hoặc số điện thoại";
        txtTimKiem.Size = new System.Drawing.Size(378, 23);
        txtTimKiem.TabIndex = 5;
        // 
        // dtpTuNgay
        // 
        dtpTuNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        dtpTuNgay.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpTuNgay.Location = new System.Drawing.Point(3, 32);
        dtpTuNgay.Name = "dtpTuNgay";
        dtpTuNgay.Size = new System.Drawing.Size(186, 30);
        dtpTuNgay.TabIndex = 6;
        // 
        // btnTimKiem
        // 
        btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnTimKiem.BackColor = System.Drawing.Color.Navy;
        btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTimKiem.ForeColor = System.Drawing.Color.White;
        btnTimKiem.Location = new System.Drawing.Point(787, 31);
        btnTimKiem.Name = "btnTimKiem";
        btnTimKiem.Size = new System.Drawing.Size(155, 32);
        btnTimKiem.TabIndex = 6;
        btnTimKiem.Text = "Tìm kiếm";
        btnTimKiem.UseVisualStyleBackColor = false;
        // 
        // dtpDenNgay
        // 
        dtpDenNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpDenNgay.Location = new System.Drawing.Point(195, 32);
        dtpDenNgay.Name = "dtpDenNgay";
        dtpDenNgay.Size = new System.Drawing.Size(186, 30);
        dtpDenNgay.TabIndex = 6;
        // 
        // lblTongKet
        // 
        lblTongKet.Anchor = System.Windows.Forms.AnchorStyles.Left;
        lblTongKet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        lblTongKet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTongKet.ForeColor = System.Drawing.Color.Navy;
        lblTongKet.Location = new System.Drawing.Point(3, 75);
        lblTongKet.Name = "lblTongKet";
        lblTongKet.Size = new System.Drawing.Size(615, 37);
        lblTongKet.TabIndex = 0;
        lblTongKet.Text = "Số đơn: 0 - Tổng tiền: 0 đ";
        lblTongKet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // dgvDonHang
        // 
        dgvDonHang.AllowUserToAddRows = false;
        dgvDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvDonHang.BackgroundColor = System.Drawing.Color.White;
        dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvDonHang.Location = new System.Drawing.Point(3, 123);
        dgvDonHang.Name = "dgvDonHang";
        dgvDonHang.RowHeadersWidth = 51;
        dgvDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvDonHang.Size = new System.Drawing.Size(968, 198);
        dgvDonHang.TabIndex = 1;
        dgvDonHang.Text = "dataGridView1";
        // 
        // tableLayoutPanel5
        // 
        tableLayoutPanel5.ColumnCount = 1;
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel5.Controls.Add(dgvChiTiet, 0, 1);
        tableLayoutPanel5.Controls.Add(lblChiTiet, 0, 0);
        tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel5.Location = new System.Drawing.Point(3, 399);
        tableLayoutPanel5.Name = "tableLayoutPanel5";
        tableLayoutPanel5.RowCount = 2;
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.285714F));
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.71429F));
        tableLayoutPanel5.Size = new System.Drawing.Size(974, 259);
        tableLayoutPanel5.TabIndex = 2;
        // 
        // dgvChiTiet
        // 
        dgvChiTiet.AllowUserToAddRows = false;
        dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
        dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvChiTiet.Location = new System.Drawing.Point(3, 40);
        dgvChiTiet.Name = "dgvChiTiet";
        dgvChiTiet.RowHeadersWidth = 51;
        dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvChiTiet.Size = new System.Drawing.Size(968, 216);
        dgvChiTiet.TabIndex = 2;
        dgvChiTiet.Text = "dataGridView1";
        // 
        // lblChiTiet
        // 
        lblChiTiet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblChiTiet.ForeColor = System.Drawing.Color.Navy;
        lblChiTiet.Location = new System.Drawing.Point(3, 0);
        lblChiTiet.Name = "lblChiTiet";
        lblChiTiet.Size = new System.Drawing.Size(968, 37);
        lblChiTiet.TabIndex = 1;
        lblChiTiet.Text = "CHI TIẾT ĐƠN HÀNG\r\n";
        lblChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // FormLichSuDonHang
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(980, 661);
        Controls.Add(panel1);
        Text = "FormLichSuDonHang";
        WindowState = System.Windows.Forms.FormWindowState.Maximized;
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        tableLayoutPanel4.ResumeLayout(false);
        tableLayoutPanel4.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDonHang).EndInit();
        tableLayoutPanel5.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dgvChiTiet;

    private System.Windows.Forms.Label lblChiTiet;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;

    private System.Windows.Forms.DataGridView dgvDonHang;

    private System.Windows.Forms.Button btnTimKiem;

    private System.Windows.Forms.DateTimePicker dtpDenNgay;
    private System.Windows.Forms.DateTimePicker dtpTuNgay;

    private System.Windows.Forms.Label lblDenNgay;
    private System.Windows.Forms.TextBox txtTimKiem;

    private System.Windows.Forms.Label lblTuNgay;

    private System.Windows.Forms.Label lblTimKiem;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

    private System.Windows.Forms.Label lblTongKet;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.Label lblTieuDe;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.Panel panel1;

    #endregion
}
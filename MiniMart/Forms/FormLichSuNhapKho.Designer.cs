using System.ComponentModel;

namespace MiniMart.Forms;

public partial class FormLichSuNhapKho
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
        pnlTieuDe = new System.Windows.Forms.Panel();
        lblTieuDe = new System.Windows.Forms.Label();
        pnlLoc = new System.Windows.Forms.Panel();
        lblTuNgay = new System.Windows.Forms.Label();
        dtpTuNgay = new System.Windows.Forms.DateTimePicker();
        lblDenNgay = new System.Windows.Forms.Label();
        dtpDenNgay = new System.Windows.Forms.DateTimePicker();
        lblTimKiem = new System.Windows.Forms.Label();
        txtTimKiem = new System.Windows.Forms.TextBox();
        btnTimKiem = new System.Windows.Forms.Button();
        lblTongKet = new System.Windows.Forms.Label();
        dgvPhieuNhap = new System.Windows.Forms.DataGridView();
        pnlChiTiet = new System.Windows.Forms.Panel();
        lblChiTiet = new System.Windows.Forms.Label();
        pnlThongTinNhaCungCap = new System.Windows.Forms.Panel();
        txtThongTinNhaCungCap = new System.Windows.Forms.TextBox();
        dgvChiTiet = new System.Windows.Forms.DataGridView();
        pnlTieuDe.SuspendLayout();
        pnlLoc.SuspendLayout();
        pnlChiTiet.SuspendLayout();
        pnlThongTinNhaCungCap.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
        SuspendLayout();
        // 
        // pnlTieuDe
        // 
        pnlTieuDe.BackColor = System.Drawing.Color.White;
        pnlTieuDe.Controls.Add(lblTieuDe);
        pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
        pnlTieuDe.Location = new System.Drawing.Point(0, 0);
        pnlTieuDe.Name = "pnlTieuDe";
        pnlTieuDe.Size = new System.Drawing.Size(1100, 70);
        pnlTieuDe.TabIndex = 0;
        // 
        // lblTieuDe
        // 
        lblTieuDe.AutoSize = true;
        lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTieuDe.ForeColor = System.Drawing.Color.Navy;
        lblTieuDe.Location = new System.Drawing.Point(20, 10);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new System.Drawing.Size(363, 54);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "LỊCH SỬ NHẬP KHO";
        // 
        // pnlLoc
        // 
        pnlLoc.Controls.Add(lblTuNgay);
        pnlLoc.Controls.Add(dtpTuNgay);
        pnlLoc.Controls.Add(lblDenNgay);
        pnlLoc.Controls.Add(dtpDenNgay);
        pnlLoc.Controls.Add(lblTimKiem);
        pnlLoc.Controls.Add(txtTimKiem);
        pnlLoc.Controls.Add(btnTimKiem);
        pnlLoc.Controls.Add(lblTongKet);
        pnlLoc.Dock = System.Windows.Forms.DockStyle.Top;
        pnlLoc.Location = new System.Drawing.Point(0, 70);
        pnlLoc.Name = "pnlLoc";
        pnlLoc.Size = new System.Drawing.Size(1100, 140);
        pnlLoc.TabIndex = 1;
        // 
        // lblTuNgay
        // 
        lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTuNgay.Location = new System.Drawing.Point(20, 10);
        lblTuNgay.Name = "lblTuNgay";
        lblTuNgay.Size = new System.Drawing.Size(150, 36);
        lblTuNgay.TabIndex = 0;
        lblTuNgay.Text = "Từ ngày:";
        // 
        // dtpTuNgay
        // 
        dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpTuNgay.Location = new System.Drawing.Point(20, 43);
        dtpTuNgay.Name = "dtpTuNgay";
        dtpTuNgay.Size = new System.Drawing.Size(170, 34);
        dtpTuNgay.TabIndex = 1;
        // 
        // lblDenNgay
        // 
        lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblDenNgay.Location = new System.Drawing.Point(215, 10);
        lblDenNgay.Name = "lblDenNgay";
        lblDenNgay.Size = new System.Drawing.Size(150, 36);
        lblDenNgay.TabIndex = 2;
        lblDenNgay.Text = "Đến ngày:";
        // 
        // dtpDenNgay
        // 
        dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpDenNgay.Location = new System.Drawing.Point(215, 43);
        dtpDenNgay.Name = "dtpDenNgay";
        dtpDenNgay.Size = new System.Drawing.Size(170, 34);
        dtpDenNgay.TabIndex = 3;
        // 
        // lblTimKiem
        // 
        lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTimKiem.Location = new System.Drawing.Point(410, 10);
        lblTimKiem.Name = "lblTimKiem";
        lblTimKiem.Size = new System.Drawing.Size(150, 36);
        lblTimKiem.TabIndex = 4;
        lblTimKiem.Text = "Tìm kiếm:";
        // 
        // txtTimKiem
        // 
        txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtTimKiem.Location = new System.Drawing.Point(410, 43);
        txtTimKiem.Name = "txtTimKiem";
        txtTimKiem.PlaceholderText = "Mã phiếu, nhà cung cấp, SĐT hoặc sản phẩm";
        txtTimKiem.Size = new System.Drawing.Size(460, 34);
        txtTimKiem.TabIndex = 5;
        // 
        // btnTimKiem
        // 
        btnTimKiem.BackColor = System.Drawing.Color.Navy;
        btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTimKiem.ForeColor = System.Drawing.Color.White;
        btnTimKiem.Location = new System.Drawing.Point(890, 41);
        btnTimKiem.Name = "btnTimKiem";
        btnTimKiem.Size = new System.Drawing.Size(150, 38);
        btnTimKiem.TabIndex = 6;
        btnTimKiem.Text = "Tìm kiếm";
        btnTimKiem.UseVisualStyleBackColor = false;
        // 
        // lblTongKet
        // 
        lblTongKet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTongKet.ForeColor = System.Drawing.Color.Navy;
        lblTongKet.Location = new System.Drawing.Point(20, 96);
        lblTongKet.Name = "lblTongKet";
        lblTongKet.Size = new System.Drawing.Size(960, 36);
        lblTongKet.TabIndex = 7;
        lblTongKet.Text = "Số phiếu: 0 - Tổng tiền nhập: 0 đ";
        lblTongKet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // dgvPhieuNhap
        // 
        dgvPhieuNhap.AllowUserToAddRows = false;
        dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvPhieuNhap.BackgroundColor = System.Drawing.Color.White;
        dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvPhieuNhap.Location = new System.Drawing.Point(0, 195);
        dgvPhieuNhap.Name = "dgvPhieuNhap";
        dgvPhieuNhap.ReadOnly = true;
        dgvPhieuNhap.RowHeadersWidth = 62;
        dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvPhieuNhap.Size = new System.Drawing.Size(1100, 225);
        dgvPhieuNhap.TabIndex = 2;
        // 
        // pnlChiTiet
        // 
        pnlChiTiet.Controls.Add(dgvChiTiet);
        pnlChiTiet.Controls.Add(pnlThongTinNhaCungCap);
        pnlChiTiet.Controls.Add(lblChiTiet);
        pnlChiTiet.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlChiTiet.Location = new System.Drawing.Point(0, 400);
        pnlChiTiet.Name = "pnlChiTiet";
        pnlChiTiet.Size = new System.Drawing.Size(1100, 300);
        pnlChiTiet.TabIndex = 3;
        // 
        // lblChiTiet
        // 
        lblChiTiet.Dock = System.Windows.Forms.DockStyle.Top;
        lblChiTiet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblChiTiet.ForeColor = System.Drawing.Color.Navy;
        lblChiTiet.Location = new System.Drawing.Point(0, 0);
        lblChiTiet.Name = "lblChiTiet";
        lblChiTiet.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
        lblChiTiet.Size = new System.Drawing.Size(1100, 40);
        lblChiTiet.TabIndex = 0;
        lblChiTiet.Text = "CHI TIẾT PHIẾU NHẬP";
        lblChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // pnlThongTinNhaCungCap
        // 
        pnlThongTinNhaCungCap.Controls.Add(txtThongTinNhaCungCap);
        pnlThongTinNhaCungCap.Dock = System.Windows.Forms.DockStyle.Top;
        pnlThongTinNhaCungCap.Location = new System.Drawing.Point(0, 40);
        pnlThongTinNhaCungCap.Name = "pnlThongTinNhaCungCap";
        pnlThongTinNhaCungCap.Padding = new System.Windows.Forms.Padding(20, 0, 20, 4);
        pnlThongTinNhaCungCap.Size = new System.Drawing.Size(1100, 100);
        pnlThongTinNhaCungCap.TabIndex = 2;
        // 
        // txtThongTinNhaCungCap
        // 
        txtThongTinNhaCungCap.BackColor = System.Drawing.Color.WhiteSmoke;
        txtThongTinNhaCungCap.BorderStyle = System.Windows.Forms.BorderStyle.None;
        txtThongTinNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
        txtThongTinNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtThongTinNhaCungCap.Location = new System.Drawing.Point(20, 0);
        txtThongTinNhaCungCap.Multiline = true;
        txtThongTinNhaCungCap.Name = "txtThongTinNhaCungCap";
        txtThongTinNhaCungCap.ReadOnly = true;
        txtThongTinNhaCungCap.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtThongTinNhaCungCap.Size = new System.Drawing.Size(1060, 96);
        txtThongTinNhaCungCap.TabIndex = 0;
        txtThongTinNhaCungCap.TabStop = false;
        // 
        // dgvChiTiet
        // 
        dgvChiTiet.AllowUserToAddRows = false;
        dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
        dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvChiTiet.Location = new System.Drawing.Point(0, 140);
        dgvChiTiet.Name = "dgvChiTiet";
        dgvChiTiet.ReadOnly = true;
        dgvChiTiet.RowHeadersWidth = 62;
        dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvChiTiet.Size = new System.Drawing.Size(1100, 160);
        dgvChiTiet.TabIndex = 1;
        // 
        // FormLichSuNhapKho
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.WhiteSmoke;
        ClientSize = new System.Drawing.Size(1100, 700);
        Controls.Add(dgvPhieuNhap);
        Controls.Add(pnlChiTiet);
        Controls.Add(pnlLoc);
        Controls.Add(pnlTieuDe);
        Name = "FormLichSuNhapKho";
        Text = "MiniMart - Lịch sử nhập kho";
        pnlTieuDe.ResumeLayout(false);
        pnlTieuDe.PerformLayout();
        pnlLoc.ResumeLayout(false);
        pnlLoc.PerformLayout();
        pnlChiTiet.ResumeLayout(false);
        pnlThongTinNhaCungCap.ResumeLayout(false);
        pnlThongTinNhaCungCap.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlTieuDe;
    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.Panel pnlLoc;
    private System.Windows.Forms.Label lblTuNgay;
    private System.Windows.Forms.DateTimePicker dtpTuNgay;
    private System.Windows.Forms.Label lblDenNgay;
    private System.Windows.Forms.DateTimePicker dtpDenNgay;
    private System.Windows.Forms.Label lblTimKiem;
    private System.Windows.Forms.TextBox txtTimKiem;
    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.Label lblTongKet;
    private System.Windows.Forms.DataGridView dgvPhieuNhap;
    private System.Windows.Forms.Panel pnlChiTiet;
    private System.Windows.Forms.Label lblChiTiet;
    private System.Windows.Forms.Panel pnlThongTinNhaCungCap;
    private System.Windows.Forms.TextBox txtThongTinNhaCungCap;
    private System.Windows.Forms.DataGridView dgvChiTiet;

    #endregion
}

using System.ComponentModel;

namespace MiniMart.Forms;

partial class FormLichSuHoatDong
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
        tlpLoc = new System.Windows.Forms.TableLayoutPanel();
        lblTuNgay = new System.Windows.Forms.Label();
        lblDenNgay = new System.Windows.Forms.Label();
        lblTuKhoa = new System.Windows.Forms.Label();
        dtpTuNgay = new System.Windows.Forms.DateTimePicker();
        dtpDenNgay = new System.Windows.Forms.DateTimePicker();
        txtTuKhoa = new System.Windows.Forms.TextBox();
        btnLoc = new System.Windows.Forms.Button();
        lblTongKet = new System.Windows.Forms.Label();
        dgvLichSu = new System.Windows.Forms.DataGridView();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tlpLoc.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvLichSu).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(tableLayoutPanel1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(1000, 660);
        panel1.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(lblTieuDe, 0, 0);
        tableLayoutPanel1.Controls.Add(tlpLoc, 0, 1);
        tableLayoutPanel1.Controls.Add(lblTongKet, 0, 2);
        tableLayoutPanel1.Controls.Add(dgvLichSu, 0, 3);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.Size = new System.Drawing.Size(968, 100);
        tableLayoutPanel1.TabIndex = 0;
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        // 
        // lblTieuDe
        // 
        lblTieuDe.BackColor = System.Drawing.Color.White;
        lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTieuDe.ForeColor = System.Drawing.Color.Navy;
        lblTieuDe.Location = new System.Drawing.Point(3, 0);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new System.Drawing.Size(974, 60);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "NHẬT KÝ HOẠT ĐỘNG";
        lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tlpLoc
        // 
        tlpLoc.ColumnCount = 4;
        tlpLoc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tlpLoc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tlpLoc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
        tlpLoc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tlpLoc.Controls.Add(lblTuNgay, 0, 0);
        tlpLoc.Controls.Add(lblDenNgay, 1, 0);
        tlpLoc.Controls.Add(lblTuKhoa, 2, 0);
        tlpLoc.Controls.Add(dtpTuNgay, 0, 1);
        tlpLoc.Controls.Add(dtpDenNgay, 1, 1);
        tlpLoc.Controls.Add(txtTuKhoa, 2, 1);
        tlpLoc.Controls.Add(btnLoc, 3, 1);
        tlpLoc.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpLoc.Location = new System.Drawing.Point(3, 3);
        tlpLoc.Name = "tlpLoc";
        tlpLoc.Size = new System.Drawing.Size(968, 100);
        tlpLoc.TabIndex = 1;
        tlpLoc.RowCount = 2;
        tlpLoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
        tlpLoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        // 
        // lblTuNgay
        // 
        lblTuNgay.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTuNgay.Location = new System.Drawing.Point(3, 0);
        lblTuNgay.Name = "lblTuNgay";
        lblTuNgay.Size = new System.Drawing.Size(180, 26);
        lblTuNgay.TabIndex = 0;
        lblTuNgay.Text = "Từ ngày:";
        lblTuNgay.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // lblDenNgay
        // 
        lblDenNgay.Dock = System.Windows.Forms.DockStyle.Fill;
        lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblDenNgay.Location = new System.Drawing.Point(3, 0);
        lblDenNgay.Name = "lblDenNgay";
        lblDenNgay.Size = new System.Drawing.Size(180, 26);
        lblDenNgay.TabIndex = 1;
        lblDenNgay.Text = "Đến ngày:";
        lblDenNgay.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // lblTuKhoa
        // 
        lblTuKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTuKhoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTuKhoa.Location = new System.Drawing.Point(3, 0);
        lblTuKhoa.Name = "lblTuKhoa";
        lblTuKhoa.Size = new System.Drawing.Size(180, 26);
        lblTuKhoa.TabIndex = 2;
        lblTuKhoa.Text = "Từ khóa:";
        lblTuKhoa.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // dtpTuNgay
        // 
        dtpTuNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpTuNgay.Location = new System.Drawing.Point(3, 3);
        dtpTuNgay.Name = "dtpTuNgay";
        dtpTuNgay.Size = new System.Drawing.Size(180, 30);
        dtpTuNgay.TabIndex = 3;
        // 
        // dtpDenNgay
        // 
        dtpDenNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpDenNgay.Location = new System.Drawing.Point(3, 3);
        dtpDenNgay.Name = "dtpDenNgay";
        dtpDenNgay.Size = new System.Drawing.Size(180, 30);
        dtpDenNgay.TabIndex = 4;
        // 
        // txtTuKhoa
        // 
        txtTuKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtTuKhoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtTuKhoa.Location = new System.Drawing.Point(3, 3);
        txtTuKhoa.MaxLength = 100;
        txtTuKhoa.Name = "txtTuKhoa";
        txtTuKhoa.PlaceholderText = "Tên đăng nhập, thao tác, nội dung...";
        txtTuKhoa.Size = new System.Drawing.Size(180, 30);
        txtTuKhoa.TabIndex = 5;
        // 
        // btnLoc
        // 
        btnLoc.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnLoc.BackColor = System.Drawing.Color.Navy;
        btnLoc.Cursor = System.Windows.Forms.Cursors.Hand;
        btnLoc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnLoc.ForeColor = System.Drawing.Color.White;
        btnLoc.Location = new System.Drawing.Point(3, 3);
        btnLoc.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
        btnLoc.Name = "btnLoc";
        btnLoc.Size = new System.Drawing.Size(155, 38);
        btnLoc.TabIndex = 6;
        btnLoc.Text = "Lọc dữ liệu";
        btnLoc.UseVisualStyleBackColor = false;
        // 
        // lblTongKet
        // 
        lblTongKet.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTongKet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTongKet.ForeColor = System.Drawing.Color.Navy;
        lblTongKet.Location = new System.Drawing.Point(3, 130);
        lblTongKet.Name = "lblTongKet";
        lblTongKet.Size = new System.Drawing.Size(974, 34);
        lblTongKet.TabIndex = 2;
        lblTongKet.Text = "Số thao tác: 0";
        lblTongKet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // dgvLichSu
        // 
        dgvLichSu.AllowUserToAddRows = false;
        dgvLichSu.AllowUserToDeleteRows = false;
        dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvLichSu.BackgroundColor = System.Drawing.Color.White;
        dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvLichSu.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvLichSu.Location = new System.Drawing.Point(3, 3);
        dgvLichSu.MultiSelect = false;
        dgvLichSu.Name = "dgvLichSu";
        dgvLichSu.ReadOnly = true;
        dgvLichSu.RowHeadersWidth = 51;
        dgvLichSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvLichSu.Size = new System.Drawing.Size(968, 300);
        dgvLichSu.TabIndex = 3;
        // 
        // FormLichSuHoatDong
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1000, 660);
        Controls.Add(panel1);
        Text = "Lịch sử hoạt động";
        WindowState = System.Windows.Forms.FormWindowState.Maximized;
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        tlpLoc.ResumeLayout(false);
        tlpLoc.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvLichSu).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.TableLayoutPanel tlpLoc;
    private System.Windows.Forms.Label lblTuNgay;
    private System.Windows.Forms.Label lblDenNgay;
    private System.Windows.Forms.Label lblTuKhoa;
    private System.Windows.Forms.DateTimePicker dtpTuNgay;
    private System.Windows.Forms.DateTimePicker dtpDenNgay;
    private System.Windows.Forms.TextBox txtTuKhoa;
    private System.Windows.Forms.Button btnLoc;
    private System.Windows.Forms.Label lblTongKet;
    private System.Windows.Forms.DataGridView dgvLichSu;

    #endregion
}

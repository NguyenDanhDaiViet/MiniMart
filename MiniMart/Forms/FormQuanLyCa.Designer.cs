using System.ComponentModel;

namespace MiniMart.Forms;

partial class FormQuanLyCa
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
        lblTrangThai = new System.Windows.Forms.Label();
        grpCa = new System.Windows.Forms.GroupBox();
        tlpCa = new System.Windows.Forms.TableLayoutPanel();
        lblTienDauCa = new System.Windows.Forms.Label();
        lblTienCuoiCa = new System.Windows.Forms.Label();
        lblGhiChu = new System.Windows.Forms.Label();
        nudTienDauCa = new System.Windows.Forms.NumericUpDown();
        btnMoCa = new System.Windows.Forms.Button();
        nudTienCuoiCa = new System.Windows.Forms.NumericUpDown();
        txtGhiChu = new System.Windows.Forms.TextBox();
        btnDongCa = new System.Windows.Forms.Button();
        tlpLoc = new System.Windows.Forms.TableLayoutPanel();
        lblTuNgay = new System.Windows.Forms.Label();
        lblDenNgay = new System.Windows.Forms.Label();
        dtpTuNgay = new System.Windows.Forms.DateTimePicker();
        dtpDenNgay = new System.Windows.Forms.DateTimePicker();
        btnTaiLichSu = new System.Windows.Forms.Button();
        dgvCaLamViec = new System.Windows.Forms.DataGridView();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        grpCa.SuspendLayout();
        tlpCa.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudTienDauCa).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudTienCuoiCa).BeginInit();
        tlpLoc.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCaLamViec).BeginInit();
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
        tableLayoutPanel1.Controls.Add(lblTrangThai, 0, 1);
        tableLayoutPanel1.Controls.Add(grpCa, 0, 2);
        tableLayoutPanel1.Controls.Add(tlpLoc, 0, 3);
        tableLayoutPanel1.Controls.Add(dgvCaLamViec, 0, 4);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.Size = new System.Drawing.Size(968, 100);
        tableLayoutPanel1.TabIndex = 0;
        tableLayoutPanel1.RowCount = 5;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
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
        lblTieuDe.Text = "QUẢN LÝ CA LÀM VIỆC";
        lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblTrangThai
        // 
        lblTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)((byte)230)), ((int)((byte)241)), ((int)((byte)252)));
        lblTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTrangThai.ForeColor = System.Drawing.Color.Navy;
        lblTrangThai.Location = new System.Drawing.Point(3, 66);
        lblTrangThai.Name = "lblTrangThai";
        lblTrangThai.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        lblTrangThai.Size = new System.Drawing.Size(974, 48);
        lblTrangThai.TabIndex = 1;
        lblTrangThai.Text = "CHƯA MỞ CA";
        lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // grpCa
        // 
        grpCa.Controls.Add(tlpCa);
        grpCa.Dock = System.Windows.Forms.DockStyle.Fill;
        grpCa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        grpCa.ForeColor = System.Drawing.Color.Navy;
        grpCa.Location = new System.Drawing.Point(3, 3);
        grpCa.Name = "grpCa";
        grpCa.Size = new System.Drawing.Size(968, 150);
        grpCa.TabIndex = 2;
        grpCa.TabStop = false;
        grpCa.Text = "Mở / đóng ca";
        // 
        // tlpCa
        // 
        tlpCa.ColumnCount = 5;
        tlpCa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tlpCa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
        tlpCa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tlpCa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
        tlpCa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
        tlpCa.Controls.Add(lblTienDauCa, 0, 0);
        tlpCa.Controls.Add(lblTienCuoiCa, 2, 0);
        tlpCa.Controls.Add(lblGhiChu, 3, 0);
        tlpCa.Controls.Add(nudTienDauCa, 0, 1);
        tlpCa.Controls.Add(btnMoCa, 1, 1);
        tlpCa.Controls.Add(nudTienCuoiCa, 2, 1);
        tlpCa.Controls.Add(txtGhiChu, 3, 1);
        tlpCa.Controls.Add(btnDongCa, 4, 1);
        tlpCa.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpCa.Location = new System.Drawing.Point(3, 3);
        tlpCa.Name = "tlpCa";
        tlpCa.Size = new System.Drawing.Size(968, 100);
        tlpCa.TabIndex = 0;
        tlpCa.RowCount = 2;
        tlpCa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
        tlpCa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        // 
        // lblTienDauCa
        // 
        lblTienDauCa.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTienDauCa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTienDauCa.Location = new System.Drawing.Point(3, 0);
        lblTienDauCa.Name = "lblTienDauCa";
        lblTienDauCa.Size = new System.Drawing.Size(180, 26);
        lblTienDauCa.TabIndex = 0;
        lblTienDauCa.Text = "Tiền đầu ca";
        lblTienDauCa.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // lblTienCuoiCa
        // 
        lblTienCuoiCa.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTienCuoiCa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTienCuoiCa.Location = new System.Drawing.Point(3, 0);
        lblTienCuoiCa.Name = "lblTienCuoiCa";
        lblTienCuoiCa.Size = new System.Drawing.Size(180, 26);
        lblTienCuoiCa.TabIndex = 1;
        lblTienCuoiCa.Text = "Tiền cuối ca (thực đếm)";
        lblTienCuoiCa.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // lblGhiChu
        // 
        lblGhiChu.Dock = System.Windows.Forms.DockStyle.Fill;
        lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblGhiChu.Location = new System.Drawing.Point(3, 0);
        lblGhiChu.Name = "lblGhiChu";
        lblGhiChu.Size = new System.Drawing.Size(180, 26);
        lblGhiChu.TabIndex = 2;
        lblGhiChu.Text = "Ghi chú khi đóng ca";
        lblGhiChu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // nudTienDauCa
        // 
        nudTienDauCa.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        nudTienDauCa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        nudTienDauCa.Location = new System.Drawing.Point(3, 3);
        nudTienDauCa.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
        nudTienDauCa.Name = "nudTienDauCa";
        nudTienDauCa.Size = new System.Drawing.Size(180, 30);
        nudTienDauCa.TabIndex = 3;
        nudTienDauCa.ThousandsSeparator = true;
        // 
        // btnMoCa
        // 
        btnMoCa.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnMoCa.BackColor = System.Drawing.Color.Navy;
        btnMoCa.Cursor = System.Windows.Forms.Cursors.Hand;
        btnMoCa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnMoCa.ForeColor = System.Drawing.Color.White;
        btnMoCa.Location = new System.Drawing.Point(3, 3);
        btnMoCa.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
        btnMoCa.Name = "btnMoCa";
        btnMoCa.Size = new System.Drawing.Size(125, 38);
        btnMoCa.TabIndex = 4;
        btnMoCa.Text = "Mở ca";
        btnMoCa.UseVisualStyleBackColor = false;
        // 
        // nudTienCuoiCa
        // 
        nudTienCuoiCa.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        nudTienCuoiCa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        nudTienCuoiCa.Location = new System.Drawing.Point(3, 3);
        nudTienCuoiCa.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
        nudTienCuoiCa.Name = "nudTienCuoiCa";
        nudTienCuoiCa.Size = new System.Drawing.Size(180, 30);
        nudTienCuoiCa.TabIndex = 5;
        nudTienCuoiCa.ThousandsSeparator = true;
        // 
        // txtGhiChu
        // 
        txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtGhiChu.Location = new System.Drawing.Point(3, 3);
        txtGhiChu.MaxLength = 500;
        txtGhiChu.Name = "txtGhiChu";
        txtGhiChu.PlaceholderText = "Ghi chú (nếu có)";
        txtGhiChu.Size = new System.Drawing.Size(180, 30);
        txtGhiChu.TabIndex = 6;
        // 
        // btnDongCa
        // 
        btnDongCa.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnDongCa.BackColor = System.Drawing.Color.Firebrick;
        btnDongCa.Cursor = System.Windows.Forms.Cursors.Hand;
        btnDongCa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnDongCa.ForeColor = System.Drawing.Color.White;
        btnDongCa.Location = new System.Drawing.Point(3, 3);
        btnDongCa.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
        btnDongCa.Name = "btnDongCa";
        btnDongCa.Size = new System.Drawing.Size(125, 38);
        btnDongCa.TabIndex = 7;
        btnDongCa.Text = "Đóng ca";
        btnDongCa.UseVisualStyleBackColor = false;
        // 
        // tlpLoc
        // 
        tlpLoc.ColumnCount = 4;
        tlpLoc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tlpLoc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tlpLoc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
        tlpLoc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tlpLoc.Controls.Add(lblTuNgay, 0, 0);
        tlpLoc.Controls.Add(lblDenNgay, 1, 0);
        tlpLoc.Controls.Add(dtpTuNgay, 0, 1);
        tlpLoc.Controls.Add(dtpDenNgay, 1, 1);
        tlpLoc.Controls.Add(btnTaiLichSu, 2, 1);
        tlpLoc.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpLoc.Location = new System.Drawing.Point(3, 3);
        tlpLoc.Name = "tlpLoc";
        tlpLoc.Size = new System.Drawing.Size(968, 100);
        tlpLoc.TabIndex = 3;
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
        lblTuNgay.Text = "Lọc từ ngày:";
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
        // dtpTuNgay
        // 
        dtpTuNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpTuNgay.Location = new System.Drawing.Point(3, 3);
        dtpTuNgay.Name = "dtpTuNgay";
        dtpTuNgay.Size = new System.Drawing.Size(180, 30);
        dtpTuNgay.TabIndex = 2;
        // 
        // dtpDenNgay
        // 
        dtpDenNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpDenNgay.Location = new System.Drawing.Point(3, 3);
        dtpDenNgay.Name = "dtpDenNgay";
        dtpDenNgay.Size = new System.Drawing.Size(180, 30);
        dtpDenNgay.TabIndex = 3;
        // 
        // btnTaiLichSu
        // 
        btnTaiLichSu.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnTaiLichSu.BackColor = System.Drawing.Color.Navy;
        btnTaiLichSu.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTaiLichSu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTaiLichSu.ForeColor = System.Drawing.Color.White;
        btnTaiLichSu.Location = new System.Drawing.Point(3, 3);
        btnTaiLichSu.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
        btnTaiLichSu.Name = "btnTaiLichSu";
        btnTaiLichSu.Size = new System.Drawing.Size(170, 38);
        btnTaiLichSu.TabIndex = 4;
        btnTaiLichSu.Text = "Tải lịch sử ca";
        btnTaiLichSu.UseVisualStyleBackColor = false;
        // 
        // dgvCaLamViec
        // 
        dgvCaLamViec.AllowUserToAddRows = false;
        dgvCaLamViec.AllowUserToDeleteRows = false;
        dgvCaLamViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvCaLamViec.BackgroundColor = System.Drawing.Color.White;
        dgvCaLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCaLamViec.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvCaLamViec.Location = new System.Drawing.Point(3, 3);
        dgvCaLamViec.MultiSelect = false;
        dgvCaLamViec.Name = "dgvCaLamViec";
        dgvCaLamViec.ReadOnly = true;
        dgvCaLamViec.RowHeadersWidth = 51;
        dgvCaLamViec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvCaLamViec.Size = new System.Drawing.Size(968, 300);
        dgvCaLamViec.TabIndex = 4;
        // 
        // FormQuanLyCa
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1000, 660);
        Controls.Add(panel1);
        Text = "Quản lý ca làm việc";
        WindowState = System.Windows.Forms.FormWindowState.Maximized;
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        grpCa.ResumeLayout(false);
        tlpCa.ResumeLayout(false);
        tlpCa.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudTienDauCa).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudTienCuoiCa).EndInit();
        tlpLoc.ResumeLayout(false);
        tlpLoc.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCaLamViec).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.Label lblTrangThai;
    private System.Windows.Forms.GroupBox grpCa;
    private System.Windows.Forms.TableLayoutPanel tlpCa;
    private System.Windows.Forms.Label lblTienDauCa;
    private System.Windows.Forms.Label lblTienCuoiCa;
    private System.Windows.Forms.Label lblGhiChu;
    private System.Windows.Forms.NumericUpDown nudTienDauCa;
    private System.Windows.Forms.Button btnMoCa;
    private System.Windows.Forms.NumericUpDown nudTienCuoiCa;
    private System.Windows.Forms.TextBox txtGhiChu;
    private System.Windows.Forms.Button btnDongCa;
    private System.Windows.Forms.TableLayoutPanel tlpLoc;
    private System.Windows.Forms.Label lblTuNgay;
    private System.Windows.Forms.Label lblDenNgay;
    private System.Windows.Forms.DateTimePicker dtpTuNgay;
    private System.Windows.Forms.DateTimePicker dtpDenNgay;
    private System.Windows.Forms.Button btnTaiLichSu;
    private System.Windows.Forms.DataGridView dgvCaLamViec;

    #endregion
}

using System.ComponentModel;

namespace MiniMart.Forms;

partial class FormHanSuDung
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
        grpLoHang = new System.Windows.Forms.GroupBox();
        tlpLoHang = new System.Windows.Forms.TableLayoutPanel();
        lblSanPham = new System.Windows.Forms.Label();
        lblMaLo = new System.Windows.Forms.Label();
        lblSoLuong = new System.Windows.Forms.Label();
        lblNgaySanXuat = new System.Windows.Forms.Label();
        lblHanSuDung = new System.Windows.Forms.Label();
        cboSanPham = new System.Windows.Forms.ComboBox();
        txtMaLo = new System.Windows.Forms.TextBox();
        nudSoLuong = new System.Windows.Forms.NumericUpDown();
        dtpNgaySanXuat = new System.Windows.Forms.DateTimePicker();
        dtpHanSuDung = new System.Windows.Forms.DateTimePicker();
        flpNutLo = new System.Windows.Forms.FlowLayoutPanel();
        btnTaoLo = new System.Windows.Forms.Button();
        tlpTimKiem = new System.Windows.Forms.TableLayoutPanel();
        lblTimKiem = new System.Windows.Forms.Label();
        txtTimKiem = new System.Windows.Forms.TextBox();
        btnLoc = new System.Windows.Forms.Button();
        btnXoaLo = new System.Windows.Forms.Button();
        dgvLoHang = new System.Windows.Forms.DataGridView();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        grpLoHang.SuspendLayout();
        tlpLoHang.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
        flpNutLo.SuspendLayout();
        tlpTimKiem.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvLoHang).BeginInit();
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
        tableLayoutPanel1.Controls.Add(grpLoHang, 0, 1);
        tableLayoutPanel1.Controls.Add(tlpTimKiem, 0, 2);
        tableLayoutPanel1.Controls.Add(dgvLoHang, 0, 3);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new System.Drawing.Size(1000, 660);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // lblTieuDe
        // 
        lblTieuDe.BackColor = System.Drawing.Color.White;
        lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTieuDe.ForeColor = System.Drawing.Color.Navy;
        lblTieuDe.Location = new System.Drawing.Point(3, 0);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new System.Drawing.Size(994, 66);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "QUẢN LÝ HẠN SỬ DỤNG";
        lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // grpLoHang
        // 
        grpLoHang.Controls.Add(tlpLoHang);
        grpLoHang.Dock = System.Windows.Forms.DockStyle.Fill;
        grpLoHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        grpLoHang.ForeColor = System.Drawing.Color.Navy;
        grpLoHang.Location = new System.Drawing.Point(3, 69);
        grpLoHang.Name = "grpLoHang";
        grpLoHang.Size = new System.Drawing.Size(994, 164);
        grpLoHang.TabIndex = 1;
        grpLoHang.TabStop = false;
        grpLoHang.Text = "Tạo lô hàng mới";
        // 
        // tlpLoHang
        // 
        tlpLoHang.ColumnCount = 5;
        tlpLoHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
        tlpLoHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
        tlpLoHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
        tlpLoHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tlpLoHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tlpLoHang.Controls.Add(lblSanPham, 0, 0);
        tlpLoHang.Controls.Add(lblMaLo, 1, 0);
        tlpLoHang.Controls.Add(lblSoLuong, 2, 0);
        tlpLoHang.Controls.Add(lblNgaySanXuat, 3, 0);
        tlpLoHang.Controls.Add(lblHanSuDung, 4, 0);
        tlpLoHang.Controls.Add(cboSanPham, 0, 1);
        tlpLoHang.Controls.Add(txtMaLo, 1, 1);
        tlpLoHang.Controls.Add(nudSoLuong, 2, 1);
        tlpLoHang.Controls.Add(dtpNgaySanXuat, 3, 1);
        tlpLoHang.Controls.Add(dtpHanSuDung, 4, 1);
        tlpLoHang.Controls.Add(flpNutLo, 0, 2);
        tlpLoHang.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpLoHang.Location = new System.Drawing.Point(3, 26);
        tlpLoHang.Name = "tlpLoHang";
        tlpLoHang.RowCount = 3;
        tlpLoHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
        tlpLoHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
        tlpLoHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpLoHang.Size = new System.Drawing.Size(988, 135);
        tlpLoHang.TabIndex = 0;
        // 
        // lblSanPham
        // 
        lblSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
        lblSanPham.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblSanPham.Location = new System.Drawing.Point(3, 0);
        lblSanPham.Name = "lblSanPham";
        lblSanPham.Size = new System.Drawing.Size(270, 28);
        lblSanPham.TabIndex = 0;
        lblSanPham.Text = "Sản phẩm";
        lblSanPham.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // lblMaLo
        // 
        lblMaLo.Dock = System.Windows.Forms.DockStyle.Fill;
        lblMaLo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblMaLo.Location = new System.Drawing.Point(279, 0);
        lblMaLo.Name = "lblMaLo";
        lblMaLo.Size = new System.Drawing.Size(171, 28);
        lblMaLo.TabIndex = 1;
        lblMaLo.Text = "Mã lô";
        lblMaLo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // lblSoLuong
        // 
        lblSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
        lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblSoLuong.Location = new System.Drawing.Point(456, 0);
        lblSoLuong.Name = "lblSoLuong";
        lblSoLuong.Size = new System.Drawing.Size(132, 28);
        lblSoLuong.TabIndex = 2;
        lblSoLuong.Text = "Số lượng lô";
        lblSoLuong.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // lblNgaySanXuat
        // 
        lblNgaySanXuat.Dock = System.Windows.Forms.DockStyle.Fill;
        lblNgaySanXuat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblNgaySanXuat.Location = new System.Drawing.Point(594, 0);
        lblNgaySanXuat.Name = "lblNgaySanXuat";
        lblNgaySanXuat.Size = new System.Drawing.Size(191, 28);
        lblNgaySanXuat.TabIndex = 3;
        lblNgaySanXuat.Text = "Ngày sản xuất (tùy chọn)";
        lblNgaySanXuat.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // lblHanSuDung
        // 
        lblHanSuDung.Dock = System.Windows.Forms.DockStyle.Fill;
        lblHanSuDung.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblHanSuDung.Location = new System.Drawing.Point(791, 0);
        lblHanSuDung.Name = "lblHanSuDung";
        lblHanSuDung.Size = new System.Drawing.Size(194, 28);
        lblHanSuDung.TabIndex = 4;
        lblHanSuDung.Text = "Hạn sử dụng";
        lblHanSuDung.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // cboSanPham
        // 
        cboSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        cboSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboSanPham.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cboSanPham.FormattingEnabled = true;
        cboSanPham.Location = new System.Drawing.Point(3, 32);
        cboSanPham.Name = "cboSanPham";
        cboSanPham.Size = new System.Drawing.Size(270, 31);
        cboSanPham.TabIndex = 5;
        // 
        // txtMaLo
        // 
        txtMaLo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtMaLo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtMaLo.Location = new System.Drawing.Point(279, 33);
        txtMaLo.MaxLength = 40;
        txtMaLo.Name = "txtMaLo";
        txtMaLo.PlaceholderText = "Để trống để tự tạo";
        txtMaLo.Size = new System.Drawing.Size(171, 30);
        txtMaLo.TabIndex = 6;
        // 
        // nudSoLuong
        // 
        nudSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        nudSoLuong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        nudSoLuong.Location = new System.Drawing.Point(456, 33);
        nudSoLuong.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudSoLuong.Name = "nudSoLuong";
        nudSoLuong.Size = new System.Drawing.Size(132, 30);
        nudSoLuong.TabIndex = 7;
        nudSoLuong.ThousandsSeparator = true;
        nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // dtpNgaySanXuat
        // 
        dtpNgaySanXuat.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        dtpNgaySanXuat.Checked = false;
        dtpNgaySanXuat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpNgaySanXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpNgaySanXuat.Location = new System.Drawing.Point(594, 33);
        dtpNgaySanXuat.Name = "dtpNgaySanXuat";
        dtpNgaySanXuat.ShowCheckBox = true;
        dtpNgaySanXuat.Size = new System.Drawing.Size(191, 30);
        dtpNgaySanXuat.TabIndex = 8;
        // 
        // dtpHanSuDung
        // 
        dtpHanSuDung.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        dtpHanSuDung.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpHanSuDung.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpHanSuDung.Location = new System.Drawing.Point(791, 33);
        dtpHanSuDung.Name = "dtpHanSuDung";
        dtpHanSuDung.Size = new System.Drawing.Size(194, 30);
        dtpHanSuDung.TabIndex = 9;
        // 
        // flpNutLo
        // 
        tlpLoHang.SetColumnSpan(flpNutLo, 5);
        flpNutLo.Controls.Add(btnTaoLo);
        flpNutLo.Dock = System.Windows.Forms.DockStyle.Fill;
        flpNutLo.Location = new System.Drawing.Point(3, 71);
        flpNutLo.Name = "flpNutLo";
        flpNutLo.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
        flpNutLo.Size = new System.Drawing.Size(982, 61);
        flpNutLo.TabIndex = 10;
        flpNutLo.WrapContents = false;
        // 
        // btnTaoLo
        // 
        btnTaoLo.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnTaoLo.BackColor = System.Drawing.Color.Navy;
        btnTaoLo.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTaoLo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTaoLo.ForeColor = System.Drawing.Color.White;
        btnTaoLo.Location = new System.Drawing.Point(3, 5);
        btnTaoLo.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
        btnTaoLo.Name = "btnTaoLo";
        btnTaoLo.Size = new System.Drawing.Size(150, 38);
        btnTaoLo.TabIndex = 0;
        btnTaoLo.Text = "Tạo lô hàng";
        btnTaoLo.UseVisualStyleBackColor = false;
        // 
        // tlpTimKiem
        // 
        tlpTimKiem.ColumnCount = 5;
        tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
        tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
        tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
        tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
        tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
        tlpTimKiem.Controls.Add(lblTimKiem, 0, 0);
        tlpTimKiem.Controls.Add(txtTimKiem, 1, 0);
        tlpTimKiem.Controls.Add(btnLoc, 2, 0);
        tlpTimKiem.Controls.Add(btnXoaLo, 3, 0);
        tlpTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpTimKiem.Location = new System.Drawing.Point(3, 239);
        tlpTimKiem.Name = "tlpTimKiem";
        tlpTimKiem.RowCount = 1;
        tlpTimKiem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpTimKiem.Size = new System.Drawing.Size(994, 50);
        tlpTimKiem.TabIndex = 2;
        // 
        // lblTimKiem
        // 
        lblTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTimKiem.Location = new System.Drawing.Point(3, 0);
        lblTimKiem.Name = "lblTimKiem";
        lblTimKiem.Size = new System.Drawing.Size(114, 50);
        lblTimKiem.TabIndex = 0;
        lblTimKiem.Text = "Tìm nhanh:";
        lblTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtTimKiem
        // 
        txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtTimKiem.Location = new System.Drawing.Point(123, 10);
        txtTimKiem.MaxLength = 100;
        txtTimKiem.Name = "txtTimKiem";
        txtTimKiem.PlaceholderText = "Mã lô hoặc tên sản phẩm";
        txtTimKiem.Size = new System.Drawing.Size(332, 30);
        txtTimKiem.TabIndex = 1;
        // 
        // btnLoc
        // 
        btnLoc.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnLoc.BackColor = System.Drawing.Color.Navy;
        btnLoc.Cursor = System.Windows.Forms.Cursors.Hand;
        btnLoc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnLoc.ForeColor = System.Drawing.Color.White;
        btnLoc.Location = new System.Drawing.Point(465, 6);
        btnLoc.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
        btnLoc.Name = "btnLoc";
        btnLoc.Size = new System.Drawing.Size(100, 38);
        btnLoc.TabIndex = 2;
        btnLoc.Text = "Lọc";
        btnLoc.UseVisualStyleBackColor = false;
        // 
        // btnXoaLo
        // 
        btnXoaLo.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnXoaLo.BackColor = System.Drawing.Color.Firebrick;
        btnXoaLo.Cursor = System.Windows.Forms.Cursors.Hand;
        btnXoaLo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnXoaLo.ForeColor = System.Drawing.Color.White;
        btnXoaLo.Location = new System.Drawing.Point(581, 6);
        btnXoaLo.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
        btnXoaLo.Name = "btnXoaLo";
        btnXoaLo.Size = new System.Drawing.Size(179, 38);
        btnXoaLo.TabIndex = 3;
        btnXoaLo.Text = "Xóa lô";
        btnXoaLo.UseVisualStyleBackColor = false;
        // 
        // dgvLoHang
        // 
        dgvLoHang.AllowUserToAddRows = false;
        dgvLoHang.AllowUserToDeleteRows = false;
        dgvLoHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvLoHang.BackgroundColor = System.Drawing.Color.White;
        dgvLoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvLoHang.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvLoHang.Location = new System.Drawing.Point(3, 295);
        dgvLoHang.MultiSelect = false;
        dgvLoHang.Name = "dgvLoHang";
        dgvLoHang.ReadOnly = true;
        dgvLoHang.RowHeadersWidth = 51;
        dgvLoHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvLoHang.Size = new System.Drawing.Size(994, 362);
        dgvLoHang.TabIndex = 3;
        // 
        // FormHanSuDung
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1000, 660);
        Controls.Add(panel1);
        Text = "Theo dõi hạn sử dụng";
        WindowState = System.Windows.Forms.FormWindowState.Maximized;
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        grpLoHang.ResumeLayout(false);
        tlpLoHang.ResumeLayout(false);
        tlpLoHang.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
        flpNutLo.ResumeLayout(false);
        tlpTimKiem.ResumeLayout(false);
        tlpTimKiem.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvLoHang).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.GroupBox grpLoHang;
    private System.Windows.Forms.TableLayoutPanel tlpLoHang;
    private System.Windows.Forms.Label lblSanPham;
    private System.Windows.Forms.Label lblMaLo;
    private System.Windows.Forms.Label lblSoLuong;
    private System.Windows.Forms.Label lblNgaySanXuat;
    private System.Windows.Forms.Label lblHanSuDung;
    private System.Windows.Forms.ComboBox cboSanPham;
    private System.Windows.Forms.TextBox txtMaLo;
    private System.Windows.Forms.NumericUpDown nudSoLuong;
    private System.Windows.Forms.DateTimePicker dtpNgaySanXuat;
    private System.Windows.Forms.DateTimePicker dtpHanSuDung;
    private System.Windows.Forms.FlowLayoutPanel flpNutLo;
    private System.Windows.Forms.Button btnTaoLo;
    private System.Windows.Forms.TableLayoutPanel tlpTimKiem;
    private System.Windows.Forms.Label lblTimKiem;
    private System.Windows.Forms.TextBox txtTimKiem;
    private System.Windows.Forms.Button btnLoc;
    private System.Windows.Forms.Button btnXoaLo;
    private System.Windows.Forms.DataGridView dgvLoHang;

    #endregion
}

using System.ComponentModel;

namespace MiniMart.Forms;

partial class FormKhachHang
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
        tlpTimKiem = new System.Windows.Forms.TableLayoutPanel();
        lblTimKiem = new System.Windows.Forms.Label();
        txtTimKiem = new System.Windows.Forms.TextBox();
        btnTimKiem = new System.Windows.Forms.Button();
        grpThongTin = new System.Windows.Forms.GroupBox();
        tlpThongTin = new System.Windows.Forms.TableLayoutPanel();
        lblHoTen = new System.Windows.Forms.Label();
        lblSoDienThoai = new System.Windows.Forms.Label();
        lblDiaChi = new System.Windows.Forms.Label();
        txtHoTen = new System.Windows.Forms.TextBox();
        txtSoDienThoai = new System.Windows.Forms.TextBox();
        txtDiaChi = new System.Windows.Forms.TextBox();
        flpNutLenh = new System.Windows.Forms.FlowLayoutPanel();
        btnLuu = new System.Windows.Forms.Button();
        btnLamMoi = new System.Windows.Forms.Button();
        btnLichSuMua = new System.Windows.Forms.Button();
        btnXoa = new System.Windows.Forms.Button();
        dgvKhachHang = new System.Windows.Forms.DataGridView();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tlpTimKiem.SuspendLayout();
        grpThongTin.SuspendLayout();
        tlpThongTin.SuspendLayout();
        flpNutLenh.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
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
        tableLayoutPanel1.Controls.Add(tlpTimKiem, 0, 1);
        tableLayoutPanel1.Controls.Add(grpThongTin, 0, 2);
        tableLayoutPanel1.Controls.Add(dgvKhachHang, 0, 3);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.Size = new System.Drawing.Size(968, 100);
        tableLayoutPanel1.TabIndex = 0;
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
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
        lblTieuDe.Text = "KHÁCH HÀNG THÂN THIẾT";
        lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tlpTimKiem
        // 
        tlpTimKiem.ColumnCount = 4;
        tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
        tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
        tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
        tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
        tlpTimKiem.Controls.Add(lblTimKiem, 0, 0);
        tlpTimKiem.Controls.Add(txtTimKiem, 1, 0);
        tlpTimKiem.Controls.Add(btnTimKiem, 2, 0);
        tlpTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpTimKiem.Location = new System.Drawing.Point(3, 3);
        tlpTimKiem.Name = "tlpTimKiem";
        tlpTimKiem.Size = new System.Drawing.Size(968, 100);
        tlpTimKiem.TabIndex = 1;
        tlpTimKiem.RowCount = 1;
        tlpTimKiem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        // 
        // lblTimKiem
        // 
        lblTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTimKiem.Location = new System.Drawing.Point(3, 0);
        lblTimKiem.Name = "lblTimKiem";
        lblTimKiem.Size = new System.Drawing.Size(180, 26);
        lblTimKiem.TabIndex = 0;
        lblTimKiem.Text = "Tìm tên / số điện thoại:";
        lblTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtTimKiem
        // 
        txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtTimKiem.Location = new System.Drawing.Point(3, 3);
        txtTimKiem.MaxLength = 100;
        txtTimKiem.Name = "txtTimKiem";
        txtTimKiem.PlaceholderText = "Nhập tên hoặc số điện thoại...";
        txtTimKiem.Size = new System.Drawing.Size(180, 30);
        txtTimKiem.TabIndex = 1;
        // 
        // btnTimKiem
        // 
        btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnTimKiem.BackColor = System.Drawing.Color.Navy;
        btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTimKiem.ForeColor = System.Drawing.Color.White;
        btnTimKiem.Location = new System.Drawing.Point(3, 3);
        btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
        btnTimKiem.Name = "btnTimKiem";
        btnTimKiem.Size = new System.Drawing.Size(150, 38);
        btnTimKiem.TabIndex = 2;
        btnTimKiem.Text = "Tìm kiếm";
        btnTimKiem.UseVisualStyleBackColor = false;
        // 
        // grpThongTin
        // 
        grpThongTin.Controls.Add(tlpThongTin);
        grpThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
        grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        grpThongTin.ForeColor = System.Drawing.Color.Navy;
        grpThongTin.Location = new System.Drawing.Point(3, 3);
        grpThongTin.Name = "grpThongTin";
        grpThongTin.Size = new System.Drawing.Size(968, 150);
        grpThongTin.TabIndex = 2;
        grpThongTin.TabStop = false;
        grpThongTin.Text = "Thông tin khách hàng";
        // 
        // tlpThongTin
        // 
        tlpThongTin.ColumnCount = 3;
        tlpThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        tlpThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        tlpThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        tlpThongTin.Controls.Add(lblHoTen, 0, 0);
        tlpThongTin.Controls.Add(lblSoDienThoai, 1, 0);
        tlpThongTin.Controls.Add(lblDiaChi, 2, 0);
        tlpThongTin.Controls.Add(txtHoTen, 0, 1);
        tlpThongTin.Controls.Add(txtSoDienThoai, 1, 1);
        tlpThongTin.Controls.Add(txtDiaChi, 2, 1);
        tlpThongTin.Controls.Add(flpNutLenh, 0, 2);
        tlpThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpThongTin.Location = new System.Drawing.Point(3, 3);
        tlpThongTin.Name = "tlpThongTin";
        tlpThongTin.Size = new System.Drawing.Size(968, 100);
        tlpThongTin.TabIndex = 0;
        tlpThongTin.RowCount = 3;
        tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
        tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
        tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpThongTin.SetColumnSpan(flpNutLenh, 3);
        // 
        // lblHoTen
        // 
        lblHoTen.Dock = System.Windows.Forms.DockStyle.Fill;
        lblHoTen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblHoTen.Location = new System.Drawing.Point(3, 0);
        lblHoTen.Name = "lblHoTen";
        lblHoTen.Size = new System.Drawing.Size(180, 26);
        lblHoTen.TabIndex = 0;
        lblHoTen.Text = "Họ và tên";
        lblHoTen.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // lblSoDienThoai
        // 
        lblSoDienThoai.Dock = System.Windows.Forms.DockStyle.Fill;
        lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblSoDienThoai.Location = new System.Drawing.Point(3, 0);
        lblSoDienThoai.Name = "lblSoDienThoai";
        lblSoDienThoai.Size = new System.Drawing.Size(180, 26);
        lblSoDienThoai.TabIndex = 1;
        lblSoDienThoai.Text = "Số điện thoại";
        lblSoDienThoai.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // lblDiaChi
        // 
        lblDiaChi.Dock = System.Windows.Forms.DockStyle.Fill;
        lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblDiaChi.Location = new System.Drawing.Point(3, 0);
        lblDiaChi.Name = "lblDiaChi";
        lblDiaChi.Size = new System.Drawing.Size(180, 26);
        lblDiaChi.TabIndex = 2;
        lblDiaChi.Text = "Địa chỉ";
        lblDiaChi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // txtHoTen
        // 
        txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtHoTen.Location = new System.Drawing.Point(3, 3);
        txtHoTen.MaxLength = 100;
        txtHoTen.Name = "txtHoTen";
        txtHoTen.Size = new System.Drawing.Size(180, 30);
        txtHoTen.TabIndex = 3;
        // 
        // txtSoDienThoai
        // 
        txtSoDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtSoDienThoai.Location = new System.Drawing.Point(3, 3);
        txtSoDienThoai.MaxLength = 15;
        txtSoDienThoai.Name = "txtSoDienThoai";
        txtSoDienThoai.PlaceholderText = "VD: 0912345678";
        txtSoDienThoai.Size = new System.Drawing.Size(180, 30);
        txtSoDienThoai.TabIndex = 4;
        // 
        // txtDiaChi
        // 
        txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtDiaChi.Location = new System.Drawing.Point(3, 3);
        txtDiaChi.MaxLength = 200;
        txtDiaChi.Name = "txtDiaChi";
        txtDiaChi.Size = new System.Drawing.Size(180, 30);
        txtDiaChi.TabIndex = 5;
        // 
        // flpNutLenh
        // 
        flpNutLenh.Controls.Add(btnLuu);
        flpNutLenh.Controls.Add(btnLamMoi);
        flpNutLenh.Controls.Add(btnLichSuMua);
        flpNutLenh.Controls.Add(btnXoa);
        flpNutLenh.Dock = System.Windows.Forms.DockStyle.Fill;
        flpNutLenh.Location = new System.Drawing.Point(3, 3);
        flpNutLenh.Name = "flpNutLenh";
        flpNutLenh.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
        flpNutLenh.Size = new System.Drawing.Size(960, 44);
        flpNutLenh.TabIndex = 6;
        flpNutLenh.WrapContents = false;
        // 
        // btnLuu
        // 
        btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnLuu.BackColor = System.Drawing.Color.Navy;
        btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
        btnLuu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnLuu.ForeColor = System.Drawing.Color.White;
        btnLuu.Location = new System.Drawing.Point(3, 3);
        btnLuu.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
        btnLuu.Name = "btnLuu";
        btnLuu.Size = new System.Drawing.Size(170, 38);
        btnLuu.TabIndex = 0;
        btnLuu.Text = "Lưu khách hàng";
        btnLuu.UseVisualStyleBackColor = false;
        // 
        // btnLamMoi
        // 
        btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnLamMoi.BackColor = System.Drawing.Color.Navy;
        btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
        btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnLamMoi.ForeColor = System.Drawing.Color.White;
        btnLamMoi.Location = new System.Drawing.Point(3, 3);
        btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new System.Drawing.Size(120, 38);
        btnLamMoi.TabIndex = 1;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.UseVisualStyleBackColor = false;
        // 
        // btnLichSuMua
        // 
        btnLichSuMua.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnLichSuMua.BackColor = System.Drawing.Color.Navy;
        btnLichSuMua.Cursor = System.Windows.Forms.Cursors.Hand;
        btnLichSuMua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnLichSuMua.ForeColor = System.Drawing.Color.White;
        btnLichSuMua.Location = new System.Drawing.Point(3, 3);
        btnLichSuMua.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
        btnLichSuMua.Name = "btnLichSuMua";
        btnLichSuMua.Size = new System.Drawing.Size(140, 38);
        btnLichSuMua.TabIndex = 2;
        btnLichSuMua.Text = "Lịch sử mua";
        btnLichSuMua.UseVisualStyleBackColor = false;
        // 
        // btnXoa
        // 
        btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnXoa.BackColor = System.Drawing.Color.Firebrick;
        btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
        btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnXoa.ForeColor = System.Drawing.Color.White;
        btnXoa.Location = new System.Drawing.Point(3, 3);
        btnXoa.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new System.Drawing.Size(120, 38);
        btnXoa.TabIndex = 3;
        btnXoa.Text = "Xóa khách";
        btnXoa.UseVisualStyleBackColor = false;
        // 
        // dgvKhachHang
        // 
        dgvKhachHang.AllowUserToAddRows = false;
        dgvKhachHang.AllowUserToDeleteRows = false;
        dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
        dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvKhachHang.Location = new System.Drawing.Point(3, 3);
        dgvKhachHang.MultiSelect = false;
        dgvKhachHang.Name = "dgvKhachHang";
        dgvKhachHang.ReadOnly = true;
        dgvKhachHang.RowHeadersWidth = 51;
        dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvKhachHang.Size = new System.Drawing.Size(968, 300);
        dgvKhachHang.TabIndex = 3;
        // 
        // FormKhachHang
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1000, 660);
        Controls.Add(panel1);
        Text = "Quản lý khách hàng thân thiết";
        WindowState = System.Windows.Forms.FormWindowState.Maximized;
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        tlpTimKiem.ResumeLayout(false);
        tlpTimKiem.PerformLayout();
        grpThongTin.ResumeLayout(false);
        tlpThongTin.ResumeLayout(false);
        tlpThongTin.PerformLayout();
        flpNutLenh.ResumeLayout(false);
        flpNutLenh.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.TableLayoutPanel tlpTimKiem;
    private System.Windows.Forms.Label lblTimKiem;
    private System.Windows.Forms.TextBox txtTimKiem;
    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.GroupBox grpThongTin;
    private System.Windows.Forms.TableLayoutPanel tlpThongTin;
    private System.Windows.Forms.Label lblHoTen;
    private System.Windows.Forms.Label lblSoDienThoai;
    private System.Windows.Forms.Label lblDiaChi;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.TextBox txtSoDienThoai;
    private System.Windows.Forms.TextBox txtDiaChi;
    private System.Windows.Forms.FlowLayoutPanel flpNutLenh;
    private System.Windows.Forms.Button btnLuu;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.Button btnLichSuMua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.DataGridView dgvKhachHang;

    #endregion
}

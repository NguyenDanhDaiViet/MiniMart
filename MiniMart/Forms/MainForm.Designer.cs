using System.ComponentModel;

namespace MiniMart.Forms;

partial class MainForm
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
        manHinh = new System.Windows.Forms.Panel();
        panel3 = new System.Windows.Forms.Panel();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        label1 = new System.Windows.Forms.Label();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        btBanHang = new System.Windows.Forms.Button();
        btTaiKhoan = new System.Windows.Forms.Button();
        btBaoCao = new System.Windows.Forms.Button();
        btCanhBao = new System.Windows.Forms.Button();
        btNhapKho = new System.Windows.Forms.Button();
        btSanPham = new System.Windows.Forms.Button();
        btnLichSuDon = new System.Windows.Forms.Button();
        tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
        btnDangXuat = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        btnNguoiDung = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        panel3.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(tableLayoutPanel1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(1056, 686);
        panel1.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.790697F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.209305F));
        tableLayoutPanel1.Controls.Add(manHinh, 1, 0);
        tableLayoutPanel1.Controls.Add(panel3, 0, 0);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new System.Drawing.Size(1056, 686);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // manHinh
        // 
        manHinh.Dock = System.Windows.Forms.DockStyle.Fill;
        manHinh.Location = new System.Drawing.Point(243, 3);
        manHinh.Name = "manHinh";
        manHinh.Size = new System.Drawing.Size(810, 680);
        manHinh.TabIndex = 0;
        // 
        // panel3
        // 
        panel3.BackColor = System.Drawing.Color.Green;
        panel3.Controls.Add(tableLayoutPanel2);
        panel3.Dock = System.Windows.Forms.DockStyle.Fill;
        panel3.Location = new System.Drawing.Point(3, 3);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(234, 680);
        panel3.TabIndex = 1;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.Controls.Add(label1, 0, 0);
        tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
        tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 2);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 3;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.704845F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.29515F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel2.Size = new System.Drawing.Size(234, 680);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // label1
        // 
        label1.Anchor = System.Windows.Forms.AnchorStyles.None;
        label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.White;
        label1.Location = new System.Drawing.Point(37, 36);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(160, 36);
        label1.TabIndex = 0;
        label1.Text = "MiniMart\r\n";
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel3.Controls.Add(btBanHang, 0, 0);
        tableLayoutPanel3.Controls.Add(btTaiKhoan, 0, 6);
        tableLayoutPanel3.Controls.Add(btBaoCao, 0, 5);
        tableLayoutPanel3.Controls.Add(btCanhBao, 0, 4);
        tableLayoutPanel3.Controls.Add(btNhapKho, 0, 3);
        tableLayoutPanel3.Controls.Add(btSanPham, 0, 1);
        tableLayoutPanel3.Controls.Add(btnLichSuDon, 0, 2);
        tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel3.Location = new System.Drawing.Point(3, 111);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 7;
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.619886F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.619884F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.619884F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.619884F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.619884F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.619884F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.280703F));
        tableLayoutPanel3.Size = new System.Drawing.Size(228, 409);
        tableLayoutPanel3.TabIndex = 1;
        // 
        // btBanHang
        // 
        btBanHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btBanHang.BackColor = System.Drawing.Color.LimeGreen;
        btBanHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btBanHang.ForeColor = System.Drawing.Color.White;
        btBanHang.Location = new System.Drawing.Point(3, 3);
        btBanHang.Name = "btBanHang";
        btBanHang.Size = new System.Drawing.Size(222, 53);
        btBanHang.TabIndex = 0;
        btBanHang.Text = "Bán hàng";
        btBanHang.UseVisualStyleBackColor = false;
        btBanHang.Click += btBanHang_Click;
        // 
        // btTaiKhoan
        // 
        btTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btTaiKhoan.BackColor = System.Drawing.Color.LimeGreen;
        btTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btTaiKhoan.ForeColor = System.Drawing.Color.White;
        btTaiKhoan.Location = new System.Drawing.Point(3, 357);
        btTaiKhoan.Name = "btTaiKhoan";
        btTaiKhoan.Size = new System.Drawing.Size(222, 49);
        btTaiKhoan.TabIndex = 5;
        btTaiKhoan.Text = "Tài khoản";
        btTaiKhoan.UseVisualStyleBackColor = false;
        btTaiKhoan.Click += btTaiKhoan_Click;
        // 
        // btBaoCao
        // 
        btBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btBaoCao.BackColor = System.Drawing.Color.LimeGreen;
        btBaoCao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btBaoCao.ForeColor = System.Drawing.Color.White;
        btBaoCao.Location = new System.Drawing.Point(3, 298);
        btBaoCao.Name = "btBaoCao";
        btBaoCao.Size = new System.Drawing.Size(222, 53);
        btBaoCao.TabIndex = 4;
        btBaoCao.Text = "Báo cáo";
        btBaoCao.UseVisualStyleBackColor = false;
        btBaoCao.Click += btBaoCao_Click;
        // 
        // btCanhBao
        // 
        btCanhBao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btCanhBao.BackColor = System.Drawing.Color.LimeGreen;
        btCanhBao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btCanhBao.ForeColor = System.Drawing.Color.White;
        btCanhBao.Location = new System.Drawing.Point(3, 239);
        btCanhBao.Name = "btCanhBao";
        btCanhBao.Size = new System.Drawing.Size(222, 53);
        btCanhBao.TabIndex = 3;
        btCanhBao.Text = "Cảnh báo tồn";
        btCanhBao.UseVisualStyleBackColor = false;
        btCanhBao.Click += btCanhBao_Click;
        // 
        // btNhapKho
        // 
        btNhapKho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btNhapKho.BackColor = System.Drawing.Color.LimeGreen;
        btNhapKho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btNhapKho.ForeColor = System.Drawing.Color.White;
        btNhapKho.Location = new System.Drawing.Point(3, 180);
        btNhapKho.Name = "btNhapKho";
        btNhapKho.Size = new System.Drawing.Size(222, 53);
        btNhapKho.TabIndex = 2;
        btNhapKho.Text = "Nhập kho";
        btNhapKho.UseVisualStyleBackColor = false;
        btNhapKho.Click += btNhapKho_Click;
        // 
        // btSanPham
        // 
        btSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btSanPham.BackColor = System.Drawing.Color.LimeGreen;
        btSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btSanPham.ForeColor = System.Drawing.Color.White;
        btSanPham.Location = new System.Drawing.Point(3, 62);
        btSanPham.Name = "btSanPham";
        btSanPham.Size = new System.Drawing.Size(222, 53);
        btSanPham.TabIndex = 1;
        btSanPham.Text = "Sản phẩm";
        btSanPham.UseVisualStyleBackColor = false;
        btSanPham.Click += btSanPham_Click;
        // 
        // btnLichSuDon
        // 
        btnLichSuDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btnLichSuDon.BackColor = System.Drawing.Color.LimeGreen;
        btnLichSuDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnLichSuDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btnLichSuDon.Location = new System.Drawing.Point(3, 121);
        btnLichSuDon.Name = "btnLichSuDon";
        btnLichSuDon.Size = new System.Drawing.Size(222, 53);
        btnLichSuDon.TabIndex = 6;
        btnLichSuDon.Text = "Lịch Sử Đơn";
        btnLichSuDon.UseVisualStyleBackColor = false;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 1;
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.Controls.Add(btnDangXuat, 0, 2);
        tableLayoutPanel4.Controls.Add(label2, 0, 0);
        tableLayoutPanel4.Controls.Add(btnNguoiDung, 0, 1);
        tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel4.Location = new System.Drawing.Point(3, 526);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 3;
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.802467F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.19753F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
        tableLayoutPanel4.Size = new System.Drawing.Size(228, 151);
        tableLayoutPanel4.TabIndex = 2;
        // 
        // btnDangXuat
        // 
        btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btnDangXuat.AutoEllipsis = true;
        btnDangXuat.BackColor = System.Drawing.Color.Red;
        btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnDangXuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btnDangXuat.Location = new System.Drawing.Point(3, 84);
        btnDangXuat.Name = "btnDangXuat";
        btnDangXuat.Size = new System.Drawing.Size(222, 64);
        btnDangXuat.TabIndex = 2;
        btnDangXuat.Text = "Đăng Xuất";
        btnDangXuat.UseVisualStyleBackColor = false;
        // 
        // label2
        // 
        label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
        label2.Location = new System.Drawing.Point(3, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(222, 29);
        label2.TabIndex = 0;
        label2.Text = "Đang đăng nhập";
        label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // btnNguoiDung
        // 
        btnNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btnNguoiDung.AutoEllipsis = true;
        btnNguoiDung.BackColor = System.Drawing.Color.DarkGreen;
        btnNguoiDung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnNguoiDung.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btnNguoiDung.Location = new System.Drawing.Point(3, 32);
        btnNguoiDung.Name = "btnNguoiDung";
        btnNguoiDung.Size = new System.Drawing.Size(222, 46);
        btnNguoiDung.TabIndex = 1;
        btnNguoiDung.Text = "Tên Người Dùng";
        btnNguoiDung.UseVisualStyleBackColor = false;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1056, 686);
        Controls.Add(panel1);
        Cursor = System.Windows.Forms.Cursors.IBeam;
        Text = "MainForm";
        WindowState = System.Windows.Forms.FormWindowState.Maximized;
        Load += MainForm_Load;
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        panel3.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        tableLayoutPanel4.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnDangXuat;

    private System.Windows.Forms.Button btnNguoiDung;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

    private System.Windows.Forms.Button btnLichSuDon;

    private System.Windows.Forms.Button btBanHang;
    private System.Windows.Forms.Button btSanPham;
    private System.Windows.Forms.Button btNhapKho;
    private System.Windows.Forms.Button btCanhBao;
    private System.Windows.Forms.Button btBaoCao;
    private System.Windows.Forms.Button btTaiKhoan;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Panel manHinh;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.Panel panel1;

    #endregion
}
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
        components = new System.ComponentModel.Container();
        panel1 = new System.Windows.Forms.Panel();
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        manHinh = new System.Windows.Forms.Panel();
        panel3 = new System.Windows.Forms.Panel();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        lblTenUngDung = new System.Windows.Forms.Label();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        btBanHang = new System.Windows.Forms.Button();
        btnLichSuDon = new System.Windows.Forms.Button();
        btSanPham = new System.Windows.Forms.Button();
        btNhapKho = new System.Windows.Forms.Button();
        btnLichSuNhapKho = new System.Windows.Forms.Button();
        btCanhBao = new System.Windows.Forms.Button();
        btBaoCao = new System.Windows.Forms.Button();
        btTaiKhoan = new System.Windows.Forms.Button();
        btnKhachHang = new System.Windows.Forms.Button();
        btnLichSuHoatDong = new System.Windows.Forms.Button();
        btnHanSuDung = new System.Windows.Forms.Button();
        btnKhuyenMai = new System.Windows.Forms.Button();
        btnQuanLyCa = new System.Windows.Forms.Button();
        tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
        btnDangXuat = new System.Windows.Forms.Button();
        lblDangDangNhap = new System.Windows.Forms.Label();
        btnNguoiDung = new System.Windows.Forms.Button();
        toolTip1 = new System.Windows.Forms.ToolTip(components);
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
        panel1.Size = new System.Drawing.Size(1264, 807);
        panel1.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(manHinh, 1, 0);
        tableLayoutPanel1.Controls.Add(panel3, 0, 0);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new System.Drawing.Size(1264, 807);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // manHinh
        // 
        manHinh.Dock = System.Windows.Forms.DockStyle.Fill;
        manHinh.Location = new System.Drawing.Point(247, 3);
        manHinh.Name = "manHinh";
        manHinh.Size = new System.Drawing.Size(1014, 801);
        manHinh.TabIndex = 0;
        // 
        // panel3
        // 
        panel3.BackColor = System.Drawing.Color.Navy;
        panel3.Controls.Add(tableLayoutPanel2);
        panel3.Dock = System.Windows.Forms.DockStyle.Fill;
        panel3.Location = new System.Drawing.Point(3, 3);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(238, 801);
        panel3.TabIndex = 1;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.BackColor = System.Drawing.Color.Navy;
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel2.Controls.Add(lblTenUngDung, 0, 0);
        tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
        tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 2);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
        tableLayoutPanel2.RowCount = 3;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
        tableLayoutPanel2.Size = new System.Drawing.Size(238, 801);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // lblTenUngDung
        // 
        lblTenUngDung.Anchor = System.Windows.Forms.AnchorStyles.None;
        lblTenUngDung.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTenUngDung.ForeColor = System.Drawing.Color.White;
        lblTenUngDung.Location = new System.Drawing.Point(39, 29);
        lblTenUngDung.Name = "lblTenUngDung";
        lblTenUngDung.Size = new System.Drawing.Size(160, 36);
        lblTenUngDung.TabIndex = 0;
        lblTenUngDung.Text = "MiniMart\r\n";
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.AutoScroll = true;
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel3.Controls.Add(btBanHang, 0, 0);
        tableLayoutPanel3.Controls.Add(btTaiKhoan, 0, 12);
        tableLayoutPanel3.Controls.Add(btnLichSuHoatDong, 0, 11);
        tableLayoutPanel3.Controls.Add(btNhapKho, 0, 6);
        tableLayoutPanel3.Controls.Add(btnLichSuDon, 0, 1);
        tableLayoutPanel3.Controls.Add(btnKhuyenMai, 0, 2);
        tableLayoutPanel3.Controls.Add(btnQuanLyCa, 0, 3);
        tableLayoutPanel3.Controls.Add(btnKhachHang, 0, 4);
        tableLayoutPanel3.Controls.Add(btSanPham, 0, 5);
        tableLayoutPanel3.Controls.Add(btnLichSuNhapKho, 0, 7);
        tableLayoutPanel3.Controls.Add(btnHanSuDung, 0, 10);
        tableLayoutPanel3.Controls.Add(btCanhBao, 0, 9);
        tableLayoutPanel3.Controls.Add(btBaoCao, 0, 8);
        tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel3.Location = new System.Drawing.Point(11, 91);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 13;
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
        tableLayoutPanel3.Size = new System.Drawing.Size(216, 551);
        tableLayoutPanel3.TabIndex = 1;
        // 
        // btBanHang
        // 
        btBanHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btBanHang.BackColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)0)), ((int)((byte)192)));
        btBanHang.Cursor = System.Windows.Forms.Cursors.Hand;
        btBanHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btBanHang.ForeColor = System.Drawing.Color.White;
        btBanHang.Location = new System.Drawing.Point(3, 3);
        btBanHang.Name = "btBanHang";
        btBanHang.Size = new System.Drawing.Size(210, 36);
        btBanHang.TabIndex = 0;
        btBanHang.Text = "Bán hàng";
        btBanHang.UseVisualStyleBackColor = false;
        // 
        // btnLichSuDon
        // 
        btnLichSuDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btnLichSuDon.BackColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)0)), ((int)((byte)192)));
        btnLichSuDon.Cursor = System.Windows.Forms.Cursors.Hand;
        btnLichSuDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnLichSuDon.ForeColor = System.Drawing.Color.White;
        btnLichSuDon.Location = new System.Drawing.Point(3, 45);
        btnLichSuDon.Name = "btnLichSuDon";
        btnLichSuDon.Size = new System.Drawing.Size(210, 36);
        btnLichSuDon.TabIndex = 1;
        btnLichSuDon.Text = "Lịch sử đơn";
        btnLichSuDon.UseVisualStyleBackColor = false;
        // 
        // btSanPham
        // 
        btSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btSanPham.BackColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)0)), ((int)((byte)192)));
        btSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
        btSanPham.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btSanPham.ForeColor = System.Drawing.Color.White;
        btSanPham.Location = new System.Drawing.Point(3, 213);
        btSanPham.Name = "btSanPham";
        btSanPham.Size = new System.Drawing.Size(210, 36);
        btSanPham.TabIndex = 2;
        btSanPham.Text = "Sản phẩm";
        btSanPham.UseVisualStyleBackColor = false;
        // 
        // btNhapKho
        // 
        btNhapKho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)0)), ((int)((byte)192)));
        btNhapKho.Cursor = System.Windows.Forms.Cursors.Hand;
        btNhapKho.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btNhapKho.ForeColor = System.Drawing.Color.White;
        btNhapKho.Location = new System.Drawing.Point(3, 255);
        btNhapKho.Name = "btNhapKho";
        btNhapKho.Size = new System.Drawing.Size(210, 36);
        btNhapKho.TabIndex = 3;
        btNhapKho.Text = "Nhập kho";
        btNhapKho.UseVisualStyleBackColor = false;
        // 
        // btnLichSuNhapKho
        // 
        btnLichSuNhapKho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btnLichSuNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)0)), ((int)((byte)192)));
        btnLichSuNhapKho.Cursor = System.Windows.Forms.Cursors.Hand;
        btnLichSuNhapKho.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnLichSuNhapKho.ForeColor = System.Drawing.Color.White;
        btnLichSuNhapKho.Location = new System.Drawing.Point(3, 297);
        btnLichSuNhapKho.Name = "btnLichSuNhapKho";
        btnLichSuNhapKho.Size = new System.Drawing.Size(210, 36);
        btnLichSuNhapKho.TabIndex = 4;
        btnLichSuNhapKho.Text = "Lịch sử nhập";
        btnLichSuNhapKho.UseVisualStyleBackColor = false;
        // 
        // btCanhBao
        // 
        btCanhBao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btCanhBao.BackColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)0)), ((int)((byte)192)));
        btCanhBao.Cursor = System.Windows.Forms.Cursors.Hand;
        btCanhBao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btCanhBao.ForeColor = System.Drawing.Color.White;
        btCanhBao.Location = new System.Drawing.Point(3, 381);
        btCanhBao.Name = "btCanhBao";
        btCanhBao.Size = new System.Drawing.Size(210, 36);
        btCanhBao.TabIndex = 5;
        btCanhBao.Text = "Cảnh báo tồn kho";
        btCanhBao.UseVisualStyleBackColor = false;
        // 
        // btBaoCao
        // 
        btBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)0)), ((int)((byte)192)));
        btBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
        btBaoCao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btBaoCao.ForeColor = System.Drawing.Color.White;
        btBaoCao.Location = new System.Drawing.Point(3, 339);
        btBaoCao.Name = "btBaoCao";
        btBaoCao.Size = new System.Drawing.Size(210, 36);
        btBaoCao.TabIndex = 6;
        btBaoCao.Text = "Báo cáo";
        btBaoCao.UseVisualStyleBackColor = false;
        // 
        // btTaiKhoan
        // 
        btTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)0)), ((int)((byte)192)));
        btTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
        btTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btTaiKhoan.ForeColor = System.Drawing.Color.White;
        btTaiKhoan.Location = new System.Drawing.Point(3, 507);
        btTaiKhoan.Name = "btTaiKhoan";
        btTaiKhoan.Size = new System.Drawing.Size(210, 41);
        btTaiKhoan.TabIndex = 7;
        btTaiKhoan.Text = "Tài khoản";
        btTaiKhoan.UseVisualStyleBackColor = false;
        // 
        // btnKhachHang
        // 
        btnKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btnKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)0)), ((int)((byte)192)));
        btnKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
        btnKhachHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnKhachHang.ForeColor = System.Drawing.Color.White;
        btnKhachHang.Location = new System.Drawing.Point(3, 171);
        btnKhachHang.Name = "btnKhachHang";
        btnKhachHang.Size = new System.Drawing.Size(210, 36);
        btnKhachHang.TabIndex = 8;
        btnKhachHang.Text = "Khách hàng";
        btnKhachHang.UseVisualStyleBackColor = false;
        // 
        // btnLichSuHoatDong
        // 
        btnLichSuHoatDong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btnLichSuHoatDong.BackColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)0)), ((int)((byte)192)));
        btnLichSuHoatDong.Cursor = System.Windows.Forms.Cursors.Hand;
        btnLichSuHoatDong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnLichSuHoatDong.ForeColor = System.Drawing.Color.White;
        btnLichSuHoatDong.Location = new System.Drawing.Point(3, 465);
        btnLichSuHoatDong.Name = "btnLichSuHoatDong";
        btnLichSuHoatDong.Size = new System.Drawing.Size(210, 36);
        btnLichSuHoatDong.TabIndex = 9;
        btnLichSuHoatDong.Text = "Nhật ký hoạt động";
        btnLichSuHoatDong.UseVisualStyleBackColor = false;
        // 
        // btnHanSuDung
        // 
        btnHanSuDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btnHanSuDung.BackColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)0)), ((int)((byte)192)));
        btnHanSuDung.Cursor = System.Windows.Forms.Cursors.Hand;
        btnHanSuDung.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnHanSuDung.ForeColor = System.Drawing.Color.White;
        btnHanSuDung.Location = new System.Drawing.Point(3, 423);
        btnHanSuDung.Name = "btnHanSuDung";
        btnHanSuDung.Size = new System.Drawing.Size(210, 36);
        btnHanSuDung.TabIndex = 10;
        btnHanSuDung.Text = "Hạn sử dụng";
        btnHanSuDung.UseVisualStyleBackColor = false;
        // 
        // btnKhuyenMai
        // 
        btnKhuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btnKhuyenMai.BackColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)0)), ((int)((byte)192)));
        btnKhuyenMai.Cursor = System.Windows.Forms.Cursors.Hand;
        btnKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnKhuyenMai.ForeColor = System.Drawing.Color.White;
        btnKhuyenMai.Location = new System.Drawing.Point(3, 87);
        btnKhuyenMai.Name = "btnKhuyenMai";
        btnKhuyenMai.Size = new System.Drawing.Size(210, 36);
        btnKhuyenMai.TabIndex = 11;
        btnKhuyenMai.Text = "Khuyến mãi";
        btnKhuyenMai.UseVisualStyleBackColor = false;
        // 
        // btnQuanLyCa
        // 
        btnQuanLyCa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btnQuanLyCa.BackColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)0)), ((int)((byte)192)));
        btnQuanLyCa.Cursor = System.Windows.Forms.Cursors.Hand;
        btnQuanLyCa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnQuanLyCa.ForeColor = System.Drawing.Color.White;
        btnQuanLyCa.Location = new System.Drawing.Point(3, 129);
        btnQuanLyCa.Name = "btnQuanLyCa";
        btnQuanLyCa.Size = new System.Drawing.Size(210, 36);
        btnQuanLyCa.TabIndex = 12;
        btnQuanLyCa.Text = "Quản lý ca";
        btnQuanLyCa.UseVisualStyleBackColor = false;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 1;
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.Controls.Add(btnDangXuat, 0, 2);
        tableLayoutPanel4.Controls.Add(lblDangDangNhap, 0, 0);
        tableLayoutPanel4.Controls.Add(btnNguoiDung, 0, 1);
        tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel4.Location = new System.Drawing.Point(11, 648);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 3;
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.802467F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.19753F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
        tableLayoutPanel4.Size = new System.Drawing.Size(216, 144);
        tableLayoutPanel4.TabIndex = 2;
        // 
        // btnDangXuat
        // 
        btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btnDangXuat.AutoEllipsis = true;
        btnDangXuat.BackColor = System.Drawing.Color.Red;
        btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnDangXuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btnDangXuat.Location = new System.Drawing.Point(3, 94);
        btnDangXuat.Name = "btnDangXuat";
        btnDangXuat.Size = new System.Drawing.Size(210, 47);
        btnDangXuat.TabIndex = 2;
        btnDangXuat.Text = "Đăng Xuất";
        btnDangXuat.UseVisualStyleBackColor = false;
        // 
        // lblDangDangNhap
        // 
        lblDangDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblDangDangNhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        lblDangDangNhap.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
        lblDangDangNhap.Location = new System.Drawing.Point(3, 0);
        lblDangDangNhap.Name = "lblDangDangNhap";
        lblDangDangNhap.Size = new System.Drawing.Size(210, 32);
        lblDangDangNhap.TabIndex = 0;
        lblDangDangNhap.Text = "Đang đăng nhập";
        lblDangDangNhap.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // btnNguoiDung
        // 
        btnNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        btnNguoiDung.AutoEllipsis = true;
        btnNguoiDung.BackColor = System.Drawing.Color.RoyalBlue;
        btnNguoiDung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnNguoiDung.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btnNguoiDung.Location = new System.Drawing.Point(3, 35);
        btnNguoiDung.Name = "btnNguoiDung";
        btnNguoiDung.Size = new System.Drawing.Size(210, 53);
        btnNguoiDung.TabIndex = 1;
        btnNguoiDung.Text = "Tên Người Dùng";
        toolTip1.SetToolTip(btnNguoiDung, "Xem thông tin tài khoản và đổi mật khẩu");
        btnNguoiDung.UseVisualStyleBackColor = false;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1264, 807);
        Controls.Add(panel1);
        MinimumSize = new System.Drawing.Size(1120, 720);
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

    private System.Windows.Forms.Label lblDangDangNhap;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

    private System.Windows.Forms.Button btnLichSuDon;

    private System.Windows.Forms.Button btBanHang;
    private System.Windows.Forms.Button btSanPham;
    private System.Windows.Forms.Button btNhapKho;
    private System.Windows.Forms.Button btCanhBao;
    private System.Windows.Forms.Button btBaoCao;
    private System.Windows.Forms.Button btTaiKhoan;
    private System.Windows.Forms.Button btnLichSuNhapKho;
    private System.Windows.Forms.Button btnKhachHang;
    private System.Windows.Forms.Button btnLichSuHoatDong;
    private System.Windows.Forms.Button btnHanSuDung;
    private System.Windows.Forms.Button btnKhuyenMai;
    private System.Windows.Forms.Button btnQuanLyCa;
    private System.Windows.Forms.ToolTip toolTip1;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    private System.Windows.Forms.Label lblTenUngDung;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Panel manHinh;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.Panel panel1;

    #endregion
}
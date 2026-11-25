using System.ComponentModel;

namespace MiniMart.Forms;

partial class FormKhuyenMai
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
        grpKhuyenMai = new System.Windows.Forms.GroupBox();
        tlpKhuyenMai = new System.Windows.Forms.TableLayoutPanel();
        lblMaKhuyenMai = new System.Windows.Forms.Label();
        lblTenKhuyenMai = new System.Windows.Forms.Label();
        lblLoaiGiam = new System.Windows.Forms.Label();
        lblGiaTriGiam = new System.Windows.Forms.Label();
        txtMaKhuyenMai = new System.Windows.Forms.TextBox();
        txtTenKhuyenMai = new System.Windows.Forms.TextBox();
        cboLoaiGiam = new System.Windows.Forms.ComboBox();
        nudGiaTriGiam = new System.Windows.Forms.NumericUpDown();
        lblDonToiThieu = new System.Windows.Forms.Label();
        lblTuNgay = new System.Windows.Forms.Label();
        lblDenNgay = new System.Windows.Forms.Label();
        nudDonToiThieu = new System.Windows.Forms.NumericUpDown();
        dtpTuNgay = new System.Windows.Forms.DateTimePicker();
        dtpDenNgay = new System.Windows.Forms.DateTimePicker();
        chkDangHoatDong = new System.Windows.Forms.CheckBox();
        flpNutLenh = new System.Windows.Forms.FlowLayoutPanel();
        btnLuu = new System.Windows.Forms.Button();
        btnTaoMoi = new System.Windows.Forms.Button();
        btnXoa = new System.Windows.Forms.Button();
        tlpTimKiem = new System.Windows.Forms.TableLayoutPanel();
        lblTimKiem = new System.Windows.Forms.Label();
        txtTimKiem = new System.Windows.Forms.TextBox();
        btnTim = new System.Windows.Forms.Button();
        btnLamMoiDanhSach = new System.Windows.Forms.Button();
        dgvKhuyenMai = new System.Windows.Forms.DataGridView();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        grpKhuyenMai.SuspendLayout();
        tlpKhuyenMai.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudGiaTriGiam).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudDonToiThieu).BeginInit();
        flpNutLenh.SuspendLayout();
        tlpTimKiem.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvKhuyenMai).BeginInit();
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
        tableLayoutPanel1.Controls.Add(grpKhuyenMai, 0, 1);
        tableLayoutPanel1.Controls.Add(tlpTimKiem, 0, 2);
        tableLayoutPanel1.Controls.Add(dgvKhuyenMai, 0, 3);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.Size = new System.Drawing.Size(968, 100);
        tableLayoutPanel1.TabIndex = 0;
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
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
        lblTieuDe.Text = "QUẢN LÝ KHUYẾN MÃI";
        lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // grpKhuyenMai
        // 
        grpKhuyenMai.Controls.Add(tlpKhuyenMai);
        grpKhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill;
        grpKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        grpKhuyenMai.ForeColor = System.Drawing.Color.Navy;
        grpKhuyenMai.Location = new System.Drawing.Point(3, 3);
        grpKhuyenMai.Name = "grpKhuyenMai";
        grpKhuyenMai.Size = new System.Drawing.Size(968, 150);
        grpKhuyenMai.TabIndex = 1;
        grpKhuyenMai.TabStop = false;
        grpKhuyenMai.Text = "Thông tin chương trình";
        // 
        // tlpKhuyenMai
        // 
        tlpKhuyenMai.ColumnCount = 4;
        tlpKhuyenMai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tlpKhuyenMai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tlpKhuyenMai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tlpKhuyenMai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tlpKhuyenMai.Controls.Add(lblMaKhuyenMai, 0, 0);
        tlpKhuyenMai.Controls.Add(lblTenKhuyenMai, 1, 0);
        tlpKhuyenMai.Controls.Add(lblLoaiGiam, 2, 0);
        tlpKhuyenMai.Controls.Add(lblGiaTriGiam, 3, 0);
        tlpKhuyenMai.Controls.Add(txtMaKhuyenMai, 0, 1);
        tlpKhuyenMai.Controls.Add(txtTenKhuyenMai, 1, 1);
        tlpKhuyenMai.Controls.Add(cboLoaiGiam, 2, 1);
        tlpKhuyenMai.Controls.Add(nudGiaTriGiam, 3, 1);
        tlpKhuyenMai.Controls.Add(lblDonToiThieu, 0, 2);
        tlpKhuyenMai.Controls.Add(lblTuNgay, 1, 2);
        tlpKhuyenMai.Controls.Add(lblDenNgay, 2, 2);
        tlpKhuyenMai.Controls.Add(nudDonToiThieu, 0, 3);
        tlpKhuyenMai.Controls.Add(dtpTuNgay, 1, 3);
        tlpKhuyenMai.Controls.Add(dtpDenNgay, 2, 3);
        tlpKhuyenMai.Controls.Add(chkDangHoatDong, 3, 3);
        tlpKhuyenMai.Controls.Add(flpNutLenh, 0, 4);
        tlpKhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpKhuyenMai.Location = new System.Drawing.Point(3, 3);
        tlpKhuyenMai.Name = "tlpKhuyenMai";
        tlpKhuyenMai.Size = new System.Drawing.Size(968, 100);
        tlpKhuyenMai.TabIndex = 0;
        tlpKhuyenMai.RowCount = 5;
        tlpKhuyenMai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
        tlpKhuyenMai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
        tlpKhuyenMai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
        tlpKhuyenMai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
        tlpKhuyenMai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpKhuyenMai.SetColumnSpan(flpNutLenh, 4);
        // 
        // lblMaKhuyenMai
        // 
        lblMaKhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill;
        lblMaKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblMaKhuyenMai.Location = new System.Drawing.Point(3, 0);
        lblMaKhuyenMai.Name = "lblMaKhuyenMai";
        lblMaKhuyenMai.Size = new System.Drawing.Size(180, 26);
        lblMaKhuyenMai.TabIndex = 0;
        lblMaKhuyenMai.Text = "Mã khuyến mãi";
        lblMaKhuyenMai.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // lblTenKhuyenMai
        // 
        lblTenKhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTenKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTenKhuyenMai.Location = new System.Drawing.Point(3, 0);
        lblTenKhuyenMai.Name = "lblTenKhuyenMai";
        lblTenKhuyenMai.Size = new System.Drawing.Size(180, 26);
        lblTenKhuyenMai.TabIndex = 1;
        lblTenKhuyenMai.Text = "Tên chương trình";
        lblTenKhuyenMai.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // lblLoaiGiam
        // 
        lblLoaiGiam.Dock = System.Windows.Forms.DockStyle.Fill;
        lblLoaiGiam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblLoaiGiam.Location = new System.Drawing.Point(3, 0);
        lblLoaiGiam.Name = "lblLoaiGiam";
        lblLoaiGiam.Size = new System.Drawing.Size(180, 26);
        lblLoaiGiam.TabIndex = 2;
        lblLoaiGiam.Text = "Hình thức giảm";
        lblLoaiGiam.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // lblGiaTriGiam
        // 
        lblGiaTriGiam.Dock = System.Windows.Forms.DockStyle.Fill;
        lblGiaTriGiam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblGiaTriGiam.Location = new System.Drawing.Point(3, 0);
        lblGiaTriGiam.Name = "lblGiaTriGiam";
        lblGiaTriGiam.Size = new System.Drawing.Size(180, 26);
        lblGiaTriGiam.TabIndex = 3;
        lblGiaTriGiam.Text = "Giá trị giảm";
        lblGiaTriGiam.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // txtMaKhuyenMai
        // 
        txtMaKhuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtMaKhuyenMai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        txtMaKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtMaKhuyenMai.Location = new System.Drawing.Point(3, 3);
        txtMaKhuyenMai.MaxLength = 30;
        txtMaKhuyenMai.Name = "txtMaKhuyenMai";
        txtMaKhuyenMai.PlaceholderText = "VD: SALE10";
        txtMaKhuyenMai.Size = new System.Drawing.Size(180, 30);
        txtMaKhuyenMai.TabIndex = 4;
        // 
        // txtTenKhuyenMai
        // 
        txtTenKhuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtTenKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtTenKhuyenMai.Location = new System.Drawing.Point(3, 3);
        txtTenKhuyenMai.MaxLength = 100;
        txtTenKhuyenMai.Name = "txtTenKhuyenMai";
        txtTenKhuyenMai.PlaceholderText = "Tên chương trình";
        txtTenKhuyenMai.Size = new System.Drawing.Size(180, 30);
        txtTenKhuyenMai.TabIndex = 5;
        // 
        // cboLoaiGiam
        // 
        cboLoaiGiam.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        cboLoaiGiam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboLoaiGiam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cboLoaiGiam.FormattingEnabled = true;
        cboLoaiGiam.Location = new System.Drawing.Point(3, 3);
        cboLoaiGiam.Name = "cboLoaiGiam";
        cboLoaiGiam.Size = new System.Drawing.Size(180, 31);
        cboLoaiGiam.TabIndex = 6;
        // 
        // nudGiaTriGiam
        // 
        nudGiaTriGiam.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        nudGiaTriGiam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        nudGiaTriGiam.Location = new System.Drawing.Point(3, 3);
        nudGiaTriGiam.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
        nudGiaTriGiam.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudGiaTriGiam.Name = "nudGiaTriGiam";
        nudGiaTriGiam.Size = new System.Drawing.Size(180, 30);
        nudGiaTriGiam.TabIndex = 7;
        nudGiaTriGiam.ThousandsSeparator = true;
        nudGiaTriGiam.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblDonToiThieu
        // 
        lblDonToiThieu.Dock = System.Windows.Forms.DockStyle.Fill;
        lblDonToiThieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblDonToiThieu.Location = new System.Drawing.Point(3, 0);
        lblDonToiThieu.Name = "lblDonToiThieu";
        lblDonToiThieu.Size = new System.Drawing.Size(180, 26);
        lblDonToiThieu.TabIndex = 8;
        lblDonToiThieu.Text = "Đơn tối thiểu";
        lblDonToiThieu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // lblTuNgay
        // 
        lblTuNgay.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTuNgay.Location = new System.Drawing.Point(3, 0);
        lblTuNgay.Name = "lblTuNgay";
        lblTuNgay.Size = new System.Drawing.Size(180, 26);
        lblTuNgay.TabIndex = 9;
        lblTuNgay.Text = "Từ ngày";
        lblTuNgay.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // lblDenNgay
        // 
        lblDenNgay.Dock = System.Windows.Forms.DockStyle.Fill;
        lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblDenNgay.Location = new System.Drawing.Point(3, 0);
        lblDenNgay.Name = "lblDenNgay";
        lblDenNgay.Size = new System.Drawing.Size(180, 26);
        lblDenNgay.TabIndex = 10;
        lblDenNgay.Text = "Đến ngày";
        lblDenNgay.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // nudDonToiThieu
        // 
        nudDonToiThieu.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        nudDonToiThieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        nudDonToiThieu.Location = new System.Drawing.Point(3, 3);
        nudDonToiThieu.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
        nudDonToiThieu.Name = "nudDonToiThieu";
        nudDonToiThieu.Size = new System.Drawing.Size(180, 30);
        nudDonToiThieu.TabIndex = 11;
        nudDonToiThieu.ThousandsSeparator = true;
        // 
        // dtpTuNgay
        // 
        dtpTuNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpTuNgay.Location = new System.Drawing.Point(3, 3);
        dtpTuNgay.Name = "dtpTuNgay";
        dtpTuNgay.Size = new System.Drawing.Size(180, 30);
        dtpTuNgay.TabIndex = 12;
        // 
        // dtpDenNgay
        // 
        dtpDenNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpDenNgay.Location = new System.Drawing.Point(3, 3);
        dtpDenNgay.Name = "dtpDenNgay";
        dtpDenNgay.Size = new System.Drawing.Size(180, 30);
        dtpDenNgay.TabIndex = 13;
        // 
        // chkDangHoatDong
        // 
        chkDangHoatDong.Anchor = System.Windows.Forms.AnchorStyles.Left;
        chkDangHoatDong.AutoSize = true;
        chkDangHoatDong.Checked = true;
        chkDangHoatDong.CheckState = System.Windows.Forms.CheckState.Checked;
        chkDangHoatDong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        chkDangHoatDong.Location = new System.Drawing.Point(3, 3);
        chkDangHoatDong.Name = "chkDangHoatDong";
        chkDangHoatDong.Size = new System.Drawing.Size(150, 27);
        chkDangHoatDong.TabIndex = 14;
        chkDangHoatDong.Text = "Đang hoạt động";
        chkDangHoatDong.UseVisualStyleBackColor = true;
        // 
        // flpNutLenh
        // 
        flpNutLenh.Controls.Add(btnLuu);
        flpNutLenh.Controls.Add(btnTaoMoi);
        flpNutLenh.Controls.Add(btnXoa);
        flpNutLenh.Dock = System.Windows.Forms.DockStyle.Fill;
        flpNutLenh.Location = new System.Drawing.Point(3, 3);
        flpNutLenh.Name = "flpNutLenh";
        flpNutLenh.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
        flpNutLenh.Size = new System.Drawing.Size(960, 44);
        flpNutLenh.TabIndex = 15;
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
        btnLuu.Size = new System.Drawing.Size(180, 38);
        btnLuu.TabIndex = 0;
        btnLuu.Text = "Lưu chương trình";
        btnLuu.UseVisualStyleBackColor = false;
        // 
        // btnTaoMoi
        // 
        btnTaoMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnTaoMoi.BackColor = System.Drawing.Color.Navy;
        btnTaoMoi.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTaoMoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTaoMoi.ForeColor = System.Drawing.Color.White;
        btnTaoMoi.Location = new System.Drawing.Point(3, 3);
        btnTaoMoi.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
        btnTaoMoi.Name = "btnTaoMoi";
        btnTaoMoi.Size = new System.Drawing.Size(120, 38);
        btnTaoMoi.TabIndex = 1;
        btnTaoMoi.Text = "Tạo mới";
        btnTaoMoi.UseVisualStyleBackColor = false;
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
        btnXoa.Size = new System.Drawing.Size(110, 38);
        btnXoa.TabIndex = 2;
        btnXoa.Text = "Xóa mã";
        btnXoa.UseVisualStyleBackColor = false;
        // 
        // tlpTimKiem
        // 
        tlpTimKiem.ColumnCount = 5;
        tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
        tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
        tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
        tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
        tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
        tlpTimKiem.Controls.Add(lblTimKiem, 0, 0);
        tlpTimKiem.Controls.Add(txtTimKiem, 1, 0);
        tlpTimKiem.Controls.Add(btnTim, 2, 0);
        tlpTimKiem.Controls.Add(btnLamMoiDanhSach, 3, 0);
        tlpTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpTimKiem.Location = new System.Drawing.Point(3, 3);
        tlpTimKiem.Name = "tlpTimKiem";
        tlpTimKiem.Size = new System.Drawing.Size(968, 100);
        tlpTimKiem.TabIndex = 2;
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
        lblTimKiem.Text = "Tìm nhanh:";
        lblTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // txtTimKiem
        // 
        txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtTimKiem.Location = new System.Drawing.Point(3, 3);
        txtTimKiem.MaxLength = 100;
        txtTimKiem.Name = "txtTimKiem";
        txtTimKiem.PlaceholderText = "Tìm mã hoặc tên chương trình...";
        txtTimKiem.Size = new System.Drawing.Size(180, 30);
        txtTimKiem.TabIndex = 1;
        // 
        // btnTim
        // 
        btnTim.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnTim.BackColor = System.Drawing.Color.Navy;
        btnTim.Cursor = System.Windows.Forms.Cursors.Hand;
        btnTim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTim.ForeColor = System.Drawing.Color.White;
        btnTim.Location = new System.Drawing.Point(3, 3);
        btnTim.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
        btnTim.Name = "btnTim";
        btnTim.Size = new System.Drawing.Size(100, 38);
        btnTim.TabIndex = 2;
        btnTim.Text = "Tìm";
        btnTim.UseVisualStyleBackColor = false;
        // 
        // btnLamMoiDanhSach
        // 
        btnLamMoiDanhSach.Anchor = System.Windows.Forms.AnchorStyles.None;
        btnLamMoiDanhSach.BackColor = System.Drawing.Color.Navy;
        btnLamMoiDanhSach.Cursor = System.Windows.Forms.Cursors.Hand;
        btnLamMoiDanhSach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnLamMoiDanhSach.ForeColor = System.Drawing.Color.White;
        btnLamMoiDanhSach.Location = new System.Drawing.Point(3, 3);
        btnLamMoiDanhSach.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
        btnLamMoiDanhSach.Name = "btnLamMoiDanhSach";
        btnLamMoiDanhSach.Size = new System.Drawing.Size(190, 38);
        btnLamMoiDanhSach.TabIndex = 3;
        btnLamMoiDanhSach.Text = "Làm mới danh sách";
        btnLamMoiDanhSach.UseVisualStyleBackColor = false;
        // 
        // dgvKhuyenMai
        // 
        dgvKhuyenMai.AllowUserToAddRows = false;
        dgvKhuyenMai.AllowUserToDeleteRows = false;
        dgvKhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvKhuyenMai.BackgroundColor = System.Drawing.Color.White;
        dgvKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvKhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvKhuyenMai.Location = new System.Drawing.Point(3, 3);
        dgvKhuyenMai.MultiSelect = false;
        dgvKhuyenMai.Name = "dgvKhuyenMai";
        dgvKhuyenMai.ReadOnly = true;
        dgvKhuyenMai.RowHeadersWidth = 51;
        dgvKhuyenMai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvKhuyenMai.Size = new System.Drawing.Size(968, 300);
        dgvKhuyenMai.TabIndex = 3;
        // 
        // FormKhuyenMai
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1000, 660);
        Controls.Add(panel1);
        Text = "Quản lý khuyến mãi";
        WindowState = System.Windows.Forms.FormWindowState.Maximized;
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        grpKhuyenMai.ResumeLayout(false);
        tlpKhuyenMai.ResumeLayout(false);
        tlpKhuyenMai.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudGiaTriGiam).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudDonToiThieu).EndInit();
        flpNutLenh.ResumeLayout(false);
        flpNutLenh.PerformLayout();
        tlpTimKiem.ResumeLayout(false);
        tlpTimKiem.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvKhuyenMai).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.GroupBox grpKhuyenMai;
    private System.Windows.Forms.TableLayoutPanel tlpKhuyenMai;
    private System.Windows.Forms.Label lblMaKhuyenMai;
    private System.Windows.Forms.Label lblTenKhuyenMai;
    private System.Windows.Forms.Label lblLoaiGiam;
    private System.Windows.Forms.Label lblGiaTriGiam;
    private System.Windows.Forms.TextBox txtMaKhuyenMai;
    private System.Windows.Forms.TextBox txtTenKhuyenMai;
    private System.Windows.Forms.ComboBox cboLoaiGiam;
    private System.Windows.Forms.NumericUpDown nudGiaTriGiam;
    private System.Windows.Forms.Label lblDonToiThieu;
    private System.Windows.Forms.Label lblTuNgay;
    private System.Windows.Forms.Label lblDenNgay;
    private System.Windows.Forms.NumericUpDown nudDonToiThieu;
    private System.Windows.Forms.DateTimePicker dtpTuNgay;
    private System.Windows.Forms.DateTimePicker dtpDenNgay;
    private System.Windows.Forms.CheckBox chkDangHoatDong;
    private System.Windows.Forms.FlowLayoutPanel flpNutLenh;
    private System.Windows.Forms.Button btnLuu;
    private System.Windows.Forms.Button btnTaoMoi;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.TableLayoutPanel tlpTimKiem;
    private System.Windows.Forms.Label lblTimKiem;
    private System.Windows.Forms.TextBox txtTimKiem;
    private System.Windows.Forms.Button btnTim;
    private System.Windows.Forms.Button btnLamMoiDanhSach;
    private System.Windows.Forms.DataGridView dgvKhuyenMai;

    #endregion
}

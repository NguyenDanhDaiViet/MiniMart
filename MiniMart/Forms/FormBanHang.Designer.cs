using System.ComponentModel;

namespace MiniMart.Forms;

partial class FormBanHang
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
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        panel1 = new System.Windows.Forms.Panel();
        lblDanhSachSP = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        lblGioHang = new System.Windows.Forms.Label();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        pnlTimKiem = new System.Windows.Forms.Panel();
        btnTimKiem = new System.Windows.Forms.Button();
        txtTimKiem = new System.Windows.Forms.TextBox();
        panel3 = new System.Windows.Forms.Panel();
        dgvSanPham = new System.Windows.Forms.DataGridView();
        pnlHeader = new System.Windows.Forms.Panel();
        lblTitle = new System.Windows.Forms.Label();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        pnlTimKiem.SuspendLayout();
        panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
        pnlHeader.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
        tableLayoutPanel1.Controls.Add(pnlHeader, 0, 0);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.680116F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.319885F));
        tableLayoutPanel1.Size = new System.Drawing.Size(1378, 694);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.005833F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.994167F));
        tableLayoutPanel2.Controls.Add(panel1, 0, 0);
        tableLayoutPanel2.Controls.Add(panel2, 1, 0);
        tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(3, 91);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.5F));
        tableLayoutPanel2.Size = new System.Drawing.Size(1372, 600);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.Controls.Add(lblDanhSachSP);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(3, 3);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(488, 39);
        panel1.TabIndex = 0;
        // 
        // lblDanhSachSP
        // 
        lblDanhSachSP.AutoSize = true;
        lblDanhSachSP.Dock = System.Windows.Forms.DockStyle.Fill;
        lblDanhSachSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblDanhSachSP.Location = new System.Drawing.Point(0, 0);
        lblDanhSachSP.Name = "lblDanhSachSP";
        lblDanhSachSP.Size = new System.Drawing.Size(248, 32);
        lblDanhSachSP.TabIndex = 0;
        lblDanhSachSP.Text = "Danh sách sản phẩm";
        // 
        // panel2
        // 
        panel2.Controls.Add(lblGioHang);
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(497, 3);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(872, 39);
        panel2.TabIndex = 1;
        // 
        // lblGioHang
        // 
        lblGioHang.AutoSize = true;
        lblGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
        lblGioHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblGioHang.Location = new System.Drawing.Point(0, 0);
        lblGioHang.Name = "lblGioHang";
        lblGioHang.Size = new System.Drawing.Size(117, 32);
        lblGioHang.TabIndex = 0;
        lblGioHang.Text = "Giỏ hàng";
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.94262F));
        tableLayoutPanel3.Controls.Add(pnlTimKiem, 0, 0);
        tableLayoutPanel3.Controls.Add(panel3, 0, 1);
        tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel3.Location = new System.Drawing.Point(3, 48);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 2;
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.468124F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.531876F));
        tableLayoutPanel3.Size = new System.Drawing.Size(488, 549);
        tableLayoutPanel3.TabIndex = 2;
        // 
        // pnlTimKiem
        // 
        pnlTimKiem.Controls.Add(btnTimKiem);
        pnlTimKiem.Controls.Add(txtTimKiem);
        pnlTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlTimKiem.Location = new System.Drawing.Point(3, 3);
        pnlTimKiem.Name = "pnlTimKiem";
        pnlTimKiem.Size = new System.Drawing.Size(482, 35);
        pnlTimKiem.TabIndex = 0;
        // 
        // btnTimKiem
        // 
        btnTimKiem.BackColor = System.Drawing.Color.DarkGreen;
        btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnTimKiem.ForeColor = System.Drawing.Color.White;
        btnTimKiem.Location = new System.Drawing.Point(392, 0);
        btnTimKiem.Name = "btnTimKiem";
        btnTimKiem.Size = new System.Drawing.Size(90, 35);
        btnTimKiem.TabIndex = 1;
        btnTimKiem.Text = "Tìm";
        btnTimKiem.UseVisualStyleBackColor = false;
        // 
        // txtTimKiem
        // 
        txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtTimKiem.Location = new System.Drawing.Point(3, 0);
        txtTimKiem.Name = "txtTimKiem";
        txtTimKiem.Size = new System.Drawing.Size(383, 34);
        txtTimKiem.TabIndex = 0;
        txtTimKiem.Text = "Nhập mã hoặc tên sản phẩm";
        // 
        // panel3
        // 
        panel3.Controls.Add(dgvSanPham);
        panel3.Dock = System.Windows.Forms.DockStyle.Fill;
        panel3.Location = new System.Drawing.Point(3, 44);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(482, 502);
        panel3.TabIndex = 1;
        // 
        // dgvSanPham
        // 
        dgvSanPham.AllowUserToAddRows = false;
        dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvSanPham.BackgroundColor = System.Drawing.Color.DarkGray;
        dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvSanPham.Location = new System.Drawing.Point(0, 0);
        dgvSanPham.Name = "dgvSanPham";
        dgvSanPham.ReadOnly = true;
        dgvSanPham.RowHeadersWidth = 62;
        dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvSanPham.Size = new System.Drawing.Size(482, 502);
        dgvSanPham.TabIndex = 0;
        dgvSanPham.Text = "dataGridView1";
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlHeader.Location = new System.Drawing.Point(3, 3);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new System.Drawing.Size(1372, 82);
        pnlHeader.TabIndex = 1;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTitle.ForeColor = System.Drawing.Color.DarkGreen;
        lblTitle.Location = new System.Drawing.Point(0, 15);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(239, 54);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "BÁN HÀNG";
        // 
        // FormBanHang
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.WhiteSmoke;
        ClientSize = new System.Drawing.Size(1378, 694);
        Controls.Add(tableLayoutPanel1);
        MinimumSize = new System.Drawing.Size(1100, 650);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "FormBanHang";
        WindowState = System.Windows.Forms.FormWindowState.Maximized;
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        tableLayoutPanel3.ResumeLayout(false);
        pnlTimKiem.ResumeLayout(false);
        pnlTimKiem.PerformLayout();
        panel3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dgvGioHang;

    private System.Windows.Forms.DataGridView dgvSanPham;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Button btnTimKiem;

    private System.Windows.Forms.TextBox txtTimKiem;

    private System.Windows.Forms.Panel pnlTimKiem;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    private System.Windows.Forms.Label lblGioHang;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Label lblDanhSachSP;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Label lblTitle;

    private System.Windows.Forms.Panel pnlHeader;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    #endregion
}
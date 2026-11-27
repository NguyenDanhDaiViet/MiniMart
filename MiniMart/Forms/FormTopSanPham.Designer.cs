using System.ComponentModel;

namespace MiniMart.Forms;

partial class FormTopSanPham
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
        panel2 = new System.Windows.Forms.Panel();
        lblTieuDe = new System.Windows.Forms.Label();
        panel3 = new System.Windows.Forms.Panel();
        lblTongKet = new System.Windows.Forms.Label();
        btnXem = new System.Windows.Forms.Button();
        cboHienThi = new System.Windows.Forms.ComboBox();
        lblHienThi = new System.Windows.Forms.Label();
        cboSapXep = new System.Windows.Forms.ComboBox();
        dtpDenNgay = new System.Windows.Forms.DateTimePicker();
        dtpTuNgay = new System.Windows.Forms.DateTimePicker();
        lblSapXep = new System.Windows.Forms.Label();
        lblDenNgay = new System.Windows.Forms.Label();
        lblTuNgay = new System.Windows.Forms.Label();
        dgvTop = new System.Windows.Forms.DataGridView();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTop).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(tableLayoutPanel1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(1022, 644);
        panel1.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(panel2, 0, 0);
        tableLayoutPanel1.Controls.Add(panel3, 0, 1);
        tableLayoutPanel1.Controls.Add(dgvTop, 0, 2);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.484472F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.608696F));
        tableLayoutPanel1.Size = new System.Drawing.Size(1022, 644);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.Color.White;
        panel2.Controls.Add(lblTieuDe);
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(3, 3);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(1016, 90);
        panel2.TabIndex = 0;
        // 
        // lblTieuDe
        // 
        lblTieuDe.AutoSize = true;
        lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 19.800001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTieuDe.ForeColor = System.Drawing.Color.Navy;
        lblTieuDe.Location = new System.Drawing.Point(35, 20);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new System.Drawing.Size(461, 46);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "TOP SẢN PHẨM BÁN CHẠY";
        // 
        // panel3
        // 
        panel3.Controls.Add(lblTongKet);
        panel3.Controls.Add(btnXem);
        panel3.Controls.Add(cboHienThi);
        panel3.Controls.Add(lblHienThi);
        panel3.Controls.Add(cboSapXep);
        panel3.Controls.Add(dtpDenNgay);
        panel3.Controls.Add(dtpTuNgay);
        panel3.Controls.Add(lblSapXep);
        panel3.Controls.Add(lblDenNgay);
        panel3.Controls.Add(lblTuNgay);
        panel3.Dock = System.Windows.Forms.DockStyle.Fill;
        panel3.Location = new System.Drawing.Point(3, 99);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(1016, 170);
        panel3.TabIndex = 1;
        // 
        // lblTongKet
        // 
        lblTongKet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblTongKet.AutoSize = true;
        lblTongKet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTongKet.ForeColor = System.Drawing.Color.Navy;
        lblTongKet.Location = new System.Drawing.Point(26, 138);
        lblTongKet.Name = "lblTongKet";
        lblTongKet.Size = new System.Drawing.Size(189, 23);
        lblTongKet.TabIndex = 9;
        lblTongKet.Text = "Hiển thị 0/0 sản phẩm";
        lblTongKet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btnXem
        // 
        btnXem.BackColor = System.Drawing.Color.Navy;
        btnXem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnXem.ForeColor = System.Drawing.Color.White;
        btnXem.Location = new System.Drawing.Point(717, 56);
        btnXem.Name = "btnXem";
        btnXem.Size = new System.Drawing.Size(121, 38);
        btnXem.TabIndex = 8;
        btnXem.Text = "Xem";
        btnXem.UseVisualStyleBackColor = false;
        // 
        // cboHienThi
        // 
        cboHienThi.FormattingEnabled = true;
        cboHienThi.Items.AddRange(new object[] { "Top 10", "Top 20", "Top 50", "Tất cả" });
        cboHienThi.Location = new System.Drawing.Point(519, 63);
        cboHienThi.Name = "cboHienThi";
        cboHienThi.Size = new System.Drawing.Size(167, 28);
        cboHienThi.TabIndex = 7;
        // 
        // lblHienThi
        // 
        lblHienThi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblHienThi.Location = new System.Drawing.Point(519, 21);
        lblHienThi.Name = "lblHienThi";
        lblHienThi.Size = new System.Drawing.Size(100, 23);
        lblHienThi.TabIndex = 6;
        lblHienThi.Text = "Hiển thị:";
        // 
        // cboSapXep
        // 
        cboSapXep.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cboSapXep.FormattingEnabled = true;
        cboSapXep.Items.AddRange(new object[] { "Doanh thu", "Số lượng bán" });
        cboSapXep.Location = new System.Drawing.Point(335, 63);
        cboSapXep.Name = "cboSapXep";
        cboSapXep.Size = new System.Drawing.Size(144, 31);
        cboSapXep.TabIndex = 5;
        // 
        // dtpDenNgay
        // 
        dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpDenNgay.Location = new System.Drawing.Point(182, 61);
        dtpDenNgay.Name = "dtpDenNgay";
        dtpDenNgay.Size = new System.Drawing.Size(127, 30);
        dtpDenNgay.TabIndex = 3;
        // 
        // dtpTuNgay
        // 
        dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpTuNgay.Location = new System.Drawing.Point(26, 61);
        dtpTuNgay.Name = "dtpTuNgay";
        dtpTuNgay.Size = new System.Drawing.Size(127, 30);
        dtpTuNgay.TabIndex = 1;
        // 
        // lblSapXep
        // 
        lblSapXep.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblSapXep.Location = new System.Drawing.Point(335, 21);
        lblSapXep.Name = "lblSapXep";
        lblSapXep.Size = new System.Drawing.Size(100, 23);
        lblSapXep.TabIndex = 2;
        lblSapXep.Text = "Sắp xếp theo:";
        // 
        // lblDenNgay
        // 
        lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblDenNgay.Location = new System.Drawing.Point(182, 21);
        lblDenNgay.Name = "lblDenNgay";
        lblDenNgay.Size = new System.Drawing.Size(100, 23);
        lblDenNgay.TabIndex = 1;
        lblDenNgay.Text = "Đến ngày:";
        // 
        // lblTuNgay
        // 
        lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblTuNgay.Location = new System.Drawing.Point(26, 21);
        lblTuNgay.Name = "lblTuNgay";
        lblTuNgay.Size = new System.Drawing.Size(100, 23);
        lblTuNgay.TabIndex = 0;
        lblTuNgay.Text = "Từ ngày:";
        // 
        // dgvTop
        // 
        dgvTop.BackgroundColor = System.Drawing.Color.White;
        dgvTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvTop.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvTop.Location = new System.Drawing.Point(3, 275);
        dgvTop.Name = "dgvTop";
        dgvTop.RowHeadersWidth = 51;
        dgvTop.Size = new System.Drawing.Size(1016, 366);
        dgvTop.TabIndex = 2;
        dgvTop.Text = "dataGridView1";
        // 
        // FormTopSanPham
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1022, 644);
        Controls.Add(panel1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "FormTopSanPham";
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTop).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DateTimePicker dtpDenNgay;
    private System.Windows.Forms.ComboBox cboSapXep;
    private System.Windows.Forms.Label lblHienThi;
    private System.Windows.Forms.ComboBox cboHienThi;
    private System.Windows.Forms.Button btnXem;
    private System.Windows.Forms.Label lblTongKet;
    private System.Windows.Forms.DataGridView dgvTop;

    private System.Windows.Forms.Label lblDenNgay;
    private System.Windows.Forms.Label lblSapXep;
    private System.Windows.Forms.DateTimePicker dtpTuNgay;

    private System.Windows.Forms.Label lblTuNgay;

    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.Panel panel1;

    #endregion
}
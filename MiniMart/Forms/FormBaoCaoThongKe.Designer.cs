using System.ComponentModel;

namespace MiniMart.Forms;

partial class FormBaoCaoThongKe
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
        label6 = new System.Windows.Forms.Label();
        panel1 = new System.Windows.Forms.Panel();
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        lbBaocaothongke = new System.Windows.Forms.Label();
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
        dtpDenNgay = new System.Windows.Forms.DateTimePicker();
        lbDenngay = new System.Windows.Forms.Label();
        tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
        btInbaocao = new System.Windows.Forms.Button();
        tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
        lbTungay = new System.Windows.Forms.Label();
        tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
        btXembaocao = new System.Windows.Forms.Button();
        tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
        dtpTuNgay = new System.Windows.Forms.DateTimePicker();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        dgvTopSanPham = new System.Windows.Forms.DataGridView();
        tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
        lbDoanhThu = new System.Windows.Forms.Label();
        tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
        lbSohoadon = new System.Windows.Forms.Label();
        tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
        lbTopsanphambanchay = new System.Windows.Forms.Label();
        btXemtop = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel6.SuspendLayout();
        tableLayoutPanel12.SuspendLayout();
        tableLayoutPanel10.SuspendLayout();
        tableLayoutPanel5.SuspendLayout();
        tableLayoutPanel9.SuspendLayout();
        tableLayoutPanel11.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTopSanPham).BeginInit();
        tableLayoutPanel4.SuspendLayout();
        tableLayoutPanel7.SuspendLayout();
        tableLayoutPanel8.SuspendLayout();
        tableLayoutPanel13.SuspendLayout();
        SuspendLayout();
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(7, 6);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(444, 28);
        label6.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.Controls.Add(tableLayoutPanel1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(1067, 646);
        panel1.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(lbBaocaothongke, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.993809F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.09907F));
        tableLayoutPanel1.Size = new System.Drawing.Size(1067, 646);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // lbBaocaothongke
        // 
        lbBaocaothongke.Anchor = System.Windows.Forms.AnchorStyles.None;
        lbBaocaothongke.AutoSize = true;
        lbBaocaothongke.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lbBaocaothongke.ForeColor = System.Drawing.Color.Navy;
        lbBaocaothongke.Location = new System.Drawing.Point(377, 11);
        lbBaocaothongke.Name = "lbBaocaothongke";
        lbBaocaothongke.Size = new System.Drawing.Size(312, 41);
        lbBaocaothongke.TabIndex = 0;
        lbBaocaothongke.Text = "BÁO CÁO THỐNG KÊ";
        lbBaocaothongke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 0);
        tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 0);
        tableLayoutPanel2.Location = new System.Drawing.Point(3, 67);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.Size = new System.Drawing.Size(1061, 148);
        tableLayoutPanel2.TabIndex = 1;
        // 
        // tableLayoutPanel6
        // 
        tableLayoutPanel6.ColumnCount = 1;
        tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel6.Controls.Add(tableLayoutPanel12, 0, 1);
        tableLayoutPanel6.Controls.Add(lbDenngay, 0, 0);
        tableLayoutPanel6.Controls.Add(tableLayoutPanel10, 0, 2);
        tableLayoutPanel6.Location = new System.Drawing.Point(533, 3);
        tableLayoutPanel6.Name = "tableLayoutPanel6";
        tableLayoutPanel6.RowCount = 3;
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
        tableLayoutPanel6.Size = new System.Drawing.Size(524, 142);
        tableLayoutPanel6.TabIndex = 1;
        // 
        // tableLayoutPanel12
        // 
        tableLayoutPanel12.ColumnCount = 3;
        tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
        tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
        tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
        tableLayoutPanel12.Controls.Add(dtpDenNgay, 1, 0);
        tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel12.Location = new System.Drawing.Point(3, 37);
        tableLayoutPanel12.Name = "tableLayoutPanel12";
        tableLayoutPanel12.RowCount = 1;
        tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel12.Size = new System.Drawing.Size(518, 28);
        tableLayoutPanel12.TabIndex = 5;
        // 
        // dtpDenNgay
        // 
        dtpDenNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
        dtpDenNgay.Location = new System.Drawing.Point(94, 3);
        dtpDenNgay.Name = "dtpDenNgay";
        dtpDenNgay.Size = new System.Drawing.Size(327, 27);
        dtpDenNgay.TabIndex = 3;
        // 
        // lbDenngay
        // 
        lbDenngay.Anchor = System.Windows.Forms.AnchorStyles.None;
        lbDenngay.AutoSize = true;
        lbDenngay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lbDenngay.Location = new System.Drawing.Point(211, 5);
        lbDenngay.Name = "lbDenngay";
        lbDenngay.Size = new System.Drawing.Size(101, 23);
        lbDenngay.TabIndex = 1;
        lbDenngay.Text = "ĐẾN NGÀY:";
        lbDenngay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tableLayoutPanel10
        // 
        tableLayoutPanel10.Anchor = System.Windows.Forms.AnchorStyles.Top;
        tableLayoutPanel10.ColumnCount = 3;
        tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel10.Controls.Add(btInbaocao, 1, 0);
        tableLayoutPanel10.Location = new System.Drawing.Point(3, 71);
        tableLayoutPanel10.Name = "tableLayoutPanel10";
        tableLayoutPanel10.RowCount = 1;
        tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel10.Size = new System.Drawing.Size(518, 68);
        tableLayoutPanel10.TabIndex = 4;
        // 
        // btInbaocao
        // 
        btInbaocao.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        btInbaocao.AutoSize = true;
        btInbaocao.BackColor = System.Drawing.Color.Navy;
        btInbaocao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btInbaocao.ForeColor = System.Drawing.Color.White;
        btInbaocao.Location = new System.Drawing.Point(132, 17);
        btInbaocao.Name = "btInbaocao";
        btInbaocao.Size = new System.Drawing.Size(253, 33);
        btInbaocao.TabIndex = 5;
        btInbaocao.Text = "XUẤT FILE CSV";
        btInbaocao.UseVisualStyleBackColor = false;
        // 
        // tableLayoutPanel5
        // 
        tableLayoutPanel5.ColumnCount = 1;
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel5.Controls.Add(lbTungay, 0, 0);
        tableLayoutPanel5.Controls.Add(tableLayoutPanel9, 0, 2);
        tableLayoutPanel5.Controls.Add(tableLayoutPanel11, 0, 1);
        tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel5.Name = "tableLayoutPanel5";
        tableLayoutPanel5.RowCount = 3;
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
        tableLayoutPanel5.Size = new System.Drawing.Size(524, 142);
        tableLayoutPanel5.TabIndex = 0;
        // 
        // lbTungay
        // 
        lbTungay.Anchor = System.Windows.Forms.AnchorStyles.None;
        lbTungay.AutoSize = true;
        lbTungay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lbTungay.Location = new System.Drawing.Point(217, 5);
        lbTungay.Name = "lbTungay";
        lbTungay.Size = new System.Drawing.Size(89, 23);
        lbTungay.TabIndex = 1;
        lbTungay.Text = "TỪ NGÀY:";
        lbTungay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tableLayoutPanel9
        // 
        tableLayoutPanel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
        tableLayoutPanel9.ColumnCount = 3;
        tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel9.Controls.Add(btXembaocao, 1, 0);
        tableLayoutPanel9.Location = new System.Drawing.Point(3, 71);
        tableLayoutPanel9.Name = "tableLayoutPanel9";
        tableLayoutPanel9.RowCount = 1;
        tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel9.Size = new System.Drawing.Size(518, 67);
        tableLayoutPanel9.TabIndex = 3;
        // 
        // btXembaocao
        // 
        btXembaocao.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        btXembaocao.AutoSize = true;
        btXembaocao.BackColor = System.Drawing.Color.Navy;
        btXembaocao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btXembaocao.ForeColor = System.Drawing.Color.White;
        btXembaocao.Location = new System.Drawing.Point(132, 14);
        btXembaocao.Name = "btXembaocao";
        btXembaocao.Size = new System.Drawing.Size(253, 38);
        btXembaocao.TabIndex = 4;
        btXembaocao.Text = "XEM BÁO CÁO";
        btXembaocao.UseVisualStyleBackColor = false;
        // 
        // tableLayoutPanel11
        // 
        tableLayoutPanel11.ColumnCount = 3;
        tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
        tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
        tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
        tableLayoutPanel11.Controls.Add(dtpTuNgay, 1, 0);
        tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel11.Location = new System.Drawing.Point(3, 37);
        tableLayoutPanel11.Name = "tableLayoutPanel11";
        tableLayoutPanel11.RowCount = 1;
        tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel11.Size = new System.Drawing.Size(518, 28);
        tableLayoutPanel11.TabIndex = 4;
        // 
        // dtpTuNgay
        // 
        dtpTuNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
        dtpTuNgay.Location = new System.Drawing.Point(94, 3);
        dtpTuNgay.Name = "dtpTuNgay";
        dtpTuNgay.Size = new System.Drawing.Size(327, 27);
        dtpTuNgay.TabIndex = 3;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel3.Controls.Add(dgvTopSanPham, 0, 2);
        tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
        tableLayoutPanel3.Controls.Add(tableLayoutPanel13, 0, 1);
        tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel3.Location = new System.Drawing.Point(3, 221);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 3;
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.587677F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.137441F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.51185F));
        tableLayoutPanel3.Size = new System.Drawing.Size(1061, 422);
        tableLayoutPanel3.TabIndex = 2;
        // 
        // dgvTopSanPham
        // 
        dgvTopSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvTopSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvTopSanPham.Location = new System.Drawing.Point(3, 118);
        dgvTopSanPham.Name = "dgvTopSanPham";
        dgvTopSanPham.RowHeadersWidth = 51;
        dgvTopSanPham.Size = new System.Drawing.Size(1055, 301);
        dgvTopSanPham.TabIndex = 0;
        dgvTopSanPham.Text = "dataGridView1";
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 2;
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 0, 0);
        tableLayoutPanel4.Controls.Add(tableLayoutPanel8, 1, 0);
        tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 1;
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel4.Size = new System.Drawing.Size(1055, 59);
        tableLayoutPanel4.TabIndex = 2;
        // 
        // tableLayoutPanel7
        // 
        tableLayoutPanel7.ColumnCount = 3;
        tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel7.Controls.Add(lbDoanhThu, 1, 0);
        tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel7.Name = "tableLayoutPanel7";
        tableLayoutPanel7.RowCount = 1;
        tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel7.Size = new System.Drawing.Size(521, 53);
        tableLayoutPanel7.TabIndex = 2;
        // 
        // lbDoanhThu
        // 
        lbDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
        lbDoanhThu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lbDoanhThu.ForeColor = System.Drawing.Color.Navy;
        lbDoanhThu.Location = new System.Drawing.Point(133, 0);
        lbDoanhThu.Name = "lbDoanhThu";
        lbDoanhThu.Size = new System.Drawing.Size(254, 53);
        lbDoanhThu.TabIndex = 1;
        lbDoanhThu.Text = "DOANH THU:";
        lbDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tableLayoutPanel8
        // 
        tableLayoutPanel8.ColumnCount = 3;
        tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel8.Controls.Add(lbSohoadon, 1, 0);
        tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
        tableLayoutPanel8.Location = new System.Drawing.Point(530, 3);
        tableLayoutPanel8.Name = "tableLayoutPanel8";
        tableLayoutPanel8.RowCount = 1;
        tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel8.Size = new System.Drawing.Size(522, 53);
        tableLayoutPanel8.TabIndex = 3;
        // 
        // lbSohoadon
        // 
        lbSohoadon.Dock = System.Windows.Forms.DockStyle.Fill;
        lbSohoadon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lbSohoadon.ForeColor = System.Drawing.Color.Navy;
        lbSohoadon.Location = new System.Drawing.Point(133, 0);
        lbSohoadon.Name = "lbSohoadon";
        lbSohoadon.Size = new System.Drawing.Size(255, 53);
        lbSohoadon.TabIndex = 2;
        lbSohoadon.Text = "SỐ HÓA ĐƠN";
        lbSohoadon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tableLayoutPanel13
        // 
        tableLayoutPanel13.ColumnCount = 2;
        tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.317535F));
        tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.682465F));
        tableLayoutPanel13.Controls.Add(lbTopsanphambanchay, 0, 0);
        tableLayoutPanel13.Controls.Add(btXemtop, 1, 0);
        tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Top;
        tableLayoutPanel13.Location = new System.Drawing.Point(3, 72);
        tableLayoutPanel13.Name = "tableLayoutPanel13";
        tableLayoutPanel13.RowCount = 1;
        tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel13.Size = new System.Drawing.Size(1055, 39);
        tableLayoutPanel13.TabIndex = 3;
        // 
        // lbTopsanphambanchay
        // 
        lbTopsanphambanchay.AutoSize = true;
        lbTopsanphambanchay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lbTopsanphambanchay.Location = new System.Drawing.Point(3, 0);
        lbTopsanphambanchay.Name = "lbTopsanphambanchay";
        lbTopsanphambanchay.Size = new System.Drawing.Size(271, 28);
        lbTopsanphambanchay.TabIndex = 0;
        lbTopsanphambanchay.Text = "TOP SẢN PHẨM BÁN CHẠY";
        lbTopsanphambanchay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btXemtop
        // 
        btXemtop.AutoSize = true;
        btXemtop.BackColor = System.Drawing.Color.Navy;
        btXemtop.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btXemtop.ForeColor = System.Drawing.Color.White;
        btXemtop.Location = new System.Drawing.Point(882, 3);
        btXemtop.Name = "btXemtop";
        btXemtop.Size = new System.Drawing.Size(166, 33);
        btXemtop.TabIndex = 1;
        btXemtop.Text = "XEM CHI TIẾT TOP";
        btXemtop.UseVisualStyleBackColor = false;
        // 
        // FormBaoCaoThongKe
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1067, 646);
        Controls.Add(panel1);
        DoubleBuffered = true;
        ImeMode = System.Windows.Forms.ImeMode.Off;
        Margin = new System.Windows.Forms.Padding(4);
        Text = "FormBaoCaoThongKe";
        Load += FormBaoCaoThongKe_Load;
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel6.ResumeLayout(false);
        tableLayoutPanel6.PerformLayout();
        tableLayoutPanel12.ResumeLayout(false);
        tableLayoutPanel10.ResumeLayout(false);
        tableLayoutPanel10.PerformLayout();
        tableLayoutPanel5.ResumeLayout(false);
        tableLayoutPanel5.PerformLayout();
        tableLayoutPanel9.ResumeLayout(false);
        tableLayoutPanel9.PerformLayout();
        tableLayoutPanel11.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvTopSanPham).EndInit();
        tableLayoutPanel4.ResumeLayout(false);
        tableLayoutPanel7.ResumeLayout(false);
        tableLayoutPanel8.ResumeLayout(false);
        tableLayoutPanel13.ResumeLayout(false);
        tableLayoutPanel13.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btXemtop;

    private System.Windows.Forms.Label lbTopsanphambanchay;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;

    private System.Windows.Forms.DateTimePicker dtpTuNgay;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;

    private System.Windows.Forms.Button btInbaocao;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;

    private System.Windows.Forms.Button btXembaocao;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;

    private System.Windows.Forms.Label lbSohoadon;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;

    private System.Windows.Forms.Label lbDoanhThu;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;

    private System.Windows.Forms.DateTimePicker dtpDenNgay;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    private System.Windows.Forms.Label lbTungay;
    private System.Windows.Forms.Label lbDenngay;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.Label lbBaocaothongke;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.DataGridView dataGridView2;

    private System.Windows.Forms.DataGridView dgvTopSanPham;


    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Panel panel1;
    

    #endregion
}
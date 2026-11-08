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
        panel1 = new System.Windows.Forms.Panel();
        panel4 = new System.Windows.Forms.Panel();
        label7 = new System.Windows.Forms.Label();
        dataGridView2 = new System.Windows.Forms.DataGridView();
        panel5 = new System.Windows.Forms.Panel();
        label5 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        panel3 = new System.Windows.Forms.Panel();
        button2 = new System.Windows.Forms.Button();
        button1 = new System.Windows.Forms.Button();
        dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
        dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        label1 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        panel1.SuspendLayout();
        panel4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
        panel5.SuspendLayout();
        panel3.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.CausesValidation = false;
        panel1.Controls.Add(panel4);
        panel1.Controls.Add(panel5);
        panel1.Controls.Add(panel3);
        panel1.Controls.Add(panel2);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(800, 450);
        panel1.TabIndex = 0;
        // 
        // panel4
        // 
        panel4.Controls.Add(label7);
        panel4.Controls.Add(dataGridView2);
        panel4.Dock = System.Windows.Forms.DockStyle.Fill;
        panel4.Location = new System.Drawing.Point(0, 244);
        panel4.Name = "panel4";
        panel4.Size = new System.Drawing.Size(800, 206);
        panel4.TabIndex = 6;
        // 
        // label7
        // 
        label7.Anchor = System.Windows.Forms.AnchorStyles.None;
        label7.AutoSize = true;
        label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.Location = new System.Drawing.Point(12, 3);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(326, 32);
        label7.TabIndex = 1;
        label7.Text = "TOP SẢN PHẨM BÁN CHẠY";
        // 
        // dataGridView2
        // 
        dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView2.Location = new System.Drawing.Point(21, 34);
        dataGridView2.Name = "dataGridView2";
        dataGridView2.RowHeadersWidth = 51;
        dataGridView2.Size = new System.Drawing.Size(757, 160);
        dataGridView2.TabIndex = 0;
        dataGridView2.Text = "dataGridView2";
        // 
        // panel5
        // 
        panel5.Controls.Add(label5);
        panel5.Controls.Add(label4);
        panel5.Dock = System.Windows.Forms.DockStyle.Top;
        panel5.Location = new System.Drawing.Point(0, 185);
        panel5.Name = "panel5";
        panel5.Size = new System.Drawing.Size(800, 59);
        panel5.TabIndex = 5;
        // 
        // label5
        // 
        label5.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        label5.AutoSize = true;
        label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(505, 15);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(171, 32);
        label5.TabIndex = 1;
        label5.Text = "Số hóa đơn: 0";
        // 
        // label4
        // 
        label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        label4.AutoSize = true;
        label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.ForeColor = System.Drawing.Color.ForestGreen;
        label4.Location = new System.Drawing.Point(101, 15);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(184, 32);
        label4.TabIndex = 0;
        label4.Text = "Doanh thu: 0 đ";
        // 
        // panel3
        // 
        panel3.Controls.Add(button2);
        panel3.Controls.Add(button1);
        panel3.Controls.Add(dateTimePicker2);
        panel3.Controls.Add(dateTimePicker1);
        panel3.Controls.Add(label3);
        panel3.Controls.Add(label2);
        panel3.Dock = System.Windows.Forms.DockStyle.Top;
        panel3.Location = new System.Drawing.Point(0, 71);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(800, 114);
        panel3.TabIndex = 1;
        // 
        // button2
        // 
        button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button2.Location = new System.Drawing.Point(505, 70);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(217, 31);
        button2.TabIndex = 5;
        button2.Text = "Xuất file CSV";
        button2.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.Anchor = System.Windows.Forms.AnchorStyles.None;
        button1.AutoSize = true;
        button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button1.Location = new System.Drawing.Point(101, 70);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(212, 40);
        button1.TabIndex = 4;
        button1.Text = "Xem Báo Cáo";
        button1.UseVisualStyleBackColor = true;
        // 
        // dateTimePicker2
        // 
        dateTimePicker2.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dateTimePicker2.Location = new System.Drawing.Point(505, 37);
        dateTimePicker2.Name = "dateTimePicker2";
        dateTimePicker2.Size = new System.Drawing.Size(217, 31);
        dateTimePicker2.TabIndex = 3;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        dateTimePicker1.Location = new System.Drawing.Point(101, 37);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new System.Drawing.Size(212, 31);
        dateTimePicker1.TabIndex = 2;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(505, 11);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(112, 30);
        label3.TabIndex = 1;
        label3.Text = "Đến ngày:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(101, 11);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(105, 30);
        label2.TabIndex = 0;
        label2.Text = "Từ ngày: ";
        // 
        // panel2
        // 
        panel2.Controls.Add(label1);
        panel2.Dock = System.Windows.Forms.DockStyle.Top;
        panel2.Location = new System.Drawing.Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(800, 71);
        panel2.TabIndex = 0;
        // 
        // label1
        // 
        label1.Anchor = System.Windows.Forms.AnchorStyles.None;
        label1.AutoSize = true;
        label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(254, 18);
        label1.Name = "label1";
        label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        label1.Size = new System.Drawing.Size(342, 45);
        label1.TabIndex = 0;
        label1.Text = "BÁO CÁO THỐNG KÊ\r\n";
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(7, 6);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(444, 28);
        label6.TabIndex = 0;
        // 
        // FormBaoCaoThongKe
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(panel1);
        DoubleBuffered = true;
        ImeMode = System.Windows.Forms.ImeMode.Off;
        Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        Text = "FormBaoCaoThongKe";
        WindowState = System.Windows.Forms.FormWindowState.Maximized;
        Load += FormBaoCaoThongKe_Load;
        panel1.ResumeLayout(false);
        panel4.ResumeLayout(false);
        panel4.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
        panel5.ResumeLayout(false);
        panel5.PerformLayout();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.DataGridView dataGridView2;
    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Panel panel5;

    private System.Windows.Forms.Label tgsjabk;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.DateTimePicker dateTimePicker2;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Panel panel4;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Panel panel1;

    #endregion
}
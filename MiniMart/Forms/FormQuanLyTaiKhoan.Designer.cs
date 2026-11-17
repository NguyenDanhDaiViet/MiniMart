using System.ComponentModel;

namespace MiniMart.Forms;

partial class FormQuanLyTaiKhoan
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
        tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        label1 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        textBox1 = new System.Windows.Forms.TextBox();
        tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
        button4 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
        textBox4 = new System.Windows.Forms.TextBox();
        textBox3 = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        textBox2 = new System.Windows.Forms.TextBox();
        comboBox1 = new System.Windows.Forms.ComboBox();
        panel3 = new System.Windows.Forms.Panel();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        tableLayoutPanel5.SuspendLayout();
        panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(tableLayoutPanel1);
        panel1.Dock = System.Windows.Forms.DockStyle.Top;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(1119, 308);
        panel1.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new System.Drawing.Size(1119, 308);
        tableLayoutPanel1.TabIndex = 1;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.22891F));
        tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.771084F));
        tableLayoutPanel2.Controls.Add(label1, 0, 0);
        tableLayoutPanel2.Controls.Add(button1, 1, 1);
        tableLayoutPanel2.Controls.Add(textBox1, 0, 1);
        tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel2.Size = new System.Drawing.Size(1113, 148);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // label1
        // 
        label1.Anchor = System.Windows.Forms.AnchorStyles.None;
        label1.AutoSize = true;
        label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(308, 18);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(299, 38);
        label1.TabIndex = 0;
        label1.Text = "QUẢN LÝ TÀI KHOẢN";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // button1
        // 
        button1.Anchor = System.Windows.Forms.AnchorStyles.None;
        button1.AutoSize = true;
        button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button1.Location = new System.Drawing.Point(926, 90);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(176, 42);
        button1.TabIndex = 2;
        button1.Text = "Tìm kiếm";
        button1.UseVisualStyleBackColor = true;
        // 
        // textBox1
        // 
        textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        textBox1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        textBox1.Location = new System.Drawing.Point(3, 97);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(909, 27);
        textBox1.TabIndex = 3;
        textBox1.Text = "Tìm tên đăng nhập hoặc họ tên";
        textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
        tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 0);
        tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel3.Location = new System.Drawing.Point(3, 157);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 2;
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.21622F));
        tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.783783F));
        tableLayoutPanel3.Size = new System.Drawing.Size(1113, 148);
        tableLayoutPanel3.TabIndex = 1;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 3;
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
        tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
        tableLayoutPanel4.Controls.Add(button4, 2, 0);
        tableLayoutPanel4.Controls.Add(button3, 1, 0);
        tableLayoutPanel4.Controls.Add(button2, 0, 0);
        tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel4.Location = new System.Drawing.Point(3, 101);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 1;
        tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel4.Size = new System.Drawing.Size(1107, 44);
        tableLayoutPanel4.TabIndex = 0;
        // 
        // button4
        // 
        button4.Anchor = System.Windows.Forms.AnchorStyles.None;
        button4.AutoSize = true;
        button4.Location = new System.Drawing.Point(843, 7);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(162, 30);
        button4.TabIndex = 2;
        button4.Text = "button4";
        button4.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Anchor = System.Windows.Forms.AnchorStyles.None;
        button3.AutoSize = true;
        button3.Location = new System.Drawing.Point(453, 5);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(200, 34);
        button3.TabIndex = 1;
        button3.Text = "button3";
        button3.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Anchor = System.Windows.Forms.AnchorStyles.None;
        button2.AutoSize = true;
        button2.Location = new System.Drawing.Point(82, 5);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(200, 34);
        button2.TabIndex = 0;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        // 
        // tableLayoutPanel5
        // 
        tableLayoutPanel5.ColumnCount = 4;
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.751581F));
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.112917F));
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel5.Controls.Add(textBox4, 2, 1);
        tableLayoutPanel5.Controls.Add(textBox3, 1, 1);
        tableLayoutPanel5.Controls.Add(label5, 3, 0);
        tableLayoutPanel5.Controls.Add(label4, 2, 0);
        tableLayoutPanel5.Controls.Add(label3, 1, 0);
        tableLayoutPanel5.Controls.Add(label2, 0, 0);
        tableLayoutPanel5.Controls.Add(textBox2, 0, 1);
        tableLayoutPanel5.Controls.Add(comboBox1, 3, 1);
        tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel5.Name = "tableLayoutPanel5";
        tableLayoutPanel5.RowCount = 2;
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel5.Size = new System.Drawing.Size(1107, 92);
        tableLayoutPanel5.TabIndex = 1;
        // 
        // textBox4
        // 
        textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
        textBox4.Location = new System.Drawing.Point(573, 55);
        textBox4.Name = "textBox4";
        textBox4.Size = new System.Drawing.Size(234, 27);
        textBox4.TabIndex = 6;
        // 
        // textBox3
        // 
        textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
        textBox3.Location = new System.Drawing.Point(301, 55);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(224, 27);
        textBox3.TabIndex = 5;
        // 
        // label5
        // 
        label5.Anchor = System.Windows.Forms.AnchorStyles.None;
        label5.Location = new System.Drawing.Point(918, 11);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(100, 23);
        label5.TabIndex = 3;
        label5.Text = "label5";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label4
        // 
        label4.Anchor = System.Windows.Forms.AnchorStyles.None;
        label4.Location = new System.Drawing.Point(574, 11);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(232, 23);
        label4.TabIndex = 2;
        label4.Text = "label4";
        // 
        // label3
        // 
        label3.Anchor = System.Windows.Forms.AnchorStyles.None;
        label3.Location = new System.Drawing.Point(301, 11);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(223, 23);
        label3.TabIndex = 1;
        label3.Text = "label3";
        // 
        // label2
        // 
        label2.Anchor = System.Windows.Forms.AnchorStyles.None;
        label2.Location = new System.Drawing.Point(23, 11);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(228, 23);
        label2.TabIndex = 0;
        label2.Text = "label2";
        // 
        // textBox2
        // 
        textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
        textBox2.Location = new System.Drawing.Point(22, 55);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(229, 27);
        textBox2.TabIndex = 4;
        // 
        // comboBox1
        // 
        comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(862, 55);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(212, 28);
        comboBox1.TabIndex = 7;
        // 
        // panel3
        // 
        panel3.Controls.Add(dataGridView1);
        panel3.Dock = System.Windows.Forms.DockStyle.Fill;
        panel3.Location = new System.Drawing.Point(0, 308);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(1119, 420);
        panel3.TabIndex = 2;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
        dataGridView1.Location = new System.Drawing.Point(0, 0);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new System.Drawing.Size(1119, 420);
        dataGridView1.TabIndex = 0;
        dataGridView1.Text = "dataGridView1";
        // 
        // FormQuanLyTaiKhoan
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1119, 728);
        Controls.Add(panel3);
        Controls.Add(panel1);
        Text = "FormQuanLyTaiKhoan";
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        tableLayoutPanel3.ResumeLayout(false);
        tableLayoutPanel4.ResumeLayout(false);
        tableLayoutPanel4.PerformLayout();
        tableLayoutPanel5.ResumeLayout(false);
        tableLayoutPanel5.PerformLayout();
        panel3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.ComboBox comboBox1;

    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;

    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Panel panel1;

    #endregion
}
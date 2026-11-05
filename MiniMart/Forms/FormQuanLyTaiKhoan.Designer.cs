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
        textBox1 = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        comboBox1 = new System.Windows.Forms.ComboBox();
        textBox4 = new System.Windows.Forms.TextBox();
        textBox3 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        button4 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        label5 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        panel3 = new System.Windows.Forms.Panel();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(textBox1);
        panel1.Controls.Add(button1);
        panel1.Controls.Add(label1);
        panel1.Dock = System.Windows.Forms.DockStyle.Top;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(800, 239);
        panel1.TabIndex = 0;
        // 
        // textBox1
        // 
        textBox1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        textBox1.Location = new System.Drawing.Point(46, 52);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(515, 27);
        textBox1.TabIndex = 2;
        textBox1.Text = "Tìm tên đăng nhập hoặc họ tên";
        textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // button1
        // 
        button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button1.Location = new System.Drawing.Point(575, 52);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(176, 27);
        button1.TabIndex = 1;
        button1.Text = "Tìm kiếm";
        button1.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(46, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(299, 38);
        label1.TabIndex = 0;
        label1.Text = "QUẢN LÝ TÀI KHOẢN";
        // 
        // panel2
        // 
        panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panel2.Controls.Add(comboBox1);
        panel2.Controls.Add(textBox4);
        panel2.Controls.Add(textBox3);
        panel2.Controls.Add(textBox2);
        panel2.Controls.Add(button4);
        panel2.Controls.Add(button3);
        panel2.Controls.Add(button2);
        panel2.Controls.Add(label5);
        panel2.Controls.Add(label4);
        panel2.Controls.Add(label3);
        panel2.Controls.Add(label2);
        panel2.Location = new System.Drawing.Point(12, 89);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(776, 138);
        panel2.TabIndex = 1;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(605, 42);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(133, 28);
        comboBox1.TabIndex = 10;
        // 
        // textBox4
        // 
        textBox4.Location = new System.Drawing.Point(415, 42);
        textBox4.Name = "textBox4";
        textBox4.Size = new System.Drawing.Size(133, 27);
        textBox4.TabIndex = 9;
        // 
        // textBox3
        // 
        textBox3.Location = new System.Drawing.Point(233, 42);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(133, 27);
        textBox3.TabIndex = 8;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(33, 42);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(133, 27);
        textBox2.TabIndex = 7;
        // 
        // button4
        // 
        button4.AutoSize = true;
        button4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button4.Location = new System.Drawing.Point(545, 91);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(193, 33);
        button4.TabIndex = 6;
        button4.Text = "Khóa / Mở khóa";
        button4.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.AutoSize = true;
        button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button3.Location = new System.Drawing.Point(274, 91);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(230, 33);
        button3.TabIndex = 5;
        button3.Text = "Lưu";
        button3.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.AutoSize = true;
        button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button2.Location = new System.Drawing.Point(33, 91);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(202, 33);
        button2.TabIndex = 4;
        button2.Text = "Làm mới";
        button2.UseVisualStyleBackColor = true;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(635, 16);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(60, 23);
        label5.TabIndex = 3;
        label5.Text = "Vai trò";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(415, 16);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(89, 23);
        label4.TabIndex = 2;
        label4.Text = "Mật khẩu \r\n";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(233, 16);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(86, 23);
        label3.TabIndex = 1;
        label3.Text = "Họ và tên\r\n";
        // 
        // label2
        // 
        label2.AutoEllipsis = true;
        label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(33, 16);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(154, 23);
        label2.TabIndex = 0;
        label2.Text = "Tên đăng nhập";
        // 
        // panel3
        // 
        panel3.Controls.Add(dataGridView1);
        panel3.Dock = System.Windows.Forms.DockStyle.Fill;
        panel3.Location = new System.Drawing.Point(0, 239);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(800, 211);
        panel3.TabIndex = 2;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new System.Drawing.Point(12, 21);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new System.Drawing.Size(776, 164);
        dataGridView1.TabIndex = 0;
        dataGridView1.Text = "dataGridView1";
        // 
        // FormQuanLyTaiKhoan
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(panel3);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Text = "FormQuanLyTaiKhoan";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        panel3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.ComboBox comboBox1;

    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Panel panel1;

    #endregion
}
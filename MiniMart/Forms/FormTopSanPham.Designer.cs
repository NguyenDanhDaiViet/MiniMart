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
        button1 = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        panel3 = new System.Windows.Forms.Panel();
        label6 = new System.Windows.Forms.Label();
        button2 = new System.Windows.Forms.Button();
        comboBox2 = new System.Windows.Forms.ComboBox();
        label5 = new System.Windows.Forms.Label();
        comboBox1 = new System.Windows.Forms.ComboBox();
        dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
        dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(tableLayoutPanel1);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(892, 644);
        panel1.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(panel2, 0, 0);
        tableLayoutPanel1.Controls.Add(panel3, 0, 1);
        tableLayoutPanel1.Controls.Add(dataGridView1, 0, 2);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.484472F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.608696F));
        tableLayoutPanel1.Size = new System.Drawing.Size(892, 644);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.Color.White;
        panel2.Controls.Add(button1);
        panel2.Controls.Add(label1);
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(3, 3);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(886, 90);
        panel2.TabIndex = 0;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(682, 31);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(115, 35);
        button1.TabIndex = 1;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new System.Drawing.Font("Segoe UI", 19.800001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(115, 18);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(117, 46);
        label1.TabIndex = 0;
        label1.Text = "label1";
        // 
        // panel3
        // 
        panel3.Controls.Add(label6);
        panel3.Controls.Add(button2);
        panel3.Controls.Add(comboBox2);
        panel3.Controls.Add(label5);
        panel3.Controls.Add(comboBox1);
        panel3.Controls.Add(dateTimePicker2);
        panel3.Controls.Add(dateTimePicker1);
        panel3.Controls.Add(label4);
        panel3.Controls.Add(label3);
        panel3.Controls.Add(label2);
        panel3.Dock = System.Windows.Forms.DockStyle.Fill;
        panel3.Location = new System.Drawing.Point(3, 99);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(886, 170);
        panel3.TabIndex = 1;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(26, 138);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(100, 23);
        label6.TabIndex = 9;
        label6.Text = "label6";
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(705, 89);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(110, 28);
        button2.TabIndex = 8;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        // 
        // comboBox2
        // 
        comboBox2.FormattingEnabled = true;
        comboBox2.Location = new System.Drawing.Point(498, 78);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new System.Drawing.Size(121, 28);
        comboBox2.TabIndex = 7;
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(498, 37);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(100, 23);
        label5.TabIndex = 6;
        label5.Text = "label5";
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(356, 78);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(121, 28);
        comboBox1.TabIndex = 5;
        // 
        // dateTimePicker2
        // 
        dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dateTimePicker2.Location = new System.Drawing.Point(184, 79);
        dateTimePicker2.Name = "dateTimePicker2";
        dateTimePicker2.Size = new System.Drawing.Size(127, 27);
        dateTimePicker2.TabIndex = 4;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dateTimePicker1.Location = new System.Drawing.Point(26, 79);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new System.Drawing.Size(127, 27);
        dateTimePicker1.TabIndex = 3;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(356, 37);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(100, 23);
        label4.TabIndex = 2;
        label4.Text = "label4";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(184, 37);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 23);
        label3.TabIndex = 1;
        label3.Text = "label3";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(26, 37);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 0;
        label2.Text = "label2";
        // 
        // dataGridView1
        // 
        dataGridView1.BackgroundColor = System.Drawing.Color.White;
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
        dataGridView1.Location = new System.Drawing.Point(3, 275);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new System.Drawing.Size(886, 366);
        dataGridView1.TabIndex = 2;
        dataGridView1.Text = "dataGridView1";
        // 
        // FormTopSanPham
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(892, 644);
        Controls.Add(panel1);
        Text = "FormTopSanPham";
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        panel3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DateTimePicker dateTimePicker2;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox comboBox2;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.Panel panel1;

    #endregion
}
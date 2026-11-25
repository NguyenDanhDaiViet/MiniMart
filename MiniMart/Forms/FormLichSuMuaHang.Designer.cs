using System.ComponentModel;

namespace MiniMart.Forms;


partial class FormLichSuMuaHang
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
        lblKhachHang = new System.Windows.Forms.Label();
        dgvLichSuMua = new System.Windows.Forms.DataGridView();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvLichSuMua).BeginInit();
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
        tableLayoutPanel1.Controls.Add(lblKhachHang, 0, 1);
        tableLayoutPanel1.Controls.Add(dgvLichSuMua, 0, 2);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.Size = new System.Drawing.Size(968, 100);
        tableLayoutPanel1.TabIndex = 0;
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
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
        lblTieuDe.Text = "LỊCH SỬ MUA HÀNG";
        lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblKhachHang
        // 
        lblKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
        lblKhachHang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblKhachHang.ForeColor = System.Drawing.Color.Navy;
        lblKhachHang.Location = new System.Drawing.Point(3, 60);
        lblKhachHang.Name = "lblKhachHang";
        lblKhachHang.Size = new System.Drawing.Size(874, 34);
        lblKhachHang.TabIndex = 1;
        lblKhachHang.Text = "Khách hàng:";
        lblKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // dgvLichSuMua
        // 
        dgvLichSuMua.AllowUserToAddRows = false;
        dgvLichSuMua.AllowUserToDeleteRows = false;
        dgvLichSuMua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvLichSuMua.BackgroundColor = System.Drawing.Color.White;
        dgvLichSuMua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvLichSuMua.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvLichSuMua.Location = new System.Drawing.Point(3, 3);
        dgvLichSuMua.MultiSelect = false;
        dgvLichSuMua.Name = "dgvLichSuMua";
        dgvLichSuMua.ReadOnly = true;
        dgvLichSuMua.RowHeadersWidth = 51;
        dgvLichSuMua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvLichSuMua.Size = new System.Drawing.Size(968, 300);
        dgvLichSuMua.TabIndex = 2;
        // 
        // FormLichSuMuaHang
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(900, 500);
        Controls.Add(panel1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Lịch sử mua hàng";
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvLichSuMua).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.Label lblKhachHang;
    private System.Windows.Forms.DataGridView dgvLichSuMua;

    #endregion
}

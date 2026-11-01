using System.ComponentModel;

namespace MiniMart.Forms;

partial class MHDangNhap
{
  private System.ComponentModel.IContainer components = null;
  
  private System.Windows.Forms.Panel panel;
  private System.Windows.Forms.Label title;
  private System.Windows.Forms.Label sub;
  private System.Windows.Forms.Label userLabel;
  private System.Windows.Forms.Label passLabel;
  private System.Windows.Forms.TextBox username;
  private System.Windows.Forms.TextBox password;
  private System.Windows.Forms.Button loginBuuton;
  
  
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        panel = new Panel();
        title = new Label();
        sub = new Label();
        userLabel = new Label();
        passLabel = new Label();
        username = new TextBox(); 
        password = new TextBox();
        loginBuuton = new Button();
        
        SuspendLayout();
        //MhDangNhap
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(430, 390);
        string text = "MINIMART POS — ĐĂNG NHẬP";
//        StartPosition = FromStartPosition.CenterScreen;
//
        MaximizeBox = false;
        
        //panel
        panel.Dock = DockStyle.Fill;
        panel.Padding =new Padding(35);
        panel.BackColor = Color.White;
        
        //title
        title.Text = "MiniMart";
        title.Font = new Font("Segoe UI",21,FontStyle.Bold);
        title.AutoSize = true;
        title.Location = new Point(70, 10);
        
        //subtitle
        sub.Text = "Đăng nhập để tiếp tục";
        sub.AutoSize = true;
        sub.Location = new Point(105, 65);
        
        //tenNguoiDung
        userLabel.Text = "Tên đăng nhập";
        userLabel.AutoSize = true;
        userLabel.Location = new Point(35,112);
        
        username.Location = new Point(35, 135);
        username.Width = 280;
        username.Text = "admmin";
        
        //matKhau
        passLabel.Text = "Mật Khẩu";
        passLabel.AutoSize = true;
        passLabel.Location = new Point(35, 180);
        
        password.Location = new Point(35, 203);
        password.Width = 280;
        password.UseSystemPasswordChar = true;
        
        // nut Dang Nhap
        loginBuuton.Text = "ĐĂNG NHẬP";
        loginBuuton.Location = new Point(35, 250);
        loginBuuton.Size = new Size(280, 42);
        
        // hoat dong 
        panel.Controls.AddRange(new Control[]
        {
            title,sub,userLabel,passLabel,username
            ,password,loginBuuton
        });
        Controls.Add(panel);
        
        ResumeLayout(false);
    }
    
}
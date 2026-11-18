
using MiniMart.Data;
using MiniMart.Forms;

namespace MiniMart;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        CoSoDuLieu.KhoiTao();

        while (true)
        {
            using (var login = new FormDangNhap())
            {
                if (login.ShowDialog() != DialogResult.OK) break;
            }

            var main = new MainForm();
            Application.Run(main);
            if (!main.DangXuat) break;
        }
        
    }
    
    
}
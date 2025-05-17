using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.DangNhap;

namespace HotelManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormDangNhap formLogin = new FormDangNhap();

            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                string tenNV = formLogin.Tag?.ToString();  // Lấy tên nhân viên từ Tag
                Application.Run(new FormMain(tenNV));      // Truyền tên nhân viên vào FormMain
            }
        }
    }
}

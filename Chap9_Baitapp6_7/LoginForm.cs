using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap9_Baitapp6_7
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenTaiKhoan.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            // Chuỗi kết nối CSDL (chỉnh theo server của bạn)
            string connectionString = @"Data Source=localhost;Initial Catalog=Chap9_Baitap6;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM user_account WHERE username = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                conn.Close();

                if (count == 1)
                {

                    this.Hide();
                    MainForm main = new MainForm();
                    main.ShowDialog();  // chờ MainForm chạy xong mới tiếp tục
                    this.Close();       // đóng hẳn LoginForm khi MainForm đóng
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

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
using HotelManagement.KetNoiCSDL;

namespace HotelManagement.TaiKhoan
{
    public partial class FormSuaTaiKhoan : Form
    {
        private string _tenTK;

        public FormSuaTaiKhoan(string tenTK)
        {
            InitializeComponent();
            _tenTK = tenTK;
        }

        private void FormSuaTaiKhoan_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"
SELECT tk.TenTK, tk.Password, tk.CapDoQuyen, nv.MaNV
FROM TaiKhoan tk
JOIN NhanVien nv ON tk.MaNV = nv.MaNV
WHERE tk.TenTK = @TenTK";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenTK", _tenTK);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtTenTK.Text = reader["TenTK"].ToString();
                    txtMatKhau.Text = reader["Password"].ToString();
                    cbCapDoQuyen.SelectedItem = Convert.ToInt32(reader["CapDoQuyen"]);
                    txtMaNV.Text = reader["MaNV"].ToString();
                }
                reader.Close();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string tenTK = txtTenTK.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            int quyen = int.Parse(cbCapDoQuyen.SelectedItem.ToString());

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string updateQuery = @"
UPDATE TaiKhoan 
SET Password = @Password, CapDoQuyen = @CapDoQuyen, TenTK = @TenTK
WHERE mAnv = @maNV";

                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@Password", matKhau);
                cmd.Parameters.AddWithValue("@CapDoQuyen", quyen);
                cmd.Parameters.AddWithValue("@TenTK", tenTK);
                cmd.Parameters.AddWithValue("@maNV", maNV);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Cập nhật tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

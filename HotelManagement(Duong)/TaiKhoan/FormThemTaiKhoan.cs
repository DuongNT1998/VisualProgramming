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
    public partial class FormThemTaiKhoan : Form
    {
        public FormThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormThemTaiKhoan_Load(object sender, EventArgs e)
        {

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "SELECT MaNV FROM NhanVien WHERE DaXoa = 0";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbMaNV.Items.Add(reader["MaNV"].ToString());
                }
                reader.Close();
            }
            cbCapDoQuyen.SelectedIndex = 0; // mặc định
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string tenTK = txtTenTK.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string maNV = cbMaNV.SelectedItem?.ToString();
            int quyen = int.Parse(cbCapDoQuyen.SelectedItem.ToString());

            if (string.IsNullOrEmpty(tenTK) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                // Kiểm tra trùng tên tài khoản
                string checkQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE TenTK = @TenTK";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@TenTK", tenTK);
                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Thêm mới
                string insertQuery = @"
            INSERT INTO TaiKhoan(TenTK, Password, CapDoQuyen, MaNV, DaXoa)
            VALUES (@TenTK, @Password, @CapDoQuyen, @MaNV, 0)";

                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@TenTK", tenTK);
                cmd.Parameters.AddWithValue("@Password", matKhau); // Có thể mã hóa ở đây nếu cần
                cmd.Parameters.AddWithValue("@CapDoQuyen", quyen);
                cmd.Parameters.AddWithValue("@MaNV", maNV);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Thêm tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form sau khi thêm
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

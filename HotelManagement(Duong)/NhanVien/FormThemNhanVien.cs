using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.KetNoiCSDL;

namespace HotelManagement.NhanVien
{
    public partial class FormThemNhanVien : Form
    {
        public FormThemNhanVien()
        {
            InitializeComponent();
        }

        private void FormThemNhanVien_Load(object sender, EventArgs e)
        {
          
            cbGioiTinh.SelectedIndex = 0;
            cbGioiTinh.SelectedIndex = 0;
        }
 
        private void ChiNhapSo(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string tenNV = txtHoTenNV.Text.Trim();
            string chucVu = cbChucVu.SelectedItem.ToString();
            string luong = txtLuong.Text.Trim();
            string sdt = txtSoDT.Text.Trim();
            string cccd = txtSoCCCD.Text.Trim();
            DateTime ngaySinh = dtNgaySinh.Value;
            string gioiTinh = cbGioiTinh.SelectedItem.ToString();
            string diaChi = txtDiaChi.Text.Trim();
            string email = txtEmail.Text.Trim();

            // Kiểm tra bắt buộc
            if (tenNV == "" || luong == "" || sdt == "" || cccd == "" || diaChi == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không đúng định dạng.");
                return;
            }

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"INSERT INTO NhanVien (MaNV, TenNV, ChucVu, Luong, SDT, CCCD, NgaySinh, GioiTinh, DiaChi, Email, DaXoa)
                         VALUES (@MaNV, @TenNV, @ChucVu, @Luong, @SDT, @CCCD, @NgaySinh, @GioiTinh, @DiaChi, @Email, 0)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                cmd.Parameters.AddWithValue("@TenNV", tenNV);
                cmd.Parameters.AddWithValue("@ChucVu", chucVu);
                cmd.Parameters.AddWithValue("@Luong", decimal.Parse(luong));
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@CCCD", cccd);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@Email", email);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhân viên thành công.");
                    this.DialogResult = DialogResult.OK;
                    this.Close(); // hoặc clear form nếu bạn muốn nhập tiếp
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("UNIQUE KEY constraint"))
                        MessageBox.Show("Số điện thoại, CCCD hoặc email đã tồn tại.");
                    else
                        MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}

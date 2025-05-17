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
    public partial class FormSuaNhanVien : Form
    {
        private string _maNV;

        public FormSuaNhanVien(string maNV)
        {
            InitializeComponent();
            _maNV = maNV;
        }
        private void FormSuaNhanVien_Load(object sender, EventArgs e)
        {
            // Tải thông tin nhân viên hiện tại vào form
            LoadThongTinNhanVien(_maNV);
        }
        private void LoadThongTinNhanVien(string maNV)
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "SELECT * FROM NhanVien WHERE MaNV = @MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", _maNV);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtMaNV.Text = reader["MaNV"].ToString();
                    txtHoTenNV.Text = reader["TenNV"].ToString();
                    cbChucVu.SelectedItem = reader["ChucVu"].ToString();
                    txtLuong.Text = reader["Luong"].ToString();
                    txtSoDT.Text = reader["SDT"].ToString();
                    txtSoCCCD.Text = reader["CCCD"].ToString();
                    dtNgaySinh.Value = Convert.ToDateTime(reader["NgaySinh"]);
                    cbGioiTinh.SelectedItem = reader["GioiTinh"].ToString();
                    txtDiaChi.Text = reader["DiaChi"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                }
            }
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string tenNV = txtHoTenNV.Text.Trim();
            string chucVu = cbChucVu.SelectedItem.ToString();
            string luong = txtLuong.Text.Trim();
            string sdt = txtSoDT.Text.Trim();
            string cccd = txtSoCCCD.Text.Trim();
            DateTime ngaySinh = dtNgaySinh.Value;
            string gioiTinh = cbGioiTinh.SelectedItem.ToString();
            string diaChi = txtDiaChi.Text.Trim();
            string email = txtEmail.Text.Trim();

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
                string query = @"UPDATE NhanVien
                             SET TenNV = @TenNV, ChucVu = @ChucVu, Luong = @Luong, SDT = @SDT, CCCD = @CCCD, 
                                 NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, Email = @Email
                             WHERE MaNV = @MaNV";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", _maNV);
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
                    MessageBox.Show("Cập nhật nhân viên thành công.");
                    this.DialogResult = DialogResult.OK;    
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }

      
    }


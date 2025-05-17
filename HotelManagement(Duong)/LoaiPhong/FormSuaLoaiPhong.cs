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

namespace HotelManagement.LoaiPhong
{
    public partial class FormSuaLoaiPhong : Form
    {
        public string MaLoaiPhong { get; set; }
        public FormSuaLoaiPhong()
        {
            InitializeComponent();
        }

        private void FormSuaLoaiPhong_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "SELECT * FROM LoaiPhong WHERE MaLPH = @ma";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma", MaLoaiPhong);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtTenLP.Text = reader["TenLPH"].ToString();
                    txtSoGiuong.Text = reader["SoGiuong"].ToString();
                    txtSoNguoiToiDa.Text = reader["SoNguoiToiDa"].ToString();
                    txtGiaNgay.Text = reader["GiaNgay"].ToString();
                    txtGiaGio.Text = reader["GiaGio"].ToString();
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Kiểm tra giá trị nhập vào có phải là số hợp lệ không
            decimal giaNgay, giaGio;
            if (!decimal.TryParse(txtGiaNgay.Text.Trim(), out giaNgay))
            {
                MessageBox.Show("Giá ngày không hợp lệ!");
                return;
            }

            if (!decimal.TryParse(txtGiaGio.Text.Trim(), out giaGio))
            {
                MessageBox.Show("Giá giờ không hợp lệ!");
                return;
            }

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"UPDATE LoaiPhong 
                         SET TenLPH = @ten, SoGiuong = @giuong, SoNguoiToiDa = @songuoi, GiaNgay = @ngay, GiaGio = @gio 
                         WHERE MaLPH = @ma";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ten", txtTenLP.Text.Trim());
                cmd.Parameters.AddWithValue("@giuong", txtSoGiuong.Text.Trim());
                cmd.Parameters.AddWithValue("@songuoi", txtSoNguoiToiDa.Text.Trim());
                cmd.Parameters.AddWithValue("@ngay", giaNgay);  // Sử dụng giá trị decimal
                cmd.Parameters.AddWithValue("@gio", giaGio);    // Sử dụng giá trị decimal
                cmd.Parameters.AddWithValue("@ma", MaLoaiPhong);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật!");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

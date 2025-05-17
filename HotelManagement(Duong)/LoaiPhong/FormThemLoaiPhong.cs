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
    public partial class FormThemLoaiPhong : Form
    {
        public FormThemLoaiPhong()
        {
            InitializeComponent();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            // Kiểm tra giá trị nhập vào có hợp lệ không
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
                string query = @"INSERT INTO LoaiPhong (MaLPH, TenLPH, SoGiuong, SoNguoiToiDa, GiaNgay, GiaGio) 
                             VALUES (@ma, @ten, @giuong, @songuoi, @ngay, @gio)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma", txtMaLoaiPhong.Text.Trim());
                cmd.Parameters.AddWithValue("@ten", txtTenLP.Text.Trim());
                cmd.Parameters.AddWithValue("@giuong", txtSoGiuong.Text.Trim());
                cmd.Parameters.AddWithValue("@songuoi", txtSoNguoiToiDa.Text.Trim());
                cmd.Parameters.AddWithValue("@ngay", giaNgay);  // Sử dụng giá trị decimal
                cmd.Parameters.AddWithValue("@gio", giaGio);    // Sử dụng giá trị decimal

                try
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Thêm loại phòng thành công!");
                        this.Close(); // Đóng form sau khi thêm thành công
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm loại phòng!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

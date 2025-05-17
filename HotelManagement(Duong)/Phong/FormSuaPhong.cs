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

namespace HotelManagement.Phong
{
    public partial class FormSuaPhong : Form
    {
        private string maPhong;
        public FormSuaPhong(string maPhong)
        {
            InitializeComponent();
            this.maPhong = maPhong;
            LoadLoaiPhong();
            LoadThongTinPhong();

        }
        private void LoadThongTinPhong()
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "SELECT TTPH, TTDD, MaLPH, GhiChu FROM Phong WHERE MaPH = @MaPH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPH", maPhong);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    cbTrangThaiPhong.SelectedItem = reader["TTPH"].ToString();
                    cbTinhTrangDonDep.SelectedItem = reader["TTDD"].ToString();
                    cbLoaiPhong.SelectedValue = reader["MaLPH"].ToString();
                    txtGhiChu.Text = reader["GhiChu"].ToString();
                }
            }
        }
        private void LoadLoaiPhong()
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "SELECT MaLPH, TenLPH FROM LoaiPhong";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbLoaiPhong.DataSource = dt;
                cbLoaiPhong.DisplayMember = "TenLPH";
                cbLoaiPhong.ValueMember = "MaLPH";
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"UPDATE Phong 
                         SET TTPH = @TTPH, 
                             TTDD = @TTDD, 
                             MaLPH = @MaLPH, 
                             GhiChu = @GhiChu
                         WHERE MaPH = @MaPH";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TTPH", cbTrangThaiPhong.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@TTDD", cbTinhTrangDonDep.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@MaLPH", cbLoaiPhong.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text.Trim());
                cmd.Parameters.AddWithValue("@MaPH", maPhong);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật.");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

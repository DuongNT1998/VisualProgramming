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

namespace HotelManagement.KhachHang
{
    public partial class FormSuaKhachHang : Form
    {
        private string maKH;

        public FormSuaKhachHang(string maKH)
        {
            InitializeComponent();
            this.maKH = maKH;
        }

        private void FormSuaKhachHang_Load(object sender, EventArgs e)
        {

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "SELECT * FROM KhachHang WHERE MaKH = @MaKH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKH", maKH);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtMaKH.Text = reader["MaKH"].ToString();
                    txtHoVaTen.Text = reader["TenKH"].ToString();
                    txtSoDienThoai.Text = reader["SDT"].ToString();
                    txtCCCD.Text = reader["CCCD/Passport"].ToString();
                    txtQuocTich.Text = reader["QuocTich"].ToString();
                    cbGioiTinh.Text = reader["GioiTinh"].ToString();
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"UPDATE KhachHang SET TenKH = @TenKH, SDT = @SDT, [CCCD/Passport] = @CCCD, 
                         QuocTich = @QuocTich, GioiTinh = @GioiTinh WHERE MaKH = @MaKH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenKH", txtHoVaTen.Text);
                cmd.Parameters.AddWithValue("@SDT", txtSoDienThoai.Text);
                cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
                cmd.Parameters.AddWithValue("@QuocTich", txtQuocTich.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", cbGioiTinh.Text);
                cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void OnlyAllowDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

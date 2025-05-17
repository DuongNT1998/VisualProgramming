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

namespace HotelManagement.DichVu
{
    public partial class FormSuaDichVu : Form
    {
        public string maDV;
        public FormSuaDichVu(string maDV)
        {
            InitializeComponent();
            this.maDV = maDV;
        }
        
        private void FormSuaDichVu_Load(object sender, EventArgs e)
        {
            LoadDanhSachDichVu();

        }
        private void LoadDanhSachDichVu()
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "SELECT * FROM DichVu WHERE MaDV = @MaDV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDV", maDV);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtTenDV.Text = reader["TenDV"].ToString();
                    txtDonGia.Text = reader["DonGia"].ToString();
                    txtSoLuongConLai.Text = reader["SLConLai"].ToString();
                    cbLoaiDV.SelectedItem = reader["LoaiDV"].ToString();
                }
            }
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"UPDATE DichVu 
                             SET TenDV = @TenDV, DonGia = @DonGia, 
                                 SLConLai = @SLConLai, LoaiDV = @LoaiDV 
                             WHERE MaDV = @MaDV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenDV", txtTenDV.Text.Trim());
                cmd.Parameters.AddWithValue("@DonGia", decimal.Parse(txtDonGia.Text.Trim()));
                cmd.Parameters.AddWithValue("@SLConLai", int.Parse(txtSoLuongConLai.Text.Trim()));
                cmd.Parameters.AddWithValue("@LoaiDV", cbLoaiDV.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@MaDV", maDV);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void txtSoLuongConLai_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số và phím điều hướng/backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số và phím điều hướng/backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

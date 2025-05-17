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

namespace HotelManagement.TienNghi
{
    public partial class FormSuaTienNghi : Form
    {
        string maTN;
        public FormSuaTienNghi(string maTN)
        {
            InitializeComponent();
            this.maTN = maTN;
        }
        private void FormSuaTienNghi_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "SELECT * FROM TienNghi WHERE MaTN = @MaTN";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaTN", maTN);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    txtTenTN.Text = reader["TenTN"].ToString();
                }
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string tenTN = txtTenTN.Text.Trim();

            if (string.IsNullOrEmpty(tenTN))
            {
                MessageBox.Show("Vui lòng nhập tên tiện nghi!");
                return;
            }

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "UPDATE TienNghi SET TenTN = @TenTN WHERE MaTN = @MaTN";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenTN", tenTN);
                cmd.Parameters.AddWithValue("@MaTN", maTN);

                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}

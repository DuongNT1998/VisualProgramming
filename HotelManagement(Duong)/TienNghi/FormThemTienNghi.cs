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
    public partial class FormThemTienNghi : Form
    {
        public FormThemTienNghi()
        {
            InitializeComponent();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string maTN = txtMaTN.Text.Trim();
            string tenTN = txtTenTN.Text.Trim();

            if (string.IsNullOrEmpty(maTN) || string.IsNullOrEmpty(tenTN))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                try
                {
                    string query = "INSERT INTO TienNghi (MaTN, TenTN, DaXoa) VALUES (@MaTN, @TenTN, 0)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaTN", maTN);
                    cmd.Parameters.AddWithValue("@TenTN", tenTN);

                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm mới tiện nghi thành công!");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm: " + ex.Message);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

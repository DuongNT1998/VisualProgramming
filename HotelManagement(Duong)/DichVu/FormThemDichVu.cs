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
    public partial class FormThemDichVu : Form
    {
        public FormThemDichVu()
        {
            InitializeComponent();
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số và phím điều hướng/backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDV.Text) ||
      string.IsNullOrWhiteSpace(txtTenDV.Text) ||
      string.IsNullOrWhiteSpace(txtDonGia.Text) ||
      string.IsNullOrWhiteSpace(txtSoLuongConLai.Text) ||
      cbLoaiDV.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu thông tin");
                return;
            }

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"INSERT INTO DichVu (MaDV, TenDV, DonGia, SLConLai, LoaiDV, DaXoa) 
                         VALUES (@MaDV, @TenDV, @DonGia, @SLConLai, @LoaiDV, 0)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDV", txtMaDV.Text.Trim());
                cmd.Parameters.AddWithValue("@TenDV", txtTenDV.Text.Trim());
                cmd.Parameters.AddWithValue("@DonGia", decimal.Parse(txtDonGia.Text.Trim()));
                cmd.Parameters.AddWithValue("@SLConLai", int.Parse(txtSoLuongConLai.Text.Trim()));
                cmd.Parameters.AddWithValue("@LoaiDV", cbLoaiDV.SelectedItem.ToString());

                try
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm dịch vụ thành công!", "Thành công");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!", "Lỗi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi khi thêm");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormThemDichVu_Load(object sender, EventArgs e)
        {

        }
    }
}

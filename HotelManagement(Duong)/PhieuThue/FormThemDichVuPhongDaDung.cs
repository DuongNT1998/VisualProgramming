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

namespace HotelManagement.PhieuThue
{
    public partial class FormThemDichVuPhongDaDung : Form
    {
        string maCTDP, soPhong;

        public FormThemDichVuPhongDaDung(string _maCTDP, string _soPhong)
        {
            InitializeComponent();
            maCTDP = _maCTDP;
            soPhong = _soPhong;
        }

        private void FormThemDichVuPhongDaDung_Load(object sender, EventArgs e)
        {
            lbSoCTPhieu.Text = "Mã CTDP: " + maCTDP;
            lbSoPhong.Text = "Số phòng: " + soPhong;

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "SELECT MaDV, TenDV FROM DichVu";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cbTenDV.DataSource = dt;
                cbTenDV.DisplayMember = "TenDV";
                cbTenDV.ValueMember = "MaDV";
            }
        }

        private void cbTenDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenDV.SelectedValue == null || cbTenDV.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            string maDV = cbTenDV.SelectedValue.ToString();

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "SELECT DonGia FROM DichVu WHERE MaDV = @MaDV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDV", maDV);

                object donGia = cmd.ExecuteScalar();

                if (donGia != null)
                {
                    txtMaDV.Text = maDV;
                    txtDonGia.Text = donGia.ToString();
                }
                else
                {
                    txtMaDV.Text = "";
                    txtDonGia.Text = "";
                }
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }
        private void TinhThanhTien()
        {
            if (int.TryParse(txtSoLuong.Text, out int soLuong) && decimal.TryParse(txtDonGia.Text, out decimal donGia))
            {
                decimal thanhTien = soLuong * donGia;
                lbThanhTien.Text = "Thành tiền: " + thanhTien.ToString("N0");
            }
            else
            {
                lbThanhTien.Text = "Thành tiền: 0";
            }
        }
        private void btnThemDV_Click(object sender, EventArgs e)
        {
            string maDV = txtMaDV.Text.Trim();
            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ.");
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia))
            {
                MessageBox.Show("Đơn giá không hợp lệ.");
                return;
            }

            decimal thanhTien = soLuong * donGia;

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"
            INSERT INTO CTDV (MaCTDP, MaDV, SL, ThanhTien)
            VALUES (@MaCTDP, @MaDV, @SL, @ThanhTien)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaCTDP", maCTDP);
                cmd.Parameters.AddWithValue("@MaDV", maDV);
                cmd.Parameters.AddWithValue("@SL", soLuong);
                cmd.Parameters.AddWithValue("@ThanhTien", thanhTien);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Thêm dịch vụ thành công.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại.");
                }
            }
        }
    }
}

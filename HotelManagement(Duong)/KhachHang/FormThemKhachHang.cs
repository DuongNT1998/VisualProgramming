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
    public partial class FormThemKhachHang : Form
    {
        public FormThemKhachHang()
        {
            InitializeComponent();
        }
        private string GenerateMaKH()
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "SELECT TOP 1 MaKH FROM KhachHang ORDER BY MaKH DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string lastMaKH = result.ToString(); // VD: KH012
                    int number = int.Parse(lastMaKH.Substring(2)) + 1;
                    return "KH" + number.ToString("D3"); // => KH013
                }
                else
                {
                    return "KH001";
                }
            }
        }
        private void FormThemKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKH.Text = GenerateMaKH();
            cbGioiTinh.SelectedIndex = 0; // Mặc định chọn "Nam"
        }
        private void OnlyAllowDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text) || string.IsNullOrWhiteSpace(txtCCCD.Text) || string.IsNullOrWhiteSpace(cbGioiTinh.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc.");
                return;
            }

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"INSERT INTO KhachHang (MaKH, TenKH, SDT, [CCCD/Passport], QuocTich, GioiTinh, DaXoa)
                         VALUES (@MaKH, @TenKH, @SDT, @CCCD, @QuocTich, @GioiTinh, 0)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                cmd.Parameters.AddWithValue("@TenKH", txtHoVaTen.Text);
                cmd.Parameters.AddWithValue("@SDT", txtSoDienThoai.Text);
                cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
                cmd.Parameters.AddWithValue("@QuocTich", txtQuocTich.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", cbGioiTinh.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm khách hàng thành công!");
                    this.DialogResult = DialogResult.OK; // Quan trọng!!!
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm: " + ex.Message);
                }
            }
        }

      
    }
}

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

namespace HotelManagement.ChiTietTienNghi
{
    public partial class FormThemChiTietTienNghi : Form
    {
        private string _maLPH; // Mã loại phòng được truyền vào

        public FormThemChiTietTienNghi(string maLPH)
        {
            InitializeComponent();
            _maLPH = maLPH;
        }

        private void FormThemChiTietTienNghi_Load(object sender, EventArgs e)
        {
            LoadTienNghiChuaThem();
            
        }
        private void LoadTienNghiChuaThem()
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"
                SELECT MaTN, TenTN 
                FROM TienNghi 
                WHERE DaXoa = 0 AND MaTN NOT IN (
                    SELECT MaTN FROM CTTN WHERE MaLPH = @MaLPH AND DaXoa = 0
                )";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLPH", _maLPH);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

               cbTenTN.DataSource = dt;
                cbTenTN.DisplayMember = "TenTN";
                cbTenTN.ValueMember = "MaTN";
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtSoLuong.Text) || cbTenTN.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maTN = cbTenTN.SelectedValue.ToString();

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"
                INSERT INTO CTTN(MaLPH, MaTN, SL, DaXoa)
                VALUES (@MaLPH, @MaTN, @SL, 0)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLPH", _maLPH);
                cmd.Parameters.AddWithValue("@MaTN", maTN);
                cmd.Parameters.AddWithValue("@SL", soLuong);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // hoặc this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

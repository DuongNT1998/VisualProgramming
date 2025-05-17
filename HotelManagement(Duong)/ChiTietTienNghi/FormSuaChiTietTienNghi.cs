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
    public partial class FormSuaChiTietTienNghi : Form
    {
        private string _maLPH;
        private string _maTN;
        private string _tenTN;
        private int _soLuongHienTai;

        public FormSuaChiTietTienNghi(string maLPH, string maTN, string tenTN, int soLuong)
        {
            InitializeComponent();
            _maLPH = maLPH;
            _maTN = maTN;
            _tenTN = tenTN;
            _soLuongHienTai = soLuong;
        }

        private void FormSuaChiTietTienNghi_Load(object sender, EventArgs e)
        {
            txtTenTN.Text = _tenTN;
            txtSoLuong.Text = _soLuongHienTai.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuongMoi))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"
                UPDATE CTTN
                SET SL = @SoLuong
                WHERE MaLPH = @MaLPH AND MaTN = @MaTN";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SoLuong", soLuongMoi);
                cmd.Parameters.AddWithValue("@MaLPH", _maLPH);
                cmd.Parameters.AddWithValue("@MaTN", _maTN);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

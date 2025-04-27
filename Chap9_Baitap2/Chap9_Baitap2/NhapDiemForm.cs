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
using Microsoft.SqlServer.Server;

namespace Chap9_Baitap2
{
    public partial class NhapDiemForm : Form
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=Chap9_Baitap2;Integrated Security=True;TrustServerCertificate=True;"; // thay TenCSDL bằng tên thật

        public NhapDiemForm()
        {
            InitializeComponent();
            LoadSinhVien();
            LoadMonHoc();

        }
        private void LoadSinhVien()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT MaSo, HoTen FROM SinhVien", conn);
                var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                cbMasoSV.DataSource = dt.Copy();
                cbMasoSV.DisplayMember = "MaSo";
                cbMasoSV.ValueMember = "MaSo";

                cbHoTenSV.DataSource = dt.Copy();
                cbHoTenSV.DisplayMember = "HoTen";
                cbHoTenSV.ValueMember = "MaSo";
            }
        }

        private void LoadMonHoc()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT MaMH, TenMH FROM MonHoc", conn);
                var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                cbMaMH.DataSource = dt.Copy();
                cbMaMH.DisplayMember = "MaMH";
                cbMaMH.ValueMember = "MaMH";

                cbTenMH.DataSource = dt.Copy();
                cbTenMH.DisplayMember = "TenMH";
                cbTenMH.ValueMember = "MaMH";
            }
        }

        private void cbMasoSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHoTenSV.SelectedValue = cbMasoSV.SelectedValue;
        }

        private void cbHoTenSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMasoSV.SelectedValue = cbHoTenSV.SelectedValue;
        }

        private void cbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTenMH.SelectedValue = cbMaMH.SelectedValue;
        }

        private void cbTenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaMH.SelectedValue = cbTenMH.SelectedValue;
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            string maSo = cbMasoSV.SelectedValue.ToString();
            string maMH = cbMaMH.SelectedValue.ToString();
            float diem;

            if (!float.TryParse(txtNhapDiem.Text, out diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm không hợp lệ! Vui lòng nhập số từ 0 đến 10.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Kiểm tra xem đã tồn tại điểm chưa
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Ketqua WHERE MaSo = @MaSo AND MaMH = @MaMH", conn);
                checkCmd.Parameters.AddWithValue("@MaSo", maSo);
                checkCmd.Parameters.AddWithValue("@MaMH", maMH);
                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                    SqlCommand insertCmd = new SqlCommand("INSERT INTO Ketqua (MaSo, MaMH, DiemThi) VALUES (@MaSo, @MaMH, @DiemThi)", conn);
                    insertCmd.Parameters.AddWithValue("@MaSo", maSo);
                    insertCmd.Parameters.AddWithValue("@MaMH", maMH);
                    insertCmd.Parameters.AddWithValue("@DiemThi", diem);

                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Nhập điểm thành công!");
                }
                else
                {
                    // Cho phép cập nhật nếu đã có điểm
                    DialogResult dialog = MessageBox.Show("Sinh viên này đã có điểm môn học này. Bạn có muốn cập nhật không?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        SqlCommand updateCmd = new SqlCommand("UPDATE ketqua SET DiemThi = @DiemThi WHERE MaSo = @MaSo AND MaMH = @MaMH", conn);
                        updateCmd.Parameters.AddWithValue("@MaSo", maSo);
                        updateCmd.Parameters.AddWithValue("@MaMH", maMH);
                        updateCmd.Parameters.AddWithValue("@DiemThi", diem);
                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật điểm thành công!");
                    }
                }
            }
        }
    }
}

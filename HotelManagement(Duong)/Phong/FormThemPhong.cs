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

namespace HotelManagement.Phong
{
    public partial class FormThemPhong : Form
    {
        public FormThemPhong()
        {
            InitializeComponent();
        }

        private void FormThemPhong_Load(object sender, EventArgs e)
        {
            // Load loại phòng
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                SqlCommand cmd = new SqlCommand("SELECT MaLPH, TenLPH FROM LoaiPhong", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbLoaiPhong.DataSource = dt;
                cbLoaiPhong.DisplayMember = "TenLPH";
                cbLoaiPhong.ValueMember = "MaLPH";
            }

            cbTrangThaiPhong.SelectedIndex = 0;
            cbTinhTrangDonDep.SelectedIndex = 0;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string maPH = txtMaPhong.Text.Trim();
            string trangThai = cbTrangThaiPhong.SelectedItem.ToString();
            string donDep = cbTinhTrangDonDep.SelectedItem.ToString();
            string maLPH = cbLoaiPhong.SelectedValue.ToString();
            string ghiChu = txtGhiChu.Text.Trim();

            if (string.IsNullOrEmpty(maPH))
            {
                MessageBox.Show("Vui lòng nhập mã phòng.");
                return;
            }

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                try
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    // 1. Kiểm tra trùng mã phòng
                    string checkQuery = "SELECT COUNT(*) FROM Phong WHERE MaPH = @MaPH AND DaXoa = 0";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@MaPH", maPH);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Mã phòng đã tồn tại. Vui lòng nhập mã khác.", "Thông báo");
                        return;
                    }

                    // 2. Thêm mới nếu không trùng
                    string insertQuery = "INSERT INTO Phong (MaPH, TTPH, TTDD, GhiChu, MaLPH, DaXoa) " +
                                         "VALUES (@MaPH, @TTPH, @TTDD, @GhiChu, @MaLPH, 0)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@MaPH", maPH);
                    insertCmd.Parameters.AddWithValue("@TTPH", trangThai);
                    insertCmd.Parameters.AddWithValue("@TTDD", donDep);
                    insertCmd.Parameters.AddWithValue("@GhiChu", ghiChu);
                    insertCmd.Parameters.AddWithValue("@MaLPH", maLPH);

                    int result = insertCmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm phòng thành công!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm phòng.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm phòng: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

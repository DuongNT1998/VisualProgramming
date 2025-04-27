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

namespace Chap9_Baitap2
{
    public partial class ThongKeKhoaForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Chap9_Baitap2;Integrated Security=True;TrustServerCertificate=True;");

        public ThongKeKhoaForm()
        {
            InitializeComponent();
        }

        private void ThongKeKhoaForm_Load(object sender, EventArgs e)
        {

            // Lấy danh sách mã khoa và tên khoa từ database
            string connectionString = @"Data Source=localhost;Initial Catalog=Chap9_Baitap2;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaKhoa, TenKhoa FROM Khoa"; // Thay đổi bảng Khoa nếu cần
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cbMaKhoa.DisplayMember = "MaKhoa";
                cbMaKhoa.ValueMember = "MaKhoa";
                cbMaKhoa.DataSource = dt;

                cbTenKhoa.DisplayMember = "TenKhoa";
                cbTenKhoa.ValueMember = "MaKhoa"; // Liên kết với MaKhoa
                cbTenKhoa.DataSource = dt;
            }
        }

        private void cbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi chọn mã khoa, cập nhật tên khoa
            if (cbMaKhoa.SelectedIndex != -1)
            {
                string selectedMaKhoa = cbMaKhoa.SelectedValue.ToString();
                cbTenKhoa.SelectedValue = selectedMaKhoa;
            }
        }

        private void cbTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi chọn tên khoa, cập nhật mã khoa
            if (cbTenKhoa.SelectedIndex != -1)
            {
                string selectedMaKhoa = cbTenKhoa.SelectedValue.ToString();
                cbMaKhoa.SelectedValue = selectedMaKhoa;
            }
        }

        private void btnXemDSSV_Click(object sender, EventArgs e)
        {
            string maKhoa = cbMaKhoa.SelectedValue.ToString();
            string connectionString = @"Data Source=localhost;Initial Catalog=Chap9_Baitap2;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaSo, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai FROM SinhVien WHERE MaKhoa = @MaKhoa";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dtgXemDSSVTheoKhoa.DataSource = dt;
            }
        }
    }
}

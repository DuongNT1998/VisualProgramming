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
    public partial class XemDiemForm : Form
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=Chap9_Baitap2;Integrated Security=True;TrustServerCertificate=True;"; // thay TenCSDL bằng tên thật

        public XemDiemForm()
        {
            InitializeComponent();
            LoadData();  // Gọi hàm để load dữ liệu khi form được mở
        }

        // Hàm load dữ liệu cho các ComboBox khi form mở
        private void LoadData()
        {
            // Load dữ liệu Mã số SV vào ComboBox cbMasoSV
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MaSo FROM SINHVIEN";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbMasoSV.Items.Add(reader["MaSo"].ToString());
                }
                reader.Close();
            }

            // Load dữ liệu Họ tên SV vào ComboBox cnHoTenSV
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT HoTen FROM SINHVIEN";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cnHoTenSV.Items.Add(reader["HoTen"].ToString());
                }
                reader.Close();
            }
        }

        private void cbMasoSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maSoSV = cbMasoSV.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(maSoSV))
            {
                string hoTenSV = GetHoTenFromMaSo(maSoSV);  // Chỉnh lại tên hàm
                cnHoTenSV.SelectedItem = hoTenSV;

                // Lấy và hiển thị tên khoa
                string tenKhoa = GetTenKhoaFromMaSo(maSoSV);
                txtTenKhoa.Text = tenKhoa;  // Hiển thị tên khoa vào TextBox
            }
        }

        private void cnHoTenSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hoTenSV = cnHoTenSV.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(hoTenSV))
            {
                string maSoSV = GetMaSoFromHoTen(hoTenSV);  // Chỉnh lại tên hàm
                cbMasoSV.SelectedItem = maSoSV;

                // Lấy và hiển thị tên khoa
                string tenKhoa = GetTenKhoaFromMaSo(maSoSV);
                txtTenKhoa.Text = tenKhoa;  // Hiển thị tên khoa vào TextBox
            }
        }
        // Hàm lấy tên khoa từ MaSo
        private string GetTenKhoaFromMaSo(string maSoSV)
        {
            string tenKhoa = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT Khoa.TenKhoa 
                         FROM SINHVIEN 
                         JOIN Khoa ON SINHVIEN.MaKhoa = Khoa.MaKhoa
                         WHERE SINHVIEN.MaSo = @MaSo";  // Cập nhật lại tên cột
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaSo", maSoSV);

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    tenKhoa = result.ToString();
                }
            }

            return tenKhoa;
        }

        // Hàm lấy Họ tên từ Mã số SV
        private string GetHoTenFromMaSo(string maSoSV)
        {
            string hoTen = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT HoTen FROM SINHVIEN WHERE MaSo = @MaSo";  // Cập nhật lại tên cột
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaSo", maSoSV);

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    hoTen = result.ToString();
                }
            }

            return hoTen;
        }

        // Hàm lấy Mã số SV từ Họ tên
        private string GetMaSoFromHoTen(string hoTen)
        {
            string maSoSV = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MaSo FROM SINHVIEN WHERE HoTen = @HoTen";  // Cập nhật lại tên cột
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@HoTen", hoTen);

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    maSoSV = result.ToString();
                }
            }

            return maSoSV;
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            string maSoSV = cbMasoSV.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(maSoSV))
            {
                MessageBox.Show("Vui lòng chọn mã số sinh viên.");
                return;
            }

            // Tạo câu truy vấn để lấy điểm của sinh viên
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT MonHoc.TenMH, Ketqua.DiemThi
                         FROM Ketqua
                         JOIN MonHoc ON  Ketqua.MaMH = MonHoc.MaMH
                         WHERE Ketqua.MaSo = @MaSo";  // Cập nhật lại tên cột
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaSo", maSoSV);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Xoá dữ liệu cũ trong DataGridView
                dtgXemDiem.Rows.Clear();

                // Thêm dữ liệu vào DataGridView
                while (reader.Read())
                {
                    dtgXemDiem.Rows.Add(reader["TenMH"].ToString(), reader["DiemThi"].ToString());
                }

                reader.Close();
            }
        }
    }

}

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
using HotelManagement.DichVu;
using HotelManagement.KetNoiCSDL;
using Excel = Microsoft.Office.Interop.Excel;

namespace HotelManagement.KhachHang
{
    public partial class FormDanhSachKhachHang : Form
    {
        public FormDanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void FormDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            LoadDanhSachKhachHang();
        }
        private void LoadDanhSachKhachHang()
        {
            dtgDanhSachKhachHang.Rows.Clear();
            dtgDanhSachKhachHang.Columns.Clear();

            // Cột icon (Khách hàng + Mã KH)
            DataGridViewImageColumn iconCol = new DataGridViewImageColumn();
            iconCol.Name = "Icon";
            iconCol.HeaderText = "";
            iconCol.Width = 40;
            dtgDanhSachKhachHang.Columns.Add(iconCol);

            // Các cột thông tin khách hàng
            dtgDanhSachKhachHang.Columns.Add("MaKH", "Mã KH");
            dtgDanhSachKhachHang.Columns.Add("TenKH", "Tên khách hàng");
            dtgDanhSachKhachHang.Columns.Add("SDT", "SĐT");
            dtgDanhSachKhachHang.Columns.Add("CCCD", "CCCD/Passport");
            dtgDanhSachKhachHang.Columns.Add("QuocTich", "Quốc tịch");
            dtgDanhSachKhachHang.Columns.Add("GioiTinh", "Giới tính");

            // Cột sửa
            DataGridViewImageColumn suaCol = new DataGridViewImageColumn();
            suaCol.Name = "Sua";
            suaCol.HeaderText = "Sửa";
            suaCol.Width = 40;
            dtgDanhSachKhachHang.Columns.Add(suaCol);

            // Cột xóa
            DataGridViewImageColumn xoaCol = new DataGridViewImageColumn();
            xoaCol.Name = "Xoa";
            xoaCol.HeaderText = "Xóa";
            xoaCol.Width = 40;
            dtgDanhSachKhachHang.Columns.Add(xoaCol);

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "SELECT * FROM KhachHang WHERE DaXoa = 0";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int row = dtgDanhSachKhachHang.Rows.Add();

                    dtgDanhSachKhachHang.Rows[row].Cells["MaKH"].Value = reader["MaKH"].ToString();
                    dtgDanhSachKhachHang.Rows[row].Cells["TenKH"].Value = reader["TenKH"].ToString();
                    dtgDanhSachKhachHang.Rows[row].Cells["SDT"].Value = reader["SDT"].ToString();
                    dtgDanhSachKhachHang.Rows[row].Cells["CCCD"].Value = reader["CCCD/Passport"].ToString();
                    dtgDanhSachKhachHang.Rows[row].Cells["QuocTich"].Value = reader["QuocTich"].ToString();
                    dtgDanhSachKhachHang.Rows[row].Cells["GioiTinh"].Value = reader["GioiTinh"].ToString();

                    dtgDanhSachKhachHang.Rows[row].Cells["Icon"].Value = Properties.Resources.KhachHang; // Thay bằng icon thật
                    dtgDanhSachKhachHang.Rows[row].Cells["Sua"].Value = Properties.Resources.edit;
                    dtgDanhSachKhachHang.Rows[row].Cells["Xoa"].Value = Properties.Resources.delete;
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadDanhSachKhachHang();
                return;
            }

            dtgDanhSachKhachHang.Rows.Clear();

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"SELECT * FROM KhachHang 
                         WHERE DaXoa = 0 AND 
                         (MaKH LIKE @key OR TenKH LIKE @key OR SDT LIKE @key OR [CCCD/Passport] LIKE @key)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@key", "%" + keyword + "%");
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int row = dtgDanhSachKhachHang.Rows.Add();

                    dtgDanhSachKhachHang.Rows[row].Cells["MaKH"].Value = reader["MaKH"].ToString();
                    dtgDanhSachKhachHang.Rows[row].Cells["TenKH"].Value = reader["TenKH"].ToString();
                    dtgDanhSachKhachHang.Rows[row].Cells["SDT"].Value = reader["SDT"].ToString();
                    dtgDanhSachKhachHang.Rows[row].Cells["CCCD"].Value = reader["CCCD/Passport"].ToString();
                    dtgDanhSachKhachHang.Rows[row].Cells["QuocTich"].Value = reader["QuocTich"].ToString();
                    dtgDanhSachKhachHang.Rows[row].Cells["GioiTinh"].Value = reader["GioiTinh"].ToString();

                    dtgDanhSachKhachHang.Rows[row].Cells["Icon"].Value = Properties.Resources.KhachHang;
                    dtgDanhSachKhachHang.Rows[row].Cells["Sua"].Value = Properties.Resources.edit;
                    dtgDanhSachKhachHang.Rows[row].Cells["Xoa"].Value = Properties.Resources.delete;
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dtgDanhSachKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Excel.Application excelApp = new Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);
            Excel._Worksheet worksheet = (Excel._Worksheet)excelApp.ActiveSheet;
            worksheet.Name = "Danh sách phòng";

            // Xuất tiêu đề cột
            for (int i = 1; i < dtgDanhSachKhachHang.Columns.Count; i++) // bỏ cột hình ảnh
            {
                worksheet.Cells[1, i] = dtgDanhSachKhachHang.Columns[i].HeaderText;
            }

            // Xuất từng dòng
            for (int i = 0; i < dtgDanhSachKhachHang.Rows.Count; i++)
            {
                for (int j = 1; j < dtgDanhSachKhachHang.Columns.Count; j++) // bỏ cột hình ảnh
                {
                    object value = dtgDanhSachKhachHang.Rows[i].Cells[j].Value;
                    worksheet.Cells[i + 2, j] = value?.ToString();
                }
            }

            // Hiển thị và thông báo
            excelApp.Visible = true;
            MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {

            FormThemKhachHang f = new FormThemKhachHang();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachKhachHang();
            }
        }

        private void dtgDanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string maKH = dtgDanhSachKhachHang.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();

            if (dtgDanhSachKhachHang.Columns[e.ColumnIndex].Name == "Sua")
            {
                // Mở form sửa
                FormSuaKhachHang frm = new FormSuaKhachHang(maKH);
                frm.FormClosed += (s, args) => LoadDanhSachKhachHang(); // Reload sau khi sửa
                frm.ShowDialog();
            }
            else if (dtgDanhSachKhachHang.Columns[e.ColumnIndex].Name == "Xoa")
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = KetNoi.MoKetNoi())
                    {
                        string query = "UPDATE KhachHang SET DaXoa = 1 WHERE MaKH = @MaKH";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaKH", maKH);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công.");
                        LoadDanhSachKhachHang();
                    }
                }
            }
        }
    }
}

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

namespace HotelManagement.NhanVien
{
    public partial class FormDanhSachNhanVien : Form
    {
        public FormDanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void FormDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
        }

        private void LoadDanhSachNhanVien()
        {
            dtgDanhSachNhanVien.Rows.Clear();
            dtgDanhSachNhanVien.Columns.Clear();

            // Cột Icon (Image + MaNV)
            DataGridViewImageColumn iconCol = new DataGridViewImageColumn();
            iconCol.Name = "Icon";
            iconCol.HeaderText = "";
            iconCol.Width = 40;
            dtgDanhSachNhanVien.Columns.Add(iconCol);

            dtgDanhSachNhanVien.Columns.Add("MaNV", "Mã NV");
            dtgDanhSachNhanVien.Columns.Add("TenNV", "Tên nhân viên");
            dtgDanhSachNhanVien.Columns.Add("ChucVu", "Chức vụ");
            dtgDanhSachNhanVien.Columns.Add("Luong", "Lương");
            dtgDanhSachNhanVien.Columns.Add("SDT", "Số điện thoại");
            dtgDanhSachNhanVien.Columns.Add("Email", "Email");
            dtgDanhSachNhanVien.Columns.Add("DiaChi", "Địa chỉ");

            // Cột sửa
            DataGridViewImageColumn suaCol = new DataGridViewImageColumn();
            suaCol.Name = "Sua";
            suaCol.HeaderText = "Sửa";
            suaCol.Width = 40;
            dtgDanhSachNhanVien.Columns.Add(suaCol);

            // Cột xóa
            DataGridViewImageColumn xoaCol = new DataGridViewImageColumn();
            xoaCol.Name = "Xoa";
            xoaCol.HeaderText = "Xóa";
            xoaCol.Width = 40;
            dtgDanhSachNhanVien.Columns.Add(xoaCol);

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "SELECT * FROM NhanVien WHERE DaXoa = 0";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int row = dtgDanhSachNhanVien.Rows.Add();
                    dtgDanhSachNhanVien.Rows[row].Cells["Icon"].Value = Properties.Resources.NhanVien; // Tên file trong Resource
                    dtgDanhSachNhanVien.Rows[row].Cells["MaNV"].Value = reader["MaNV"].ToString();
                    dtgDanhSachNhanVien.Rows[row].Cells["TenNV"].Value = reader["TenNV"].ToString();
                    dtgDanhSachNhanVien.Rows[row].Cells["ChucVu"].Value = reader["ChucVu"].ToString();
                    dtgDanhSachNhanVien.Rows[row].Cells["Luong"].Value = Convert.ToDecimal(reader["Luong"]).ToString("C0");
                    dtgDanhSachNhanVien.Rows[row].Cells["SDT"].Value = reader["SDT"].ToString();
                    dtgDanhSachNhanVien.Rows[row].Cells["Email"].Value = reader["Email"].ToString();
                    dtgDanhSachNhanVien.Rows[row].Cells["DiaChi"].Value = reader["DiaChi"].ToString();

                   
                    dtgDanhSachNhanVien.Rows[row].Cells["Sua"].Value = Properties.Resources.edit;
                    dtgDanhSachNhanVien.Rows[row].Cells["Xoa"].Value = Properties.Resources.delete;
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dtgDanhSachNhanVien.Rows.Clear();

            string query = "SELECT * FROM NhanVien WHERE DaXoa = 0 AND (MaNV LIKE @search OR TenNV LIKE @search OR SDT LIKE @search OR CCCD LIKE @search)";
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + txtTimKiem.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int row = dtgDanhSachNhanVien.Rows.Add();
                    dtgDanhSachNhanVien.Rows[row].Cells["Icon"].Value = Properties.Resources.NhanVien; // Tên file trong Resource
                    dtgDanhSachNhanVien.Rows[row].Cells["MaNV"].Value = reader["MaNV"].ToString();
                    dtgDanhSachNhanVien.Rows[row].Cells["TenNV"].Value = reader["TenNV"].ToString();
                    dtgDanhSachNhanVien.Rows[row].Cells["ChucVu"].Value = reader["ChucVu"].ToString();
                    dtgDanhSachNhanVien.Rows[row].Cells["Luong"].Value = Convert.ToDecimal(reader["Luong"]).ToString("C0");
                    dtgDanhSachNhanVien.Rows[row].Cells["SDT"].Value = reader["SDT"].ToString();
                    dtgDanhSachNhanVien.Rows[row].Cells["Email"].Value = reader["Email"].ToString();
                    dtgDanhSachNhanVien.Rows[row].Cells["DiaChi"].Value = reader["DiaChi"].ToString();

                   
                    dtgDanhSachNhanVien.Rows[row].Cells["Sua"].Value = Properties.Resources.edit;
                    dtgDanhSachNhanVien.Rows[row].Cells["Xoa"].Value = Properties.Resources.delete;
                }
            }
        }

        private void dtgDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào cột "Sua"
            if (e.ColumnIndex == dtgDanhSachNhanVien.Columns["Sua"].Index)
            {
                // Lấy Mã NV từ dòng hiện tại
                string maNV = dtgDanhSachNhanVien.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();

                // Mở form sửa nhân viên với Mã NV tương ứng
                FormSuaNhanVien frmSuaNV = new FormSuaNhanVien(maNV);
                frmSuaNV.ShowDialog();

                // Sau khi sửa xong, reload lại danh sách nhân viên
                LoadDanhSachNhanVien();
            }

            // Kiểm tra nếu click vào cột "Xoa"
            if (e.ColumnIndex == dtgDanhSachNhanVien.Columns["Xoa"].Index)
            {
                // Lấy Mã NV từ dòng hiện tại
                string maNV = dtgDanhSachNhanVien.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();

                // Xác nhận trước khi xóa
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Xóa nhân viên
                    XoaNhanVien(maNV);
                }
            }
        }
        private void XoaNhanVien(string maNV)
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "delete NhanVien WHERE MaNV = @MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", maNV);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa nhân viên thành công.");
                    LoadDanhSachNhanVien(); // Reload danh sách nhân viên sau khi xóa
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dtgDanhSachNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Excel.Application excelApp = new Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);
            Excel._Worksheet worksheet = (Excel._Worksheet)excelApp.ActiveSheet;
            worksheet.Name = "Danh sách phòng";

            // Xuất tiêu đề cột
            for (int i = 1; i < dtgDanhSachNhanVien.Columns.Count; i++) // bỏ cột hình ảnh
            {
                worksheet.Cells[1, i] = dtgDanhSachNhanVien.Columns[i].HeaderText;
            }

            // Xuất từng dòng
            for (int i = 0; i < dtgDanhSachNhanVien.Rows.Count; i++)
            {
                for (int j = 1; j < dtgDanhSachNhanVien.Columns.Count; j++) // bỏ cột hình ảnh
                {
                    object value = dtgDanhSachNhanVien.Rows[i].Cells[j].Value;
                    worksheet.Cells[i + 2, j] = value?.ToString();
                }
            }

            // Hiển thị và thông báo
            excelApp.Visible = true;
            MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            FormThemNhanVien f = new FormThemNhanVien();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachNhanVien();
            }
        }
    }
}

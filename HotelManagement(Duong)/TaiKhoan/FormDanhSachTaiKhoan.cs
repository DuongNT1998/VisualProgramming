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
using HotelManagement.NhanVien;
using Excel = Microsoft.Office.Interop.Excel;

namespace HotelManagement.TaiKhoan
{
    public partial class FormDanhSachTaiKhoan : Form
    {
        public FormDanhSachTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormDanhSachTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadDanhSachTaiKhoan();
        }
        private void LoadDanhSachTaiKhoan()
        {
            dtgDanhSachTaiKhoan.Rows.Clear();
            dtgDanhSachTaiKhoan.Columns.Clear();

            // Cột Icon (Image + MaNV)
            DataGridViewImageColumn iconCol = new DataGridViewImageColumn();
            iconCol.Name = "Icon";
            iconCol.HeaderText = "";
            iconCol.Width = 40;
            dtgDanhSachTaiKhoan.Columns.Add(iconCol);

            dtgDanhSachTaiKhoan.Columns.Add("TenTK", "Tên tài khoản");
            dtgDanhSachTaiKhoan.Columns.Add("TenNV", "Họ và tên NV");
            dtgDanhSachTaiKhoan.Columns.Add("CapDoQuyen", "Cấp độ quyền");
        

            // Cột sửa
            DataGridViewImageColumn suaCol = new DataGridViewImageColumn();
            suaCol.Name = "Sua";
            suaCol.HeaderText = "Sửa";
            suaCol.Width = 40;
            dtgDanhSachTaiKhoan.Columns.Add(suaCol);

            // Cột xóa
            DataGridViewImageColumn xoaCol = new DataGridViewImageColumn();
            xoaCol.Name = "Xoa";
            xoaCol.HeaderText = "Xóa";
            xoaCol.Width = 40;
            dtgDanhSachTaiKhoan.Columns.Add(xoaCol);

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "SELECT * FROM NhanVien nv join TaiKhoan tk on " +
                    "nv.MaNV=tk.MaNV WHERE tk.DaXoa = 0";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int row = dtgDanhSachTaiKhoan.Rows.Add();
                    dtgDanhSachTaiKhoan.Rows[row].Cells["Icon"].Value = Properties.Resources.TaiKhoan; // Tên file trong Resource
                    dtgDanhSachTaiKhoan.Rows[row].Cells["TenTK"].Value = reader["TenTK"].ToString();
                    dtgDanhSachTaiKhoan.Rows[row].Cells["TenNV"].Value = reader["TenNV"].ToString();
                    dtgDanhSachTaiKhoan.Rows[row].Cells["CapDoQuyen"].Value = reader["CapDoQuyen"].ToString();
                    dtgDanhSachTaiKhoan.Rows[row].Cells["Sua"].Value = Properties.Resources.edit;
                    dtgDanhSachTaiKhoan.Rows[row].Cells["Xoa"].Value = Properties.Resources.delete;
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dtgDanhSachTaiKhoan.Rows.Clear();

            string query = "SELECT * FROM TaiKhoan tk join NhanVien nv " +
                "on tk.MaNV = nv.MaNV WHERE tk.DaXoa = 0 AND (TenTK LIKE @search OR TenNV LIKE @search )";
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + txtTimKiem.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int row = dtgDanhSachTaiKhoan.Rows.Add();
                    dtgDanhSachTaiKhoan.Rows[row].Cells["Icon"].Value = Properties.Resources.TaiKhoan; // Tên file trong Resource
                    dtgDanhSachTaiKhoan.Rows[row].Cells["TenTK"].Value = reader["TenTK"].ToString();
                    dtgDanhSachTaiKhoan.Rows[row].Cells["TenNV"].Value = reader["TenNV"].ToString();
                    dtgDanhSachTaiKhoan.Rows[row].Cells["CapDoQuyen"].Value = reader["CapDoQuyen"].ToString();
                    dtgDanhSachTaiKhoan.Rows[row].Cells["Sua"].Value = Properties.Resources.edit;
                    dtgDanhSachTaiKhoan.Rows[row].Cells["Xoa"].Value = Properties.Resources.delete;
                }
            }
        }

        private void dtgDanhSachTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tenTK = dtgDanhSachTaiKhoan.Rows[e.RowIndex].Cells["TenTK"].Value.ToString();

            // Kiểm tra nếu click vào cột "Sua"
            if (e.ColumnIndex == dtgDanhSachTaiKhoan.Columns["Sua"].Index)
            {
                // Lấy Mã NV từ dòng hiện tại

                // Mở form sửa nhân viên với Mã NV tương ứng
                FormSuaTaiKhoan frmSua = new FormSuaTaiKhoan(tenTK);
                frmSua.ShowDialog();

                // Sau khi sửa xong, reload lại danh sách nhân viên
                LoadDanhSachTaiKhoan();

            }

            // Kiểm tra nếu click vào cột "Xoa"
            if (e.ColumnIndex == dtgDanhSachTaiKhoan.Columns["Xoa"].Index)
            {
         

                // Xác nhận trước khi xóa
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Xóa nhân viên
                    XoaTaiKhoan(tenTK);
                }
            }
        }
        private void XoaTaiKhoan(string tenTK)
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "update TaiKhoan set DaXoa =1 WHERE TenTK = @tenTK";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tenTK", tenTK);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa nhân viên thành công.");
                    LoadDanhSachTaiKhoan(); // Reload danh sách nhân viên sau khi xóa
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dtgDanhSachTaiKhoan.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Excel.Application excelApp = new Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);
            Excel._Worksheet worksheet = (Excel._Worksheet)excelApp.ActiveSheet;
            worksheet.Name = "Danh sách phòng";

            // Xuất tiêu đề cột
            for (int i = 1; i < dtgDanhSachTaiKhoan.Columns.Count; i++) // bỏ cột hình ảnh
            {
                worksheet.Cells[1, i] = dtgDanhSachTaiKhoan.Columns[i].HeaderText;
            }

            // Xuất từng dòng
            for (int i = 0; i < dtgDanhSachTaiKhoan.Rows.Count; i++)
            {
                for (int j = 1; j < dtgDanhSachTaiKhoan.Columns.Count; j++) // bỏ cột hình ảnh
                {
                    object value = dtgDanhSachTaiKhoan.Rows[i].Cells[j].Value;
                    worksheet.Cells[i + 2, j] = value?.ToString();
                }
            }

            // Hiển thị và thông báo
            excelApp.Visible = true;
            MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            FormThemTaiKhoan f = new FormThemTaiKhoan();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachTaiKhoan();
            }
        }
    }
}

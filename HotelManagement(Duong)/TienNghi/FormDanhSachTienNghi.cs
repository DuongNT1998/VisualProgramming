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
using Excel = Microsoft.Office.Interop.Excel;

namespace HotelManagement.TienNghi
{
    public partial class FormDanhSachTienNghi : Form
    {
        public FormDanhSachTienNghi()
        {
            InitializeComponent();
        }

        private void FormDanhSachTienNghi_Load(object sender, EventArgs e)
        {
            LoadDanhSachTienNghi();
        }
        private void LoadDanhSachTienNghi()
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                try
                {
                    string query = "SELECT MaTN, TenTN FROM TienNghi WHERE DaXoa = 0";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dtgDanhSachTienNghi.Rows.Clear();
                    dtgDanhSachTienNghi.Columns.Clear();

                    // Cột hình + mã
                    DataGridViewImageColumn iconCol = new DataGridViewImageColumn();
                    iconCol.HeaderText = "";
                    iconCol.Image = Properties.Resources.TienNghi;
                    iconCol.Width = 50;
                    dtgDanhSachTienNghi.Columns.Add(iconCol);

                    dtgDanhSachTienNghi.Columns.Add("MaTN", "Mã tiện nghi");
                    dtgDanhSachTienNghi.Columns.Add("TenTN", "Tên tiện nghi");

                    // Cập nhật
                    DataGridViewImageColumn suaCol = new DataGridViewImageColumn();
                    suaCol.Name = "Sua"; // ← Đặt tên để truy cập
                    suaCol.HeaderText = "Sửa";
                    suaCol.Image = Properties.Resources.edit;
                    suaCol.Width = 40;
                    dtgDanhSachTienNghi.Columns.Add(suaCol);

                    // Xóa
                    DataGridViewImageColumn xoaCol = new DataGridViewImageColumn();
                    xoaCol.Name = "Xoa"; // ← Đặt tên để truy cập
                    xoaCol.HeaderText = "Xóa";
                    xoaCol.Image = Properties.Resources.delete;
                    xoaCol.Width = 40;
                    dtgDanhSachTienNghi.Columns.Add(xoaCol);

                    // Thêm dữ liệu vào từng dòng
                    foreach (DataRow row in dt.Rows)
                    {
                        dtgDanhSachTienNghi.Rows.Add(
                            Properties.Resources.TienNghi,
                            row["MaTN"],
                            row["TenTN"],
                            Properties.Resources.edit,
                            Properties.Resources.delete
                        );
                    }

                    dtgDanhSachTienNghi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi load tiện nghi: " + ex.Message);
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadDanhSachTienNghi();
                return;
            }

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                try
                {
                    string query = "SELECT MaTN, TenTN FROM TienNghi WHERE TenTN LIKE @keyword AND DaXoa = 0";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dtgDanhSachTienNghi.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        dtgDanhSachTienNghi.Rows.Add(
                            Properties.Resources.TienNghi,
                            row["MaTN"],
                            row["TenTN"],
                            Properties.Resources.edit,
                            Properties.Resources.delete
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dtgDanhSachTienNghi.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Excel.Application excelApp = new Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);
            Excel._Worksheet worksheet = (Excel._Worksheet)excelApp.ActiveSheet;
            worksheet.Name = "Danh sách phòng";

            // Xuất tiêu đề cột
            for (int i = 1; i < dtgDanhSachTienNghi.Columns.Count; i++) // bỏ cột hình ảnh
            {
                worksheet.Cells[1, i] = dtgDanhSachTienNghi.Columns[i].HeaderText;
            }

            // Xuất từng dòng
            for (int i = 0; i < dtgDanhSachTienNghi.Rows.Count; i++)
            {
                for (int j = 1; j < dtgDanhSachTienNghi.Columns.Count; j++) // bỏ cột hình ảnh
                {
                    object value = dtgDanhSachTienNghi.Rows[i].Cells[j].Value;
                    worksheet.Cells[i + 2, j] = value?.ToString();
                }
            }

            // Hiển thị và thông báo
            excelApp.Visible = true;
            MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            FormThemTienNghi f = new FormThemTienNghi();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachTienNghi();
            }
        }

        private void dtgDanhSachTienNghi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maTN = dtgDanhSachTienNghi.Rows[e.RowIndex].Cells["MaTN"].Value.ToString();

                // Click cột sửa
                if (e.ColumnIndex == dtgDanhSachTienNghi.Columns["Sua"].Index)
                {
                    FormSuaTienNghi f = new FormSuaTienNghi(maTN);
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        LoadDanhSachTienNghi();
                    }
                }

                // Click cột xóa
                if (e.ColumnIndex == dtgDanhSachTienNghi.Columns["Xoa"].Index)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa tiện nghi này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (SqlConnection conn = KetNoi.MoKetNoi())
                        {
                            string query = "UPDATE TienNghi SET DaXoa = 1 WHERE MaTN = @MaTN";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@MaTN", maTN);
                            int kq = cmd.ExecuteNonQuery();
                            if (kq > 0)
                                MessageBox.Show("Xóa thành công!");
                            else
                                MessageBox.Show("Xóa thất bại!");
                            LoadDanhSachTienNghi();
                        }
                    }
                }
            }
        }
    }
}

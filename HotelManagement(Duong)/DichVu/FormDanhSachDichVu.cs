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
using HotelManagement.TienNghi;
using Excel = Microsoft.Office.Interop.Excel;

namespace HotelManagement.DichVu
{
    public partial class FormDanhSachDichVu : Form
    {
        public FormDanhSachDichVu()
        {
            InitializeComponent();
        }
        private void FormDanhSachDichVu_Load(object sender, EventArgs e)
        {

            LoadDanhSachDichVu();
        }
        private void LoadDanhSachDichVu() {
            dtgDanhSachDichVu.Rows.Clear();
            dtgDanhSachDichVu.Columns.Clear();

            // Cột Icon (Image + MaDV)
            DataGridViewImageColumn iconCol = new DataGridViewImageColumn();
            iconCol.Name = "Icon";
            iconCol.HeaderText = "";
            iconCol.Width = 40;
            dtgDanhSachDichVu.Columns.Add(iconCol);

            dtgDanhSachDichVu.Columns.Add("MaDV", "Mã DV");
            dtgDanhSachDichVu.Columns.Add("TenDV", "Tên dịch vụ");
            dtgDanhSachDichVu.Columns.Add("DonGia", "Đơn giá");
            dtgDanhSachDichVu.Columns.Add("SLConLai", "Số lượng còn lại");
            dtgDanhSachDichVu.Columns.Add("LoaiDV", "Loại dịch vụ");

            // Cột sửa
            DataGridViewImageColumn suaCol = new DataGridViewImageColumn();
            suaCol.Name = "Sua";
            suaCol.HeaderText = "Sửa";
            suaCol.Width = 40;
            dtgDanhSachDichVu.Columns.Add(suaCol);

            // Cột xóa
            DataGridViewImageColumn xoaCol = new DataGridViewImageColumn();
            xoaCol.Name = "Xoa";
            xoaCol.HeaderText = "Xóa";
            xoaCol.Width = 40;
            dtgDanhSachDichVu.Columns.Add(xoaCol);
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "SELECT * FROM DichVu WHERE DaXoa = 0";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int row = dtgDanhSachDichVu.Rows.Add();
                    dtgDanhSachDichVu.Rows[row].Cells["MaDV"].Value = reader["MaDV"].ToString();
                    dtgDanhSachDichVu.Rows[row].Cells["TenDV"].Value = reader["TenDV"].ToString();
                    dtgDanhSachDichVu.Rows[row].Cells["DonGia"].Value = Convert.ToDecimal(reader["DonGia"]).ToString("N0") + " VNĐ";
                    dtgDanhSachDichVu.Rows[row].Cells["SLConLai"].Value = reader["SLConLai"].ToString();
                    dtgDanhSachDichVu.Rows[row].Cells["LoaiDV"].Value = reader["LoaiDV"].ToString();

                    dtgDanhSachDichVu.Rows[row].Cells["Icon"].Value = Properties.Resources.DichVu; // Tên file trong Resource
                    dtgDanhSachDichVu.Rows[row].Cells["Sua"].Value = Properties.Resources.edit;
                    dtgDanhSachDichVu.Rows[row].Cells["Xoa"].Value = Properties.Resources.delete;
                }
            }
        }

        

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            dtgDanhSachDichVu.Rows.Clear();
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "SELECT * FROM DichVu WHERE DaXoa = 0 AND TenDV LIKE @keyword";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int row = dtgDanhSachDichVu.Rows.Add();
                    dtgDanhSachDichVu.Rows[row].Cells["MaDV"].Value = reader["MaDV"].ToString();
                    dtgDanhSachDichVu.Rows[row].Cells["TenDV"].Value = reader["TenDV"].ToString();
                    dtgDanhSachDichVu.Rows[row].Cells["DonGia"].Value = Convert.ToDecimal(reader["DonGia"]).ToString("N0") + " VNĐ";
                    dtgDanhSachDichVu.Rows[row].Cells["SLConLai"].Value = reader["SLConLai"].ToString();
                    dtgDanhSachDichVu.Rows[row].Cells["LoaiDV"].Value = reader["LoaiDV"].ToString();

                    dtgDanhSachDichVu.Rows[row].Cells["Icon"].Value = Properties.Resources.DichVu;
                    dtgDanhSachDichVu.Rows[row].Cells["Sua"].Value = Properties.Resources.edit;
                    dtgDanhSachDichVu.Rows[row].Cells["Xoa"].Value = Properties.Resources.delete;
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dtgDanhSachDichVu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Excel.Application excelApp = new Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);
            Excel._Worksheet worksheet = (Excel._Worksheet)excelApp.ActiveSheet;
            worksheet.Name = "Danh sách phòng";

            // Xuất tiêu đề cột
            for (int i = 1; i < dtgDanhSachDichVu.Columns.Count; i++) // bỏ cột hình ảnh
            {
                worksheet.Cells[1, i] = dtgDanhSachDichVu.Columns[i].HeaderText;
            }

            // Xuất từng dòng
            for (int i = 0; i < dtgDanhSachDichVu.Rows.Count; i++)
            {
                for (int j = 1; j < dtgDanhSachDichVu.Columns.Count; j++) // bỏ cột hình ảnh
                {
                    object value = dtgDanhSachDichVu.Rows[i].Cells[j].Value;
                    worksheet.Cells[i + 2, j] = value?.ToString();
                }
            }

            // Hiển thị và thông báo
            excelApp.Visible = true;
            MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dtgDanhSachDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maDV = dtgDanhSachDichVu.Rows[e.RowIndex].Cells["MaDV"].Value.ToString();

                if (dtgDanhSachDichVu.Columns[e.ColumnIndex].Name == "Sua")
                {
                    FormSuaDichVu frm = new FormSuaDichVu(maDV);
                    if (frm.ShowDialog() == DialogResult.OK)
                        LoadDanhSachDichVu();
                }
                else if (dtgDanhSachDichVu.Columns[e.ColumnIndex].Name == "Xoa")
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa dịch vụ này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (SqlConnection conn = KetNoi.MoKetNoi())
                        {
                            string query = "UPDATE DichVu SET DaXoa = 1 WHERE MaDV = @MaDV";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@MaDV", maDV);
                            cmd.ExecuteNonQuery();
                        }
                        LoadDanhSachDichVu();
                    }
                }
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            FormThemDichVu f = new FormThemDichVu();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachDichVu();
            }
        }
    }
}

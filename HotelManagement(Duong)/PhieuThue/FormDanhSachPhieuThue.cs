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
using HotelManagement.SoDoPhong;
using Excel = Microsoft.Office.Interop.Excel;

namespace HotelManagement.PhieuThue
{
    public partial class FormDanhSachPhieuThue : Form
    {
        public FormDanhSachPhieuThue()
        {
            InitializeComponent();
        }

        private void FormDanhSachPhieuThue_Load(object sender, EventArgs e)
        {
            // Tải dữ liệu vào DataGridView khi form được load
            LoadDanhSachPhieuThue();
        }
        // Hàm để tải danh sách phiếu thuê
        private void LoadDanhSachPhieuThue()
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"
            SELECT pt.MaPT, kh.TenKH, pt.NgPT, nv.TenNV
            FROM PhieuThue pt
            JOIN KhachHang kh ON pt.MaKH = kh.MaKH
            JOIN NhanVien nv ON pt.MaNV = nv.MaNV
            WHERE pt.DaXoa = 0";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dtgDanhSachPhieuThue.DataSource = dt;

                // Đặt tên cột
                dtgDanhSachPhieuThue.Columns["MaPT"].HeaderText = "Mã phiếu thuê";
                dtgDanhSachPhieuThue.Columns["TenKH"].HeaderText = "Tên khách hàng";
                dtgDanhSachPhieuThue.Columns["NgPT"].HeaderText = "Ngày lập phiếu";
                dtgDanhSachPhieuThue.Columns["TenNV"].HeaderText = "Nhân viên lập";

               
                // ✅ Thêm cột hình ảnh chi tiết
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol.Name = "ChiTiet";
                imgCol.HeaderText = "Chi tiết";
                imgCol.Image = Properties.Resources.details; // <-- Tên icon của bạn trong Resource
               
                imgCol.ToolTipText = "Xem chi tiết";
                dtgDanhSachPhieuThue.Columns.Add(imgCol);
            }

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string filter = txtTimKiem.Text.Trim().ToLower();

            if (dtgDanhSachPhieuThue.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("MaPT LIKE '%{0}%' OR TenKH LIKE '%{0}%'", filter);
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dtgDanhSachPhieuThue.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Excel.Application excelApp = new Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);
            Excel._Worksheet worksheet = (Excel._Worksheet)excelApp.ActiveSheet;
            worksheet.Name = "Danh sách phòng";

            // Xuất tiêu đề cột
            for (int i = 1; i < dtgDanhSachPhieuThue.Columns.Count; i++) // bỏ cột hình ảnh
            {
                worksheet.Cells[1, i] = dtgDanhSachPhieuThue.Columns[i].HeaderText;
            }

            // Xuất từng dòng
            for (int i = 0; i < dtgDanhSachPhieuThue.Rows.Count; i++)
            {
                for (int j = 1; j < dtgDanhSachPhieuThue.Columns.Count; j++) // bỏ cột hình ảnh
                {
                    object value = dtgDanhSachPhieuThue.Rows[i].Cells[j].Value;
                    worksheet.Cells[i + 2, j] = value?.ToString();
                }
            }

            // Hiển thị và thông báo
            excelApp.Visible = true;
            MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            FormDatPhong formDatPhong = new FormDatPhong();
            formDatPhong.ShowDialog();
        }

        private void dtgDanhSachPhieuThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgDanhSachPhieuThue.Columns["ChiTiet"].Index)
            {
                string maPT = dtgDanhSachPhieuThue.Rows[e.RowIndex].Cells["MaPT"].Value.ToString();

                // Mở form chi tiết
                FormChiTietPhieuThue formChiTiet = new FormChiTietPhieuThue(maPT);
                formChiTiet.ShowDialog();
            }
        }
    }
}

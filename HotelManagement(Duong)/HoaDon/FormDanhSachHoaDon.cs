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


namespace HotelManagement.HoaDon
{
    public partial class FormDanhSachHoaDon : Form
    {
        public FormDanhSachHoaDon()
        {
            InitializeComponent();
        }
        public void LoadDanhSachHoaDon()
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"
        SELECT MaHD, NgHD, TenNV, MaCTDP, TriGia, TrangThai
        FROM HoaDon join NhanVien on HoaDon.MaNV=NhanVien.manv
        WHERE HoaDon.DaXoa = 0";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dtgDanhSachHoaDon.DataSource = dt;

                // Format header
                dtgDanhSachHoaDon.Columns["MaHD"].HeaderText = "Mã hóa đơn";
                dtgDanhSachHoaDon.Columns["NgHD"].HeaderText = "Ngày lập";
                dtgDanhSachHoaDon.Columns["TenNV"].HeaderText = "Nhân viên";
                dtgDanhSachHoaDon.Columns["MaCTDP"].HeaderText = "Mã chi tiết phiếu";
                dtgDanhSachHoaDon.Columns["TriGia"].HeaderText = "Trị giá";
                dtgDanhSachHoaDon.Columns["TrangThai"].HeaderText = "Trạng thái";
                // Thêm cột biểu tượng nếu chưa có
                if (!dtgDanhSachHoaDon.Columns.Contains("XemChiTiet"))
                {
                    DataGridViewImageColumn colXemChiTiet = new DataGridViewImageColumn();
                    colXemChiTiet.Name = "XemChiTiet";
                    colXemChiTiet.HeaderText = "Chi tiết";
                    colXemChiTiet.ToolTipText = "Hủy thông tin chi tiết phiếu";
                    colXemChiTiet.Image = Properties.Resources.details;
                    dtgDanhSachHoaDon.Columns.Add(colXemChiTiet);
                }

            }
        }

        private void FormDanhSachHoaDon_Load(object sender, EventArgs e)
        {
            LoadDanhSachHoaDon();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dtgDanhSachHoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Excel.Application excelApp = new Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);
            Excel._Worksheet worksheet = (Excel._Worksheet)excelApp.ActiveSheet;
            worksheet.Name = "Danh sách phòng";

            // Xuất tiêu đề cột
            for (int i = 1; i < dtgDanhSachHoaDon.Columns.Count; i++) // bỏ cột hình ảnh
            {
                worksheet.Cells[1, i] = dtgDanhSachHoaDon.Columns[i].HeaderText;
            }

            // Xuất từng dòng
            for (int i = 0; i < dtgDanhSachHoaDon.Rows.Count; i++)
            {
                for (int j = 1; j < dtgDanhSachHoaDon.Columns.Count; j++) // bỏ cột hình ảnh
                {
                    object value = dtgDanhSachHoaDon.Rows[i].Cells[j].Value;
                    worksheet.Cells[i + 2, j] = value?.ToString();
                }
            }

            // Hiển thị và thông báo
            excelApp.Visible = true;
            MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TimKiemHoaDon()
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"
        SELECT hd.MaHD, hd.NgHD, TenNV, hd.MaCTDP, hd.TriGia, hd.TrangThai
        FROM HoaDon hd
        JOIN CTDP ctdp ON hd.MaCTDP = ctdp.MaCTDP
        JOIN PhieuThue pt ON pt.MaPT = ctdp.MaPT
        JOIN KhachHang kh ON kh.MaKH = pt.MaKH
        join NhanVien on hd.MaNV=NhanVien.manv
        WHERE hd.DaXoa = 0
        ";

                // Nếu người dùng nhập từ khóa
                if (!string.IsNullOrWhiteSpace(txtTimKiem.Text))
                {
                    query += " AND (hd.MaHD LIKE @TuKhoa OR kh.[CCCD/Passport] LIKE @TuKhoa)";
                }

                // Lọc theo ngày lập (ngày được chọn trong datetimepicker)
                query += " AND CAST(hd.NgHD AS DATE) = @NgayLap";

                SqlCommand cmd = new SqlCommand(query, conn);

                if (!string.IsNullOrWhiteSpace(txtTimKiem.Text))
                {
                    cmd.Parameters.AddWithValue("@TuKhoa", "%" + txtTimKiem.Text.Trim() + "%");
                }

                cmd.Parameters.AddWithValue("@NgayLap", dtpNgayLap.Value.Date);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dtgDanhSachHoaDon.DataSource = dt;

                dtgDanhSachHoaDon.Columns["MaHD"].HeaderText = "Mã hóa đơn";
                dtgDanhSachHoaDon.Columns["NgHD"].HeaderText = "Ngày lập";
                dtgDanhSachHoaDon.Columns["TenNV"].HeaderText = "Nhân viên";
                dtgDanhSachHoaDon.Columns["MaCTDP"].HeaderText = "Mã chi tiết phiếu";
                dtgDanhSachHoaDon.Columns["TriGia"].HeaderText = "Trị giá";
                dtgDanhSachHoaDon.Columns["TrangThai"].HeaderText = "Trạng thái";
                // Thêm cột biểu tượng nếu chưa có
                if (!dtgDanhSachHoaDon.Columns.Contains("XemChiTiet"))
                {
                    DataGridViewImageColumn colXemChiTiet = new DataGridViewImageColumn();
                    colXemChiTiet.Name = "XemChiTiet";
                    colXemChiTiet.HeaderText = "Chi tiết";
                    colXemChiTiet.ToolTipText = "Hủy thông tin chi tiết phiếu";
                    dtgDanhSachHoaDon.Columns.Add(colXemChiTiet);
                }
            }
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemHoaDon();
        }

        private void dtgDanhSachHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgDanhSachHoaDon.Columns[e.ColumnIndex].Name == "XemChiTiet")
            {
                string maHD = dtgDanhSachHoaDon.Rows[e.RowIndex].Cells["MaHD"].Value.ToString();

                FormHoaDon frm = new FormHoaDon(maHD); // truyền mã hóa đơn
                frm.ShowDialog();
            }
        }
    }
}

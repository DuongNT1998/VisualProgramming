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
using HotelManagement.ChiTietTienNghi;
using HotelManagement.KetNoiCSDL;
using Excel = Microsoft.Office.Interop.Excel;

namespace HotelManagement.LoaiPhong
{
    public partial class FormDanhSachLoaiPhong : Form
    {
        public FormDanhSachLoaiPhong()
        {
            InitializeComponent();
        }

        private void FormDanhSachLoaiPhong_Load(object sender, EventArgs e)
        {
            LoadLoaiPhong();
        }
        private void LoadLoaiPhong()
        {


            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                try
                {
                    string query = "SELECT MaLPH, TenLPH, SoGiuong, SoNguoiToiDa, GiaNgay, GiaGio FROM LoaiPhong ";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dtgDanhSachLoaiPhong.Rows.Clear();
                    dtgDanhSachLoaiPhong.Columns.Clear();

                    // Thêm các cột cần thiết
                    DataGridViewImageColumn iconCol = new DataGridViewImageColumn();
                    iconCol.HeaderText = "";
                    iconCol.Image = Properties.Resources.Giuong;
                    iconCol.Width = 50;
                    dtgDanhSachLoaiPhong.Columns.Add(iconCol);

                    dtgDanhSachLoaiPhong.Columns.Add("MaLPH", "Mã loại");
                    dtgDanhSachLoaiPhong.Columns.Add("TenLPH", "Tên loại");
                    dtgDanhSachLoaiPhong.Columns.Add("SoGiuong", "Số giường");
                    dtgDanhSachLoaiPhong.Columns.Add("SoNguoiToiDa", "Số người tối đa");
                    dtgDanhSachLoaiPhong.Columns.Add("GiaNgay", "Giá ngày");
                    dtgDanhSachLoaiPhong.Columns.Add("GiaGio", "Giá giờ");

                    // Tiện nghi: chỉ icon
                    DataGridViewImageColumn tienNghiCol = new DataGridViewImageColumn();
                    tienNghiCol.HeaderText = "Tiện nghi";
                    tienNghiCol.Image = Properties.Resources.details;
                    tienNghiCol.Width = 40;
                    dtgDanhSachLoaiPhong.Columns.Add(tienNghiCol);

                    // Cập nhật
                    DataGridViewImageColumn suaCol = new DataGridViewImageColumn();
                    suaCol.HeaderText = "Cập nhật";
                    suaCol.Image = Properties.Resources.edit;
                    suaCol.Width = 40;
                    dtgDanhSachLoaiPhong.Columns.Add(suaCol);

                    // Thêm dữ liệu
                    foreach (DataRow row in dt.Rows)
                    {
                        dtgDanhSachLoaiPhong.Rows.Add(
                            Properties.Resources.Giuong,
                            row["MaLPH"],
                            row["TenLPH"],
                            row["SoGiuong"],
                            row["SoNguoiToiDa"],
                            row["GiaNgay"],
                            row["GiaGio"],
                            Properties.Resources.details,
                            Properties.Resources.edit
                        );
                    }

                    dtgDanhSachLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải loại phòng: " + ex.Message);
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadLoaiPhong(); // Nếu để trống thì load lại toàn bộ
                return;
            }

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                try
                {
                    string query = "SELECT MaLPH, TenLPH, SoGiuong, SoNguoiToiDa, GiaNgay, GiaGio FROM LoaiPhong WHERE MaLPH LIKE @keyword";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dtgDanhSachLoaiPhong.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        dtgDanhSachLoaiPhong.Rows.Add(
                            Properties.Resources.Giuong,
                            row["MaLPH"],
                            row["TenLPH"],
                            row["SoGiuong"],
                            row["SoNguoiToiDa"],
                            row["GiaNgay"],
                            row["GiaGio"],
                            Properties.Resources.details,
                            Properties.Resources.edit
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
            if (dtgDanhSachLoaiPhong.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Excel.Application excelApp = new Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);
            Excel._Worksheet worksheet = (Excel._Worksheet)excelApp.ActiveSheet;
            worksheet.Name = "Danh sách loại phòng";

            // Xuất tiêu đề cột
            for (int i = 1; i < dtgDanhSachLoaiPhong.Columns.Count; i++) // bỏ cột hình ảnh
            {
                worksheet.Cells[1, i] = dtgDanhSachLoaiPhong.Columns[i].HeaderText;
            }

            // Xuất từng dòng
            for (int i = 0; i < dtgDanhSachLoaiPhong.Rows.Count; i++)
            {
                for (int j = 1; j < dtgDanhSachLoaiPhong.Columns.Count; j++) // bỏ cột hình ảnh
                {
                    object value = dtgDanhSachLoaiPhong.Rows[i].Cells[j].Value;
                    worksheet.Cells[i + 2, j] = value?.ToString();
                }
            }

            // Hiển thị và thông báo
            excelApp.Visible = true;
            MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtgDanhSachLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra không phải header và đúng cột sửa (giả sử là cột cuối)
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgDanhSachLoaiPhong.Columns.Count - 1)
            {
                string maLoaiPhong = dtgDanhSachLoaiPhong.Rows[e.RowIndex].Cells["MaLPH"].Value.ToString();

                FormSuaLoaiPhong formSua = new FormSuaLoaiPhong();
                formSua.MaLoaiPhong = maLoaiPhong;
                formSua.ShowDialog();

                // Sau khi sửa thì reload danh sách
                LoadLoaiPhong();
            }



            // Kiểm tra chỉ xử lý khi click vào dòng dữ liệu (ô tiện nghi)
            if (e.RowIndex >= 0)
            {
                // Cột tiện nghi là cột thứ 7 nếu tính từ 0
                int colTienNghi = 7;

                if (e.ColumnIndex == colTienNghi)
                {
                    string maLPH = dtgDanhSachLoaiPhong.Rows[e.RowIndex].Cells["MaLPH"].Value.ToString();
                    string tenLPH = dtgDanhSachLoaiPhong.Rows[e.RowIndex].Cells["TenLPH"].Value.ToString();



                    // Mở form danh sách chi tiết tiện nghi
                    FormDanhSachChiTietTienNghi frm = new FormDanhSachChiTietTienNghi(maLPH, tenLPH);
                    frm.ShowDialog();
                }
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            // Mở form thêm mới loại phòng
            FormThemLoaiPhong formThemLoaiPhong = new FormThemLoaiPhong();
            formThemLoaiPhong.ShowDialog(); // Mở form thêm mới ở chế độ dialog
            // Sau khi thêm xong, reload lại danh sách loại phòng
            LoadLoaiPhong();
        }

        
    }
}

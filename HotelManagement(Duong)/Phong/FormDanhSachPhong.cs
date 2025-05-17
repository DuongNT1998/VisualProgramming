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


namespace HotelManagement.Phong
{
    public partial class FormDanhSachPhong : Form
    {
        public FormDanhSachPhong()
        {
            InitializeComponent();
        }

        private void FormDanhSachPhong_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhong();
        }

        private void LoadDanhSachPhong()
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                try
                {
                    string query = @"
                SELECT 
                    P.MaPH, 
                    P.TTPH, 
                    P.TTDD, 
                    L.TenLPH
                FROM Phong P
                JOIN LoaiPhong L ON P.MaLPH = L.MaLPH
                WHERE P.DaXoa = 0";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Xóa cấu trúc cũ
                    dtgDanhSachPhong.Columns.Clear();
                    dtgDanhSachPhong.Rows.Clear();

                    // Cột 1: Icon Phòng
                    DataGridViewImageColumn iconCol = new DataGridViewImageColumn();
                    iconCol.Image = Properties.Resources.Phong;
                    iconCol.HeaderText = "";
                    iconCol.Width = 40;
                    iconCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    dtgDanhSachPhong.Columns.Add(iconCol);

                    // Cột 2: Mã phòng
                    dtgDanhSachPhong.Columns.Add("MaPH", "Mã phòng");

                    // Cột 3: Tình trạng phòng
                    dtgDanhSachPhong.Columns.Add("TTPH", "Tình trạng phòng");

                    // Cột 4: Dọn dẹp
                    dtgDanhSachPhong.Columns.Add("TTDD", "Dọn dẹp");

                    // Cột 5: Loại phòng
                    dtgDanhSachPhong.Columns.Add("TenLPH", "Loại phòng");

                    // Cột 6: Sửa (icon)
                    DataGridViewImageColumn editCol = new DataGridViewImageColumn();
                    editCol.Image = Properties.Resources.edit;
                    editCol.HeaderText = "Sửa";
                    editCol.Width = 40;
                    editCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    dtgDanhSachPhong.Columns.Add(editCol);

                    // Cột 7: Xóa (icon)
                    DataGridViewImageColumn deleteCol = new DataGridViewImageColumn();
                    deleteCol.Image = Properties.Resources.delete;
                    deleteCol.HeaderText = "Xóa";
                    deleteCol.Width = 40;
                    deleteCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    dtgDanhSachPhong.Columns.Add(deleteCol);

                    // Thêm dòng dữ liệu
                    foreach (DataRow row in dt.Rows)
                    {
                        dtgDanhSachPhong.Rows.Add(
                            Properties.Resources.Phong,
                            row["MaPH"],
                            row["TTPH"],
                            row["TTDD"],
                            row["TenLPH"],
                            Properties.Resources.edit,
                            Properties.Resources.delete
                        );
                    }

                    // Thiết lập hiển thị
                    dtgDanhSachPhong.RowTemplate.Height = 40;
                    dtgDanhSachPhong.AllowUserToAddRows = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách phòng: " + ex.Message);
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToUpper();

            foreach (DataGridViewRow row in dtgDanhSachPhong.Rows)
            {
                if (row.Cells[1].Value != null) // Cột 1 là mã phòng
                {
                    string maPhong = row.Cells[1].Value.ToString().ToUpper();
                    row.Visible = string.IsNullOrEmpty(keyword) || maPhong.Contains(keyword);
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dtgDanhSachPhong.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Excel.Application excelApp = new Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);
            Excel._Worksheet worksheet = (Excel._Worksheet)excelApp.ActiveSheet;
            worksheet.Name = "Danh sách phòng";

            // Xuất tiêu đề cột
            for (int i = 1; i < dtgDanhSachPhong.Columns.Count; i++) // bỏ cột hình ảnh
            {
                worksheet.Cells[1, i] = dtgDanhSachPhong.Columns[i].HeaderText;
            }

            // Xuất từng dòng
            for (int i = 0; i < dtgDanhSachPhong.Rows.Count; i++)
            {
                for (int j = 1; j < dtgDanhSachPhong.Columns.Count; j++) // bỏ cột hình ảnh
                {
                    object value = dtgDanhSachPhong.Rows[i].Cells[j].Value;
                    worksheet.Cells[i + 2, j] = value?.ToString();
                }
            }

            // Hiển thị và thông báo
            excelApp.Visible = true;
            MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
    }

        private void dtgDanhSachPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string maPhong = dtgDanhSachPhong.Rows[e.RowIndex].Cells[1].Value.ToString();

            // Sửa
            if (e.ColumnIndex == 5)
            {
                FormSuaPhong formSua = new FormSuaPhong(maPhong);
                formSua.ShowDialog();
                LoadDanhSachPhong();
            }
            // Xóa
            else if (e.ColumnIndex == 6)
            {
                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa phòng {maPhong} không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    XoaPhong(maPhong); // Gọi hàm xử lý xóa
                    LoadDanhSachPhong(); // Tải lại danh sách
                }
            }
        }
        private void XoaPhong(string maPhong)
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                try
                {
                    // Đảm bảo kết nối đang đóng trước khi mở
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    string query = "UPDATE Phong SET DaXoa = 1 WHERE MaPH = @MaPH";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaPH", maPhong);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã xóa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy phòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }

        private void btnThemMoiPhong_Click(object sender, EventArgs e)
        {
            FormThemPhong form = new FormThemPhong();
            form.ShowDialog();

            // Sau khi thêm xong, reload lại danh sách phòng
            LoadDanhSachPhong();
        }
    }
}

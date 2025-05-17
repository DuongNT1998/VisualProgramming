using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.KetNoiCSDL;
using static System.Net.Mime.MediaTypeNames;

namespace HotelManagement.ChiTietTienNghi
{
    public partial class FormDanhSachChiTietTienNghi : Form
    {
        private string _maLPH;
        private string _tenLoaiPhong;

        public FormDanhSachChiTietTienNghi(string maLPH, string tenLoaiPhong)
        {
            InitializeComponent();
            _maLPH = maLPH;
            _tenLoaiPhong = tenLoaiPhong;
        }

        private void FormDanhSachChiTietTienNghi_Load(object sender, EventArgs e)
        {
            lblTenLoaiPhong.Text = $"Loại phòng: {_tenLoaiPhong}";
            LoadChiTietTienNghi();
        }
        private void LoadChiTietTienNghi()
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"
            SELECT TienNghi.TenTN, CTTN.SL, 
                   CASE 
                       WHEN CTTN.SL <1 THEN N'Đang không sử dụng được'
                       ELSE N'Có thể sử dụng tốt' 
                   END AS GhiChu
            FROM CTTN
            JOIN TienNghi ON CTTN.MaTN = TienNghi.MaTN
            WHERE CTTN.MaLPH = @MaLPH AND CTTN.DaXoa = 0 AND TienNghi.DaXoa = 0";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLPH", _maLPH);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dtgDanhSachTienNghiTheoLoaiPhong.Rows.Clear();
                dtgDanhSachTienNghiTheoLoaiPhong.Columns.Clear();

                dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add("TenTN", "Tên tiện nghi");
                dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add("SL", "Số lượng");
                dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add("GhiChu", "Ghi chú");

                // Cột sửa
                DataGridViewImageColumn colEdit = new DataGridViewImageColumn();
                colEdit.Image = Properties.Resources.edit;
                colEdit.Width = 30;
                colEdit.Name = "Sua";
                colEdit.HeaderText = "Sửa";
                dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add(colEdit);

                // Cột xóa
                DataGridViewImageColumn colDelete = new DataGridViewImageColumn();
                colDelete.Image = Properties.Resources.delete;
                colDelete.Width = 30;
                colEdit.Name = "Xoa";
                colDelete.HeaderText = "Xóa";
                dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add(colDelete);

                foreach (DataRow row in dt.Rows)
                {
                    dtgDanhSachTienNghiTheoLoaiPhong.Rows.Add(
                        row["TenTN"],
                        row["SL"],
                        row["GhiChu"],
                        Properties.Resources.edit,
                        Properties.Resources.delete
                    );
                }

                dtgDanhSachTienNghiTheoLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void dtgDanhSachTienNghiTheoLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tenTN = dtgDanhSachTienNghiTheoLoaiPhong.Rows[e.RowIndex].Cells["TenTN"].Value.ToString();
            string sl = dtgDanhSachTienNghiTheoLoaiPhong.Rows[e.RowIndex].Cells["SL"].Value.ToString();
            // Lấy MaTN từ CSDL nếu chưa có sẵn trong DataGridView
            string maTN = LayMaTienNghiTheoTen(tenTN); // Viết hàm này tùy vào cấu trúc
            if (e.ColumnIndex == 3) // 3 là chỉ số cột icon sửa trong dtgDanhSachTienNghiTheoLoaiPhong
            {
               
              

                FormSuaChiTietTienNghi frm = new FormSuaChiTietTienNghi(_maLPH, maTN, tenTN, int.Parse(sl));
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadChiTietTienNghi(); // Refresh lại dữ liệu
                }
            }
            // 🗑 Xử lý khi click vào cột xóa
            if (e.ColumnIndex == 4) // 4 là chỉ số cột icon xóa trong dtgDanhSachTienNghiTheoLoaiPhong
            {
                var result = MessageBox.Show($"Bạn có chắc muốn xóa tiện nghi '{tenTN}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = KetNoi.MoKetNoi())
                    {
                        string query = @"
                        delete CTTN
                        
                        WHERE MaLPH = @MaLPH AND MaTN = @MaTN";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaLPH", _maLPH);
                        cmd.Parameters.AddWithValue("@MaTN", maTN);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadChiTietTienNghi(); // Refresh lại danh sách
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private string LayMaTienNghiTheoTen(string tenTN)
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "SELECT MaTN FROM TienNghi WHERE TenTN = @TenTN AND DaXoa = 0";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenTN", tenTN);

                var result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : "";
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var frm = new FormThemChiTietTienNghi(_maLPH);
            frm.ShowDialog();

            // Sau khi thêm xong, load lại danh sách
            LoadChiTietTienNghi();
        }
    }
}

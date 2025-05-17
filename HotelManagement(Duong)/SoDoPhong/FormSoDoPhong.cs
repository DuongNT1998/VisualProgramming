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

namespace HotelManagement.SoDoPhong
{
    public partial class FormSoDoPhong : Form
    {
        public FormSoDoPhong()
        {
            InitializeComponent();
        }

        private void FormSoDoPhong_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhong(); // Gọi phương thức để load dữ liệu khi form được mở
        }
        private void LoadDanhSachPhong()
        {
            string query = @"
        SELECT 
            MaPH,
            SUBSTRING(MaPH, 2, 1) AS Tang,
            TenLPH,
            TTPH,
            TTDD,
            GhiChu
        FROM Phong P
        JOIN LoaiPhong L ON P.MaLPH = L.MaLPH
        WHERE DaXoa = 0 OR DaXoa IS NULL
    ";

            SqlConnection conn = KetNoi.MoKetNoi();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

              dataGridViewPhong.DataSource = dt;

                // Cập nhật tên cột hiển thị
                dataGridViewPhong.Columns["Tang"].HeaderText = "Tầng";
                dataGridViewPhong.Columns["MaPH"].HeaderText = "Mã phòng";
                dataGridViewPhong.Columns["TenLPH"].HeaderText = "Loại phòng";
                dataGridViewPhong.Columns["TTPH"].HeaderText = "Trạng thái phòng";
                dataGridViewPhong.Columns["TTDD"].HeaderText = "Tình trạng dọn dẹp";
                dataGridViewPhong.Columns["GhiChu"].HeaderText = "Ghi chú";
              

                dataGridViewPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tùy chọn: tự động giãn cột
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách phòng: " + ex.Message);
            }
            finally
            {
                KetNoi.DongKetNoi(conn);
            }
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LoadPhongTheoTieuChi();
        }
        private void LoadPhongTheoTieuChi()
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                try
                {
                    // Khởi tạo câu truy vấn cơ bản với JOIN để lấy TenLPH
                    string query = @"
                SELECT 
                    P.MaPH, 
                    L.TenLPH,
                    P.TTPH, 
                    P.TTDD, 
                    P.GhiChu
              
                 
                FROM Phong P
                JOIN LoaiPhong L ON P.MaLPH = L.MaLPH
                WHERE P.DaXoa = 0";

                    // Danh sách các điều kiện lọc
                    List<string> filters = new List<string>();

                    // Trạng thái phòng
                    if (rdbPhongTrong.Checked) filters.Add("P.TTPH = N'Bình thường'");
                    else if (rdbPhongDaDat.Checked) filters.Add("P.TTPH = N'Đã đặt'");
                    else if (rdbPhongDangThue.Checked) filters.Add("P.TTPH = N'Đang thuê'");
                    else if (rdbPhongDangSuaChua.Checked) filters.Add("P.TTPH = N'Đang sửa chữa'");

                    // Loại phòng
                    if (rdbPhongThuongDon.Checked) filters.Add("P.MaLPH = 'NOR01'");
                    else if (rdbPhongThuongDoi.Checked) filters.Add("P.MaLPH = 'NOR02'");
                    else if (rdbPhongVipDon.Checked) filters.Add("P.MaLPH = 'VIP01'");
                    else if (rdbPhongVipDoi.Checked) filters.Add("P.MaLPH = 'VIP02'");

                    // Tình trạng dọn dẹp
                    if (rdbPhongDaDonDep.Checked) filters.Add("P.TTDD = N'Đã dọn dẹp'");
                    else if (rdbPhongChuaDon.Checked) filters.Add("P.TTDD = N'Chưa dọn dẹp'");

                    // Nếu có điều kiện lọc, thêm vào truy vấn
                    if (filters.Count > 0)
                    {
                        query += " AND " + string.Join(" AND ", filters);
                    }

                    // Thực hiện truy vấn
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Thêm cột "Tầng"
                    if (!dt.Columns.Contains("Tầng"))
                        dt.Columns.Add("Tầng", typeof(string));

                    foreach (DataRow row in dt.Rows)
                    {
                        row["Tầng"] = row["MaPH"].ToString().Substring(1, 1);
                    }

                    // Gán dữ liệu vào DataGridView
                    dataGridViewPhong.DataSource = dt;

                    // Đặt lại tên các cột nếu muốn
                    dataGridViewPhong.Columns["Tầng"].HeaderText = "Tầng";
                    dataGridViewPhong.Columns["MaPH"].HeaderText = "Mã số phòng";
                    dataGridViewPhong.Columns["TenLPH"].HeaderText = "Loại phòng";
                    dataGridViewPhong.Columns["TTPH"].HeaderText = "Trạng thái phòng";
                    dataGridViewPhong.Columns["TTDD"].HeaderText = "Tình trạng dọn dẹp";
                    dataGridViewPhong.Columns["GhiChu"].HeaderText = "Ghi chú";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lọc dữ liệu: " + ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                try
                {
                    string maPhong = txtSearchMaPhong.Text.Trim();

                    // Nếu ô tìm kiếm rỗng thì hiển thị toàn bộ dữ liệu gốc
                    if (string.IsNullOrEmpty(maPhong))
                    {
                        LoadPhongTheoTieuChi(); // hoặc không gọi gì nếu bạn muốn giữ nguyên dữ liệu cũ
                        return;
                    }

                    string query = @"
                SELECT 
                    P.MaPH, 
         L.TenLPH,
                    P.TTPH, 
                    P.TTDD, 
                    P.GhiChu
             
           
                FROM Phong P
                JOIN LoaiPhong L ON P.MaLPH = L.MaLPH
                WHERE P.DaXoa = 0 AND P.MaPH = @MaPH";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@MaPH", maPhong);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Thêm cột "Tầng" nếu chưa có
                    if (!dt.Columns.Contains("Tầng"))
                        dt.Columns.Add("Tầng", typeof(string));

                    foreach (DataRow row in dt.Rows)
                    {
                        row["Tầng"] = row["MaPH"].ToString().Substring(1, 1);
                    }

                    // Gán dữ liệu vào DataGridView
                    dataGridViewPhong.DataSource = dt;

                    // Tùy chỉnh tiêu đề cột nếu cần
                    dataGridViewPhong.Columns["Tầng"].HeaderText = "Tầng";
                    dataGridViewPhong.Columns["MaPH"].HeaderText = "Mã phòng";
                    dataGridViewPhong.Columns["TenLPH"].HeaderText = "Loại phòng";
                    dataGridViewPhong.Columns["TTPH"].HeaderText = "Trạng thái phòng";
                    dataGridViewPhong.Columns["TTDD"].HeaderText = "Tình trạng dọn dẹp";
                    dataGridViewPhong.Columns["GhiChu"].HeaderText = "Ghi chú";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
                }
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            // Mở Form đặt phòng, có thể truyền mã phòng nếu muốn
            FormDatPhong fDatPhong = new FormDatPhong();
            // fDatPhong.MaPhong = maPhong; // nếu cần truyền mã phòng
            fDatPhong.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngayChon = dtNgayChon.Value.Date;

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                try
                {
                    string query = @"
                SELECT 
                    P.MaPH,
                    SUBSTRING(P.MaPH, 2, 1) AS Tang,
                    L.TenLPH,
                    P.TTPH,
                    P.TTDD,
                    P.GhiChu
                FROM Phong P
                JOIN LoaiPhong L ON P.MaLPH = L.MaLPH
                WHERE 
                    (P.DaXoa = 0 OR P.DaXoa IS NULL)
                    AND P.TTPH = N'Bình thường'
                    AND NOT EXISTS (
                        SELECT 1 FROM CTDP C
                        WHERE 
                            C.MaPH = P.MaPH 
                            AND C.DaXoa = 0
                            AND @NgayChon >= CAST(C.CheckIn AS DATE) 
                            AND @NgayChon < CAST(C.CheckOut AS DATE)
                    )
            ";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@NgayChon", ngayChon);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Gán vào DataGridView
                    dataGridViewPhong.DataSource = dt;

                    // Cập nhật tiêu đề cột
                    dataGridViewPhong.Columns["MaPH"].HeaderText = "Mã phòng";
                    dataGridViewPhong.Columns["Tang"].HeaderText = "Tầng";
                    dataGridViewPhong.Columns["TenLPH"].HeaderText = "Loại phòng";
                    dataGridViewPhong.Columns["TTPH"].HeaderText = "Trạng thái phòng";
                    dataGridViewPhong.Columns["TTDD"].HeaderText = "Tình trạng dọn dẹp";
                    dataGridViewPhong.Columns["GhiChu"].HeaderText = "Ghi chú";

                    dataGridViewPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm phòng theo ngày: " + ex.Message);
                }
            }
        }
    }
}

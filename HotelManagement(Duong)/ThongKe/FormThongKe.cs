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
using System.Windows.Forms.DataVisualization.Charting;
using HotelManagement.KetNoiCSDL;
namespace HotelManagement.ThongKe
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                // 1. Tổng doanh thu thuê phòng
                SqlCommand cmd1 = new SqlCommand(@"
            SELECT ISNULL(SUM(TriGia), 0) 
            FROM HoaDon
            WHERE NgHD BETWEEN @tuNgay AND @denNgay", conn);
                cmd1.Parameters.AddWithValue("@tuNgay", tuNgay);
                cmd1.Parameters.AddWithValue("@denNgay", denNgay);
                lbDoanhThuThuePhong.Text = $"{(decimal)cmd1.ExecuteScalar():N0} VND";

                // 2. Tổng doanh thu dịch vụ
                SqlCommand cmd2 = new SqlCommand(@"
            SELECT ISNULL(SUM(ctdv.ThanhTien), 0) 
            FROM CTDV join CTDP on CTDV.MaCTDP =  CTDP.MaCTDP
            WHERE CheckIn BETWEEN @tuNgay AND @denNgay", conn);
                cmd2.Parameters.AddWithValue("@tuNgay", tuNgay);
                cmd2.Parameters.AddWithValue("@denNgay", denNgay);
                lbDoanhThuDichVu.Text = $"{(decimal)cmd2.ExecuteScalar():N0} VND";

                // 3. Số phòng đã được đặt
                SqlCommand cmd3 = new SqlCommand(@"
            SELECT COUNT(*) 
            FROM CTDP
            WHERE CheckIn BETWEEN @tuNgay AND @denNgay", conn);
                cmd3.Parameters.AddWithValue("@tuNgay", tuNgay);
                cmd3.Parameters.AddWithValue("@denNgay", denNgay);
                lbSoPhongDat.Text = cmd3.ExecuteScalar().ToString();

                // 4. Loại phòng có doanh thu cao nhất
                SqlCommand cmd4 = new SqlCommand(@"
            SELECT TOP 1 lp.TenLPH, SUM(ct.ThanhTien) AS DoanhThu
            FROM CTDP ct
            JOIN Phong p ON ct.MaPh = p.MaPh
            JOIN LoaiPhong lp ON p.MaLPH = lp.MaLPH
            WHERE ct.CheckIn BETWEEN @tuNgay AND @denNgay
            GROUP BY lp.TenLPH
            ORDER BY DoanhThu DESC", conn);
                cmd4.Parameters.AddWithValue("@tuNgay", tuNgay);
                cmd4.Parameters.AddWithValue("@denNgay", denNgay);
                using (var reader = cmd4.ExecuteReader())
                {
                    if (reader.Read())
                        lbLoaiPhongDoanhThuCaoNhat.Text = $"{reader["TenLPH"]} ({Convert.ToDecimal(reader["DoanhThu"]):N0} VND)";
                }

                // 5. Loại phòng được đặt nhiều nhất
                SqlCommand cmd5 = new SqlCommand(@"
            SELECT TOP 1 lp.Tenlph, COUNT(*) AS SoLuong
            FROM CTDP dp
            JOIN Phong p ON dp.MaPh = p.MaPh
            JOIN LoaiPhong lp ON p.MaLPH = lp.MaLPH
            WHERE dp.Checkin BETWEEN @tuNgay AND @denNgay
            GROUP BY lp.TenLPH
            ORDER BY SoLuong DESC", conn);
                cmd5.Parameters.AddWithValue("@tuNgay", tuNgay);
                cmd5.Parameters.AddWithValue("@denNgay", denNgay);
                using (var reader = cmd5.ExecuteReader())
                {
                    if (reader.Read())
                        lbLoaiPhongDuocDatNhieuNhat.Text = $"{reader["TenLPH"]} ({reader["SoLuong"]} lượt)";
                }

                // 6. Dịch vụ có doanh thu cao nhất
                SqlCommand cmd6 = new SqlCommand(@"
            SELECT TOP 1 dv.TenDV, SUM(ctdv.ThanhTien) AS DoanhThu
            FROM ctdv
            JOIN DichVu dv ON ctdv.MaDV = dv.MaDV
join CTDP on CTDV.MaCTDP =  CTDP.MaCTDP
            WHERE ctdP.CheckIn BETWEEN @tuNgay AND @denNgay
            GROUP BY dv.TenDV
            ORDER BY DoanhThu DESC", conn);
                cmd6.Parameters.AddWithValue("@tuNgay", tuNgay);
                cmd6.Parameters.AddWithValue("@denNgay", denNgay);
                using (var reader = cmd6.ExecuteReader())
                {
                    if (reader.Read())
                        lbDoanhThuDichVuCaoNhat.Text = $"{reader["TenDV"]} ({Convert.ToDecimal(reader["DoanhThu"]):N0} VND)";
                }

                // 7. Biểu đồ cột doanh thu thuê phòng theo loại


                SqlCommand cmd7 = new SqlCommand(@"
    SELECT lp.TenLPH, SUM(dp.ThanhTien) AS TongDoanhThu
    FROM CTDP dp
    JOIN Phong p ON dp.MaPh = p.MaPh
    JOIN LoaiPhong lp ON p.MaLPH = lp.MaLPH
    WHERE dp.CheckIn BETWEEN @tuNgay AND @denNgay
    GROUP BY lp.TenLPH", conn);

                cmd7.Parameters.AddWithValue("@tuNgay", tuNgay);
                cmd7.Parameters.AddWithValue("@denNgay", denNgay);

                SqlDataAdapter da1 = new SqlDataAdapter(cmd7);
                DataTable dtCol = new DataTable();
                da1.Fill(dtCol);

                chartDoanhThuThuePhong.Series.Clear();
                chartDoanhThuThuePhong.Series.Add("Doanh thu theo loại phòng");

                // 👉 Chuyển thành biểu đồ cột
                chartDoanhThuThuePhong.Series["Doanh thu theo loại phòng"].ChartType =
                    System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                // 👉 Thêm dữ liệu
                foreach (DataRow row in dtCol.Rows)
                {
                    chartDoanhThuThuePhong.Series["Doanh thu theo loại phòng"]
                        .Points.AddXY(row["TenLPH"].ToString(), Convert.ToDecimal(row["TongDoanhThu"]));
                }




                // 8.  Biểu đồ tròn dịch vụ đã dùng

                SqlCommand cmd8 = new SqlCommand(@"
    SELECT dv.TenDV, COUNT(*) AS SoLuong
    FROM ctdv
    JOIN DichVu dv ON ctdv.MaDV = dv.MaDV
    JOIN CTDP ON ctdv.MaCTDP = CTDP.MaCTDP
    WHERE CTDP.CheckIn BETWEEN @tuNgay AND @denNgay
    GROUP BY dv.TenDV", conn);

                // Thêm tham số trước khi Fill
                cmd8.Parameters.AddWithValue("@tuNgay", tuNgay);
                cmd8.Parameters.AddWithValue("@denNgay", denNgay);

                SqlDataAdapter da2 = new SqlDataAdapter(cmd8);
                DataTable dtBar = new DataTable();
                da2.Fill(dtBar);

                // Tạo mới series trước khi dùng
                chartDichVuDaDung.Series.Clear();
                chartDichVuDaDung.Series.Add("Dịch vụ");

                // ✅ Đổi kiểu biểu đồ thành Pie
                chartDichVuDaDung.Series["Dịch vụ"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                // ✅ (Tùy chọn) Hiển thị tên dịch vụ trên Pie
                chartDichVuDaDung.Series["Dịch vụ"]["PieLabelStyle"] = "Outside";
                chartDichVuDaDung.Series["Dịch vụ"].IsValueShownAsLabel = true;

                foreach (DataRow row in dtBar.Rows)
                {
                    chartDichVuDaDung.Series["Dịch vụ"].Points.AddXY(row["TenDV"], row["SoLuong"]);
                }


                // 9. Biểu đồ cột số phòng đã đặt theo loại
                // Biểu đồ cột: số phòng đã đặt theo loại (dựa trên CheckIn trong CTDP)
                SqlCommand cmd9 = new SqlCommand(@"
    SELECT lp.TenLPH, COUNT(*) AS SoLuong
    FROM LoaiPhong lp 
    JOIN Phong p ON lp.MaLPH = p.MaLPH
    JOIN CTDP ON ctdp.MaPH = p.MaPH
    WHERE CTDP.CheckIn BETWEEN @tuNgay AND @denNgay
    GROUP BY lp.TenLPH", conn);

                cmd9.Parameters.AddWithValue("@tuNgay", tuNgay);
                cmd9.Parameters.AddWithValue("@denNgay", denNgay);

                // Đổ dữ liệu vào DataTable
                SqlDataAdapter da9 = new SqlDataAdapter(cmd9);
                DataTable dtBar3 = new DataTable();
                da9.Fill(dtBar3);

                // Hiển thị lên biểu đồ
                chartSoPhongDaDat.Series.Clear(); // Xóa dữ liệu cũ
                chartSoPhongDaDat.Series.Add("Số lượng đặt");
                chartSoPhongDaDat.Series["Số lượng đặt"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                foreach (DataRow row in dtBar3.Rows)
                {
                    chartSoPhongDaDat.Series["Số lượng đặt"].Points.AddXY(row["TenLPH"], row["SoLuong"]);
                }

                // Thiết lập kiểu biểu đồ là cột (Column)

                KetNoi.DongKetNoi(conn);
            }
        }
    }
}


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
using HotelManagement.DangNhap;
using HotelManagement.KetNoiCSDL;

namespace HotelManagement.SoDoPhong
{
    public partial class FormDatPhong : Form
    {
        string maNV = FormDangNhap.MaNV_DangNhap;
        public FormDatPhong()
        {
            InitializeComponent();
        }

        private void FormDatPhong_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhongTrong();
            KhoiTaoGridPhongDaChon();
        }
        private void LoadDanhSachPhongTrong()
        {
            string ngayDen = dtpNgayBD.Value.ToString("yyyy-MM-dd");
            string ngayDi = dtpNgayKT.Value.ToString("yyyy-MM-dd");

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"
        SELECT p.MaPH, lp.TenLPH
        FROM Phong p
        JOIN LoaiPhong lp ON p.MaLPH = lp.MaLPH
        WHERE p.TTPH = N'Bình thường' AND p.DaXoa = 0 AND NOT EXISTS (
            SELECT 1 FROM CTDP ct
            WHERE ct.MaPH = p.MaPH AND ct.DaXoa = 0
            AND (
                (ct.CheckIn <= @NgayDi AND ct.CheckOut >= @NgayDen)
            )
        )";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NgayDen", ngayDen);
                cmd.Parameters.AddWithValue("@NgayDi", ngayDi);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt); 
                dt.Columns.Add("Thêm", typeof(Image));
                foreach (DataRow row in dt.Rows)
                {
                    row["Thêm"] = Properties.Resources.Add; // icon add từ Resources
                }

                dtgDanhSachPhongTrong.DataSource = dt;
            }

        }

        private void dtgDanhSachPhongTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgDanhSachPhongTrong.Columns[e.ColumnIndex].Name == "Thêm")
            {
                string maPhong = dtgDanhSachPhongTrong.Rows[e.RowIndex].Cells["MaPH"].Value.ToString();
                string tenLoai = dtgDanhSachPhongTrong.Rows[e.RowIndex].Cells["TenLPH"].Value.ToString();

                // Lấy thời gian đặt phòng
                DateTime checkIn = GetDateTime(dtpNgayBD, cbGioDen, cbDangGioDen);
                DateTime checkOut = GetDateTime(dtpNgayKT, cbGioDi, cbDangGioDi);

                // Lấy số người tối đa từ loại phòng
                int soNguoiToiDa = LaySoNguoiToiDa(maPhong);

                dtgDanhSachPhongDaChon.Rows.Add(maPhong, soNguoiToiDa, checkIn, checkOut, Properties.Resources.delete);
            }
        }

        public static int LaySoNguoiToiDa(string maPhong)
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"SELECT lp.SoNguoiToiDa
                         FROM Phong p JOIN LoaiPhong lp ON p.MaLPH = lp.MaLPH
                         WHERE p.MaPH = @maPH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maPH", maPhong);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }
        private DateTime GetDateTime(DateTimePicker dtp, ComboBox cbGio, ComboBox cbAMPM)
        {
            string gio = cbGio.SelectedItem.ToString();
            string ampm = cbAMPM.SelectedItem.ToString();

            DateTime baseDate = dtp.Value.Date;
            DateTime gioPhut = DateTime.ParseExact(gio, "h:mm", null);

            int hour = gioPhut.Hour;
            int minute = gioPhut.Minute;

            if (ampm == "PM" && hour < 12) hour += 12;
            if (ampm == "AM" && hour == 12) hour = 0;

            return baseDate.AddHours(hour).AddMinutes(minute);
        }

        private void dtgDanhSachPhongDaChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgDanhSachPhongDaChon.Columns[e.ColumnIndex].Name == "Huy")
            {
                dtgDanhSachPhongDaChon.Rows.RemoveAt(e.RowIndex);
            }
        }
  
        private string TaoMaKH()
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "SELECT TOP 1 MaKH FROM KhachHang  ORDER BY MaKH DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string maCuoi = result.ToString(); // ví dụ: "KH045"
                    int so = int.Parse(maCuoi.Substring(2)); // 45
                    so++;
                    return "KH" + so.ToString("D3"); // KH046
                }
                else
                {
                    return "KH001";
                }
            }
        }
        private string TaoMaPT()
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "SELECT TOP 1 MaPT FROM PhieuThue ORDER BY MaPT DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    int so = int.Parse(result.ToString().Substring(2));
                    return "PT" + (so + 1).ToString("D3");
                }
                else
                {
                    return "PT001";
                }
            }
        }
        private string TaoMaCTDP()
        {
            string maCTDP = "CTDP";
            int soTiepTheo;

            // Mở kết nối CSDL
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"SELECT TOP 1 MaCTDP FROM CTDP ORDER BY MaCTDP DESC"; // Lấy mã CTDP mới nhất

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Lấy phần số cuối của mã CTDP mới nhất
                    string maCu = reader["MaCTDP"].ToString();
                    string soCu = maCu.Substring(4); // Lấy phần sau "CTDP"
                    soTiepTheo = int.Parse(soCu) + 1; // Tăng số cuối lên 1
                }
                else
                {
                    soTiepTheo = 1; // Nếu chưa có CTDP nào, bắt đầu từ 1
                }

                // Tạo mã CTDP mới với định dạng "CTDPxxx"
                maCTDP += soTiepTheo.ToString("D3"); // Đảm bảo rằng số luôn có 3 chữ số (ví dụ: 001, 002, ...)
            }

            return maCTDP;
        }
        private void KhoiTaoGridPhongDaChon()
        {
            dtgDanhSachPhongDaChon.Columns.Clear();

            dtgDanhSachPhongDaChon.Columns.Add("MaPhong", "Mã phòng");
            dtgDanhSachPhongDaChon.Columns.Add("SoNguoiToiDa", "Số người tối đa");
            dtgDanhSachPhongDaChon.Columns.Add("NgayBatDau", "Ngày bắt đầu");
            dtgDanhSachPhongDaChon.Columns.Add("NgayKetThuc", "Ngày kết thúc");

            // Cột Hủy (chứa nút hình icon delete)
            DataGridViewImageColumn colHuy = new DataGridViewImageColumn();
            colHuy.Name = "Huy";
            colHuy.HeaderText = "Hủy";
            colHuy.Image = Properties.Resources.delete; // đổi tên icon đúng trong resource của bạn
            colHuy.Width = 30;
            dtgDanhSachPhongDaChon.Columns.Add(colHuy);

            // Tuỳ chọn không cho auto tạo cột nếu bạn đã tạo thủ công
            dtgDanhSachPhongDaChon.AutoGenerateColumns = false;
        }
        private bool LuuPhieuThue()
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                SqlTransaction transaction = conn.BeginTransaction(); // Bắt đầu transaction

                try
                {
                    // 1. Thêm khách hàng mới nếu cần
                    string maKH;

                    // Kiểm tra nếu khách hàng đã tồn tại theo CCCD
                    string queryKiemTra = "SELECT MaKH FROM KhachHang WHERE [CCCD/Passport] = @CCCD AND DaXoa = 0";
                    using (SqlCommand cmdCheck = new SqlCommand(queryKiemTra, conn, transaction))
                    {
                        cmdCheck.Parameters.AddWithValue("@CCCD", txtCCCD.Text.Trim());
                        object result = cmdCheck.ExecuteScalar();
                        if (result != null)
                        {
                            maKH = result.ToString(); // đã có
                        }
                        else
                        {
                            // Thêm khách hàng mới
                            maKH = TaoMaKH();
                            string queryInsertKH = @"INSERT INTO KhachHang (MaKH, TenKH, SDT, [CCCD/Passport], QuocTich, GioiTinh, DaXoa)
                 VALUES (@MaKH, @TenKH, @SDT, @CCCD, @QuocTich, @GioiTinh, 0)";
                            SqlCommand cmdInsertKH = new SqlCommand(queryInsertKH, conn, transaction);
                            cmdInsertKH.Parameters.AddWithValue("@MaKH", maKH);
                            cmdInsertKH.Parameters.AddWithValue("@TenKH", txtHoVaTen.Text);
                            cmdInsertKH.Parameters.AddWithValue("@SDT", txtSoDienThoai.Text);
                            cmdInsertKH.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
                            cmdInsertKH.Parameters.AddWithValue("@QuocTich", txtQuocTich.Text);
                            cmdInsertKH.Parameters.AddWithValue("@GioiTinh", cbGioiTinh.SelectedItem.ToString());
                            cmdInsertKH.ExecuteNonQuery();
                        }
                    }

                    // 2. Lưu phiếu thuê phòng
                    string maPT = TaoMaPT(); // Mã phiếu thuê mới
                    string queryInsertPT = @"INSERT INTO PhieuThue (MaPT, NgPT, MaKH, MaNV, DaXoa)
                             VALUES (@MaPT, @NgPT, @MaKH, @MaNV, 0)";
                    SqlCommand cmdInsertPT = new SqlCommand(queryInsertPT, conn, transaction);
                    cmdInsertPT.Parameters.AddWithValue("@MaPT", maPT);
                    cmdInsertPT.Parameters.AddWithValue("@NgPT", DateTime.Now); // Ngày phiếu thuê
                    cmdInsertPT.Parameters.AddWithValue("@MaKH", maKH);
                    cmdInsertPT.Parameters.AddWithValue("@MaNV", maNV);
                    cmdInsertPT.ExecuteNonQuery(); // Thêm phiếu thuê

                    // 3. Chuẩn bị dữ liệu cho Bulk Insert
                    DataTable dtCTDP = new DataTable();
                    dtCTDP.Columns.Add("MaCTDP", typeof(string));
                    dtCTDP.Columns.Add("SoNguoi", typeof(int));
                    dtCTDP.Columns.Add("MaPT", typeof(string));
                    dtCTDP.Columns.Add("MaPH", typeof(string));
                    dtCTDP.Columns.Add("CheckIn", typeof(DateTime));
                    dtCTDP.Columns.Add("CheckOut", typeof(DateTime));
                    dtCTDP.Columns.Add("TrangThai", typeof(string));
                    dtCTDP.Columns.Add("DonGia", typeof(decimal));
                    dtCTDP.Columns.Add("ThanhTien", typeof(decimal));

                    int stt = 0;
                    using (SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM CTDP", conn, transaction))
                    {
                        stt = (int)cmdCount.ExecuteScalar();
                    }

                    foreach (DataGridViewRow row in dtgDanhSachPhongDaChon.Rows)
                    {
                        if (row.IsNewRow) continue;
                        stt++;
                        string maCTDP = "CTDP" + stt.ToString("D3");
                        string maPH = row.Cells["MaPhong"].Value.ToString();
                        int soNguoi = Convert.ToInt32(row.Cells["SoNguoiToiDa"].Value.ToString());
                        DateTime checkIn = dtpNgayBD.Value.AddHours(cbGioDen.SelectedIndex * 0.5);
                        DateTime checkOut = dtpNgayKT.Value.AddHours(cbGioDi.SelectedIndex * 0.5);

                        // 1. Lấy DonGia từ bảng LoaiPhong thông qua Phong -> MaLPH -> GiaNgay
                        decimal donGia = 0;
                        using (SqlCommand cmdGia = new SqlCommand(@"
                    SELECT lp.GiaNgay FROM Phong p
                    JOIN LoaiPhong lp ON p.MaLPH = lp.MaLPH
                    WHERE p.MaPH = @MaPH", conn, transaction))
                        {
                            cmdGia.Parameters.AddWithValue("@MaPH", maPH);
                            object result = cmdGia.ExecuteScalar();
                            if (result != null)
                            {
                                donGia = Convert.ToDecimal(result);
                            }
                        }

                        // 2. Tính số ngày ở (làm tròn lên nếu có thời gian lẻ)
                        double soNgayO = Math.Ceiling((checkOut - checkIn).TotalDays);
                        decimal thanhTien = donGia * (decimal)soNgayO;

                        // 3. Thêm dòng vào DataTable
                        dtCTDP.Rows.Add(maCTDP, soNguoi, maPT, maPH, checkIn, checkOut, "Đã đặt", donGia, thanhTien);
                    }

                    // 4. Sử dụng SqlBulkCopy để chèn các dữ liệu vào bảng CTDP
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn, SqlBulkCopyOptions.Default, transaction))
                    {
                        bulkCopy.DestinationTableName = "CTDP";
                        bulkCopy.WriteToServer(dtCTDP); // Bulk Insert tất cả các dữ liệu vào bảng CTDP
                    }

                    // 5. Cập nhật trạng thái phòng
                    foreach (DataGridViewRow row in dtgDanhSachPhongDaChon.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string maPH = row.Cells["MaPhong"].Value.ToString();
                        using (SqlCommand cmdUpdatePhong = new SqlCommand(@"
                UPDATE Phong SET TTPH = N'Đã đặt' WHERE MaPH = @MaPH", conn, transaction))
                        {
                            cmdUpdatePhong.Parameters.AddWithValue("@MaPH", maPH);
                            cmdUpdatePhong.ExecuteNonQuery(); // Cập nhật trạng thái phòng
                        }
                    }

                    // Commit transaction
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Có lỗi xảy ra khi chạy hàm LuuPhieuThue(): {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private bool KiemTraVaDienThongTinKH(string cccd)
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = "SELECT TOP 1 * FROM KhachHang WHERE [CCCD/Passport] = @CCCD AND DaXoa = 0";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CCCD", cccd);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtHoVaTen.Text = reader["TenKH"].ToString();
                        txtSoDienThoai.Text = reader["SDT"].ToString();
                        txtQuocTich.Text = reader["QuocTich"].ToString();
                        string gioiTinh = reader["GioiTinh"].ToString();

                        cbGioiTinh.SelectedItem = gioiTinh;

                        // Disable các control nhập liệu
                        txtHoVaTen.Enabled = false;
                        txtSoDienThoai.Enabled = false;
                        txtQuocTich.Enabled = false;
                        cbGioiTinh.Enabled = false;

                        return true; // đã tồn tại
                    }
                }
            }

            return false; // chưa tồn tại
        }
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            // 0.Kiểm tra CCCD đã tồn tại trong DB chưa
            bool khachHangTonTai = KiemTraVaDienThongTinKH(txtCCCD.Text.Trim());

            if (khachHangTonTai)
            {
                DialogResult result = MessageBox.Show("Khách hàng đã tồn tại trong hệ thống. Thông tin sẽ được tự động điền và không thể sửa.\nBạn có muốn tiếp tục đặt phòng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.No) return;
            }
            // 1. Kiểm tra thông tin khách hàng
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text) ||
                string.IsNullOrWhiteSpace(txtCCCD.Text) ||
                string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ||
                string.IsNullOrWhiteSpace(txtQuocTich.Text) ||
                cbGioiTinh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra thời gian hợp lệ
            DateTime ngayDen = dtpNgayBD.Value.Date;
            DateTime ngayDi = dtpNgayKT.Value.Date;
            if (ngayDi <= ngayDen)
            {
                MessageBox.Show("Ngày trả phòng phải sau ngày nhận phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbGioDen.SelectedIndex == -1 || cbGioDi.SelectedIndex == -1 ||
                cbDangGioDen.SelectedIndex == -1 || cbDangGioDi.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ giờ đến và giờ đi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Kiểm tra đã chọn phòng chưa
            if (dtgDanhSachPhongDaChon.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 phòng để đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Nếu OK -> Gọi hàm lưu
            bool thanhCong = LuuPhieuThue(); // bạn có thể truyền thêm thông tin nếu cần

            if (thanhCong)
            {
                MessageBox.Show("Đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // hoặc reset form
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi đặt phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// //////////////
        /// </summary>
        
    }
}

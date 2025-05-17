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
using HotelManagement.HoaDon;
using HotelManagement.KetNoiCSDL;

namespace HotelManagement.PhieuThue
{
    public partial class FormChiTietPhieuThue : Form
    {
        private string maPT;
        string maNV = FormDangNhap.MaNV_DangNhap;

        public FormChiTietPhieuThue(string maPT)
        {
            InitializeComponent();
            this.maPT = maPT;
        }

        private void FormChiTietPhieuThue_Load(object sender, EventArgs e)
        {
            LoadThongTinPhieuThue();
            LoadDanhSachChiTietPhieuThue();
        }
        private void LoadThongTinPhieuThue()
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"
            SELECT pt.MaPT, kh.TenKH, pt.NgPT, nv.TenNV
            FROM PhieuThue pt
            JOIN KhachHang kh ON pt.MaKH = kh.MaKH
            JOIN NhanVien nv ON pt.MaNV = nv.MaNV
            WHERE pt.MaPT = @MaPT";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPT", maPT);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lbSoPhieu.Text = "Chi tiết phiếu thuê " + reader["MaPT"].ToString();
                        lbHoTenKH.Text = reader["TenKH"].ToString();
                        lbThoiGianLP.Text = Convert.ToDateTime(reader["NgPT"]).ToString("dd/MM/yyyy");
                        lbHoTenNV.Text = reader["TenNV"].ToString();
                    }
                }
            }
        }
        private void LoadDanhSachChiTietPhieuThue()
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"
        SELECT maCTDP, ctdp.MapH, ctdp.CheckIn, ctdp.CheckOut, ctdp.TrangThai, ThanhTien
        FROM CTDP ctdp
        WHERE ctdp.MaPT = @MaPT and ctdp.DaXoa=0";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPT", maPT);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dtgDanhSachCTPT.DataSource = dt;

                // Format headers
                dtgDanhSachCTPT.Columns["maCTDP"].HeaderText = "Mã CT Phiếu";
                dtgDanhSachCTPT.Columns["MapH"].HeaderText = "Số phòng";
                dtgDanhSachCTPT.Columns["CheckIn"].HeaderText = "Ngày đến KS";
                dtgDanhSachCTPT.Columns["CheckOut"].HeaderText = "Ngày đi";
                dtgDanhSachCTPT.Columns["ThanhTien"].HeaderText = "Thành tiền";
                dtgDanhSachCTPT.Columns["CheckIn"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dtgDanhSachCTPT.Columns["CheckOut"].DefaultCellStyle.Format = "dd/MM/yyyy";

                // Thêm cột biểu tượng nếu chưa có
                if (!dtgDanhSachCTPT.Columns.Contains("Huy"))
                {
                    DataGridViewImageColumn colHuy = new DataGridViewImageColumn();
                    colHuy.Name = "Huy";
                    colHuy.HeaderText = "";
                    colHuy.ToolTipText = "Hủy thông tin chi tiết phiếu";
                    dtgDanhSachCTPT.Columns.Add(colHuy);
                }

                if (!dtgDanhSachCTPT.Columns.Contains("Sua"))
                {
                    DataGridViewImageColumn colSua = new DataGridViewImageColumn();
                    colSua.Name = "Sua";
                    colSua.HeaderText = "";
                    colSua.ToolTipText = "Cập nhật trạng thái của chi tiết phiếu";
                    dtgDanhSachCTPT.Columns.Add(colSua);
                }

                if (!dtgDanhSachCTPT.Columns.Contains("DichVu"))
                {
                    DataGridViewImageColumn colDichVu = new DataGridViewImageColumn();
                    colDichVu.Name = "DichVu";
                    colDichVu.HeaderText = "Dịch vụ đã dùng";
                    colDichVu.ToolTipText = "Quản lý dịch vụ đã dùng của phòng";
                    dtgDanhSachCTPT.Columns.Add(colDichVu);
                }

                // ✅ Thêm cột Thanh Toán
                if (!dtgDanhSachCTPT.Columns.Contains("ThanhToan"))
                {
                    DataGridViewImageColumn colThanhToan = new DataGridViewImageColumn();
                    colThanhToan.Name = "ThanhToan";
                    colThanhToan.HeaderText = "Thanh toán";
                    colThanhToan.ToolTipText = "Thanh toán hóa đơn cho phòng này";
                    dtgDanhSachCTPT.Columns.Add(colThanhToan);
                }

                // Gán giá trị biểu tượng theo trạng thái
                foreach (DataGridViewRow row in dtgDanhSachCTPT.Rows)
                {
                    string trangThai = row.Cells["TrangThai"].Value?.ToString();

                    row.Cells["Huy"].Value = (trangThai == "Đã đặt") ? Properties.Resources.delete : null;
                    row.Cells["Sua"].Value = (trangThai == "Đã đặt") ? Properties.Resources.edit : null;
                    row.Cells["DichVu"].Value = (trangThai == "Đang thuê") ? Properties.Resources.DichVu1:null;
                    row.Cells["ThanhToan"].Value = (trangThai == "Đang thuê") ? Properties.Resources.money : null;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgDanhSachCTPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maPH = dtgDanhSachCTPT.Rows[e.RowIndex].Cells["MapH"].Value.ToString();
            string trangThai = dtgDanhSachCTPT.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();
            string maCTDP = dtgDanhSachCTPT.Rows[e.RowIndex].Cells["maCTDP"].Value.ToString();
            if (e.RowIndex >= 0 && dtgDanhSachCTPT.Columns[e.ColumnIndex].Name == "Huy")
            {
              
                if (trangThai != "Đã đặt")
                {
                    MessageBox.Show("Chỉ có thể huỷ những phòng đã đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn huỷ phòng {maPH} không?", "Xác nhận huỷ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = KetNoi.MoKetNoi()) // Giả sử đã mở
                    {
                        SqlTransaction transaction = conn.BeginTransaction();

                        try
                        {
                            // 1. Xoá CTDP
                            string deleteQuery = "UPDATE CTDP SET DAXOA = 1 WHERE MaPT = @MaPT AND MapH = @MapH";
                            SqlCommand cmdDelete = new SqlCommand(deleteQuery, conn, transaction);
                            cmdDelete.Parameters.AddWithValue("@MaPT", maPT);
                            cmdDelete.Parameters.AddWithValue("@MapH", maPH);
                            cmdDelete.ExecuteNonQuery();

                            // 2. Cập nhật trạng thái phòng
                            string updateQuery = "UPDATE Phong SET TTPH = N'Bình thường' WHERE MaPH = @MapH";
                            SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn, transaction);
                            cmdUpdate.Parameters.AddWithValue("@MapH", maPH);
                            cmdUpdate.ExecuteNonQuery();

                            transaction.Commit();

                            // 3. Xoá khỏi DataGridView
                            dtgDanhSachCTPT.Rows.RemoveAt(e.RowIndex);

                            MessageBox.Show($"Phòng {maPH} đã được huỷ và cập nhật trạng thái thành 'Bình thường'.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Lỗi khi huỷ phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            if (e.RowIndex >= 0 && dtgDanhSachCTPT.Columns[e.ColumnIndex].Name == "Sua") {
                FormSuaChiTietPhieuThue frm = new FormSuaChiTietPhieuThue(maPT, maPH);
                frm.FormClosed += (s, args) => LoadDanhSachChiTietPhieuThue(); // <- reload lại khi form đóng
                frm.ShowDialog();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgDanhSachCTPT.Columns["DichVu"].Index)
            {
               
                // Tạo khóa chính MaCTDP từ MaPT + MaPH (nếu đúng thiết kế của bạn)
                

                // Mở form danh sách dịch vụ
                FormDanhSachDichVuPhongDaDung frmDV = new FormDanhSachDichVuPhongDaDung(maCTDP, maPH);
                frmDV.ShowDialog();
            }
            if (e.RowIndex >= 0 && dtgDanhSachCTPT.Columns[e.ColumnIndex].Name == "ThanhToan")
            {
                TinhTienVaThanhToanHoaDon(maCTDP);
                LoadDanhSachChiTietPhieuThue(); // Cập nhật lại DataGridView
            }
        }
        private void TinhTienVaThanhToanHoaDon(string maCTDP)
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
      

                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // 1. Lấy tiền thuê phòng từ CTDP
                    decimal tienPhong = 0;
                    string maPhong = "";

                    string queryPhong = "SELECT ThanhTien, MaPH FROM CTDP WHERE MaCTDP = @maCTDP";
                    using (SqlCommand cmd = new SqlCommand(queryPhong, conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@maCTDP", maCTDP);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tienPhong = reader.GetDecimal(0);
                                maPhong = reader.GetString(1);
                            }
                        }
                    }

                    // 2. Tính tiền dịch vụ
                    decimal tienDV = 0;
                    string queryDV = "SELECT SUM(ThanhTien) FROM CTDV WHERE MaCTDP = @maCTDP AND DaXoa = 0";
                    using (SqlCommand cmd = new SqlCommand(queryDV, conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@maCTDP", maCTDP);
                        object result = cmd.ExecuteScalar();
                        tienDV = (result != DBNull.Value) ? Convert.ToDecimal(result) : 0;
                    }

                    // 3. Tính tổng tiền
                    decimal tongTien = tienPhong + tienDV;

                    // 4. Sinh mã hóa đơn mới (dạng HD001)
                    string maHD = "HD001";
                    string getMax = "SELECT MAX(MaHD) FROM HoaDon";
                    using (SqlCommand cmd = new SqlCommand(getMax, conn, tran))
                    {
                        object maxMa = cmd.ExecuteScalar();
                        if (maxMa != DBNull.Value && maxMa != null)
                        {
                            string current = maxMa.ToString().Substring(2);
                            int next = int.Parse(current) + 1;
                            maHD = "HD" + next.ToString("D3");
                        }
                    }

                    // 5. Insert vào bảng HoaDon
                    string insertHD = @"INSERT INTO HoaDon(MaHD, NgHD, TriGia, MaNV, TrangThai, MaCTDP)
                                VALUES (@MaHD, GETDATE(), @TriGia, @MaNV, N'Chờ  KH xác nhận', @MaCTDP)";
                    using (SqlCommand cmd = new SqlCommand(insertHD, conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", maHD);
                        cmd.Parameters.AddWithValue("@TriGia", tongTien);
                        cmd.Parameters.AddWithValue("@MaNV", maNV); // <-- bạn cần truyền MaNV (nhân viên đang login)
                        cmd.Parameters.AddWithValue("@MaCTDP", maCTDP);
                        cmd.ExecuteNonQuery();
                    }

                    // 6. Cập nhật CTDP.TrangThai = "Đã thanh toán"
                    string updateCTDP = "UPDATE CTDP SET TrangThai = N'Đã thanh toán' WHERE MaCTDP = @maCTDP";
                    using (SqlCommand cmd = new SqlCommand(updateCTDP, conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@maCTDP", maCTDP);
                        cmd.ExecuteNonQuery();
                    }

                    // 7. Cập nhật trạng thái phòng => "Bình thường"
                    string updatePH = "UPDATE Phong SET TTPH = N'Bình thường' WHERE MaPH = @maPhong";
                    using (SqlCommand cmd = new SqlCommand(updatePH, conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@maPhong", maPhong);
                        cmd.ExecuteNonQuery();
                    }

                    tran.Commit();

                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 8. Load lại danh sách hóa đơn ở FormDanhSach
                    if (Application.OpenForms["FormDanhSach"] is FormDanhSachHoaDon formDanhSach)
                    {
                        formDanhSach.LoadDanhSachHoaDon(); // <-- bạn cần có hàm này trong FormDanhSach
                    }
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

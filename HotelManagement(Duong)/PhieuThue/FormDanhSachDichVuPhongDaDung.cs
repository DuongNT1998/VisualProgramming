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

namespace HotelManagement.PhieuThue
{
    public partial class FormDanhSachDichVuPhongDaDung : Form
    {
        private string maCTDP;
        private string maPH;
        public FormDanhSachDichVuPhongDaDung(string maCTDP, string maPH)
        {
            InitializeComponent();
            this.maCTDP = maCTDP;
            this.maPH = maPH;
            lbSoCTPhieu.Text = "Mã chi tiết phiếu: " + maCTDP;
            lbSoPhong.Text = "Số phòng: " + maPH;

            LoadDanhSachDichVu();
        }
        private void LoadDanhSachDichVu() 
        {
         

            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                string query = @"
            SELECT dv.MaDV, dv.TenDV, dv.DonGia, ctdv.SL, 
                   (ctdv.SL * dv.DonGia) AS ThanhTien
            FROM CTDV ctdv
            JOIN DichVu dv ON ctdv.MaDV = dv.MaDV
            WHERE ctdv.MaCTDP = @MaCTDP AND ctdv.DaXoa = 0";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaCTDP", maCTDP);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dtgDanhSachDichVu.DataSource = dt;

                // Format
                dtgDanhSachDichVu.Columns["MaDV"].HeaderText = "Mã dịch vụ";
                dtgDanhSachDichVu.Columns["TenDV"].HeaderText = "Tên dịch vụ";
                dtgDanhSachDichVu.Columns["DonGia"].HeaderText = "Đơn giá";
                dtgDanhSachDichVu.Columns["SL"].HeaderText = "Số lượng";
                dtgDanhSachDichVu.Columns["ThanhTien"].HeaderText = "Thành tiền";
                dtgDanhSachDichVu.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                dtgDanhSachDichVu.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
            }
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            FormThemDichVuPhongDaDung frm = new FormThemDichVuPhongDaDung(maCTDP, maPH);
            frm.ShowDialog();

            // Sau khi thêm xong, tự động load lại danh sách dịch vụ
            LoadDanhSachDichVu();
        }
    }
}

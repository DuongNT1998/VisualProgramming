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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace HotelManagement.HoaDon
{
    public partial class FormHoaDon : Form
    {
        private string _maHD;
        public FormHoaDon(string maHD)
        {
            InitializeComponent();
            _maHD = maHD;
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            LoadThongTinHoaDon();
        }

        private void LoadThongTinHoaDon()
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
             

                // 1. Lấy thông tin chung của hóa đơn
                string queryHoaDon = @"
SELECT hd.MaHD, hd.NgHD, nv.TenNV, kh.TenKH, p.MaPh, lp.TenLPH, hd.TriGia,ctdp.ThanhTien ,
       ctdp.CheckIn, ctdp.CheckOut
FROM HoaDon hd
JOIN NhanVien nv ON hd.MaNV = nv.MaNV
JOIN ctdp ON hd.MaCTDP = ctdp.MaCTDP
JOIN PhieuThue pt ON pt.MaPT = ctdp.MaPT
JOIN KhachHang kh ON pt.MaKH = kh.MaKH
JOIN Phong p ON ctdp.MaPH = p.MaPh
JOIN LoaiPhong lp ON p.MaLPH = lp.MaLPH
WHERE hd.MaHD = @MaHD";

                SqlCommand cmd = new SqlCommand(queryHoaDon, conn);
                cmd.Parameters.AddWithValue("@MaHD", _maHD);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtMaHoaDon.Text = reader["MaHD"].ToString();
                    dtpNgayHD.Value = Convert.ToDateTime(reader["NgHD"]);
                    txtTenNV.Text = reader["TenNV"].ToString();
                    txtTenKH.Text = reader["TenKH"].ToString();
                    txtMaPhong.Text = reader["MaPh"].ToString();
                    txtTenLP.Text = reader["TenLPH"].ToString();
                    txtTienThuePhong.Text= string.Format("{0:N0} VND", Convert.ToDecimal(reader["ThanhTien"]));
                    lbTongTriGia.Text = "Tổng tiền: "+ string.Format("{0:N0} VND", Convert.ToDecimal(reader["TriGia"]));

                    // Tính số ngày thuê
                    DateTime checkin = Convert.ToDateTime(reader["CheckIn"]);
                    DateTime checkout = Convert.ToDateTime(reader["CheckOut"]);
                    int soNgay = (checkout - checkin).Days;
                    txtSoNgayThuePhong.Text = soNgay.ToString();
                }

                reader.Close();

                // 2. Lấy danh sách dịch vụ
                string queryDV = @"
SELECT dv.TenDV, dv.DonGia, ctdv.SL , (dv.DonGia * ctdv.SL) AS ThanhTien
FROM ctdv
JOIN DichVu dv ON ctdv.MaDV = dv.MaDV
JOIN ctdp ON ctdv.MaCTDP = ctdp.MaCTDP
JOIN HoaDon hd ON ctdp.MaCTDP = hd.MaCTDP
WHERE hd.MaHD = @MaHD";

                // Tạo command riêng
                SqlCommand cmdDV = new SqlCommand(queryDV, conn);
                cmdDV.Parameters.AddWithValue("@MaHD", _maHD);

                // Gán vào adapter
                SqlDataAdapter adapter = new SqlDataAdapter(cmdDV);
                DataTable dtDV = new DataTable();
                adapter.Fill(dtDV);
                dtgDichVuDaDung.DataSource = dtDV;

                // Format gridview
                dtgDichVuDaDung.Columns["TenDV"].HeaderText = "Tên dịch vụ";
                dtgDichVuDaDung.Columns["DonGia"].HeaderText = "Đơn giá";
                dtgDichVuDaDung.Columns["SL"].HeaderText = "Số lượng";
                dtgDichVuDaDung.Columns["ThanhTien"].HeaderText = "Thành tiền";
            }
        }

        private void Printer_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
                // Cập nhật trạng thái HÓA ĐƠN => "Đã thanh toán"
                string updatePH = "UPDATE HOADON SET Trangthai = N'Đã thanh toán' WHERE MaHD= @maHD";
                using (SqlCommand cmd = new SqlCommand(updatePH, conn))
                {
                    cmd.Parameters.AddWithValue("@maHD", _maHD);
                    cmd.ExecuteNonQuery();
                }
            }
            XuatHoaDonRaPDF();

        }
        private void XuatHoaDonRaPDF()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF files (*.pdf)|*.pdf";
            save.FileName = "HoaDon_" + txtMaHoaDon.Text + ".pdf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document(PageSize.A4, 25, 25, 30, 30);

                using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                {
                    PdfWriter.GetInstance(doc, stream);
                    doc.Open();

                    // Tiêu đề
                    var titleFont = FontFactory.GetFont("Arial", "16", Font.Bold);
                    var normalFont = FontFactory.GetFont("Arial", "12", Font.Italic);
                    Paragraph title = new Paragraph("HÓA ĐƠN THANH TOÁN\n\n", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    doc.Add(title);

                    // Thông tin chung
                    PdfPTable tableInfo = new PdfPTable(2);
                    tableInfo.WidthPercentage = 100;
                    tableInfo.DefaultCell.Border = 0;
                    tableInfo.AddCell("Mã hóa đơn:");
                    tableInfo.AddCell(txtMaHoaDon.Text);
                    tableInfo.AddCell("Ngày lập:");
                    tableInfo.AddCell(dtpNgayHD.Value.ToString("dd/MM/yyyy"));
                    tableInfo.AddCell("Khách hàng:");
                    tableInfo.AddCell(txtTenKH.Text);
                    tableInfo.AddCell("Nhân viên lập:");
                    tableInfo.AddCell(txtTenNV.Text);
                    tableInfo.AddCell("Phòng:");
                    tableInfo.AddCell(txtMaPhong.Text);
                    tableInfo.AddCell("Loại phòng:");
                    tableInfo.AddCell(txtTenLP.Text);
                    tableInfo.AddCell("Số ngày thuê:");
                    tableInfo.AddCell(txtSoNgayThuePhong.Text);
                    tableInfo.AddCell("Tiền thuê phòng:");
                    tableInfo.AddCell(txtTienThuePhong.Text);
                    doc.Add(tableInfo);

                    doc.Add(new Paragraph("\nDỊCH VỤ ĐÃ SỬ DỤNG:\n", normalFont));

                    // Bảng dịch vụ
                    PdfPTable tableDV = new PdfPTable(4);
                    tableDV.WidthPercentage = 100;
                    tableDV.SetWidths(new float[] { 3, 2, 1.5f, 2 });

                    // Header
                    tableDV.AddCell("Tên dịch vụ");
                    tableDV.AddCell("Đơn giá");
                    tableDV.AddCell("Số lượng");
                    tableDV.AddCell("Thành tiền");

                    // Dữ liệu
                    foreach (DataGridViewRow row in dtgDichVuDaDung.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            tableDV.AddCell(row.Cells["TenDV"].Value?.ToString());
                            tableDV.AddCell(row.Cells["DonGia"].Value?.ToString());
                            tableDV.AddCell(row.Cells["SL"].Value?.ToString());
                            tableDV.AddCell(row.Cells["ThanhTien"].Value?.ToString());
                        }
                    }

                    doc.Add(tableDV);

                    // Tổng tiền
                    Paragraph total = new Paragraph("\n" + lbTongTriGia.Text, titleFont);
                    total.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(total);

                    doc.Close();
                }

                MessageBox.Show("Xuất hóa đơn PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}

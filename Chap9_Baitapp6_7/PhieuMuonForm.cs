using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Chap9_Baitapp6_7
{
    public partial class PhieuMuonForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Chap9_Baitap6;Integrated Security=True;TrustServerCertificate=True;");
        string currentMaPhieuMuon = ""; // lưu mã phiếu mượn đang thêm chi tiết
        public PhieuMuonForm()
        {
            InitializeComponent();
        }

        private void PhieuMuonForm_Load(object sender, EventArgs e)
        {
            LoadDocGia();
            LoadPhieuMuon();
        }
        // Hàm LoadDocGia
        private void LoadDocGia()
        {
            using (SqlConnection localConn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Chap9_Baitap6;Integrated Security=True;TrustServerCertificate=True;"))
            {
                localConn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MaDocGia, HoTenDocGia FROM DOCGIA", localConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbTenDG.DataSource = dt;
                cbTenDG.DisplayMember = "HoTenDocGia";
                cbTenDG.ValueMember = "MaDocGia";
            }
        }




        // Hàm LoadPhieuMuon
        private void LoadPhieuMuon(string maDocGia = "", string maPhieuMuon = "")
        {
            using (SqlConnection localConn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Chap9_Baitap6;Integrated Security=True;TrustServerCertificate=True;"))
            {
                localConn.Open();
                var query = @"
            SELECT pm.MaPhieuMuon,
                   ctp.MaSach,
                   s.TenSach,
                   ctp.NgayTraDUKIEN,
                   ctp.NgayTraThucTe
            FROM PHIEUMUONSACH pm
            JOIN CHITIETPHIEUMUON ctp ON pm.MaPhieuMuon = ctp.MaPhieuMuon
            JOIN SACH s ON ctp.MaSach = s.MaSach
            WHERE (@MaDocGia = '' OR pm.MaDocGia = @MaDocGia)
              AND (@MaPhieuMuon = '' OR pm.MaPhieuMuon = @MaPhieuMuon)";
                var cmd = new SqlCommand(query, localConn);
                cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);
                cmd.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);

                lstPhieuMuon.Items.Clear();
                foreach (DataRow r in dt.Rows)
                {
                    var item = new ListViewItem(r["MaPhieuMuon"].ToString());
                    item.SubItems.Add(r["TenSach"].ToString());
                    var ngayDuKien = Convert.ToDateTime(r["NgayTraDUKIEN"]).ToString("dd/MM/yyyy");
                    item.SubItems.Add(ngayDuKien);
                    string ngayThucTe = r["NgayTraThucTe"] == DBNull.Value
                        ? ""
                        : Convert.ToDateTime(r["NgayTraThucTe"]).ToString("dd/MM/yyyy");
                    item.SubItems.Add(ngayThucTe);

                    // tính trạng thái
                    int tt = 0;
                    if (r["NgayTraThucTe"] != DBNull.Value)
                    {
                        var dtThucTe = Convert.ToDateTime(r["NgayTraThucTe"]);
                        var dtDuKien = Convert.ToDateTime(r["NgayTraDUKIEN"]);
                        tt = dtThucTe <= dtDuKien ? 1 : 2;
                    }
                    item.SubItems.Add(tt == 0 ? "Đang mượn"
                                        : tt == 1 ? "Trả đúng hạn"
                                                  : "Trả trễ hạn");

                    item.Tag = r["MaSach"];        // ← lưu MaSach ở đây
                    lstPhieuMuon.Items.Add(item);
                }
            }
        }



        private void btnXemPhieu_Click(object sender, EventArgs e)
        {
            string maDocGia = txtMaDG.Text.Trim();
            string maPhieuMuon = txtMaPhieuMuon.Text.Trim();
            LoadPhieuMuon(maDocGia, maPhieuMuon);

        }
        // Hàm LoadMaDocGiaFromTenDocGia
        private void LoadMaDocGiaFromTenDocGia(string hoTen)
        {
            using (SqlConnection localConn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Chap9_Baitap6;Integrated Security=True;TrustServerCertificate=True;"))
            {
                localConn.Open();
                string query = "SELECT MaDocGia FROM DOCGIA WHERE HoTenDocGia = @HoTen";
                SqlCommand cmd = new SqlCommand(query, localConn);
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    txtMaDG.Text = result.ToString();
                }
            }
        }
        // Hàm cbTenDG_SelectedIndexChanged
        private void cbTenDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenDG.SelectedValue != null)
            {
                string hoTen = cbTenDG.Text;
                LoadMaDocGiaFromTenDocGia(hoTen);
                LoadPhieuMuon(maDocGia: txtMaDG.Text);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDG.Text))
            {
                MessageBox.Show("Vui lòng chọn độc giả trước!");
                return;
            }

            // Enable combobox Tên sách, Ngày phải trả
            cbTenSach.Enabled = true;
            dtNgayPhaiTraDuKien.Enabled = true;
            dtNgayTraThucTe.Enabled = false; // không cho chọn ngày trả thực tế

            LoadTenSach();
            GenerateNewMaPhieuMuonIfNeeded();
        }

        private void LoadTenSach()
        {
            using (SqlConnection localConn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Chap9_Baitap6;Integrated Security=True;TrustServerCertificate=True;"))
            {
                localConn.Open();
                string sql = "SELECT MaSach, TenSach FROM Sach WHERE TrangThai = 0";
                SqlDataAdapter da = new SqlDataAdapter(sql, localConn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbTenSach.DataSource = dt;
                cbTenSach.DisplayMember = "TenSach";
                cbTenSach.ValueMember = "MaSach";
                cbTenSach.SelectedIndex = -1;
            }
        }

        private void GenerateNewMaPhieuMuonIfNeeded()
        {
            if (string.IsNullOrEmpty(currentMaPhieuMuon))
            {
                using (SqlConnection localConn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Chap9_Baitap6;Integrated Security=True;TrustServerCertificate=True;"))
                {
                    localConn.Open();
                    string insertPhieuMuon = "INSERT INTO PhieuMuonSach (MaDocGia, NgayMuon) OUTPUT INSERTED.MaPhieuMuon VALUES (@MaDocGia, GETDATE())";
                    SqlCommand cmd = new SqlCommand(insertPhieuMuon, localConn);
                    cmd.Parameters.AddWithValue("@MaDocGia", txtMaDG.Text.Trim());

                    currentMaPhieuMuon = cmd.ExecuteScalar().ToString();
                    txtMaPhieuMuon.Text = currentMaPhieuMuon;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentMaPhieuMuon) || cbTenSach.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn sách!");
                return;
            }

            using (SqlConnection localConn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Chap9_Baitap6;Integrated Security=True;TrustServerCertificate=True;"))
            {
                try
                {
                    localConn.Open();
                    string insertChiTiet = "INSERT INTO ChiTietPhieuMuon (MaPhieuMuon, MaSach, NgayTraDuKien,TrangThai) VALUES (@MaPhieuMuon, @MaSach, @NgayPhaiTra, 0)";
                    SqlCommand cmd = new SqlCommand(insertChiTiet, localConn);
                    cmd.Parameters.AddWithValue("@MaPhieuMuon", currentMaPhieuMuon);
                    cmd.Parameters.AddWithValue("@MaSach", cbTenSach.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@NgayPhaiTra", dtNgayPhaiTraDuKien.Value.Date);

                    cmd.ExecuteNonQuery();

                    // Sau khi mượn, cập nhật trạng thái sách thành đã mượn
                    string updateSach = "UPDATE Sach SET TrangThai = 1 WHERE MaSach = @MaSach";
                    SqlCommand cmdUpdate = new SqlCommand(updateSach, localConn);
                    cmdUpdate.Parameters.AddWithValue("@MaSach", cbTenSach.SelectedValue.ToString());
                    cmdUpdate.ExecuteNonQuery();

                    MessageBox.Show("Thêm chi tiết phiếu mượn thành công!");

                    // Reload lại sách còn có thể mượn
                    LoadTenSach();
                    LoadPhieuMuon();
                }
                finally
                {
                    localConn.Close();
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lstPhieuMuon.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật!");
                return;
            }

            // Lấy MaSach từ Tag
            var it = lstPhieuMuon.SelectedItems[0];
            string maPhieu = txtMaPhieuMuon.Text;
            string maSach = it.Tag.ToString();

            // Parse ngày trả thực tế
            DateTime ngayDuKien = DateTime.Parse(dtNgayPhaiTraDuKien.Text);
            DateTime ngayThucTe = DateTime.Parse(dtNgayTraThucTe.Text);

            // Tính trạng thái: 0=đang,1=đúng,2=trễ
            int trangThai = ngayThucTe <= ngayDuKien ? 1 : 2;

            using (SqlConnection localConn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Chap9_Baitap6;Integrated Security=True;TrustServerCertificate=True;"))
            {
                {
                    localConn.Open();
                    // 1. Cập nhật ChiTietPhieuMuon
                    string updCT = @"
            UPDATE CHITIETPHIEUMUON
            SET NgayTraThucTe = @NgayThucTe,
                TrangThai     = @TT
            WHERE MaPhieuMuon = @MaPM
              AND MaSach      = @MaSach";
                    var cmd1 = new SqlCommand(updCT, localConn);
                    cmd1.Parameters.AddWithValue("@NgayThucTe", ngayThucTe);
                    cmd1.Parameters.AddWithValue("@TT", trangThai);
                    cmd1.Parameters.AddWithValue("@MaPM", maPhieu);
                    cmd1.Parameters.AddWithValue("@MaSach", maSach);
                    cmd1.ExecuteNonQuery();

                    // 2. Cập nhật sách về trạng thái = 0 (có thể mượn lại)
                    string updSach = "UPDATE SACH SET TrangThai = 0 WHERE MaSach = @MaSach";
                    var cmd2 = new SqlCommand(updSach, localConn);
                    cmd2.Parameters.AddWithValue("@MaSach", maSach);
                    cmd2.ExecuteNonQuery();
                }

                MessageBox.Show("Cập nhật thành công!");
                // Reload lại view
                LoadPhieuMuon(txtMaDG.Text, txtMaPhieuMuon.Text);
            }
        }

        private void lstPhieuMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPhieuMuon.SelectedItems.Count > 0)
            {
                // Lấy thông tin từ dòng được chọn trong ListView
                ListViewItem selectedItem = lstPhieuMuon.SelectedItems[0];
                string maPhieuMuon = selectedItem.SubItems[0].Text;
                string tenSach = selectedItem.SubItems[1].Text;
                string ngayTraDukien = selectedItem.SubItems[2].Text;
                string ngayTraThucTe = selectedItem.SubItems[3].Text;
                string trangThai = selectedItem.SubItems[4].Text;

                // Hiển thị thông tin lên các control
                txtMaPhieuMuon.Text = maPhieuMuon;
                cbTenSach.Text = tenSach;
                dtNgayPhaiTraDuKien.Text = ngayTraDukien;

                // Nếu có ngày trả thực tế, hiển thị trên control, nếu không thì để trống
                if (!string.IsNullOrEmpty(ngayTraThucTe))
                {
                    dtNgayTraThucTe.Text = ngayTraThucTe;
                }
                else
                {
                    dtNgayTraThucTe.Text = "";
                }

                // Disable các nút không cần thiết
                btnXemPhieu.Enabled = false;
                btnThem.Enabled = false;
                btnLuu.Enabled = false;
                dtNgayPhaiTraDuKien.Enabled = false;
            }
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra mã phiếu
            if (string.IsNullOrEmpty(txtMaPhieuMuon.Text))
            {
                MessageBox.Show("Vui lòng nhập hoặc chọn mã phiếu mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maPhieu = txtMaPhieuMuon.Text.Trim();

            // 2. Lấy thông tin phiếu mượn và độc giả
            DataTable dtPhieu;
            DataTable dtChiTiet;
            using (SqlConnection localConn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Chap9_Baitap6;Integrated Security=True;TrustServerCertificate=True;"))
            {
                localConn.Open();

                // Thông tin phiếu + độc giả
                string sqlPhieu = @"
            SELECT pm.MaPhieuMuon,
                   pm.NgayMuon,
                   dg.HoTenDocGia,
                   dg.Email,
                   dg.DiaChi
            FROM PHIEUMUONSACH pm
            LEFT JOIN DOCGIA dg ON pm.MaDocGia = dg.MaDocGia
            WHERE pm.MaPhieuMuon = @MaPhieu";
                using (var cmd = new SqlCommand(sqlPhieu, localConn))
                {
                    cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                    dtPhieu = new DataTable();
                    new SqlDataAdapter(cmd).Fill(dtPhieu);
                }

                // Chi tiết phiếu
                string sqlCT = @"
            SELECT s.TenSach,
                   ctp.NgayTraDuKien,
                   ctp.NgayTraThucTe,
                   ctp.TrangThai
            FROM CHITIETPHIEUMUON ctp
            JOIN SACH s ON ctp.MaSach = s.MaSach
            WHERE ctp.MaPhieuMuon = @MaPhieu";
                using (var cmd = new SqlCommand(sqlCT, localConn))
                {
                    cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                    dtChiTiet = new DataTable();
                    new SqlDataAdapter(cmd).Fill(dtChiTiet);
                }
            }

            if (dtPhieu.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phiếu mượn với mã: " + maPhieu, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Chọn file lưu PDF
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.FileName = $"PhieuMuon_{maPhieu}.pdf";
                if (sfd.ShowDialog() != DialogResult.OK) return;

                // 4. Tạo PDF
                Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                doc.Open();

                // Tiêu đề
                var titleFont = FontFactory.GetFont("Arial", "16", Font.Bold);
                Paragraph title = new Paragraph("PHIẾU MƯỢN SÁCH", titleFont) { Alignment = Element.ALIGN_CENTER };
                doc.Add(title);
                doc.Add(new Paragraph(" ")); // dòng trống

                // Thông tin phiếu và độc giả
                DataRow rp = dtPhieu.Rows[0];
                doc.Add(new Paragraph($"Mã phiếu mượn: {rp["MaPhieuMuon"]}"));
                doc.Add(new Paragraph($"Ngày mượn      : {Convert.ToDateTime(rp["NgayMuon"]).ToString("dd/MM/yyyy")}"));
                doc.Add(new Paragraph($"Độc giả        : {rp["HoTenDocGia"]}"));
                doc.Add(new Paragraph($"Email          : {rp["Email"]}"));
                doc.Add(new Paragraph($"Địa chỉ        : {rp["DiaChi"]}"));
                doc.Add(new Paragraph(" "));

                // Bảng chi tiết
                PdfPTable table = new PdfPTable(5) { WidthPercentage = 100 };
                table.SetWidths(new float[] { 10f, 40f, 15f, 15f, 20f });

                // Header
                var hdrFont = FontFactory.GetFont("Arial", "12", Font.Bold);
                table.AddCell(new PdfPCell(new Phrase("STT", hdrFont)));
                table.AddCell(new PdfPCell(new Phrase("Tên sách", hdrFont)));
                table.AddCell(new PdfPCell(new Phrase("Ngày dự kiến", hdrFont)));
                table.AddCell(new PdfPCell(new Phrase("Ngày thực tế", hdrFont)));
                table.AddCell(new PdfPCell(new Phrase("Trạng thái", hdrFont)));

                // Nội dung
                var rowFont = FontFactory.GetFont("Arial", "12", Font.Italic);
                for (int i = 0; i < dtChiTiet.Rows.Count; i++)
                {
                    DataRow r = dtChiTiet.Rows[i];
                    string ttText = r["TrangThai"].ToString() == "0" ? "Đang mượn"
                                  : r["TrangThai"].ToString() == "1" ? "Trả đúng hạn"
                                  : "Trả trễ hạn";

                    table.AddCell(new PdfPCell(new Phrase((i + 1).ToString(), rowFont)));
                    table.AddCell(new PdfPCell(new Phrase(r["TenSach"].ToString(), rowFont)));
                    table.AddCell(new PdfPCell(new Phrase(Convert.ToDateTime(r["NgayTraDuKien"]).ToString("dd/MM/yyyy"), rowFont)));
                    table.AddCell(new PdfPCell(new Phrase(
                        r["NgayTraThucTe"] == DBNull.Value
                            ? ""
                            : Convert.ToDateTime(r["NgayTraThucTe"]).ToString("dd/MM/yyyy"),
                        rowFont)));
                    table.AddCell(new PdfPCell(new Phrase(ttText, rowFont)));
                }

                doc.Add(table);
                doc.Close();
            }

            MessageBox.Show("In phiếu mượn thành công!", "Xong", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

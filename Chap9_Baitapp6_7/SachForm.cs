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

    public partial class SachForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Chap9_Baitap6;Integrated Security=True;TrustServerCertificate=True;");

        public SachForm()
        {
            InitializeComponent();
        }

        private void LoadSachToListView()
        {
            lstSach.Items.Clear();

            using (SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Chap9_Baitap6;Integrated Security=True;TrustServerCertificate=True;")
)
            {
                conn.Open();
                string query = "SELECT * FROM Sach";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["MaSach"].ToString());

                    item.SubItems.Add(reader["TenSach"].ToString());
                    item.SubItems.Add(reader["TacGia"].ToString());

                    DateTime ngayNhap;
                    if (DateTime.TryParse(reader["NgayNhap"].ToString(), out ngayNhap))
                        item.SubItems.Add(ngayNhap.ToShortDateString());
                    else
                        item.SubItems.Add("");

                    item.SubItems.Add(reader["NamXuatBan"].ToString());
                    item.SubItems.Add(reader["NhaXuatBan"].ToString());
                    item.SubItems.Add(reader["TriGia"].ToString());

                    int trangThaiValue = reader["TrangThai"] != DBNull.Value ? Convert.ToInt32(reader["TrangThai"]) : -1;
                    item.SubItems.Add(GetTrangThaiText(trangThaiValue));

                    lstSach.Items.Add(item);
                }
                reader.Close();
            }
        }
        private string GetTrangThaiText(int value)
        {
            switch (value)
            {
                case 0: return "Mới - đang có sẵn";
                case 1: return "Đang được mượn";
                case 2: return "Bị lỗi";
                default: return "Không xác định";
            }
        }
        private void SachForm_Load(object sender, EventArgs e)
        {
            LoadSachToListView();
            for (int year = DateTime.Now.Year; year >= 1900; year--)
                cbNamXuatBan.Items.Add(year.ToString());

            cbTrangThai.Items.Clear();
            cbTrangThai.Items.Add(new KeyValuePair<int, string>(0, "Mới - đang có sẵn"));
            cbTrangThai.Items.Add(new KeyValuePair<int, string>(1, "Đang được mượn"));
            cbTrangThai.Items.Add(new KeyValuePair<int, string>(2, "Bị lỗi"));

            cbTrangThai.DisplayMember = "Value";
            cbTrangThai.ValueMember = "Key";

            dtNgayNhapSach.Value = DateTime.Now;

            // Khi form load, chỉ enable các nút "Thêm" và "Lưu"
            EnableControls(false);
            btnThem.Enabled = true;
            btnLuu.Enabled = true;


        }
        private void EnableControls(bool enable)
        {
            txtMaSach.Enabled = enable;
            txtTenSach.Enabled = enable;
            txtTacGia.Enabled = enable;
            txtNhaXuatBan.Enabled = enable;
            txtTriGia.Enabled = enable;
            cbNamXuatBan.Enabled = enable;
            cbTrangThai.Enabled = enable;
            dtNgayNhapSach.Enabled = enable;

            btnLuu.Enabled = enable;
            btnThem.Enabled = !enable;
            btnCapNhat.Enabled = enable;
            btnXoa.Enabled = enable;
            btnIn.Enabled = enable;
        }

      
        private void btnThem_Click(object sender, EventArgs e)
        {
            EnableControls(true);
            ClearForm();
            txtMaSach.Focus();
        }
        private void ClearForm()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtNhaXuatBan.Clear();
            txtTriGia.Clear();
            cbNamXuatBan.SelectedIndex = -1;
            cbTrangThai.SelectedIndex = -1;
            dtNgayNhapSach.Value = DateTime.Now;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int trangThai = ((KeyValuePair<int, string>)cbTrangThai.SelectedItem).Key;

            using (SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Chap9_Baitap6;Integrated Security=True;TrustServerCertificate=True;"))
            {
                conn.Open();
                string query = "INSERT INTO Sach (TenSach, TacGia, NgayNhap, NamXuatBan, NhaXuatBan, TriGia, TrangThai) " +
                               "VALUES (@TenSach, @TacGia, @NgayNhap, @NamXuatBan, @NhaXuatBan, @TriGia, @TrangThai)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenSach", txtTenSach.Text);
                cmd.Parameters.AddWithValue("@TacGia", txtTacGia.Text);
                cmd.Parameters.AddWithValue("@NgayNhap", dtNgayNhapSach.Value);
                cmd.Parameters.AddWithValue("@NamXuatBan", cbNamXuatBan.Text);
                cmd.Parameters.AddWithValue("@NhaXuatBan", txtNhaXuatBan.Text);
                cmd.Parameters.AddWithValue("@TriGia", txtTriGia.Text);
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Thêm sách thành công!");
            LoadSachToListView();
        }
        private void lstSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSach.SelectedItems.Count == 0)
            {
                // Nếu không chọn dòng nào thì chỉ enable nút "Thêm" và "Lưu"
                EnableControls(false);
                btnThem.Enabled = true;
                btnLuu.Enabled = true;
            }
            else
            {
                // Nếu có chọn dòng trong ListView, enable các nút "Cập nhật", "Xóa", "In"
                EnableControls(true);
                txtMaSach.Enabled = false;
                btnThem.Enabled = false;
                btnLuu.Enabled = false;
            }

            if (lstSach.SelectedItems.Count == 0) return;

            ListViewItem item = lstSach.SelectedItems[0];

            txtMaSach.Text = item.SubItems[0].Text;
            txtTenSach.Text = item.SubItems[1].Text;
            txtTacGia.Text = item.SubItems[2].Text;
            dtNgayNhapSach.Value = DateTime.Parse(item.SubItems[3].Text);
            cbNamXuatBan.Text = item.SubItems[4].Text;
            txtNhaXuatBan.Text = item.SubItems[5].Text;
            txtTriGia.Text = item.SubItems[6].Text;

            // Chọn đúng trạng thái trong combobox
            string trangThaiText = item.SubItems[7].Text;
            foreach (KeyValuePair<int, string> kvp in cbTrangThai.Items)
            {
                if (kvp.Value == trangThaiText)
                {
                    cbTrangThai.SelectedItem = kvp;
                    break;
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lstSach.SelectedItems.Count == 0) return;

            int trangThai = ((KeyValuePair<int, string>)cbTrangThai.SelectedItem).Key;
            string maSach = txtMaSach.Text;

            using (SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Chap9_Baitap6;Integrated Security=True;TrustServerCertificate=True;"))

            {
                conn.Open();
                string query = "UPDATE Sach SET TenSach=@TenSach, TacGia=@TacGia, NgayNhap=@NgayNhap, NamXuatBan=@NamXuatBan, " +
                               "NhaXuatBan=@NhaXuatBan, TriGia=@TriGia, TrangThai=@TrangThai WHERE MaSach=@MaSach";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSach", maSach);
                cmd.Parameters.AddWithValue("@TenSach", txtTenSach.Text);
                cmd.Parameters.AddWithValue("@TacGia", txtTacGia.Text);
                cmd.Parameters.AddWithValue("@NgayNhap", dtNgayNhapSach.Value);
                cmd.Parameters.AddWithValue("@NamXuatBan", cbNamXuatBan.Text);
                cmd.Parameters.AddWithValue("@NhaXuatBan", txtNhaXuatBan.Text);
                cmd.Parameters.AddWithValue("@TriGia", txtTriGia.Text);
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Cập nhật sách thành công!");
            LoadSachToListView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Sach WHERE MaSach=@MaSach", conn);
                cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadSachToListView();
                ClearForm();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF File|*.pdf";
            if (save.ShowDialog() == DialogResult.OK)
            {
                // Tạo tài liệu PDF mới
                Document doc = new Document();
                try
                {
                    // Tạo PdfWriter để ghi dữ liệu vào file PDF
                    PdfWriter.GetInstance(doc, new FileStream(save.FileName, FileMode.Create));

                    // Mở tài liệu để bắt đầu ghi nội dung
                    doc.Open();

                    // Thêm tiêu đề vào PDF
                    doc.Add(new Paragraph("----- THÔNG TIN SÁCH -----"));
                    doc.Add(new Paragraph("Mã Sách: " + txtMaSach.Text));
                    doc.Add(new Paragraph("Tên Sách: " + txtTenSach.Text));
                    doc.Add(new Paragraph("Tác Giả: " + txtTacGia.Text));
                    doc.Add(new Paragraph("Ngày Nhập: " + dtNgayNhapSach.Text));
                    doc.Add(new Paragraph("Năm XB: " + cbNamXuatBan.Text));
                    doc.Add(new Paragraph("Nhà XB: " + txtNhaXuatBan.Text));
                    doc.Add(new Paragraph("Trị Giá: " + txtTriGia.Text));
                    doc.Add(new Paragraph("Trạng Thái: " + cbTrangThai.Text));

                    // Đóng tài liệu PDF
                    doc.Close();

                    MessageBox.Show("Đã in thông tin sách ra PDF!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }
        }
    }
}

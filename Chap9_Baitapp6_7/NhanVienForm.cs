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
    public partial class NhanVienForm : Form
    {
        public NhanVienForm()
        {
            InitializeComponent();
        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            LoadBangCap();
            LoadNhanVien();
            SetControlState(false);
            btnThem.Enabled = btnLuu.Enabled = true;
        }
        private void LoadBangCap()
        {
            cbBangCap.Items.Clear();
            using (SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Chap9_Baitap6;Integrated Security=True;TrustServerCertificate=True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM BangCap", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbBangCap.Items.Add(new
                    {
                        Text = reader["TenBangCap"].ToString(),
                        Value = reader["MaBangCap"].ToString()
                    });
                }
                cbBangCap.DisplayMember = "Text";
                cbBangCap.ValueMember = "Value";
            }
        }
        private void LoadNhanVien()
        {
            lstNhanVien.Items.Clear();
            using (SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Chap9_Baitap6;Integrated Security=True;TrustServerCertificate=True;"))
            {
                conn.Open();
                string query = @"SELECT nv.*, bc.TenBangCap 
                         FROM NhanVien nv 
                         JOIN BangCap bc ON nv.MaBangCap = bc.MaBangCap";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["MaNhanVien"].ToString());
                    item.SubItems.Add(reader["HoTenNhanVien"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(reader["NgaySinh"]).ToString("dd/MM/yyyy"));
                    item.SubItems.Add(reader["DiaChi"].ToString());
                    item.SubItems.Add(reader["DienThoai"].ToString());
                    item.SubItems.Add(reader["TenBangCap"].ToString());
                    lstNhanVien.Items.Add(item);
                }
            }
        }
        private void SetControlState(bool enable)
        {
            txtMaNhanVien.Enabled = enable;
            txtHoTen.Enabled = enable;
            txtDiaChi.Enabled = enable;
            txtSoDienThoai.Enabled = enable;
            dtNgaySinh.Enabled = enable;
            cbBangCap.Enabled = enable;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearForm();
            SetControlState(true);
            btnLuu.Enabled = true;
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnIn.Enabled = false;
        }
        private void ClearForm()
        {
            txtMaNhanVien.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            dtNgaySinh.Value = DateTime.Today;
            cbBangCap.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Chap9_Baitap6;Integrated Security=True;TrustServerCertificate=True;"))
            {
                conn.Open();
                string sql = "INSERT INTO NhanVien (HoTenNhanVien, DiaChi, DienThoai, NgaySinh, MaBangCap) " +
                             "VALUES (@HoTen, @DiaChi, @DienThoai, @NgaySinh, @MaBangCap)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@MaNV", txtMaNhanVien.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@DienThoai", txtSoDienThoai.Text);
                cmd.Parameters.AddWithValue("@MaBangCap", ((dynamic)cbBangCap.SelectedItem).Value);
                cmd.ExecuteNonQuery();
            }
            LoadNhanVien();
            SetControlState(false);
            btnThem.Enabled = btnLuu.Enabled = true;
        }

        private void lstNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNhanVien.SelectedItems.Count == 0) return;

            var item = lstNhanVien.SelectedItems[0];
            txtMaNhanVien.Text = item.SubItems[0].Text;
            txtHoTen.Text = item.SubItems[1].Text;
            dtNgaySinh.Value = DateTime.Parse(item.SubItems[2].Text);
            txtDiaChi.Text = item.SubItems[3].Text;
            txtSoDienThoai.Text = item.SubItems[4].Text;
            cbBangCap.Text = item.SubItems[5].Text;

            SetControlState(true);
            txtMaNhanVien.Enabled = false;

            btnThem.Enabled = true;
            btnCapNhat.Enabled = btnXoa.Enabled = btnIn.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled=false;
            using (SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Chap9_Baitap6;Integrated Security=True;TrustServerCertificate=True;"))
            {
                conn.Open();
                string query = @"UPDATE NhanVien SET HoTenNhanVien=@HoTen, NgaySinh=@NgaySinh,
                         DiaChi=@DiaChi, DienThoai=@DienThoai, MaBangCap=@MaBangCap 
                         WHERE MaNhanVien=@MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", txtMaNhanVien.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@DienThoai", txtSoDienThoai.Text);
                cmd.Parameters.AddWithValue("@MaBangCap", ((dynamic)cbBangCap.SelectedItem).Value);
                cmd.ExecuteNonQuery();
            }
            LoadNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn xoá?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Chap9_Baitap6;Integrated Security=True;TrustServerCertificate=True;"))
                {
                    conn.Open();
                    string query = "DELETE FROM NhanVien WHERE MaNhanVien = @MaNV";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaNV", txtMaNhanVien.Text);
                    cmd.ExecuteNonQuery();
                }
                LoadNhanVien();
                ClearForm();
                SetControlState(false);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (lstNhanVien.SelectedItems.Count > 0)
            {
                var selectedItem = lstNhanVien.SelectedItems[0];

                // Lấy dữ liệu từ dòng ListView
                string maNV = selectedItem.SubItems[0].Text;
                string hoTen = selectedItem.SubItems[1].Text;
                string diaChi = selectedItem.SubItems[2].Text;
                string dienThoai = selectedItem.SubItems[3].Text;
                string ngaySinh = selectedItem.SubItems[4].Text;
                string bangCap = selectedItem.SubItems[5].Text;

                // Tạo Document PDF
                Document doc = new Document();
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "NhanVien_" + maNV + ".pdf");

                try
                {
                    PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                    doc.Open();

                    // Thêm tiêu đề và thông tin vào PDF
                    doc.Add(new Paragraph("Thông tin Nhân viên"));
                    doc.Add(new Paragraph("Mã nhân viên: " + maNV));
                    doc.Add(new Paragraph("Họ tên: " + hoTen));
                    doc.Add(new Paragraph("Địa chỉ: " + diaChi));
                    doc.Add(new Paragraph("Điện thoại: " + dienThoai));
                    doc.Add(new Paragraph("Ngày sinh: " + ngaySinh));
                    doc.Add(new Paragraph("Bằng cấp: " + bangCap));

                    doc.Close();

                    MessageBox.Show("File PDF đã được lưu tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi tạo file PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

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
using System.Runtime.Remoting.Lifetime;

namespace Chap9_Baitapp6_7
{
    public partial class DocGiaForm : Form
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=Chap9_Baitap6;Integrated Security=True;TrustServerCertificate=True;";
        SqlConnection conn;
        bool isAddingNew = false;
        public DocGiaForm()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearForm();
            SetControlState(false);
            isAddingNew = true;
        }

        private void DocGiaForm_Load(object sender, EventArgs e)
        {
            LoadData();
            SetControlState(true);
        }
        private void LoadData()
        {
            lstDocGia.Items.Clear();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DOCGIA", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["MaDocGia"].ToString());
                    item.SubItems.Add(reader["HoTenDocGia"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(reader["NgaySinh"]).ToString("yyyy-MM-dd"));
                    item.SubItems.Add(reader["DiaChi"].ToString());
                    item.SubItems.Add(reader["Email"].ToString());
                    item.SubItems.Add(reader["SoDienThoai"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(reader["NgayLapThe"]).ToString("yyyy-MM-dd"));
                    item.SubItems.Add(Convert.ToDateTime(reader["NgayHetHan"]).ToString("yyyy-MM-dd"));
                    lstDocGia.Items.Add(item);
                }
                reader.Close(); // Đảm bảo đóng reader sau khi sử dụng
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        private void SetControlState(bool isNormalState)
        {
            txtHoTen.Enabled = !isNormalState;
            dtNgaySinh.Enabled = !isNormalState;
            txtDiaChi.Enabled = !isNormalState;
            txtEmail.Enabled = !isNormalState;
            txtSoDienThoai.Enabled = !isNormalState;
            dtNgayLapThe.Enabled = !isNormalState;
            dtNgayHetHanThe.Enabled = !isNormalState;
           

            btnThem.Enabled = isNormalState;
            btnLuu.Enabled = !isNormalState;
            btnCapNhat.Enabled = !isNormalState;
            btnXoa.Enabled = !isNormalState;
            btnIn.Enabled = !isNormalState;
        }
        private void ClearForm()
        {
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtSoDienThoai.Clear();
            dtNgaySinh.Value = DateTime.Now;
            dtNgayLapThe.Value = DateTime.Now;
            dtNgayHetHanThe.Value = DateTime.Now;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isAddingNew)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO DOCGIA (HoTenDocGia, NgaySinh, DiaChi, Email, NgayLapThe, NgayHetHan,SoDienThoai) " +
                                                "VALUES (@HoTen, @NgaySinh, @DiaChi, @Email, @NgayLapThe, @NgayHetHan,@SodienThoai)", conn);
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text);
                cmd.Parameters.AddWithValue("@NgayLapThe", dtNgayLapThe.Value);
                cmd.Parameters.AddWithValue("@NgayHetHan", dtNgayHetHanThe.Value);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE DOCGIA SET HoTenDocGia=@HoTen, NgaySinh=@NgaySinh, DiaChi=@DiaChi, Email=@Email, NgayLapThe=@NgayLapThe, NgayHetHan=@NgayHetHan,SoDienThoai=@SoDienThoai WHERE MaDocGia=@MaDocGia", conn);
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text);

                cmd.Parameters.AddWithValue("@NgayLapThe", dtNgayLapThe.Value);
                cmd.Parameters.AddWithValue("@NgayHetHan", dtNgayHetHanThe.Value);
                cmd.Parameters.AddWithValue("@MaDocGia", lstDocGia.SelectedItems[0].Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            LoadData();
            SetControlState(true);
        }

        private void lstDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDocGia.SelectedItems.Count > 0)
            {
                ListViewItem item = lstDocGia.SelectedItems[0];
                txtHoTen.Text = item.SubItems[1].Text;
                dtNgaySinh.Value = DateTime.Parse(item.SubItems[2].Text);
                txtDiaChi.Text = item.SubItems[3].Text;
                txtEmail.Text = item.SubItems[4].Text;
                txtSoDienThoai.Text = item.SubItems[5].Text;
                dtNgayLapThe.Value = DateTime.Parse(item.SubItems[6].Text);
                dtNgayHetHanThe.Value = DateTime.Parse(item.SubItems[7].Text);


                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
                btnIn.Enabled = true;

                txtHoTen.Enabled = true;
                dtNgaySinh.Enabled = true;
                txtDiaChi.Enabled = true;
                txtEmail.Enabled = true;
                txtSoDienThoai.Enabled = true;
                dtNgayLapThe.Enabled = true;
                dtNgayHetHanThe.Enabled = true;
        

                isAddingNew = false;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lstDocGia.SelectedItems.Count > 0)
            {
                isAddingNew = false;
                btnLuu.Enabled = true;
                btnCapNhat.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnIn.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstDocGia.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM DOCGIA WHERE MaDocGia=@MaDocGia", conn);
                    cmd.Parameters.AddWithValue("@MaDocGia", lstDocGia.SelectedItems[0].Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadData();
                    ClearForm();
                    SetControlState(true);
                }
            }
        }

        //Khi bạn chạy ứng dụng từ Visual Studio, file PDF sẽ được lưu trong thư mục chứa file .exe của ứng dụng, thông thường là:

        //C:\Users\<Tên người dùng>\source\repos\<Tên dự án>\bin\Debug\ (hoặc bin\Release nếu bạn xây dựng dự án ở chế độ Release).
        private void btnIn_Click(object sender, EventArgs e)
        {
            if (lstDocGia.SelectedItems.Count > 0)
            {
                ListViewItem item = lstDocGia.SelectedItems[0];
                Document pdfDoc = new Document();
                PdfWriter.GetInstance(pdfDoc, new FileStream("DocGia_" + item.SubItems[0].Text + ".pdf", FileMode.Create));
                pdfDoc.Open();
                pdfDoc.Add(new Paragraph("Thông Tin Độc Giả"));
                pdfDoc.Add(new Paragraph("Mã Độc Giả: " + item.SubItems[0].Text));
                pdfDoc.Add(new Paragraph("Họ Tên: " + item.SubItems[1].Text));
                pdfDoc.Add(new Paragraph("Ngày Sinh: " + item.SubItems[2].Text));
                pdfDoc.Add(new Paragraph("Địa Chỉ: " + item.SubItems[3].Text));
                pdfDoc.Add(new Paragraph("Email: " + item.SubItems[4].Text));
                pdfDoc.Add(new Paragraph("Số điện thoại: " + item.SubItems[5].Text));
                pdfDoc.Add(new Paragraph("Ngày Lập Thẻ: " + item.SubItems[6].Text));
                pdfDoc.Add(new Paragraph("Ngày Hết Hạn: " + item.SubItems[7].Text));
            
                pdfDoc.Close();
                MessageBox.Show("Đã in thông tin độc giả ra file PDF!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

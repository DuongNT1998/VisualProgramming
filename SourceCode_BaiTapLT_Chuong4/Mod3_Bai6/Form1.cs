namespace Mod3_Bai6
{
    public partial class Form1 : Form
    {
        // Giá của mỗi quyển sách
        private const int DonGia = 20000;

        // Các biến để tính toán thống kê
        private int tongSoKH = 0;
        private int tongSoKHSV = 0;
        private double tongDoanhThu = 0;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void btnTinhThanhTien_Click(object sender, EventArgs e)
        {
            // Kiểm tra tên khách hàng không được rỗng
            if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                MessageBox.Show("Tên khách hàng không được phép rỗng.");
                return;
            }

            // Kiểm tra số lượng sách phải là số nguyên dương
            if (int.TryParse(txtSoLuongSach.Text, out int soLuong) && soLuong > 0)
            {
                double thanhTien = soLuong * DonGia;

                // Kiểm tra nếu khách hàng là sinh viên thì giảm 5% thành tiền
                if (cbKHSV.Checked)
                {
                    thanhTien *= 0.95;
                }

                txtThanhTien.Text = thanhTien.ToString("N0");

                // Cập nhật thống kê
                tongDoanhThu += thanhTien;
                tongSoKH++;
                if (cbKHSV.Checked) tongSoKHSV++;
            }
            else
            {
                MessageBox.Show("Số lượng sách phải là số nguyên dương.");
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            // Xóa nội dung trong các control của groupBox1
            txtTenKH.Clear();
            txtSoLuongSach.Clear();
            txtThanhTien.Clear();
            cbKHSV.Checked = false;

            // Đặt focus lại cho textbox "Tên khách hàng"
            txtTenKH.Focus();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            // Hiển thị thống kê
            txtTongSoKH.Text = tongSoKH.ToString();
            txtTongSoKHSV.Text = tongSoKHSV.ToString();
            txtTongDoanhThu.Text = tongDoanhThu.ToString("N0");
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi đóng ứng dụng
            var result = MessageBox.Show("Bạn có chắc muốn đóng ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

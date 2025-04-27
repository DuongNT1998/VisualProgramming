namespace Mod3_Bai5
{
    public partial class Form1 : Form
    {
        private int tongSoLuong = 0;
        private decimal tongTien = 0;
        public Form1()
        {
            InitializeComponent();
            // Gán sự kiện phím Enter cho nút tính
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }
        // Xử lý sự kiện khi nhấn phím Enter hoặc Tính
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TinhTien();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        // Xử lý sự kiện nhấn nút Tính
        private void BtnTinh_Click(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void btnBanMoi_Click(object sender, EventArgs e)
        {
            // Reset các trường thông tin sau khi bàn mới
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtThanhTien.Clear();

            // Cập nhật thống kê
            CapNhatThongKe();
        }

        // Xử lý sự kiện nhấn nút Thoát
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TinhTien()
        {
            try
            {
                int soLuong = int.Parse(txtSoLuong.Text);
                decimal donGia = decimal.Parse(txtDonGia.Text);
                decimal thanhTien = soLuong * donGia;

                txtThanhTien.Text = thanhTien.ToString();

                // Cập nhật tổng số lượng và tổng tiền
                tongSoLuong += soLuong;
                tongTien += thanhTien;

                // Cập nhật thống kê
                CapNhatThongKe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        // Hàm cập nhật thống kê
        private void CapNhatThongKe()
        {
            txtTongSL.Text = tongSoLuong.ToString();
            txtTongTien.Text = tongTien.ToString();

            // Trung bình = Tổng tiền / Tổng số lượng (nếu có số lượng)
            if (tongSoLuong > 0)
            {
                txtTrungBinh.Text = (tongTien / tongSoLuong).ToString("C");
            }
            else
            {
                txtTrungBinh.Text = "0";
            }
        }
    }
}

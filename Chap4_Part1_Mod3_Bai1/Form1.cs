using System.Globalization;


namespace Mod3_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Form hiển thị giữa màn hình
            this.StartPosition = FormStartPosition.CenterScreen;

            // Gán sự kiện phím Enter cho nút Thanh toán, ESC cho nút Tiếp
            this.AcceptButton = btnThanhToan;
            this.CancelButton = btnTiep;

            // Đặt tất cả text box và label rỗng
            txtTenHang.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtThanhTien.Text = "";

            // Đặt focus vào txtTenHang
            txtTenHang.Focus();


        }
        
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text) || string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Số lượng và Đơn giá!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên không âm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là số không âm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            // Tính thành tiền
            decimal thanhTien = soLuong * donGia;
            txtThanhTien.Text = thanhTien.ToString();

            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số nguyên không âm cho Số lượng!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số hợp lệ cho Đơn giá!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Chỉ cho phép một dấu chấm (.)
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtTenHang.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtThanhTien.Text = "";
            txtTenHang.Focus();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

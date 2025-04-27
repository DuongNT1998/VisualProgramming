namespace Chap4_Part2_Bai3_Page34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNhapSo.Focus();
            this.AcceptButton = btnCapNhat; // Enter sẽ kích hoạt nút Cập nhật
        }

        private void txtNhapSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCapNhat_Click(sender, e);
                e.Handled = e.SuppressKeyPress = true;
            }
        }
      

        private void cbSoVuaNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCacUocSo.Items.Clear();
            if (cbSoVuaNhap.SelectedItem != null)
            {
                int number = Convert.ToInt32(cbSoVuaNhap.SelectedItem);
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                        lbCacUocSo.Items.Add(i);
                }
            }
        }

        private void btnTongCacUocSo_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (var item in lbCacUocSo.Items)
            {
                sum += Convert.ToInt32(item);
            }
            MessageBox.Show($"Tổng các ước số là: {sum}", "Kết quả");
        }

        private void btnSoLuongCacUocSoChan_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (var item in lbCacUocSo.Items)
            {
                if (Convert.ToInt32(item) % 2 == 0)
                    count++;
            }
            MessageBox.Show($"Số lượng các ước số chẵn: {count}", "Kết quả");
        }

        private void btnSoLuongCacUocSNT_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (var item in lbCacUocSo.Items)
            {
                int n = Convert.ToInt32(item);
                if (KiemTraSNT(n)) count++;
            }
            MessageBox.Show($"Số lượng các ước số là số nguyên tố: {count}", "Kết quả");
        }
        private bool KiemTraSNT(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string input = txtNhapSo.Text.Trim();
            if (int.TryParse(input, out int number) && number > 0)
            {
                if (!cbSoVuaNhap.Items.Contains(number))
                    cbSoVuaNhap.Items.Add(number);

                txtNhapSo.Clear();
                txtNhapSo.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên dương hợp lệ!", "Thông báo");
                txtNhapSo.SelectAll();
                txtNhapSo.Focus();
            }
        }
    }
}

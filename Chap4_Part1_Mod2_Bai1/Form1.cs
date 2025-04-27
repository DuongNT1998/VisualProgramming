namespace Mod2_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {

            // Hiển thị nội dung password trên textbox hiển thị
            tbHienThi.Text = tbNhapPassword.Text;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {

            // Xóa nội dung textbox nhập password và textbox hiển thị
            tbNhapPassword.Clear();
            tbHienThi.Clear();

            // Đặt con trỏ vào textbox nhập password
            tbNhapPassword.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

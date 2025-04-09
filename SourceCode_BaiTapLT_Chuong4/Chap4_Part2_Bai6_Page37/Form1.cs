namespace Chap4_Part2_Bai6_Page37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();
            string hoTen = txtHoVaTen.Text.Trim();
            string nienKhoa = cbNienKhoa.SelectedItem?.ToString() ?? "Chưa chọn";
            string lop = cbLop.SelectedItem?.ToString() ?? "Chưa chọn";
            string hocKy = rdHKI.Checked ? "I" :
                           rdHKII.Checked ? "II" :
                           rdHKIII.Checked ? "III" :
                           rdHKIV.Checked ? "IV" : "Chưa chọn";

            string monHoc = "";
            foreach (var item in clbMonHoc.CheckedItems)
            {
                monHoc += "- " + item.ToString() + "\n";
            }
            if (string.IsNullOrEmpty(monHoc))
            {
                monHoc = "Chưa chọn môn học.";
            }

            string message = $"MSSV: {mssv}\nHọ tên: {hoTen}\nNiên khóa: {nienKhoa}\nLớp: {lop}\nHọc kỳ: {hocKy}\nMôn học:\n{monHoc}";
            MessageBox.Show(message, "Thông tin đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            txtMSSV.Clear();
            txtHoVaTen.Clear();
            cbNienKhoa.SelectedIndex = -1;
            cbLop.SelectedIndex = -1;

            rdHKI.Checked = false;
            rdHKII.Checked = false;
            rdHKIII.Checked = false;
            rdHKIV.Checked = false;

            for (int i = 0; i < clbMonHoc.Items.Count; i++)
            {
                clbMonHoc.SetItemChecked(i, false);
            }
            txtMSSV.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

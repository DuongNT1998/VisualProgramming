namespace Mod2_Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            radRed.CheckedChanged += RadioButton_CheckedChanged;
            radGreen.CheckedChanged += RadioButton_CheckedChanged;
            radBlue.CheckedChanged += RadioButton_CheckedChanged;
            radBlack.CheckedChanged += RadioButton_CheckedChanged;
            chkBold.CheckedChanged += CheckBox_CheckedChanged;
            chkItalic.CheckedChanged += CheckBox_CheckedChanged;
            chkUnderline.CheckedChanged += CheckBox_CheckedChanged;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Checked = true; // Chọn mặc định RadioButton Red
            txtNhapTen.Focus(); // Đặt con trỏ vào TextBox
        }
        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text; // Hiển thị song song nội dung nhập
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                txtNhapTen.ForeColor = Color.Red;
                lblLapTrinh.ForeColor = Color.Red;
            }
            else if (radGreen.Checked)
            {
                txtNhapTen.ForeColor = Color.Green;
                lblLapTrinh.ForeColor = Color.Green;
            }
            else if (radBlue.Checked)
            {
                txtNhapTen.ForeColor = Color.Blue;
                lblLapTrinh.ForeColor = Color.Blue;
            }
            else if (radBlack.Checked)
            {
                txtNhapTen.ForeColor = Color.Black;
                lblLapTrinh.ForeColor = Color.Black;
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle style = FontStyle.Regular;
            if (chkBold.Checked) style |= FontStyle.Bold;
            if (chkItalic.Checked) style |= FontStyle.Italic;
            if (chkUnderline.Checked) style |= FontStyle.Underline;

            txtNhapTen.Font = new Font(txtNhapTen.Font, style);
            lblLapTrinh.Font = new Font(lblLapTrinh.Font, style);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

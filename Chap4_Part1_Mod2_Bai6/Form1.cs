namespace Mod2_Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtName.Focus(); // 1. Đặt con trỏ vào ô Name

            picBig.Visible = true; // 2. Hình lớn hiện
            picSmall.Visible = false; // Hình nhỏ ẩn

            ToolTip tooltip = new ToolTip(); // 3. Thêm tooltip
            tooltip.SetToolTip(picBig, "Click Me");
            tooltip.SetToolTip(picSmall, "Click Me");
          
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblMessage.Text = txtName.Text + " " + txtMessage.Text; // 4. Gán nội dung vào lblMessage
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear(); // 5. Xóa nội dung
            txtMessage.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // 8. Đóng chương trình
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đóng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // 9. Xác nhận trước khi đóng
            }
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = chkVisible.Checked; // 7. Ẩn hiện Message

        }
        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked) lblMessage.ForeColor = Color.Red; // 6. Đổi màu chữ
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked) lblMessage.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked) lblMessage.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked) lblMessage.ForeColor = Color.Black;
        }

        private void picBig_Click(object sender, EventArgs e)
        {
            picBig.Visible = false; // 10. Ẩn hình lớn, hiện hình nhỏ
            picSmall.Visible = true;
        }

        private void picSmall_Click(object sender, EventArgs e)
        {
            picSmall.Visible = false; // Làm ngược lại
            picBig.Visible = true;
        }

       
    }
}

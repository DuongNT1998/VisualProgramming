namespace Mod2_Bai15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nudSize_ValueChanged(object sender, EventArgs e)
        {
            UpdateLabelStyle();
        }

        private void dudColor_SelectedItemChanged(object sender, EventArgs e)
        {
            UpdateLabelStyle();
        }
        private void UpdateLabelStyle()
        {
            if (label3 == null) return;

            int fontSize = (int)nudSize.Value;
            string colorName = dudColor.Text;

            try
            {
                label3.ForeColor = Color.FromName(colorName);
            }
            catch
            {
                label3.ForeColor = Color.Black; // Mặc định nếu màu không hợp lệ
            }

            label3.Font = new Font(label3.Font.FontFamily, fontSize, FontStyle.Bold);
        }
    }
}

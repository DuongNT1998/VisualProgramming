namespace Mod3_Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoiLich_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAmLich.Text, out int duongLich))
            {
                string[] thienCan = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
                string[] diaChi = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi" };

                string namAmLich = thienCan[duongLich % 10] + " " + diaChi[duongLich % 12];

                txtDuongLich.Text = namAmLich;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập năm hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
    }
    }
}

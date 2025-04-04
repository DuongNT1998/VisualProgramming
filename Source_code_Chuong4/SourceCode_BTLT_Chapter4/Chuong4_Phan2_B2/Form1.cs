namespace Chuong4_Phan2_B2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Gán sự kiện CheckedChanged cho các RadioButton
            rbVietNamFlag.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rbChineseFlag.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rbUSAFlag.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            string imagePath = "";

            if (rbVietNamFlag.Checked)
            {
                imagePath = "D://Tài liệu giảng dạy UIT//Tài liệu UTC2//Lập trình trực quan//Bài tập (LT)//Buổi LT 4//Chuong4_Phan2_B2//vietnam.jpg"; // Đường dẫn trực tiếp
            }
            else if (rbChineseFlag.Checked)
            {
                imagePath = "D://Tài liệu giảng dạy UIT//Tài liệu UTC2//Lập trình trực quan//Bài tập (LT)//Buổi LT 4//Chuong4_Phan2_B2//chinese.png";
            }
            else if (rbUSAFlag.Checked)
            {
                imagePath = "D://Tài liệu giảng dạy UIT//Tài liệu UTC2//Lập trình trực quan//Bài tập (LT)//Buổi LT 4//Chuong4_Phan2_B2//usa.png";
            }

            // Kiểm tra nếu ảnh tồn tại trước khi load
            if (System.IO.File.Exists(imagePath))
            {
                pbFlag.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy ảnh: " + imagePath, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}

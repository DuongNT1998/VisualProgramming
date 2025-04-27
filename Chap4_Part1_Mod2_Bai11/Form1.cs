namespace Mod2_Bai11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng OpenFileDialog để chọn file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff|All Files|*.*";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Hiển thị thông tin file
                FileInfo fileInfo = new FileInfo(filePath);
                lbProperties.Text = $"File Name: {fileInfo.Name}\n" +
                                    $"File Size: {fileInfo.Length / 1024} KB\n" +
                                    $"Last Modified: {fileInfo.LastWriteTime}\n" +
                                    $"Last Accessed: {fileInfo.LastAccessTime}";

                // Hiển thị hình ảnh
                DisplayImage(filePath);
            }

        }
        private void DisplayImage(string filePath)
        {
            // Tạo PictureBox để hiển thị hình ảnh
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(filePath);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.Location = new Point(42, 220);  // Đặt vị trí PictureBox bên dưới groupBox1
            Controls.Add(pictureBox);

            // Đặt ScrollBars cho Form
            hScrollBar1.Maximum = pictureBox.Width - ClientSize.Width;
            vScrollBar1.Maximum = pictureBox.Height - ClientSize.Height;

            // Xử lý sự kiện cuộn cho HScrollBar và VScrollBar
            hScrollBar1.Scroll += (s, e) =>
            {
                pictureBox.Left = -hScrollBar1.Value;
            };
            vScrollBar1.Scroll += (s, e) =>
            {
                pictureBox.Top = -vScrollBar1.Value;
            };
        }
    }
}

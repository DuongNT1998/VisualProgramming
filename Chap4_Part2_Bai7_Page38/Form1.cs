namespace Chap4_Part2_Bai7_Page38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Add event handlers
            tbRed.Scroll += TbRGB_Scroll;
            tbGreen.Scroll += TbRGB_Scroll;
            tbBlue.Scroll += TbRGB_Scroll;


            //sử dụng sự kiện MouseDown của các TrackBar để đặt lại
            //màu nền về trắng 
            //khi người dùng bắt đầu tương tác với một TrackBar.
            tbRed.MouseDown += TbRGB_MouseDown;
            tbGreen.MouseDown += TbRGB_MouseDown;
            tbBlue.MouseDown += TbRGB_MouseDown;
        }

        private void TbRGB_Scroll(object sender, EventArgs e)
        {
            int red = tbRed.Value;
            int green = tbGreen.Value;
            int blue = tbBlue.Value;

            lbRed.Text = $"R = {red}";
            lbGreen.Text = $"G = {green}";
            lbBlue.Text = $"B = {blue}";

            panel1.BackColor = Color.FromArgb(red, green, blue);
        }
        private void TbRGB_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.White;
        }
    }
}

namespace Mod2_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Hiển thị thông báo khi form được hiển thị
            Load += (sender, e) => MessageBox.Show("Welcome to the application!", "Greeting");

            // Xử lý sự kiện khi người dùng nhấp vào form
            Click += (sender, e) => MessageBox.Show("Form was clicked", "Notification");

            // Xử lý sự kiện khi người dùng nhấp vào nút bấm
            btnClick.Click += (sender, e) => MessageBox.Show("Button was clicked", "Notification");
        }
    }
}

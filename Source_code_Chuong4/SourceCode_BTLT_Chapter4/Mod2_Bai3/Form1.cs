namespace Mod2_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Gán sự kiện cho các nút bấm để cập nhật nội dung Label "lbHoVaTen"
            btnHoLot.Click += (sender, e) =>
            {
                // Hiển thị chỉ phần họ lót trong Label "lbHoVaTen"
                lbHoVaTen.Text = txtHoLot.Text;
            };

            btnTen.Click += (sender, e) =>
            {
                // Hiển thị chỉ phần tên trong Label "lbHoVaTen"
                lbHoVaTen.Text = txtTen.Text;
            };

            btnHovaTen.Click += (sender, e) =>
            {
                // Hiển thị cả họ lót và tên đầy đủ trong Label "lbHoVaTen"
                lbHoVaTen.Text = txtHoLot.Text + " " + txtTen.Text;
            };

            // Xử lý sự kiện double-click vào Label để xoá nội dung
            lbHoVaTen.DoubleClick += (sender, e) =>
            {
                // Khi nhấn đúp vào Label, nó sẽ bị xoá nội dung
                lbHoVaTen.Text = "";
            };

            // Xử lý sự kiện thoát chương trình khi bấm vào nút "Thoát chương trình"
            btnThoat.Click += (sender, e) =>
            {
                // Đóng cửa sổ ứng dụng
                Close();
            };
        }
    }
}

namespace Chuong4_Phan2_B3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.FullRowSelect = true;
            listView1.View = View.Details;

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox và ComboBox
            string maSV = txtMaSV.Text;
            string hoTen = txtHoTen.Text;
            string diaChi = txtDiaChi.Text;
            string lop = cbLop.SelectedItem.ToString();
            string ngaySinh = dtNgaySinh.Value.ToString("dd/MM/yyyy");  // Định dạng ngày sinh

            // Kiểm tra xem các thông tin có bị bỏ trống không
            if (string.IsNullOrWhiteSpace(maSV) || string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(diaChi) || string.IsNullOrWhiteSpace(lop))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm một dòng mới vào ListView
            ListViewItem item = new ListViewItem(maSV);  // Mã sinh viên
            item.SubItems.Add(hoTen);                    // Họ tên
            item.SubItems.Add(diaChi);                   // Địa chỉ
            item.SubItems.Add(ngaySinh);                 // Ngày sinh
            item.SubItems.Add(lop);                      // Lớp

            // Thêm item vào ListView
            listView1.Items.Add(item);

            // Xóa các TextBox và ComboBox để chuẩn bị cho việc nhập thông tin mới
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            cbLop.SelectedIndex = -1;  // Deselect ComboBox
            dtNgaySinh.Value = DateTime.Now;  // Reset ngày sinh về ngày hiện tại
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = listView1.SelectedItems[0];
            selectedItem.SubItems[0].Text = txtMaSV.Text;
            selectedItem.SubItems[1].Text = txtHoTen.Text;
            selectedItem.SubItems[2].Text = txtDiaChi.Text;
            selectedItem.SubItems[3].Text = dtNgaySinh.Value.ToShortDateString();
            selectedItem.SubItems[4].Text = cbLop.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(item);
                }
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                txtMaSV.Text = e.Item.SubItems[0].Text;
                txtHoTen.Text = e.Item.SubItems[1].Text;
                txtDiaChi.Text = e.Item.SubItems[2].Text;
                dtNgaySinh.Value = DateTime.Parse(e.Item.SubItems[3].Text);
                cbLop.Text = e.Item.SubItems[4].Text;
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                ToolStripMenuItem viewItem = new ToolStripMenuItem("Xem chi tiết");
                viewItem.Click += (s, ev) => MessageBox.Show($"Mã SV: {txtMaSV.Text}\nHọ tên: {txtHoTen.Text}\nĐịa chỉ: {txtDiaChi.Text}\nNgày sinh: {dtNgaySinh.Value.ToShortDateString()}\nLớp: {cbLop.Text}", "Chi tiết sinh viên");
                menu.Items.Add(viewItem);
                menu.Show(Cursor.Position);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

namespace Mod2_Bai14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            AcceptButton = btnCapNhat;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string studentName = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(studentName))
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lstLopA.Items.Add(studentName);
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void btnMoveEachToRight_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(lstLopA, lstLopB);
        }

        private void btnMoveEachToLeft_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(lstLopB, lstLopA);
        }

        private void btnMoveAllToRight_Click(object sender, EventArgs e)
        {
            MoveAllItems(lstLopA, lstLopB);
        }

        private void btnMoveAllToLeft_Click(object sender, EventArgs e)
        {
            MoveAllItems(lstLopB, lstLopA);
        }

        private void btnXoaLopA_Click(object sender, EventArgs e)
        {
            RemoveSelectedItems(lstLopA);
        }

        private void btnXoaLopB_Click(object sender, EventArgs e)
        {
            RemoveSelectedItems(lstLopB);
        }
        private void MoveSelectedItems(ListBox from, ListBox to)
        {
            if (from.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn chuyển dữ liệu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    List<object> selectedItems = new List<object>();
                    foreach (var item in from.SelectedItems)
                    {
                        selectedItems.Add(item);
                    }

                    foreach (var item in selectedItems)
                    {
                        to.Items.Add(item);
                        from.Items.Remove(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có mục nào được chọn để chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MoveAllItems(ListBox from, ListBox to)
        {
            foreach (var item in from.Items)
            {
                to.Items.Add(item);
            }
            from.Items.Clear();
        }

        private void RemoveSelectedItems(ListBox listBox)
        {
            List<object> selectedItems = new List<object>();
            foreach (var item in listBox.SelectedItems)
            {
                selectedItems.Add(item);
            }

            foreach (var item in selectedItems)
            {
                listBox.Items.Remove(item);
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

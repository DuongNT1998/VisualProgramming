namespace Mod2_Bai13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AddNumberToList()
        {
            if (int.TryParse(txtNhapSo.Text, out int number))
            {
                lstDanhSach.Items.Add(number);
                txtNhapSo.Clear();
                txtNhapSo.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapSo.SelectAll();
            }
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            AddNumberToList();
        }

        private void txtNhapSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddNumberToList();
                e.SuppressKeyPress = true;
            }
        }

        private void btnTinhTongDanhSach_Click(object sender, EventArgs e)
        {
            int sum = lstDanhSach.Items.Cast<int>().Sum();
            MessageBox.Show($"Tổng danh sách: {sum}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaPhanTuDauVaCuoi_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.Items.Count >= 2)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa phần tử đầu và cuối không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    lstDanhSach.Items.RemoveAt(0);
                    lstDanhSach.Items.RemoveAt(lstDanhSach.Items.Count - 1);
                }
            }
            else
            {
                MessageBox.Show("Danh sách phải có ít nhất 2 phần tử để thực hiện xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaPhanTuDangChon_Click(object sender, EventArgs e)
        {
            while (lstDanhSach.SelectedItems.Count > 0)
            {
                lstDanhSach.Items.Remove(lstDanhSach.SelectedItem);
            }
        }

        private void btnXoaNhieuPhanTuDangChon_Click(object sender, EventArgs e)
        {
            foreach (var item in lstDanhSach.SelectedItems.Cast<object>().ToList())
            {
                lstDanhSach.Items.Remove(item);
            }
        }

        private void btnThayBangBinhPhuong_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < lstDanhSach.Items.Count; i++)
            {
                if (lstDanhSach.SelectedIndices.Contains(i))
                {
                    int value = (int)lstDanhSach.Items[i];
                    lstDanhSach.Items[i] = value * value;
                }
            }
        }

        private void btnTangPhanTuThemHaiDonVi_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDanhSach.Items.Count; i++)
            {
                if (lstDanhSach.SelectedIndices.Contains(i))
                {
                    int value = (int)lstDanhSach.Items[i];
                    lstDanhSach.Items[i] = value + 2;
                }
            }
        }

        private void btnChonSoLe_Click(object sender, EventArgs e)
        {
            lstDanhSach.ClearSelected();
            for (int i = 0; i < lstDanhSach.Items.Count; i++)
            {
                if ((int)lstDanhSach.Items[i] % 2 == 1)
                {
                    lstDanhSach.SetSelected(i, true);
                }
            }
        }

        private void btnChonSoChan_Click(object sender, EventArgs e)
        {
            lstDanhSach.ClearSelected();
            for (int i = 0; i < lstDanhSach.Items.Count; i++)
            {
                if ((int)lstDanhSach.Items[i] % 2 == 0)
                {
                    lstDanhSach.SetSelected(i, true);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

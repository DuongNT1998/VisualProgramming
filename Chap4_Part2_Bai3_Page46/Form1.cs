using System.Configuration.Internal;

namespace Chap4_Part2_Bai3_Page46
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            // Nếu là node sinh viên (cha của địa chỉ)
            if (selectedNode.Level == 2 && selectedNode.Nodes.Count > 0)
            {
                string[] parts = selectedNode.Text.Split(" - ");
                if (parts.Length >= 2)
                {
                    txtMaSV.Text = parts[0];
                    txtHoVaTen.Text = parts[1];

                    // Lấy địa chỉ từ node con
                    string diaChi = selectedNode.Nodes[0].Text.Replace("Địa chỉ: ", "");
                    txtDiaChi.Text = diaChi;
                }
            }
            else
            {
                ClearInput();
            }
        }
        private void ClearInput()
        {
            txtMaSV.Clear();
            txtHoVaTen.Clear();
            txtDiaChi.Clear();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoVaTen.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (maSV == "" || hoTen == "" || diaChi == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên.");
                return;
            }

            TreeNode selectedNode = treeView1.SelectedNode;

            if (selectedNode == null || selectedNode.Level != 1)
            {
                MessageBox.Show("Vui lòng chọn một lớp để thêm sinh viên.");
                return;
            }

            // Kiểm tra trùng mã SV
            foreach (TreeNode node in selectedNode.Nodes)
            {
                if (node.Text.StartsWith(maSV + " -"))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại trong lớp này.");
                    return;
                }
            }

            // Tạo node sinh viên
            TreeNode nodeSV = new TreeNode($"{maSV} - {hoTen}");

            // Tạo node địa chỉ là con của nodeSV
            TreeNode nodeDiaChi = new TreeNode($"Địa chỉ: {diaChi}");
            nodeSV.Nodes.Add(nodeDiaChi);

            // Thêm nodeSV vào lớp
            selectedNode.Nodes.Add(nodeSV);
            selectedNode.Expand();

            ClearInput();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;

            if (selectedNode == null || selectedNode.Level != 2 || selectedNode.Nodes.Count == 0)
            {
                MessageBox.Show("Chỉ được xóa nút sinh viên (không phải nút lớp hay nút địa chỉ).","Error");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sinh viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                selectedNode.Remove();
                ClearInput();
            }
        }
    }
}

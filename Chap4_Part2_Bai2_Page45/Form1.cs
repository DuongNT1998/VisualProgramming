namespace Chuong4_Phan2_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.FullRowSelect = true; // Cho phép chọn cả hàng
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();

            // Nếu chọn cấp Khoa, hiển thị toàn bộ sinh viên
            if (e.Node.Name == "rtKhoa")
            {
                foreach (TreeNode lopNode in e.Node.Nodes)
                {
                    foreach (TreeNode svNode in lopNode.Nodes)
                    {
                        AddStudentToListView(svNode.Text, lopNode.Text);
                    }
                }
            }
            // Nếu chọn cấp Lớp, hiển thị tất cả sinh viên của lớp đó
            else if (e.Node.Parent != null && e.Node.Parent.Name == "rtKhoa")
            {
                foreach (TreeNode svNode in e.Node.Nodes)
                {
                    AddStudentToListView(svNode.Text, e.Node.Text);
                }
            }
            // Nếu chọn cấp Sinh viên, chỉ hiển thị sinh viên đó
            else if (e.Node.Parent != null && e.Node.Parent.Parent != null)
            {
                AddStudentToListView(e.Node.Text, e.Node.Parent.Text);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string searchText = txtTenSV.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchText)) return;

            listView1.Items.Clear();
            TreeNode selectedNode = treeView1.SelectedNode;

            if (selectedNode != null)
            {
                if (selectedNode.Name == "rtKhoa") // Tìm trên toàn bộ khoa
                {
                    foreach (TreeNode lopNode in selectedNode.Nodes)
                    {
                        foreach (TreeNode svNode in lopNode.Nodes)
                        {
                            if (svNode.Text.ToLower().Contains(searchText))
                            {
                                AddStudentToListView(svNode.Text, lopNode.Text);
                            }
                        }
                    }
                }
                else if (selectedNode.Parent != null && selectedNode.Parent.Name == "rtKhoa") // Tìm trong lớp
                {
                    foreach (TreeNode svNode in selectedNode.Nodes)
                    {
                        if (svNode.Text.ToLower().Contains(searchText))
                        {
                            AddStudentToListView(svNode.Text, selectedNode.Text);
                        }
                    }
                }
                else if (selectedNode.Parent != null && selectedNode.Parent.Parent != null) // Kiểm tra nếu sinh viên trùng tên
                {
                    if (selectedNode.Text.ToLower().Contains(searchText))
                    {
                        AddStudentToListView(selectedNode.Text, selectedNode.Parent.Text);
                    }
                }
            }
        }

        private void AddStudentToListView(string tenSV, string lop)
        {
            ListViewItem item = new ListViewItem(tenSV); // Cột đầu tiên
            item.SubItems.Add(lop); // Cột thứ hai
            listView1.Items.Add(item);
        }
    }
}

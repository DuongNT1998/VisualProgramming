namespace Chuong4_Phan2_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeTreeView(); // Gọi phương thức khởi tạo TreeView
        }
        private void InitializeTreeView()
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                tvNme.Nodes.Add(c.ToString());
            }
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ và tên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fullName = $"{firstName} {lastName}";
            char firstChar = char.ToUpper(firstName[0]);

            // Tìm node tương ứng với chữ cái đầu tiên
            foreach (TreeNode node in tvNme.Nodes)
            {
                if (node.Text[0] == firstChar)
                {
                    node.Nodes.Add(fullName);
                    node.Expand(); // Mở rộng node chứa tên
                    return;
                }
            }
        }
    }
}

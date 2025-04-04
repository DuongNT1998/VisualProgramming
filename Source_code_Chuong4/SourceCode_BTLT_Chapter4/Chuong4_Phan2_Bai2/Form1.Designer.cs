namespace Chuong4_Phan2_Bai2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("Nguyễn Văn Tuấn");
            TreeNode treeNode2 = new TreeNode("Nguyễn Thị Lan");
            TreeNode treeNode3 = new TreeNode("Nguyen Van Luong");
            TreeNode treeNode4 = new TreeNode("THTH5A", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("Le Nghiep");
            TreeNode treeNode6 = new TreeNode("Tran Long");
            TreeNode treeNode7 = new TreeNode("Ly Hai");
            TreeNode treeNode8 = new TreeNode("THTH5B", new TreeNode[] { treeNode5, treeNode6, treeNode7 });
            TreeNode treeNode9 = new TreeNode("Le Trung");
            TreeNode treeNode10 = new TreeNode("Ton Mai");
            TreeNode treeNode11 = new TreeNode("Tran Minh");
            TreeNode treeNode12 = new TreeNode("THTH5C", new TreeNode[] { treeNode9, treeNode10, treeNode11 });
            TreeNode treeNode13 = new TreeNode("Tin học", new TreeNode[] { treeNode4, treeNode8, treeNode12 });
            treeView1 = new TreeView();
            listView1 = new ListView();
            clTenSV = new ColumnHeader();
            clLop = new ColumnHeader();
            label1 = new Label();
            txtTenSV = new TextBox();
            btnTim = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 60);
            treeView1.Name = "treeView1";
            treeNode1.Name = "childSV1";
            treeNode1.Text = "Nguyễn Văn Tuấn";
            treeNode2.Name = "childSV2";
            treeNode2.Text = "Nguyễn Thị Lan";
            treeNode3.Name = "childSV3";
            treeNode3.Text = "Nguyen Van Luong";
            treeNode4.Name = "chilTHTH5A";
            treeNode4.Text = "THTH5A";
            treeNode5.Name = "chilSV4";
            treeNode5.Text = "Le Nghiep";
            treeNode6.Name = "childSV5";
            treeNode6.Text = "Tran Long";
            treeNode7.Name = "chilSV6";
            treeNode7.Text = "Ly Hai";
            treeNode8.Name = "childTHTH5B";
            treeNode8.Text = "THTH5B";
            treeNode9.Name = "chilSV7";
            treeNode9.Text = "Le Trung";
            treeNode10.Name = "chilSV8";
            treeNode10.Text = "Ton Mai";
            treeNode11.Name = "chilSV9";
            treeNode11.Text = "Tran Minh";
            treeNode12.Name = "chilTHTH5C";
            treeNode12.Text = "THTH5C";
            treeNode13.Name = "rtKhoa";
            treeNode13.Text = "Tin học";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode13 });
            treeView1.Size = new Size(342, 360);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { clTenSV, clLop });
            listView1.Location = new Point(375, 63);
            listView1.Name = "listView1";
            listView1.Size = new Size(322, 357);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // clTenSV
            // 
            clTenSV.Text = "Tên SV";
            // 
            // clLop
            // 
            clLop.Text = "Lớp";
            clLop.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 18);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 2;
            label1.Text = "Nhập tên";
            // 
            // txtTenSV
            // 
            txtTenSV.Location = new Point(401, 15);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(202, 27);
            txtTenSV.TabIndex = 3;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(609, 15);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 4;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(709, 432);
            Controls.Add(btnTim);
            Controls.Add(txtTenSV);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private ListView listView1;
        private Label label1;
        private TextBox txtTenSV;
        private Button btnTim;
        private ColumnHeader clTenSV;
        private ColumnHeader clLop;
    }
}

namespace Chap4_Part2_Bai3_Page46
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
            TreeNode treeNode1 = new TreeNode("NTCH3KA");
            TreeNode treeNode2 = new TreeNode("NTCH3KB");
            TreeNode treeNode3 = new TreeNode("CDTH11K");
            TreeNode treeNode4 = new TreeNode("CDTH11K", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            treeView1 = new TreeView();
            groupBox1 = new GroupBox();
            btnXoa = new Button();
            btnCapNhat = new Button();
            txtDiaChi = new TextBox();
            label3 = new Label();
            txtHoVaTen = new TextBox();
            label2 = new Label();
            txtMaSV = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Left;
            treeView1.HideSelection = false;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeNode1.Name = "nodeLopNTCH3KA";
            treeNode1.Text = "NTCH3KA";
            treeNode2.Name = "nodeLopNTCH3KB";
            treeNode2.Text = "NTCH3KB";
            treeNode3.Name = "nodeLopCDTH11K";
            treeNode3.Text = "CDTH11K";
            treeNode4.Name = "nodeDanhSacLop";
            treeNode4.Text = "CDTH11K";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode4 });
            treeView1.Size = new Size(370, 452);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnCapNhat);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaSV);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(405, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 231);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(227, 186);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(69, 186);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(101, 138);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(263, 27);
            txtDiaChi.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 145);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 4;
            label3.Text = "Địa chỉ";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(101, 86);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(263, 27);
            txtHoVaTen.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 89);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Họ và tên";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(101, 30);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(263, 27);
            txtMaSV.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 37);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã SV";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 452);
            Controls.Add(groupBox1);
            Controls.Add(treeView1);
            MaximumSize = new Size(820, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private GroupBox groupBox1;
        private Button btnXoa;
        private Button btnCapNhat;
        private TextBox txtDiaChi;
        private Label label3;
        private TextBox txtHoVaTen;
        private Label label2;
        private TextBox txtMaSV;
        private Label label1;
    }
}

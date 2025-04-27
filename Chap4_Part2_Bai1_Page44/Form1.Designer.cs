namespace Chuong4_Phan2_Bai1
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
            tvNme = new TreeView();
            hScrollBar1 = new HScrollBar();
            vScrollBar1 = new VScrollBar();
            panel1 = new Panel();
            label1 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label2 = new Label();
            btnAddName = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tvNme
            // 
            tvNme.Location = new Point(12, 10);
            tvNme.Name = "tvNme";
            tvNme.Size = new Size(279, 428);
            tvNme.TabIndex = 0;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(16, 411);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(275, 26);
            hScrollBar1.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(265, 10);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 401);
            vScrollBar1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddName);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(297, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 216);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(16, 17);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(16, 49);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(198, 27);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(16, 139);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(198, 27);
            txtLastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(16, 107);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "Last name";
            // 
            // btnAddName
            // 
            btnAddName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddName.Location = new Point(226, 180);
            btnAddName.Name = "btnAddName";
            btnAddName.Size = new Size(94, 29);
            btnAddName.TabIndex = 4;
            btnAddName.Text = "Add name";
            btnAddName.UseVisualStyleBackColor = true;
            btnAddName.Click += btnAddName_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 450);
            Controls.Add(panel1);
            Controls.Add(vScrollBar1);
            Controls.Add(hScrollBar1);
            Controls.Add(tvNme);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TreeView tvNme;
        private HScrollBar hScrollBar1;
        private VScrollBar vScrollBar1;
        private Panel panel1;
        private Button btnAddName;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtFirstName;
        private Label label1;
    }
}

namespace Mod2_Bai1
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
            lbNhapPass = new Label();
            lbHienThi = new Label();
            tbNhapPassword = new TextBox();
            tbHienThi = new TextBox();
            btnHienThi = new Button();
            btnTiep = new Button();
            btnDong = new Button();
            SuspendLayout();
            // 
            // lbNhapPass
            // 
            lbNhapPass.AutoSize = true;
            lbNhapPass.Location = new Point(22, 20);
            lbNhapPass.Name = "lbNhapPass";
            lbNhapPass.Size = new Size(112, 20);
            lbNhapPass.TabIndex = 0;
            lbNhapPass.Text = "Nhập password";
            // 
            // lbHienThi
            // 
            lbHienThi.AutoSize = true;
            lbHienThi.Location = new Point(73, 73);
            lbHienThi.Name = "lbHienThi";
            lbHienThi.Size = new Size(61, 20);
            lbHienThi.TabIndex = 1;
            lbHienThi.Text = "Hiển thị";
            // 
            // tbNhapPassword
            // 
            tbNhapPassword.Location = new Point(167, 22);
            tbNhapPassword.Name = "tbNhapPassword";
            tbNhapPassword.PasswordChar = '*';
            tbNhapPassword.Size = new Size(189, 27);
            tbNhapPassword.TabIndex = 2;
            // 
            // tbHienThi
            // 
            tbHienThi.Enabled = false;
            tbHienThi.Location = new Point(167, 75);
            tbHienThi.Name = "tbHienThi";
            tbHienThi.ReadOnly = true;
            tbHienThi.Size = new Size(189, 27);
            tbHienThi.TabIndex = 3;
            // 
            // btnHienThi
            // 
            btnHienThi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHienThi.Location = new Point(35, 121);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(94, 29);
            btnHienThi.TabIndex = 4;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // btnTiep
            // 
            btnTiep.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTiep.Location = new Point(167, 121);
            btnTiep.Name = "btnTiep";
            btnTiep.Size = new Size(94, 29);
            btnTiep.TabIndex = 5;
            btnTiep.Text = "Tiếp";
            btnTiep.UseVisualStyleBackColor = true;
            btnTiep.Click += btnTiep_Click;
            // 
            // btnDong
            // 
            btnDong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDong.Location = new Point(307, 121);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 29);
            btnDong.TabIndex = 6;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 170);
            Controls.Add(btnDong);
            Controls.Add(btnTiep);
            Controls.Add(btnHienThi);
            Controls.Add(tbHienThi);
            Controls.Add(tbNhapPassword);
            Controls.Add(lbHienThi);
            Controls.Add(lbNhapPass);
            Name = "Form1";
            Text = "Sử dụng Label và Textbox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNhapPass;
        private Label lbHienThi;
        private TextBox tbNhapPassword;
        private TextBox tbHienThi;
        private Button btnHienThi;
        private Button btnTiep;
        private Button btnDong;
    }
}

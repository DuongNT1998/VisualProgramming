namespace Mod3_Bai5
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSoLuong = new TextBox();
            txtDonGia = new TextBox();
            txtThanhTien = new TextBox();
            btnBanMoi = new Button();
            btnTinh = new Button();
            btnThoat = new Button();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtTongSL = new TextBox();
            txtTongTien = new TextBox();
            txtTrungBinh = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 11);
            label1.Name = "label1";
            label1.Size = new Size(424, 41);
            label1.TabIndex = 0;
            label1.Text = "CHƯƠNG TRÌNH BÁN HÀNG";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 58);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnTinh);
            groupBox1.Controls.Add(btnBanMoi);
            groupBox1.Controls.Add(txtThanhTien);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.OrangeRed;
            groupBox1.Location = new Point(-1, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(588, 163);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(48, 32);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 0;
            label2.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(48, 80);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 1;
            label3.Text = "Đơn giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(48, 135);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 2;
            label4.Text = "Thành tiền";
            // 
            // txtSoLuong
            // 
            txtSoLuong.ForeColor = SystemColors.ActiveCaptionText;
            txtSoLuong.Location = new Point(140, 32);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(282, 27);
            txtSoLuong.TabIndex = 3;
            // 
            // txtDonGia
            // 
            txtDonGia.ForeColor = SystemColors.ActiveCaptionText;
            txtDonGia.Location = new Point(140, 80);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(282, 27);
            txtDonGia.TabIndex = 4;
            // 
            // txtThanhTien
            // 
            txtThanhTien.BackColor = Color.FromArgb(255, 255, 192);
            txtThanhTien.ForeColor = SystemColors.ActiveCaptionText;
            txtThanhTien.Location = new Point(140, 128);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(282, 27);
            txtThanhTien.TabIndex = 5;
            // 
            // btnBanMoi
            // 
            btnBanMoi.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btnBanMoi.ForeColor = SystemColors.ActiveCaptionText;
            btnBanMoi.Location = new Point(474, 26);
            btnBanMoi.Name = "btnBanMoi";
            btnBanMoi.Size = new Size(114, 35);
            btnBanMoi.TabIndex = 6;
            btnBanMoi.Text = "Bàn mới";
            btnBanMoi.UseVisualStyleBackColor = true;
            btnBanMoi.Click += btnBanMoi_Click;
            // 
            // btnTinh
            // 
            btnTinh.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btnTinh.ForeColor = SystemColors.ActiveCaptionText;
            btnTinh.Location = new Point(474, 67);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(114, 42);
            btnTinh.TabIndex = 7;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += BtnTinh_Click;

            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btnThoat.ForeColor = SystemColors.ActiveCaptionText;
            btnThoat.Location = new Point(474, 115);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(114, 42);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTrungBinh);
            groupBox2.Controls.Add(txtTongTien);
            groupBox2.Controls.Add(txtTongSL);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.ForeColor = Color.Red;
            groupBox2.Location = new Point(-1, 231);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(588, 207);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin thống kê";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(61, 44);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 0;
            label5.Text = "Tổng SL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(61, 109);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 1;
            label6.Text = "Tổng tiền";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(61, 171);
            label7.Name = "label7";
            label7.Size = new Size(155, 20);
            label7.TabIndex = 2;
            label7.Text = "Trung bình / Lần bán";
            // 
            // txtTongSL
            // 
            txtTongSL.BackColor = Color.FromArgb(255, 255, 192);
            txtTongSL.ForeColor = SystemColors.ActiveCaptionText;
            txtTongSL.Location = new Point(247, 41);
            txtTongSL.Name = "txtTongSL";
            txtTongSL.ReadOnly = true;
            txtTongSL.Size = new Size(282, 27);
            txtTongSL.TabIndex = 9;
            // 
            // txtTongTien
            // 
            txtTongTien.BackColor = Color.FromArgb(255, 255, 192);
            txtTongTien.ForeColor = SystemColors.ActiveCaptionText;
            txtTongTien.Location = new Point(247, 102);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(282, 27);
            txtTongTien.TabIndex = 10;
            // 
            // txtTrungBinh
            // 
            txtTrungBinh.BackColor = Color.FromArgb(255, 255, 192);
            txtTrungBinh.ForeColor = SystemColors.ActiveCaptionText;
            txtTrungBinh.Location = new Point(247, 164);
            txtTrungBinh.Name = "txtTrungBinh";
            txtTrungBinh.ReadOnly = true;
            txtTrungBinh.Size = new Size(282, 27);
            txtTrungBinh.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(599, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox txtSoLuong;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnThoat;
        private Button btnTinh;
        private Button btnBanMoi;
        private TextBox txtThanhTien;
        private TextBox txtDonGia;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtTrungBinh;
        private TextBox txtTongTien;
        private TextBox txtTongSL;
        private ContextMenuStrip contextMenuStrip1;
    }
}

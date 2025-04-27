namespace Mod3_Bai6
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
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtThanhTien = new TextBox();
            label5 = new Label();
            cbKHSV = new CheckBox();
            label4 = new Label();
            txtSoLuongSach = new TextBox();
            label3 = new Label();
            txtTenKH = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnTinhThanhTien = new Button();
            btnTiep = new Button();
            btnThongKe = new Button();
            btnKetThuc = new Button();
            groupBox2 = new GroupBox();
            txtTongDoanhThu = new TextBox();
            label9 = new Label();
            txtTongSoKHSV = new TextBox();
            label8 = new Label();
            txtTongSoKH = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 68);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(109, 10);
            label1.Name = "label1";
            label1.Size = new Size(436, 38);
            label1.TabIndex = 0;
            label1.Text = "Chương trình tính tiền bán sách";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtThanhTien);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbKHSV);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSoLuongSach);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTenKH);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(587, 231);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa đơn";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(200, 186);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(266, 27);
            txtThanhTien.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 186);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 6;
            label5.Text = "Thành tiền";
            // 
            // cbKHSV
            // 
            cbKHSV.AutoSize = true;
            cbKHSV.Location = new Point(202, 137);
            cbKHSV.Name = "cbKHSV";
            cbKHSV.Size = new Size(18, 17);
            cbKHSV.TabIndex = 5;
            cbKHSV.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 138);
            label4.Name = "label4";
            label4.Size = new Size(163, 20);
            label4.TabIndex = 4;
            label4.Text = "Khách hàng là sinh viên";
            // 
            // txtSoLuongSach
            // 
            txtSoLuongSach.Location = new Point(200, 89);
            txtSoLuongSach.Name = "txtSoLuongSach";
            txtSoLuongSach.Size = new Size(266, 27);
            txtSoLuongSach.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 89);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 2;
            label3.Text = "Số lượng sách";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(200, 38);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(266, 27);
            txtTenKH.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 27);
            textBox1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 38);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 0;
            label6.Text = "Tên khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 38);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên khách hàng";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnTinhThanhTien);
            flowLayoutPanel1.Controls.Add(btnTiep);
            flowLayoutPanel1.Controls.Add(btnThongKe);
            flowLayoutPanel1.Controls.Add(btnKetThuc);
            flowLayoutPanel1.Location = new Point(12, 310);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(587, 51);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // btnTinhThanhTien
            // 
            btnTinhThanhTien.Location = new Point(3, 3);
            btnTinhThanhTien.Name = "btnTinhThanhTien";
            btnTinhThanhTien.Size = new Size(94, 29);
            btnTinhThanhTien.TabIndex = 3;
            btnTinhThanhTien.Text = "Tính TT";
            btnTinhThanhTien.UseVisualStyleBackColor = true;
            btnTinhThanhTien.Click += btnTinhThanhTien_Click;
            // 
            // btnTiep
            // 
            btnTiep.Location = new Point(103, 3);
            btnTiep.Name = "btnTiep";
            btnTiep.Size = new Size(94, 29);
            btnTiep.TabIndex = 1;
            btnTiep.Text = "Tiếp";
            btnTiep.UseVisualStyleBackColor = true;
            btnTiep.Click += btnTiep_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(203, 3);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(94, 29);
            btnThongKe.TabIndex = 2;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(303, 3);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(94, 29);
            btnKetThuc.TabIndex = 0;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTongDoanhThu);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtTongSoKHSV);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtTongSoKH);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(12, 376);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(587, 162);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thống kê";
            // 
            // txtTongDoanhThu
            // 
            txtTongDoanhThu.Location = new Point(203, 129);
            txtTongDoanhThu.Name = "txtTongDoanhThu";
            txtTongDoanhThu.ReadOnly = true;
            txtTongDoanhThu.Size = new Size(266, 27);
            txtTongDoanhThu.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 129);
            label9.Name = "label9";
            label9.Size = new Size(114, 20);
            label9.TabIndex = 12;
            label9.Text = "Tổng doanh thu";
            // 
            // txtTongSoKHSV
            // 
            txtTongSoKHSV.Location = new Point(203, 79);
            txtTongSoKHSV.Name = "txtTongSoKHSV";
            txtTongSoKHSV.ReadOnly = true;
            txtTongSoKHSV.Size = new Size(266, 27);
            txtTongSoKHSV.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 79);
            label8.Name = "label8";
            label8.Size = new Size(123, 20);
            label8.TabIndex = 10;
            label8.Text = "Tổng số KH là SV";
            // 
            // txtTongSoKH
            // 
            txtTongSoKH.Location = new Point(203, 26);
            txtTongSoKH.Name = "txtTongSoKH";
            txtTongSoKH.ReadOnly = true;
            txtTongSoKH.Size = new Size(266, 27);
            txtTongSoKH.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 26);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 8;
            label7.Text = "Tổng số KH";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 550);
            Controls.Add(groupBox2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtThanhTien;
        private Label label5;
        private CheckBox cbKHSV;
        private Label label4;
        private TextBox txtSoLuongSach;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private TextBox txtTenKH;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnTinhThanhTien;
        private Button btnTiep;
        private Button btnThongKe;
        private Button btnKetThuc;
        private GroupBox groupBox2;
        private TextBox txtTongDoanhThu;
        private Label label9;
        private TextBox txtTongSoKHSV;
        private Label label8;
        private TextBox txtTongSoKH;
        private Label label7;
    }
}

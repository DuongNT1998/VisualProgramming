namespace Chap4_Part2_Bai6_Page37
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
            label2 = new Label();
            txtMSSV = new TextBox();
            label3 = new Label();
            txtHoVaTen = new TextBox();
            label4 = new Label();
            cbNienKhoa = new ComboBox();
            cbLop = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            rdHKI = new RadioButton();
            rdHKIII = new RadioButton();
            rdHKII = new RadioButton();
            rdHKIV = new RadioButton();
            label7 = new Label();
            clbMonHoc = new CheckedListBox();
            btnDangKy = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(636, 51);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.LightSalmon;
            label1.Location = new Point(166, 6);
            label1.Name = "label1";
            label1.Size = new Size(308, 41);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÝ MÔN HỌC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 61);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "MSSV: ";
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(202, 61);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(205, 27);
            txtMSSV.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 111);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 3;
            label3.Text = "Họ và tên: ";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(202, 111);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(380, 27);
            txtHoVaTen.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 161);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 5;
            label4.Text = "Niên khóa:";
            // 
            // cbNienKhoa
            // 
            cbNienKhoa.FormattingEnabled = true;
            cbNienKhoa.Items.AddRange(new object[] { "2021-2025", "2022-2026", "2023-2027", "2024-2028", "2025-2029" });
            cbNienKhoa.Location = new Point(202, 158);
            cbNienKhoa.Name = "cbNienKhoa";
            cbNienKhoa.Size = new Size(259, 28);
            cbNienKhoa.TabIndex = 6;
            // 
            // cbLop
            // 
            cbLop.FormattingEnabled = true;
            cbLop.Items.AddRange(new object[] { "CNTTK61", "CNTTK62", "CNTTK63", "CNTTK64", "CNTTK65", "CNTTK66" });
            cbLop.Location = new Point(202, 209);
            cbLop.Name = "cbLop";
            cbLop.Size = new Size(259, 28);
            cbLop.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 212);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 7;
            label5.Text = "Lớp: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(110, 260);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 9;
            label6.Text = "Học kỳ:";
            // 
            // rdHKI
            // 
            rdHKI.AutoSize = true;
            rdHKI.Location = new Point(202, 260);
            rdHKI.Name = "rdHKI";
            rdHKI.Size = new Size(34, 24);
            rdHKI.TabIndex = 10;
            rdHKI.TabStop = true;
            rdHKI.Text = "I";
            rdHKI.UseVisualStyleBackColor = true;
            // 
            // rdHKIII
            // 
            rdHKIII.AutoSize = true;
            rdHKIII.Location = new Point(340, 260);
            rdHKIII.Name = "rdHKIII";
            rdHKIII.Size = new Size(42, 24);
            rdHKIII.TabIndex = 11;
            rdHKIII.TabStop = true;
            rdHKIII.Text = "III";
            rdHKIII.UseVisualStyleBackColor = true;
            // 
            // rdHKII
            // 
            rdHKII.AutoSize = true;
            rdHKII.Location = new Point(266, 260);
            rdHKII.Name = "rdHKII";
            rdHKII.Size = new Size(38, 24);
            rdHKII.TabIndex = 12;
            rdHKII.TabStop = true;
            rdHKII.Text = "II";
            rdHKII.UseVisualStyleBackColor = true;
            // 
            // rdHKIV
            // 
            rdHKIV.AutoSize = true;
            rdHKIV.Location = new Point(418, 260);
            rdHKIV.Name = "rdHKIV";
            rdHKIV.Size = new Size(43, 24);
            rdHKIV.TabIndex = 13;
            rdHKIV.TabStop = true;
            rdHKIV.Text = "IV";
            rdHKIV.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(109, 312);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 14;
            label7.Text = "Môn học:";
            // 
            // clbMonHoc
            // 
            clbMonHoc.FormattingEnabled = true;
            clbMonHoc.Items.AddRange(new object[] { "LT Windows", "LT Internet", "Mạng máy tính", "UML" });
            clbMonHoc.Location = new Point(202, 312);
            clbMonHoc.Name = "clbMonHoc";
            clbMonHoc.Size = new Size(259, 114);
            clbMonHoc.TabIndex = 15;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(152, 446);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(94, 29);
            btnDangKy.TabIndex = 16;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(299, 446);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 17;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(454, 446);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 501);
            Controls.Add(btnThoat);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(clbMonHoc);
            Controls.Add(label7);
            Controls.Add(rdHKIV);
            Controls.Add(rdHKII);
            Controls.Add(rdHKIII);
            Controls.Add(rdHKI);
            Controls.Add(label6);
            Controls.Add(cbLop);
            Controls.Add(label5);
            Controls.Add(cbNienKhoa);
            Controls.Add(label4);
            Controls.Add(txtHoVaTen);
            Controls.Add(label3);
            Controls.Add(txtMSSV);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtMSSV;
        private Label label3;
        private TextBox txtHoVaTen;
        private Label label4;
        private ComboBox cbNienKhoa;
        private ComboBox cbLop;
        private Label label5;
        private Label label6;
        private RadioButton rdHKI;
        private RadioButton rdHKIII;
        private RadioButton rdHKII;
        private RadioButton rdHKIV;
        private Label label7;
        private CheckedListBox clbMonHoc;
        private Button btnDangKy;
        private Button btnHuy;
        private Button btnThoat;
    }
}

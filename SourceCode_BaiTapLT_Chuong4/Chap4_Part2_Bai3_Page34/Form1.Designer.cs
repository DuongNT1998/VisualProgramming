namespace Chap4_Part2_Bai3_Page34
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
            groupBox1 = new GroupBox();
            cbSoVuaNhap = new ComboBox();
            btnCapNhat = new Button();
            txtNhapSo = new TextBox();
            groupBox2 = new GroupBox();
            lbCacUocSo = new ListBox();
            btnTongCacUocSo = new Button();
            btnSoLuongCacUocSoChan = new Button();
            btnSoLuongCacUocSNT = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbSoVuaNhap);
            groupBox1.Controls.Add(btnCapNhat);
            groupBox1.Controls.Add(txtNhapSo);
            groupBox1.Location = new Point(37, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 175);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập số";
            // 
            // cbSoVuaNhap
            // 
            cbSoVuaNhap.FormattingEnabled = true;
            cbSoVuaNhap.Location = new Point(17, 96);
            cbSoVuaNhap.Name = "cbSoVuaNhap";
            cbSoVuaNhap.Size = new Size(270, 28);
            cbSoVuaNhap.TabIndex = 2;
            cbSoVuaNhap.SelectedIndexChanged += cbSoVuaNhap_SelectedIndexChanged;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(175, 31);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(112, 38);
            btnCapNhat.TabIndex = 1;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // txtNhapSo
            // 
            txtNhapSo.Location = new Point(17, 37);
            txtNhapSo.Name = "txtNhapSo";
            txtNhapSo.Size = new Size(152, 27);
            txtNhapSo.TabIndex = 0;
            txtNhapSo.KeyDown += txtNhapSo_KeyDown;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbCacUocSo);
            groupBox2.Location = new Point(381, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(293, 175);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách các ước số";
            // 
            // lbCacUocSo
            // 
            lbCacUocSo.FormattingEnabled = true;
            lbCacUocSo.Location = new Point(6, 26);
            lbCacUocSo.Name = "lbCacUocSo";
            lbCacUocSo.Size = new Size(281, 144);
            lbCacUocSo.TabIndex = 0;
            // 
            // btnTongCacUocSo
            // 
            btnTongCacUocSo.Location = new Point(381, 224);
            btnTongCacUocSo.Name = "btnTongCacUocSo";
            btnTongCacUocSo.Size = new Size(293, 38);
            btnTongCacUocSo.TabIndex = 3;
            btnTongCacUocSo.Text = "Tổng các ước số";
            btnTongCacUocSo.UseVisualStyleBackColor = true;
            btnTongCacUocSo.Click += btnTongCacUocSo_Click;
            // 
            // btnSoLuongCacUocSoChan
            // 
            btnSoLuongCacUocSoChan.Location = new Point(381, 284);
            btnSoLuongCacUocSoChan.Name = "btnSoLuongCacUocSoChan";
            btnSoLuongCacUocSoChan.Size = new Size(293, 38);
            btnSoLuongCacUocSoChan.TabIndex = 4;
            btnSoLuongCacUocSoChan.Text = "Số lượng các ước số chẵn";
            btnSoLuongCacUocSoChan.UseVisualStyleBackColor = true;
            btnSoLuongCacUocSoChan.Click += btnSoLuongCacUocSoChan_Click;
            // 
            // btnSoLuongCacUocSNT
            // 
            btnSoLuongCacUocSNT.Location = new Point(381, 342);
            btnSoLuongCacUocSNT.Name = "btnSoLuongCacUocSNT";
            btnSoLuongCacUocSNT.Size = new Size(293, 38);
            btnSoLuongCacUocSNT.TabIndex = 5;
            btnSoLuongCacUocSNT.Text = "Số lượng các ước số nguyên tố";
            btnSoLuongCacUocSNT.UseVisualStyleBackColor = true;
            btnSoLuongCacUocSNT.Click += btnSoLuongCacUocSNT_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(212, 342);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 38);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 392);
            Controls.Add(btnThoat);
            Controls.Add(btnSoLuongCacUocSNT);
            Controls.Add(btnSoLuongCacUocSoChan);
            Controls.Add(btnTongCacUocSo);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbSoVuaNhap;
        private Button btnCapNhat;
        private TextBox txtNhapSo;
        private GroupBox groupBox2;
        private ListBox lbCacUocSo;
        private Button btnTongCacUocSo;
        private Button btnSoLuongCacUocSoChan;
        private Button btnSoLuongCacUocSNT;
        private Button btnThoat;
    }
}

namespace Mod2_Bai13
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
            label1 = new Label();
            txtNhapSo = new TextBox();
            btnCapNhat = new Button();
            groupBox1 = new GroupBox();
            lstDanhSach = new ListBox();
            groupBox2 = new GroupBox();
            btnChonSoChan = new Button();
            btnChonSoLe = new Button();
            btnTangPhanTuThemHaiDonVi = new Button();
            btnThayBangBinhPhuong = new Button();
            btnXoaNhieuPhanTuDangChon = new Button();
            btnXoaPhanTuDangChon = new Button();
            btnXoaPhanTuDauVaCuoi = new Button();
            btnTinhTongDanhSach = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 27);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập số";
            // 
            // txtNhapSo
            // 
            txtNhapSo.Location = new Point(110, 24);
            txtNhapSo.Name = "txtNhapSo";
            txtNhapSo.Size = new Size(367, 27);
            txtNhapSo.TabIndex = 1;
            txtNhapSo.KeyDown += txtNhapSo_KeyDown;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(520, 13);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(116, 48);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstDanhSach);
            groupBox1.Location = new Point(26, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 544);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lớp A";
            // 
            // lstDanhSach
            // 
            lstDanhSach.FormattingEnabled = true;
            lstDanhSach.Location = new Point(-1, 26);
            lstDanhSach.Name = "lstDanhSach";
            lstDanhSach.Size = new Size(355, 504);
            lstDanhSach.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnChonSoChan);
            groupBox2.Controls.Add(btnChonSoLe);
            groupBox2.Controls.Add(btnTangPhanTuThemHaiDonVi);
            groupBox2.Controls.Add(btnThayBangBinhPhuong);
            groupBox2.Controls.Add(btnXoaNhieuPhanTuDangChon);
            groupBox2.Controls.Add(btnXoaPhanTuDangChon);
            groupBox2.Controls.Add(btnXoaPhanTuDauVaCuoi);
            groupBox2.Controls.Add(btnTinhTongDanhSach);
            groupBox2.Location = new Point(423, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(325, 532);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Các chức năng";
            // 
            // btnChonSoChan
            // 
            btnChonSoChan.Location = new Point(24, 473);
            btnChonSoChan.Name = "btnChonSoChan";
            btnChonSoChan.Size = new Size(283, 43);
            btnChonSoChan.TabIndex = 7;
            btnChonSoChan.Text = "Chọn số chẵn";
            btnChonSoChan.UseVisualStyleBackColor = true;
            btnChonSoChan.Click += btnChonSoChan_Click;
            // 
            // btnChonSoLe
            // 
            btnChonSoLe.Location = new Point(24, 413);
            btnChonSoLe.Name = "btnChonSoLe";
            btnChonSoLe.Size = new Size(283, 43);
            btnChonSoLe.TabIndex = 6;
            btnChonSoLe.Text = "Chọn số lẻ";
            btnChonSoLe.UseVisualStyleBackColor = true;
            btnChonSoLe.Click += btnChonSoLe_Click;
            // 
            // btnTangPhanTuThemHaiDonVi
            // 
            btnTangPhanTuThemHaiDonVi.Location = new Point(24, 346);
            btnTangPhanTuThemHaiDonVi.Name = "btnTangPhanTuThemHaiDonVi";
            btnTangPhanTuThemHaiDonVi.Size = new Size(283, 43);
            btnTangPhanTuThemHaiDonVi.TabIndex = 5;
            btnTangPhanTuThemHaiDonVi.Text = "Tăng mỗi phàn tử lên 2";
            btnTangPhanTuThemHaiDonVi.UseVisualStyleBackColor = true;
            btnTangPhanTuThemHaiDonVi.Click += btnTangPhanTuThemHaiDonVi_Click;
            // 
            // btnThayBangBinhPhuong
            // 
            btnThayBangBinhPhuong.Location = new Point(24, 283);
            btnThayBangBinhPhuong.Name = "btnThayBangBinhPhuong";
            btnThayBangBinhPhuong.Size = new Size(283, 43);
            btnThayBangBinhPhuong.TabIndex = 4;
            btnThayBangBinhPhuong.Text = "Thay bằng bình phương";
            btnThayBangBinhPhuong.UseVisualStyleBackColor = true;
            btnThayBangBinhPhuong.Click += btnThayBangBinhPhuong_Click;
            // 
            // btnXoaNhieuPhanTuDangChon
            // 
            btnXoaNhieuPhanTuDangChon.Location = new Point(24, 224);
            btnXoaNhieuPhanTuDangChon.Name = "btnXoaNhieuPhanTuDangChon";
            btnXoaNhieuPhanTuDangChon.Size = new Size(283, 43);
            btnXoaNhieuPhanTuDangChon.TabIndex = 3;
            btnXoaNhieuPhanTuDangChon.Text = "Xóa nhiều phần tử đang chọn";
            btnXoaNhieuPhanTuDangChon.UseVisualStyleBackColor = true;
            btnXoaNhieuPhanTuDangChon.Click += btnXoaNhieuPhanTuDangChon_Click;
            // 
            // btnXoaPhanTuDangChon
            // 
            btnXoaPhanTuDangChon.Location = new Point(24, 157);
            btnXoaPhanTuDangChon.Name = "btnXoaPhanTuDangChon";
            btnXoaPhanTuDangChon.Size = new Size(283, 43);
            btnXoaPhanTuDangChon.TabIndex = 2;
            btnXoaPhanTuDangChon.Text = "Xóa phần tử đang chọn";
            btnXoaPhanTuDangChon.UseVisualStyleBackColor = true;
            btnXoaPhanTuDangChon.Click += btnXoaPhanTuDangChon_Click;
            // 
            // btnXoaPhanTuDauVaCuoi
            // 
            btnXoaPhanTuDauVaCuoi.Location = new Point(24, 90);
            btnXoaPhanTuDauVaCuoi.Name = "btnXoaPhanTuDauVaCuoi";
            btnXoaPhanTuDauVaCuoi.Size = new Size(283, 43);
            btnXoaPhanTuDauVaCuoi.TabIndex = 1;
            btnXoaPhanTuDauVaCuoi.Text = "Xóa phần tử đầu và cuối";
            btnXoaPhanTuDauVaCuoi.UseVisualStyleBackColor = true;
            btnXoaPhanTuDauVaCuoi.Click += btnXoaPhanTuDauVaCuoi_Click;
            // 
            // btnTinhTongDanhSach
            // 
            btnTinhTongDanhSach.Location = new Point(24, 26);
            btnTinhTongDanhSach.Name = "btnTinhTongDanhSach";
            btnTinhTongDanhSach.Size = new Size(283, 43);
            btnTinhTongDanhSach.TabIndex = 0;
            btnTinhTongDanhSach.Text = "Tổng của danh sách";
            btnTinhTongDanhSach.UseVisualStyleBackColor = true;
            btnTinhTongDanhSach.Click += btnTinhTongDanhSach_Click;
            // 
            // button2
            // 
            button2.Location = new Point(26, 621);
            button2.Name = "button2";
            button2.Size = new Size(722, 45);
            button2.TabIndex = 5;
            button2.Text = "Kết thúc";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 678);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCapNhat);
            Controls.Add(txtNhapSo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNhapSo;
        private Button btnCapNhat;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnChonSoLe;
        private Button btnTangPhanTuThemHaiDonVi;
        private Button btnThayBangBinhPhuong;
        private Button btnXoaNhieuPhanTuDangChon;
        private Button btnXoaPhanTuDangChon;
        private Button btnXoaPhanTuDauVaCuoi;
        private Button btnTinhTongDanhSach;
        private Button button2;
        private Button btnChonSoChan;
        private ListBox lstDanhSach;
    }
}

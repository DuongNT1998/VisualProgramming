using System.Windows.Forms;

namespace Chap9_Baitapp6_7
{
    partial class SachForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtNgayNhapSach = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTriGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNhaXuatBan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbNamXuatBan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lstSach = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(231, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "QUẢN LÝ DANH MỤC SÁCH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTrangThai);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtNgayNhapSach);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTriGia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNhaXuatBan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbNamXuatBan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTacGia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 221);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(462, 173);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(189, 24);
            this.cbTrangThai.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(366, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "TRạng thái";
            // 
            // dtNgayNhapSach
            // 
            this.dtNgayNhapSach.Location = new System.Drawing.Point(86, 175);
            this.dtNgayNhapSach.Name = "dtNgayNhapSach";
            this.dtNgayNhapSach.Size = new System.Drawing.Size(218, 22);
            this.dtNgayNhapSach.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ngày nhập";
            // 
            // txtTriGia
            // 
            this.txtTriGia.Location = new System.Drawing.Point(462, 128);
            this.txtTriGia.Name = "txtTriGia";
            this.txtTriGia.Size = new System.Drawing.Size(188, 22);
            this.txtTriGia.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Trị giá";
            // 
            // txtNhaXuatBan
            // 
            this.txtNhaXuatBan.Location = new System.Drawing.Point(462, 79);
            this.txtNhaXuatBan.Name = "txtNhaXuatBan";
            this.txtNhaXuatBan.Size = new System.Drawing.Size(188, 22);
            this.txtNhaXuatBan.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nhà xuất bản";
            // 
            // cbNamXuatBan
            // 
            this.cbNamXuatBan.FormattingEnabled = true;
            this.cbNamXuatBan.Location = new System.Drawing.Point(462, 33);
            this.cbNamXuatBan.Name = "cbNamXuatBan";
            this.cbNamXuatBan.Size = new System.Drawing.Size(189, 24);
            this.cbNamXuatBan.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Năm xuất bản";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(86, 128);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(218, 22);
            this.txtTacGia.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tác giả";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(86, 82);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(218, 22);
            this.txtTenSach.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sách";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(86, 42);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(218, 22);
            this.txtMaSach.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIn);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(263, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 35);
            this.panel1.TabIndex = 8;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(432, 4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 9;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(324, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(211, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(113, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lstSach
            // 
            this.lstSach.HideSelection = false;
            this.lstSach.Location = new System.Drawing.Point(12, 325);
            this.lstSach.Name = "lstSach";
            this.lstSach.Size = new System.Drawing.Size(776, 113);
            this.lstSach.TabIndex = 9;
            this.lstSach.UseCompatibleStateImageBehavior = false;
            this.lstSach.View = System.Windows.Forms.View.Details;
            this.lstSach.SelectedIndexChanged += new System.EventHandler(this.lstSach_SelectedIndexChanged);
            lstSach.Columns.Add("Mã Sách", 80);
            lstSach.Columns.Add("Tên Sách", 150);
            lstSach.Columns.Add("Tác Giả", 120);
            lstSach.Columns.Add("Ngày Nhập", 100);
            lstSach.Columns.Add("Năm XB", 70);
            lstSach.Columns.Add("Nhà XB", 120);
            lstSach.Columns.Add("Trị Giá", 80);
            lstSach.Columns.Add("Trạng Thái", 130);
            lstSach.FullRowSelect = true;
            lstSach.MultiSelect = false; // Nếu bạn chỉ muốn chọn 1 dòng tại 1 thời điểm

            // 
            // SachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstSach);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "SachForm";
            this.Text = "SachForm";
            this.Load += new System.EventHandler(this.SachForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtNgayNhapSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTriGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNhaXuatBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbNamXuatBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListView lstSach;
    }
}
using System.Windows.Forms;

namespace Chap9_Baitapp6_7
{
    partial class PhieuMuonForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXemPhieu = new System.Windows.Forms.Button();
            this.cbTenSach = new System.Windows.Forms.ComboBox();
            this.cbTenDG = new System.Windows.Forms.ComboBox();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtNgayTraThucTe = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtNgayPhaiTraDuKien = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaPhieuMuon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstPhieuMuon = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(204, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ PHIẾU MƯỢN SÁCH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXemPhieu);
            this.groupBox1.Controls.Add(this.cbTenSach);
            this.groupBox1.Controls.Add(this.cbTenDG);
            this.groupBox1.Controls.Add(this.btnInPhieu);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.dtNgayTraThucTe);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtNgayPhaiTraDuKien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaPhieuMuon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaDG);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1083, 193);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lập phiếu";
            // 
            // btnXemPhieu
            // 
            this.btnXemPhieu.Location = new System.Drawing.Point(215, 89);
            this.btnXemPhieu.Name = "btnXemPhieu";
            this.btnXemPhieu.Size = new System.Drawing.Size(84, 40);
            this.btnXemPhieu.TabIndex = 31;
            this.btnXemPhieu.Text = "Xem Phiếu";
            this.btnXemPhieu.UseVisualStyleBackColor = true;
            this.btnXemPhieu.Click += new System.EventHandler(this.btnXemPhieu_Click);
            // 
            // cbTenSach
            // 
            this.cbTenSach.Enabled = false;
            this.cbTenSach.FormattingEnabled = true;
            this.cbTenSach.Location = new System.Drawing.Point(87, 153);
            this.cbTenSach.Name = "cbTenSach";
            this.cbTenSach.Size = new System.Drawing.Size(232, 24);
            this.cbTenSach.TabIndex = 30;
            // 
            // cbTenDG
            // 
            this.cbTenDG.FormattingEnabled = true;
            this.cbTenDG.Location = new System.Drawing.Point(436, 32);
            this.cbTenDG.Name = "cbTenDG";
            this.cbTenDG.Size = new System.Drawing.Size(232, 24);
            this.cbTenDG.TabIndex = 29;
            this.cbTenDG.SelectedIndexChanged += new System.EventHandler(this.cbTenDG_SelectedIndexChanged);
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.Location = new System.Drawing.Point(858, 89);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(84, 40);
            this.btnInPhieu.TabIndex = 28;
            this.btnInPhieu.Text = "In phiếu";
            this.btnInPhieu.UseVisualStyleBackColor = true;
            this.btnInPhieu.Click += new System.EventHandler(this.btnInPhieu_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(695, 89);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(84, 40);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(558, 89);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(84, 40);
            this.btnCapNhat.TabIndex = 26;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(392, 89);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 40);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtNgayTraThucTe
            // 
            this.dtNgayTraThucTe.Location = new System.Drawing.Point(832, 153);
            this.dtNgayTraThucTe.Name = "dtNgayTraThucTe";
            this.dtNgayTraThucTe.Size = new System.Drawing.Size(233, 22);
            this.dtNgayTraThucTe.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(727, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ngày trả thực tế";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtNgayPhaiTraDuKien
            // 
            this.dtNgayPhaiTraDuKien.Location = new System.Drawing.Point(477, 153);
            this.dtNgayPhaiTraDuKien.Name = "dtNgayPhaiTraDuKien";
            this.dtNgayPhaiTraDuKien.Size = new System.Drawing.Size(233, 22);
            this.dtNgayPhaiTraDuKien.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ngày phải trả dự kiến";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tên sách";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMaPhieuMuon
            // 
            this.txtMaPhieuMuon.Location = new System.Drawing.Point(858, 26);
            this.txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            this.txtMaPhieuMuon.Size = new System.Drawing.Size(161, 22);
            this.txtMaPhieuMuon.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(739, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Số phiếu mượn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Họ tên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(122, 29);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.ReadOnly = true;
            this.txtMaDG.Size = new System.Drawing.Size(161, 22);
            this.txtMaDG.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã độc giả";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstPhieuMuon
            // 
            this.lstPhieuMuon.HideSelection = false;
            this.lstPhieuMuon.Location = new System.Drawing.Point(12, 267);
            this.lstPhieuMuon.Name = "lstPhieuMuon";
            this.lstPhieuMuon.Size = new System.Drawing.Size(1083, 171);
            this.lstPhieuMuon.TabIndex = 14;
            this.lstPhieuMuon.UseCompatibleStateImageBehavior = false;
            this.lstPhieuMuon.View = System.Windows.Forms.View.Details;
            this.lstPhieuMuon.SelectedIndexChanged += new System.EventHandler(this.lstPhieuMuon_SelectedIndexChanged);
            lstPhieuMuon.Columns.Add("Số phiếu", 100);
            lstPhieuMuon.Columns.Add("Tên sách", 180);
            lstPhieuMuon.Columns.Add("Ngày phải trả dự kiến", 180);
            lstPhieuMuon.Columns.Add("Ngày trả thực tế", 180);
            lstPhieuMuon.Columns.Add("Trạng thái", 100);
            // 
            // PhieuMuonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 450);
            this.Controls.Add(this.lstPhieuMuon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "PhieuMuonForm";
            this.Text = "QUẢN LÝ PHIẾU MƯỢN SÁCH ";
            this.Load += new System.EventHandler(this.PhieuMuonForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInPhieu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtNgayTraThucTe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtNgayPhaiTraDuKien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaPhieuMuon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTenSach;
        private System.Windows.Forms.ComboBox cbTenDG;
        private System.Windows.Forms.ListView lstPhieuMuon;
        private System.Windows.Forms.Button btnXemPhieu;
    }
}
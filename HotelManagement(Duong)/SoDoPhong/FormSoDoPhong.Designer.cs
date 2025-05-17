namespace HotelManagement.SoDoPhong
{
    partial class FormSoDoPhong
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdbTatCaPhong = new System.Windows.Forms.RadioButton();
            this.rdbPhongChuaDon = new System.Windows.Forms.RadioButton();
            this.rdbPhongDaDonDep = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdbTatCaLoaiPhong = new System.Windows.Forms.RadioButton();
            this.rdbPhongVipDoi = new System.Windows.Forms.RadioButton();
            this.rdbPhongVipDon = new System.Windows.Forms.RadioButton();
            this.rdbPhongThuongDoi = new System.Windows.Forms.RadioButton();
            this.rdbPhongThuongDon = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbTatCaTrangThaiPhong = new System.Windows.Forms.RadioButton();
            this.rdbPhongDangSuaChua = new System.Windows.Forms.RadioButton();
            this.rdbPhongDangThue = new System.Windows.Forms.RadioButton();
            this.rdbPhongDaDat = new System.Windows.Forms.RadioButton();
            this.rdbPhongTrong = new System.Windows.Forms.RadioButton();
            this.LabelTrangThaiPhong = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearchMaPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtNgayChon = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.dataGridViewPhong = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GreenYellow;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 686);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdbTatCaPhong);
            this.panel4.Controls.Add(this.rdbPhongChuaDon);
            this.panel4.Controls.Add(this.rdbPhongDaDonDep);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(12, 476);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(246, 150);
            this.panel4.TabIndex = 8;
            // 
            // rdbTatCaPhong
            // 
            this.rdbTatCaPhong.AutoSize = true;
            this.rdbTatCaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTatCaPhong.Location = new System.Drawing.Point(9, 119);
            this.rdbTatCaPhong.Name = "rdbTatCaPhong";
            this.rdbTatCaPhong.Size = new System.Drawing.Size(88, 29);
            this.rdbTatCaPhong.TabIndex = 4;
            this.rdbTatCaPhong.TabStop = true;
            this.rdbTatCaPhong.Text = "Tất cả";
            this.rdbTatCaPhong.UseVisualStyleBackColor = true;
            this.rdbTatCaPhong.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdbPhongChuaDon
            // 
            this.rdbPhongChuaDon.AutoSize = true;
            this.rdbPhongChuaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPhongChuaDon.Location = new System.Drawing.Point(9, 84);
            this.rdbPhongChuaDon.Name = "rdbPhongChuaDon";
            this.rdbPhongChuaDon.Size = new System.Drawing.Size(157, 29);
            this.rdbPhongChuaDon.TabIndex = 3;
            this.rdbPhongChuaDon.TabStop = true;
            this.rdbPhongChuaDon.Text = "Chưa dọn dẹp";
            this.rdbPhongChuaDon.UseVisualStyleBackColor = true;
            this.rdbPhongChuaDon.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdbPhongDaDonDep
            // 
            this.rdbPhongDaDonDep.AutoSize = true;
            this.rdbPhongDaDonDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPhongDaDonDep.Location = new System.Drawing.Point(9, 49);
            this.rdbPhongDaDonDep.Name = "rdbPhongDaDonDep";
            this.rdbPhongDaDonDep.Size = new System.Drawing.Size(134, 29);
            this.rdbPhongDaDonDep.TabIndex = 2;
            this.rdbPhongDaDonDep.TabStop = true;
            this.rdbPhongDaDonDep.Text = "Đã dọn dẹp";
            this.rdbPhongDaDonDep.UseVisualStyleBackColor = true;
            this.rdbPhongDaDonDep.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tình trạng dọn dẹp";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdbTatCaLoaiPhong);
            this.panel3.Controls.Add(this.rdbPhongVipDoi);
            this.panel3.Controls.Add(this.rdbPhongVipDon);
            this.panel3.Controls.Add(this.rdbPhongThuongDoi);
            this.panel3.Controls.Add(this.rdbPhongThuongDon);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(6, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 223);
            this.panel3.TabIndex = 7;
            // 
            // rdbTatCaLoaiPhong
            // 
            this.rdbTatCaLoaiPhong.AutoSize = true;
            this.rdbTatCaLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTatCaLoaiPhong.Location = new System.Drawing.Point(9, 189);
            this.rdbTatCaLoaiPhong.Name = "rdbTatCaLoaiPhong";
            this.rdbTatCaLoaiPhong.Size = new System.Drawing.Size(148, 29);
            this.rdbTatCaLoaiPhong.TabIndex = 7;
            this.rdbTatCaLoaiPhong.TabStop = true;
            this.rdbTatCaLoaiPhong.Text = "Tất cả phòng";
            this.rdbTatCaLoaiPhong.UseVisualStyleBackColor = true;
            this.rdbTatCaLoaiPhong.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdbPhongVipDoi
            // 
            this.rdbPhongVipDoi.AutoSize = true;
            this.rdbPhongVipDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPhongVipDoi.Location = new System.Drawing.Point(9, 154);
            this.rdbPhongVipDoi.Name = "rdbPhongVipDoi";
            this.rdbPhongVipDoi.Size = new System.Drawing.Size(158, 29);
            this.rdbPhongVipDoi.TabIndex = 5;
            this.rdbPhongVipDoi.TabStop = true;
            this.rdbPhongVipDoi.Text = "Phòng VIP đôi";
            this.rdbPhongVipDoi.UseVisualStyleBackColor = true;
            this.rdbPhongVipDoi.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdbPhongVipDon
            // 
            this.rdbPhongVipDon.AutoSize = true;
            this.rdbPhongVipDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPhongVipDon.Location = new System.Drawing.Point(9, 119);
            this.rdbPhongVipDon.Name = "rdbPhongVipDon";
            this.rdbPhongVipDon.Size = new System.Drawing.Size(165, 29);
            this.rdbPhongVipDon.TabIndex = 4;
            this.rdbPhongVipDon.TabStop = true;
            this.rdbPhongVipDon.Text = "Phòng VIP đơn";
            this.rdbPhongVipDon.UseVisualStyleBackColor = true;
            this.rdbPhongVipDon.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdbPhongThuongDoi
            // 
            this.rdbPhongThuongDoi.AutoSize = true;
            this.rdbPhongThuongDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPhongThuongDoi.Location = new System.Drawing.Point(9, 84);
            this.rdbPhongThuongDoi.Name = "rdbPhongThuongDoi";
            this.rdbPhongThuongDoi.Size = new System.Drawing.Size(186, 29);
            this.rdbPhongThuongDoi.TabIndex = 3;
            this.rdbPhongThuongDoi.TabStop = true;
            this.rdbPhongThuongDoi.Text = "Phòng thường đôi";
            this.rdbPhongThuongDoi.UseVisualStyleBackColor = true;
            this.rdbPhongThuongDoi.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdbPhongThuongDon
            // 
            this.rdbPhongThuongDon.AutoSize = true;
            this.rdbPhongThuongDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPhongThuongDon.Location = new System.Drawing.Point(9, 49);
            this.rdbPhongThuongDon.Name = "rdbPhongThuongDon";
            this.rdbPhongThuongDon.Size = new System.Drawing.Size(193, 29);
            this.rdbPhongThuongDon.TabIndex = 2;
            this.rdbPhongThuongDon.TabStop = true;
            this.rdbPhongThuongDon.Text = "Phòng thường đơn";
            this.rdbPhongThuongDon.UseVisualStyleBackColor = true;
            this.rdbPhongThuongDon.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại phòng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbTatCaTrangThaiPhong);
            this.panel2.Controls.Add(this.rdbPhongDangSuaChua);
            this.panel2.Controls.Add(this.rdbPhongDangThue);
            this.panel2.Controls.Add(this.rdbPhongDaDat);
            this.panel2.Controls.Add(this.rdbPhongTrong);
            this.panel2.Controls.Add(this.LabelTrangThaiPhong);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 223);
            this.panel2.TabIndex = 1;
            // 
            // rdbTatCaTrangThaiPhong
            // 
            this.rdbTatCaTrangThaiPhong.AutoSize = true;
            this.rdbTatCaTrangThaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTatCaTrangThaiPhong.Location = new System.Drawing.Point(9, 189);
            this.rdbTatCaTrangThaiPhong.Name = "rdbTatCaTrangThaiPhong";
            this.rdbTatCaTrangThaiPhong.Size = new System.Drawing.Size(148, 29);
            this.rdbTatCaTrangThaiPhong.TabIndex = 6;
            this.rdbTatCaTrangThaiPhong.TabStop = true;
            this.rdbTatCaTrangThaiPhong.Text = "Tất cả phòng";
            this.rdbTatCaTrangThaiPhong.UseVisualStyleBackColor = true;
            this.rdbTatCaTrangThaiPhong.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdbPhongDangSuaChua
            // 
            this.rdbPhongDangSuaChua.AutoSize = true;
            this.rdbPhongDangSuaChua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPhongDangSuaChua.Location = new System.Drawing.Point(9, 154);
            this.rdbPhongDangSuaChua.Name = "rdbPhongDangSuaChua";
            this.rdbPhongDangSuaChua.Size = new System.Drawing.Size(224, 29);
            this.rdbPhongDangSuaChua.TabIndex = 5;
            this.rdbPhongDangSuaChua.TabStop = true;
            this.rdbPhongDangSuaChua.Text = "Phòng đang sửa chữa";
            this.rdbPhongDangSuaChua.UseVisualStyleBackColor = true;
            this.rdbPhongDangSuaChua.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdbPhongDangThue
            // 
            this.rdbPhongDangThue.AutoSize = true;
            this.rdbPhongDangThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPhongDangThue.Location = new System.Drawing.Point(9, 119);
            this.rdbPhongDangThue.Name = "rdbPhongDangThue";
            this.rdbPhongDangThue.Size = new System.Drawing.Size(182, 29);
            this.rdbPhongDangThue.TabIndex = 4;
            this.rdbPhongDangThue.TabStop = true;
            this.rdbPhongDangThue.Text = "Phòng đang thuê";
            this.rdbPhongDangThue.UseVisualStyleBackColor = true;
            this.rdbPhongDangThue.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdbPhongDaDat
            // 
            this.rdbPhongDaDat.AutoSize = true;
            this.rdbPhongDaDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPhongDaDat.Location = new System.Drawing.Point(9, 84);
            this.rdbPhongDaDat.Name = "rdbPhongDaDat";
            this.rdbPhongDaDat.Size = new System.Drawing.Size(149, 29);
            this.rdbPhongDaDat.TabIndex = 3;
            this.rdbPhongDaDat.TabStop = true;
            this.rdbPhongDaDat.Text = "Phòng đã đặt";
            this.rdbPhongDaDat.UseVisualStyleBackColor = true;
            this.rdbPhongDaDat.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdbPhongTrong
            // 
            this.rdbPhongTrong.AutoSize = true;
            this.rdbPhongTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPhongTrong.Location = new System.Drawing.Point(9, 49);
            this.rdbPhongTrong.Name = "rdbPhongTrong";
            this.rdbPhongTrong.Size = new System.Drawing.Size(139, 29);
            this.rdbPhongTrong.TabIndex = 2;
            this.rdbPhongTrong.TabStop = true;
            this.rdbPhongTrong.Text = "Phòng trống";
            this.rdbPhongTrong.UseVisualStyleBackColor = true;
            this.rdbPhongTrong.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // LabelTrangThaiPhong
            // 
            this.LabelTrangThaiPhong.AutoSize = true;
            this.LabelTrangThaiPhong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTrangThaiPhong.Location = new System.Drawing.Point(24, 10);
            this.LabelTrangThaiPhong.Name = "LabelTrangThaiPhong";
            this.LabelTrangThaiPhong.Size = new System.Drawing.Size(210, 32);
            this.LabelTrangThaiPhong.TabIndex = 1;
            this.LabelTrangThaiPhong.Text = "Trạng thái phòng";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.txtSearchMaPhong);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.dateTimePicker2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.dtNgayChon);
            this.panel5.Location = new System.Drawing.Point(274, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(724, 53);
            this.panel5.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(522, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 32);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearchMaPhong
            // 
            this.txtSearchMaPhong.Location = new System.Drawing.Point(563, 20);
            this.txtSearchMaPhong.Name = "txtSearchMaPhong";
            this.txtSearchMaPhong.Size = new System.Drawing.Size(149, 22);
            this.txtSearchMaPhong.TabIndex = 4;
            this.txtSearchMaPhong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chọn giờ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(269, 28);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chọn ngày";
            // 
            // dtNgayChon
            // 
            this.dtNgayChon.Location = new System.Drawing.Point(31, 28);
            this.dtNgayChon.Name = "dtNgayChon";
            this.dtNgayChon.Size = new System.Drawing.Size(200, 22);
            this.dtNgayChon.TabIndex = 0;
            this.dtNgayChon.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Nhập số phòng";
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.ForeColor = System.Drawing.Color.Blue;
            this.btnDatPhong.Location = new System.Drawing.Point(1031, 8);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(166, 43);
            this.btnDatPhong.TabIndex = 3;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // dataGridViewPhong
            // 
            this.dataGridViewPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhong.Location = new System.Drawing.Point(274, 59);
            this.dataGridViewPhong.Name = "dataGridViewPhong";
            this.dataGridViewPhong.RowHeadersWidth = 51;
            this.dataGridViewPhong.RowTemplate.Height = 24;
            this.dataGridViewPhong.Size = new System.Drawing.Size(990, 610);
            this.dataGridViewPhong.TabIndex = 4;
            // 
            // FormSoDoPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1276, 681);
            this.Controls.Add(this.dataGridViewPhong);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "FormSoDoPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sơ đồ phòng";
            this.Load += new System.EventHandler(this.FormSoDoPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelTrangThaiPhong;
        private System.Windows.Forms.RadioButton rdbPhongDangSuaChua;
        private System.Windows.Forms.RadioButton rdbPhongDangThue;
        private System.Windows.Forms.RadioButton rdbPhongDaDat;
        private System.Windows.Forms.RadioButton rdbPhongTrong;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdbTatCaPhong;
        private System.Windows.Forms.RadioButton rdbPhongChuaDon;
        private System.Windows.Forms.RadioButton rdbPhongDaDonDep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdbPhongVipDoi;
        private System.Windows.Forms.RadioButton rdbPhongVipDon;
        private System.Windows.Forms.RadioButton rdbPhongThuongDoi;
        private System.Windows.Forms.RadioButton rdbPhongThuongDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbTatCaTrangThaiPhong;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearchMaPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtNgayChon;
        private System.Windows.Forms.RadioButton rdbTatCaLoaiPhong;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.DataGridView dataGridViewPhong;
    }
}
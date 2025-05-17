namespace HotelManagement.PhieuThue
{
    partial class FormChiTietPhieuThue
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
            this.lbSoPhieu = new System.Windows.Forms.Label();
            this.lbHoTenKH = new System.Windows.Forms.Label();
            this.lbThoiGianLP = new System.Windows.Forms.Label();
            this.lbHoTenNV = new System.Windows.Forms.Label();
            this.dtgDanhSachCTPT = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachCTPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSoPhieu
            // 
            this.lbSoPhieu.AutoSize = true;
            this.lbSoPhieu.BackColor = System.Drawing.Color.Transparent;
            this.lbSoPhieu.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoPhieu.Location = new System.Drawing.Point(351, 23);
            this.lbSoPhieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoPhieu.Name = "lbSoPhieu";
            this.lbSoPhieu.Size = new System.Drawing.Size(484, 46);
            this.lbSoPhieu.TabIndex = 6;
            this.lbSoPhieu.Text = "Chi tiết phiếu thuê {số phiếu}";
            // 
            // lbHoTenKH
            // 
            this.lbHoTenKH.AutoSize = true;
            this.lbHoTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTenKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbHoTenKH.Location = new System.Drawing.Point(83, 113);
            this.lbHoTenKH.Name = "lbHoTenKH";
            this.lbHoTenKH.Size = new System.Drawing.Size(194, 26);
            this.lbHoTenKH.TabIndex = 8;
            this.lbHoTenKH.Text = "Họ tên khách hàng";
            // 
            // lbThoiGianLP
            // 
            this.lbThoiGianLP.AutoSize = true;
            this.lbThoiGianLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGianLP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbThoiGianLP.Location = new System.Drawing.Point(515, 113);
            this.lbThoiGianLP.Name = "lbThoiGianLP";
            this.lbThoiGianLP.Size = new System.Drawing.Size(194, 26);
            this.lbThoiGianLP.TabIndex = 10;
            this.lbThoiGianLP.Text = "Thời gian lập phiếu";
            // 
            // lbHoTenNV
            // 
            this.lbHoTenNV.AutoSize = true;
            this.lbHoTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbHoTenNV.Location = new System.Drawing.Point(905, 113);
            this.lbHoTenNV.Name = "lbHoTenNV";
            this.lbHoTenNV.Size = new System.Drawing.Size(176, 26);
            this.lbHoTenNV.TabIndex = 12;
            this.lbHoTenNV.Text = "Họ tên nhân viên";
            // 
            // dtgDanhSachCTPT
            // 
            this.dtgDanhSachCTPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhSachCTPT.Location = new System.Drawing.Point(12, 177);
            this.dtgDanhSachCTPT.Name = "dtgDanhSachCTPT";
            this.dtgDanhSachCTPT.RowHeadersWidth = 51;
            this.dtgDanhSachCTPT.RowTemplate.Height = 24;
            this.dtgDanhSachCTPT.Size = new System.Drawing.Size(1150, 443);
            this.dtgDanhSachCTPT.TabIndex = 13;
            this.dtgDanhSachCTPT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachCTPT_CellClick);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(499, 646);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 47);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "OK";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HotelManagement.Properties.Resources.NhanVien1;
            this.pictureBox3.Location = new System.Drawing.Point(834, 99);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HotelManagement.Properties.Resources.CalendarPick;
            this.pictureBox2.Location = new System.Drawing.Point(444, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = HotelManagement.Properties.Resources.Name;
            this.pictureBox1.Location = new System.Drawing.Point(12, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormChiTietPhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 705);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dtgDanhSachCTPT);
            this.Controls.Add(this.lbHoTenNV);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbThoiGianLP);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbHoTenKH);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbSoPhieu);
            this.Name = "FormChiTietPhieuThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết phiếu thuê";
            this.Load += new System.EventHandler(this.FormChiTietPhieuThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachCTPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSoPhieu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbHoTenKH;
        private System.Windows.Forms.Label lbThoiGianLP;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbHoTenNV;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dtgDanhSachCTPT;
        private System.Windows.Forms.Button btnThoat;
    }
}
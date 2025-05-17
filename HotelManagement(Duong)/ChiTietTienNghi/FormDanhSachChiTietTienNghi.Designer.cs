namespace HotelManagement.ChiTietTienNghi
{
    partial class FormDanhSachChiTietTienNghi
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
            this.dtgDanhSachTienNghiTheoLoaiPhong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenLoaiPhong = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachTienNghiTheoLoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDanhSachTienNghiTheoLoaiPhong
            // 
            this.dtgDanhSachTienNghiTheoLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhSachTienNghiTheoLoaiPhong.Location = new System.Drawing.Point(12, 113);
            this.dtgDanhSachTienNghiTheoLoaiPhong.Name = "dtgDanhSachTienNghiTheoLoaiPhong";
            this.dtgDanhSachTienNghiTheoLoaiPhong.RowHeadersWidth = 51;
            this.dtgDanhSachTienNghiTheoLoaiPhong.RowTemplate.Height = 24;
            this.dtgDanhSachTienNghiTheoLoaiPhong.Size = new System.Drawing.Size(776, 399);
            this.dtgDanhSachTienNghiTheoLoaiPhong.TabIndex = 0;
            this.dtgDanhSachTienNghiTheoLoaiPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachTienNghiTheoLoaiPhong_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(157, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH TIỆN NGHI HIỆN CÓ";
            // 
            // lblTenLoaiPhong
            // 
            this.lblTenLoaiPhong.AutoSize = true;
            this.lblTenLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLoaiPhong.ForeColor = System.Drawing.Color.Blue;
            this.lblTenLoaiPhong.Location = new System.Drawing.Point(306, 72);
            this.lblTenLoaiPhong.Name = "lblTenLoaiPhong";
            this.lblTenLoaiPhong.Size = new System.Drawing.Size(194, 29);
            this.lblTenLoaiPhong.TabIndex = 2;
            this.lblTenLoaiPhong.Text = "Tên loai phòng";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(437, 530);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 47);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Moccasin;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(229, 530);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(137, 47);
            this.btnCapNhat.TabIndex = 16;
            this.btnCapNhat.Text = "Thêm mới";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // FormDanhSachChiTietTienNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.lblTenLoaiPhong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgDanhSachTienNghiTheoLoaiPhong);
            this.Name = "FormDanhSachChiTietTienNghi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý các tiện nghi theo loại phòng";
            this.Load += new System.EventHandler(this.FormDanhSachChiTietTienNghi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachTienNghiTheoLoaiPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDanhSachTienNghiTheoLoaiPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenLoaiPhong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
    }
}
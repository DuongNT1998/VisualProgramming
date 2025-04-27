namespace Chap9_Baitap2
{
    partial class XemDiemForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXemDiem = new System.Windows.Forms.Button();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.cnHoTenSV = new System.Windows.Forms.ComboBox();
            this.cbMasoSV = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgXemDiem = new System.Windows.Forms.DataGridView();
            this.dtgXemDiemClTenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgXemDiemClDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgXemDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXemDiem);
            this.panel1.Controls.Add(this.txtTenKhoa);
            this.panel1.Controls.Add(this.cnHoTenSV);
            this.panel1.Controls.Add(this.cbMasoSV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 125);
            this.panel1.TabIndex = 0;
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.Location = new System.Drawing.Point(372, 85);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(75, 23);
            this.btnXemDiem.TabIndex = 6;
            this.btnXemDiem.Text = "Xem điểm";
            this.btnXemDiem.UseVisualStyleBackColor = true;
            this.btnXemDiem.Click += new System.EventHandler(this.btnXemDiem_Click);
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(124, 93);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.ReadOnly = true;
            this.txtTenKhoa.Size = new System.Drawing.Size(200, 22);
            this.txtTenKhoa.TabIndex = 5;
            // 
            // cnHoTenSV
            // 
            this.cnHoTenSV.FormattingEnabled = true;
            this.cnHoTenSV.Location = new System.Drawing.Point(124, 50);
            this.cnHoTenSV.Name = "cnHoTenSV";
            this.cnHoTenSV.Size = new System.Drawing.Size(200, 24);
            this.cnHoTenSV.TabIndex = 4;
            this.cnHoTenSV.SelectedIndexChanged += new System.EventHandler(this.cnHoTenSV_SelectedIndexChanged);
            // 
            // cbMasoSV
            // 
            this.cbMasoSV.FormattingEnabled = true;
            this.cbMasoSV.Location = new System.Drawing.Point(124, 14);
            this.cbMasoSV.Name = "cbMasoSV";
            this.cbMasoSV.Size = new System.Drawing.Size(200, 24);
            this.cbMasoSV.TabIndex = 3;
            this.cbMasoSV.SelectedIndexChanged += new System.EventHandler(this.cbMasoSV_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên SV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số SV";
            // 
            // dtgXemDiem
            // 
            this.dtgXemDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgXemDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgXemDiemClTenMH,
            this.dtgXemDiemClDiem});
            this.dtgXemDiem.Location = new System.Drawing.Point(13, 164);
            this.dtgXemDiem.Name = "dtgXemDiem";
            this.dtgXemDiem.RowHeadersWidth = 51;
            this.dtgXemDiem.RowTemplate.Height = 24;
            this.dtgXemDiem.Size = new System.Drawing.Size(530, 150);
            this.dtgXemDiem.TabIndex = 1;
            // 
            // dtgXemDiemClTenMH
            // 
            this.dtgXemDiemClTenMH.HeaderText = "Môn học";
            this.dtgXemDiemClTenMH.MinimumWidth = 6;
            this.dtgXemDiemClTenMH.Name = "dtgXemDiemClTenMH";
            this.dtgXemDiemClTenMH.Width = 125;
            // 
            // dtgXemDiemClDiem
            // 
            this.dtgXemDiemClDiem.HeaderText = "Điểm";
            this.dtgXemDiemClDiem.MinimumWidth = 6;
            this.dtgXemDiemClDiem.Name = "dtgXemDiemClDiem";
            this.dtgXemDiemClDiem.Width = 125;
            // 
            // XemDiemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.dtgXemDiem);
            this.Controls.Add(this.panel1);
            this.Name = "XemDiemForm";
            this.Text = "Xem điểm sinh viên";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgXemDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXemDiem;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.ComboBox cnHoTenSV;
        private System.Windows.Forms.ComboBox cbMasoSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgXemDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgXemDiemClTenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgXemDiemClDiem;
    }
}
namespace Chap9_Baitap2
{
    partial class ThongKeKhoaForm
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
            this.btnXemDSSV = new System.Windows.Forms.Button();
            this.cbTenKhoa = new System.Windows.Forms.ComboBox();
            this.cbMaKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chap9_Baitap2DataSet1 = new Chap9_Baitap2.Chap9_Baitap2DataSet();
            this.dtgXemDSSVTheoKhoa = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chap9_Baitap2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgXemDSSVTheoKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXemDSSV);
            this.panel1.Controls.Add(this.cbTenKhoa);
            this.panel1.Controls.Add(this.cbMaKhoa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 123);
            this.panel1.TabIndex = 0;
            // 
            // btnXemDSSV
            // 
            this.btnXemDSSV.Location = new System.Drawing.Point(456, 76);
            this.btnXemDSSV.Name = "btnXemDSSV";
            this.btnXemDSSV.Size = new System.Drawing.Size(75, 23);
            this.btnXemDSSV.TabIndex = 4;
            this.btnXemDSSV.Text = "Xem";
            this.btnXemDSSV.UseVisualStyleBackColor = true;
            this.btnXemDSSV.Click += new System.EventHandler(this.btnXemDSSV_Click);
            // 
            // cbTenKhoa
            // 
            this.cbTenKhoa.FormattingEnabled = true;
            this.cbTenKhoa.Location = new System.Drawing.Point(155, 75);
            this.cbTenKhoa.Name = "cbTenKhoa";
            this.cbTenKhoa.Size = new System.Drawing.Size(239, 24);
            this.cbTenKhoa.TabIndex = 3;
            this.cbTenKhoa.SelectedIndexChanged += new System.EventHandler(this.cbTenKhoa_SelectedIndexChanged);
            // 
            // cbMaKhoa
            // 
            this.cbMaKhoa.FormattingEnabled = true;
            this.cbMaKhoa.Location = new System.Drawing.Point(155, 9);
            this.cbMaKhoa.Name = "cbMaKhoa";
            this.cbMaKhoa.Size = new System.Drawing.Size(239, 24);
            this.cbMaKhoa.TabIndex = 2;
            this.cbMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cbMaKhoa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khoa";
            // 
            // chap9_Baitap2DataSet1
            // 
            this.chap9_Baitap2DataSet1.DataSetName = "Chap9_Baitap2DataSet";
            this.chap9_Baitap2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtgXemDSSVTheoKhoa
            // 
            this.dtgXemDSSVTheoKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgXemDSSVTheoKhoa.Location = new System.Drawing.Point(12, 161);
            this.dtgXemDSSVTheoKhoa.Name = "dtgXemDSSVTheoKhoa";
            this.dtgXemDSSVTheoKhoa.RowHeadersWidth = 51;
            this.dtgXemDSSVTheoKhoa.RowTemplate.Height = 24;
            this.dtgXemDSSVTheoKhoa.Size = new System.Drawing.Size(802, 150);
            this.dtgXemDSSVTheoKhoa.TabIndex = 1;
            // 
            // ThongKeKhoaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.dtgXemDSSVTheoKhoa);
            this.Controls.Add(this.panel1);
            this.Name = "ThongKeKhoaForm";
            this.Text = "Thông tin sinh viên theo Khoa";
            this.Load += new System.EventHandler(this.ThongKeKhoaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chap9_Baitap2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgXemDSSVTheoKhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTenKhoa;
        private System.Windows.Forms.ComboBox cbMaKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXemDSSV;
        private Chap9_Baitap2DataSet chap9_Baitap2DataSet1;
        private System.Windows.Forms.DataGridView dtgXemDSSVTheoKhoa;
    }
}
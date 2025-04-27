namespace Chap9_Baitap2
{
    partial class NhapDiemForm
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
            this.cbMasoSV = new System.Windows.Forms.ComboBox();
            this.cbHoTenSV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTenMH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMaMH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNhapDiem = new System.Windows.Forms.TextBox();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số SV";
            // 
            // cbMasoSV
            // 
            this.cbMasoSV.FormattingEnabled = true;
            this.cbMasoSV.Location = new System.Drawing.Point(184, 24);
            this.cbMasoSV.Name = "cbMasoSV";
            this.cbMasoSV.Size = new System.Drawing.Size(238, 24);
            this.cbMasoSV.TabIndex = 1;
            this.cbMasoSV.SelectedIndexChanged += new System.EventHandler(this.cbMasoSV_SelectedIndexChanged);
            // 
            // cbHoTenSV
            // 
            this.cbHoTenSV.FormattingEnabled = true;
            this.cbHoTenSV.Location = new System.Drawing.Point(184, 79);
            this.cbHoTenSV.Name = "cbHoTenSV";
            this.cbHoTenSV.Size = new System.Drawing.Size(238, 24);
            this.cbHoTenSV.TabIndex = 3;
            this.cbHoTenSV.SelectedIndexChanged += new System.EventHandler(this.cbHoTenSV_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên SV";
            // 
            // cbTenMH
            // 
            this.cbTenMH.FormattingEnabled = true;
            this.cbTenMH.Location = new System.Drawing.Point(184, 192);
            this.cbTenMH.Name = "cbTenMH";
            this.cbTenMH.Size = new System.Drawing.Size(238, 24);
            this.cbTenMH.TabIndex = 7;
            this.cbTenMH.SelectedIndexChanged += new System.EventHandler(this.cbTenMH_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên môn học";
            // 
            // cbMaMH
            // 
            this.cbMaMH.FormattingEnabled = true;
            this.cbMaMH.Location = new System.Drawing.Point(184, 137);
            this.cbMaMH.Name = "cbMaMH";
            this.cbMaMH.Size = new System.Drawing.Size(238, 24);
            this.cbMaMH.TabIndex = 5;
            this.cbMaMH.SelectedIndexChanged += new System.EventHandler(this.cbMaMH_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã môn học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Điểm";
            // 
            // txtNhapDiem
            // 
            this.txtNhapDiem.Location = new System.Drawing.Point(184, 251);
            this.txtNhapDiem.Name = "txtNhapDiem";
            this.txtNhapDiem.Size = new System.Drawing.Size(127, 22);
            this.txtNhapDiem.TabIndex = 9;
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Location = new System.Drawing.Point(239, 322);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(105, 53);
            this.btnNhapDiem.TabIndex = 10;
            this.btnNhapDiem.Text = "Nhập điểm";
            this.btnNhapDiem.UseVisualStyleBackColor = true;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // NhapDiemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.btnNhapDiem);
            this.Controls.Add(this.txtNhapDiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTenMH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMaMH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbHoTenSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMasoSV);
            this.Controls.Add(this.label1);
            this.Name = "NhapDiemForm";
            this.Text = "Nhập điểm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMasoSV;
        private System.Windows.Forms.ComboBox cbHoTenSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTenMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMaMH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNhapDiem;
        private System.Windows.Forms.Button btnNhapDiem;
    }
}
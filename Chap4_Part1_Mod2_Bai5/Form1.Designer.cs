namespace Mod2_Bai5
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
            txtNhapTen = new TextBox();
            groupBox1 = new GroupBox();
            radBlack = new RadioButton();
            radBlue = new RadioButton();
            radGreen = new RadioButton();
            radRed = new RadioButton();
            groupBox2 = new GroupBox();
            chkUnderline = new CheckBox();
            chkItalic = new CheckBox();
            chkBold = new CheckBox();
            label2 = new Label();
            btnThoat = new Button();
            lblLapTrinh = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(21, 17);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 0;
            label1.Text = "Nhập tên";
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(134, 17);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(444, 27);
            txtNhapTen.TabIndex = 1;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(radBlack);
            groupBox1.Controls.Add(radBlue);
            groupBox1.Controls.Add(radGreen);
            groupBox1.Controls.Add(radRed);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(21, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(259, 216);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color";
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Location = new Point(15, 180);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(67, 24);
            radBlack.TabIndex = 1;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.ForeColor = SystemColors.MenuHighlight;
            radBlue.Location = new Point(15, 130);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(61, 24);
            radBlue.TabIndex = 2;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.ForeColor = Color.FromArgb(0, 192, 0);
            radGreen.Location = new Point(15, 81);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(72, 24);
            radGreen.TabIndex = 1;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(15, 38);
            radRed.Name = "radRed";
            radRed.Size = new Size(57, 24);
            radRed.TabIndex = 0;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 224, 192);
            groupBox2.Controls.Add(chkUnderline);
            groupBox2.Controls.Add(chkItalic);
            groupBox2.Controls.Add(chkBold);
            groupBox2.Location = new Point(319, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(259, 216);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Font";
            // 
            // chkUnderline
            // 
            chkUnderline.AutoSize = true;
            chkUnderline.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            chkUnderline.ForeColor = Color.FromArgb(0, 0, 192);
            chkUnderline.Location = new Point(24, 171);
            chkUnderline.Name = "chkUnderline";
            chkUnderline.Size = new Size(103, 24);
            chkUnderline.TabIndex = 2;
            chkUnderline.Text = "Gạch chân";
            chkUnderline.UseVisualStyleBackColor = true;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            chkItalic.ForeColor = Color.FromArgb(0, 0, 192);
            chkItalic.Location = new Point(24, 102);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(133, 24);
            chkItalic.TabIndex = 1;
            chkItalic.Text = "Nghiêng Italic";
            chkItalic.UseVisualStyleBackColor = true;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkBold.ForeColor = Color.FromArgb(0, 0, 192);
            chkBold.Location = new Point(24, 34);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(100, 24);
            chkBold.TabIndex = 0;
            chkBold.Text = "Đậm Bold";
            chkBold.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(36, 297);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 4;
            label2.Text = "Lập trình bởi";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(469, 281);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(109, 44);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.AutoSize = true;
            lblLapTrinh.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLapTrinh.ForeColor = Color.FromArgb(0, 192, 0);
            lblLapTrinh.Location = new Point(198, 288);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(104, 41);
            lblLapTrinh.TabIndex = 7;
            lblLapTrinh.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 337);
            Controls.Add(lblLapTrinh);
            Controls.Add(btnThoat);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtNhapTen);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Định dạng Formater";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNhapTen;
        private GroupBox groupBox1;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private RadioButton radRed;
        private GroupBox groupBox2;
        private CheckBox chkUnderline;
        private CheckBox chkItalic;
        private CheckBox chkBold;
        private Label label2;
        private Button btnThoat;
        private Label lblLapTrinh;
    }
}

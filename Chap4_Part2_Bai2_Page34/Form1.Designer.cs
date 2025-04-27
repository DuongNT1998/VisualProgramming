namespace Chuong4_Phan2_B2
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
            rbVietNamFlag = new RadioButton();
            rbChineseFlag = new RadioButton();
            rbUSAFlag = new RadioButton();
            pbFlag = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbFlag).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(94, 26);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Countruy";
            label1.Click += label1_Click;
            // 
            // rbVietNamFlag
            // 
            rbVietNamFlag.AutoSize = true;
            rbVietNamFlag.Location = new Point(132, 60);
            rbVietNamFlag.Name = "rbVietNamFlag";
            rbVietNamFlag.Size = new Size(92, 24);
            rbVietNamFlag.TabIndex = 1;
            rbVietNamFlag.TabStop = true;
            rbVietNamFlag.Text = "Việt Nam";
            rbVietNamFlag.UseVisualStyleBackColor = true;
            // 
            // rbChineseFlag
            // 
            rbChineseFlag.AutoSize = true;
            rbChineseFlag.Location = new Point(132, 120);
            rbChineseFlag.Name = "rbChineseFlag";
            rbChineseFlag.Size = new Size(106, 24);
            rbChineseFlag.TabIndex = 2;
            rbChineseFlag.TabStop = true;
            rbChineseFlag.Text = "Trung Quốc";
            rbChineseFlag.UseVisualStyleBackColor = true;
            // 
            // rbUSAFlag
            // 
            rbUSAFlag.AutoSize = true;
            rbUSAFlag.Location = new Point(132, 182);
            rbUSAFlag.Name = "rbUSAFlag";
            rbUSAFlag.Size = new Size(50, 24);
            rbUSAFlag.TabIndex = 3;
            rbUSAFlag.TabStop = true;
            rbUSAFlag.Text = "Mỹ";
            rbUSAFlag.UseVisualStyleBackColor = true;
            // 
            // pbFlag
            // 
            pbFlag.Location = new Point(313, 60);
            pbFlag.Name = "pbFlag";
            pbFlag.Size = new Size(193, 163);
            pbFlag.TabIndex = 4;
            pbFlag.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 273);
            Controls.Add(pbFlag);
            Controls.Add(rbUSAFlag);
            Controls.Add(rbChineseFlag);
            Controls.Add(rbVietNamFlag);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbFlag).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rbVietNamFlag;
        private RadioButton rbChineseFlag;
        private RadioButton rbUSAFlag;
        private PictureBox pbFlag;
    }
}

namespace Chap4_Part2_Bai7_Page38
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
            tbRed = new TrackBar();
            tbGreen = new TrackBar();
            tbBlue = new TrackBar();
            panel1 = new Panel();
            lbRed = new Label();
            lbGreen = new Label();
            lbBlue = new Label();
            ((System.ComponentModel.ISupportInitialize)tbRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbBlue).BeginInit();
            SuspendLayout();
            // 
            // tbRed
            // 
            tbRed.Location = new Point(12, 12);
            tbRed.Maximum = 255;
            tbRed.Name = "tbRed";
            tbRed.Size = new Size(187, 56);
            tbRed.TabIndex = 0;
            // 
            // tbGreen
            // 
            tbGreen.Location = new Point(12, 74);
            tbGreen.Maximum = 255;
            tbGreen.Name = "tbGreen";
            tbGreen.Size = new Size(187, 56);
            tbGreen.TabIndex = 1;
            // 
            // tbBlue
            // 
            tbBlue.Location = new Point(12, 136);
            tbBlue.Maximum = 255;
            tbBlue.Name = "tbBlue";
            tbBlue.Size = new Size(187, 56);
            tbBlue.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(340, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 166);
            panel1.TabIndex = 3;
        
            // 
            // lbRed
            // 
            lbRed.AutoSize = true;
            lbRed.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbRed.ForeColor = Color.Red;
            lbRed.Location = new Point(205, 12);
            lbRed.Name = "lbRed";
            lbRed.Size = new Size(68, 30);
            lbRed.TabIndex = 4;
            lbRed.Text = "R = 0";
            // 
            // lbGreen
            // 
            lbGreen.AutoSize = true;
            lbGreen.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbGreen.ForeColor = Color.FromArgb(0, 192, 0);
            lbGreen.Location = new Point(205, 65);
            lbGreen.Name = "lbGreen";
            lbGreen.Size = new Size(70, 30);
            lbGreen.TabIndex = 5;
            lbGreen.Text = "G = 0";
            // 
            // lbBlue
            // 
            lbBlue.AutoSize = true;
            lbBlue.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbBlue.ForeColor = Color.Blue;
            lbBlue.Location = new Point(205, 127);
            lbBlue.Name = "lbBlue";
            lbBlue.Size = new Size(68, 30);
            lbBlue.TabIndex = 6;
            lbBlue.Text = "B = 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 190);
            Controls.Add(lbBlue);
            Controls.Add(lbGreen);
            Controls.Add(lbRed);
            Controls.Add(panel1);
            Controls.Add(tbBlue);
            Controls.Add(tbGreen);
            Controls.Add(tbRed);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)tbRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar tbRed;
        private TrackBar tbGreen;
        private TrackBar tbBlue;
        private Panel panel1;
        private Label lbRed;
        private Label lbGreen;
        private Label lbBlue;
    }
}

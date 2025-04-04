namespace Mod2_Bai7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtName = new TextBox();
            picTurnOn = new PictureBox();
            picTurnOff = new PictureBox();
            txtChangeLight = new Label();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)picTurnOn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTurnOff).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = SystemColors.InactiveCaptionText;
            txtName.Location = new Point(75, 17);
            txtName.Name = "txtName";
            txtName.Size = new Size(435, 34);
            txtName.TabIndex = 1;
            txtName.Text = "Jack";
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // picTurnOn
            // 
            picTurnOn.Image = (Image)resources.GetObject("picTurnOn.Image");
            picTurnOn.Location = new Point(189, 71);
            picTurnOn.Name = "picTurnOn";
            picTurnOn.Size = new Size(172, 243);
            picTurnOn.TabIndex = 2;
            picTurnOn.TabStop = false;
            picTurnOn.Click += picTurnOn_Click;
            picTurnOn.MouseHover += picTurnOn_MouseHover;
            // 
            // picTurnOff
            // 
            picTurnOff.Image = (Image)resources.GetObject("picTurnOff.Image");
            picTurnOff.Location = new Point(189, 71);
            picTurnOff.Name = "picTurnOff";
            picTurnOff.Size = new Size(172, 243);
            picTurnOff.TabIndex = 3;
            picTurnOff.TabStop = false;
            picTurnOff.Click += picTurnOff_Click;
            picTurnOff.MouseHover += picTurnOff_MouseHover;
            // 
            // txtChangeLight
            // 
            txtChangeLight.AutoSize = true;
            txtChangeLight.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtChangeLight.Location = new Point(53, 334);
            txtChangeLight.Name = "txtChangeLight";
            txtChangeLight.Size = new Size(0, 38);
            txtChangeLight.TabIndex = 4;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(416, 384);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(105, 43);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Exit";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(554, 439);
            Controls.Add(btnThoat);
            Controls.Add(txtChangeLight);
            Controls.Add(picTurnOff);
            Controls.Add(picTurnOn);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picTurnOn).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTurnOff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private PictureBox picTurnOn;
        private PictureBox picTurnOff;
        private Label txtChangeLight;
        private Button btnThoat;
    }
}

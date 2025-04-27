namespace Mod2_Bai10
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
            lklblWeb = new LinkLabel();
            lklblCDrive = new LinkLabel();
            lklblCalcu = new LinkLabel();
            label1 = new Label();
            SuspendLayout();
            // 
            // lklblWeb
            // 
            lklblWeb.AutoSize = true;
            lklblWeb.Location = new Point(108, 61);
            lklblWeb.Name = "lklblWeb";
            lklblWeb.Size = new Size(233, 20);
            lklblWeb.TabIndex = 0;
            lklblWeb.TabStop = true;
            lklblWeb.Text = "Window form community website";
            lklblWeb.LinkClicked += lklblWeb_LinkClicked;
            // 
            // lklblCDrive
            // 
            lklblCDrive.AutoSize = true;
            lklblCDrive.Location = new Point(250, 124);
            lklblCDrive.Name = "lklblCDrive";
            lklblCDrive.Size = new Size(100, 20);
            lklblCDrive.TabIndex = 1;
            lklblCDrive.TabStop = true;
            lklblCDrive.Text = "Open C: Drive";
            lklblCDrive.LinkClicked += lklblCDrive_LinkClicked;
            // 
            // lklblCalcu
            // 
            lklblCalcu.AutoSize = true;
            lklblCalcu.Location = new Point(99, 124);
            lklblCalcu.Name = "lklblCalcu";
            lklblCalcu.Size = new Size(126, 20);
            lklblCalcu.TabIndex = 2;
            lklblCalcu.TabStop = true;
            lklblCalcu.Text = "Launch Calculator";
            lklblCalcu.LinkClicked += lklblCalcu_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 124);
            label1.Name = "label1";
            label1.Size = new Size(13, 20);
            label1.TabIndex = 3;
            label1.Text = "|";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 208);
            Controls.Add(label1);
            Controls.Add(lklblCalcu);
            Controls.Add(lklblCDrive);
            Controls.Add(lklblWeb);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lklblWeb;
        private LinkLabel lklblCDrive;
        private LinkLabel lklblCalcu;
        private Label label1;
    }
}

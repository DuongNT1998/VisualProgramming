namespace Mod2_Bai11
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
            btnBrowseFile = new Button();
            groupBox1 = new GroupBox();
            lbProperties = new Label();
            hScrollBar1 = new HScrollBar();
            vScrollBar1 = new VScrollBar();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 22);
            label1.Name = "label1";
            label1.Size = new Size(231, 20);
            label1.TabIndex = 0;
            label1.Text = "Click button to open a picture file";
            // 
            // btnBrowseFile
            // 
            btnBrowseFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowseFile.Location = new Point(401, 22);
            btnBrowseFile.Name = "btnBrowseFile";
            btnBrowseFile.Size = new Size(120, 40);
            btnBrowseFile.TabIndex = 1;
            btnBrowseFile.Text = "Browse...";
            btnBrowseFile.UseVisualStyleBackColor = true;
            btnBrowseFile.Click += btnBrowseFile_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbProperties);
            groupBox1.Location = new Point(42, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 144);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "File statitics";
            // 
            // lbProperties
            // 
            lbProperties.AutoSize = true;
            lbProperties.Location = new Point(6, 35);
            lbProperties.Name = "lbProperties";
            lbProperties.Size = new Size(50, 20);
            lbProperties.TabIndex = 0;
            lbProperties.Text = "label2";
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(42, 425);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(479, 26);
            hScrollBar1.TabIndex = 3;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(503, 217);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(18, 208);
            vScrollBar1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 467);
            Controls.Add(vScrollBar1);
            Controls.Add(hScrollBar1);
            Controls.Add(groupBox1);
            Controls.Add(btnBrowseFile);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBrowseFile;
        private GroupBox groupBox1;
        private HScrollBar hScrollBar1;
        private VScrollBar vScrollBar1;
        private Label lbProperties;
    }
}

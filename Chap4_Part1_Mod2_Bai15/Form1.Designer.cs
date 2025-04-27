namespace Mod2_Bai15
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
            label2 = new Label();
            nudSize = new NumericUpDown();
            dudColor = new DomainUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudSize).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 48);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Color";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 111);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 1;
            label2.Text = "Size";
            // 
            // nudSize
            // 
            nudSize.Location = new Point(133, 108);
            nudSize.Maximum = new decimal(new int[] { 80, 0, 0, 0 });
            nudSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSize.Name = "nudSize";
            nudSize.Size = new Size(156, 27);
            nudSize.TabIndex = 2;
            nudSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudSize.ValueChanged += nudSize_ValueChanged;
            // 
            // dudColor
            // 
            dudColor.Items.Add("Green");
            dudColor.Items.Add("Red");
            dudColor.Items.Add("White");
            dudColor.Items.Add("Orange");
            dudColor.Items.Add("Violet");
            dudColor.Items.Add("Yellow");
            dudColor.Items.Add("Black");
            dudColor.Items.Add("Brown");
            dudColor.Location = new Point(133, 47);
            dudColor.Name = "dudColor";
            dudColor.Size = new Size(156, 27);
            dudColor.TabIndex = 3;
            dudColor.SelectedItemChanged += dudColor_SelectedItemChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(108, 192);
            label3.Name = "label3";
            label3.Size = new Size(190, 41);
            label3.TabIndex = 4;
            label3.Text = "Sample Text";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 283);
            Controls.Add(label3);
            Controls.Add(dudColor);
            Controls.Add(nudSize);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown nudSize;
        private DomainUpDown dudColor;
        private Label label3;
    }
}

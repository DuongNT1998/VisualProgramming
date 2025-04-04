namespace Mod2_Bai2
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
            btnClick = new Button();
            SuspendLayout();
            // 
            // btnClick
            // 
            btnClick.BackColor = SystemColors.Control;
            btnClick.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClick.ForeColor = Color.Red;
            btnClick.Location = new Point(123, 58);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(163, 75);
            btnClick.TabIndex = 0;
            btnClick.Text = "Click me";
            btnClick.UseVisualStyleBackColor = false;
        
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 204);
            Controls.Add(btnClick);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);

           
        }

        #endregion

        private Button btnClick;
    }
}

namespace Mod3_Bai7
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
            txtAmLich = new TextBox();
            btnDoiLich = new Button();
            label2 = new Label();
            txtDuongLich = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập năm dương lịch";
            // 
            // txtAmLich
            // 
            txtAmLich.Location = new Point(203, 25);
            txtAmLich.Name = "txtAmLich";
            txtAmLich.Size = new Size(210, 27);
            txtAmLich.TabIndex = 1;
            // 
            // btnDoiLich
            // 
            btnDoiLich.Location = new Point(120, 89);
            btnDoiLich.Name = "btnDoiLich";
            btnDoiLich.Size = new Size(197, 29);
            btnDoiLich.TabIndex = 2;
            btnDoiLich.Text = "Thực hiện đổi";
            btnDoiLich.UseVisualStyleBackColor = true;
            btnDoiLich.Click += btnDoiLich_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 149);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 3;
            label2.Text = "Năm âm lịch";
            // 
            // txtDuongLich
            // 
            txtDuongLich.Location = new Point(203, 142);
            txtDuongLich.Name = "txtDuongLich";
            txtDuongLich.ReadOnly = true;
            txtDuongLich.Size = new Size(210, 27);
            txtDuongLich.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 197);
            Controls.Add(txtDuongLich);
            Controls.Add(label2);
            Controls.Add(btnDoiLich);
            Controls.Add(txtAmLich);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Đổi năm dương lịch sang âm lịch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAmLich;
        private Button btnDoiLich;
        private Label label2;
        private TextBox txtDuongLich;
    }
}

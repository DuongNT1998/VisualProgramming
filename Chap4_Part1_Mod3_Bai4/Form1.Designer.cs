namespace Mod3_Bai4
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
            label3 = new Label();
            txtHeSoThu1 = new TextBox();
            txtHeSoThu2 = new TextBox();
            txtHeSoThu3 = new TextBox();
            label4 = new Label();
            btnPTB1 = new Button();
            btnPTB2 = new Button();
            lblKetQua = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 18);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "Số A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 66);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Số B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 117);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "Số C";
            // 
            // txtHeSoThu1
            // 
            txtHeSoThu1.Location = new Point(93, 20);
            txtHeSoThu1.Name = "txtHeSoThu1";
            txtHeSoThu1.Size = new Size(168, 27);
            txtHeSoThu1.TabIndex = 3;
            // 
            // txtHeSoThu2
            // 
            txtHeSoThu2.Location = new Point(93, 66);
            txtHeSoThu2.Name = "txtHeSoThu2";
            txtHeSoThu2.Size = new Size(168, 27);
            txtHeSoThu2.TabIndex = 4;
            // 
            // txtHeSoThu3
            // 
            txtHeSoThu3.Location = new Point(93, 117);
            txtHeSoThu3.Name = "txtHeSoThu3";
            txtHeSoThu3.Size = new Size(168, 27);
            txtHeSoThu3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 184);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 6;
            label4.Text = "Kết quả";
            // 
            // btnPTB1
            // 
            btnPTB1.Location = new Point(42, 243);
            btnPTB1.Name = "btnPTB1";
            btnPTB1.Size = new Size(125, 48);
            btnPTB1.TabIndex = 8;
            btnPTB1.Text = "Giải PT Bậc 1";
            btnPTB1.UseVisualStyleBackColor = true;
            btnPTB1.Click += btnPTB1_Click;
            // 
            // btnPTB2
            // 
            btnPTB2.Location = new Point(191, 243);
            btnPTB2.Name = "btnPTB2";
            btnPTB2.Size = new Size(125, 48);
            btnPTB2.TabIndex = 9;
            btnPTB2.Text = "Giải PT Bậc 2";
            btnPTB2.UseVisualStyleBackColor = true;
            btnPTB2.Click += btnPTB2_Click;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.ForeColor = Color.Red;
            lblKetQua.Location = new Point(96, 184);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(0, 20);
            lblKetQua.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 303);
            Controls.Add(lblKetQua);
            Controls.Add(btnPTB2);
            Controls.Add(btnPTB1);
            Controls.Add(label4);
            Controls.Add(txtHeSoThu3);
            Controls.Add(txtHeSoThu2);
            Controls.Add(txtHeSoThu1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtHeSoThu1;
        private TextBox txtHeSoThu2;
        private TextBox txtHeSoThu3;
        private Label label4;
        private Button btnPTB1;
        private Button btnPTB2;
        private Label lblKetQua;
    }
}

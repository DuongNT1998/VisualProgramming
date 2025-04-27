namespace Mod2_Bai14
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
            textBox1 = new TextBox();
            btnCapNhat = new Button();
            lstLopA = new ListBox();
            btnMoveEachToRight = new Button();
            btnMoveAllToRight = new Button();
            btnMoveEachToLeft = new Button();
            btnMoveAllToLeft = new Button();
            lstLopB = new ListBox();
            btnKetThuc = new Button();
            btnXoaLopA = new Button();
            btnXoaLopB = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên SV";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 27);
            textBox1.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.Location = new Point(431, 19);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(153, 45);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // lstLopA
            // 
            lstLopA.FormattingEnabled = true;
            lstLopA.Location = new Point(32, 81);
            lstLopA.Name = "lstLopA";
            lstLopA.Size = new Size(189, 224);
            lstLopA.TabIndex = 3;
            // 
            // btnMoveEachToRight
            // 
            btnMoveEachToRight.Location = new Point(249, 81);
            btnMoveEachToRight.Name = "btnMoveEachToRight";
            btnMoveEachToRight.Size = new Size(70, 44);
            btnMoveEachToRight.TabIndex = 4;
            btnMoveEachToRight.Text = ">";
            btnMoveEachToRight.UseVisualStyleBackColor = true;
            btnMoveEachToRight.Click += btnMoveEachToRight_Click;
            // 
            // btnMoveAllToRight
            // 
            btnMoveAllToRight.Location = new Point(249, 144);
            btnMoveAllToRight.Name = "btnMoveAllToRight";
            btnMoveAllToRight.Size = new Size(70, 44);
            btnMoveAllToRight.TabIndex = 5;
            btnMoveAllToRight.Text = ">>";
            btnMoveAllToRight.UseVisualStyleBackColor = true;
            btnMoveAllToRight.Click += btnMoveAllToRight_Click;
            // 
            // btnMoveEachToLeft
            // 
            btnMoveEachToLeft.Location = new Point(249, 208);
            btnMoveEachToLeft.Name = "btnMoveEachToLeft";
            btnMoveEachToLeft.Size = new Size(70, 44);
            btnMoveEachToLeft.TabIndex = 6;
            btnMoveEachToLeft.Text = "<";
            btnMoveEachToLeft.UseVisualStyleBackColor = true;
            btnMoveEachToLeft.Click += btnMoveEachToLeft_Click;
            // 
            // btnMoveAllToLeft
            // 
            btnMoveAllToLeft.Location = new Point(249, 261);
            btnMoveAllToLeft.Name = "btnMoveAllToLeft";
            btnMoveAllToLeft.Size = new Size(70, 44);
            btnMoveAllToLeft.TabIndex = 7;
            btnMoveAllToLeft.Text = "<<";
            btnMoveAllToLeft.UseVisualStyleBackColor = true;
            btnMoveAllToLeft.Click += btnMoveAllToLeft_Click;
            // 
            // lstLopB
            // 
            lstLopB.FormattingEnabled = true;
            lstLopB.Location = new Point(372, 81);
            lstLopB.Name = "lstLopB";
            lstLopB.Size = new Size(212, 224);
            lstLopB.TabIndex = 8;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKetThuc.Location = new Point(234, 349);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(158, 45);
            btnKetThuc.TabIndex = 9;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnXoaLopA
            // 
            btnXoaLopA.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaLopA.Location = new Point(32, 349);
            btnXoaLopA.Name = "btnXoaLopA";
            btnXoaLopA.Size = new Size(161, 45);
            btnXoaLopA.TabIndex = 10;
            btnXoaLopA.Text = "Xóa Lớp A";
            btnXoaLopA.UseVisualStyleBackColor = true;
            btnXoaLopA.Click += btnXoaLopA_Click;
            // 
            // btnXoaLopB
            // 
            btnXoaLopB.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaLopB.Location = new Point(431, 349);
            btnXoaLopB.Name = "btnXoaLopB";
            btnXoaLopB.Size = new Size(136, 45);
            btnXoaLopB.TabIndex = 11;
            btnXoaLopB.Text = "Xóa lớp B";
            btnXoaLopB.UseVisualStyleBackColor = true;
            btnXoaLopB.Click += btnXoaLopB_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 450);
            Controls.Add(btnXoaLopB);
            Controls.Add(btnXoaLopA);
            Controls.Add(btnKetThuc);
            Controls.Add(lstLopB);
            Controls.Add(btnMoveAllToLeft);
            Controls.Add(btnMoveEachToLeft);
            Controls.Add(btnMoveAllToRight);
            Controls.Add(btnMoveEachToRight);
            Controls.Add(lstLopA);
            Controls.Add(btnCapNhat);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnCapNhat;
        private ListBox lstLopA;
        private Button btnMoveEachToRight;
        private Button btnMoveAllToRight;
        private Button btnMoveEachToLeft;
        private Button btnMoveAllToLeft;
        private ListBox lstLopB;
        private Button btnKetThuc;
        private Button btnXoaLopA;
        private Button btnXoaLopB;
    }
}

namespace Mod2_Bai3
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
            txtHoLot = new TextBox();
            txtTen = new TextBox();
            lbHoVaTen = new Label();
            btnHoLot = new Button();
            btnTen = new Button();
            btnHovaTen = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 85);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Họ lót";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 139);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên";
            // 
            // txtHoLot
            // 
            txtHoLot.Location = new Point(99, 85);
            txtHoLot.Name = "txtHoLot";
            txtHoLot.Size = new Size(381, 27);
            txtHoLot.TabIndex = 3;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.FromArgb(255, 192, 255);
            txtTen.Location = new Point(99, 139);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(381, 27);
            txtTen.TabIndex = 4;
            // 
            // lbHoVaTen
            // 
            lbHoVaTen.AutoSize = true;
            lbHoVaTen.Location = new Point(1, 0);
            lbHoVaTen.MaximumSize = new Size(666, 333);
            lbHoVaTen.Name = "lbHoVaTen";
            lbHoVaTen.Size = new Size(50, 20);
            lbHoVaTen.TabIndex = 5;
            lbHoVaTen.Text = "label3";
            // 
            // btnHoLot
            // 
            btnHoLot.Location = new Point(61, 196);
            btnHoLot.Name = "btnHoLot";
            btnHoLot.Size = new Size(94, 29);
            btnHoLot.TabIndex = 6;
            btnHoLot.Text = "Họ Lót";
            btnHoLot.UseVisualStyleBackColor = true;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(230, 196);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(94, 29);
            btnTen.TabIndex = 7;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            // 
            // btnHovaTen
            // 
            btnHovaTen.Location = new Point(402, 196);
            btnHovaTen.Name = "btnHovaTen";
            btnHovaTen.Size = new Size(94, 29);
            btnHovaTen.TabIndex = 8;
            btnHovaTen.Text = "Họ và tên";
            btnHovaTen.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(187, 246);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(209, 29);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát chương trình";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 287);
            Controls.Add(btnThoat);
            Controls.Add(btnHovaTen);
            Controls.Add(btnTen);
            Controls.Add(btnHoLot);
            Controls.Add(lbHoVaTen);
            Controls.Add(txtTen);
            Controls.Add(txtHoLot);
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
        private TextBox txtHoLot;
        private TextBox txtTen;
        private Label lbHoVaTen;
        private Button btnHoLot;
        private Button btnTen;
        private Button btnHovaTen;
        private Button btnThoat;
    }
}

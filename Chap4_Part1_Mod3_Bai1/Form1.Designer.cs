namespace Mod3_Bai1
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
            panel1 = new Panel();
            txtThanhTien = new TextBox();
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            txtTenHang = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnKetThuc = new Button();
            btnTiep = new Button();
            btnThanhToan = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtThanhTien);
            panel1.Controls.Add(txtDonGia);
            panel1.Controls.Add(txtSoLuong);
            panel1.Controls.Add(txtTenHang);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 214);
            panel1.TabIndex = 0;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(133, 154);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(242, 27);
            txtThanhTien.TabIndex = 7;
            txtThanhTien.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(133, 111);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(242, 27);
            txtDonGia.TabIndex = 6;
            txtDonGia.TextAlign = HorizontalAlignment.Right;
            txtDonGia.KeyPress += txtDonGia_KeyPress;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(133, 63);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(242, 27);
            txtSoLuong.TabIndex = 5;
            txtSoLuong.TextAlign = HorizontalAlignment.Right;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(133, 21);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(242, 27);
            txtTenHang.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 157);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 3;
            label4.Text = "Thành tiền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 111);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Đơn giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 63);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Số lượng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 18);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên hàng";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnKetThuc);
            panel2.Controls.Add(btnTiep);
            panel2.Controls.Add(btnThanhToan);
            panel2.Location = new Point(12, 250);
            panel2.Name = "panel2";
            panel2.Size = new Size(407, 71);
            panel2.TabIndex = 1;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(292, 23);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(94, 29);
            btnKetThuc.TabIndex = 2;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnTiep
            // 
            btnTiep.Location = new Point(159, 23);
            btnTiep.Name = "btnTiep";
            btnTiep.Size = new Size(94, 29);
            btnTiep.TabIndex = 1;
            btnTiep.Text = "Tiếp";
            btnTiep.UseVisualStyleBackColor = true;
            btnTiep.Click += btnTiep_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(15, 23);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(94, 29);
            btnThanhToan.TabIndex = 0;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 333);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Chương trình tính tiền bán hàng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtThanhTien;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private TextBox txtTenHang;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button btnKetThuc;
        private Button btnTiep;
        private Button btnThanhToan;
    }
}

namespace Chuong4_Phan2_B3
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
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnThemMoi = new Button();
            cbLop = new ComboBox();
            dtNgaySinh = new DateTimePicker();
            txtDiaChi = new TextBox();
            txtHoTen = new TextBox();
            txtMaSV = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listView1 = new ListView();
            clHoTen = new ColumnHeader();
            clMaSV = new ColumnHeader();
            clDiaChi = new ColumnHeader();
            clNgaySinh = new ColumnHeader();
            clLop = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnCapNhat);
            groupBox1.Controls.Add(btnThemMoi);
            groupBox1.Controls.Add(cbLop);
            groupBox1.Controls.Add(dtNgaySinh);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtMaSV);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(831, 311);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThoat.Location = new Point(466, 248);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(115, 43);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.Location = new Point(466, 170);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(115, 43);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa Item";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCapNhat.Location = new Point(466, 97);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(115, 43);
            btnCapNhat.TabIndex = 11;
            btnCapNhat.Text = "Cập nhật item";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThemMoi.Location = new Point(466, 32);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(115, 43);
            btnThemMoi.TabIndex = 10;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // cbLop
            // 
            cbLop.FormattingEnabled = true;
            cbLop.Items.AddRange(new object[] { "Lớp A", "Lớp B", "Lớp C" });
            cbLop.Location = new Point(189, 263);
            cbLop.Name = "cbLop";
            cbLop.Size = new Size(230, 28);
            cbLop.TabIndex = 9;
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.Location = new Point(189, 204);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new Size(231, 27);
            dtNgaySinh.TabIndex = 8;
            dtNgaySinh.UseWaitCursor = true;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(189, 143);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(231, 27);
            txtDiaChi.TabIndex = 7;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(189, 94);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(231, 27);
            txtHoTen.TabIndex = 6;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(189, 40);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(231, 27);
            txtMaSV.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 259);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 4;
            label5.Text = "Lớp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 209);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 150);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 97);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 43);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { clHoTen, clMaSV, clDiaChi, clNgaySinh, clLop });
            listView1.Location = new Point(96, 369);
            listView1.Name = "listView1";
            listView1.Size = new Size(684, 121);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.ItemSelectionChanged += listView1_ItemSelectionChanged;
            listView1.MouseClick += listView1_MouseClick;
            // 
            // clHoTen
            // 
            clHoTen.DisplayIndex = 1;
            clHoTen.Text = "Họ Tên";
            // 
            // clMaSV
            // 
            clMaSV.DisplayIndex = 0;
            clMaSV.Text = "Mã SV";
            // 
            // clDiaChi
            // 
            clDiaChi.Text = "Địa chỉ";
            // 
            // clNgaySinh
            // 
            clNgaySinh.Text = "Ngày sinh";
            // 
            // clLop
            // 
            clLop.Text = "Lớp";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 557);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtNgaySinh;
        private TextBox txtDiaChi;
        private TextBox txtHoTen;
        private TextBox txtMaSV;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbLop;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnCapNhat;
        private Button btnThemMoi;
        private ListView listView1;
        private ColumnHeader clHoTen;
        private ColumnHeader clMaSV;
        private ColumnHeader clDiaChi;
        private ColumnHeader clNgaySinh;
        private ColumnHeader clLop;
    }
}

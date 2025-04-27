namespace Chap9_Baitap2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuQuanLySinhVien = new System.Windows.Forms.ToolStripButton();
            this.mnuQuanLyKhoa = new System.Windows.Forms.ToolStripButton();
            this.mnuQuanLyMonHoc = new System.Windows.Forms.ToolStripButton();
            this.mnuNhapDiem = new System.Windows.Forms.ToolStripButton();
            this.mnuThoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuXemDiem = new System.Windows.Forms.ToolStripButton();
            this.mnuThongKeTheoKhoa = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.hỗTrợToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // hỗTrợToolStripMenuItem
            // 
            this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanLySinhVien,
            this.mnuQuanLyKhoa,
            this.mnuQuanLyMonHoc,
            this.mnuNhapDiem,
            this.mnuThoat,
            this.toolStripSeparator1,
            this.mnuXemDiem,
            this.mnuThongKeTheoKhoa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnuQuanLySinhVien
            // 
            this.mnuQuanLySinhVien.Image = ((System.Drawing.Image)(resources.GetObject("mnuQuanLySinhVien.Image")));
            this.mnuQuanLySinhVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuQuanLySinhVien.Name = "mnuQuanLySinhVien";
            this.mnuQuanLySinhVien.Size = new System.Drawing.Size(92, 24);
            this.mnuQuanLySinhVien.Text = "Sinh viên";
            this.mnuQuanLySinhVien.Click += new System.EventHandler(this.mnuQuanLySinhVien_Click);
            // 
            // mnuQuanLyKhoa
            // 
            this.mnuQuanLyKhoa.Image = ((System.Drawing.Image)(resources.GetObject("mnuQuanLyKhoa.Image")));
            this.mnuQuanLyKhoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuQuanLyKhoa.Name = "mnuQuanLyKhoa";
            this.mnuQuanLyKhoa.Size = new System.Drawing.Size(67, 24);
            this.mnuQuanLyKhoa.Text = "Khoa";
            this.mnuQuanLyKhoa.Click += new System.EventHandler(this.mnuQuanLyKhoa_Click);
            // 
            // mnuQuanLyMonHoc
            // 
            this.mnuQuanLyMonHoc.Image = ((System.Drawing.Image)(resources.GetObject("mnuQuanLyMonHoc.Image")));
            this.mnuQuanLyMonHoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuQuanLyMonHoc.Name = "mnuQuanLyMonHoc";
            this.mnuQuanLyMonHoc.Size = new System.Drawing.Size(91, 24);
            this.mnuQuanLyMonHoc.Text = "Môn học";
            this.mnuQuanLyMonHoc.Click += new System.EventHandler(this.mnuQuanLyMonHoc_Click);
            // 
            // mnuNhapDiem
            // 
            this.mnuNhapDiem.Image = ((System.Drawing.Image)(resources.GetObject("mnuNhapDiem.Image")));
            this.mnuNhapDiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuNhapDiem.Name = "mnuNhapDiem";
            this.mnuNhapDiem.Size = new System.Drawing.Size(107, 24);
            this.mnuNhapDiem.Text = "Nhập điểm";
            this.mnuNhapDiem.Click += new System.EventHandler(this.mnuNhapDiem_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuThoat.Image = ((System.Drawing.Image)(resources.GetObject("mnuThoat.Image")));
            this.mnuThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(71, 24);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // mnuXemDiem
            // 
            this.mnuXemDiem.Image = ((System.Drawing.Image)(resources.GetObject("mnuXemDiem.Image")));
            this.mnuXemDiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuXemDiem.Name = "mnuXemDiem";
            this.mnuXemDiem.Size = new System.Drawing.Size(101, 24);
            this.mnuXemDiem.Text = "Xem điểm";
            this.mnuXemDiem.Click += new System.EventHandler(this.mnuXemDiem_Click);
            // 
            // mnuThongKeTheoKhoa
            // 
            this.mnuThongKeTheoKhoa.Image = ((System.Drawing.Image)(resources.GetObject("mnuThongKeTheoKhoa.Image")));
            this.mnuThongKeTheoKhoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuThongKeTheoKhoa.Name = "mnuThongKeTheoKhoa";
            this.mnuThongKeTheoKhoa.Size = new System.Drawing.Size(130, 24);
            this.mnuThongKeTheoKhoa.Text = "Thống kê khoa";
            this.mnuThongKeTheoKhoa.Click += new System.EventHandler(this.mnuThongKeTheoKhoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(89, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chào mứng đến với hệ thống quản lý sinh viên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quản lý sinh viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mnuQuanLySinhVien;
        private System.Windows.Forms.ToolStripButton mnuQuanLyKhoa;
        private System.Windows.Forms.ToolStripButton mnuQuanLyMonHoc;
        private System.Windows.Forms.ToolStripButton mnuNhapDiem;
        private System.Windows.Forms.ToolStripButton mnuThoat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mnuXemDiem;
        private System.Windows.Forms.ToolStripButton mnuThongKeTheoKhoa;
        private System.Windows.Forms.Label label1;
    }
}


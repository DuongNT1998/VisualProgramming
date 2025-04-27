using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap9_Baitap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuQuanLySinhVien_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            SinhVienForm svForm = new SinhVienForm();
            svForm.MdiParent = this;
            svForm.Show();
             label1.Visible= true;
        }

        private void mnuQuanLyKhoa_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            KhoaForm khoaForm = new KhoaForm();
            khoaForm.MdiParent = this;
            khoaForm.Show();
        }

        private void mnuQuanLyMonHoc_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            MonHocForm monhocForm = new MonHocForm();
            monhocForm.MdiParent = this;
            monhocForm.Show();
        }

        private void mnuNhapDiem_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            NhapDiemForm nhapdiemForm = new NhapDiemForm();
            nhapdiemForm.MdiParent = this;
            nhapdiemForm.Show();
        }

        private void mnuXemDiem_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            XemDiemForm xemdiemForm = new XemDiemForm();
            xemdiemForm.MdiParent = this;
            xemdiemForm.Show();
        }

        private void mnuThongKeTheoKhoa_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            ThongKeKhoaForm thongkeForm = new ThongKeKhoaForm();
            thongkeForm.MdiParent = this;
            thongkeForm.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

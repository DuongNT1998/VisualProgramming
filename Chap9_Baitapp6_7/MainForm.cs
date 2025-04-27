using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap9_Baitapp6_7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SachForm sach=new SachForm();  
            sach.MdiParent=this;
            sach.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            NhanVienForm nhanvien=new NhanVienForm();
            nhanvien.MdiParent=this;
            nhanvien.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DocGiaForm docGiaForm=new DocGiaForm();
            docGiaForm.MdiParent=this;
            docGiaForm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            PhieuMuonForm ph=   new PhieuMuonForm();
            ph.MdiParent=this;
            ph.Show();  
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
                RepoRtDSSach f = new RepoRtDSSach();
            f.MdiParent = this;
            f.Show();

        }
    }
}

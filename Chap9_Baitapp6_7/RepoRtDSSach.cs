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
    public partial class RepoRtDSSach : Form
    {
        public RepoRtDSSach()
        {
            InitializeComponent();
        }

        private void RepoRtDSSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.dataSet1.SACH);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        
        }
    }
}

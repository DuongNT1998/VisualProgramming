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
    public partial class MonHocForm : Form
    {
        public MonHocForm()
        {
            InitializeComponent();
        }

        private void monHocBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.monHocBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chap9_Baitap2DataSet);

        }

        private void MonHocForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chap9_Baitap2DataSet.MonHoc' table. You can move, or remove it, as needed.
            this.monHocTableAdapter.Fill(this.chap9_Baitap2DataSet.MonHoc);

        }
    }
}

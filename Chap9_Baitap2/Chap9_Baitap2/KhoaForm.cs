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
    public partial class KhoaForm : Form
    {
        public KhoaForm()
        {
            InitializeComponent();
        }

        private void khoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chap9_Baitap2DataSet);

        }

        private void KhoaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chap9_Baitap2DataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.chap9_Baitap2DataSet.Khoa);

        }
    }
}

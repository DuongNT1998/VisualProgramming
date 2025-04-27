using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Chap9_Baitap1
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable table;

        bool isAdding = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection((@"Data Source=localhost;Initial Catalog=Chap9_Baitap1;Integrated Security=True;TrustServerCertificate=True;"));
            adapter = new SqlDataAdapter("SELECT * FROM Products", conn);
            ds = new DataSet();
            adapter.Fill(ds,"Products");
            table = ds.Tables["Products"];

            LoadListView();
            SetControls(false);
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
        }
        private void LoadListView()
        {
            lstvDuLieuSach.Items.Clear();

            // Lặp qua tất cả các dòng trong DataSet và hiển thị vào ListView
            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(row["ProductCode"].ToString());
                item.SubItems.Add(row["Description"].ToString());
                item.SubItems.Add(row["UnitPrice"].ToString());
                item.SubItems.Add(row["OnHandQuantity"].ToString());

                lstvDuLieuSach.Items.Add(item);
            }
        }
        private void SetControls(bool enabled)
        {
            txtMaSach.Enabled = enabled;
            txtTieuDe.Enabled = enabled;
            txtGia.Enabled = enabled;
            txtSoLuong.Enabled = enabled;
        }
        private void ClearTextBoxes()
        {
            txtMaSach.Clear();
            txtTieuDe.Clear();
            txtGia.Clear();
            txtSoLuong.Clear();
        }

        private void lstvDuLieuSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvDuLieuSach.SelectedItems.Count == 0) return;

            var item = lstvDuLieuSach.SelectedItems[0];
            txtMaSach.Text = item.SubItems[0].Text;
            txtTieuDe.Text = item.SubItems[1].Text;
            txtGia.Text = item.SubItems[2].Text;
            txtSoLuong.Text = item.SubItems[3].Text;

            SetControls(false);
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ClearTextBoxes();
            SetControls(true);
            txtMaSach.Focus();

            // Kích hoạt/Làm mờ các nút
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;

      
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                DataRow newRow = table.NewRow();
                newRow["ProductCode"] = txtMaSach.Text;
                newRow["Description"] = txtTieuDe.Text;
                newRow["UnitPrice"] = decimal.Parse(txtGia.Text);
                newRow["OnHandQuantity"] = int.Parse(txtSoLuong.Text);
                table.Rows.Add(newRow);
                isAdding = false;
            }

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(ds, "Products");

         
            SetControls(false);
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadListView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstvDuLieuSach.SelectedItems.Count == 0) return;

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            string code = lstvDuLieuSach.SelectedItems[0].Text;
            DataRow[] rows = table.Select($"ProductCode = '{code}'");
            if (rows.Length > 0)
                rows[0].Delete();

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(ds, "Products");

        
            ClearTextBoxes();
            btnXoa.Enabled = false;
            LoadListView();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            SetControls(false);

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;

            isAdding = false;
            lstvDuLieuSach.Enabled = true;
        }
    }
}

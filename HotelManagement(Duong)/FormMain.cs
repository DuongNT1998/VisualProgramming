using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.DangNhap;
using HotelManagement.DichVu;
using HotelManagement.HoaDon;
using HotelManagement.KhachHang;
using HotelManagement.LoaiPhong;
using HotelManagement.NhanVien;
using HotelManagement.PhieuThue;
using HotelManagement.Phong;
using HotelManagement.SoDoPhong;
using HotelManagement.TaiKhoan;
using HotelManagement.ThongKe;
using HotelManagement.TienNghi;

namespace HotelManagement
{
    public partial class FormMain : Form
    {


        public FormMain(string tenNV)
        {
            InitializeComponent();
            lblTenNguoiDung.Text =  tenNV;  // Hiển thị tên nhân viên
        }

        private void LoadUserControl(UserControl uc)
        {
            panelMain.Controls.Clear();          // Xóa các control cũ nếu có
            uc.Dock = DockStyle.Fill;            // Cho UserControl lấp đầy panel
            panelMain.Controls.Add(uc);          // Thêm vào panel
            uc.BringToFront();                   // Đưa lên trên cùng
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormTrangChu trangChu = new FormTrangChu();  // Khởi tạo UserControl
            LoadUserControl(trangChu);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            UserControl formCon = new FormTrangChu(); // Form phụ
           
          
            formCon.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }

     

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // Ẩn FormMain
            FormDangNhap formLogin = new FormDangNhap();
            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = formLogin.Tag?.ToString();
                lblTenNguoiDung.Text = "Xin chào, " + tenDangNhap;
                this.Show(); // Hiện lại FormMain sau đăng nhập
            }
            else
            {
                this.Close(); // Nếu người dùng không đăng nhập lại thì thoát
            }
        }

        private void btnSoDoPhong_Click(object sender, EventArgs e)
        {
            Form formCon = new FormSoDoPhong(); // Form phụ
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }

        private void btnQuanLyPhong_Click(object sender, EventArgs e)
        {
            Form formCon = new FormDanhSachPhong(); // Form phụ
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formCon = new FormDanhSachLoaiPhong(); // Form phụ
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form formCon = new FormDanhSachTienNghi(); // Form phụ
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form formCon = new FormDanhSachDichVu(); // Form phụ
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formCon = new FormDanhSachKhachHang(); // Form phụ
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form formCon = new FormDanhSachNhanVien(); // Form phụ
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form formCon = new FormDanhSachPhieuThue(); // Form phụ
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form formCon = new FormDanhSachHoaDon(); // Form phụ
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form formCon = new FormThongKe(); // Form phụ
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formCon = new FormDanhSachTaiKhoan(); // Form phụ
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }
    }
}

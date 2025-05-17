using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.KetNoiCSDL;

namespace HotelManagement.DangNhap
{
    public partial class FormDangNhap : Form
    {
        public static string MaNV_DangNhap; // Biến static lưu mã nhân viên
        public FormDangNhap()
        {
            InitializeComponent();
            txtTenDangNhap.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Kiểm tra đăng nhập
            bool isValid = KiemTraDangNhap(tenDangNhap, matKhau);

            if (isValid)
            {
                this.DialogResult = DialogResult.OK;  // Không Show FormMain ở đây
                this.Close();                         // Đóng lại form login
            }
            else
            {
                // Đăng nhập không thành công, thông báo lỗi
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.");
            }
        }
        private bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
             bool isValid = false;
    SqlConnection conn = KetNoi.MoKetNoi();
    try
    {
        string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenTK = @TenTK AND Password = @Password AND DaXoa = 0";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@TenTK", tenDangNhap);
        cmd.Parameters.AddWithValue("@Password", matKhau); // Lưu ý: Mật khẩu nên được mã hóa

        int count = (int)cmd.ExecuteScalar();

        if (count > 0)
        {
            // Đăng nhập thành công, lấy mã nhân viên
            query = "SELECT MaNV FROM TaiKhoan WHERE TenTK = @TenTK AND DaXoa = 0";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TenTK", tenDangNhap);
            string maNV = (string)cmd.ExecuteScalar();  // Lấy mã nhân viên
                    MaNV_DangNhap= maNV;

            // Lấy tên nhân viên từ bảng NhanVien
            query = "SELECT TenNV FROM NhanVien WHERE MaNV = @MaNV";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaNV", maNV);
            string tenNV = (string)cmd.ExecuteScalar();  // Lấy tên nhân viên

            // Nếu tên nhân viên tồn tại, đăng nhập hợp lệ
            if (!string.IsNullOrEmpty(tenNV))
            {
                isValid = true;
                this.Tag = tenNV; // Lưu tên nhân viên vào Tag (để truyền qua FormMain)
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
    }
    finally
    {
        KetNoi.DongKetNoi(conn);
    }

    return isValid;
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick(); // Gọi sự kiện click của nút đăng nhập
            }
        }
    }
}

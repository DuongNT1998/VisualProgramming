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

namespace HotelManagement.PhieuThue
{
    public partial class FormSuaChiTietPhieuThue : Form
    {
        private string maPT;
        private string maPH;
  
        public FormSuaChiTietPhieuThue(string _maPT, string _maPH)
        {
            InitializeComponent();
            maPT = _maPT;
            maPH = _maPH;

            lbMaCTDP.Text = "Cập nhật trạng thái CTDP " + maPT;
           
            cbTrangThaiCTDP.SelectedIndex = 0;
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = KetNoi.MoKetNoi())
            {
             

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string newTrangThai = cbTrangThaiCTDP.SelectedItem.ToString();

                    // 1. Cập nhật trạng thái trong bảng CTDP
                    string updateCTDP = @"UPDATE CTDP SET TrangThai = @TrangThai 
                                  WHERE MaPT = @MaPT AND MapH = @MapH";

                    SqlCommand cmdCTDP = new SqlCommand(updateCTDP, conn, transaction);
                    cmdCTDP.Parameters.AddWithValue("@TrangThai", newTrangThai);
                    cmdCTDP.Parameters.AddWithValue("@MaPT", maPT);
                    cmdCTDP.Parameters.AddWithValue("@MapH", maPH);
                    cmdCTDP.ExecuteNonQuery();

                    // 2. Nếu trạng thái mới là "Đang thuê", cập nhật trạng thái phòng
                    if (newTrangThai == "Đang thuê")
                    {
                        string updatePhong = "UPDATE PHONG SET TTPH = N'Đang thuê' WHERE MaPH = @MaPH";
                        SqlCommand cmdPhong = new SqlCommand(updatePhong, conn, transaction);
                        cmdPhong.Parameters.AddWithValue("@MaPH", maPH);
                        cmdPhong.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

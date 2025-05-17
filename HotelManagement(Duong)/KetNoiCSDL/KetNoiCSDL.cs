using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.KetNoiCSDL
{
    public static class KetNoi
    {
        // Chuỗi kết nối đến CSDL
        private static string connectionString = @"Data Source=localhost;Initial Catalog=HotelManagement;Integrated Security=True;TrustServerCertificate=True;";

        // Hàm mở kết nối với CSDL
        public static SqlConnection MoKetNoi()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {

                conn.Open(); // Mở kết nối
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi kết nối: " + ex.Message);
                throw;
            }

            return conn;
        }

        // Hàm đóng kết nối
        public static void DongKetNoi(SqlConnection conn)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close(); // Đóng kết nối
            }
        }
    }
}

using DoAn_QuanLyBanHang.BEAN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyBanHang.DAO
{
    internal class TaiKhoanDAO
    {   

        public TaiKhoan dangnhap (String tendn, String matkhau)
        {
            KetNoi kn = new KetNoi ();
            kn.MoKetNoi();
            string sql = "SELECT * FROM [User] WHERE [User].username = @TaiKhoan AND [User].password = @MatKhau ";

            //B4 Thực hiện câu lệnh sql 
            SqlCommand cmd = new SqlCommand(sql, kn.sqlConn); // Khởi tạo SqlCommand với câu lệnh SQL và kết nối
             //Thêm tham số và giá trị tương ứng
            cmd.Parameters.AddWithValue("@TaiKhoan", tendn);
            cmd.Parameters.AddWithValue("@MatKhau", matkhau);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                /*byte[] data = (byte[])reader["username"];
                string username = Encoding.UTF8.GetString(data);
   
                string password = reader.GetString("password");
                string phanquyen = reader.GetString("phanquyen");
                return new TaiKhoan(username, password, phanquyen);*/
                string username = reader.GetString(0);
                string password = reader.GetString(1);
                string phanquyen = reader.GetString(2);
                return new TaiKhoan (username, password, phanquyen);
            }
            kn.DongKetNoi();
            return null;
            

        }
        public bool KiemTraMatKhau(string tentk,string matkhau)
        {
            KetNoi kn = new KetNoi();
            kn.MoKetNoi();
            //kiem tra mat khau dung hay sai 
            string sql = "SELECT * FROM [User] WHERE [User].username = @TaiKhoan";

            SqlCommand cmd = new SqlCommand (sql, kn.sqlConn); 
            cmd.Parameters.AddWithValue ("@TaiKhoan", tentk);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string password = reader.GetString(1);
                if (!password.Equals(matkhau))
                {
                    return true; //Tai Khoan dung mat khau sai 
                }
            }
            kn.DongKetNoi();
            return false;
           
        }
        public bool checkTaiKhoan(string tentk)
        {
            KetNoi kn = new KetNoi();
            kn.MoKetNoi();

            //Kiem tra xem tai khoan co ton tai khong 
            string checkSql = "SELECT * FROM [User] WHERE [User].username =@TaiKhoan";

            SqlCommand checkCmd = new SqlCommand(checkSql, kn.sqlConn);
            checkCmd.Parameters.AddWithValue("@TaiKhoan", tentk);

            SqlDataReader checkReader = checkCmd.ExecuteReader();

            //Kiem tra coi co du lieu trong database khong
            bool hasRows = checkReader.HasRows;
            //check matkhau sai 

            //Đóng checkReader và giải phóng checkCmd
            checkReader.Close();
            checkCmd.Dispose();

            if (hasRows)
            {
                
                return false; 
            }
            return true;
        }

        public void dangky(string tentk , string matkhau,string phanquyen)
        {
            KetNoi kn = new KetNoi();
            kn.MoKetNoi();

            string sql = "INSERT INTO [User] (username,password,phanquyen) VALUES (@TaiKhoan,@MatKhau,@PhanQuyen)";
            SqlCommand cmd = new SqlCommand(sql, kn.sqlConn);

            cmd.Parameters.AddWithValue("@TaiKhoan", tentk);
            cmd.Parameters.AddWithValue("@MatKhau", matkhau);
            cmd.Parameters.AddWithValue("@PhanQuyen", phanquyen);
            cmd.ExecuteNonQuery();
        }


       


    }
}

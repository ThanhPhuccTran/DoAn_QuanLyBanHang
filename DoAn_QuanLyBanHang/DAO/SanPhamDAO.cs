using DoAn_QuanLyBanHang.BEAN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyBanHang.DAO
{
    public class SanPhamDAO
    {

        public List<SanPham> getsanppham()
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            List<SanPham> ds = new List<SanPham>();
            string sql = "SELECT * FROM SanPham";
            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string masanpham = reader.GetString(0);
                string tensanpham = reader.GetString(1);
                string maloai = reader.GetString(2);
                int soluong = reader.GetInt32(3);
                float dongiaban = (float)reader.GetDouble(4);
                string anh = reader.GetString(5);

                ds.Add(new SanPham(masanpham, tensanpham, maloai, soluong, dongiaban, anh));
            }
            ketNoi.DongKetNoi();
            return ds;
        }

        public int soluong()
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            string sql = "Select COUNT(*) FROM SanPham";
            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);

            int count = (int)cmd.ExecuteScalar();
            ketNoi.DongKetNoi();
            return count;
        }

        public int tongsoluong()
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            string sql = "Select SUM(soluong) from SanPham";
            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);

            int count = (int)cmd.ExecuteScalar();
            ketNoi.DongKetNoi();
            return count;
        }
        public int themsp(string masanpham, string tensanpham, string maloai, int soluong, float dongiaban, string anh)
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            string sql = "INSERT INTO SanPham(masanpham,tensanpham,maloai,soluong,dongiaban,anh) VALUES (@Masanpham,@Tensanpham,@Maloai,@Soluong,@Giaban,@Anh)";
            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);
            cmd.Parameters.AddWithValue("@Masanpham", masanpham);
            cmd.Parameters.AddWithValue("@Tensanpham", tensanpham);
            cmd.Parameters.AddWithValue("@Maloai", maloai);
            cmd.Parameters.AddWithValue("@Soluong", soluong);
            cmd.Parameters.AddWithValue("@Giaban", dongiaban);
            cmd.Parameters.AddWithValue("@Anh", anh);
            /*int rs = 0;*/
            int rs = cmd.ExecuteNonQuery();
            ketNoi.DongKetNoi();
            // return rs;
            return rs;
        }
        public bool KiemTraSanPham(string masanpham)
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            string sql = "SELECT COUNT(*) FROM SanPham WHERE masanpham=@Masanpham";
            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);
            cmd.Parameters.AddWithValue("@Masanpham", masanpham);

            int count = (int)cmd.ExecuteScalar();
            ketNoi.DongKetNoi();

            if (count > 0)
                return true; // Sản phẩm tồn tại
            else
                return false; // Sản phẩm không tồn tại
        }

        public DataTable LocSanPhamTheoMaLoai(string maloai)
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            string sql = "SELECT * FROM SanPham WHERE maloai = @Maloai";
            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);
            cmd.Parameters.AddWithValue("@Maloai", maloai);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ketNoi.DongKetNoi();
            return dt;
        }


        public string getMaSanPham(string tensanpham)
        {
            string masanpham = "";
            try
            {
                KetNoi kn = new KetNoi();
                kn.MoKetNoi();
                string sql = "SELECT * FROM SanPham WHERE tensanpham = @TenSanPham";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kn.sqlConn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@TenSanPham", tensanpham);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    masanpham = reader.GetString(0);
                }
                kn.DongKetNoi();
                return masanpham;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return masanpham;
        }
        public DataTable TimKiemSanPhamTheoTen(string tensanpham)
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            string sql = "SELECT * FROM SanPham WHERE tensanpham LIKE @Tensanpham";
            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);
            cmd.Parameters.AddWithValue("@Tensanpham", "%" + tensanpham + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ketNoi.DongKetNoi();
            return dt;
        }
        public int suaSP(string masanpham, string tensanpham, string maloai, int soluong, float dongiaban, string anh)
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            string sql = "UPDATE SanPham SET tensanpham=@Tensanpham, maloai=@Maloai, soluong=@Soluong, dongiaban=@Giaban, anh=@Anh WHERE masanpham=@Masanpham";
            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);
            cmd.Parameters.AddWithValue("@Masanpham", masanpham);
            cmd.Parameters.AddWithValue("@Tensanpham", tensanpham);
            cmd.Parameters.AddWithValue("@Maloai", maloai);
            cmd.Parameters.AddWithValue("@Soluong", soluong);
            cmd.Parameters.AddWithValue("@Giaban", dongiaban);
            cmd.Parameters.AddWithValue("@Anh", anh);

            int rs = cmd.ExecuteNonQuery();
            ketNoi.DongKetNoi();
            return rs;
        }
        
        public int Xoa(string masanpham)
        {
            KetNoi kn = new KetNoi();
            kn.MoKetNoi();

            string sql = "DELETE FROM SanPham WHERE masanpham =@Masanpham";

            SqlCommand cmd = new SqlCommand(sql, kn.sqlConn);
            cmd.Parameters.AddWithValue("@Masanpham", masanpham);
            int rs = cmd.ExecuteNonQuery();
            kn.DongKetNoi();
            return rs;
        }
        public int CapNhatSoLuong(string masanpham, int soluongmoi)
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            string sql = "UPDATE SanPham SET soluong = @Soluongmoi WHERE masanpham = @Masanpham";
            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);
            cmd.Parameters.AddWithValue("@Masanpham", masanpham);
            cmd.Parameters.AddWithValue("@Soluongmoi", soluongmoi);
            int rs = cmd.ExecuteNonQuery();
            ketNoi.DongKetNoi();
            return rs;
        }


    }
}

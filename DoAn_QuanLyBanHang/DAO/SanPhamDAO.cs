using DoAn_QuanLyBanHang.BEAN;
using System;
using System.Collections.Generic;
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

            int rs = cmd.ExecuteNonQuery();
            ketNoi.DongKetNoi();
            return rs;
        }

    }
}

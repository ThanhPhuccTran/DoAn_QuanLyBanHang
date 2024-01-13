using DoAn_QuanLyBanHang.BEAN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAn_QuanLyBanHang.DAO
{
    public class ChiTietHoaDonDAO
    {
        public int ThemCTHD (string masanpham,string tensanpham,decimal soluong , decimal dongia,decimal thanhtien,long maxhd)
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            string sql = "INSERT INTO ChiTietHD (masanpham,tensanpham, soluong, dongia, thanhtien, mahdban) " +
             "VALUES ( @Masanpham,@Tensanpham, @Soluong, @Dongia, @Thanhtien, @MaHDmax)";


            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);
            cmd.Parameters.AddWithValue("@Masanpham", masanpham);
            cmd.Parameters.AddWithValue("@Tensanpham", tensanpham);
            cmd.Parameters.AddWithValue("@Soluong", soluong);
            cmd.Parameters.AddWithValue("@Dongia", dongia);
            cmd.Parameters.AddWithValue("@Thanhtien", thanhtien);
            cmd.Parameters.AddWithValue("@MaHDmax", maxhd);
            int rs = cmd.ExecuteNonQuery();
            ketNoi.DongKetNoi();
            return rs;
        }


        /*  public List<ChiTietHoaDon> getchitiet()
          {
              KetNoi ketNoi = new KetNoi();
              ketNoi.MoKetNoi();
              List<ChiTietHoaDon> ds = new List<ChiTietHoaDon>();
              string sql = "SELECT * FROM ChiTietHD";
              SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);
              SqlDataReader reader = cmd.ExecuteReader();

              while (reader.Read())
              {
                  int machitiet = reader.GetInt32(reader.GetOrdinal("machitiet"));
                  int mahdban = reader.GetInt32(reader.GetOrdinal("mahdban"));
                  string masanpham = reader.GetString(reader.GetOrdinal("masanpham"));
                  string tensanpham = reader.GetString(reader.GetOrdinal("tensanpham"));
                  decimal soluong = reader.GetDecimal(reader.GetOrdinal("soluong"));
                  decimal donggia = reader.GetDecimal(reader.GetOrdinal("donggia"));
                  decimal thanhtien = reader.GetDecimal(reader.GetOrdinal("thanhtien"));

                  ChiTietHoaDon cthd = new ChiTietHoaDon(machitiet, mahdban, masanpham, soluong, donggia, thanhtien);
                  ds.Add(cthd);
              }
              ketNoi.DongKetNoi();
              return ds;
          }*/

        public decimal doanhthu()
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            string sql = "select SUM(thanhtien) from ChiTietHD";
            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);

            decimal total = (decimal)cmd.ExecuteScalar();
            ketNoi.DongKetNoi();
            return total;
        }
        public List<ChiTietHoaDon> GetSanPhamTheoGia(int mahd)
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            List<ChiTietHoaDon> ds = new List<ChiTietHoaDon>();
            string sql = "SELECT * FROM ChiTietHD WHERE mahdban = @MaHD";
            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);
            cmd.Parameters.AddWithValue("@MaHD", mahd);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int machitiet = reader.GetInt32(0);
                string masanpham = reader.GetString(1);
                int mahdban = reader.GetInt32(2);
                string tensanpham = reader.GetString(3);
                decimal soluong = reader.GetDecimal(4);
                decimal donggia = reader.GetDecimal(5);
                decimal thanhtien = reader.GetDecimal(6);

                ChiTietHoaDon cthd = new ChiTietHoaDon(machitiet,masanpham, mahdban, tensanpham, soluong, donggia, thanhtien);
                ds.Add(cthd);
            }
            ketNoi.DongKetNoi();
            return ds;
        }




    }
}

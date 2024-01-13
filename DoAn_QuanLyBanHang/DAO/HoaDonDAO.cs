using DoAn_QuanLyBanHang.BEAN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyBanHang.DAO
{
    public class HoaDonDAO
    {
        public int ThemHoaDon(string manhanvien , DateTime ngayban )
        {
            KetNoi kn = new KetNoi();
            kn.MoKetNoi();

            string sql = "INSERT INTO HDBan(manhanvien,ngayban) VALUES (@Manhanvien, @Ngayban); SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(sql, kn.sqlConn);

            cmd.Parameters.AddWithValue("@Manhanvien", manhanvien);
            cmd.Parameters.AddWithValue("@Ngayban", ngayban);
            int maHDMax = Convert.ToInt32(cmd.ExecuteScalar());
            /*int rs = cmd.ExecuteNonQuery();*/
            kn.DongKetNoi();
            return maHDMax;
        }
        public void Capnhatsoluong(int sl , string ten)
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            string sql = "UPDATE SanPham SET soluong = soluong - @soluong WHERE tensanpham = @Tensanpham";
            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);
            // Thêm tham số vào câu lệnh SQL
            cmd.Parameters.AddWithValue("@soluong", sl);
            cmd.Parameters.AddWithValue("@tenSanPham", ten);
            cmd.ExecuteNonQuery();
            ketNoi.DongKetNoi();
        }
        public List<HoaDon> gethoadon()
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            List<HoaDon> ds = new List<HoaDon>();
            string sql = "SELECT * FROM HDBan";
            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int mahdban = reader.GetInt32(0);
                string manhanvien = reader.GetString(1);
                DateTime ngayban = reader.GetDateTime(2);

                ds.Add(new HoaDon(mahdban,manhanvien,ngayban));
            }
            ketNoi.DongKetNoi();
            return ds;
        }

        public DataTable TimHoaDonTheoNgay(DateTime ngay)
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            string sql = "SELECT * FROM HDBan WHERE ngayban = @Ngayban";
            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);
            cmd.Parameters.AddWithValue("@Ngayban", ngay);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ketNoi.DongKetNoi();
            return dt;
        }
    }
}

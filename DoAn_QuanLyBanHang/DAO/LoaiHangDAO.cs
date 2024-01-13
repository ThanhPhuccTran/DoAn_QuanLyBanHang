using DoAn_QuanLyBanHang.BEAN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyBanHang.DAO
{
    public class LoaiHangDAO
    {

        // hien thi danh sach
        public List<LoaiHang> getloai()
        {
            KetNoi kn = new KetNoi();
            kn.MoKetNoi();

            string sql = "SELECT * FROM LoaiHang ";

            SqlCommand cmd = new SqlCommand(sql, kn.sqlConn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<LoaiHang> ds = new List<LoaiHang>();
            while (reader.Read())
            {
                string maloai = reader.GetString(0);
                string tenloai = reader.GetString(1);
                ds.Add(new LoaiHang(maloai, tenloai));
            }
            kn.DongKetNoi();
            return ds;
        }
        //check trung ma 
        public Boolean check(string maloai)
        {
            KetNoi kn = new KetNoi();
            kn.MoKetNoi();
            string sql = "SELECT * FROM LoaiHang WHERE maloai = @Maloai";
            SqlCommand cmd = new SqlCommand(sql, kn.sqlConn);
            cmd.Parameters.AddWithValue("@Maloai", maloai);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return true; // ml ton tai
            }

            return false;
        }
        //lay ten loai
        public string LayTenLoai(string maloai)
        {
            KetNoi kn = new KetNoi();
            kn.MoKetNoi();

            string sql = "SELECT tenloai FROM LoaiHang WHERE maloai = @MaHang";
            SqlCommand cmd = new SqlCommand(sql, kn.sqlConn);
            cmd.Parameters.AddWithValue("@MaHang", maloai);

            SqlDataReader reader = cmd.ExecuteReader();
            string tenloai = "";
            if (reader.Read())
            {
                tenloai = reader["tenloai"].ToString();
            }

            kn.DongKetNoi();
            return tenloai;
        }
        public int ThemLoai(string maloai, string tenloai)
        {
            KetNoi kn = new KetNoi();
            kn.MoKetNoi();


            string sql = "INSERT INTO LoaiHang(maloai,tenloai) VALUES (@MaHang,@Tenloai) ";
            SqlCommand cmd = new SqlCommand(sql, kn.sqlConn);
            /*SqlDataReader reader = cmd.ExecuteReader();*/
            cmd.Parameters.AddWithValue("@MaHang", maloai);
            cmd.Parameters.AddWithValue("@Tenloai", tenloai);
            int rs = cmd.ExecuteNonQuery();
            kn.DongKetNoi();
            return rs;
        }


        public int SuaLoai(string maloai, string tenloaimoi)
        {
            KetNoi kn = new KetNoi();
            kn.MoKetNoi();

            string sql = "UPDATE LoaiHang SET tenloai = @Tenloai where maloai = @Maloai";
            SqlCommand cmd = new SqlCommand(sql, kn.sqlConn);
            cmd.Parameters.AddWithValue("@Maloai", maloai);
            cmd.Parameters.AddWithValue("@Tenloai", tenloaimoi);

            int rs = cmd.ExecuteNonQuery();
            kn.DongKetNoi();
            return rs;
        }
        

        public int Xoa(string maloai )
        {
            KetNoi kn = new KetNoi();
            kn.MoKetNoi();

            string sql = "DELETE FROM LoaiHang WHERE maloai = @Maloai";

            SqlCommand cmd = new SqlCommand(sql, kn.sqlConn);
            cmd.Parameters.AddWithValue("@Maloai", maloai);
            int rs = cmd.ExecuteNonQuery();
            kn.DongKetNoi();
            return rs;
        }

    }
}

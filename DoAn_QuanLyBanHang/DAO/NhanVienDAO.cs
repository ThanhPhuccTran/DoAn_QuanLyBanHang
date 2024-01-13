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
    public class NhanVienDAO
    {
        public List<NhanVien> getnhanvien()
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            List<NhanVien> ds = new List<NhanVien>();
            string sql = "SELECT * FROM NhanVien";
            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string manhanvien = reader.GetString(0);
                string tennhanvien = reader.GetString(1);
                string gioitinh = reader.GetString(2);
                string diachi = reader.GetString(3);
                string dienthoai = reader.GetString(4);
                DateTime ngaysinh = reader.GetDateTime(5);

                ds.Add(new NhanVien(manhanvien, tennhanvien, gioitinh, diachi, dienthoai, ngaysinh));
            }
            ketNoi.DongKetNoi();
            return ds;
        }
        public int soluong()
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            string sql = "Select COUNT(*) FROM NhanVien";
            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);

            int count = (int)cmd.ExecuteScalar();
            ketNoi.DongKetNoi();
            return count;
        }
        // Thêm nhân viên
        public int ThemNhanVien(string manhanvien, string tennhanvien, string gioitinh, string diachi, string dienthoai, DateTime ngaysinh)
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            string sql = "INSERT INTO NhanVien(manhanvien,tennhanvien,gioitinh,diachi,dienthoai,ngaysinh) VALUES (@MaNhanVien,@TenNhanVien,@GioiTinh,@Diachi,@DienThoai,@NgaySinh)";
            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);
            // Thêm các tham số vào câu lệnh SQL
            cmd.Parameters.AddWithValue("@MaNhanVien", manhanvien);
            cmd.Parameters.AddWithValue("@TenNhanVien", tennhanvien);
            cmd.Parameters.AddWithValue("@GioiTinh", gioitinh);
            cmd.Parameters.AddWithValue("@Diachi", diachi);
            cmd.Parameters.AddWithValue("@DienThoai", dienthoai);
            cmd.Parameters.AddWithValue("@NgaySinh", ngaysinh);
            int result = cmd.ExecuteNonQuery();
            ketNoi.DongKetNoi();
            return result; // Trả về số lượng bản ghi được thêm
        }

        // Sửa nhân viên
        public int SuaNhanVien(string manhanvien, string tennhanvien, string gioitinh, string diachi, string dienthoai, DateTime ngaysinh)
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            string sql = "UPDATE NhanVien SET tennhanvien=@TenNhanVien, gioitinh=@GioiTinh, diachi=@Diachi, dienthoai=@DienThoai, ngaysinh=@NgaySinh WHERE manhanvien=@MaNhanVien";
            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);
            // Thêm các tham số vào câu lệnh SQL
            cmd.Parameters.AddWithValue("@MaNhanVien", manhanvien);
            cmd.Parameters.AddWithValue("@TenNhanVien", tennhanvien);
            cmd.Parameters.AddWithValue("@GioiTinh", gioitinh);
            cmd.Parameters.AddWithValue("@Diachi", diachi);
            cmd.Parameters.AddWithValue("@DienThoai", dienthoai);
            cmd.Parameters.AddWithValue("@NgaySinh", ngaysinh);
            int result = cmd.ExecuteNonQuery();
            ketNoi.DongKetNoi();
            return result; // Trả về số lượng bản ghi được sửa
        }

        // Xóa nhân viên
        public int XoaNhanVien(string manhanvien)
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            string sql = "DELETE FROM NhanVien WHERE manhanvien=@MaNhanVien";
            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);
            // Thêm các tham số vào câu lệnh SQL
            cmd.Parameters.AddWithValue("@MaNhanVien", manhanvien);
            int result = cmd.ExecuteNonQuery();
            ketNoi.DongKetNoi();
            return result; // Trả về số lượng bản ghi được xóa
        }

        // Kiểm tra nhân viên theo mã nhân viên
        public bool KiemTraNhanVien(string manhanvien)
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE manhanvien=@Manhanvien";
            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);
            cmd.Parameters.AddWithValue("@Manhanvien", manhanvien);

            int count = (int)cmd.ExecuteScalar();
            ketNoi.DongKetNoi();

            if (count > 0)
                return true; // Nhân viên tồn tại
            else
                return false; // Nhân viên không tồn tại
        }

        // Tìm kiếm nhân viên theo tên
        public DataTable TimKiemNhanVienTheoTen(string tennhanvien)
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            string sql = "SELECT * FROM NhanVien WHERE tennhanvien LIKE @Tennhanvien";
            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);
            cmd.Parameters.AddWithValue("@Tennhanvien", "%" + tennhanvien + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ketNoi.DongKetNoi();
            return dt;
        }

        // Lọc nhân viên theo giới tính
        public DataTable LocNhanVienTheoGioiTinh(string gioitinh)
        {
            KetNoi ketNoi = new KetNoi();
            ketNoi.MoKetNoi();
            string sql = "SELECT * FROM NhanVien WHERE gioitinh = @Gioitinh";
            SqlCommand cmd = new SqlCommand(sql, ketNoi.sqlConn);
            cmd.Parameters.AddWithValue("@Gioitinh", gioitinh);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ketNoi.DongKetNoi();
            return dt;
        }
    }
}

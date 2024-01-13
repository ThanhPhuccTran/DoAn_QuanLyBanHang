using DoAn_QuanLyBanHang.BEAN;
using DoAn_QuanLyBanHang.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyBanHang.BO
{
    public class NhanVienBO
    {
        NhanVienDAO nvbo = new NhanVienDAO();
        List<NhanVien> ds;

        public List<NhanVien> getnhanvien()
        {
           ds = nvbo.getnhanvien();
            return ds;
        }

        public int ThemNhanVien(string manhanvien, string tennhanvien, string gioitinh, string diachi, string dienthoai, DateTime ngaysinh)
        {
            return nvbo.ThemNhanVien(manhanvien, tennhanvien, gioitinh, diachi, dienthoai, ngaysinh);
        }

        public int SuaNhanVien(string manhanvien, string tennhanvien, string gioitinh, string diachi, string dienthoai, DateTime ngaysinh)
        {
            return nvbo.SuaNhanVien(manhanvien, tennhanvien, gioitinh, diachi, dienthoai, ngaysinh);
        }

        public int XoaNhanVien(string manhanvien)
        {
            return nvbo.XoaNhanVien(manhanvien);
        }
        public bool KiemTraNhanVien(string manhanvien)
        {
            return nvbo.KiemTraNhanVien(manhanvien);
        }

        public DataTable TimKiemNhanVienTheoTen(string tennhanvien)
        {
            return nvbo.TimKiemNhanVienTheoTen(tennhanvien);
        }
        public DataTable LocNhanVienTheoGioiTinh(string gioitinh)
        {
            return nvbo.LocNhanVienTheoGioiTinh(gioitinh);
        }

        public int soluong()
        { 
            return nvbo.soluong();
        }
        }
}

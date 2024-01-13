using DoAn_QuanLyBanHang.BEAN;
using DoAn_QuanLyBanHang.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyBanHang.BO
{
    public class SanPhamBO
    {
        SanPhamDAO spdao = new SanPhamDAO();
        List<SanPham> ds;

        public List<SanPham> getsanpham()
        {
            ds = spdao.getsanppham();
            return ds;
        }

        public int ThemSanPham(string masanpham, string tensanpham, string maloai, int soluong, float dongiaban, string anh)
        {
            return spdao.themsp( masanpham,  tensanpham,  maloai,  soluong, dongiaban,  anh);
        }

        public int SuaSanPham(string masanpham, string tensanpham, string maloai, int soluong, float dongiaban, string anh)
        {
            return spdao.suaSP(masanpham, tensanpham, maloai, soluong, dongiaban, anh);
        }

        public int XoaSanPham(string masanpham)
        {
            return spdao.Xoa(masanpham);
        }
        public bool KiemTraSanPham(string masanpham)
        {
            return spdao.KiemTraSanPham(masanpham);
        }

        public DataTable LocSanPhamTheoMaLoai(string maloai)
        {
            return spdao.LocSanPhamTheoMaLoai(maloai);
        }
        public DataTable TimKiemSanPhamTheoTen(string tensanpham)
        {
            return spdao.TimKiemSanPhamTheoTen(tensanpham);
        }
        public int CapNhatSoLuong(string masanpham, int soluongmoi)
        {
            return spdao.CapNhatSoLuong(masanpham, soluongmoi);
        }

        public string getMaSanPham(string tensanpham)
        {
            return spdao.getMaSanPham(tensanpham);
        }

        public int soluong()
        {
            return spdao.soluong();
        }


        public int tongsoluong()
        {
            return spdao.tongsoluong();
        }
        }
}

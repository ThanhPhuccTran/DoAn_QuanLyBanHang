using DoAn_QuanLyBanHang.BEAN;
using DoAn_QuanLyBanHang.DAO;
using System;
using System.Collections.Generic;
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
    }
}

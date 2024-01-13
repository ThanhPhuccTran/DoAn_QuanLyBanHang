using DoAn_QuanLyBanHang.BEAN;
using DoAn_QuanLyBanHang.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyBanHang.BO
{
    public class ChiTietHoaDonBO
    {
        ChiTietHoaDonDAO dao = new ChiTietHoaDonDAO();
        List<ChiTietHoaDon> ds;
        public int ThemCTHD( string masanpham,string tensanpham, decimal soluong, decimal dongia, decimal thanhtien, long maxhd)
        {
            int rs = dao.ThemCTHD(masanpham,tensanpham,  soluong, dongia,  thanhtien, maxhd);
            return rs;
        }

        public List<ChiTietHoaDon> getchitiet(int mahd)
        {
            ds = dao.GetSanPhamTheoGia(mahd);
            return ds;
        }

        public decimal doanhthu()
        {
            return dao.doanhthu();
        }
    }
}

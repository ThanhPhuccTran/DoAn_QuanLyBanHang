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
    public class HoaDonBO
    {
        HoaDonDAO hddao = new HoaDonDAO();
        List<HoaDon> ds;
        public int ThemHD (string manhanvien,DateTime ngayban)
        {
            return hddao.ThemHoaDon(manhanvien,ngayban);
        }

        public List<HoaDon> gethoadon()
        {
            ds = hddao.gethoadon();
            return ds;
        }

        public void Capnhatsoluong(int sl, string ten)
        {
            hddao.Capnhatsoluong(sl, ten);
        }

        public DataTable TimHoaDonTheoNgay(DateTime ngay)
        {
            return hddao.TimHoaDonTheoNgay(ngay);
        }
        }
}

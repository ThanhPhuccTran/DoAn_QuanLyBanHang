using DoAn_QuanLyBanHang.BEAN;
using DoAn_QuanLyBanHang.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyBanHang.BO
{
    public class LoaiHangBO
    {
        LoaiHangDAO loaibo = new LoaiHangDAO();
        List<LoaiHang> ds;
        public List<LoaiHang> getloai()
        {
            ds = loaibo.getloai();
            return ds;
        }

        public int ThemLoai (string maloai , string tenloai)
        {
            return loaibo.ThemLoai(maloai , tenloai);
        }

        public bool check (string maloai)
        {
            return loaibo.check(maloai);
        }

        public int SuaLoai (string maloai,string tenloaimoi)
        {
            return loaibo.SuaLoai(maloai , tenloaimoi);
        }

        public int Xoaloai(string maloai)
        {
            return loaibo.Xoa(maloai);
        }
        public string TenLoai(string maloai)
        {
            return loaibo.LayTenLoai(maloai);
        }
    }
}

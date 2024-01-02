using DoAn_QuanLyBanHang.BEAN;
using DoAn_QuanLyBanHang.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyBanHang.BO
{
    public class TaiKhoanBo
    {
        TaiKhoanDAO tkdao = new TaiKhoanDAO();
        public TaiKhoan dangnhap(string username, string password)
        {
            return tkdao.dangnhap(username, password);
        }

        public bool checkTaiKhoan(string username)
        {
            return tkdao.checkTaiKhoan(username);
        }

        public void dangky(String username,String password,String phanquyen)
        {
             tkdao.dangky(username, password,phanquyen);
        }

        public bool checkmatkhau(string taikhoan , string matkhau)
        {
            return tkdao.KiemTraMatKhau(taikhoan, matkhau);
        }

    }
}

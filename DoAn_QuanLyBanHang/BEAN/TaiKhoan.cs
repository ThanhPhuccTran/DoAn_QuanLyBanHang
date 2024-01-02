using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyBanHang.BEAN
{
    public class TaiKhoan
    {

       public string username {  get; set; }
       public  string password { get; set; }
       public  string phanquyen { get; set; }
        
       public TaiKhoan(string username,string password,string phanquyen)
        {
            this.username = username;
            this.password = password;
            this.phanquyen = phanquyen;
        }

       /* override
        public string toString()
        {
            return "TaiKhoan [username=" + username + ",password=" + password + ",phanquyen=" + phanquyen + "]";
        }*/
    }
}

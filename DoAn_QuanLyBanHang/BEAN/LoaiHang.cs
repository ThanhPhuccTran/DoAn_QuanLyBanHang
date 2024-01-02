using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyBanHang.BEAN
{
    public class LoaiHang
    {
        public LoaiHang() { }
        public string maloai { get; set; }
        public string tenloai { get; set; }

        public LoaiHang(string maloai, string tenloai)
        {
            this.maloai = maloai;
            this.tenloai = tenloai;
        }

        /* public string toString()
         {
             return "LoaiHang [maloai="+maloai +", tenloai = "+tenloai +"]";
         }*/
        public override string ToString()
        {
            return tenloai;
        }
    }
}

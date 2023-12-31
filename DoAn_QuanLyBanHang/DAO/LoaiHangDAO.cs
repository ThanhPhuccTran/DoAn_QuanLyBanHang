using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyBanHang.DAO
{
    public class LoaiHangDAO
    {
        public LoaiHangDAO() { }
        public string maloai {  get; set; }
        public string tenloai { get; set; }

        public LoaiHangDAO(string maloai, string tenloai)
        {
            this.maloai = maloai;
            this.tenloai = tenloai;
        }


    }
}

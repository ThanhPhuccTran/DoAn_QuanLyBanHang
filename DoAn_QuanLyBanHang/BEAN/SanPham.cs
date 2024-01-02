using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyBanHang.BEAN
{
    public class SanPham
    {
        public string masanpham {  get; set; }
        public string tensanpham { get; set; }
        public string maloai {  get; set; }
        public int soluong { get; set; }
        public float dongiaban { get; set; }
        public string anh {  get; set; }

        public SanPham() { }
        public SanPham(string masanpham, string tensanpham, string maloai, int soluong, float dongiaban, string anh)
        {
            this.masanpham = masanpham;
            this.tensanpham = tensanpham;
            this.maloai = maloai;
            this.soluong = soluong;
            this.dongiaban = dongiaban;
            this.anh = anh;
        }


    }
}

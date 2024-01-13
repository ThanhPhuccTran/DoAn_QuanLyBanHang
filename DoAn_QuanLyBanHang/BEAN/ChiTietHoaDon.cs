using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyBanHang.BEAN
{
    public class ChiTietHoaDon
    {

        public int machitiet { get; set; }
        public int mahdban { get; set; }
        public string masanpham { get; set; }
        public string tensanpham { get; set; }
        public decimal soluong { get; set; }
        public decimal dongia { get; set; }
        public decimal thanhtien { get; set; }


        public ChiTietHoaDon() { }
        public ChiTietHoaDon(int machitiet, string masanpham, int mahdban,string tensanpham,decimal soluong, decimal dongia, decimal thanhtien)
        {
            this.machitiet = machitiet;
            this.mahdban = mahdban;
            this.masanpham = masanpham;
            this.soluong = soluong;
            this.tensanpham = tensanpham;
            this.dongia = dongia;
            this.thanhtien = thanhtien;
        }
    }
}

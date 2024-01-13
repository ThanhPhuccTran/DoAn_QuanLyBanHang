using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyBanHang.BEAN
{
    public class HoaDon
    {
        public int mahdban {  get; set; }
        public string manhanvien { get; set; }

        public DateTime ngayban {  get; set; }
        public HoaDon() { }
        public HoaDon (int mahdban, string manhanvien, DateTime ngayban)
        {
            this.mahdban = mahdban;
            this.manhanvien = manhanvien;
            this.ngayban = ngayban;
        }
        public override string ToString()
        {
            return $"{ngayban.ToShortDateString()}";
        }
    }
}

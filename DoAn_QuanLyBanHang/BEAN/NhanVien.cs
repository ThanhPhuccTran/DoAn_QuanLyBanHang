using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyBanHang.BEAN
{
    public class NhanVien
    {
       public string manhanvien {  get; set; }
       public string tennhanvien { get; set; }
       public string gioitinh {  get; set; }
       public string diachi { get; set; }
       public string dienthoai { get; set; }
       public DateTime ngaysinh { get; set; }

        public  NhanVien()
        {

        }
        public NhanVien(string manhanvien, string tennhanvien, string gioitinh, string diachi, string dienthoai, DateTime ngaysinh)
        {
            this.manhanvien = manhanvien;
            this.tennhanvien = tennhanvien;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
            this.ngaysinh = ngaysinh;
        }
    }
}

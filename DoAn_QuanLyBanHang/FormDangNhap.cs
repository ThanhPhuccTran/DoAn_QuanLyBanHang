using DoAn_QuanLyBanHang.BEAN;
using DoAn_QuanLyBanHang.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyBanHang
{
    public partial class FormDangNhap : Form
    {
        TaiKhoanBo tkbo = new TaiKhoanBo();
        public static TaiKhoan taikhoan = null;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String tendn = txtTaiKhoan.Text;
            String matkhau = txtMatKhau.Text;

            if (string.IsNullOrEmpty(tendn) || string.IsNullOrEmpty(matkhau))
            {
                MessageBox.Show("Bạn cần phải nhập đầy đủ thông tin!");
            }
            else
            {
                //kiem tra mat khau sai 
                bool kiemtra = tkbo.checkmatkhau(tendn,matkhau);
                if (kiemtra == true)
                {
                    MessageBox.Show("Mật khẩu của bạn đã sai ");
                }
                else
                {
                     taikhoan = tkbo.dangnhap(tendn, matkhau);
                    if (taikhoan != null)
                    {   
                        if(taikhoan.phanquyen == "0") {
                            MessageBox.Show("Đăng nhập thành công");
                            Hide();
                            var f = new FormMain();
                            f.ShowDialog();
                        }
                        else
                            if(taikhoan.phanquyen == "1"){
                            Hide();
                            var f = new FormcuaNhanVien();
                            f.ShowDialog();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Đang nhập thất bại");
                    }

                }


        }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            var f = new FormDangKy();
            f.ShowDialog();
        }
    }
}

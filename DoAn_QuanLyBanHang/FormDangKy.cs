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
    public partial class FormDangKy : Form
    {
        TaiKhoanBo tkbo = new TaiKhoanBo();
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tendky = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            string phanquyen = radioButton1.Checked ? "1" : "0";
            if (string.IsNullOrEmpty(tendky) || string.IsNullOrEmpty(matkhau))
            {
                MessageBox.Show("Bạn cần phải nhập đầy đủ thông tin!");
            }
            else
            {
                bool taiKhoan = tkbo.checkTaiKhoan(tendky);
                if (taiKhoan == true)
                {
                    tkbo.dangky(tendky, matkhau, phanquyen);
                    MessageBox.Show("Đăng ký thành công");

                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!");
                }
                

               /* //Dang Ky

                string sql = "INSERT INTO [User] (username,password,phanquyen) VALUES (@TaiKhoan,@MatKhau,@PhanQuyen)";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.AddWithValue("@TaiKhoan", tendky);
                cmd.Parameters.AddWithValue("@MatKhau", matkhau);
                cmd.Parameters.AddWithValue("@PhanQuyen", 1);

                int rowsAdded = cmd.ExecuteNonQuery();
                if (rowsAdded > 0)
                {
                    MessageBox.Show("Đăng ký thành công!");
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại!");
                }

                if (sqlConn.State != ConnectionState.Closed)
                {
                    sqlConn.Close();
                    sqlConn.Dispose();
                    cmd.Dispose();
                }*/

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            var f = new FormDangNhap();
            f.ShowDialog();
        }
    }
}

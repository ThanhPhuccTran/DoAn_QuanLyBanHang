using DoAn_QuanLyBanHang.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyBanHang
{
    
    public partial class FormThongke : Form
    {
        SanPhamBO spbo = new SanPhamBO();
        NhanVienBO nvbo = new NhanVienBO();
        ChiTietHoaDonBO ctbo = new ChiTietHoaDonBO();
        public FormThongke()
        {
            InitializeComponent();
            int soluong = spbo.soluong();
            txtSanpham.Text = soluong.ToString();
            int soluongnv = nvbo.soluong();
            txtnhanvien.Text = soluongnv.ToString();

            decimal doanthu = ctbo.doanhthu();
            txtDoanhthu.Text = doanthu.ToString("N0");

            int tongsoluong = spbo.tongsoluong();

            txtSoluong.Text = tongsoluong.ToString();
            timer1.Start();
        }

        private void txtSanpham_Click(object sender, EventArgs e)
        {
           
        }

        private void FormThongke_Load(object sender, EventArgs e)
        {

        }
        private void LoaiSanPham_Click(object sender, EventArgs e)
        {
            FormMain fd = new FormMain();
            fd.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormSanPham fd = new FormSanPham();
            fd.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FrmNhanVien fd = new FrmNhanVien();
            fd.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormDangNhap fd = new FormDangNhap();
            fd.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            /*FormDangNhap fd = new FormDangNhap();
            fd.Show();
            this.Hide();*/
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormQuanLyHoaDon fd  = new FormQuanLyHoaDon();
            fd.Show();
            this.Hide();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}

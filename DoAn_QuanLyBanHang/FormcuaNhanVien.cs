using DoAn_QuanLyBanHang.BEAN;
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
    public partial class FormcuaNhanVien : Form
    {
        SanPhamBO sp = new SanPhamBO();

        public FormcuaNhanVien()
        {
            InitializeComponent();
        }

        private void FormcuaNhanVien_Load(object sender, EventArgs e)
        {
            capnhatbang();
        }

        public void capnhatbang()
        {
            frmSanPham.DataSource = sp.getsanpham();
            frmSanPham.Columns[4].DefaultCellStyle.Format = "F0";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormcuaNhanVien fm = new FormcuaNhanVien();
            fm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormHoaDonNV fm = new FormHoaDonNV();
            fm.Show();
            this.Hide();
        }
    }
}

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
    public partial class FormChiTietHD : Form
    {
       /* ChiTietHoaDonBO*/

        

        ChiTietHoaDonBO ctbo = new ChiTietHoaDonBO();
        public int mahdban { get; set;}
        public FormChiTietHD()
        {
            
            InitializeComponent();

        }

        private void FormChiTietHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BanHang_DienTuDataSet4.ChiTietHD' table. You can move, or remove it, as needed.
            this.chiTietHDTableAdapter.Fill(this.qL_BanHang_DienTuDataSet4.ChiTietHD);
            HienthiSanPham();

        }

        public void HienthiSanPham()
        {
            //MessageBox.Show("hhi" + mahdban);
            grdChiTiet.DataSource = ctbo.getchitiet(mahdban);
        }

        private void grdChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormQuanLyHoaDon ct = new FormQuanLyHoaDon();
            ct.Show();
            this.Hide();
        }
    }
}

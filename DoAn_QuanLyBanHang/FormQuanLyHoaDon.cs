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
    public partial class FormQuanLyHoaDon : Form
    {
        HoaDonBO hd = new HoaDonBO();
        ChiTietHoaDonBO ct = new ChiTietHoaDonBO();
    
        public FormQuanLyHoaDon()
        {
            InitializeComponent();
            
            
        }

        private void FormQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BanHang_DienTuDataSet3.HDBan' table. You can move, or remove it, as needed.
            this.hDBanTableAdapter.Fill(this.qL_BanHang_DienTuDataSet3.HDBan);

            Capnhat();
            var dsngay = hd.gethoadon();
            foreach(var ngay in dsngay)
            {
                cbxLoc.Items.Add(new HoaDon {mahdban = ngay.mahdban,manhanvien=ngay.manhanvien,ngayban = ngay.ngayban});
            }
            timer1.Start();

        }
        private void Loc()
        {
            DateTime ngay = ((HoaDon)cbxLoc.SelectedItem).ngayban;
            DataTable dt = hd.TimHoaDonTheoNgay(ngay);
            grdHoaDon.DataSource = dt;
        }
        private void Capnhat()
        {
            grdHoaDon.DataSource = hd.gethoadon();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void grdHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = grdHoaDon.CurrentRow;
            if(currentRow != null)
            {
                int mahdban = (int)currentRow.Cells[0].Value;
                FormChiTietHD ct = new FormChiTietHD();
                ct.mahdban = mahdban;
                ct.Show();
                this.Hide();

            }
        }

        private void grdHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLoc.SelectedItem != null)
            {
                Loc();
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào ", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormDangNhap fd = new FormDangNhap();
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

        private void label6_Click(object sender, EventArgs e)
        {
            FormThongke fd = new FormThongke();
            fd.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            /*FormDangNhap fd = new FormDangNhap();
            fd.Show();
            this.Hide();*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}

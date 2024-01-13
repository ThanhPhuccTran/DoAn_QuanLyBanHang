using DoAn_QuanLyBanHang.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DoAn_QuanLyBanHang
{
    public partial class FormMain : Form
    {
        LoaiHangBO loaibo = new LoaiHangBO();
        
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BanHang_DienTuDataSet.LoaiHang' table. You can move, or remove it, as needed.
            this.loaiHangTableAdapter.Fill(this.qL_BanHang_DienTuDataSet.LoaiHang);
            capnhatbang();
            timer1.Start();
        }

        private void capnhatbang()
        {
            grdDanhSach.DataSource = loaibo.getloai();
        }
        private void ClearAll()
        {
            txtMaloai.Clear();
            txtTenLoai.Clear();
        }
        
        private void label5_Click(object sender, EventArgs e)
        {
            FrmNhanVien fd = new FrmNhanVien();
            fd.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maloai = txtMaloai.Text;
            string tenloai = txtTenLoai.Text;

            if (maloai == "" || tenloai == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Trống", MessageBoxButtons.OK);

            }
            else
            {
                bool kt = loaibo.check(maloai);
                if (kt == true)
                {
                    MessageBox.Show("Mã loại đã tồn tại !", "Thất bại", MessageBoxButtons.OK);
                }
                else { 
                        int them = loaibo.ThemLoai(maloai, tenloai);
                    if (them > 0)
                    {
                        MessageBox.Show("Thêm thành công !", "Thành Công", MessageBoxButtons.OK);
                        capnhatbang();
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Thêm loại hàng thất bại!", "Thất bại", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void grdDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaloai.Text = grdDanhSach.SelectedRows[0].Cells[0].Value.ToString();
            txtTenLoai.Text = grdDanhSach.SelectedRows[0].Cells[1].Value.ToString();
            //dell cho nhap maloai
            txtMaloai.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maloai = txtMaloai.Text;
            string tenloai = txtTenLoai.Text;
           
            int sua = loaibo.SuaLoai(maloai, tenloai);
            if(sua>0)
            {
                MessageBox.Show("Sửa thành công !", "Thành Công", MessageBoxButtons.OK);
                capnhatbang();
                ClearAll();
            }
            else
            {
                MessageBox.Show("Sửa loại hàng thất bại!", "Thất bại", MessageBoxButtons.OK);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //dell cho nhap maloai
            txtMaloai.Enabled = true;
            capnhatbang();
            ClearAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maloai = txtMaloai.Text;
            if (MessageBox.Show("Bạn có muốn xóa loại này không?","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int xoa = loaibo.Xoaloai(maloai);
                if (xoa>0)
                {
                    MessageBox.Show("Xóa thành công !!!", "Thành Công", MessageBoxButtons.OK);
                    capnhatbang();
                    ClearAll();
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormSanPham fd = new FormSanPham();
            fd.Show();
            this.Hide();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormQuanLyHoaDon fd = new FormQuanLyHoaDon();
            fd.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FormThongke fd = new FormThongke();
            fd.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormDangNhap fd = new FormDangNhap();
            fd.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

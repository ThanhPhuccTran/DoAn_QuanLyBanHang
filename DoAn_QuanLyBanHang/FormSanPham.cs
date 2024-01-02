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
    public partial class FormSanPham : Form
    {   
        SanPhamBO sp = new SanPhamBO();
        LoaiHangBO loai = new LoaiHangBO();
        public FormSanPham()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void LoaiSanPham_Click(object sender, EventArgs e)
        {
            FormMain fm = new FormMain();
            fm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BanHang_DienTuDataSet.LoaiHang' table. You can move, or remove it, as needed.
            this.loaiHangTableAdapter.Fill(this.qL_BanHang_DienTuDataSet.LoaiHang);
            capnhatbang();

            var dsloai = loai.getloai();
            foreach(var loaihang in dsloai)
            {
                cbxLoai.Items.Add(new LoaiHang { tenloai = loaihang.tenloai,maloai = loaihang.maloai});
            }

        }

        private void lblTime_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                imageAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }
        public void capnhatbang()
        {
            grdSanPham.DataSource = sp.getsanpham();
        }

        private void ClearAll()
        {
            txtMasp.Clear();
            txtTensp.Clear();
            txtAnh.Clear();
            txtGia.Clear();
            txtsoluong.Clear();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string masanpham = txtMasp.Text;
            string tensanpham = txtTensp.Text;
            string maloai = ((LoaiHang)cbxLoai.SelectedItem).maloai;
            int soluong = int.Parse(txtsoluong.Text);
            float giaban = float.Parse(txtGia.Text);
            string anh = txtAnh.Text;

            if(masanpham =="" || tensanpham =="" || maloai ==""||soluong == 0 || giaban == 0.0f || anh == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Trống", MessageBoxButtons.OK);
            }
            else
            {
                int them = sp.ThemSanPham(masanpham, tensanpham,maloai,soluong,giaban,anh);
                MessageBox.Show("Thêm thành công !", "Thành Công", MessageBoxButtons.OK);
                capnhatbang();
                ClearAll();
            }

        }
    }
}

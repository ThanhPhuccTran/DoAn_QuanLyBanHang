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
            // TODO: This line of code loads data into the 'qL_BanHang_DienTuDataSet1.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.qL_BanHang_DienTuDataSet1.SanPham);
            // TODO: This line of code loads data into the 'qL_BanHang_DienTuDataSet.LoaiHang' table. You can move, or remove it, as needed.
            this.loaiHangTableAdapter.Fill(this.qL_BanHang_DienTuDataSet.LoaiHang);
            capnhatbang();

            var dsloai = loai.getloai();
            foreach(var loaihang in dsloai)
            {
                cbxLoai.Items.Add(new LoaiHang { tenloai = loaihang.tenloai,maloai = loaihang.maloai});
                cbxFill.Items.Add(new LoaiHang { tenloai = loaihang.tenloai, maloai = loaihang.maloai });
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
        private void capnhatbang()
        {

            grdSanPham2.DataSource = sp.getsanpham();

            grdSanPham2.Columns[0].HeaderText = "Mã sản phẩm";
            grdSanPham2.Columns[1].HeaderText = "Tên sản phẩm";
            grdSanPham2.Columns[2].HeaderText = "Mã loại";
            grdSanPham2.Columns[3].HeaderText = "Số lượng";
            grdSanPham2.Columns[4].HeaderText = "Giá bán";
            grdSanPham2.Columns[5].HeaderText = "Ảnh";

            // căn chỉnh cột .
            grdSanPham2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grdSanPham2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grdSanPham2.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grdSanPham2.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            grdSanPham2.Columns[4].DefaultCellStyle.Format = "N0";

            grdSanPham2.Columns[0].Width = 100;
            grdSanPham2.Columns[1].Width = 200;
            grdSanPham2.Columns[2].Width = 100;
            grdSanPham2.Columns[3].Width = 100;
            grdSanPham2.Columns[4].Width = 100;
            grdSanPham2.Columns[5].Width = 300;

           /* grdSanPham2.AllowUserToAddRows = false;
            grdSanPham2.EditMode = DataGridViewEditMode.EditProgrammatically;*/

        }

        private void ClearAll()
        {
            txtMasp.Clear();
            txtTensp.Clear();
            txtAnh.Clear();
            txtGia.Clear();
            txtsoluong.Clear();
            txtTimKiem.Clear();
            cbxLoai.SelectedIndex = -1;
            //cbxFill.SelectedIndex = -1;
            cbxFill.Text = "Lọc theo mã loại";
            cbxLoai.Text = "Chọn loại";
            imageAnh.Image = null;
            capnhatbang();
            btnThem.Enabled = true;

        }

        private void Loc()
        {
            string maloai = ((LoaiHang)cbxFill.SelectedItem).maloai;
            DataTable dt = sp.LocSanPhamTheoMaLoai(maloai);
            grdSanPham2.DataSource = dt;
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

                if (sp.KiemTraSanPham(masanpham)==false) 
                {
                    int them = sp.ThemSanPham(masanpham, tensanpham, maloai, soluong, giaban, anh);
                    if (them > 0)
                    {
                        MessageBox.Show("Thêm thành công !", "Thành Công", MessageBoxButtons.OK);
                        capnhatbang();
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại !", "Thất Bại", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show("Mã sản phẩm không được trùng với nhau !", "Thất Bại", MessageBoxButtons.OK);
                }
            }
                
            

        }

        private void grdSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdSanPham2_Click(object sender, EventArgs e)
        {
           

            if (grdSanPham2.SelectedRows.Count > 0)
            {
                //dell cho nhap maloai
                txtMasp.Enabled = false;
                btnThem.Enabled = false;
                DataGridViewRow row = grdSanPham2.SelectedRows[0];
                txtMasp.Text = row.Cells[0].Value?.ToString();
                txtTensp.Text = row.Cells[1].Value?.ToString();
                txtGia.Text = Convert.ToDecimal(row.Cells[4].Value).ToString("F0");
                txtsoluong.Text = row.Cells[3].Value?.ToString();
                txtAnh.Text = row.Cells[5].Value?.ToString();
                string maloai = row.Cells[2].Value?.ToString();
                string tenloai = loai.TenLoai(maloai);
                cbxLoai.Text = tenloai;
                // Thêm mã để hiển thị hình ảnh
                string imagePath = row.Cells[5].Value?.ToString();
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    imageAnh.Image = Image.FromFile(imagePath);
                }
                else
                {
                    imageAnh.Image = null;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng", "Lỗi", MessageBoxButtons.OK);
            }
        }
       
        private void btnLoad_Click(object sender, EventArgs e)
        {
            //dell cho nhap maloai
            txtMasp.Enabled = true;
            ClearAll();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string masanpham = txtMasp.Text;
            string tensanpham = txtTensp.Text;
            string maloai = ((LoaiHang)cbxLoai.SelectedItem).maloai;
            int soluong = int.Parse(txtsoluong.Text);
            float giaban = float.Parse(txtGia.Text);
            string anh = txtAnh.Text;
            if (masanpham == "" || tensanpham == "" || maloai == "" || soluong == 0 || giaban == 0.0f || anh == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Trống", MessageBoxButtons.OK);
            }
            else
            {
                // Kiểm tra xem sản phẩm đã tồn tại trong cơ sở dữ liệu hay chưa
                if (sp.KiemTraSanPham(masanpham))
                {
                    int sua = sp.SuaSanPham(masanpham, tensanpham, maloai, soluong, giaban, anh);
                    if (sua > 0)
                    {
                        MessageBox.Show("Sửa thành công !", "Thành Công", MessageBoxButtons.OK);
                        capnhatbang();
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Sửa sản phẩm thất bại!", "Thất bại", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Sản phẩm không tồn tại trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string masanpham = txtMasp.Text;
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int xoa = sp.XoaSanPham(masanpham);
                if (xoa > 0)
                {
                    MessageBox.Show("Xóa thành công !!!", "Thành Công", MessageBoxButtons.OK);
                    capnhatbang();
                    ClearAll();
                }

            }
        }

        private void cbxFill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFill.SelectedItem != null)
            {
                Loc();
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào ", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = txtTimKiem.Text;
            if (!string.IsNullOrEmpty(ten))
            {
                DataTable dt = sp.TimKiemSanPhamTheoTen(ten);
                grdSanPham2.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm cần tìm kiếm", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void imageAnh_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            FrmNhanVien fm = new FrmNhanVien();
            fm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
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
    }
}

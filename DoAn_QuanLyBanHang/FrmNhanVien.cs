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
    public partial class FrmNhanVien : Form
    {
        NhanVienBO nvbo = new NhanVienBO();
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormSanPham fm = new FormSanPham();
            fm.Show();
            this.Hide();
        }

        private void LoaiSanPham_Click(object sender, EventArgs e)
        {
            FormMain fm = new FormMain();
            fm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BanHang_DienTuDataSet2.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qL_BanHang_DienTuDataSet2.NhanVien);
            timer1.Start();
            capnhatbang();
        }

        private void capnhatbang()
        {
            grdNhanVien.DataSource = nvbo.getnhanvien();
        }
        bool kiemtratrong()
        {
            if((txtMaNhanVien.Text == "") || (txtHoTen.Text=="") || (txtDiaChi.Text=="")||(txtSDT.Text==""))
            {

                return false;
            }
             else
            {
                return true;
            }
        }
        private void ClearAll()
        {
             txtMaNhanVien.Clear();
             txtHoTen.Clear();
             txtSDT.Clear();
             txtDiaChi.Clear();
             dtpNgaySinh.ResetText();
            radioButton1.Checked = true; // Đặt giới tính về "Nam"
            radioButton2.Checked = false;

            capnhatbang();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string manv = txtMaNhanVien.Text;
            string hoten = txtHoTen.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiaChi.Text;
            DateTime ngaysinh = dtpNgaySinh.Value;
            string gioitinh = radioButton1.Checked ? "Nam" : "Nữ";

            if (kiemtratrong()== false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Trống", MessageBoxButtons.OK);
               
            }
            else
            {
                int them = nvbo.ThemNhanVien(manv, hoten, gioitinh, diachi, sdt, ngaysinh);
                if (them > 0)
                {
                    MessageBox.Show("Thêm thành công !", "Thành Công", MessageBoxButtons.OK);
                    capnhatbang();
                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công !", "Lỗi", MessageBoxButtons.OK);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void grdNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = grdNhanVien.SelectedRows[0];

                txtMaNhanVien.Text = row.Cells[0].Value?.ToString(); // Mã nhân viên
                txtHoTen.Text = row.Cells[1].Value?.ToString(); // Họ tên
                string gioitinh = row.Cells[2].Value?.ToString();
                if(gioitinh == "Nam")
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }
                txtDiaChi.Text = row.Cells[3].Value?.ToString(); // Địa chỉ
                txtSDT.Text = row.Cells[4].Value?.ToString(); // Số điện thoại
                dtpNgaySinh.Value = DateTime.Parse(row.Cells[5].Value?.ToString()); // Ngày sinh
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string manv = txtMaNhanVien.Text;
            string hoten = txtHoTen.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiaChi.Text;
            DateTime ngaysinh = dtpNgaySinh.Value;
            string gioitinh = radioButton1.Checked ? "Nam" : "Nữ";

            if (kiemtratrong() == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Trống", MessageBoxButtons.OK);
                capnhatbang();
            }
            else
            {
                if (nvbo.KiemTraNhanVien(manv))
                {
                    int sua = nvbo.SuaNhanVien(manv, hoten, gioitinh, diachi, sdt, ngaysinh);
                    if (sua > 0)
                    {
                        MessageBox.Show("Sửa thành công !", "Thành Công", MessageBoxButtons.OK);
                        capnhatbang();
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Sửa nhân viên thất bại!", "Thất bại", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Nhân viên không tồn tại trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string manv = txtMaNhanVien.Text;
            if (MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int xoa = nvbo.XoaNhanVien(manv);
                if (xoa > 0)
                {
                    MessageBox.Show("Xóa thành công !!!", "Thành Công", MessageBoxButtons.OK);
                    capnhatbang();
                    ClearAll();
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
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
    }
}

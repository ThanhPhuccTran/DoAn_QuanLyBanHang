using DoAn_QuanLyBanHang.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyBanHang
{
    public partial class FormHoaDonNV : Form
    {
        SanPhamBO sp = new SanPhamBO();
        DataTable dtSanPhamMoi = new DataTable();
        HoaDonBO hd = new HoaDonBO();
        ChiTietHoaDonBO cthd = new ChiTietHoaDonBO();
        public FormHoaDonNV()
        {
            InitializeComponent();

            dtSanPhamMoi.Columns.Add("Tên sản phẩm", typeof(string));
            dtSanPhamMoi.Columns.Add("Số lượng", typeof(int));
            dtSanPhamMoi.Columns.Add("Giá", typeof(decimal));
            dtSanPhamMoi.Columns.Add("Tổng tiền", typeof(decimal));
            btnPrint.Enabled = false;
            
            grdGioHang.DataSource = dtSanPhamMoi;

        }

        private void FormHoaDonNV_Load(object sender, EventArgs e)
        {
            capnhatbang();
        }

        public void capnhatbang()
        {
            grdSanPham.DataSource = sp.getsanpham();
            grdSanPham.Columns[4].DefaultCellStyle.Format = "F0";
        }
        private void Clean()
        {
            txtTen.Text = "";
            txtGia.Text = "";
            txtSoLuong.Text = "";
            btnThem.Enabled = true;

        }
        private void grdSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grdSanPham_Click(object sender, EventArgs e)
        {


            txtTen.Enabled = false;
            txtGia.Enabled = false;
            DataGridViewRow row = grdSanPham.SelectedRows[0];
            txtTen.Text = row.Cells[1].Value?.ToString();
            txtGia.Text = Convert.ToDecimal(row.Cells[4].Value).ToString("F0");
           // txtSoLuong.Text = row.Cells[3].Value?.ToString();


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            /* if (string.IsNullOrEmpty(txtSoLuong.Text))
             {
                 MessageBox.Show("Yêu cầu nhập số lượng");
                 return;
             }*/

            // Lấy thông tin từ các ô nhập liệu
            if (string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtSoLuong.Text) || string.IsNullOrEmpty(txtGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Trống", MessageBoxButtons.OK);
            }
            else
            {
                string ten = txtTen.Text;
                int soLuong = int.Parse(txtSoLuong.Text);
                decimal gia = decimal.Parse(txtGia.Text);

                // Kiểm tra xem sản phẩm đã tồn tại trong dtSanPhamMoi chưa
                DataRow[] rows = dtSanPhamMoi.Select("[Tên sản phẩm] = '" + ten + "'");
                if (rows.Length > 0)
                {
                    // Nếu sản phẩm đã tồn tại, tăng số lượng
                    rows[0]["Số lượng"] = (int)rows[0]["Số lượng"] + soLuong;
                    rows[0]["Tổng tiền"] = (int)rows[0]["Số lượng"] * gia;
                }
                else
                {
                    // Nếu sản phẩm chưa tồn tại, thêm một hàng mới
                    dtSanPhamMoi.Rows.Add(ten, soLuong, gia, soLuong * gia);
                }
                // Cập nhật giá trị của txtTongTien
                decimal tongTien = 0;
                if (dtSanPhamMoi.Rows.Count > 0)
                {
                    tongTien = dtSanPhamMoi.AsEnumerable().Sum(row => row.Field<decimal>("Tổng tiền"));
                }
                txtTongTien.Text = tongTien.ToString("N0");
                Clean();
            }
        }

        private void grdGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void grdGioHang_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = grdGioHang.SelectedRows[0];
            
                txtTen.Text = row.Cells[0].Value?.ToString();
                txtGia.Text = Convert.ToDecimal(row.Cells[2].Value).ToString("F0");
                txtSoLuong.Text = row.Cells[1].Value?.ToString(); 
                btnThem.Enabled = false;
            }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtSoLuong.Text) || string.IsNullOrEmpty(txtGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Trống", MessageBoxButtons.OK);
            }
            else
            {

                // Lấy thông tin từ các ô nhập liệu
                string ten = txtTen.Text;
                int soLuong = int.Parse(txtSoLuong.Text);
                decimal gia = decimal.Parse(txtGia.Text);
                // Kiểm tra xem sản phẩm đã tồn tại trong dtSanPhamMoi chưa
                DataRow[] rows = dtSanPhamMoi.Select("[Tên sản phẩm] = '" + ten + "'");
                if (rows.Length > 0)
                {
                    // Nếu sản phẩm đã tồn tại, cập nhật số lượng và tổng tiền
                    rows[0]["Số lượng"] = soLuong; // Cập nhật số lượng
                    rows[0]["Tổng tiền"] = soLuong * gia;
                }
                else
                {
                    // Nếu sản phẩm chưa tồn tại, hiển thị thông báo lỗi
                    MessageBox.Show("Sản phẩm không tồn tại trong giỏ hàng.");
                }

                // Cập nhật giá trị của txtTongTien
                decimal tongTien = 0;
                if (dtSanPhamMoi.Rows.Count > 0)
                {
                    tongTien = dtSanPhamMoi.AsEnumerable().Sum(row => row.Field<decimal>("Tổng tiền"));
                }
                txtTongTien.Text = tongTien.ToString("N0");

                Clean();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các ô nhập liệu
            string ten = txtTen.Text;
            if (ten == "")
            {
                MessageBox.Show("Yêu cầu có sản phẩm ");

            }
            else
            {
                // Kiểm tra xem sản phẩm đã tồn tại trong dtSanPhamMoi chưa
                DataRow[] rows = dtSanPhamMoi.Select("[Tên sản phẩm] = '" + ten + "'");
                if (rows.Length > 0)
                {
                    // Nếu sản phẩm đã tồn tại, xóa sản phẩm
                    dtSanPhamMoi.Rows.Remove(rows[0]);
                }
                else
                {
                    // Nếu sản phẩm chưa tồn tại, hiển thị thông báo lỗi
                    MessageBox.Show("Sản phẩm không tồn tại trong giỏ hàng.");
                }

                // Cập nhật giá trị của txtTongTien
                decimal tongTien = 0;
                if (dtSanPhamMoi.Rows.Count > 0)
                {
                    tongTien = dtSanPhamMoi.AsEnumerable().Sum(row => row.Field<decimal>("Tổng tiền"));
                }
                txtTongTien.Text = tongTien.ToString("N0");
                Clean();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DateTime ngayBan = DateTime.Now;
            string manv = FormDangNhap.taikhoan.username;
            int maHDMax = hd.ThemHD(manv, ngayBan);
            if (grdGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm trong  !", "Thành Công", MessageBoxButtons.OK);
            }
            else
            {
              /*  int hoadon = hd.ThemHD(manv, ngayBan);*/
                if (maHDMax > 0)
                {
                    foreach (DataRow row in dtSanPhamMoi.Rows)
                    {
                        string tenSanPham = row["Tên sản phẩm"].ToString();
                        int soLuong = int.Parse(row["Số lượng"].ToString());
                        decimal gia = decimal.Parse(row["Giá"].ToString());
                        decimal tongTien = decimal.Parse(row["Tổng tiền"].ToString());

                        // Gọi hàm thêm chi tiết hóa đơn ở đây, sử dụng mã hóa đơn vừa tạo (maHDMax)
                        int result = cthd.ThemCTHD(sp.getMaSanPham(tenSanPham),tenSanPham, soLuong, gia, tongTien, maHDMax);

                        if (result <= 0)
                        {
                            MessageBox.Show("Thanh toán không thành công!", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }
                        hd.Capnhatsoluong(soLuong, tenSanPham);
                        capnhatbang();
                    }
                    
                    MessageBox.Show("Thanh toán thành công !", "Thành Công", MessageBoxButtons.OK);

                    btnPrint.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Ko thành công !", "Thành Công", MessageBoxButtons.OK);
                }
            }
            //dtSanPhamMoi.Rows.Clear();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Chuẩn bị thông tin hóa đơn cần in
            StringBuilder sb = new StringBuilder();
            string hoaDon = "Hóa Đơn";
            int totalWidth = 80; // Độ rộng tổng cộng của dòng, bạn có thể thay đổi con số này
            int padding = (totalWidth - hoaDon.Length) / 2; // Tính toán số lượng ký tự cần thêm vào mỗi bên

            // Thêm ký tự trống vào hai bên chuỗi
            hoaDon = hoaDon.PadLeft(hoaDon.Length + padding).PadRight(totalWidth);

            sb.AppendLine(hoaDon);


            // Thêm tiêu đề cho bảng
            sb.AppendLine($"Tên sản phẩm: {" ".PadRight(26)} Số lượng: {" ".PadRight(30)} Giá: {" ".PadRight(30)} Thành tiền: {" ".PadRight(11)}");

            // Thêm thông tin chi tiết hóa đơn từ dtSanPhamMoi vào StringBuilder
            foreach (DataRow row in dtSanPhamMoi.Rows)
            {
                sb.AppendLine($"{row["Tên sản phẩm"].ToString().PadRight(45)} {row["Số lượng"].ToString().PadRight(45)} {row["Giá"].ToString().PadRight(30)} {row["Tổng tiền"].ToString().PadRight(11)}");
            }

            // Tạo và hiển thị trước khi in
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawString(sb.ToString(), new Font("Arial", 12), Brushes.Black, new PointF(100, 100));
                ev.Graphics.DrawString($"Tổng tiền là : {txtTongTien.Text}", new Font("Arial", 12), Brushes.Black, new PointF(300, 300));
            };

            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();

            dtSanPhamMoi.Rows.Clear();
            txtTongTien.Text = "";
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormcuaNhanVien fd = new FormcuaNhanVien();
            fd.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            /*FormDangNhap fd = new FormDangNhap();
            fd.Show();
            this.Hide();*/
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormDangNhap fd = new FormDangNhap();
            fd.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

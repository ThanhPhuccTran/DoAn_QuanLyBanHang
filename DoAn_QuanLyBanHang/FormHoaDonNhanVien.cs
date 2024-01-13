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
    public partial class FormHoaDonNhanVien : Form
    {
        SanPhamBO sp = new SanPhamBO();
        private DataTable table;
        public FormHoaDonNhanVien()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void capnhatbang()
        {
            grdSanPham.DataSource = sp.getsanpham();
            grdSanPham.Columns[4].DefaultCellStyle.Format = "F0";
        }
        private void grdSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int SoluongSanPham = 0;
        int soluong,tong;
        float UnitPrice;
        string Product;
        int sum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSoluong.Text))
                {
                    MessageBox.Show("Hãy nhập số lượng ");
                }
                else if(flag==0)
                {
                    MessageBox.Show("Chọn sản phẩm muốn thêm");
                }
                else if (Convert.ToInt32(txtSoluong.Text)>stock)
                {
                    MessageBox.Show("So luong hien tai khong du ");
                }
                else
                {
                    SoluongSanPham = SoluongSanPham + 1;
                    soluong = Convert.ToInt32(txtSoluong.Text);
                    tong = (int)(soluong * UnitPrice);
                    table.Rows.Add(SoluongSanPham,Product,soluong,UnitPrice,tong);
                    grdGioHang.DataSource = table;
                    flag = 0;
                    sum = sum + tong;
                    txtTongtien.Text = sum.ToString();
                    UpdateProduct();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int flag = 0;
        int stock = 0;
        private void grdSanPham_DoubleClick(object sender, EventArgs e)
        {
           
            try
            {
                Product = grdSanPham.SelectedRows[0].Cells[0].Value.ToString();
                if (Int32.TryParse(grdSanPham.SelectedRows[0].Cells[3].Value.ToString(), out int stockValue))
                {
                    stock = stockValue;
                }
                else
                {
                    MessageBox.Show("Giá trị stock không phải là số nguyên");
                    return;
                }
                if (float.TryParse(grdSanPham.SelectedRows[0].Cells[4].Value.ToString(), out float unitPriceValue))
                {
                    UnitPrice = unitPriceValue;
                }
                else
                {
                    MessageBox.Show("Giá trị UnitPrice không phải là số thực");
                    return;
                }
                flag = 1;
                MessageBox.Show("Chon Thanh Cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormHoaDonNhanVien_Load(object sender, EventArgs e)
        {
            capnhatbang();
            table = new DataTable();
            table.Columns.Add("STT",typeof(int));
            table.Columns.Add("Sản Phẩm", typeof(string));
            table.Columns.Add("Số lượng", typeof(int));
            table.Columns.Add("Giá tiền", typeof(int));
            table.Columns.Add("Tổng", typeof(int));
        }
        
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdGioHang.CurrentRow != null && grdGioHang.CurrentRow.Index > -1 && grdGioHang.Rows.Count > 0)
                {
                    int rowIndex = grdGioHang.CurrentRow.Index;

                    // Lấy thông tin sản phẩm từ hàng được chọn trong giỏ hàng
                    string productName = grdGioHang.Rows[rowIndex].Cells[1].Value.ToString();
                    int quantityToRestore = Convert.ToInt32(grdGioHang.Rows[rowIndex].Cells[2].Value);

                    // Xóa hàng từ giỏ hàng
                    int total = Convert.ToInt32(grdGioHang.Rows[rowIndex].Cells[4].Value);
                    grdGioHang.Rows.RemoveAt(rowIndex);
                    grdGioHang.Refresh();

                    // Cập nhật tổng tiền
                    sum = sum - total;
                    txtTongtien.Text = sum.ToString();

                    // Khôi phục số lượng sản phẩm trong grdSanPham
                    foreach (DataGridViewRow row in grdSanPham.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == productName)
                        {
                            int currentStock = Convert.ToInt32(row.Cells[3].Value);
                            row.Cells[3].Value = currentStock + quantityToRestore;
                            MessageBox.Show("Hủy thành công và số lượng sản phẩm đã được khôi phục");
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng từ giỏ hàng trước khi hủy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grdGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void UpdateProduct()
        {
            try
            {
                if (flag == 1) // Kiểm tra xem sản phẩm đã được thêm vào giỏ hàng chưa
                {
                    string Product = grdSanPham.SelectedRows[0].Cells[0].Value.ToString();
                    int newQty = stock - Convert.ToInt32(txtSoluong.Text);
                    if (newQty < 0)
                    {
                        MessageBox.Show("Loi Update");
                    }
                    else
                    {
                        int sanpham = sp.CapNhatSoLuong(Product, newQty);
                        if (sanpham > 0)
                        {
                            MessageBox.Show("Them Thanh Cong");
                            capnhatbang();
                        }
                        else
                        {
                            MessageBox.Show("Khong Thanh Cong");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }

}

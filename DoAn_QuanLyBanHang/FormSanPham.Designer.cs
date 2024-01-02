namespace DoAn_QuanLyBanHang
{
    partial class FormSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoaiSanPham = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.cbxLoai = new System.Windows.Forms.ComboBox();
            this.qL_BanHang_DienTuDataSet = new DoAn_QuanLyBanHang.QL_BanHang_DienTuDataSet();
            this.loaiHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiHangTableAdapter = new DoAn_QuanLyBanHang.QL_BanHang_DienTuDataSetTableAdapters.LoaiHangTableAdapter();
            this.imageAnh = new System.Windows.Forms.PictureBox();
            this.grdSanPham = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.btnMo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BanHang_DienTuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LoaiSanPham);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 759);
            this.panel1.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(45, 138);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(129, 38);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "00:00:00";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 152);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAn_QuanLyBanHang.Properties.Resources.attachment_144613571_preview_rev_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(70, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nhân Viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(70, 584);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Thanh Toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thống kê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(70, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sản Phẩm";
            // 
            // LoaiSanPham
            // 
            this.LoaiSanPham.AutoSize = true;
            this.LoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiSanPham.ForeColor = System.Drawing.Color.White;
            this.LoaiSanPham.Location = new System.Drawing.Point(70, 216);
            this.LoaiSanPham.Name = "LoaiSanPham";
            this.LoaiSanPham.Size = new System.Drawing.Size(153, 25);
            this.LoaiSanPham.TabIndex = 1;
            this.LoaiSanPham.Text = "Loại sản phẩm";
            this.LoaiSanPham.Click += new System.EventHandler(this.LoaiSanPham_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 697);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 62);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Xuất";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(257, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(937, 83);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(906, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(379, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quản Lý Bán LapTop";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(983, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Quản lý sản phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(281, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Mã sản phẩm";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(477, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tên sản phẩm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(692, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "Loại ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(281, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 25);
            this.label12.TabIndex = 7;
            this.label12.Text = "Số lượng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(467, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 25);
            this.label13.TabIndex = 8;
            this.label13.Text = "Giá";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(787, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 25);
            this.label14.TabIndex = 9;
            this.label14.Text = "Ảnh";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(286, 247);
            this.txtsoluong.Multiline = true;
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(150, 39);
            this.txtsoluong.TabIndex = 10;
            // 
            // txtTensp
            // 
            this.txtTensp.Location = new System.Drawing.Point(472, 157);
            this.txtTensp.Multiline = true;
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(258, 39);
            this.txtTensp.TabIndex = 10;
            // 
            // txtMasp
            // 
            this.txtMasp.Location = new System.Drawing.Point(286, 157);
            this.txtMasp.Multiline = true;
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Size = new System.Drawing.Size(150, 39);
            this.txtMasp.TabIndex = 10;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(472, 247);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(203, 39);
            this.txtGia.TabIndex = 10;
            // 
            // cbxLoai
            // 
            this.cbxLoai.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.qL_BanHang_DienTuDataSet, "LoaiHang.maloai", true));
            this.cbxLoai.FormattingEnabled = true;
            this.cbxLoai.Location = new System.Drawing.Point(697, 247);
            this.cbxLoai.Name = "cbxLoai";
            this.cbxLoai.Size = new System.Drawing.Size(117, 24);
            this.cbxLoai.TabIndex = 11;
            // 
            // qL_BanHang_DienTuDataSet
            // 
            this.qL_BanHang_DienTuDataSet.DataSetName = "QL_BanHang_DienTuDataSet";
            this.qL_BanHang_DienTuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiHangBindingSource
            // 
            this.loaiHangBindingSource.DataMember = "LoaiHang";
            this.loaiHangBindingSource.DataSource = this.qL_BanHang_DienTuDataSet;
            // 
            // loaiHangTableAdapter
            // 
            this.loaiHangTableAdapter.ClearBeforeFill = true;
            // 
            // imageAnh
            // 
            this.imageAnh.BackColor = System.Drawing.Color.LightGray;
            this.imageAnh.Location = new System.Drawing.Point(1012, 140);
            this.imageAnh.Name = "imageAnh";
            this.imageAnh.Size = new System.Drawing.Size(181, 169);
            this.imageAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageAnh.TabIndex = 12;
            this.imageAnh.TabStop = false;
            // 
            // grdSanPham
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.grdSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdSanPham.ColumnHeadersHeight = 4;
            this.grdSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdSanPham.DefaultCellStyle = dataGridViewCellStyle9;
            this.grdSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdSanPham.Location = new System.Drawing.Point(265, 388);
            this.grdSanPham.Name = "grdSanPham";
            this.grdSanPham.RowHeadersVisible = false;
            this.grdSanPham.RowHeadersWidth = 51;
            this.grdSanPham.RowTemplate.Height = 24;
            this.grdSanPham.Size = new System.Drawing.Size(916, 354);
            this.grdSanPham.TabIndex = 13;
            this.grdSanPham.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdSanPham.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdSanPham.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdSanPham.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdSanPham.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdSanPham.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdSanPham.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdSanPham.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grdSanPham.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdSanPham.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdSanPham.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdSanPham.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdSanPham.ThemeStyle.HeaderStyle.Height = 4;
            this.grdSanPham.ThemeStyle.ReadOnly = false;
            this.grdSanPham.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdSanPham.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdSanPham.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdSanPham.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdSanPham.ThemeStyle.RowsStyle.Height = 24;
            this.grdSanPham.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdSanPham.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(286, 307);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 36);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(522, 307);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 36);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(406, 307);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 36);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(629, 307);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 36);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(636, 360);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(215, 25);
            this.label15.TabIndex = 15;
            this.label15.Text = "Danh sách sản phẩm";
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(792, 157);
            this.txtAnh.Multiline = true;
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(204, 40);
            this.txtAnh.TabIndex = 16;
            // 
            // btnMo
            // 
            this.btnMo.Location = new System.Drawing.Point(921, 203);
            this.btnMo.Name = "btnMo";
            this.btnMo.Size = new System.Drawing.Size(75, 23);
            this.btnMo.TabIndex = 17;
            this.btnMo.Text = "Mở";
            this.btnMo.UseVisualStyleBackColor = true;
            this.btnMo.Click += new System.EventHandler(this.btnMo_Click);
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 753);
            this.Controls.Add(this.btnMo);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grdSanPham);
            this.Controls.Add(this.imageAnh);
            this.Controls.Add(this.cbxLoai);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtMasp);
            this.Controls.Add(this.txtTensp);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSanPham";
            this.Load += new System.EventHandler(this.FormSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BanHang_DienTuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTime;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LoaiSanPham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.ComboBox cbxLoai;
        private QL_BanHang_DienTuDataSet qL_BanHang_DienTuDataSet;
        private System.Windows.Forms.BindingSource loaiHangBindingSource;
        private QL_BanHang_DienTuDataSetTableAdapters.LoaiHangTableAdapter loaiHangTableAdapter;
        private System.Windows.Forms.PictureBox imageAnh;
        private Guna.UI2.WinForms.Guna2DataGridView grdSanPham;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Button btnMo;
    }
}
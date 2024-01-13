namespace DoAn_QuanLyBanHang
{
    partial class FormChiTietHD
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
            this.grdChiTiet = new System.Windows.Forms.DataGridView();
            this.machitietDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masanphamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahdbanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensanphamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_BanHang_DienTuDataSet4 = new DoAn_QuanLyBanHang.QL_BanHang_DienTuDataSet4();
            this.chiTietHDTableAdapter = new DoAn_QuanLyBanHang.QL_BanHang_DienTuDataSet4TableAdapters.ChiTietHDTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BanHang_DienTuDataSet4)).BeginInit();
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
            this.lblTime.Location = new System.Drawing.Point(56, 140);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(129, 38);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "00:00:00";
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
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Thống kê";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hóa Đơn";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
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
            this.LoaiSanPham.ForeColor = System.Drawing.Color.DarkOrange;
            this.LoaiSanPham.Location = new System.Drawing.Point(70, 216);
            this.LoaiSanPham.Name = "LoaiSanPham";
            this.LoaiSanPham.Size = new System.Drawing.Size(153, 25);
            this.LoaiSanPham.TabIndex = 1;
            this.LoaiSanPham.Text = "Loại sản phẩm";
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
            this.panel4.Location = new System.Drawing.Point(258, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(946, 83);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(913, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
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
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(647, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Chi tiết sản phẩm";
            // 
            // grdChiTiet
            // 
            this.grdChiTiet.AutoGenerateColumns = false;
            this.grdChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machitietDataGridViewTextBoxColumn,
            this.masanphamDataGridViewTextBoxColumn,
            this.mahdbanDataGridViewTextBoxColumn,
            this.tensanphamDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn,
            this.dongiaDataGridViewTextBoxColumn,
            this.thanhtienDataGridViewTextBoxColumn});
            this.grdChiTiet.DataSource = this.chiTietHDBindingSource;
            this.grdChiTiet.Location = new System.Drawing.Point(258, 255);
            this.grdChiTiet.Name = "grdChiTiet";
            this.grdChiTiet.RowHeadersWidth = 51;
            this.grdChiTiet.RowTemplate.Height = 24;
            this.grdChiTiet.Size = new System.Drawing.Size(946, 468);
            this.grdChiTiet.TabIndex = 4;
            this.grdChiTiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdChiTiet_CellContentClick);
            // 
            // machitietDataGridViewTextBoxColumn
            // 
            this.machitietDataGridViewTextBoxColumn.DataPropertyName = "machitiet";
            this.machitietDataGridViewTextBoxColumn.HeaderText = "machitiet";
            this.machitietDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.machitietDataGridViewTextBoxColumn.Name = "machitietDataGridViewTextBoxColumn";
            this.machitietDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // masanphamDataGridViewTextBoxColumn
            // 
            this.masanphamDataGridViewTextBoxColumn.DataPropertyName = "masanpham";
            this.masanphamDataGridViewTextBoxColumn.HeaderText = "masanpham";
            this.masanphamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.masanphamDataGridViewTextBoxColumn.Name = "masanphamDataGridViewTextBoxColumn";
            // 
            // mahdbanDataGridViewTextBoxColumn
            // 
            this.mahdbanDataGridViewTextBoxColumn.DataPropertyName = "mahdban";
            this.mahdbanDataGridViewTextBoxColumn.HeaderText = "mahdban";
            this.mahdbanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mahdbanDataGridViewTextBoxColumn.Name = "mahdbanDataGridViewTextBoxColumn";
            // 
            // tensanphamDataGridViewTextBoxColumn
            // 
            this.tensanphamDataGridViewTextBoxColumn.DataPropertyName = "tensanpham";
            this.tensanphamDataGridViewTextBoxColumn.HeaderText = "tensanpham";
            this.tensanphamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tensanphamDataGridViewTextBoxColumn.Name = "tensanphamDataGridViewTextBoxColumn";
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "soluong";
            this.soluongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            // 
            // dongiaDataGridViewTextBoxColumn
            // 
            this.dongiaDataGridViewTextBoxColumn.DataPropertyName = "dongia";
            this.dongiaDataGridViewTextBoxColumn.HeaderText = "dongia";
            this.dongiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dongiaDataGridViewTextBoxColumn.Name = "dongiaDataGridViewTextBoxColumn";
            // 
            // thanhtienDataGridViewTextBoxColumn
            // 
            this.thanhtienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thanhtienDataGridViewTextBoxColumn.DataPropertyName = "thanhtien";
            this.thanhtienDataGridViewTextBoxColumn.HeaderText = "thanhtien";
            this.thanhtienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thanhtienDataGridViewTextBoxColumn.Name = "thanhtienDataGridViewTextBoxColumn";
            // 
            // chiTietHDBindingSource
            // 
            this.chiTietHDBindingSource.DataMember = "ChiTietHD";
            this.chiTietHDBindingSource.DataSource = this.qL_BanHang_DienTuDataSet4;
            // 
            // qL_BanHang_DienTuDataSet4
            // 
            this.qL_BanHang_DienTuDataSet4.DataSetName = "QL_BanHang_DienTuDataSet4";
            this.qL_BanHang_DienTuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiTietHDTableAdapter
            // 
            this.chiTietHDTableAdapter.ClearBeforeFill = true;
            // 
            // FormChiTietHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 764);
            this.Controls.Add(this.grdChiTiet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChiTietHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChiTietHD";
            this.Load += new System.EventHandler(this.FormChiTietHD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BanHang_DienTuDataSet4)).EndInit();
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
        private System.Windows.Forms.DataGridView grdChiTiet;
        private QL_BanHang_DienTuDataSet4 qL_BanHang_DienTuDataSet4;
        private System.Windows.Forms.BindingSource chiTietHDBindingSource;
        private QL_BanHang_DienTuDataSet4TableAdapters.ChiTietHDTableAdapter chiTietHDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn machitietDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masanphamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahdbanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensanphamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtienDataGridViewTextBoxColumn;
    }
}
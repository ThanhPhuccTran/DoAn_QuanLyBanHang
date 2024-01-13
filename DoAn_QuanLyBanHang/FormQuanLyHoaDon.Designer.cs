namespace DoAn_QuanLyBanHang
{
    partial class FormQuanLyHoaDon
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
            this.grdHoaDon = new System.Windows.Forms.DataGridView();
            this.mahdbanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhanvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_BanHang_DienTuDataSet3 = new DoAn_QuanLyBanHang.QL_BanHang_DienTuDataSet3();
            this.hDBanTableAdapter = new DoAn_QuanLyBanHang.QL_BanHang_DienTuDataSet3TableAdapters.HDBanTableAdapter();
            this.cbxLoc = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BanHang_DienTuDataSet3)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(2, 0);
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
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(71, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hóa Đơn";
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 697);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 62);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Xuất";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(257, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(947, 83);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(917, 0);
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
            this.label8.Location = new System.Drawing.Point(662, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Quản lý hóa đơn";
            // 
            // grdHoaDon
            // 
            this.grdHoaDon.AutoGenerateColumns = false;
            this.grdHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahdbanDataGridViewTextBoxColumn,
            this.manhanvienDataGridViewTextBoxColumn,
            this.ngaybanDataGridViewTextBoxColumn});
            this.grdHoaDon.DataSource = this.hDBanBindingSource;
            this.grdHoaDon.Location = new System.Drawing.Point(257, 303);
            this.grdHoaDon.Name = "grdHoaDon";
            this.grdHoaDon.RowHeadersWidth = 51;
            this.grdHoaDon.RowTemplate.Height = 24;
            this.grdHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHoaDon.Size = new System.Drawing.Size(947, 455);
            this.grdHoaDon.TabIndex = 4;
            this.grdHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdHoaDon_CellClick);
            this.grdHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdHoaDon_CellContentClick);
            // 
            // mahdbanDataGridViewTextBoxColumn
            // 
            this.mahdbanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mahdbanDataGridViewTextBoxColumn.DataPropertyName = "mahdban";
            this.mahdbanDataGridViewTextBoxColumn.HeaderText = "mahdban";
            this.mahdbanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mahdbanDataGridViewTextBoxColumn.Name = "mahdbanDataGridViewTextBoxColumn";
            this.mahdbanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manhanvienDataGridViewTextBoxColumn
            // 
            this.manhanvienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manhanvienDataGridViewTextBoxColumn.DataPropertyName = "manhanvien";
            this.manhanvienDataGridViewTextBoxColumn.HeaderText = "manhanvien";
            this.manhanvienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manhanvienDataGridViewTextBoxColumn.Name = "manhanvienDataGridViewTextBoxColumn";
            // 
            // ngaybanDataGridViewTextBoxColumn
            // 
            this.ngaybanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaybanDataGridViewTextBoxColumn.DataPropertyName = "ngayban";
            this.ngaybanDataGridViewTextBoxColumn.HeaderText = "ngayban";
            this.ngaybanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaybanDataGridViewTextBoxColumn.Name = "ngaybanDataGridViewTextBoxColumn";
            // 
            // hDBanBindingSource
            // 
            this.hDBanBindingSource.DataMember = "HDBan";
            this.hDBanBindingSource.DataSource = this.qL_BanHang_DienTuDataSet3;
            // 
            // qL_BanHang_DienTuDataSet3
            // 
            this.qL_BanHang_DienTuDataSet3.DataSetName = "QL_BanHang_DienTuDataSet3";
            this.qL_BanHang_DienTuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hDBanTableAdapter
            // 
            this.hDBanTableAdapter.ClearBeforeFill = true;
            // 
            // cbxLoc
            // 
            this.cbxLoc.FormattingEnabled = true;
            this.cbxLoc.Location = new System.Drawing.Point(979, 261);
            this.cbxLoc.Name = "cbxLoc";
            this.cbxLoc.Size = new System.Drawing.Size(121, 24);
            this.cbxLoc.TabIndex = 5;
            this.cbxLoc.Text = "Lọc theo ngày";
            this.cbxLoc.SelectedIndexChanged += new System.EventHandler(this.cbxLoc_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 762);
            this.Controls.Add(this.cbxLoc);
            this.Controls.Add(this.grdHoaDon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanLyHoaDon";
            this.Load += new System.EventHandler(this.FormQuanLyHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BanHang_DienTuDataSet3)).EndInit();
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
        private System.Windows.Forms.DataGridView grdHoaDon;
        private QL_BanHang_DienTuDataSet3 qL_BanHang_DienTuDataSet3;
        private System.Windows.Forms.BindingSource hDBanBindingSource;
        private QL_BanHang_DienTuDataSet3TableAdapters.HDBanTableAdapter hDBanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahdbanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhanvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybanDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbxLoc;
        private System.Windows.Forms.Timer timer1;
    }
}
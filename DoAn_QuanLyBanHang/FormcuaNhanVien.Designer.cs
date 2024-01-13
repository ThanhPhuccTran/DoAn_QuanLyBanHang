namespace DoAn_QuanLyBanHang
{
    partial class FormcuaNhanVien
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LoaiSanPham = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.frmSanPham = new System.Windows.Forms.DataGridView();
            this.masanphamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensanphamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiabanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LoaiSanPham);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 759);
            this.panel1.TabIndex = 1;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(71, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hóa Đơn";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LoaiSanPham
            // 
            this.LoaiSanPham.AutoSize = true;
            this.LoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiSanPham.ForeColor = System.Drawing.Color.White;
            this.LoaiSanPham.Location = new System.Drawing.Point(71, 310);
            this.LoaiSanPham.Name = "LoaiSanPham";
            this.LoaiSanPham.Size = new System.Drawing.Size(131, 25);
            this.LoaiSanPham.TabIndex = 1;
            this.LoaiSanPham.Text = "Khách Hàng";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(71, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sản phẩm";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(652, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tất cả sản phẩm";
            // 
            // frmSanPham
            // 
            this.frmSanPham.AutoGenerateColumns = false;
            this.frmSanPham.BackgroundColor = System.Drawing.Color.White;
            this.frmSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frmSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masanphamDataGridViewTextBoxColumn,
            this.tensanphamDataGridViewTextBoxColumn,
            this.maloaiDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn,
            this.dongiabanDataGridViewTextBoxColumn,
            this.anhDataGridViewTextBoxColumn});
            this.frmSanPham.DataSource = this.sanPhamBindingSource;
            this.frmSanPham.Location = new System.Drawing.Point(257, 231);
            this.frmSanPham.Name = "frmSanPham";
            this.frmSanPham.RowHeadersWidth = 51;
            this.frmSanPham.RowTemplate.Height = 24;
            this.frmSanPham.Size = new System.Drawing.Size(947, 512);
            this.frmSanPham.TabIndex = 4;
            // 
            // masanphamDataGridViewTextBoxColumn
            // 
            this.masanphamDataGridViewTextBoxColumn.DataPropertyName = "masanpham";
            this.masanphamDataGridViewTextBoxColumn.HeaderText = "masanpham";
            this.masanphamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.masanphamDataGridViewTextBoxColumn.Name = "masanphamDataGridViewTextBoxColumn";
            this.masanphamDataGridViewTextBoxColumn.Width = 125;
            // 
            // tensanphamDataGridViewTextBoxColumn
            // 
            this.tensanphamDataGridViewTextBoxColumn.DataPropertyName = "tensanpham";
            this.tensanphamDataGridViewTextBoxColumn.HeaderText = "tensanpham";
            this.tensanphamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tensanphamDataGridViewTextBoxColumn.Name = "tensanphamDataGridViewTextBoxColumn";
            this.tensanphamDataGridViewTextBoxColumn.Width = 125;
            // 
            // maloaiDataGridViewTextBoxColumn
            // 
            this.maloaiDataGridViewTextBoxColumn.DataPropertyName = "maloai";
            this.maloaiDataGridViewTextBoxColumn.HeaderText = "maloai";
            this.maloaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maloaiDataGridViewTextBoxColumn.Name = "maloaiDataGridViewTextBoxColumn";
            this.maloaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "soluong";
            this.soluongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            this.soluongDataGridViewTextBoxColumn.Width = 125;
            // 
            // dongiabanDataGridViewTextBoxColumn
            // 
            this.dongiabanDataGridViewTextBoxColumn.DataPropertyName = "dongiaban";
            this.dongiabanDataGridViewTextBoxColumn.HeaderText = "dongiaban";
            this.dongiabanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dongiabanDataGridViewTextBoxColumn.Name = "dongiabanDataGridViewTextBoxColumn";
            this.dongiabanDataGridViewTextBoxColumn.Width = 125;
            // 
            // anhDataGridViewTextBoxColumn
            // 
            this.anhDataGridViewTextBoxColumn.DataPropertyName = "anh";
            this.anhDataGridViewTextBoxColumn.HeaderText = "anh";
            this.anhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.anhDataGridViewTextBoxColumn.Name = "anhDataGridViewTextBoxColumn";
            this.anhDataGridViewTextBoxColumn.Width = 125;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataSource = typeof(DoAn_QuanLyBanHang.BEAN.SanPham);
            // 
            // FormcuaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1205, 755);
            this.Controls.Add(this.frmSanPham);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormcuaNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormcuaNhanVien";
            this.Load += new System.EventHandler(this.FormcuaNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LoaiSanPham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView frmSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn masanphamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensanphamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiabanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anhDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
    }
}
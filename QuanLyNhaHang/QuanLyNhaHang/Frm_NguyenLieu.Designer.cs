namespace QuanLyNhaHang
{
    partial class Frm_NguyenLieu
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
            this.gb_qlnguyenlieu = new System.Windows.Forms.GroupBox();
            this.cbLoaiNguyenLieu = new System.Windows.Forms.ComboBox();
            this.txtDonGiaTinh = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtTenNguyenLieu = new System.Windows.Forms.TextBox();
            this.txtMaNguyenLieu = new System.Windows.Forms.TextBox();
            this.lbl_dongiaton = new System.Windows.Forms.Label();
            this.lbl_donvitinh = new System.Windows.Forms.Label();
            this.lbl_tennguyenlieu = new System.Windows.Forms.Label();
            this.lbl_tennhomnguyenlieu = new System.Windows.Forms.Label();
            this.lbl_manguyenlieu = new System.Windows.Forms.Label();
            this.lbl_dsthucdon = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblQLNguyenLieu = new System.Windows.Forms.Label();
            this.grb_DSNguyenLieu = new System.Windows.Forms.GroupBox();
            this.gvvDanhSachThucDon = new System.Windows.Forms.DataGridView();
            this.MANL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONVITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gb_qlnguyenlieu.SuspendLayout();
            this.grb_DSNguyenLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvvDanhSachThucDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_qlnguyenlieu
            // 
            this.gb_qlnguyenlieu.Controls.Add(this.cbLoaiNguyenLieu);
            this.gb_qlnguyenlieu.Controls.Add(this.txtDonGiaTinh);
            this.gb_qlnguyenlieu.Controls.Add(this.txtDonViTinh);
            this.gb_qlnguyenlieu.Controls.Add(this.txtTenNguyenLieu);
            this.gb_qlnguyenlieu.Controls.Add(this.txtMaNguyenLieu);
            this.gb_qlnguyenlieu.Controls.Add(this.lbl_dongiaton);
            this.gb_qlnguyenlieu.Controls.Add(this.lbl_donvitinh);
            this.gb_qlnguyenlieu.Controls.Add(this.lbl_tennguyenlieu);
            this.gb_qlnguyenlieu.Controls.Add(this.lbl_tennhomnguyenlieu);
            this.gb_qlnguyenlieu.Controls.Add(this.lbl_manguyenlieu);
            this.gb_qlnguyenlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_qlnguyenlieu.Location = new System.Drawing.Point(7, 34);
            this.gb_qlnguyenlieu.Name = "gb_qlnguyenlieu";
            this.gb_qlnguyenlieu.Size = new System.Drawing.Size(337, 251);
            this.gb_qlnguyenlieu.TabIndex = 45;
            this.gb_qlnguyenlieu.TabStop = false;
            // 
            // cbLoaiNguyenLieu
            // 
            this.cbLoaiNguyenLieu.FormattingEnabled = true;
            this.cbLoaiNguyenLieu.Location = new System.Drawing.Point(164, 58);
            this.cbLoaiNguyenLieu.Name = "cbLoaiNguyenLieu";
            this.cbLoaiNguyenLieu.Size = new System.Drawing.Size(151, 28);
            this.cbLoaiNguyenLieu.TabIndex = 1;
            // 
            // txtDonGiaTinh
            // 
            this.txtDonGiaTinh.Location = new System.Drawing.Point(164, 167);
            this.txtDonGiaTinh.Name = "txtDonGiaTinh";
            this.txtDonGiaTinh.Size = new System.Drawing.Size(151, 27);
            this.txtDonGiaTinh.TabIndex = 4;
            this.txtDonGiaTinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaTinh_KeyPress);
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(164, 132);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(151, 27);
            this.txtDonViTinh.TabIndex = 3;
            // 
            // txtTenNguyenLieu
            // 
            this.txtTenNguyenLieu.Location = new System.Drawing.Point(164, 95);
            this.txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            this.txtTenNguyenLieu.Size = new System.Drawing.Size(151, 27);
            this.txtTenNguyenLieu.TabIndex = 2;
            // 
            // txtMaNguyenLieu
            // 
            this.txtMaNguyenLieu.Location = new System.Drawing.Point(164, 21);
            this.txtMaNguyenLieu.Name = "txtMaNguyenLieu";
            this.txtMaNguyenLieu.Size = new System.Drawing.Size(151, 27);
            this.txtMaNguyenLieu.TabIndex = 0;
            this.txtMaNguyenLieu.Leave += new System.EventHandler(this.txtMaNguyenLieu_Leave);
            // 
            // lbl_dongiaton
            // 
            this.lbl_dongiaton.AutoSize = true;
            this.lbl_dongiaton.Location = new System.Drawing.Point(22, 168);
            this.lbl_dongiaton.Name = "lbl_dongiaton";
            this.lbl_dongiaton.Size = new System.Drawing.Size(98, 20);
            this.lbl_dongiaton.TabIndex = 8;
            this.lbl_dongiaton.Text = "Đơn giá tính";
            // 
            // lbl_donvitinh
            // 
            this.lbl_donvitinh.AutoSize = true;
            this.lbl_donvitinh.Location = new System.Drawing.Point(22, 134);
            this.lbl_donvitinh.Name = "lbl_donvitinh";
            this.lbl_donvitinh.Size = new System.Drawing.Size(88, 20);
            this.lbl_donvitinh.TabIndex = 6;
            this.lbl_donvitinh.Text = "Đơn vị tính";
            // 
            // lbl_tennguyenlieu
            // 
            this.lbl_tennguyenlieu.AutoSize = true;
            this.lbl_tennguyenlieu.Location = new System.Drawing.Point(20, 97);
            this.lbl_tennguyenlieu.Name = "lbl_tennguyenlieu";
            this.lbl_tennguyenlieu.Size = new System.Drawing.Size(129, 20);
            this.lbl_tennguyenlieu.TabIndex = 5;
            this.lbl_tennguyenlieu.Text = "Tên Nguyên liệu";
            // 
            // lbl_tennhomnguyenlieu
            // 
            this.lbl_tennhomnguyenlieu.AutoSize = true;
            this.lbl_tennhomnguyenlieu.Location = new System.Drawing.Point(20, 61);
            this.lbl_tennhomnguyenlieu.Name = "lbl_tennhomnguyenlieu";
            this.lbl_tennhomnguyenlieu.Size = new System.Drawing.Size(175, 20);
            this.lbl_tennhomnguyenlieu.TabIndex = 4;
            this.lbl_tennhomnguyenlieu.Text = "Tên Nhóm nguyên liệu";
            // 
            // lbl_manguyenlieu
            // 
            this.lbl_manguyenlieu.AutoSize = true;
            this.lbl_manguyenlieu.Location = new System.Drawing.Point(20, 26);
            this.lbl_manguyenlieu.Name = "lbl_manguyenlieu";
            this.lbl_manguyenlieu.Size = new System.Drawing.Size(124, 20);
            this.lbl_manguyenlieu.TabIndex = 3;
            this.lbl_manguyenlieu.Text = "Mã Nguyên liệu";
            // 
            // lbl_dsthucdon
            // 
            this.lbl_dsthucdon.AutoSize = true;
            this.lbl_dsthucdon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dsthucdon.Location = new System.Drawing.Point(534, 9);
            this.lbl_dsthucdon.Name = "lbl_dsthucdon";
            this.lbl_dsthucdon.Size = new System.Drawing.Size(190, 20);
            this.lbl_dsthucdon.TabIndex = 51;
            this.lbl_dsthucdon.Text = "Danh Sách Nguyên Liệu";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(235, 291);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 34);
            this.btnXoa.TabIndex = 48;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(144, 291);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 34);
            this.btnSua.TabIndex = 47;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(56, 291);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 34);
            this.btnThem.TabIndex = 46;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblQLNguyenLieu
            // 
            this.lblQLNguyenLieu.AutoSize = true;
            this.lblQLNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLNguyenLieu.Location = new System.Drawing.Point(101, 9);
            this.lblQLNguyenLieu.Name = "lblQLNguyenLieu";
            this.lblQLNguyenLieu.Size = new System.Drawing.Size(170, 20);
            this.lblQLNguyenLieu.TabIndex = 49;
            this.lblQLNguyenLieu.Text = "Quản Lý Nguyên Liệu";
            // 
            // grb_DSNguyenLieu
            // 
            this.grb_DSNguyenLieu.Controls.Add(this.gvvDanhSachThucDon);
            this.grb_DSNguyenLieu.Location = new System.Drawing.Point(361, 34);
            this.grb_DSNguyenLieu.Name = "grb_DSNguyenLieu";
            this.grb_DSNguyenLieu.Size = new System.Drawing.Size(547, 291);
            this.grb_DSNguyenLieu.TabIndex = 52;
            this.grb_DSNguyenLieu.TabStop = false;
            // 
            // gvvDanhSachThucDon
            // 
            this.gvvDanhSachThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvvDanhSachThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANL,
            this.MANNL,
            this.TENNL,
            this.DONGIA,
            this.DONVITINH});
            this.gvvDanhSachThucDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvvDanhSachThucDon.Location = new System.Drawing.Point(3, 16);
            this.gvvDanhSachThucDon.Name = "gvvDanhSachThucDon";
            this.gvvDanhSachThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvvDanhSachThucDon.Size = new System.Drawing.Size(541, 272);
            this.gvvDanhSachThucDon.TabIndex = 23;
            this.gvvDanhSachThucDon.SelectionChanged += new System.EventHandler(this.gvvDanhSachThucDon_SelectionChanged);
            // 
            // MANL
            // 
            this.MANL.DataPropertyName = "MANL";
            this.MANL.HeaderText = "Mã Nguyên Liệu";
            this.MANL.Name = "MANL";
            // 
            // MANNL
            // 
            this.MANNL.DataPropertyName = "MANNL";
            this.MANNL.HeaderText = "Mã Nhóm Nguyên Liệu";
            this.MANNL.Name = "MANNL";
            // 
            // TENNL
            // 
            this.TENNL.DataPropertyName = "TENNL";
            this.TENNL.HeaderText = "Tên Nguyên Liệu";
            this.TENNL.Name = "TENNL";
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn Giá";
            this.DONGIA.Name = "DONGIA";
            // 
            // DONVITINH
            // 
            this.DONVITINH.DataPropertyName = "DONVITINH";
            this.DONVITINH.HeaderText = "Đơn Vị Tính";
            this.DONVITINH.Name = "DONVITINH";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_NguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 354);
            this.Controls.Add(this.grb_DSNguyenLieu);
            this.Controls.Add(this.gb_qlnguyenlieu);
            this.Controls.Add(this.lbl_dsthucdon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblQLNguyenLieu);
            this.Name = "Frm_NguyenLieu";
            this.Text = "Frm_NguyenLieu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_NguyenLieu_FormClosing);
            this.Load += new System.EventHandler(this.Frm_NguyenLieu_Load);
            this.gb_qlnguyenlieu.ResumeLayout(false);
            this.gb_qlnguyenlieu.PerformLayout();
            this.grb_DSNguyenLieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvvDanhSachThucDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_qlnguyenlieu;
        private System.Windows.Forms.ComboBox cbLoaiNguyenLieu;
        private System.Windows.Forms.TextBox txtDonGiaTinh;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtTenNguyenLieu;
        private System.Windows.Forms.TextBox txtMaNguyenLieu;
        private System.Windows.Forms.Label lbl_dongiaton;
        private System.Windows.Forms.Label lbl_donvitinh;
        private System.Windows.Forms.Label lbl_tennguyenlieu;
        private System.Windows.Forms.Label lbl_tennhomnguyenlieu;
        private System.Windows.Forms.Label lbl_manguyenlieu;
        private System.Windows.Forms.Label lbl_dsthucdon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblQLNguyenLieu;
        private System.Windows.Forms.GroupBox grb_DSNguyenLieu;
        private System.Windows.Forms.DataGridView gvvDanhSachThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONVITINH;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
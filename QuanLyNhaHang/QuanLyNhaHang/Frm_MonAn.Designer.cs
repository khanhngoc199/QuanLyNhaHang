namespace QuanLyNhaHang
{
    partial class Frm_MonAn
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
            this.gb_qlthucdon = new System.Windows.Forms.GroupBox();
            this.cbTenNhomMonAn = new System.Windows.Forms.ComboBox();
            this.txtDonGiaTinh = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.txtMaMonAn = new System.Windows.Forms.TextBox();
            this.lsbTrangThai = new System.Windows.Forms.ListBox();
            this.lbl_trangthai = new System.Windows.Forms.Label();
            this.lbl_dongiaton = new System.Windows.Forms.Label();
            this.lbl_donvitinh = new System.Windows.Forms.Label();
            this.lbl_tenmonan = new System.Windows.Forms.Label();
            this.lbl_tennhommonan = new System.Windows.Forms.Label();
            this.lblMaMonAn = new System.Windows.Forms.Label();
            this.grbDanhSachMonAn = new System.Windows.Forms.GroupBox();
            this.gvvDanhSachMonAn = new System.Windows.Forms.DataGridView();
            this.MAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONVITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gb_qlthucdon.SuspendLayout();
            this.grbDanhSachMonAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvvDanhSachMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_qlthucdon
            // 
            this.gb_qlthucdon.Controls.Add(this.cbTenNhomMonAn);
            this.gb_qlthucdon.Controls.Add(this.txtDonGiaTinh);
            this.gb_qlthucdon.Controls.Add(this.txtDonViTinh);
            this.gb_qlthucdon.Controls.Add(this.txtTenMonAn);
            this.gb_qlthucdon.Controls.Add(this.txtMaMonAn);
            this.gb_qlthucdon.Controls.Add(this.lsbTrangThai);
            this.gb_qlthucdon.Controls.Add(this.lbl_trangthai);
            this.gb_qlthucdon.Controls.Add(this.lbl_dongiaton);
            this.gb_qlthucdon.Controls.Add(this.lbl_donvitinh);
            this.gb_qlthucdon.Controls.Add(this.lbl_tenmonan);
            this.gb_qlthucdon.Controls.Add(this.lbl_tennhommonan);
            this.gb_qlthucdon.Controls.Add(this.lblMaMonAn);
            this.gb_qlthucdon.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_qlthucdon.Location = new System.Drawing.Point(12, 12);
            this.gb_qlthucdon.Name = "gb_qlthucdon";
            this.gb_qlthucdon.Size = new System.Drawing.Size(318, 251);
            this.gb_qlthucdon.TabIndex = 35;
            this.gb_qlthucdon.TabStop = false;
            // 
            // cbTenNhomMonAn
            // 
            this.cbTenNhomMonAn.FormattingEnabled = true;
            this.cbTenNhomMonAn.Location = new System.Drawing.Point(161, 56);
            this.cbTenNhomMonAn.Name = "cbTenNhomMonAn";
            this.cbTenNhomMonAn.Size = new System.Drawing.Size(151, 27);
            this.cbTenNhomMonAn.TabIndex = 1;
            // 
            // txtDonGiaTinh
            // 
            this.txtDonGiaTinh.Location = new System.Drawing.Point(161, 162);
            this.txtDonGiaTinh.Name = "txtDonGiaTinh";
            this.txtDonGiaTinh.Size = new System.Drawing.Size(151, 27);
            this.txtDonGiaTinh.TabIndex = 4;
            this.txtDonGiaTinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaTinh_KeyPress);
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(161, 128);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(151, 27);
            this.txtDonViTinh.TabIndex = 3;
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Location = new System.Drawing.Point(161, 91);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(151, 27);
            this.txtTenMonAn.TabIndex = 2;
            // 
            // txtMaMonAn
            // 
            this.txtMaMonAn.Location = new System.Drawing.Point(161, 20);
            this.txtMaMonAn.Name = "txtMaMonAn";
            this.txtMaMonAn.Size = new System.Drawing.Size(151, 27);
            this.txtMaMonAn.TabIndex = 0;
            // 
            // lsbTrangThai
            // 
            this.lsbTrangThai.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbTrangThai.FormattingEnabled = true;
            this.lsbTrangThai.ItemHeight = 19;
            this.lsbTrangThai.Items.AddRange(new object[] {
            "Còn hàng",
            "Tạm hết"});
            this.lsbTrangThai.Location = new System.Drawing.Point(161, 201);
            this.lsbTrangThai.Name = "lsbTrangThai";
            this.lsbTrangThai.Size = new System.Drawing.Size(151, 23);
            this.lsbTrangThai.TabIndex = 5;
            // 
            // lbl_trangthai
            // 
            this.lbl_trangthai.AutoSize = true;
            this.lbl_trangthai.Location = new System.Drawing.Point(6, 201);
            this.lbl_trangthai.Name = "lbl_trangthai";
            this.lbl_trangthai.Size = new System.Drawing.Size(84, 19);
            this.lbl_trangthai.TabIndex = 4;
            this.lbl_trangthai.Text = "Trạng Thái:";
            // 
            // lbl_dongiaton
            // 
            this.lbl_dongiaton.AutoSize = true;
            this.lbl_dongiaton.Location = new System.Drawing.Point(6, 165);
            this.lbl_dongiaton.Name = "lbl_dongiaton";
            this.lbl_dongiaton.Size = new System.Drawing.Size(105, 19);
            this.lbl_dongiaton.TabIndex = 8;
            this.lbl_dongiaton.Text = "Đơn Giá Tính:";
            // 
            // lbl_donvitinh
            // 
            this.lbl_donvitinh.AutoSize = true;
            this.lbl_donvitinh.Location = new System.Drawing.Point(6, 131);
            this.lbl_donvitinh.Name = "lbl_donvitinh";
            this.lbl_donvitinh.Size = new System.Drawing.Size(97, 19);
            this.lbl_donvitinh.TabIndex = 6;
            this.lbl_donvitinh.Text = "Đơn Vị Tính:";
            // 
            // lbl_tenmonan
            // 
            this.lbl_tenmonan.AutoSize = true;
            this.lbl_tenmonan.Location = new System.Drawing.Point(6, 94);
            this.lbl_tenmonan.Name = "lbl_tenmonan";
            this.lbl_tenmonan.Size = new System.Drawing.Size(98, 19);
            this.lbl_tenmonan.TabIndex = 5;
            this.lbl_tenmonan.Text = "Tên Món Ăn:";
            // 
            // lbl_tennhommonan
            // 
            this.lbl_tennhommonan.AutoSize = true;
            this.lbl_tennhommonan.Location = new System.Drawing.Point(6, 59);
            this.lbl_tennhommonan.Name = "lbl_tennhommonan";
            this.lbl_tennhommonan.Size = new System.Drawing.Size(144, 19);
            this.lbl_tennhommonan.TabIndex = 4;
            this.lbl_tennhommonan.Text = "Tên Nhóm Món Ăn:";
            // 
            // lblMaMonAn
            // 
            this.lblMaMonAn.AutoSize = true;
            this.lblMaMonAn.Location = new System.Drawing.Point(6, 23);
            this.lblMaMonAn.Name = "lblMaMonAn";
            this.lblMaMonAn.Size = new System.Drawing.Size(95, 19);
            this.lblMaMonAn.TabIndex = 3;
            this.lblMaMonAn.Text = "Mã Món Ăn:";
            // 
            // grbDanhSachMonAn
            // 
            this.grbDanhSachMonAn.Controls.Add(this.gvvDanhSachMonAn);
            this.grbDanhSachMonAn.Location = new System.Drawing.Point(341, 12);
            this.grbDanhSachMonAn.Name = "grbDanhSachMonAn";
            this.grbDanhSachMonAn.Size = new System.Drawing.Size(547, 251);
            this.grbDanhSachMonAn.TabIndex = 39;
            this.grbDanhSachMonAn.TabStop = false;
            // 
            // gvvDanhSachMonAn
            // 
            this.gvvDanhSachMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvvDanhSachMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAMA,
            this.MANMA,
            this.TENMA,
            this.DONGIA,
            this.DONVITINH});
            this.gvvDanhSachMonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvvDanhSachMonAn.Location = new System.Drawing.Point(3, 16);
            this.gvvDanhSachMonAn.Name = "gvvDanhSachMonAn";
            this.gvvDanhSachMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvvDanhSachMonAn.Size = new System.Drawing.Size(541, 232);
            this.gvvDanhSachMonAn.TabIndex = 23;
            this.gvvDanhSachMonAn.SelectionChanged += new System.EventHandler(this.gvvDanhSachMonAn_SelectionChanged);
            // 
            // MAMA
            // 
            this.MAMA.DataPropertyName = "MAMA";
            this.MAMA.HeaderText = "Mã Món Ăn";
            this.MAMA.Name = "MAMA";
            // 
            // MANMA
            // 
            this.MANMA.DataPropertyName = "MANMA";
            this.MANMA.HeaderText = "Mã Nhóm Món Ăn";
            this.MANMA.Name = "MANMA";
            // 
            // TENMA
            // 
            this.TENMA.DataPropertyName = "TENMA";
            this.TENMA.HeaderText = "Tên Món Ăn";
            this.TENMA.Name = "TENMA";
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
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(207, 281);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 33);
            this.btnXoa.TabIndex = 38;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(116, 281);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 33);
            this.btnSua.TabIndex = 37;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(28, 281);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 33);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Frm_MonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 340);
            this.Controls.Add(this.gb_qlthucdon);
            this.Controls.Add(this.grbDanhSachMonAn);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "Frm_MonAn";
            this.Text = "Frm_MonAn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_MonAn_FormClosing);
            this.Load += new System.EventHandler(this.Frm_MonAn_Load);
            this.gb_qlthucdon.ResumeLayout(false);
            this.gb_qlthucdon.PerformLayout();
            this.grbDanhSachMonAn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvvDanhSachMonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_qlthucdon;
        private System.Windows.Forms.ComboBox cbTenNhomMonAn;
        private System.Windows.Forms.TextBox txtDonGiaTinh;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.TextBox txtMaMonAn;
        private System.Windows.Forms.ListBox lsbTrangThai;
        private System.Windows.Forms.Label lbl_trangthai;
        private System.Windows.Forms.Label lbl_dongiaton;
        private System.Windows.Forms.Label lbl_donvitinh;
        private System.Windows.Forms.Label lbl_tenmonan;
        private System.Windows.Forms.Label lbl_tennhommonan;
        private System.Windows.Forms.Label lblMaMonAn;
        private System.Windows.Forms.GroupBox grbDanhSachMonAn;
        private System.Windows.Forms.DataGridView gvvDanhSachMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONVITINH;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}
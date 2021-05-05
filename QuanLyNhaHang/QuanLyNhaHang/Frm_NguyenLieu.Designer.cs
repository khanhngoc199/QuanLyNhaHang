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
            this.gb_qlnguyenlieu = new System.Windows.Forms.GroupBox();
            this.cboLoaiNguyeLieu = new System.Windows.Forms.ComboBox();
            this.txtDonGiatinh = new System.Windows.Forms.TextBox();
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
            this.gvv_DSThucDon = new System.Windows.Forms.DataGridView();
            this.MANL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONVITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_qlnguyenlieu.SuspendLayout();
            this.grb_DSNguyenLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvv_DSThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_qlnguyenlieu
            // 
            this.gb_qlnguyenlieu.Controls.Add(this.cboLoaiNguyeLieu);
            this.gb_qlnguyenlieu.Controls.Add(this.txtDonGiatinh);
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
            // cboLoaiNguyeLieu
            // 
            this.cboLoaiNguyeLieu.FormattingEnabled = true;
            this.cboLoaiNguyeLieu.Location = new System.Drawing.Point(164, 58);
            this.cboLoaiNguyeLieu.Name = "cboLoaiNguyeLieu";
            this.cboLoaiNguyeLieu.Size = new System.Drawing.Size(151, 28);
            this.cboLoaiNguyeLieu.TabIndex = 1;
            // 
            // txtDonGiatinh
            // 
            this.txtDonGiatinh.Location = new System.Drawing.Point(164, 167);
            this.txtDonGiatinh.Name = "txtDonGiatinh";
            this.txtDonGiatinh.Size = new System.Drawing.Size(151, 27);
            this.txtDonGiatinh.TabIndex = 4;
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
            this.grb_DSNguyenLieu.Controls.Add(this.gvv_DSThucDon);
            this.grb_DSNguyenLieu.Location = new System.Drawing.Point(361, 34);
            this.grb_DSNguyenLieu.Name = "grb_DSNguyenLieu";
            this.grb_DSNguyenLieu.Size = new System.Drawing.Size(547, 291);
            this.grb_DSNguyenLieu.TabIndex = 52;
            this.grb_DSNguyenLieu.TabStop = false;
            // 
            // gvv_DSThucDon
            // 
            this.gvv_DSThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvv_DSThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANL,
            this.MANNL,
            this.TENNL,
            this.DONGIA,
            this.DONVITINH});
            this.gvv_DSThucDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvv_DSThucDon.Location = new System.Drawing.Point(3, 16);
            this.gvv_DSThucDon.Name = "gvv_DSThucDon";
            this.gvv_DSThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvv_DSThucDon.Size = new System.Drawing.Size(541, 272);
            this.gvv_DSThucDon.TabIndex = 23;
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
            this.gb_qlnguyenlieu.ResumeLayout(false);
            this.gb_qlnguyenlieu.PerformLayout();
            this.grb_DSNguyenLieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvv_DSThucDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_qlnguyenlieu;
        private System.Windows.Forms.ComboBox cboLoaiNguyeLieu;
        private System.Windows.Forms.TextBox txtDonGiatinh;
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
        private System.Windows.Forms.DataGridView gvv_DSThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONVITINH;
    }
}
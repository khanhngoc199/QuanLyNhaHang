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
            this.cboLoaiTD = new System.Windows.Forms.ComboBox();
            this.txt_dongiaton = new System.Windows.Forms.TextBox();
            this.txt_dvt = new System.Windows.Forms.TextBox();
            this.txt_tenthucdon = new System.Windows.Forms.TextBox();
            this.txt_mathucdon = new System.Windows.Forms.TextBox();
            this.lsb_trangthai = new System.Windows.Forms.ListBox();
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
            this.gb_qlthucdon.Controls.Add(this.cboLoaiTD);
            this.gb_qlthucdon.Controls.Add(this.txt_dongiaton);
            this.gb_qlthucdon.Controls.Add(this.txt_dvt);
            this.gb_qlthucdon.Controls.Add(this.txt_tenthucdon);
            this.gb_qlthucdon.Controls.Add(this.txt_mathucdon);
            this.gb_qlthucdon.Controls.Add(this.lsb_trangthai);
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
            // cboLoaiTD
            // 
            this.cboLoaiTD.FormattingEnabled = true;
            this.cboLoaiTD.Location = new System.Drawing.Point(161, 56);
            this.cboLoaiTD.Name = "cboLoaiTD";
            this.cboLoaiTD.Size = new System.Drawing.Size(151, 27);
            this.cboLoaiTD.TabIndex = 1;
            // 
            // txt_dongiaton
            // 
            this.txt_dongiaton.Location = new System.Drawing.Point(161, 162);
            this.txt_dongiaton.Name = "txt_dongiaton";
            this.txt_dongiaton.Size = new System.Drawing.Size(151, 27);
            this.txt_dongiaton.TabIndex = 4;
            // 
            // txt_dvt
            // 
            this.txt_dvt.Location = new System.Drawing.Point(161, 128);
            this.txt_dvt.Name = "txt_dvt";
            this.txt_dvt.Size = new System.Drawing.Size(151, 27);
            this.txt_dvt.TabIndex = 3;
            // 
            // txt_tenthucdon
            // 
            this.txt_tenthucdon.Location = new System.Drawing.Point(161, 91);
            this.txt_tenthucdon.Name = "txt_tenthucdon";
            this.txt_tenthucdon.Size = new System.Drawing.Size(151, 27);
            this.txt_tenthucdon.TabIndex = 2;
            // 
            // txt_mathucdon
            // 
            this.txt_mathucdon.Location = new System.Drawing.Point(161, 20);
            this.txt_mathucdon.Name = "txt_mathucdon";
            this.txt_mathucdon.Size = new System.Drawing.Size(151, 27);
            this.txt_mathucdon.TabIndex = 0;
            // 
            // lsb_trangthai
            // 
            this.lsb_trangthai.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsb_trangthai.FormattingEnabled = true;
            this.lsb_trangthai.ItemHeight = 19;
            this.lsb_trangthai.Items.AddRange(new object[] {
            "Còn hàng",
            "Tạm hết"});
            this.lsb_trangthai.Location = new System.Drawing.Point(161, 201);
            this.lsb_trangthai.Name = "lsb_trangthai";
            this.lsb_trangthai.Size = new System.Drawing.Size(151, 19);
            this.lsb_trangthai.TabIndex = 5;
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
            this.gb_qlthucdon.ResumeLayout(false);
            this.gb_qlthucdon.PerformLayout();
            this.grbDanhSachMonAn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvvDanhSachMonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_qlthucdon;
        private System.Windows.Forms.ComboBox cboLoaiTD;
        private System.Windows.Forms.TextBox txt_dongiaton;
        private System.Windows.Forms.TextBox txt_dvt;
        private System.Windows.Forms.TextBox txt_tenthucdon;
        private System.Windows.Forms.TextBox txt_mathucdon;
        private System.Windows.Forms.ListBox lsb_trangthai;
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
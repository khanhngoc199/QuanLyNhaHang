namespace QuanLyNhaHang
{
    partial class Frm_PhanQuyen
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
            this.clbPhanQuyen = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MATAIKHOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDANGNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATKHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnNhanVien = new System.Windows.Forms.TextBox();
            this.lbl_NhanVien = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lbl_matkhau = new System.Windows.Forms.Label();
            this.lbl_tendn = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // clbPhanQuyen
            // 
            this.clbPhanQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbPhanQuyen.FormattingEnabled = true;
            this.clbPhanQuyen.Items.AddRange(new object[] {
            "Chức năng",
            "Đăng Nhập",
            "Hóa Đơn Nhập",
            "Hóa Đơn Xuất",
            "Nhóm Nguyên Liệu",
            "Nguyên Liệu",
            "Nhóm Món Ăn",
            "Món Ăn",
            "Nhân Viên"});
            this.clbPhanQuyen.Location = new System.Drawing.Point(364, 129);
            this.clbPhanQuyen.Name = "clbPhanQuyen";
            this.clbPhanQuyen.Size = new System.Drawing.Size(294, 202);
            this.clbPhanQuyen.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 224);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATAIKHOAN,
            this.TENDANGNHAP,
            this.MATKHAU,
            this.TENNV});
            this.dataGridView1.Location = new System.Drawing.Point(0, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(301, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // MATAIKHOAN
            // 
            this.MATAIKHOAN.HeaderText = "MÃ TÀI KHOẢN";
            this.MATAIKHOAN.Name = "MATAIKHOAN";
            // 
            // TENDANGNHAP
            // 
            this.TENDANGNHAP.HeaderText = "TÊN ĐĂNG NHẬP";
            this.TENDANGNHAP.Name = "TENDANGNHAP";
            // 
            // MATKHAU
            // 
            this.MATKHAU.HeaderText = "MẬT KHẨU";
            this.MATKHAU.Name = "MATKHAU";
            // 
            // TENNV
            // 
            this.TENNV.HeaderText = "TÊN NHÂN VIÊN";
            this.TENNV.Name = "TENNV";
            // 
            // txtnNhanVien
            // 
            this.txtnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnNhanVien.Location = new System.Drawing.Point(489, 32);
            this.txtnNhanVien.Name = "txtnNhanVien";
            this.txtnNhanVien.Size = new System.Drawing.Size(169, 27);
            this.txtnNhanVien.TabIndex = 33;
            // 
            // lbl_NhanVien
            // 
            this.lbl_NhanVien.AutoSize = true;
            this.lbl_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhanVien.ForeColor = System.Drawing.Color.Black;
            this.lbl_NhanVien.Location = new System.Drawing.Point(361, 35);
            this.lbl_NhanVien.Name = "lbl_NhanVien";
            this.lbl_NhanVien.Size = new System.Drawing.Size(83, 20);
            this.lbl_NhanVien.TabIndex = 32;
            this.lbl_NhanVien.Text = "Nhân viên";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(489, 96);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(169, 27);
            this.txtMatKhau.TabIndex = 31;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(489, 63);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(169, 27);
            this.txtTenDangNhap.TabIndex = 30;
            // 
            // lbl_matkhau
            // 
            this.lbl_matkhau.AutoSize = true;
            this.lbl_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matkhau.ForeColor = System.Drawing.Color.Black;
            this.lbl_matkhau.Location = new System.Drawing.Point(360, 99);
            this.lbl_matkhau.Name = "lbl_matkhau";
            this.lbl_matkhau.Size = new System.Drawing.Size(77, 20);
            this.lbl_matkhau.TabIndex = 29;
            this.lbl_matkhau.Text = "Mật khẩu";
            // 
            // lbl_tendn
            // 
            this.lbl_tendn.AutoSize = true;
            this.lbl_tendn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tendn.ForeColor = System.Drawing.Color.Black;
            this.lbl_tendn.Location = new System.Drawing.Point(360, 66);
            this.lbl_tendn.Name = "lbl_tendn";
            this.lbl_tendn.Size = new System.Drawing.Size(119, 20);
            this.lbl_tendn.TabIndex = 28;
            this.lbl_tendn.Text = "Tên đăng nhập";
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(476, 356);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 32);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(578, 356);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 32);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Frm_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 399);
            this.Controls.Add(this.clbPhanQuyen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtnNhanVien);
            this.Controls.Add(this.lbl_NhanVien);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lbl_matkhau);
            this.Controls.Add(this.lbl_tendn);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Name = "Frm_PhanQuyen";
            this.Text = "Frm_PhanQuyen";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbPhanQuyen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtnNhanVien;
        private System.Windows.Forms.Label lbl_NhanVien;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lbl_matkhau;
        private System.Windows.Forms.Label lbl_tendn;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATAIKHOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDANGNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATKHAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
    }
}
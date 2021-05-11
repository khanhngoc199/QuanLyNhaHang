namespace QuanLyNhaHang
{
    partial class Frm_HoaDonNhap
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.gpb_ChiTietHoaDon = new System.Windows.Forms.GroupBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_macthd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Ghi = new System.Windows.Forms.Button();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.cbo_nguyenlieu = new System.Windows.Forms.ComboBox();
            this.lbl_NguyenLieu = new System.Windows.Forms.Label();
            this.gpb_HoaDonNhap = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mahoadonnhap = new System.Windows.Forms.TextBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_TaoHoaDon = new System.Windows.Forms.Button();
            this.lbl_NhanVien = new System.Windows.Forms.Label();
            this.lbl_ThoiGian = new System.Windows.Forms.Label();
            this.gpb_HoaDon = new System.Windows.Forms.GroupBox();
            this.gvv_DSHoaDon = new System.Windows.Forms.DataGridView();
            this.MAHDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MACTHDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpb_ChiTietHoaDon.SuspendLayout();
            this.gpb_HoaDonNhap.SuspendLayout();
            this.gpb_HoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvv_DSHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(493, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 33);
            this.button1.TabIndex = 53;
            this.button1.Text = "Xuất hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 56;
            this.label4.Text = "Tổng tiền";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(496, 411);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(181, 32);
            this.textBox5.TabIndex = 55;
            // 
            // gpb_ChiTietHoaDon
            // 
            this.gpb_ChiTietHoaDon.Controls.Add(this.txt_soluong);
            this.gpb_ChiTietHoaDon.Controls.Add(this.txt_macthd);
            this.gpb_ChiTietHoaDon.Controls.Add(this.label3);
            this.gpb_ChiTietHoaDon.Controls.Add(this.textBox3);
            this.gpb_ChiTietHoaDon.Controls.Add(this.label2);
            this.gpb_ChiTietHoaDon.Controls.Add(this.btn_Ghi);
            this.gpb_ChiTietHoaDon.Controls.Add(this.lbl_SoLuong);
            this.gpb_ChiTietHoaDon.Controls.Add(this.cbo_nguyenlieu);
            this.gpb_ChiTietHoaDon.Controls.Add(this.lbl_NguyenLieu);
            this.gpb_ChiTietHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_ChiTietHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gpb_ChiTietHoaDon.Location = new System.Drawing.Point(12, 90);
            this.gpb_ChiTietHoaDon.Name = "gpb_ChiTietHoaDon";
            this.gpb_ChiTietHoaDon.Size = new System.Drawing.Size(668, 79);
            this.gpb_ChiTietHoaDon.TabIndex = 52;
            this.gpb_ChiTietHoaDon.TabStop = false;
            this.gpb_ChiTietHoaDon.Text = "Chi tiết hóa đơn";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(465, 45);
            this.txt_soluong.Multiline = true;
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_soluong.Size = new System.Drawing.Size(100, 23);
            this.txt_soluong.TabIndex = 3;
            // 
            // txt_macthd
            // 
            this.txt_macthd.Location = new System.Drawing.Point(9, 46);
            this.txt_macthd.Name = "txt_macthd";
            this.txt_macthd.Size = new System.Drawing.Size(110, 27);
            this.txt_macthd.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã chi tiết hóa đơn";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(192, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 27);
            this.textBox3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(176, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã hóa đơn";
            // 
            // btn_Ghi
            // 
            this.btn_Ghi.Location = new System.Drawing.Point(593, 41);
            this.btn_Ghi.Name = "btn_Ghi";
            this.btn_Ghi.Size = new System.Drawing.Size(48, 26);
            this.btn_Ghi.TabIndex = 4;
            this.btn_Ghi.Text = "Ghi";
            this.btn_Ghi.UseVisualStyleBackColor = true;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.ForeColor = System.Drawing.Color.Black;
            this.lbl_SoLuong.Location = new System.Drawing.Point(461, 23);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(74, 20);
            this.lbl_SoLuong.TabIndex = 8;
            this.lbl_SoLuong.Text = "Số lượng";
            // 
            // cbo_nguyenlieu
            // 
            this.cbo_nguyenlieu.FormattingEnabled = true;
            this.cbo_nguyenlieu.Location = new System.Drawing.Point(332, 45);
            this.cbo_nguyenlieu.Name = "cbo_nguyenlieu";
            this.cbo_nguyenlieu.Size = new System.Drawing.Size(79, 28);
            this.cbo_nguyenlieu.TabIndex = 2;
            // 
            // lbl_NguyenLieu
            // 
            this.lbl_NguyenLieu.AutoSize = true;
            this.lbl_NguyenLieu.ForeColor = System.Drawing.Color.Black;
            this.lbl_NguyenLieu.Location = new System.Drawing.Point(328, 23);
            this.lbl_NguyenLieu.Name = "lbl_NguyenLieu";
            this.lbl_NguyenLieu.Size = new System.Drawing.Size(96, 20);
            this.lbl_NguyenLieu.TabIndex = 6;
            this.lbl_NguyenLieu.Text = "Nguyên liệu";
            // 
            // gpb_HoaDonNhap
            // 
            this.gpb_HoaDonNhap.Controls.Add(this.label1);
            this.gpb_HoaDonNhap.Controls.Add(this.txt_mahoadonnhap);
            this.gpb_HoaDonNhap.Controls.Add(this.txt_manv);
            this.gpb_HoaDonNhap.Controls.Add(this.dateTimePicker1);
            this.gpb_HoaDonNhap.Controls.Add(this.btn_TaoHoaDon);
            this.gpb_HoaDonNhap.Controls.Add(this.lbl_NhanVien);
            this.gpb_HoaDonNhap.Controls.Add(this.lbl_ThoiGian);
            this.gpb_HoaDonNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_HoaDonNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gpb_HoaDonNhap.Location = new System.Drawing.Point(12, 12);
            this.gpb_HoaDonNhap.Name = "gpb_HoaDonNhap";
            this.gpb_HoaDonNhap.Size = new System.Drawing.Size(668, 72);
            this.gpb_HoaDonNhap.TabIndex = 51;
            this.gpb_HoaDonNhap.TabStop = false;
            this.gpb_HoaDonNhap.Text = "Hóa đơn nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(189, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã hóa đơn nhập";
            // 
            // txt_mahoadonnhap
            // 
            this.txt_mahoadonnhap.Location = new System.Drawing.Point(195, 42);
            this.txt_mahoadonnhap.Name = "txt_mahoadonnhap";
            this.txt_mahoadonnhap.Size = new System.Drawing.Size(100, 27);
            this.txt_mahoadonnhap.TabIndex = 0;
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(549, 41);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(95, 27);
            this.txt_manv.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(441, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(91, 27);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btn_TaoHoaDon
            // 
            this.btn_TaoHoaDon.Location = new System.Drawing.Point(9, 35);
            this.btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            this.btn_TaoHoaDon.Size = new System.Drawing.Size(113, 31);
            this.btn_TaoHoaDon.TabIndex = 4;
            this.btn_TaoHoaDon.Text = "Tạo hóa đơn";
            this.btn_TaoHoaDon.UseVisualStyleBackColor = true;
            // 
            // lbl_NhanVien
            // 
            this.lbl_NhanVien.AutoSize = true;
            this.lbl_NhanVien.ForeColor = System.Drawing.Color.Black;
            this.lbl_NhanVien.Location = new System.Drawing.Point(543, 14);
            this.lbl_NhanVien.Name = "lbl_NhanVien";
            this.lbl_NhanVien.Size = new System.Drawing.Size(111, 20);
            this.lbl_NhanVien.TabIndex = 3;
            this.lbl_NhanVien.Text = "Mã Nhân viên";
            // 
            // lbl_ThoiGian
            // 
            this.lbl_ThoiGian.AutoSize = true;
            this.lbl_ThoiGian.ForeColor = System.Drawing.Color.Black;
            this.lbl_ThoiGian.Location = new System.Drawing.Point(435, 14);
            this.lbl_ThoiGian.Name = "lbl_ThoiGian";
            this.lbl_ThoiGian.Size = new System.Drawing.Size(77, 20);
            this.lbl_ThoiGian.TabIndex = 2;
            this.lbl_ThoiGian.Text = "Thời gian";
            // 
            // gpb_HoaDon
            // 
            this.gpb_HoaDon.Controls.Add(this.gvv_DSHoaDon);
            this.gpb_HoaDon.Location = new System.Drawing.Point(7, 210);
            this.gpb_HoaDon.Name = "gpb_HoaDon";
            this.gpb_HoaDon.Size = new System.Drawing.Size(673, 198);
            this.gpb_HoaDon.TabIndex = 54;
            this.gpb_HoaDon.TabStop = false;
            // 
            // gvv_DSHoaDon
            // 
            this.gvv_DSHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvv_DSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvv_DSHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHDN,
            this.MACTHDN,
            this.MANL,
            this.SOLUONG,
            this.DONGIA});
            this.gvv_DSHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvv_DSHoaDon.Location = new System.Drawing.Point(3, 16);
            this.gvv_DSHoaDon.Name = "gvv_DSHoaDon";
            this.gvv_DSHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvv_DSHoaDon.Size = new System.Drawing.Size(667, 179);
            this.gvv_DSHoaDon.TabIndex = 0;
            // 
            // MAHDN
            // 
            this.MAHDN.DataPropertyName = "MAHDN";
            this.MAHDN.HeaderText = "Mã hóa đơn nhập";
            this.MAHDN.Name = "MAHDN";
            // 
            // MACTHDN
            // 
            this.MACTHDN.DataPropertyName = "MACTHDN";
            this.MACTHDN.HeaderText = "Mã chi tiết hóa đơn nhập";
            this.MACTHDN.Name = "MACTHDN";
            // 
            // MANL
            // 
            this.MANL.DataPropertyName = "MANL";
            this.MANL.HeaderText = "Mã nguyên liệu";
            this.MANL.Name = "MANL";
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.Name = "SOLUONG";
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn giá";
            this.DONGIA.Name = "DONGIA";
            // 
            // Frm_HoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.gpb_ChiTietHoaDon);
            this.Controls.Add(this.gpb_HoaDonNhap);
            this.Controls.Add(this.gpb_HoaDon);
            this.Name = "Frm_HoaDonNhap";
            this.Text = "Frm_HoaDonNhap";
            this.gpb_ChiTietHoaDon.ResumeLayout(false);
            this.gpb_ChiTietHoaDon.PerformLayout();
            this.gpb_HoaDonNhap.ResumeLayout(false);
            this.gpb_HoaDonNhap.PerformLayout();
            this.gpb_HoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvv_DSHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox gpb_ChiTietHoaDon;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_macthd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Ghi;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.ComboBox cbo_nguyenlieu;
        private System.Windows.Forms.Label lbl_NguyenLieu;
        private System.Windows.Forms.GroupBox gpb_HoaDonNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mahoadonnhap;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_TaoHoaDon;
        private System.Windows.Forms.Label lbl_NhanVien;
        private System.Windows.Forms.Label lbl_ThoiGian;
        private System.Windows.Forms.GroupBox gpb_HoaDon;
        private System.Windows.Forms.DataGridView gvv_DSHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACTHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
    }
}
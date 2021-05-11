namespace QuanLyNhaHang
{
    partial class Frm_HoaDonXuat
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
            this.gpb_HoaDon = new System.Windows.Forms.GroupBox();
            this.gvv_DSHoaDon = new System.Windows.Forms.DataGridView();
            this.MAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENGIAMGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpb_ChiTietHoaDon = new System.Windows.Forms.GroupBox();
            this.cbo_GiamGia = new System.Windows.Forms.ComboBox();
            this.cbo_SoLuong = new System.Windows.Forms.ComboBox();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.btn_Ghi = new System.Windows.Forms.Button();
            this.lbl_GiamGia = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.lbl_Gia = new System.Windows.Forms.Label();
            this.cbo_ThucDon = new System.Windows.Forms.ComboBox();
            this.lbl_MonAn = new System.Windows.Forms.Label();
            this.gpb_HoaDonXuat = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbo_NhaCC = new System.Windows.Forms.ComboBox();
            this.btn_TaoHoaDon = new System.Windows.Forms.Button();
            this.lbl_NhanVien = new System.Windows.Forms.Label();
            this.lbl_ThoiGian = new System.Windows.Forms.Label();
            this.lbl_NhaCC = new System.Windows.Forms.Label();
            this.lbl_TongTienGiamGia = new System.Windows.Forms.Label();
            this.txt_TongTienGiamGia = new System.Windows.Forms.TextBox();
            this.txt_TongTienGia = new System.Windows.Forms.TextBox();
            this.btn_InHD = new System.Windows.Forms.Button();
            this.lbl_TongTienPhaiTra = new System.Windows.Forms.Label();
            this.lbl_TongTienGia = new System.Windows.Forms.Label();
            this.btn_LuuHD = new System.Windows.Forms.Button();
            this.txt_TongTienPhaiTra = new System.Windows.Forms.TextBox();
            this.gpb_HoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvv_DSHoaDon)).BeginInit();
            this.gpb_ChiTietHoaDon.SuspendLayout();
            this.gpb_HoaDonXuat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_HoaDon
            // 
            this.gpb_HoaDon.Controls.Add(this.gvv_DSHoaDon);
            this.gpb_HoaDon.Location = new System.Drawing.Point(12, 181);
            this.gpb_HoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpb_HoaDon.Name = "gpb_HoaDon";
            this.gpb_HoaDon.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpb_HoaDon.Size = new System.Drawing.Size(757, 244);
            this.gpb_HoaDon.TabIndex = 57;
            this.gpb_HoaDon.TabStop = false;
            // 
            // gvv_DSHoaDon
            // 
            this.gvv_DSHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvv_DSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvv_DSHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAMA,
            this.TENMA,
            this.SOLUONG,
            this.THANHTIEN,
            this.TIENGIAMGIA});
            this.gvv_DSHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvv_DSHoaDon.Location = new System.Drawing.Point(3, 17);
            this.gvv_DSHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvv_DSHoaDon.Name = "gvv_DSHoaDon";
            this.gvv_DSHoaDon.Size = new System.Drawing.Size(751, 223);
            this.gvv_DSHoaDon.TabIndex = 24;
            // 
            // MAMA
            // 
            this.MAMA.HeaderText = "MÃ MÓN ĂN";
            this.MAMA.Name = "MAMA";
            // 
            // TENMA
            // 
            this.TENMA.HeaderText = "TÊN MÓN ĂN";
            this.TENMA.Name = "TENMA";
            // 
            // SOLUONG
            // 
            this.SOLUONG.HeaderText = "SỐ LƯỢNG";
            this.SOLUONG.Name = "SOLUONG";
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.HeaderText = "THÀNH TIỀN";
            this.THANHTIEN.Name = "THANHTIEN";
            // 
            // TIENGIAMGIA
            // 
            this.TIENGIAMGIA.HeaderText = "TIỀN GIẢM GIÁ";
            this.TIENGIAMGIA.Name = "TIENGIAMGIA";
            // 
            // gpb_ChiTietHoaDon
            // 
            this.gpb_ChiTietHoaDon.Controls.Add(this.cbo_GiamGia);
            this.gpb_ChiTietHoaDon.Controls.Add(this.cbo_SoLuong);
            this.gpb_ChiTietHoaDon.Controls.Add(this.txt_Gia);
            this.gpb_ChiTietHoaDon.Controls.Add(this.btn_Ghi);
            this.gpb_ChiTietHoaDon.Controls.Add(this.lbl_GiamGia);
            this.gpb_ChiTietHoaDon.Controls.Add(this.lbl_SoLuong);
            this.gpb_ChiTietHoaDon.Controls.Add(this.lbl_Gia);
            this.gpb_ChiTietHoaDon.Controls.Add(this.cbo_ThucDon);
            this.gpb_ChiTietHoaDon.Controls.Add(this.lbl_MonAn);
            this.gpb_ChiTietHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_ChiTietHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gpb_ChiTietHoaDon.Location = new System.Drawing.Point(12, 94);
            this.gpb_ChiTietHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpb_ChiTietHoaDon.Name = "gpb_ChiTietHoaDon";
            this.gpb_ChiTietHoaDon.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpb_ChiTietHoaDon.Size = new System.Drawing.Size(757, 79);
            this.gpb_ChiTietHoaDon.TabIndex = 56;
            this.gpb_ChiTietHoaDon.TabStop = false;
            this.gpb_ChiTietHoaDon.Text = "Chi tiết hóa đơn";
            // 
            // cbo_GiamGia
            // 
            this.cbo_GiamGia.FormattingEnabled = true;
            this.cbo_GiamGia.Location = new System.Drawing.Point(565, 38);
            this.cbo_GiamGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_GiamGia.Name = "cbo_GiamGia";
            this.cbo_GiamGia.Size = new System.Drawing.Size(104, 28);
            this.cbo_GiamGia.TabIndex = 10;
            // 
            // cbo_SoLuong
            // 
            this.cbo_SoLuong.FormattingEnabled = true;
            this.cbo_SoLuong.Location = new System.Drawing.Point(437, 39);
            this.cbo_SoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_SoLuong.Name = "cbo_SoLuong";
            this.cbo_SoLuong.Size = new System.Drawing.Size(101, 28);
            this.cbo_SoLuong.TabIndex = 6;
            // 
            // txt_Gia
            // 
            this.txt_Gia.Location = new System.Drawing.Point(264, 39);
            this.txt_Gia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(153, 27);
            this.txt_Gia.TabIndex = 6;
            // 
            // btn_Ghi
            // 
            this.btn_Ghi.Location = new System.Drawing.Point(692, 34);
            this.btn_Ghi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Ghi.Name = "btn_Ghi";
            this.btn_Ghi.Size = new System.Drawing.Size(56, 32);
            this.btn_Ghi.TabIndex = 6;
            this.btn_Ghi.Text = "Ghi";
            this.btn_Ghi.UseVisualStyleBackColor = true;
            // 
            // lbl_GiamGia
            // 
            this.lbl_GiamGia.AutoSize = true;
            this.lbl_GiamGia.ForeColor = System.Drawing.Color.Black;
            this.lbl_GiamGia.Location = new System.Drawing.Point(561, 20);
            this.lbl_GiamGia.Name = "lbl_GiamGia";
            this.lbl_GiamGia.Size = new System.Drawing.Size(76, 20);
            this.lbl_GiamGia.TabIndex = 9;
            this.lbl_GiamGia.Text = "Giảm giá";
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.ForeColor = System.Drawing.Color.Black;
            this.lbl_SoLuong.Location = new System.Drawing.Point(434, 20);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(74, 20);
            this.lbl_SoLuong.TabIndex = 8;
            this.lbl_SoLuong.Text = "Số lượng";
            // 
            // lbl_Gia
            // 
            this.lbl_Gia.AutoSize = true;
            this.lbl_Gia.ForeColor = System.Drawing.Color.Black;
            this.lbl_Gia.Location = new System.Drawing.Point(260, 20);
            this.lbl_Gia.Name = "lbl_Gia";
            this.lbl_Gia.Size = new System.Drawing.Size(35, 20);
            this.lbl_Gia.TabIndex = 7;
            this.lbl_Gia.Text = "Giá";
            // 
            // cbo_ThucDon
            // 
            this.cbo_ThucDon.FormattingEnabled = true;
            this.cbo_ThucDon.Location = new System.Drawing.Point(10, 39);
            this.cbo_ThucDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_ThucDon.Name = "cbo_ThucDon";
            this.cbo_ThucDon.Size = new System.Drawing.Size(235, 28);
            this.cbo_ThucDon.TabIndex = 6;
            // 
            // lbl_MonAn
            // 
            this.lbl_MonAn.AutoSize = true;
            this.lbl_MonAn.ForeColor = System.Drawing.Color.Black;
            this.lbl_MonAn.Location = new System.Drawing.Point(7, 20);
            this.lbl_MonAn.Name = "lbl_MonAn";
            this.lbl_MonAn.Size = new System.Drawing.Size(64, 20);
            this.lbl_MonAn.TabIndex = 6;
            this.lbl_MonAn.Text = "Món ăn";
            // 
            // gpb_HoaDonXuat
            // 
            this.gpb_HoaDonXuat.Controls.Add(this.textBox1);
            this.gpb_HoaDonXuat.Controls.Add(this.dateTimePicker1);
            this.gpb_HoaDonXuat.Controls.Add(this.cbo_NhaCC);
            this.gpb_HoaDonXuat.Controls.Add(this.btn_TaoHoaDon);
            this.gpb_HoaDonXuat.Controls.Add(this.lbl_NhanVien);
            this.gpb_HoaDonXuat.Controls.Add(this.lbl_ThoiGian);
            this.gpb_HoaDonXuat.Controls.Add(this.lbl_NhaCC);
            this.gpb_HoaDonXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_HoaDonXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gpb_HoaDonXuat.Location = new System.Drawing.Point(12, 13);
            this.gpb_HoaDonXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpb_HoaDonXuat.Name = "gpb_HoaDonXuat";
            this.gpb_HoaDonXuat.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpb_HoaDonXuat.Size = new System.Drawing.Size(757, 73);
            this.gpb_HoaDonXuat.TabIndex = 55;
            this.gpb_HoaDonXuat.TabStop = false;
            this.gpb_HoaDonXuat.Text = "Hóa đơn xuất";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(528, 39);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 27);
            this.textBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(350, 39);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 27);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // cbo_NhaCC
            // 
            this.cbo_NhaCC.FormattingEnabled = true;
            this.cbo_NhaCC.Location = new System.Drawing.Point(167, 39);
            this.cbo_NhaCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_NhaCC.Name = "cbo_NhaCC";
            this.cbo_NhaCC.Size = new System.Drawing.Size(175, 28);
            this.cbo_NhaCC.TabIndex = 1;
            // 
            // btn_TaoHoaDon
            // 
            this.btn_TaoHoaDon.Location = new System.Drawing.Point(7, 30);
            this.btn_TaoHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            this.btn_TaoHoaDon.Size = new System.Drawing.Size(132, 38);
            this.btn_TaoHoaDon.TabIndex = 1;
            this.btn_TaoHoaDon.Text = "Tạo hóa đơn";
            this.btn_TaoHoaDon.UseVisualStyleBackColor = true;
            // 
            // lbl_NhanVien
            // 
            this.lbl_NhanVien.AutoSize = true;
            this.lbl_NhanVien.ForeColor = System.Drawing.Color.Black;
            this.lbl_NhanVien.Location = new System.Drawing.Point(525, 20);
            this.lbl_NhanVien.Name = "lbl_NhanVien";
            this.lbl_NhanVien.Size = new System.Drawing.Size(83, 20);
            this.lbl_NhanVien.TabIndex = 3;
            this.lbl_NhanVien.Text = "Nhân viên";
            // 
            // lbl_ThoiGian
            // 
            this.lbl_ThoiGian.AutoSize = true;
            this.lbl_ThoiGian.ForeColor = System.Drawing.Color.Black;
            this.lbl_ThoiGian.Location = new System.Drawing.Point(346, 20);
            this.lbl_ThoiGian.Name = "lbl_ThoiGian";
            this.lbl_ThoiGian.Size = new System.Drawing.Size(77, 20);
            this.lbl_ThoiGian.TabIndex = 2;
            this.lbl_ThoiGian.Text = "Thời gian";
            // 
            // lbl_NhaCC
            // 
            this.lbl_NhaCC.AutoSize = true;
            this.lbl_NhaCC.ForeColor = System.Drawing.Color.Black;
            this.lbl_NhaCC.Location = new System.Drawing.Point(163, 20);
            this.lbl_NhaCC.Name = "lbl_NhaCC";
            this.lbl_NhaCC.Size = new System.Drawing.Size(112, 20);
            this.lbl_NhaCC.TabIndex = 1;
            this.lbl_NhaCC.Text = "Nhà cung cấp";
            // 
            // lbl_TongTienGiamGia
            // 
            this.lbl_TongTienGiamGia.AutoSize = true;
            this.lbl_TongTienGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTienGiamGia.ForeColor = System.Drawing.Color.Black;
            this.lbl_TongTienGiamGia.Location = new System.Drawing.Point(14, 488);
            this.lbl_TongTienGiamGia.Name = "lbl_TongTienGiamGia";
            this.lbl_TongTienGiamGia.Size = new System.Drawing.Size(146, 20);
            this.lbl_TongTienGiamGia.TabIndex = 64;
            this.lbl_TongTienGiamGia.Text = "Tổng tiền giảm giá";
            // 
            // txt_TongTienGiamGia
            // 
            this.txt_TongTienGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTienGiamGia.Location = new System.Drawing.Point(168, 484);
            this.txt_TongTienGiamGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TongTienGiamGia.Name = "txt_TongTienGiamGia";
            this.txt_TongTienGiamGia.Size = new System.Drawing.Size(164, 27);
            this.txt_TongTienGiamGia.TabIndex = 69;
            // 
            // txt_TongTienGia
            // 
            this.txt_TongTienGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTienGia.Location = new System.Drawing.Point(168, 444);
            this.txt_TongTienGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TongTienGia.Name = "txt_TongTienGia";
            this.txt_TongTienGia.Size = new System.Drawing.Size(164, 27);
            this.txt_TongTienGia.TabIndex = 68;
            // 
            // btn_InHD
            // 
            this.btn_InHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InHD.Location = new System.Drawing.Point(403, 484);
            this.btn_InHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_InHD.Name = "btn_InHD";
            this.btn_InHD.Size = new System.Drawing.Size(104, 39);
            this.btn_InHD.TabIndex = 66;
            this.btn_InHD.Text = "In hóa đơn";
            this.btn_InHD.UseVisualStyleBackColor = true;
            // 
            // lbl_TongTienPhaiTra
            // 
            this.lbl_TongTienPhaiTra.AutoSize = true;
            this.lbl_TongTienPhaiTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTienPhaiTra.ForeColor = System.Drawing.Color.Black;
            this.lbl_TongTienPhaiTra.Location = new System.Drawing.Point(14, 532);
            this.lbl_TongTienPhaiTra.Name = "lbl_TongTienPhaiTra";
            this.lbl_TongTienPhaiTra.Size = new System.Drawing.Size(139, 20);
            this.lbl_TongTienPhaiTra.TabIndex = 65;
            this.lbl_TongTienPhaiTra.Text = "Tổng tiền phải trả";
            // 
            // lbl_TongTienGia
            // 
            this.lbl_TongTienGia.AutoSize = true;
            this.lbl_TongTienGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTienGia.ForeColor = System.Drawing.Color.Black;
            this.lbl_TongTienGia.Location = new System.Drawing.Point(14, 447);
            this.lbl_TongTienGia.Name = "lbl_TongTienGia";
            this.lbl_TongTienGia.Size = new System.Drawing.Size(105, 20);
            this.lbl_TongTienGia.TabIndex = 63;
            this.lbl_TongTienGia.Text = "Tổng tiền giá";
            // 
            // btn_LuuHD
            // 
            this.btn_LuuHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuuHD.Location = new System.Drawing.Point(524, 484);
            this.btn_LuuHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_LuuHD.Name = "btn_LuuHD";
            this.btn_LuuHD.Size = new System.Drawing.Size(104, 39);
            this.btn_LuuHD.TabIndex = 67;
            this.btn_LuuHD.Text = "Lưu hóa đơn";
            this.btn_LuuHD.UseVisualStyleBackColor = true;
            // 
            // txt_TongTienPhaiTra
            // 
            this.txt_TongTienPhaiTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTienPhaiTra.Location = new System.Drawing.Point(168, 528);
            this.txt_TongTienPhaiTra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TongTienPhaiTra.Name = "txt_TongTienPhaiTra";
            this.txt_TongTienPhaiTra.Size = new System.Drawing.Size(164, 27);
            this.txt_TongTienPhaiTra.TabIndex = 70;
            // 
            // Frm_HoaDonXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.lbl_TongTienGiamGia);
            this.Controls.Add(this.txt_TongTienGiamGia);
            this.Controls.Add(this.txt_TongTienGia);
            this.Controls.Add(this.btn_InHD);
            this.Controls.Add(this.lbl_TongTienPhaiTra);
            this.Controls.Add(this.lbl_TongTienGia);
            this.Controls.Add(this.btn_LuuHD);
            this.Controls.Add(this.txt_TongTienPhaiTra);
            this.Controls.Add(this.gpb_HoaDon);
            this.Controls.Add(this.gpb_ChiTietHoaDon);
            this.Controls.Add(this.gpb_HoaDonXuat);
            this.Name = "Frm_HoaDonXuat";
            this.Text = "Frm_HoaDonXuat";
            this.gpb_HoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvv_DSHoaDon)).EndInit();
            this.gpb_ChiTietHoaDon.ResumeLayout(false);
            this.gpb_ChiTietHoaDon.PerformLayout();
            this.gpb_HoaDonXuat.ResumeLayout(false);
            this.gpb_HoaDonXuat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_HoaDon;
        private System.Windows.Forms.DataGridView gvv_DSHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENGIAMGIA;
        private System.Windows.Forms.GroupBox gpb_ChiTietHoaDon;
        private System.Windows.Forms.ComboBox cbo_GiamGia;
        private System.Windows.Forms.ComboBox cbo_SoLuong;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.Button btn_Ghi;
        private System.Windows.Forms.Label lbl_GiamGia;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label lbl_Gia;
        private System.Windows.Forms.ComboBox cbo_ThucDon;
        private System.Windows.Forms.Label lbl_MonAn;
        private System.Windows.Forms.GroupBox gpb_HoaDonXuat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbo_NhaCC;
        private System.Windows.Forms.Button btn_TaoHoaDon;
        private System.Windows.Forms.Label lbl_NhanVien;
        private System.Windows.Forms.Label lbl_ThoiGian;
        private System.Windows.Forms.Label lbl_NhaCC;
        private System.Windows.Forms.Label lbl_TongTienGiamGia;
        private System.Windows.Forms.TextBox txt_TongTienGiamGia;
        private System.Windows.Forms.TextBox txt_TongTienGia;
        private System.Windows.Forms.Button btn_InHD;
        private System.Windows.Forms.Label lbl_TongTienPhaiTra;
        private System.Windows.Forms.Label lbl_TongTienGia;
        private System.Windows.Forms.Button btn_LuuHD;
        private System.Windows.Forms.TextBox txt_TongTienPhaiTra;
    }
}
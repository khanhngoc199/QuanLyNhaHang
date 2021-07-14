namespace QuanLyNhaHang
{
    partial class Frm_GoiMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GoiMon));
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nmGiamGia = new System.Windows.Forms.NumericUpDown();
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbGopBan = new System.Windows.Forms.ComboBox();
            this.btGopban = new System.Windows.Forms.Button();
            this.cbChuyenBan = new System.Windows.Forms.ComboBox();
            this.btChuyenban = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbMonAn = new System.Windows.Forms.ComboBox();
            this.cbNhomMonAn = new System.Windows.Forms.ComboBox();
            this.flpBan = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(564, 409);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 23);
            this.label15.TabIndex = 16;
            this.label15.Text = "Giảm giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "(%)";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTongTien.Location = new System.Drawing.Point(692, 436);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(126, 30);
            this.txtTongTien.TabIndex = 13;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(692, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tổng tiền:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(820, 442);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 23);
            this.label13.TabIndex = 14;
            this.label13.Text = "VNĐ";
            // 
            // nmGiamGia
            // 
            this.nmGiamGia.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmGiamGia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nmGiamGia.Location = new System.Drawing.Point(568, 436);
            this.nmGiamGia.Name = "nmGiamGia";
            this.nmGiamGia.Size = new System.Drawing.Size(58, 30);
            this.nmGiamGia.TabIndex = 12;
            this.nmGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvHoaDon.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvHoaDon.GridLines = true;
            this.lvHoaDon.HideSelection = false;
            this.lvHoaDon.Location = new System.Drawing.Point(398, 98);
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(479, 196);
            this.lvHoaDon.TabIndex = 18;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 142;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 119;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 125;
            // 
            // cbGopBan
            // 
            this.cbGopBan.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGopBan.FormattingEnabled = true;
            this.cbGopBan.Location = new System.Drawing.Point(550, 350);
            this.cbGopBan.Name = "cbGopBan";
            this.cbGopBan.Size = new System.Drawing.Size(145, 31);
            this.cbGopBan.TabIndex = 22;
            // 
            // btGopban
            // 
            this.btGopban.BackColor = System.Drawing.SystemColors.Control;
            this.btGopban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGopban.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGopban.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btGopban.Location = new System.Drawing.Point(550, 300);
            this.btGopban.Name = "btGopban";
            this.btGopban.Size = new System.Drawing.Size(145, 44);
            this.btGopban.TabIndex = 21;
            this.btGopban.Text = "Gộp bàn";
            this.btGopban.UseVisualStyleBackColor = false;
            // 
            // cbChuyenBan
            // 
            this.cbChuyenBan.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChuyenBan.FormattingEnabled = true;
            this.cbChuyenBan.Location = new System.Drawing.Point(732, 350);
            this.cbChuyenBan.Name = "cbChuyenBan";
            this.cbChuyenBan.Size = new System.Drawing.Size(145, 31);
            this.cbChuyenBan.TabIndex = 20;
            // 
            // btChuyenban
            // 
            this.btChuyenban.BackColor = System.Drawing.SystemColors.Control;
            this.btChuyenban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChuyenban.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChuyenban.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btChuyenban.Location = new System.Drawing.Point(732, 300);
            this.btChuyenban.Name = "btChuyenban";
            this.btChuyenban.Size = new System.Drawing.Size(145, 44);
            this.btChuyenban.TabIndex = 19;
            this.btChuyenban.Text = "Chuyển bàn";
            this.btChuyenban.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(678, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 25);
            this.label14.TabIndex = 26;
            this.label14.Text = "Số lượng ";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmSoLuong.Location = new System.Drawing.Point(678, 59);
            this.nmSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmSoLuong.Name = "nmSoLuong";
            this.nmSoLuong.Size = new System.Drawing.Size(90, 30);
            this.nmSoLuong.TabIndex = 25;
            this.nmSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbMonAn
            // 
            this.cbMonAn.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonAn.FormattingEnabled = true;
            this.cbMonAn.Location = new System.Drawing.Point(398, 60);
            this.cbMonAn.Name = "cbMonAn";
            this.cbMonAn.Size = new System.Drawing.Size(254, 31);
            this.cbMonAn.TabIndex = 24;
            // 
            // cbNhomMonAn
            // 
            this.cbNhomMonAn.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhomMonAn.FormattingEnabled = true;
            this.cbNhomMonAn.Location = new System.Drawing.Point(398, 23);
            this.cbNhomMonAn.Name = "cbNhomMonAn";
            this.cbNhomMonAn.Size = new System.Drawing.Size(254, 31);
            this.cbNhomMonAn.TabIndex = 1;
            this.cbNhomMonAn.SelectedIndexChanged += new System.EventHandler(this.cbNhomMonAn_SelectedIndexChanged);
            // 
            // flpBan
            // 
            this.flpBan.AutoScroll = true;
            this.flpBan.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flpBan.Location = new System.Drawing.Point(12, 21);
            this.flpBan.Name = "flpBan";
            this.flpBan.Size = new System.Drawing.Size(376, 446);
            this.flpBan.TabIndex = 58;
            // 
            // btnThemMon
            // 
            this.btnThemMon.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.Image = global::QuanLyNhaHang.Properties.Resources.add32_32;
            this.btnThemMon.Location = new System.Drawing.Point(788, 23);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(89, 69);
            this.btnThemMon.TabIndex = 27;
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Image = global::QuanLyNhaHang.Properties.Resources.cash_32;
            this.btnThanhToan.Location = new System.Drawing.Point(413, 408);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(120, 61);
            this.btnThanhToan.TabIndex = 17;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // Frm_GoiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 480);
            this.Controls.Add(this.flpBan);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.nmSoLuong);
            this.Controls.Add(this.cbMonAn);
            this.Controls.Add(this.cbNhomMonAn);
            this.Controls.Add(this.cbGopBan);
            this.Controls.Add(this.btGopban);
            this.Controls.Add(this.cbChuyenBan);
            this.Controls.Add(this.btChuyenban);
            this.Controls.Add(this.lvHoaDon);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.nmGiamGia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_GoiMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gọi món";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_GoiMon_FormClosing);
            this.Load += new System.EventHandler(this.Frm_GoiMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nmGiamGia;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.ListView lvHoaDon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cbGopBan;
        private System.Windows.Forms.Button btGopban;
        private System.Windows.Forms.ComboBox cbChuyenBan;
        private System.Windows.Forms.Button btChuyenban;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nmSoLuong;
        private System.Windows.Forms.ComboBox cbMonAn;
        private System.Windows.Forms.ComboBox cbNhomMonAn;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.FlowLayoutPanel flpBan;
    }
}
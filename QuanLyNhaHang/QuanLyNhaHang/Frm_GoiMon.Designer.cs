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
            this.button1 = new System.Windows.Forms.Button();
            this.cbbban = new System.Windows.Forms.ComboBox();
            this.lvhd = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.gpb_TongTienThanhToan = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.lbl_TongTienThanhToan = new System.Windows.Forms.Label();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.dtp_ThoiGian = new System.Windows.Forms.DateTimePicker();
            this.fltable = new System.Windows.Forms.FlowLayoutPanel();
            this.dgv_DSBan = new System.Windows.Forms.DataGridView();
            this.MABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_InHoaDon = new System.Windows.Forms.Button();
            this.btn_GoiMon = new System.Windows.Forms.Button();
            this.gpb_TongTienThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSBan)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(605, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 62;
            this.button1.Text = "Gộp bàn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbbban
            // 
            this.cbbban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbban.FormattingEnabled = true;
            this.cbbban.Location = new System.Drawing.Point(605, 290);
            this.cbbban.Name = "cbbban";
            this.cbbban.Size = new System.Drawing.Size(86, 28);
            this.cbbban.TabIndex = 63;
            // 
            // lvhd
            // 
            this.lvhd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvhd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvhd.GridLines = true;
            this.lvhd.HideSelection = false;
            this.lvhd.Location = new System.Drawing.Point(521, 324);
            this.lvhd.Name = "lvhd";
            this.lvhd.Size = new System.Drawing.Size(609, 160);
            this.lvhd.TabIndex = 65;
            this.lvhd.UseCompatibleStateImageBehavior = false;
            this.lvhd.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Hóa Đơn";
            this.columnHeader1.Width = 129;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Bàn ";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 84;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên món ăn";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số lượng";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 84;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Đơn giá";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 102;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Đơn Vị";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_LamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LamMoi.Location = new System.Drawing.Point(1033, 199);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(97, 35);
            this.btn_LamMoi.TabIndex = 61;
            this.btn_LamMoi.Text = "Làm Mới";
            this.btn_LamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            // 
            // gpb_TongTienThanhToan
            // 
            this.gpb_TongTienThanhToan.BackColor = System.Drawing.Color.White;
            this.gpb_TongTienThanhToan.Controls.Add(this.label1);
            this.gpb_TongTienThanhToan.Controls.Add(this.txttongtien);
            this.gpb_TongTienThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_TongTienThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gpb_TongTienThanhToan.Location = new System.Drawing.Point(816, 493);
            this.gpb_TongTienThanhToan.Name = "gpb_TongTienThanhToan";
            this.gpb_TongTienThanhToan.Size = new System.Drawing.Size(302, 39);
            this.gpb_TongTienThanhToan.TabIndex = 67;
            this.gpb_TongTienThanhToan.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(251, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "VND";
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(146, 11);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.ReadOnly = true;
            this.txttongtien.Size = new System.Drawing.Size(102, 27);
            this.txttongtien.TabIndex = 4;
            this.txttongtien.Text = "0";
            // 
            // lbl_TongTienThanhToan
            // 
            this.lbl_TongTienThanhToan.AutoSize = true;
            this.lbl_TongTienThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTienThanhToan.Location = new System.Drawing.Point(785, 507);
            this.lbl_TongTienThanhToan.Name = "lbl_TongTienThanhToan";
            this.lbl_TongTienThanhToan.Size = new System.Drawing.Size(171, 20);
            this.lbl_TongTienThanhToan.TabIndex = 3;
            this.lbl_TongTienThanhToan.Text = "Tổng tiền thanh toán :";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThanhToan.Location = new System.Drawing.Point(691, 199);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(126, 36);
            this.btn_ThanhToan.TabIndex = 59;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            // 
            // dtp_ThoiGian
            // 
            this.dtp_ThoiGian.CustomFormat = "dd/MM/yyyy";
            this.dtp_ThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ThoiGian.Location = new System.Drawing.Point(952, 291);
            this.dtp_ThoiGian.Name = "dtp_ThoiGian";
            this.dtp_ThoiGian.Size = new System.Drawing.Size(178, 27);
            this.dtp_ThoiGian.TabIndex = 64;
            // 
            // fltable
            // 
            this.fltable.AutoScroll = true;
            this.fltable.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.fltable.Location = new System.Drawing.Point(12, 12);
            this.fltable.Name = "fltable";
            this.fltable.Size = new System.Drawing.Size(503, 520);
            this.fltable.TabIndex = 68;
            // 
            // dgv_DSBan
            // 
            this.dgv_DSBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MABAN,
            this.TENBAN,
            this.MAKV,
            this.TRANGTHAI});
            this.dgv_DSBan.Location = new System.Drawing.Point(521, 12);
            this.dgv_DSBan.Name = "dgv_DSBan";
            this.dgv_DSBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSBan.Size = new System.Drawing.Size(609, 167);
            this.dgv_DSBan.TabIndex = 66;
            // 
            // MABAN
            // 
            this.MABAN.DataPropertyName = "MABAN";
            this.MABAN.HeaderText = "Mã Bàn";
            this.MABAN.Name = "MABAN";
            // 
            // TENBAN
            // 
            this.TENBAN.DataPropertyName = "TENBAN";
            this.TENBAN.HeaderText = "Tên Bàn";
            this.TENBAN.Name = "TENBAN";
            // 
            // MAKV
            // 
            this.MAKV.DataPropertyName = "MAKV";
            this.MAKV.HeaderText = "Mã Khu Vực";
            this.MAKV.Name = "MAKV";
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            this.TRANGTHAI.HeaderText = "Trạng Thái";
            this.TRANGTHAI.Name = "TRANGTHAI";
            // 
            // btn_InHoaDon
            // 
            this.btn_InHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_InHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InHoaDon.Location = new System.Drawing.Point(873, 200);
            this.btn_InHoaDon.Name = "btn_InHoaDon";
            this.btn_InHoaDon.Size = new System.Drawing.Size(97, 35);
            this.btn_InHoaDon.TabIndex = 60;
            this.btn_InHoaDon.Text = "In hóa đơn";
            this.btn_InHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_InHoaDon.UseVisualStyleBackColor = true;
            // 
            // btn_GoiMon
            // 
            this.btn_GoiMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_GoiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoiMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GoiMon.Location = new System.Drawing.Point(521, 200);
            this.btn_GoiMon.Name = "btn_GoiMon";
            this.btn_GoiMon.Size = new System.Drawing.Size(86, 35);
            this.btn_GoiMon.TabIndex = 58;
            this.btn_GoiMon.Text = "Gọi món";
            this.btn_GoiMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_GoiMon.UseVisualStyleBackColor = true;
            // 
            // Frm_GoiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 548);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbbban);
            this.Controls.Add(this.lbl_TongTienThanhToan);
            this.Controls.Add(this.lvhd);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.gpb_TongTienThanhToan);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.dtp_ThoiGian);
            this.Controls.Add(this.fltable);
            this.Controls.Add(this.dgv_DSBan);
            this.Controls.Add(this.btn_InHoaDon);
            this.Controls.Add(this.btn_GoiMon);
            this.Name = "Frm_GoiMon";
            this.Text = "Frm_GoiMon";
            this.gpb_TongTienThanhToan.ResumeLayout(false);
            this.gpb_TongTienThanhToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbbban;
        private System.Windows.Forms.ListView lvhd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.GroupBox gpb_TongTienThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label lbl_TongTienThanhToan;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.DateTimePicker dtp_ThoiGian;
        private System.Windows.Forms.FlowLayoutPanel fltable;
        private System.Windows.Forms.DataGridView dgv_DSBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
        private System.Windows.Forms.Button btn_InHoaDon;
        private System.Windows.Forms.Button btn_GoiMon;
    }
}
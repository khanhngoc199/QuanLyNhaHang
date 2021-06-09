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
            this.btnGopBan = new System.Windows.Forms.Button();
            this.cbbBan = new System.Windows.Forms.ComboBox();
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.gpb_TongTienThanhToan = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.lbl_TongTienThanhToan = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.flTable = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvDanhSachBan = new System.Windows.Forms.DataGridView();
            this.MABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.btnGoiMon = new System.Windows.Forms.Button();
            this.gpb_TongTienThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGopBan
            // 
            this.btnGopBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGopBan.Location = new System.Drawing.Point(605, 250);
            this.btnGopBan.Name = "btnGopBan";
            this.btnGopBan.Size = new System.Drawing.Size(86, 34);
            this.btnGopBan.TabIndex = 62;
            this.btnGopBan.Text = "Gộp bàn";
            this.btnGopBan.UseVisualStyleBackColor = true;
            this.btnGopBan.Click += new System.EventHandler(this.btnGopBan_Click);
            // 
            // cbbBan
            // 
            this.cbbBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBan.FormattingEnabled = true;
            this.cbbBan.Location = new System.Drawing.Point(605, 290);
            this.cbbBan.Name = "cbbBan";
            this.cbbBan.Size = new System.Drawing.Size(86, 28);
            this.cbbBan.TabIndex = 63;
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvHoaDon.GridLines = true;
            this.lvHoaDon.HideSelection = false;
            this.lvHoaDon.Location = new System.Drawing.Point(521, 324);
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(609, 160);
            this.lvHoaDon.TabIndex = 65;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvHoaDon.View = System.Windows.Forms.View.Details;
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
            // btnLamMoi
            // 
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(1033, 199);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(97, 35);
            this.btnLamMoi.TabIndex = 61;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
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
            // btnThanhToan
            // 
            this.btnThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(691, 199);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(126, 36);
            this.btnThanhToan.TabIndex = 59;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.CustomFormat = "dd/MM/yyyy";
            this.dtpThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGian.Location = new System.Drawing.Point(952, 291);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(178, 27);
            this.dtpThoiGian.TabIndex = 64;
            // 
            // flTable
            // 
            this.flTable.AutoScroll = true;
            this.flTable.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flTable.Location = new System.Drawing.Point(12, 12);
            this.flTable.Name = "flTable";
            this.flTable.Size = new System.Drawing.Size(503, 520);
            this.flTable.TabIndex = 68;
            // 
            // dgvDanhSachBan
            // 
            this.dgvDanhSachBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MABAN,
            this.TENBAN,
            this.MAKV,
            this.TRANGTHAI});
            this.dgvDanhSachBan.Location = new System.Drawing.Point(521, 12);
            this.dgvDanhSachBan.Name = "dgvDanhSachBan";
            this.dgvDanhSachBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachBan.Size = new System.Drawing.Size(609, 167);
            this.dgvDanhSachBan.TabIndex = 66;
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
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHoaDon.Location = new System.Drawing.Point(873, 200);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(97, 35);
            this.btnInHoaDon.TabIndex = 60;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog1";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // btnGoiMon
            // 
            this.btnGoiMon.Location = new System.Drawing.Point(551, 199);
            this.btnGoiMon.Name = "btnGoiMon";
            this.btnGoiMon.Size = new System.Drawing.Size(75, 23);
            this.btnGoiMon.TabIndex = 69;
            this.btnGoiMon.Text = "Gọi món";
            this.btnGoiMon.UseVisualStyleBackColor = true;
            this.btnGoiMon.Click += new System.EventHandler(this.btnGoiMon_Click);
            // 
            // Frm_GoiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 548);
            this.Controls.Add(this.btnGoiMon);
            this.Controls.Add(this.btnGopBan);
            this.Controls.Add(this.cbbBan);
            this.Controls.Add(this.lbl_TongTienThanhToan);
            this.Controls.Add(this.lvHoaDon);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.gpb_TongTienThanhToan);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.dtpThoiGian);
            this.Controls.Add(this.flTable);
            this.Controls.Add(this.dgvDanhSachBan);
            this.Controls.Add(this.btnInHoaDon);
            this.Name = "Frm_GoiMon";
            this.Text = "Frm_GoiMon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_GoiMon_FormClosing);
            this.Load += new System.EventHandler(this.Frm_GoiMon_Load);
            this.gpb_TongTienThanhToan.ResumeLayout(false);
            this.gpb_TongTienThanhToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGopBan;
        private System.Windows.Forms.ComboBox cbbBan;
        private System.Windows.Forms.ListView lvHoaDon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox gpb_TongTienThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label lbl_TongTienThanhToan;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.FlowLayoutPanel flTable;
        private System.Windows.Forms.DataGridView dgvDanhSachBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Button btnGoiMon;
    }
}
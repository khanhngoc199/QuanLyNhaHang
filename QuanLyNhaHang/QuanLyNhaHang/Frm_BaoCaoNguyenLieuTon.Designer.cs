namespace DTO
{
    partial class Frm_BaoCaoNguyenLieuTon
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
            this.dtpNhomNguyenLieu = new System.Windows.Forms.DateTimePicker();
            this.dgvBaoCaoNguyenLieuTon = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNGUYENLIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONVITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNguyenlieuton = new System.Windows.Forms.Label();
            this.cmbNhomNguyenLieu = new System.Windows.Forms.ComboBox();
            this.lblNhomNguyenLieu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoNguyenLieuTon)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNhomNguyenLieu
            // 
            this.dtpNhomNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNhomNguyenLieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNhomNguyenLieu.Location = new System.Drawing.Point(392, 51);
            this.dtpNhomNguyenLieu.Name = "dtpNhomNguyenLieu";
            this.dtpNhomNguyenLieu.Size = new System.Drawing.Size(135, 27);
            this.dtpNhomNguyenLieu.TabIndex = 17;
            // 
            // dgvBaoCaoNguyenLieuTon
            // 
            this.dgvBaoCaoNguyenLieuTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCaoNguyenLieuTon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TENNGUYENLIEU,
            this.DONVITINH,
            this.SOLUONG,
            this.TONGTIEN});
            this.dgvBaoCaoNguyenLieuTon.Location = new System.Drawing.Point(14, 104);
            this.dgvBaoCaoNguyenLieuTon.Name = "dgvBaoCaoNguyenLieuTon";
            this.dgvBaoCaoNguyenLieuTon.Size = new System.Drawing.Size(513, 177);
            this.dgvBaoCaoNguyenLieuTon.TabIndex = 16;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // TENNGUYENLIEU
            // 
            this.TENNGUYENLIEU.HeaderText = "TÊN NGUYÊN LIỆU";
            this.TENNGUYENLIEU.Name = "TENNGUYENLIEU";
            this.TENNGUYENLIEU.Width = 150;
            // 
            // DONVITINH
            // 
            this.DONVITINH.HeaderText = "ĐƠN VỊ TÍNH";
            this.DONVITINH.Name = "DONVITINH";
            // 
            // SOLUONG
            // 
            this.SOLUONG.HeaderText = "SỐ LƯỢNG";
            this.SOLUONG.Name = "SOLUONG";
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.HeaderText = "TỔNG TIỀN";
            this.TONGTIEN.Name = "TONGTIEN";
            // 
            // lblNguyenlieuton
            // 
            this.lblNguyenlieuton.AutoSize = true;
            this.lblNguyenlieuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguyenlieuton.Location = new System.Drawing.Point(120, 12);
            this.lblNguyenlieuton.Name = "lblNguyenlieuton";
            this.lblNguyenlieuton.Size = new System.Drawing.Size(319, 16);
            this.lblNguyenlieuton.TabIndex = 18;
            this.lblNguyenlieuton.Text = "BÁO CÁO NGUYÊN LIỆU TỒN TRONG NGÀY";
            // 
            // cmbNhomNguyenLieu
            // 
            this.cmbNhomNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhomNguyenLieu.FormattingEnabled = true;
            this.cmbNhomNguyenLieu.Location = new System.Drawing.Point(171, 50);
            this.cmbNhomNguyenLieu.Name = "cmbNhomNguyenLieu";
            this.cmbNhomNguyenLieu.Size = new System.Drawing.Size(185, 28);
            this.cmbNhomNguyenLieu.TabIndex = 15;
            // 
            // lblNhomNguyenLieu
            // 
            this.lblNhomNguyenLieu.AutoSize = true;
            this.lblNhomNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhomNguyenLieu.Location = new System.Drawing.Point(10, 53);
            this.lblNhomNguyenLieu.Name = "lblNhomNguyenLieu";
            this.lblNhomNguyenLieu.Size = new System.Drawing.Size(147, 20);
            this.lblNhomNguyenLieu.TabIndex = 14;
            this.lblNhomNguyenLieu.Text = "Nhóm nguyên liệu:";
            // 
            // Frm_BaoCaoNguyenLieuTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 311);
            this.Controls.Add(this.dtpNhomNguyenLieu);
            this.Controls.Add(this.dgvBaoCaoNguyenLieuTon);
            this.Controls.Add(this.lblNguyenlieuton);
            this.Controls.Add(this.cmbNhomNguyenLieu);
            this.Controls.Add(this.lblNhomNguyenLieu);
            this.Name = "Frm_BaoCaoNguyenLieuTon";
            this.Text = "Frm_BaoCaoNguyenLieuTon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoNguyenLieuTon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNhomNguyenLieu;
        private System.Windows.Forms.DataGridView dgvBaoCaoNguyenLieuTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNGUYENLIEU;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONVITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.Label lblNguyenlieuton;
        private System.Windows.Forms.ComboBox cmbNhomNguyenLieu;
        private System.Windows.Forms.Label lblNhomNguyenLieu;
    }
}
namespace QuanLyNhaHang
{
    partial class Frm_NhomNguyenLieu
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblQLNhomNguyenLieu = new System.Windows.Forms.Label();
            this.lblDSNhomNguyenLieu = new System.Windows.Forms.Label();
            this.grb_QLNhomNguyenLieu = new System.Windows.Forms.GroupBox();
            this.txttenNhomNguyenLieu = new System.Windows.Forms.TextBox();
            this.txtMaNhomNguyenLieu = new System.Windows.Forms.TextBox();
            this.lblTenNNL = new System.Windows.Forms.Label();
            this.lbllblMaNNL = new System.Windows.Forms.Label();
            this.grb_dsloaithucdon = new System.Windows.Forms.GroupBox();
            this.gvvDanhSachNhomNguyenLieu = new System.Windows.Forms.DataGridView();
            this.MANNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_QLNhomNguyenLieu.SuspendLayout();
            this.grb_dsloaithucdon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvvDanhSachNhomNguyenLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(282, 195);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(77, 39);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(182, 195);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 39);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(65, 195);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 39);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // lblQLNhomNguyenLieu
            // 
            this.lblQLNhomNguyenLieu.AutoSize = true;
            this.lblQLNhomNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLNhomNguyenLieu.Location = new System.Drawing.Point(112, 12);
            this.lblQLNhomNguyenLieu.Name = "lblQLNhomNguyenLieu";
            this.lblQLNhomNguyenLieu.Size = new System.Drawing.Size(219, 20);
            this.lblQLNhomNguyenLieu.TabIndex = 34;
            this.lblQLNhomNguyenLieu.Text = "Quản Lý Nhóm Nguyên Liệu";
            // 
            // lblDSNhomNguyenLieu
            // 
            this.lblDSNhomNguyenLieu.AutoSize = true;
            this.lblDSNhomNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSNhomNguyenLieu.Location = new System.Drawing.Point(517, 12);
            this.lblDSNhomNguyenLieu.Name = "lblDSNhomNguyenLieu";
            this.lblDSNhomNguyenLieu.Size = new System.Drawing.Size(239, 20);
            this.lblDSNhomNguyenLieu.TabIndex = 32;
            this.lblDSNhomNguyenLieu.Text = "Danh Sách Nhóm Nguyên Liệu";
            // 
            // grb_QLNhomNguyenLieu
            // 
            this.grb_QLNhomNguyenLieu.Controls.Add(this.txttenNhomNguyenLieu);
            this.grb_QLNhomNguyenLieu.Controls.Add(this.txtMaNhomNguyenLieu);
            this.grb_QLNhomNguyenLieu.Controls.Add(this.lblTenNNL);
            this.grb_QLNhomNguyenLieu.Controls.Add(this.lbllblMaNNL);
            this.grb_QLNhomNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_QLNhomNguyenLieu.Location = new System.Drawing.Point(12, 52);
            this.grb_QLNhomNguyenLieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grb_QLNhomNguyenLieu.Name = "grb_QLNhomNguyenLieu";
            this.grb_QLNhomNguyenLieu.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grb_QLNhomNguyenLieu.Size = new System.Drawing.Size(391, 115);
            this.grb_QLNhomNguyenLieu.TabIndex = 28;
            this.grb_QLNhomNguyenLieu.TabStop = false;
            // 
            // txttenNhomNguyenLieu
            // 
            this.txttenNhomNguyenLieu.Location = new System.Drawing.Point(192, 69);
            this.txttenNhomNguyenLieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttenNhomNguyenLieu.Name = "txttenNhomNguyenLieu";
            this.txttenNhomNguyenLieu.Size = new System.Drawing.Size(177, 27);
            this.txttenNhomNguyenLieu.TabIndex = 1;
            // 
            // txtMaNhomNguyenLieu
            // 
            this.txtMaNhomNguyenLieu.Location = new System.Drawing.Point(192, 24);
            this.txtMaNhomNguyenLieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNhomNguyenLieu.Name = "txtMaNhomNguyenLieu";
            this.txtMaNhomNguyenLieu.Size = new System.Drawing.Size(177, 27);
            this.txtMaNhomNguyenLieu.TabIndex = 0;
            // 
            // lblTenNNL
            // 
            this.lblTenNNL.AutoSize = true;
            this.lblTenNNL.Location = new System.Drawing.Point(16, 73);
            this.lblTenNNL.Name = "lblTenNNL";
            this.lblTenNNL.Size = new System.Drawing.Size(175, 20);
            this.lblTenNNL.TabIndex = 4;
            this.lblTenNNL.Text = "Tên Nhóm nguyên liệu";
            // 
            // lbllblMaNNL
            // 
            this.lbllblMaNNL.AutoSize = true;
            this.lbllblMaNNL.Location = new System.Drawing.Point(16, 29);
            this.lbllblMaNNL.Name = "lbllblMaNNL";
            this.lbllblMaNNL.Size = new System.Drawing.Size(170, 20);
            this.lbllblMaNNL.TabIndex = 3;
            this.lbllblMaNNL.Text = "Mã Nhóm nguyên liệu";
            // 
            // grb_dsloaithucdon
            // 
            this.grb_dsloaithucdon.Controls.Add(this.gvvDanhSachNhomNguyenLieu);
            this.grb_dsloaithucdon.Location = new System.Drawing.Point(426, 52);
            this.grb_dsloaithucdon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grb_dsloaithucdon.Name = "grb_dsloaithucdon";
            this.grb_dsloaithucdon.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grb_dsloaithucdon.Size = new System.Drawing.Size(528, 231);
            this.grb_dsloaithucdon.TabIndex = 35;
            this.grb_dsloaithucdon.TabStop = false;
            // 
            // gvvDanhSachNhomNguyenLieu
            // 
            this.gvvDanhSachNhomNguyenLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvvDanhSachNhomNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvvDanhSachNhomNguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANNL,
            this.TENNNL});
            this.gvvDanhSachNhomNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvvDanhSachNhomNguyenLieu.Location = new System.Drawing.Point(3, 19);
            this.gvvDanhSachNhomNguyenLieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvvDanhSachNhomNguyenLieu.Name = "gvvDanhSachNhomNguyenLieu";
            this.gvvDanhSachNhomNguyenLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvvDanhSachNhomNguyenLieu.Size = new System.Drawing.Size(522, 208);
            this.gvvDanhSachNhomNguyenLieu.TabIndex = 23;
            // 
            // MANNL
            // 
            this.MANNL.DataPropertyName = "MANNL";
            this.MANNL.HeaderText = "Mã Nhóm Nguyên Liệu";
            this.MANNL.Name = "MANNL";
            // 
            // TENNNL
            // 
            this.TENNNL.DataPropertyName = "TENNNL";
            this.TENNNL.HeaderText = "Tên Nhóm Nguyên Liệu";
            this.TENNNL.Name = "TENNNL";
            // 
            // Frm_NhomNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 315);
            this.Controls.Add(this.grb_dsloaithucdon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblQLNhomNguyenLieu);
            this.Controls.Add(this.lblDSNhomNguyenLieu);
            this.Controls.Add(this.grb_QLNhomNguyenLieu);
            this.Name = "Frm_NhomNguyenLieu";
            this.Text = "Frm_NhomNguyenLieu";
            this.grb_QLNhomNguyenLieu.ResumeLayout(false);
            this.grb_QLNhomNguyenLieu.PerformLayout();
            this.grb_dsloaithucdon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvvDanhSachNhomNguyenLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblQLNhomNguyenLieu;
        private System.Windows.Forms.Label lblDSNhomNguyenLieu;
        private System.Windows.Forms.GroupBox grb_QLNhomNguyenLieu;
        private System.Windows.Forms.TextBox txttenNhomNguyenLieu;
        private System.Windows.Forms.TextBox txtMaNhomNguyenLieu;
        private System.Windows.Forms.Label lblTenNNL;
        private System.Windows.Forms.Label lbllblMaNNL;
        private System.Windows.Forms.GroupBox grb_dsloaithucdon;
        private System.Windows.Forms.DataGridView gvvDanhSachNhomNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNNL;
    }
}
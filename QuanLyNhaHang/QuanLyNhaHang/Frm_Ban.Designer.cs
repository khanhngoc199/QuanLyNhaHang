namespace QuanLyNhaHang
{
    partial class Frm_Ban
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
            this.dgvDanhSachBan = new System.Windows.Forms.DataGridView();
            this.MABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lbl_dsBan = new System.Windows.Forms.Label();
            this.grb_ban = new System.Windows.Forms.GroupBox();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.txtMaBan = new System.Windows.Forms.TextBox();
            this.lsbTenKhuVuc = new System.Windows.Forms.ListBox();
            this.lsbTrangThai = new System.Windows.Forms.ListBox();
            this.lbl_trangthai = new System.Windows.Forms.Label();
            this.lbl_tenban = new System.Windows.Forms.Label();
            this.lbl_tenkv = new System.Windows.Forms.Label();
            this.lbl_maban = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbl_qlban = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBan)).BeginInit();
            this.grb_ban.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSachBan
            // 
            this.dgvDanhSachBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MABAN,
            this.TENBAN,
            this.MAKV,
            this.TRANGTHAI});
            this.dgvDanhSachBan.Location = new System.Drawing.Point(11, 49);
            this.dgvDanhSachBan.Name = "dgvDanhSachBan";
            this.dgvDanhSachBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachBan.Size = new System.Drawing.Size(443, 230);
            this.dgvDanhSachBan.TabIndex = 25;
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
            // btnXoa
            // 
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Enabled = false;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(736, 256);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(69, 36);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.Enabled = false;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(643, 256);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(67, 36);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lbl_dsBan
            // 
            this.lbl_dsBan.AutoSize = true;
            this.lbl_dsBan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dsBan.Location = new System.Drawing.Point(131, 9);
            this.lbl_dsBan.Name = "lbl_dsBan";
            this.lbl_dsBan.Size = new System.Drawing.Size(149, 24);
            this.lbl_dsBan.TabIndex = 27;
            this.lbl_dsBan.Text = "Danh Sách Bàn";
            // 
            // grb_ban
            // 
            this.grb_ban.Controls.Add(this.txtTenBan);
            this.grb_ban.Controls.Add(this.txtMaBan);
            this.grb_ban.Controls.Add(this.lsbTenKhuVuc);
            this.grb_ban.Controls.Add(this.lsbTrangThai);
            this.grb_ban.Controls.Add(this.lbl_trangthai);
            this.grb_ban.Controls.Add(this.lbl_tenban);
            this.grb_ban.Controls.Add(this.lbl_tenkv);
            this.grb_ban.Controls.Add(this.lbl_maban);
            this.grb_ban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ban.Location = new System.Drawing.Point(490, 49);
            this.grb_ban.Name = "grb_ban";
            this.grb_ban.Size = new System.Drawing.Size(333, 186);
            this.grb_ban.TabIndex = 21;
            this.grb_ban.TabStop = false;
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(127, 106);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(188, 27);
            this.txtTenBan.TabIndex = 2;
            // 
            // txtMaBan
            // 
            this.txtMaBan.Location = new System.Drawing.Point(127, 30);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.Size = new System.Drawing.Size(188, 27);
            this.txtMaBan.TabIndex = 0;
            // 
            // lsbTenKhuVuc
            // 
            this.lsbTenKhuVuc.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbTenKhuVuc.FormattingEnabled = true;
            this.lsbTenKhuVuc.ItemHeight = 18;
            this.lsbTenKhuVuc.Items.AddRange(new object[] {
            "Trong nhà",
            "Sân thượng",
            "Sân vườn",
            "Tầng 3",
            "Tầng 2"});
            this.lsbTenKhuVuc.Location = new System.Drawing.Point(127, 71);
            this.lsbTenKhuVuc.Name = "lsbTenKhuVuc";
            this.lsbTenKhuVuc.Size = new System.Drawing.Size(188, 22);
            this.lsbTenKhuVuc.TabIndex = 1;
            // 
            // lsbTrangThai
            // 
            this.lsbTrangThai.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbTrangThai.FormattingEnabled = true;
            this.lsbTrangThai.ItemHeight = 18;
            this.lsbTrangThai.Items.AddRange(new object[] {
            "Còn trống",
            "Đã có khách"});
            this.lsbTrangThai.Location = new System.Drawing.Point(127, 145);
            this.lsbTrangThai.Name = "lsbTrangThai";
            this.lsbTrangThai.Size = new System.Drawing.Size(188, 22);
            this.lsbTrangThai.TabIndex = 3;
            // 
            // lbl_trangthai
            // 
            this.lbl_trangthai.AutoSize = true;
            this.lbl_trangthai.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trangthai.Location = new System.Drawing.Point(23, 149);
            this.lbl_trangthai.Name = "lbl_trangthai";
            this.lbl_trangthai.Size = new System.Drawing.Size(75, 19);
            this.lbl_trangthai.TabIndex = 7;
            this.lbl_trangthai.Text = "Trạng thái";
            // 
            // lbl_tenban
            // 
            this.lbl_tenban.AutoSize = true;
            this.lbl_tenban.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenban.Location = new System.Drawing.Point(23, 113);
            this.lbl_tenban.Name = "lbl_tenban";
            this.lbl_tenban.Size = new System.Drawing.Size(61, 19);
            this.lbl_tenban.TabIndex = 5;
            this.lbl_tenban.Text = "Tên bàn";
            // 
            // lbl_tenkv
            // 
            this.lbl_tenkv.AutoSize = true;
            this.lbl_tenkv.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenkv.Location = new System.Drawing.Point(23, 71);
            this.lbl_tenkv.Name = "lbl_tenkv";
            this.lbl_tenkv.Size = new System.Drawing.Size(90, 19);
            this.lbl_tenkv.TabIndex = 4;
            this.lbl_tenkv.Text = "Tên khu vực";
            // 
            // lbl_maban
            // 
            this.lbl_maban.AutoSize = true;
            this.lbl_maban.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maban.Location = new System.Drawing.Point(23, 37);
            this.lbl_maban.Name = "lbl_maban";
            this.lbl_maban.Size = new System.Drawing.Size(58, 19);
            this.lbl_maban.TabIndex = 3;
            this.lbl_maban.Text = "Mã bàn";
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Enabled = false;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(545, 256);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(74, 36);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            //this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbl_qlban
            // 
            this.lbl_qlban.AutoSize = true;
            this.lbl_qlban.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qlban.Location = new System.Drawing.Point(597, 13);
            this.lbl_qlban.Name = "lbl_qlban";
            this.lbl_qlban.Size = new System.Drawing.Size(130, 24);
            this.lbl_qlban.TabIndex = 26;
            this.lbl_qlban.Text = "Quản Lý Bàn";
            // 
            // Frm_Ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 340);
            this.Controls.Add(this.dgvDanhSachBan);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lbl_dsBan);
            this.Controls.Add(this.grb_ban);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbl_qlban);
            this.Name = "Frm_Ban";
            this.Text = "Frm_Ban";
            //this.Load += new System.EventHandler(this.Frm_Ban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBan)).EndInit();
            this.grb_ban.ResumeLayout(false);
            this.grb_ban.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lbl_dsBan;
        private System.Windows.Forms.GroupBox grb_ban;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.TextBox txtMaBan;
        private System.Windows.Forms.ListBox lsbTenKhuVuc;
        private System.Windows.Forms.ListBox lsbTrangThai;
        private System.Windows.Forms.Label lbl_trangthai;
        private System.Windows.Forms.Label lbl_tenban;
        private System.Windows.Forms.Label lbl_tenkv;
        private System.Windows.Forms.Label lbl_maban;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbl_qlban;
    }
}
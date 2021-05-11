namespace QuanLyNhaHang
{
    partial class Frm_KhuVuc
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
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbl_qlkv = new System.Windows.Forms.Label();
            this.lbl_dskv = new System.Windows.Forms.Label();
            this.gbDanhSachKhuVuc = new System.Windows.Forms.GroupBox();
            this.gvvDanhSachKhuVuc = new System.Windows.Forms.DataGridView();
            this.MAKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_khuvuc = new System.Windows.Forms.GroupBox();
            this.lsbTrangThai = new System.Windows.Forms.ListBox();
            this.lsbTenKhuVuc = new System.Windows.Forms.ListBox();
            this.txtMaKhuVuc = new System.Windows.Forms.TextBox();
            this.lbl_trangthai = new System.Windows.Forms.Label();
            this.lbl_tenkv = new System.Windows.Forms.Label();
            this.lbl_makv = new System.Windows.Forms.Label();
            this.gbDanhSachKhuVuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvvDanhSachKhuVuc)).BeginInit();
            this.gb_khuvuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(205, 239);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 33);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(81, 239);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 33);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // lbl_qlkv
            // 
            this.lbl_qlkv.AutoSize = true;
            this.lbl_qlkv.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qlkv.Location = new System.Drawing.Point(98, 14);
            this.lbl_qlkv.Name = "lbl_qlkv";
            this.lbl_qlkv.Size = new System.Drawing.Size(156, 24);
            this.lbl_qlkv.TabIndex = 26;
            this.lbl_qlkv.Text = "Quản lý khu vực";
            // 
            // lbl_dskv
            // 
            this.lbl_dskv.AutoSize = true;
            this.lbl_dskv.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dskv.Location = new System.Drawing.Point(525, 14);
            this.lbl_dskv.Name = "lbl_dskv";
            this.lbl_dskv.Size = new System.Drawing.Size(194, 24);
            this.lbl_dskv.TabIndex = 27;
            this.lbl_dskv.Text = "Danh Sách Khu Vực";
            // 
            // gbDanhSachKhuVuc
            // 
            this.gbDanhSachKhuVuc.Controls.Add(this.gvvDanhSachKhuVuc);
            this.gbDanhSachKhuVuc.Location = new System.Drawing.Point(370, 55);
            this.gbDanhSachKhuVuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDanhSachKhuVuc.Name = "gbDanhSachKhuVuc";
            this.gbDanhSachKhuVuc.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDanhSachKhuVuc.Size = new System.Drawing.Size(475, 230);
            this.gbDanhSachKhuVuc.TabIndex = 25;
            this.gbDanhSachKhuVuc.TabStop = false;
            // 
            // gvvDanhSachKhuVuc
            // 
            this.gvvDanhSachKhuVuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvvDanhSachKhuVuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvvDanhSachKhuVuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKV,
            this.TENKV,
            this.TRANGTHAI});
            this.gvvDanhSachKhuVuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvvDanhSachKhuVuc.Location = new System.Drawing.Point(3, 17);
            this.gvvDanhSachKhuVuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvvDanhSachKhuVuc.Name = "gvvDanhSachKhuVuc";
            this.gvvDanhSachKhuVuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvvDanhSachKhuVuc.Size = new System.Drawing.Size(469, 209);
            this.gvvDanhSachKhuVuc.TabIndex = 23;
            // 
            // MAKV
            // 
            this.MAKV.DataPropertyName = "MAKV";
            this.MAKV.HeaderText = "Mã Khu Vực";
            this.MAKV.Name = "MAKV";
            // 
            // TENKV
            // 
            this.TENKV.DataPropertyName = "TENKV";
            this.TENKV.HeaderText = "Tên Khu Vực";
            this.TENKV.Name = "TENKV";
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            this.TRANGTHAI.HeaderText = "Trạng Thái";
            this.TRANGTHAI.Name = "TRANGTHAI";
            // 
            // gb_khuvuc
            // 
            this.gb_khuvuc.Controls.Add(this.lsbTrangThai);
            this.gb_khuvuc.Controls.Add(this.lsbTenKhuVuc);
            this.gb_khuvuc.Controls.Add(this.txtMaKhuVuc);
            this.gb_khuvuc.Controls.Add(this.lbl_trangthai);
            this.gb_khuvuc.Controls.Add(this.lbl_tenkv);
            this.gb_khuvuc.Controls.Add(this.lbl_makv);
            this.gb_khuvuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_khuvuc.Location = new System.Drawing.Point(12, 55);
            this.gb_khuvuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_khuvuc.Name = "gb_khuvuc";
            this.gb_khuvuc.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_khuvuc.Size = new System.Drawing.Size(339, 152);
            this.gb_khuvuc.TabIndex = 22;
            this.gb_khuvuc.TabStop = false;
            // 
            // lsbTrangThai
            // 
            this.lsbTrangThai.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbTrangThai.FormattingEnabled = true;
            this.lsbTrangThai.ItemHeight = 19;
            this.lsbTrangThai.Items.AddRange(new object[] {
            "Hoạt động",
            "Tạm nghỉ"});
            this.lsbTrangThai.Location = new System.Drawing.Point(132, 110);
            this.lsbTrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsbTrangThai.Name = "lsbTrangThai";
            this.lsbTrangThai.Size = new System.Drawing.Size(180, 19);
            this.lsbTrangThai.TabIndex = 2;
            // 
            // lsbTenKhuVuc
            // 
            this.lsbTenKhuVuc.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbTenKhuVuc.FormattingEnabled = true;
            this.lsbTenKhuVuc.ItemHeight = 19;
            this.lsbTenKhuVuc.Items.AddRange(new object[] {
            "Trong nhà",
            "Sân vườn",
            "Sân thượng",
            "Tầng 2",
            "Tầng 3"});
            this.lsbTenKhuVuc.Location = new System.Drawing.Point(132, 68);
            this.lsbTenKhuVuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsbTenKhuVuc.Name = "lsbTenKhuVuc";
            this.lsbTenKhuVuc.Size = new System.Drawing.Size(180, 19);
            this.lsbTenKhuVuc.TabIndex = 1;
            // 
            // txtMaKhuVuc
            // 
            this.txtMaKhuVuc.Location = new System.Drawing.Point(132, 23);
            this.txtMaKhuVuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKhuVuc.Name = "txtMaKhuVuc";
            this.txtMaKhuVuc.Size = new System.Drawing.Size(180, 27);
            this.txtMaKhuVuc.TabIndex = 0;
            // 
            // lbl_trangthai
            // 
            this.lbl_trangthai.AutoSize = true;
            this.lbl_trangthai.Location = new System.Drawing.Point(6, 109);
            this.lbl_trangthai.Name = "lbl_trangthai";
            this.lbl_trangthai.Size = new System.Drawing.Size(89, 20);
            this.lbl_trangthai.TabIndex = 3;
            this.lbl_trangthai.Text = "Trạng thái:";
            // 
            // lbl_tenkv
            // 
            this.lbl_tenkv.AutoSize = true;
            this.lbl_tenkv.Location = new System.Drawing.Point(6, 67);
            this.lbl_tenkv.Name = "lbl_tenkv";
            this.lbl_tenkv.Size = new System.Drawing.Size(110, 20);
            this.lbl_tenkv.TabIndex = 2;
            this.lbl_tenkv.Text = "Tên Khu Vực:";
            // 
            // lbl_makv
            // 
            this.lbl_makv.AutoSize = true;
            this.lbl_makv.Location = new System.Drawing.Point(6, 26);
            this.lbl_makv.Name = "lbl_makv";
            this.lbl_makv.Size = new System.Drawing.Size(105, 20);
            this.lbl_makv.TabIndex = 0;
            this.lbl_makv.Text = "Mã Khu Vực:";
            // 
            // Frm_KhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 324);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbl_qlkv);
            this.Controls.Add(this.lbl_dskv);
            this.Controls.Add(this.gbDanhSachKhuVuc);
            this.Controls.Add(this.gb_khuvuc);
            this.Name = "Frm_KhuVuc";
            this.Text = "Frm_KhuVuc";
            this.Load += new System.EventHandler(this.Frm_KhuVuc_Load);
            this.gbDanhSachKhuVuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvvDanhSachKhuVuc)).EndInit();
            this.gb_khuvuc.ResumeLayout(false);
            this.gb_khuvuc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbl_qlkv;
        private System.Windows.Forms.Label lbl_dskv;
        private System.Windows.Forms.GroupBox gbDanhSachKhuVuc;
        private System.Windows.Forms.DataGridView gvvDanhSachKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
        private System.Windows.Forms.GroupBox gb_khuvuc;
        private System.Windows.Forms.ListBox lsbTrangThai;
        private System.Windows.Forms.ListBox lsbTenKhuVuc;
        private System.Windows.Forms.TextBox txtMaKhuVuc;
        private System.Windows.Forms.Label lbl_trangthai;
        private System.Windows.Forms.Label lbl_tenkv;
        private System.Windows.Forms.Label lbl_makv;
    }
}
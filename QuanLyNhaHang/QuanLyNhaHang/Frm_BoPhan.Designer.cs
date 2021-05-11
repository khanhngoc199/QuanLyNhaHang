namespace DTO
{
    partial class Frm_BoPhan
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
            this.txtMaChucNang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbDanhSachChucNang = new System.Windows.Forms.GroupBox();
            this.gvvDanhSachChucNang = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenChucNang = new System.Windows.Forms.TextBox();
            this.lbl_TenBoPhan = new System.Windows.Forms.Label();
            this.MACHUCNANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENCHUCNANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbDanhSachChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvvDanhSachChucNang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaChucNang
            // 
            this.txtMaChucNang.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaChucNang.Location = new System.Drawing.Point(125, 19);
            this.txtMaChucNang.Name = "txtMaChucNang";
            this.txtMaChucNang.Size = new System.Drawing.Size(204, 27);
            this.txtMaChucNang.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "Mã chức năng:";
            // 
            // gpbDanhSachChucNang
            // 
            this.gpbDanhSachChucNang.Controls.Add(this.gvvDanhSachChucNang);
            this.gpbDanhSachChucNang.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDanhSachChucNang.Location = new System.Drawing.Point(15, 101);
            this.gpbDanhSachChucNang.Name = "gpbDanhSachChucNang";
            this.gpbDanhSachChucNang.Size = new System.Drawing.Size(348, 182);
            this.gpbDanhSachChucNang.TabIndex = 46;
            this.gpbDanhSachChucNang.TabStop = false;
            // 
            // gvvDanhSachChucNang
            // 
            this.gvvDanhSachChucNang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvvDanhSachChucNang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MACHUCNANG,
            this.TENCHUCNANG});
            this.gvvDanhSachChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvvDanhSachChucNang.Location = new System.Drawing.Point(3, 17);
            this.gvvDanhSachChucNang.Name = "gvvDanhSachChucNang";
            this.gvvDanhSachChucNang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvvDanhSachChucNang.Size = new System.Drawing.Size(342, 162);
            this.gvvDanhSachChucNang.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Enabled = false;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(349, 40);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 32);
            this.btnThem.TabIndex = 45;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtTenChucNang
            // 
            this.txtTenChucNang.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenChucNang.Location = new System.Drawing.Point(125, 50);
            this.txtTenChucNang.Name = "txtTenChucNang";
            this.txtTenChucNang.Size = new System.Drawing.Size(204, 27);
            this.txtTenChucNang.TabIndex = 44;
            // 
            // lbl_TenBoPhan
            // 
            this.lbl_TenBoPhan.AutoSize = true;
            this.lbl_TenBoPhan.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenBoPhan.Location = new System.Drawing.Point(11, 53);
            this.lbl_TenBoPhan.Name = "lbl_TenBoPhan";
            this.lbl_TenBoPhan.Size = new System.Drawing.Size(111, 19);
            this.lbl_TenBoPhan.TabIndex = 47;
            this.lbl_TenBoPhan.Text = "Tên chức năng:";
            // 
            // MACHUCNANG
            // 
            this.MACHUCNANG.DataPropertyName = "MACHUCNANG";
            this.MACHUCNANG.HeaderText = "MÃ CHỨC NĂNG";
            this.MACHUCNANG.Name = "MACHUCNANG";
            // 
            // TENCHUCNANG
            // 
            this.TENCHUCNANG.DataPropertyName = "TENCHUCNANG";
            this.TENCHUCNANG.HeaderText = "TÊN CHỨC NĂNG";
            this.TENCHUCNANG.Name = "TENCHUCNANG";
            this.TENCHUCNANG.Width = 200;
            // 
            // Frm_BoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 324);
            this.Controls.Add(this.txtMaChucNang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpbDanhSachChucNang);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenChucNang);
            this.Controls.Add(this.lbl_TenBoPhan);
            this.Name = "Frm_BoPhan";
            this.Text = "Frm_BoPhan";
            this.gpbDanhSachChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvvDanhSachChucNang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaChucNang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbDanhSachChucNang;
        private System.Windows.Forms.DataGridView gvvDanhSachChucNang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenChucNang;
        private System.Windows.Forms.Label lbl_TenBoPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACHUCNANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENCHUCNANG;
    }
}
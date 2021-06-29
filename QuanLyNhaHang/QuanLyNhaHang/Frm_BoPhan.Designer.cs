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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BoPhan));
            this.txtMaBoPhan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbDanhSachChucNang = new System.Windows.Forms.GroupBox();
            this.gvvDanhSachBoPhan = new System.Windows.Forms.DataGridView();
            this.txtTenBoPhan = new System.Windows.Forms.TextBox();
            this.lbl_TenBoPhan = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.MABP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbDanhSachChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvvDanhSachBoPhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaBoPhan
            // 
            this.txtMaBoPhan.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBoPhan.Location = new System.Drawing.Point(125, 19);
            this.txtMaBoPhan.Name = "txtMaBoPhan";
            this.txtMaBoPhan.Size = new System.Drawing.Size(323, 27);
            this.txtMaBoPhan.TabIndex = 43;
            this.txtMaBoPhan.TextChanged += new System.EventHandler(this.txtMaBoPhan_TextChanged);
            this.txtMaBoPhan.Leave += new System.EventHandler(this.txtMaBoPhan_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "Mã bộ phận:";
            // 
            // gpbDanhSachChucNang
            // 
            this.gpbDanhSachChucNang.Controls.Add(this.gvvDanhSachBoPhan);
            this.gpbDanhSachChucNang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpbDanhSachChucNang.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDanhSachChucNang.Location = new System.Drawing.Point(0, 142);
            this.gpbDanhSachChucNang.Name = "gpbDanhSachChucNang";
            this.gpbDanhSachChucNang.Size = new System.Drawing.Size(460, 182);
            this.gpbDanhSachChucNang.TabIndex = 46;
            this.gpbDanhSachChucNang.TabStop = false;
            // 
            // gvvDanhSachBoPhan
            // 
            this.gvvDanhSachBoPhan.AllowUserToAddRows = false;
            this.gvvDanhSachBoPhan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvvDanhSachBoPhan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvvDanhSachBoPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvvDanhSachBoPhan.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvvDanhSachBoPhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvvDanhSachBoPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvvDanhSachBoPhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MABP,
            this.TENBP});
            this.gvvDanhSachBoPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvvDanhSachBoPhan.Location = new System.Drawing.Point(3, 17);
            this.gvvDanhSachBoPhan.Name = "gvvDanhSachBoPhan";
            this.gvvDanhSachBoPhan.ReadOnly = true;
            this.gvvDanhSachBoPhan.RowHeadersVisible = false;
            this.gvvDanhSachBoPhan.RowTemplate.Height = 32;
            this.gvvDanhSachBoPhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvvDanhSachBoPhan.Size = new System.Drawing.Size(454, 162);
            this.gvvDanhSachBoPhan.TabIndex = 0;
            this.gvvDanhSachBoPhan.SelectionChanged += new System.EventHandler(this.gvvDanhSachBoPhan_SelectionChanged);
            // 
            // txtTenBoPhan
            // 
            this.txtTenBoPhan.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBoPhan.Location = new System.Drawing.Point(125, 50);
            this.txtTenBoPhan.Name = "txtTenBoPhan";
            this.txtTenBoPhan.Size = new System.Drawing.Size(323, 27);
            this.txtTenBoPhan.TabIndex = 44;
            this.txtTenBoPhan.TextChanged += new System.EventHandler(this.txtTenBoPhan_TextChanged);
            // 
            // lbl_TenBoPhan
            // 
            this.lbl_TenBoPhan.AutoSize = true;
            this.lbl_TenBoPhan.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenBoPhan.Location = new System.Drawing.Point(11, 53);
            this.lbl_TenBoPhan.Name = "lbl_TenBoPhan";
            this.lbl_TenBoPhan.Size = new System.Drawing.Size(95, 19);
            this.lbl_TenBoPhan.TabIndex = 47;
            this.lbl_TenBoPhan.Text = "Tên bộ phận:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::QuanLyNhaHang.Properties.Resources.cancel_32;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(342, 83);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(102, 46);
            this.btnHuy.TabIndex = 50;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Enabled = false;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLyNhaHang.Properties.Resources.add32_32;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(187, 83);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 46);
            this.btnThem.TabIndex = 45;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // MABP
            // 
            this.MABP.DataPropertyName = "MABP";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MABP.DefaultCellStyle = dataGridViewCellStyle3;
            this.MABP.HeaderText = "Mã bộ phận";
            this.MABP.Name = "MABP";
            this.MABP.ReadOnly = true;
            // 
            // TENBP
            // 
            this.TENBP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENBP.DataPropertyName = "TENBP";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TENBP.DefaultCellStyle = dataGridViewCellStyle4;
            this.TENBP.HeaderText = "Tên bộ phận";
            this.TENBP.Name = "TENBP";
            this.TENBP.ReadOnly = true;
            // 
            // Frm_BoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 324);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txtMaBoPhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpbDanhSachChucNang);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenBoPhan);
            this.Controls.Add(this.lbl_TenBoPhan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_BoPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bộ phận";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_BoPhan_FormClosing);
            this.Load += new System.EventHandler(this.Frm_BoPhan_Load);
            this.gpbDanhSachChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvvDanhSachBoPhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaBoPhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbDanhSachChucNang;
        private System.Windows.Forms.DataGridView gvvDanhSachBoPhan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenBoPhan;
        private System.Windows.Forms.Label lbl_TenBoPhan;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBP;
    }
}
namespace QuanLyNhaHang
{
    partial class Frm_NhomMonAn
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
            this.txtTenNhomMonAn = new System.Windows.Forms.TextBox();
            this.txtMaNhomMonAn = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lbl_TenNMA = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MANMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_MaNMA = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenNhomMonAn
            // 
            this.txtTenNhomMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhomMonAn.Location = new System.Drawing.Point(169, 62);
            this.txtTenNhomMonAn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNhomMonAn.Name = "txtTenNhomMonAn";
            this.txtTenNhomMonAn.Size = new System.Drawing.Size(257, 27);
            this.txtTenNhomMonAn.TabIndex = 39;
            // 
            // txtMaNhomMonAn
            // 
            this.txtMaNhomMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhomMonAn.Location = new System.Drawing.Point(169, 18);
            this.txtMaNhomMonAn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNhomMonAn.Name = "txtMaNhomMonAn";
            this.txtMaNhomMonAn.Size = new System.Drawing.Size(257, 27);
            this.txtMaNhomMonAn.TabIndex = 38;
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(680, 30);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 43);
            this.btnXoa.TabIndex = 42;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(568, 30);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(105, 43);
            this.btnSua.TabIndex = 41;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // lbl_TenNMA
            // 
            this.lbl_TenNMA.AutoSize = true;
            this.lbl_TenNMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenNMA.Location = new System.Drawing.Point(8, 65);
            this.lbl_TenNMA.Name = "lbl_TenNMA";
            this.lbl_TenNMA.Size = new System.Drawing.Size(116, 20);
            this.lbl_TenNMA.TabIndex = 45;
            this.lbl_TenNMA.Text = "Tên thực đơn :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANMA,
            this.TENNMA});
            this.dataGridView1.Location = new System.Drawing.Point(126, 118);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(556, 241);
            this.dataGridView1.TabIndex = 44;
            // 
            // MANMA
            // 
            this.MANMA.DataPropertyName = "MANMA";
            this.MANMA.HeaderText = "Mã Thực Đơn";
            this.MANMA.Name = "MANMA";
            // 
            // TENNMA
            // 
            this.TENNMA.DataPropertyName = "TENNMA";
            this.TENNMA.HeaderText = "Tên Thực Đơn";
            this.TENNMA.Name = "TENNMA";
            // 
            // lbl_MaNMA
            // 
            this.lbl_MaNMA.AutoSize = true;
            this.lbl_MaNMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNMA.Location = new System.Drawing.Point(12, 21);
            this.lbl_MaNMA.Name = "lbl_MaNMA";
            this.lbl_MaNMA.Size = new System.Drawing.Size(151, 20);
            this.lbl_MaNMA.TabIndex = 43;
            this.lbl_MaNMA.Text = "Mã Nhóm món ăn :";
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(456, 30);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 43);
            this.btnThem.TabIndex = 40;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // Frm_NhomMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 385);
            this.Controls.Add(this.txtTenNhomMonAn);
            this.Controls.Add(this.txtMaNhomMonAn);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lbl_TenNMA);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_MaNMA);
            this.Controls.Add(this.btnThem);
            this.Name = "Frm_NhomMonAn";
            this.Text = "Frm_NhomMonAn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenNhomMonAn;
        private System.Windows.Forms.TextBox txtMaNhomMonAn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lbl_TenNMA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNMA;
        private System.Windows.Forms.Label lbl_MaNMA;
        private System.Windows.Forms.Button btnThem;
    }
}
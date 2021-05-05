namespace QuanLyNhaHang
{
    partial class Frm_User
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
            this.txtMaTaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDongY = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lbl_matkhau = new System.Windows.Forms.Label();
            this.lbl_tendn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMaTaiKhoan
            // 
            this.txtMaTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTaiKhoan.Location = new System.Drawing.Point(149, 14);
            this.txtMaTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaTaiKhoan.Name = "txtMaTaiKhoan";
            this.txtMaTaiKhoan.Size = new System.Drawing.Size(259, 27);
            this.txtMaTaiKhoan.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã tài khoản:";
            // 
            // btnDongY
            // 
            this.btnDongY.Enabled = false;
            this.btnDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.Location = new System.Drawing.Point(321, 171);
            this.btnDongY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(87, 41);
            this.btnDongY.TabIndex = 16;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;

            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(149, 127);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(259, 27);
            this.txtMatKhau.TabIndex = 15;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(149, 74);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(259, 27);
            this.txtTenDangNhap.TabIndex = 14;
            // 
            // lbl_matkhau
            // 
            this.lbl_matkhau.AutoSize = true;
            this.lbl_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matkhau.ForeColor = System.Drawing.Color.Black;
            this.lbl_matkhau.Location = new System.Drawing.Point(12, 132);
            this.lbl_matkhau.Name = "lbl_matkhau";
            this.lbl_matkhau.Size = new System.Drawing.Size(82, 20);
            this.lbl_matkhau.TabIndex = 18;
            this.lbl_matkhau.Text = "Mật khẩu:";
            // 
            // lbl_tendn
            // 
            this.lbl_tendn.AutoSize = true;
            this.lbl_tendn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tendn.ForeColor = System.Drawing.Color.Black;
            this.lbl_tendn.Location = new System.Drawing.Point(12, 79);
            this.lbl_tendn.Name = "lbl_tendn";
            this.lbl_tendn.Size = new System.Drawing.Size(124, 20);
            this.lbl_tendn.TabIndex = 17;
            this.lbl_tendn.Text = "Tên đăng nhập:";
            // 
            // Frm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 229);
            this.Controls.Add(this.txtMaTaiKhoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lbl_matkhau);
            this.Controls.Add(this.lbl_tendn);
            this.Name = "Frm_User";
            this.Text = "Frm_User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lbl_matkhau;
        private System.Windows.Forms.Label lbl_tendn;
    }
}
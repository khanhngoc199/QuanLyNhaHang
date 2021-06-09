using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class Frm_User : Form
    {
        public Frm_User()
        {
            InitializeComponent();
        }

        

        private void Frm_User_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtMaTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txtMaTaiKhoan.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtMaTaiKhoan, "Phải nhập mã nhân viên !");
            else
                this.errorProvider1.Clear();
        }

        private void Frm_User_Load(object sender, EventArgs e)
        {
            txtMaTaiKhoan.Focus();
        }
      

        private void btnDongY_Click_1(object sender, EventArgs e)
        {
            if (txtMaTaiKhoan.Text == string.Empty)
            {
                MessageBox.Show("Nhập vào mã nhân viên");
            }
            else
            {
                if (txtTenDangNhap.Text == string.Empty)
                {
                    MessageBox.Show("Nhập vào tên người dùng ");
                }
                else
                {
                    if (txtMatKhau.Text == string.Empty)
                    {
                        MessageBox.Show("Nhập vào mật khẩu ");
                    }
                }
            }
            try
            {
                if (userDAO.Instance.createND(int.Parse(txtMaTaiKhoan.Text), txtTenDangNhap.Text, txtMatKhau.Text))//insert tài khoản vào database
                {
                    MessageBox.Show("Đăng ký thành công");
                }

            }
            catch
            {
                MessageBox.Show("Mã người dùng tồn tại !");
            }
        }
    }
}

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

namespace DTO
{
    public partial class Frm_DoiMatkhau : Form
    {
        public Frm_DoiMatkhau()
        {
            InitializeComponent();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == string.Empty)//Kiểm tra textbox tài khoản có được nhập chưa
            {
                MessageBox.Show("Hãy nhập vào tài khoản");
            }
            else
            {
                if (txtMatKhauCu.Text == string.Empty)//kiểm tra textbox mật khẩu có được nhập chưa
                {
                    MessageBox.Show("Hãy nhập mật khẩu cũ");
                }
                else
                {
                    if (txtMatKhauMoi.Text == string.Empty)//Kiểm tra textbox mật khẩu mới có được nhập chưa
                    {
                        MessageBox.Show("Hãy nhập mật khẩu mới");
                    }
                    else
                    {
                        try
                        {
                            if (userDAO.Instance.updateUser(txtTenDangNhap.Text, txtMatKhauCu.Text, txtMatKhauMoi.Text))//truyền tham số vào hàm đăng nhập tài khoản trong lớp user_DAO
                            {
                                MessageBox.Show("Đổi thành công");
                                btnDongY.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Tài khoản không tồn tại hoặc mật khẩu sai !!");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Đổi thất bại ");
                        }
                    }
                }
            }
        }
    }
}

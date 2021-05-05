
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class Frm_Login : Form
    {
        public static int key = 0;
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtTenDangNhap.Text.Trim();
            string pass = txtMatKhau.Text;
            if (user == string.Empty)//kiểm tra tài khoản có được nhập chưa
            {
                MessageBox.Show("Hãy nhập tài khoản ");
            }
            else
            {
                if (pass == string.Empty)
                    MessageBox.Show("Hãy nhập Password");
            }
            if (login(user, pass))//đăng nhập vào hệ thống
            {
                if (string.Compare(user, "admin") == 0)//Hàm so sánh 2 chuỗi
                {
                    key = 1;
                }
                Frm_Main f = new Frm_Main();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản không hợp lệ!");
            }
        }

        private bool login(string user, string pass)
        {
            return userDAO.Instance.login(user, pass);
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnDangNhap;
        }

        private void grbDangNhap_Enter(object sender, EventArgs e)
        {
            this.grbDangNhap.BackColor = Color.Transparent;
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text!=string.Empty)
            {
                if(txtMatKhau.Text!=string.Empty)
                {
                    btnDangNhap.Enabled = true;
                }
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text!=string.Empty)
            {
                if(txtMatKhau.Text!=string.Empty)
                {
                    btnDangNhap.Enabled = true;
                }
            }
        }
    }
}

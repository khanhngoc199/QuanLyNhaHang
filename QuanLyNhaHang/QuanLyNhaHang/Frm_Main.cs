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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
            
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Login.key == 1)
            {
                //Mở form quản lý nhân viên
                Frm_NhanVien nv = new Frm_NhanVien();
                nv.Show();
            }
            else
            {
                MessageBox.Show("Bạn phải đăng nhập dưới quyền admin");
            }
        }

        private void tạoTàiKhoảnChoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Login.key == 1)
            {
                Frm_User pq = new Frm_User();
                pq.Show();
            }
            else
            {
                MessageBox.Show("Bạn phải đăng nhập dưới quyền admin");
            }

        }

        private void bànKhuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void loạiThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Login.key == 1)
            {
                Frm_NhomMonAn nma = new Frm_NhomMonAn();
                nma.Show();
            }
            else
            {

                MessageBox.Show("Bạn phải đăng nhập dưới quyền admin");
            }

        }

        private void thựcĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void Frm_Main_Click(object sender, EventArgs e)
        {

        }

        private void bộPhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}

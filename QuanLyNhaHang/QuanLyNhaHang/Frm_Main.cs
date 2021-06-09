using DTO;
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
        public static Frm_GoiMon gm;
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
            if (Frm_Login.key == 1)
            {
                Frm_Ban b = new Frm_Ban();
                b.Show();
            }
            else
            {
                MessageBox.Show("Bạn phải đăng nhập dưới quyền admin");
            }
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
            if (Frm_Login.key == 1)
            {
                Frm_MonAn ma = new Frm_MonAn();
                ma.Show();
            }
            else
            {

                MessageBox.Show("Bạn phải đăng nhập dưới quyền admin");
            }
        }

        private void Frm_Main_Click(object sender, EventArgs e)
        {

        }

        private void bộPhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Login.key == 1)
            {
                Frm_BoPhan f = new Frm_BoPhan();
                f.Show();
            }
            else
            {
                MessageBox.Show("Bạn hãy đăng nhập dưới quyền admin");
            }
        }

        private void hệThốngKhuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Login.key == 1)
            {
                Frm_KhuVuc kv = new Frm_KhuVuc();
                kv.Show();
            }
            else
            {

                MessageBox.Show("Bạn phải đăng nhập dưới quyền admin");
            }
        }

        private void tsmiGoiMon_Click(object sender, EventArgs e)
        {
            gm = new Frm_GoiMon();
            gm.Show();
        }

        private void quảnLýNguyênLiêuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhómNguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Login.key == 1)
            {
                Frm_NhomNguyenLieu f = new Frm_NhomNguyenLieu();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn hãy đăng nhập dưới quyền admin ");
            }
        }

        private void nguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Login.key == 1)
            {
                Frm_NguyenLieu f = new Frm_NguyenLieu();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn hãy đăng nhập dưới quyền admin ");
            }
        }

        private void tsmiThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiThuChi_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Login.key == 1)
            {
                Frm_BaoCaoDoanhThuNgay hdx = new Frm_BaoCaoDoanhThuNgay();
                hdx.Show();
            }
            else
            {

                MessageBox.Show("Bạn phải đăng nhập dưới quyền admin");
            }
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Login.key == 1)
            {
                Frm_HoaDonNhap hdn = new Frm_HoaDonNhap();
                hdn.Show();
            }
            else
            {
                MessageBox.Show("Bạn hãy đăng nhập dưới quyền admin");
            }
        }
    }
}

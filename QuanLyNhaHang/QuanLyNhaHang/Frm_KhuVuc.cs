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
    public partial class Frm_KhuVuc : Form
    {
        public Frm_KhuVuc()
        {
            InitializeComponent();
            loadKV();//load danh sách khu vực vào bảng khu vực
        }
        private void loadKV()
        {
            gvvDanhSachKhuVuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvvDanhSachKhuVuc.DataSource = khuVucDAO.Instance.getKV();//gán datasource cho gridview
        }
        private void Frm_KhuVuc_Load(object sender, EventArgs e)
        {
            txtMaKhuVuc.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (lsbTenKhuVuc.Text == string.Empty)//kiểm tra dữ liệu đã nhập chưa
            {
                MessageBox.Show("Hãy nhập tên khu vực ");
            }
            else
            {
                if (txtMaKhuVuc.Text == string.Empty)
                    MessageBox.Show("Hãy nhập mã khu vực ");
                else
                {
                    if (lsbTrangThai.Text == string.Empty)
                        MessageBox.Show("Hãy nhập trạng thái ");
                    else
                    {
                        try
                        {
                            //lấy dữ liệu từ texbox, listbox,
                            string tenkv = lsbTenKhuVuc.Text;
                            int makv = int.Parse(txtMaKhuVuc.Text);
                            string trangthai = lsbTrangThai.Text;
                            if (khuVucDAO.Instance.insertkv(makv, tenkv, trangthai))//gọi hàm insert khu vực và truyền tham số
                            {
                                MessageBox.Show("Thành công !");
                                loadKV();//load lại bảng danh sách khu vực
                                foreach (Control i in Controls)
                                {
                                    if (i is TextBox || i is ListBox)
                                    {
                                        i.ResetText();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Thất bại ! ");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Thông tin không hợp lệ! ");
                        }
                    }
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsbTenKhuVuc.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập tên khu vực ");
            }
            else
            {
                if (txtMaKhuVuc.Text == string.Empty)
                    MessageBox.Show("Hãy nhập mã khu vực ");
                else
                {
                    if (lsbTrangThai.Text == string.Empty)
                        MessageBox.Show("Hãy nhập trạng thái ");
                    else
                    {
                        try
                        {
                            //lấy thông tin từ các textbox,...
                            string tenkv = lsbTenKhuVuc.Text;
                            int makv = int.Parse(txtMaKhuVuc.Text);
                            string trangthai = lsbTrangThai.Text;
                            if (khuVucDAO.Instance.updatetkv(makv, tenkv, trangthai))//gọi đến hàm update thông tin khu vực
                            {
                                MessageBox.Show("Thành công! ");
                                loadKV();
                            }
                            else
                            {
                                MessageBox.Show("Thất bại!");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Thông tin không hợp lệ ");
                        }
                    }
                }

            }
        }

        private void Frm_KhuVuc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtMaKhuVuc_Leave(object sender, EventArgs e)
        {
            if (txtMaKhuVuc.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtMaKhuVuc, "Phải nhập mã khu vực !");
            else
                this.errorProvider1.Clear();
        }

        private void gvvDanhSachKhuVuc_SelectionChanged(object sender, EventArgs e)
        {
            txtMaKhuVuc.Text = gvvDanhSachKhuVuc.CurrentRow.Cells[0].Value.ToString();
            lsbTenKhuVuc.Text = gvvDanhSachKhuVuc.CurrentRow.Cells[1].Value.ToString();
            lsbTrangThai.Text = gvvDanhSachKhuVuc.CurrentRow.Cells[2].Value.ToString();
        }
    }
}

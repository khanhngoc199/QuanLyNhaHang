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
    public partial class Frm_NhomNguyenLieu : Form
    {
        public Frm_NhomNguyenLieu()
        {
            InitializeComponent();
            getlistnhomnl();//load danh sách nguyên liệu 
        }

        private void getlistnhomnl()
        {
            gvvDanhSachNhomNguyenLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvvDanhSachNhomNguyenLieu.DataSource = nhomNguyenLieuDAO.Instance.getnhomnl();//gán datasource cho gridview
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNhomNguyenLieu.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập vào mã nguyên liệu");
            }
            else
            {
                if (txtTenNhomNguyenLieu.Text == string.Empty)
                {
                    MessageBox.Show("Hãy nhập vào tên nguyên liệu ");
                }
                else
                {
                    try
                    {
                        if (nhomNguyenLieuDAO.Instance.insertnhomnl(int.Parse(txtMaNhomNguyenLieu.Text.ToString()), txtTenNhomNguyenLieu.Text.ToString()))//gọi hàm insert trong lớp DAO để insert dữ liệu vào database
                        {
                            MessageBox.Show("Thêm thành công ");
                            foreach (Control i in this.Controls)
                                if (i is TextBox)
                                {
                                    i.ResetText();
                                }
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại ");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Thêm thất bại ");
                    }
                }

            }


            getlistnhomnl();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNhomNguyenLieu.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập vào mã nguyên liệu");
            }
            else
            {
                if (txtTenNhomNguyenLieu.Text == string.Empty)
                {
                    MessageBox.Show("Hãy nhập vào tên nguyên liệu ");
                }
                else
                {
                    try
                    {
                        if (nhomNguyenLieuDAO.Instance.updatennl(int.Parse(txtMaNhomNguyenLieu.Text), txtTenNhomNguyenLieu.Text))//gọi hàm update của lớp nl_DAO để sửa thông tin trong database
                        {
                            MessageBox.Show("Sửa thành công ");
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại ");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Sửa thất bại ");
                    }
                }

            }

            getlistnhomnl();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhomNguyenLieu.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập vào mã nguyên liệu");
            }
            try
            {
                if (nhomNguyenLieuDAO.Instance.delete(int.Parse(txtMaNhomNguyenLieu.Text.ToString())))//gọi hàm xóa nhóm nguyên liệu trong database
                {
                    MessageBox.Show("Xóa thành công ");
                }
                else
                {

                }
            }
            catch
            {

            }


            getlistnhomnl();
        }

        private void Frm_NhomNguyenLieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void Frm_NhomNguyenLieu_Load(object sender, EventArgs e)
        {
            txtMaNhomNguyenLieu.Focus();
        }

        private void txtMaNhomNguyenLieu_Leave(object sender, EventArgs e)
        {
            if (txtMaNhomNguyenLieu.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtMaNhomNguyenLieu, "Phải nhập mã nhóm nguyên liệu !");
            else
                this.errorProvider1.Clear();
        }

        private void gvvDanhSachNhomNguyenLieu_SelectionChanged(object sender, EventArgs e)
        {
            txtMaNhomNguyenLieu.Text = gvvDanhSachNhomNguyenLieu.CurrentRow.Cells[0].Value.ToString();
            txtTenNhomNguyenLieu.Text = gvvDanhSachNhomNguyenLieu.CurrentRow.Cells[1].Value.ToString();
        }
    }
}

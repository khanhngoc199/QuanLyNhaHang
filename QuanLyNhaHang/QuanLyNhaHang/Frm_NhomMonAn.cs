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
    public partial class Frm_NhomMonAn : Form
    {
        public Frm_NhomMonAn()
        {
            InitializeComponent();
            loadMenu();//load danh sách các nhóm món ăn lên gridview
        }

        private void loadMenu()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = nhomMonAnDAO.Instance.getNhommonan();//gán datasource cho gridview
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNhomMonAn.Text == string.Empty)
                MessageBox.Show("Hãy nhập vào mã thực đơn");
            else
            {
                if (txtTenNhomMonAn.Text == string.Empty)
                {
                    MessageBox.Show("Hãy nhập vào tên thực đơn");
                }
                else
                {
                    try
                    {
                        int manhom = int.Parse(txtMaNhomMonAn.Text);
                        string tennhom = txtTenNhomMonAn.Text;
                        if (nhomMonAnDAO.Instance.insertnhommonan(manhom, tennhom))//gọi hàm insert trong lớp DAO để insert thông tin vào database
                        {
                            MessageBox.Show("Thành công !");
                            loadMenu();
                            foreach (Control i in this.Controls)
                            {
                                if (i is TextBox)
                                    i.ResetText();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Thất bại!");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Thông tin không hợp lệ !");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNhomMonAn.Text == string.Empty)
                MessageBox.Show("Hãy nhập vào mã thực đơn");
            else
            {
                if (txtTenNhomMonAn.Text == string.Empty)
                {
                    MessageBox.Show("Hãy nhập vào tên thực đơn");
                }
                else
                {
                    try
                    {
                        int manhom = int.Parse(txtMaNhomMonAn.Text);
                        string tennhom = txtTenNhomMonAn.Text;
                        if (nhomMonAnDAO.Instance.updatenhommonan(manhom, tennhom))//gọi hàm update trong DAO để sửa thông tin trong database
                        {
                            MessageBox.Show("Thành công !");
                            loadMenu();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhomMonAn.Text == string.Empty)
                MessageBox.Show("Hãy nhập vào mã thực đơn");
            try
            {
                int manhom = int.Parse(txtMaNhomMonAn.Text);
                if (nhomMonAnDAO.Instance.deletenhommonan(manhom))//gọi hàm xóa nhóm món ăn trong database
                {
                    MessageBox.Show("Thành công !");
                    loadMenu();
                }
                else
                {
                    MessageBox.Show("Thất bại !");
                }

            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ ");
            }
        }

        private void Frm_NhomMonAn_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtMaNhomMonAn_Leave(object sender, EventArgs e)
        {
            if (txtMaNhomMonAn.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtMaNhomMonAn, "Phải nhập mã nhóm món ăn !");
            else
                this.errorProvider1.Clear();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtMaNhomMonAn.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenNhomMonAn.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void Frm_NhomMonAn_Load(object sender, EventArgs e)
        {
            txtMaNhomMonAn.Focus();
        }
    }
}

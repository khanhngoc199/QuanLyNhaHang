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
    public partial class Frm_BoPhan : Form
    {
        public Frm_BoPhan()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            gvvDanhSachBoPhan.DataSource = nhanVienDAO.Instance.getbp(); //gán datasource cho gridview
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaBoPhan.Text == string.Empty)//kiểm tra xem mã bộ phận đã nhập chưa
            {
                MessageBox.Show("Hãy nhập vào mã bo phận ");
            }
            else
            {
                if (txtTenBoPhan.Text == string.Empty)//kiểm tra xem tên bộ phận đã được nhập chưa
                    MessageBox.Show("Hãy nhập vào tên bộ phận");
                else
                {
                    try
                    {
                        if (nhanVienDAO.Instance.insertbophan(int.Parse(txtMaBoPhan.Text), txtTenBoPhan.Text))//gọi hàm insert và truyền tham số để insert vào database
                        {
                            MessageBox.Show("Nhập thành công");
                            load();//load lại bảng danh sách các bộ phận
                            foreach (Control i in this.Controls)
                            {
                                if (i is TextBox)
                                {
                                    i.ResetText();
                                }
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Nhập thất bại ");
                    }
                }
            }
        }

        private void Frm_BoPhan_Load(object sender, EventArgs e)
        {
            txtMaBoPhan.Focus();
        }

        private void Frm_BoPhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtMaBoPhan_TextChanged(object sender, EventArgs e)
        {
            if (txtMaBoPhan.Text != string.Empty && txtTenBoPhan.Text != string.Empty)
            {
                btnThem.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
            }
        }

        private void txtTenBoPhan_TextChanged(object sender, EventArgs e)
        {
            if (txtMaBoPhan.Text != string.Empty && txtTenBoPhan.Text != string.Empty)
            {
                btnThem.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
            }
        }

        private void txtMaBoPhan_Leave(object sender, EventArgs e)
        {
            if (txtMaBoPhan.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtMaBoPhan, "Phải nhập mã bộ phận !");
            else
                this.errorProvider1.Clear();
        }

        private void gvvDanhSachBoPhan_SelectionChanged(object sender, EventArgs e)
        {
            txtMaBoPhan.Text = gvvDanhSachBoPhan.CurrentRow.Cells[0].Value.ToString();
            txtTenBoPhan.Text = gvvDanhSachBoPhan.CurrentRow.Cells[1].Value.ToString();
        }
    }
}

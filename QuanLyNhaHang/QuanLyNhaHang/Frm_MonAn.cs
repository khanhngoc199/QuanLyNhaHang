using DAO;
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
    public partial class Frm_MonAn : Form
    {
        public Frm_MonAn()
        {
            InitializeComponent();
            loadmonan();//load danh sách món ăn vào bảng món ăn
            loadcb();//load danh sách món ăn vào combobox theo loại thực đơn
        }

        private void loadcb()
        {
            List<nhomMonAnDTO> group = nhomMonAnDAO.Instance.loadtennhom();//lấy danh sách nhóm món ăn từ database
            foreach (nhomMonAnDTO nhom in group)
            {
                cbTenNhomMonAn.Items.Add(nhom.TenNhom.ToString());//add loại thực đơn vào combobox
            }
        }

        private void loadmonan()
        {
            gvvDanhSachMonAn.DataSource = monAnDAO.Instance.getNhommonan();//gán datasource vào gridview món ăn
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaMonAn.Text == string.Empty)
                MessageBox.Show("Hãy nhập mã thực đơn");
            else
            {
                if (txtTenMonAn.Text == string.Empty)
                    MessageBox.Show("Hãy nhập tên thực đơn");
                else
                {
                    if (txtDonGiaTinh.Text == string.Empty)
                        MessageBox.Show("Hãy nhập đơn giá");
                    else
                    {
                        if (txtDonViTinh.Text == string.Empty)
                        {
                            MessageBox.Show("Hãy nhập đơn vị tính");
                        }
                        else
                        {
                            if (lsbTrangThai.Text == string.Empty)
                                MessageBox.Show("Hãy nhập trạng thái ");
                            else
                            {
                                try
                                {
                                    //lấy thông tin từ các textbox
                                    string tenmonan = txtTenMonAn.Text;
                                    int mamonan = int.Parse(txtMaMonAn.Text);
                                    string tennhom = cbTenNhomMonAn.Text;
                                    string donvi = txtDonViTinh.Text;
                                    string trangthai = lsbTrangThai.Text;
                                    float dongia = float.Parse(txtDonGiaTinh.Text);
                                    if (monAnDAO.Instance.insertmonan(tennhom, mamonan, tenmonan, dongia, donvi, trangthai))//gọi hàm insert món ăn và truyền tham số để insert vào bảng món ăn trong database
                                    {
                                        MessageBox.Show("Thành công!");
                                        loadmonan();
                                        foreach (Control i in this.Controls)
                                        {
                                            if (i is TextBox || i is ListBox || i is ComboBox)
                                            {
                                                i.ResetText();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thất bại!");
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Thông tin không hợp lệ!");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaMonAn.Text == string.Empty)
                MessageBox.Show("Hãy nhập mã thực đơn");
            else
            {
                if (txtTenMonAn.Text == string.Empty)
                    MessageBox.Show("Hãy nhập tên thực đơn");
                else
                {
                    if (txtDonGiaTinh.Text == string.Empty)
                        MessageBox.Show("Hãy nhập đơn giá");
                    else
                    {
                        if (txtDonViTinh.Text == string.Empty)
                        {
                            MessageBox.Show("Hãy nhập đơn vị tính");
                        }
                        else
                        {
                            if (lsbTrangThai.Text == string.Empty)
                                MessageBox.Show("Hãy nhập trạng thái ");
                            else
                            {
                                try
                                {
                                    //lấy thông tin từ các textbox
                                    string tenmonan = txtTenMonAn.Text;
                                    int mamonan = int.Parse(txtMaMonAn.Text);
                                    string tennhom = cbTenNhomMonAn.Text;
                                    string donvi = txtDonViTinh.Text;
                                    float dongia = float.Parse(txtDonGiaTinh.Text);
                                    string trangthai = lsbTrangThai.Text;
                                    if (monAnDAO.Instance.updatetmonan(tennhom, mamonan, tenmonan, dongia, donvi, trangthai))//gọi hàm update và truyền tham số để sửa thông tin bàn trong database
                                    {
                                        MessageBox.Show("Thành công!");
                                        loadmonan();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thất bại ");
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Thông tin không hợp lệ ! ");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaMonAn.Text == string.Empty)
                MessageBox.Show("Hãy nhập mã thực đơn");
            try
            {
                int mamonan = int.Parse(txtMaMonAn.Text);
                if (monAnDAO.Instance.deletemonan(mamonan))//gọi hàm xóa món ăn
                {
                    MessageBox.Show("Thành công!");
                    loadmonan();
                }
                else
                {
                    MessageBox.Show("Thất bại!");
                }
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ");
            }
        }

        private void Frm_MonAn_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void Frm_MonAn_Load(object sender, EventArgs e)
        {
            txtMaMonAn.Focus();
        }

        private void txtDonGiaTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gvvDanhSachMonAn_SelectionChanged(object sender, EventArgs e)
        {
            txtMaMonAn.Text = gvvDanhSachMonAn.CurrentRow.Cells[0].Value.ToString();
            cbTenNhomMonAn.Text = gvvDanhSachMonAn.CurrentRow.Cells[1].Value.ToString();
            txtTenMonAn.Text = gvvDanhSachMonAn.CurrentRow.Cells[2].Value.ToString();
            txtDonGiaTinh.Text = gvvDanhSachMonAn.CurrentRow.Cells[3].Value.ToString();
            txtDonViTinh.Text = gvvDanhSachMonAn.CurrentRow.Cells[4].Value.ToString();
        }
    }
}

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
    public partial class Frm_NguyenLieu : Form
    {
        public Frm_NguyenLieu()
        {
            InitializeComponent();
            getlist();//load danh sách nguyên liệu 
            loadcb();//load danh sách nhóm nguyên liệu vào combobox
        }

        private void loadcb()
        {
            List<nhomNguyenLieuDTO> group = nhomNguyenLieuDAO.Instance.getlisnhom();//lấy danh sách nhóm nguyên liệu
            foreach (nhomNguyenLieuDTO nhom in group)
            {
                cbLoaiNguyenLieu.Items.Add(nhom.TenNNL.ToString());//add danh sách nhóm nguyên liệu vào combobox
            }
        }

        private void getlist()
        {
            gvvDanhSachThucDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvvDanhSachThucDon.DataSource = nguyenLieuDAO.Instance.getnl();//gán datasource vào gridview
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNguyenLieu.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập vào mã nguyên liệu");
            }
            else
            {
                if (txtTenNguyenLieu.Text == string.Empty)
                {
                    MessageBox.Show("Hãy nhập vào tên nguyên liệu");
                }
                else
                {
                    if (txtDonGiaTinh.Text == string.Empty)
                    {
                        MessageBox.Show("Hãy nhập vào đơn giá nguyên liệu");
                    }
                    else
                    {
                        if (txtDonViTinh.Text == string.Empty)
                        {
                            MessageBox.Show("Hãy nhập vào đơn vị tính nguyên liệu");
                        }
                        else
                        {
                            try
                            {

                                if (nguyenLieuDAO.Instance.insertnnl(int.Parse(txtMaNguyenLieu.Text), txtTenNguyenLieu.Text, float.Parse(txtDonGiaTinh.Text), txtDonViTinh.Text, cbLoaiNguyenLieu.Text))//gọi hàm insert nguyên liêu và truyền tham số để insert và database
                                {
                                    MessageBox.Show("Thêm thành công");
                                    getlist();//load lại danh sách nguyên liệu
                                    foreach (Control i in this.Controls)
                                    {
                                        if (i is TextBox || i is ComboBox)
                                        {
                                            i.ResetText();
                                        }
                                    }
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Thêm thất bại");
                            }
                        }

                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNguyenLieu.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập vào mã nguyên liệu");
            }
            else
            {
                if (txtTenNguyenLieu.Text == string.Empty)
                {
                    MessageBox.Show("Hãy nhập vào tên nguyên liệu");
                }
                else
                {
                    if (txtDonGiaTinh.Text == string.Empty)
                    {
                        MessageBox.Show("Hãy nhập vào đơn giá");
                    }
                    else
                    {
                        if (txtDonViTinh.Text == string.Empty)
                        {
                            MessageBox.Show("Hãy nhập vào đơn vị tính");
                        }
                        else
                        {
                            try
                            {
                                if (nguyenLieuDAO.Instance.updatennl(int.Parse(txtMaNguyenLieu.Text), cbLoaiNguyenLieu.Text, float.Parse(txtDonGiaTinh.Text), txtDonViTinh.Text, txtTenNguyenLieu.Text))//gọi hàm update nguyên liệu trong lớp nguyenlieu_DAO để sữa thông tin trong database
                                {
                                    MessageBox.Show("Cập nhật thành công");
                                    getlist();
                                }

                            }
                            catch
                            {
                                MessageBox.Show("Cập nhật thất bại");
                            }
                        }

                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNguyenLieu.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập vào mã nguyên liệu");
            }
            else
            {
                try
                {
                    if (nguyenLieuDAO.Instance.deletenl(int.Parse(txtMaNguyenLieu.Text)))//gọi hàm xóa nguyên liệu trong database
                    {
                        MessageBox.Show("Xóa thành công");
                        getlist();
                    }

                }
                catch
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void Frm_NguyenLieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void Frm_NguyenLieu_Load(object sender, EventArgs e)
        {
            txtMaNguyenLieu.Focus();
        }

        private void txtMaNguyenLieu_Leave(object sender, EventArgs e)
        {
            if (txtMaNguyenLieu.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtMaNguyenLieu, "Phải nhập mã nguyên liệu !");
            else
                this.errorProvider1.Clear();
        }

        private void txtDonGiaTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gvvDanhSachThucDon_SelectionChanged(object sender, EventArgs e)
        {
            txtMaNguyenLieu.Text = gvvDanhSachThucDon.CurrentRow.Cells[0].Value.ToString();
            cbLoaiNguyenLieu.SelectedValue = gvvDanhSachThucDon.CurrentRow.Cells[1].Value.ToString();
            txtTenNguyenLieu.Text = gvvDanhSachThucDon.CurrentRow.Cells[2].Value.ToString();
            txtDonGiaTinh.Text = gvvDanhSachThucDon.CurrentRow.Cells[3].Value.ToString();
            txtDonViTinh.Text = gvvDanhSachThucDon.CurrentRow.Cells[4].Value.ToString();
        }
    }
}

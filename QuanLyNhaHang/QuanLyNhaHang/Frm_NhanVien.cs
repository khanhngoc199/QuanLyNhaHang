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
    public partial class Frm_NhanVien : Form
    {
        public Frm_NhanVien()
        {
            InitializeComponent();
            loadNhanVien();
            loadCbb();
            LoadDataFromGrv();
        }

        private void LoadDataFromGrv()
        {
            //hiển thị thông tin vào các textbox, combobox, khi ta chọn một dòng trong gridview
            txtMaNhanVien.DataBindings.Add(new Binding("Text", dgvDanhsachnhanvien.DataSource, "MANV"));
            txtTenNhanVien.DataBindings.Add(new Binding("Text", dgvDanhsachnhanvien.DataSource, "TENNV"));
            txtDienthoai.DataBindings.Add(new Binding("Text", dgvDanhsachnhanvien.DataSource, "DIENTHOAI"));
            txtDiachi.DataBindings.Add(new Binding("Text", dgvDanhsachnhanvien.DataSource, "DIACHI"));
            cbGioitinh.DataBindings.Add(new Binding("Text", dgvDanhsachnhanvien.DataSource, "GIOITINH"));
            dtpNgaysinh.DataBindings.Add(new Binding("Text", dgvDanhsachnhanvien.DataSource, "NGAYSINH"));
        }

        private void loadCbb()
        {
            List<chucNangDTO> ls = nhanVienDAO.Instance.getlist();//lấy danh sách các bộ phận trong nhà hàng
            foreach (chucNangDTO tb in ls)
            {
                cbBoPhan.Items.Add(tb.TenChucNang);//add danh sách các bộ phận vào combobox
            }
        }

        private void loadNhanVien()
        {
            dgvDanhsachnhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhsachnhanvien.DataSource = nhanVienDAO.Instance.getNhanvien();//gán datasource cho gridview
        }

        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtDiachi.Text == string.Empty)
                MessageBox.Show("Hãy nhập vào địa chỉ ");
            else
            {
                if (false)
                {

                }
                else
                {
                    if (txtMaNhanVien.Text == string.Empty)
                    {
                        MessageBox.Show("Hãy nhập vào mã nhân viên");
                    }
                    else
                    {
                        if (txtTenNhanVien.Text == string.Empty)
                        {
                            MessageBox.Show("Hãy nhập vào tên nhân viên ");
                        }
                        else
                        {
                            try
                            {
                                //lấy thông tin từ textbox, combobox,....
                                int maNV = int.Parse(txtMaNhanVien.Text);
                                string tenNV = txtTenNhanVien.Text;
                                string dc = txtDiachi.Text;
                                string dienthoai = txtDienthoai.Text;
                                string boPhan = cbBoPhan.Text;
                                string gioitinh = cbGioitinh.Text;
                                string ngaysinh = dtpNgaysinh.Text;
                                DateTime ngaySinh = Convert.ToDateTime(ngaysinh);
                                if (nhanVienDAO.Instance.insertNhanvien(maNV, tenNV, boPhan, dienthoai, dc, gioitinh, ngaySinh))//gọi hàm insert để insert vào database
                                {
                                    MessageBox.Show("Thêm thành công !!");
                                    loadNhanVien();
                                    foreach (Control i in this.Controls)
                                    {
                                        if (i is TextBox || i is ComboBox)
                                            i.ResetText();
                                        if (i is DateTimePicker) ((DateTimePicker)i).Text = DateTime.Now.ToString();
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Thất bại !!");
                                }

                            }
                            catch
                            {
                                MessageBox.Show("Hãy điền đầy đủ thông tin");

                            }
                        }

                    }
                }
            }

        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (txtDiachi.Text == string.Empty)
                MessageBox.Show("Hãy nhập vào địa chỉ ");
            else
            {
                if (txtDienthoai.Text == string.Empty)
                {
                    MessageBox.Show("Hãy nhập vào số điện thoại");
                }
                else
                {
                    if (txtMaNhanVien.Text == string.Empty)
                    {
                        MessageBox.Show("Hãy nhập vào mã nhân viên");
                    }
                    else
                    {
                        if (txtTenNhanVien.Text == string.Empty)
                        {
                            MessageBox.Show("Hãy nhập vào tên nhân viên ");
                        }
                        else
                        {
                            try
                            {
                                //lấy thông tin từ các textbox, combobox
                                int maNV = int.Parse(txtMaNhanVien.Text);
                                string tenNV = txtTenNhanVien.Text;
                                string dc = txtDiachi.Text;
                                string dienthoai = txtDienthoai.Text;
                                string boPhan = cbBoPhan.Text;
                                string gioitinh = cbGioitinh.Text;
                                string ngaysinh = dtpNgaysinh.Text;
                                DateTime ngaySinh = Convert.ToDateTime(ngaysinh);
                                if (nhanVienDAO.Instance.updateNhanvien(maNV, tenNV, boPhan, dienthoai, dc, gioitinh, ngaySinh))//gọi hàm update để sửa thông tin nhân viên trong database
                                {
                                    MessageBox.Show("Update Thành công!!");
                                    loadNhanVien();

                                }
                                else
                                {
                                    MessageBox.Show("Thất bại !!");
                                }

                            }
                            catch
                            {
                                MessageBox.Show("Hãy điền đầy đủ thông tin !");

                            }
                        }

                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập vào mã nhân viên");
            }
            try
            {
                int maNV = int.Parse(txtMaNhanVien.Text);
                if (nhanVienDAO.Instance.deleteNhanvien(maNV))//gọi hàm xóa thông tin nhân viên trong database
                {
                    MessageBox.Show("Xóa thành công !!");
                    loadNhanVien();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại !!");
                }
            }
            catch
            {
                MessageBox.Show("Mã nhân viên không tồn tại !");
            }

        }

        private void dgvDanhsachnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhsachnhanvien_SelectionChanged(object sender, EventArgs e)
        {
            // loaddatafromGrv();

            txtMaNhanVien.Text = dgvDanhsachnhanvien.CurrentRow.Cells[0].Value.ToString();
            cbBoPhan.SelectedValue = dgvDanhsachnhanvien.CurrentRow.Cells[1].Value.ToString();
            txtTenNhanVien.Text = dgvDanhsachnhanvien.CurrentRow.Cells[2].Value.ToString();
            cbGioitinh.Text = dgvDanhsachnhanvien.CurrentRow.Cells[3].Value.ToString();
            dtpNgaysinh.Text = dgvDanhsachnhanvien.CurrentRow.Cells[4].Value.ToString();
            txtDiachi.Text = dgvDanhsachnhanvien.CurrentRow.Cells[5].Value.ToString();
            txtDienthoai.Text = dgvDanhsachnhanvien.CurrentRow.Cells[6].Value.ToString();
        }

        private void Frm_NhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Phải nhập ký tự là số !");
            }
        }

        private void txtTenNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Phải nhập ký tự là chữ !");
            }
        }

        private void txtMaNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMaNhanVien.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtMaNhanVien, "Phải nhập mã nhân viên !");
            else
                this.errorProvider1.Clear();
        }
    }
}

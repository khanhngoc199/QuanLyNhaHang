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
    public partial class Frm_Ban : Form
    {
        public Frm_Ban()
        {
            InitializeComponent();
            loadBan();
        }

        private void loadBan()
        {
            dgvDanhSachBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachBan.DataSource = banDAO.Instance.getBan();
        }

        private void Frm_Ban_Load(object sender, EventArgs e)
        {
            txtMaBan.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Lấy các giá trị từ các textbox
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //lấy các giá trị từ các textbox,...
            string tenBan = txtTenBan.Text;
            string tenKV = lsbTenKhuVuc.Text;
            string trangThai = lsbTrangThai.Text;
            if (tenBan == string.Empty)//Kiểm tra các giá trị có hợp lệ không
            {
                MessageBox.Show("Hãy Nhập Tên Bàn");

            }
            else
            {
                if (tenKV == string.Empty)//Kiểm tra các giá trị có hợp lệ không
                {
                    MessageBox.Show("Hãy Nhập Tên Khu Vực");
                }
                else
                {
                    if (trangThai == string.Empty)
                    {
                        MessageBox.Show("Hãy Nhập Trạng Thái");
                    }
                    else
                    {
                        if (txtMaBan.Text == string.Empty)
                            MessageBox.Show("Hãy Nhập Mã Bàn");
                        else
                        {
                            try
                            {

                                int maBan = int.Parse(txtMaBan.Text);
                                if (banDAO.Instance.updatetBan(maBan, tenBan, tenKV, trangThai))//gọi hàm update và truyền tham số để thay đổi thông tin bàn
                                {
                                    MessageBox.Show("Thành công ");
                                    loadBan();//load lại gridview
                                }
                                else
                                {
                                    MessageBox.Show("Thất bại ");
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
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaBan.Text == string.Empty)//check xem mã bàn có được nhập chưa
                MessageBox.Show("Hãy Nhập Mã Bàn");
            try
            {
                int maBan = int.Parse(txtMaBan.Text);
                if (maBan == 0)
                    MessageBox.Show("Hãy Nhập Mã Bàn");

                if (banDAO.Instance.deleteban(maBan))//gọi hàm xóa bàn và truyền tham số
                {
                    MessageBox.Show("Thành công ");
                    loadBan();//load lại gridview
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ ");
            }
        }

        private void Frm_Ban_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtMaBan_TextChanged(object sender, EventArgs e)
        {
            if (txtMaBan.Text != string.Empty && txtTenBan.Text != string.Empty)
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void txtTenBan_TextChanged(object sender, EventArgs e)
        {
            if (txtMaBan.Text != string.Empty && txtTenBan.Text != string.Empty)
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void dgvDanhSachBan_SelectionChanged(object sender, EventArgs e)
        {
            txtMaBan.Text = dgvDanhSachBan.CurrentRow.Cells[0].Value.ToString();
            lsbTenKhuVuc.Text = dgvDanhSachBan.CurrentRow.Cells[1].Value.ToString();
            //txtTenBan.Text = dgvDanhSachBan.CurrentRow.Cells[2].Value.ToString();
            lsbTrangThai.Text = dgvDanhSachBan.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string tenBan = txtTenBan.Text;
            string tenKV = lsbTenKhuVuc.Text;
            string trangThai = lsbTrangThai.Text;
            if (tenBan == string.Empty)//kiểm tra tên bàn đã được nhập chưa
            {
                MessageBox.Show("Hãy Nhập Tên Bàn");
            }
            else
            {
                if (tenKV == string.Empty)//kiểm tra tên kv có được nhập chưa
                {
                    MessageBox.Show("Hãy Nhập Tên Khu Vực");
                }
                else
                {
                    if (trangThai == string.Empty)//kiểm tra trạng thái bàn đã được nhập chưa
                    {
                        MessageBox.Show("Hãy Nhập Trạng Thái");
                    }
                    else
                    {
                        if (txtMaBan.Text == string.Empty)//Kiểm tra mã bàn đã được nhập chưa
                            MessageBox.Show("Hãy Nhập Mã Bàn");
                        else
                        {
                            try
                            {
                                int maban = int.Parse(txtMaBan.Text);
                                if (banDAO.Instance.insertBan(maban, tenBan, tenKV, trangThai))//truyên tham số vào hàm insert trong lớp ban_DAO
                                {
                                    MessageBox.Show("Thành công!");
                                    loadBan();//load lại gridview danh sách bàn

                                    foreach (Control i in this.Controls)
                                    {
                                        if (i is TextBox || i is ListBox)
                                            i.ResetText();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Thất bại !");
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Nhập sai mã bàn !");

                            }
                        }
                    }

                }
            }
        }
    }
}

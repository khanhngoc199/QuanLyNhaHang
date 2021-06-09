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
    public partial class Frm_ChonMon : Form
    {
        List<monAnDTO> list;
        public static int maBan = 0;
        public Frm_ChonMon()
        {
            InitializeComponent();
            txtMaBan.Text = maBan.ToString();
            loadcb();
        }

        private void loadcb()
        {
            List<nhomMonAnDTO> group = nhomMonAnDAO.Instance.loadtennhom();//lấy danh sách món ăn
            cbLoaiThucDon.DataSource = group;//add danh sách món ăn vào combobox
            cbLoaiThucDon.DisplayMember = "tennhom";//hiểm thị danh sách món ăn mới trường là tên món ăn
        }
        private void loadfoodbythucdon(int id)
        {
            list = monAnDAO.Instance.getlisbyID(id);//lấy danh sách thực đơn
            cbMonAn.DataSource = list;//load danh sách thực đơn vào combobox
            cbMonAn.DisplayMember = "tenmonan";
            
        }
        private void Frm_ChonMon_Load(object sender, EventArgs e)
        {

        }

        private void cbLoaiThucDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lấy mã thực đơn
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            nhomMonAnDTO selected = cb.SelectedItem as nhomMonAnDTO;
            id = selected.MaNhom;
            loadfoodbythucdon(id);//load danh sách món ăn theo loại thực đơn
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            if (false)
            {

            }
            else
            {
                if (txtMaBan.Text == string.Empty)
                {
                    MessageBox.Show("Hãy nhập mã bàn ");
                }
                else
                {
                    if (txtMaChiTietHoaDon.Text == string.Empty)
                    {
                        MessageBox.Show("Hãy nhập mã chi tiết hóa đơn ");
                    }
                    else
                    {
                        if (txtMaHoaDon.Text == string.Empty)
                        {
                            MessageBox.Show("Hãy nhập mã hóa đơn ");
                        }
                        else
                        {
                            if (txtMaNhanVien.Text == string.Empty)
                            {
                                MessageBox.Show("Hãy nhập mã nhân viên ");
                            }
                            else
                            {
                                if (txtMaNhanVien.Text == string.Empty)
                                {
                                    MessageBox.Show("Hãy nhập mã nhân viên ");
                                }
                                else
                                {
                                    if (txtSoLuong.Text == string.Empty)
                                    {
                                        MessageBox.Show("Hãy nhập số lượng ");
                                    }
                                    else
                                    {
                                        if (txtMaChiTietHoaDon.Text == string.Empty)
                                        {
                                            MessageBox.Show("Hãy nhập mã chi tiết hóa đơn ");
                                        }
                                        else
                                        {
                                            try
                                            {
                                                //lấy dữ liệu từ các textbox, comboox,.....
                                              
                                                int mahd = int.Parse(txtMaHoaDon.Text);
                                                int maban = int.Parse(txtMaBan.Text);
                                                int macthd = int.Parse(txtMaChiTietHoaDon.Text);
                                                int manv = int.Parse(txtMaNhanVien.Text);
                                                string dc = txtDiaChi.Text;
                                                
                                                float sl = float.Parse(txtSoLuong.Text);
                                                string tenmonan = cbMonAn.Text.ToString();
                                                int mamonan = 0;

                                                foreach (monAnDTO mon in list)
                                                {
                                                    if (string.Compare(tenmonan, mon.TenMonAn) == 0)
                                                    {
                                                        mamonan = mon.MaMonAn;
                                                        break;
                                                    }


                                                }
                                                DateTime dt = DateTime.Today;
                                                if (mahd != 0 & maban != 0 & macthd != 0 & manv != 0 & dc != null  & sl != 0.0F & tenmonan != null & mamonan != 0)
                                                {
                                                  
                                                    updateSTTBan(maban);//update trạng thái bàn
                                                    insertHD(mahd, maban, manv, dt);//insert vào bảng hóa đơn
                                                    insertCTHD(macthd, mahd, mamonan, sl);//insert vao bảng chi tiết hóa đơn
                                                    this.Hide();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Hãy điền đầy đủ thông tin");
                                                }

                                            }
                                            catch
                                            {
                                                MessageBox.Show("Mã khách hàng, Mã hóa đơn, hoặc Mã chi tiết hóa đơn đã tồn tại");
                                            }
                                        }

                                    }

                                }

                            }
                        }
                    }
                }
            }
        }

        private void insertCTHD(int macthd, int mahd, int mamonan, float sl)
        {
            goiMonDAO.Instance.insertCTHD(macthd,  mahd,  mamonan,  sl);
        }

        private void insertHD(int mahd, int maban, int manv, DateTime tgvao)
        {
            goiMonDAO.Instance.insertHD(mahd, maban, manv, tgvao);
        }

        private void updateSTTBan(int maban)
        {
            goiMonDAO.Instance.updatesttban(maban);
        }

        private void txtMaHoaDon_Leave(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtMaHoaDon, "Phải nhập mã hóa đơn !");
            else
                this.errorProvider1.Clear();
        }

        private void txtMaChiTietHoaDon_Leave(object sender, EventArgs e)
        {
            if (txtMaChiTietHoaDon.Text.Trim().Length == 0)
                this.errorProvider2.SetError(txtMaChiTietHoaDon, "Phải nhập mã chi tiết hóa đơn !");
            else
                this.errorProvider2.Clear();
        }
    }
}

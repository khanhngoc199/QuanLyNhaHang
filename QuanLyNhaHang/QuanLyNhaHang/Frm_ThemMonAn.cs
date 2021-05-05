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
    public partial class Frm_ThemMonAn : Form
    {
        public static int maHoaDon = 0;
        List<monAnDTO> list;
        public Frm_ThemMonAn()
        {
            InitializeComponent();
            loadCB();//load dữ liệu cho các combobox
            txtMaHoaDon.Text = maHoaDon.ToString();//gán mã hóa đơn cho textbox
        }

        private void loadCB()
        {
            throw new NotImplementedException();
        }

        private void Frm_ThemMonAn_Load(object sender, EventArgs e)
        {

        }
        public void insertCTHD(int MACTHDX, int MAHDX, int MAMA, float SOLUONG)
        {
            goiMonDAO.Instance.insertCTHD(MACTHDX, MAHDX, MAMA, SOLUONG);//insert thông tin vào bảng chi tiết hóa đơn trong database
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (txtMaChiTietHoaDon.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập vào chi tiết hóa đơn ");
            }
            else
            {
                if (txtMaNhanVien.Text == string.Empty)
                {
                    MessageBox.Show("Hãy nhập vào mã nhân viên ");
                }
                else
                {
                    if (txtSoLuong.Text == string.Empty)
                    {
                        MessageBox.Show("Hãy nhập vào số lượng ");
                    }
                    else
                    {
                        try
                        {
                            //lấy thông tin từ các textbox, combobox
                            int mahd = int.Parse(txtMaHoaDon.Text);

                            int macthd = int.Parse(txtMaChiTietHoaDon.Text);
                            int manv = int.Parse(txtMaNhanVien.Text);


                            float sl = float.Parse(txtSoLuong.Text);
                            string tenmonan = cbMonAn.Text.ToString();
                            int mamonan = 0;

                            foreach (monAnDTO mon in list)
                            {
                                if (tenmonan.CompareTo(mon.TenMonAn) == 0)
                                {
                                    mamonan = mon.MaMonAn;//lấy mã món ăn theo tên món ăn
                                    break;
                                }


                            }
                            if (macthd != 0 && mahd != 0 && manv != 0 && sl != 0.0F && tenmonan != null && mamonan != 0)
                            {
                                insertCTHD(macthd, mahd, mamonan, sl);//insert thông tin vào bảng chi tiết hóa đơn trong database
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Hãy điền đầy đủ thông tin ");
                            }


                        }
                        catch
                        {
                            MessageBox.Show("Mã chi tiết hóa đơn đã tồn tại");
                        }

                    }

                }
            }
        }
    }
}

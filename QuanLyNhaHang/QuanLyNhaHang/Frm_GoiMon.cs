using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class Frm_GoiMon : Form
    {
        
        public Frm_GoiMon()
        {
            InitializeComponent();
            loadBan();
            loadCategory();
        }
        void loadBan()
        {
            List<banDTO> tableList = banDAO.Instance.getListBan();
            foreach (banDTO item in tableList)
            {
                Button btn = new Button()
                {
                    Width = banDAO.TableWidth,
                    Height = banDAO.TableHeight
                };
                btn.Text = item.TenBan + Environment.NewLine + item.TrangThai;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.TrangThai)
                {
                    case "Còn trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                flpBan.Controls.Add(btn);


            }
        }
        void showHoaDon(int id)
        {
            lvHoaDon.Items.Clear();
            List<menuDTO> listBillInfo = menuDAO.Instance.getListMenuByTable(id);
            float tongTien = 0;
            foreach (menuDTO item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.TenMonAn.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.DonGia.ToString());
                lsvItem.SubItems.Add(item.TongTien.ToString());
                tongTien += item.TongTien;
                lvHoaDon.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTongTien.Text = tongTien.ToString("c",culture);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as banDTO).MaBan;
            lvHoaDon.Tag = (sender as Button).Tag;
            showHoaDon(tableID);
        }

        private void Frm_GoiMon_Load(object sender, EventArgs e)
        {

        }
        void loadCategory()
        {
            List<nhomMonAnDTO> listNhomMonAn = nhomMonAnDAO.Instance.loadTenNhom();
            cbNhomMonAn.DataSource = listNhomMonAn;
            cbNhomMonAn.DisplayMember = "tenNhom";


        }
        void loadFoodListByCategoryID(int id)
        {
            List<monAnDTO> listMonAn = monAnDAO.Instance.getLisByID(id);
            cbMonAn.DataSource = listMonAn;
            cbMonAn.DisplayMember = "tenMonAn";
        }

        private void cbNhomMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            nhomMonAnDTO selected = cb.SelectedItem as nhomMonAnDTO;
            id = selected.MaNhom;
            loadFoodListByCategoryID(id);//load danh sách món ăn theo loại thực đơn
        }

        private void Frm_GoiMon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            banDTO table = lvHoaDon.Tag as banDTO;
            int idHoaDon = hoaDonDAO.Instance.GetUncheckBillIdByTableID(table.MaBan);
            int idMonAn = (cbMonAn.SelectedItem as monAnDTO).MaMonAn;
            int SoLuong = (int)nmSoLuong.Value;
            if (idHoaDon == -1)
            {
                hoaDonDAO.Instance.InsertBill(table.MaBan);
                chiTietHoaDonDAO.Instance.InsertBillInfo(hoaDonDAO.Instance.GetMaxIDBill(), idMonAn, SoLuong);
            }
            else
            {
                chiTietHoaDonDAO.Instance.InsertBillInfo(idHoaDon, idMonAn, SoLuong);
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}

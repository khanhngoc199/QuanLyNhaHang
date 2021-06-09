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
        float tongtien = 0;
        List<banDTO> listban;
        public Frm_GoiMon()
        {
            InitializeComponent();
            loadban();//load các bàn ăn
            loadlistbanan();//load thông tin của bàn được chọn
            loadcbb();
        }
        private void loadlistbanan()
        {
            dgvDanhSachBan.Controls.Clear();//xóa thông tin cũ trong listview
            dgvDanhSachBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachBan.DataSource = banDAO.Instance.getBan();//gán datasource
        }
        private void loadcbb()
        {
            cbbBan.DataSource = listban;
            cbbBan.DisplayMember = "Tenban";
        }
        private void loadban()
        {
            flTable.Controls.Clear();
            listban = banDAO.Instance.getlistban();
            foreach (banDTO table in listban)
            {
                Button btn = new Button();
                btn.Text = table.TenBan + Environment.NewLine + table.TrangThai + Environment.NewLine + "Khu Vực: " + table.MaKhuVuc.ToString();// set text button bằng tên của bàn
                btn.Tag = table;
                btn.Click += Btn_Click;//sự kiện click vào bàn
                //thay đổi màu cảu button theo trạng thái của bàn 
                switch (table.TrangThai)
                {
                    case "Còn trống":
                        btn.BackColor = Color.RoyalBlue;
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        break;
                }
                flTable.Controls.Add(btn);//add button vào control

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //load thông tin của bàn khi click vào 1 bàn nào đó
            try
            {
                tongtien = 0;
                int maban = ((sender as Button).Tag as banDTO).MaBan;
                lvHoaDon.Tag = (sender as Button).Tag;
                showmenu(maban);
            }
            catch
            {

            }
        }

        private void showmenu(int maban)
        {
            lvHoaDon.Items.Clear();

            List<menuDTO> list = menuDAO.Instance.getmenu(maban);//lấy danh sách thông tin bàn


            foreach (menuDTO item in list)
            {
                //add danh sách thông tin bàn vào listview
                ListViewItem lvitem = new ListViewItem(item.MaHD.ToString());
                lvitem.SubItems.Add(item.TenBan.ToString());
                lvitem.SubItems.Add(item.TenMonAn.ToString());
                lvitem.SubItems.Add(item.SoLuong.ToString());
                lvitem.SubItems.Add(item.DonGia.ToString());
                tongtien += item.DonGia * item.SoLuong;
                lvitem.SubItems.Add(item.DonViTinh.ToString());
                lvHoaDon.Items.Add(lvitem);
            }
            CultureInfo cutural = new CultureInfo("vi-VN");//thiết lập đơn vị tiền tệ
            txttongtien.Text = tongtien.ToString("c", cutural);
        }
        void showhd(int maban)
        {
            try
            {
                lvHoaDon.Items.Clear();
                List<chiTietHoaDonDTO> list = chiTietHoaDonDAO.Instance.getlistbyhdid(hoaDonXuatDAO.Instance.getidhdbyidban(maban));//lấy danh sách hóa đơn của bàn
                //add danh sách hóa đơn vào mảng
                foreach (chiTietHoaDonDTO item in list)
                {
                    ListViewItem lvitem = new ListViewItem(item.MaCTHD.ToString());
                    lvitem.SubItems.Add(item.MaMonAn.ToString());
                    lvHoaDon.Items.Add(lvitem);
                }
            }
            catch
            {

            }

        }

    

        
        private void gopban()
        {
            try
            {
                banDTO ban1 = lvHoaDon.Tag as banDTO;//lấy thông tin bàn thứ nhất
                banDTO ban2 = cbbBan.SelectedItem as banDTO;//lấy thông tin bàn thứ hai
                foreach (banDTO b in listban)
                {
                    if (string.Compare(cbbBan.Text, b.TenBan) == 0)
                    {
                        ban2 = b;

                    }
                    if (string.Compare(ban1.TenBan, b.TenBan) == 0)
                    {
                        ban1 = b;

                    }
                }
                if (ban1.TrangThai.Equals("Còn trống"))
                {
                    MessageBox.Show("Bàn: " + ban1.TenBan + " Trống");
                }
                else
                {
                    if (ban2.TrangThai.Equals("Còn trống"))
                    {
                        MessageBox.Show("Bàn: " + ban2.TenBan + " Trống");
                    }
                    else
                    {
                        if (ban1.MaBan == ban2.MaBan)
                        {
                            MessageBox.Show("Trùng Bàn !");
                        }
                        else
                        {
                            if (MessageBox.Show(string.Format("Bạn co muốn gọp bàn :   {0} vào bàn:   {1} không ?", ban1.TenBan, ban2.TenBan), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                                goiMonDAO.Instance.gopban(ban1.MaBan, ban2.MaBan);//gọi hàm gọp bàn
                            loadcbb();
                            loadban();
                            loadlistbanan();
                        }

                    }
                }

            }
            catch
            {
                MessageBox.Show(" Bàn Trống ");
            }



        }

        private void btnGopBan_Click(object sender, EventArgs e)
        {
            gopban();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            banDTO ban = lvHoaDon.Tag as banDTO;  //tạo đối tượng bàn
            DateTime dt = new DateTime();


            try
            {


                if (ban != null)
                {
                    DialogResult rs = MessageBox.Show("Bạn đang chọn bàn : " + ban.TenBan, "Nhắc nhở ", MessageBoxButtons.OKCancel);
                    if (rs == DialogResult.OK)
                    {
                        if (hoaDonXuatDAO.Instance.thanhtoan(ban.MaBan))
                        {
                            MessageBox.Show("Thanh toán thành công");
                            if (tongtien != 0)
                            {
                                menuDAO.Instance.addbaocao(ban.TenBan, dtpThoiGian.Value, tongtien);//add vào bảng báo cáo khi thanh toán
                            }
                            lvHoaDon.Items.Clear();
                            tongtien = 0;
                            txttongtien.Text = "0";

                            loadlistbanan();//load lại danh sách bàn
                            loadban();// load lại thông tin bàn
                        }
                    }


                }
                else
                {
                    MessageBox.Show("Hãy chọn bàn cần thanh toán");
                }
            }
            catch
            {

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadcbb();
            loadban();
            loadlistbanan();

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;//thiết lập giấy in
            printPreviewDialog.ShowDialog();//hiển thị thông tin hóa đơn trên giấy in
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                banDTO ban = lvHoaDon.Tag as banDTO;
                if (ban != null)
                {
                    List<menuDTO> list = menuDAO.Instance.getmenu(ban.MaBan);
                    menuDTO menu1 = list[0];
                    DateTime dt = new DateTime();

                    //vẽ các string vào graphics, giấy in như một đối tượng graphics
                    e.Graphics.DrawString(@" Nhà Hàng Rose
 Kính Chào Quý Khách ", new Font("Brush", 25, FontStyle.Italic), Brushes.Black, 0, 20);
                    e.Graphics.DrawString("HÓA ĐƠN", new Font("Arial", 40, FontStyle.Bold), Brushes.Black, 300, 200);
                    
                    float y = 400;


                    e.Graphics.DrawString("Tên Bàn: " + menu1.TenBan, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 50, 350);


                    e.Graphics.DrawString("Tên Món Ăn: " + "  | ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 50, 400);

                    e.Graphics.DrawString("Số Lượng: " + "  | ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 300, 400);

                    e.Graphics.DrawString("Đơn Giá: ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 500, 400);

                    foreach (menuDTO menu in list)
                    {
                        y += 50;


                        e.Graphics.DrawString(menu.TenMonAn, new Font("Arial", 20, FontStyle.Italic), Brushes.Black, 50, y);

                        e.Graphics.DrawString(menu.SoLuong.ToString(), new Font("Arial", 20, FontStyle.Italic), Brushes.Black, 350, y);

                        e.Graphics.DrawString(menu.DonGia.ToString() + " đ ", new Font("Arial", 20, FontStyle.Italic), Brushes.Black, 520, y);

                    }
                    e.Graphics.DrawString("Tổng Tiền :  " + txttongtien.Text, new Font("Arial", 20, FontStyle.Italic), Brushes.Black, 400, y + 50);
                    e.Graphics.DrawString("Ngày thanh toán :  " + DateTime.Now.ToString(), new Font("Arial", 20, FontStyle.Italic), Brushes.Black, 300, y + 100);
                    e.Graphics.DrawString("Nhân viên thanh toán :  ", new Font("Arial", 15, FontStyle.Italic), Brushes.Black, 400, y + 150);


                }
            }
            catch
            {

            }
        }

        private void Frm_GoiMon_Load(object sender, EventArgs e)
        {
            btnThanhToan.Enabled = btnInHoaDon.Enabled = btnLamMoi.Enabled = false;
        }

        private void Frm_GoiMon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            btnLamMoi.Enabled = btnInHoaDon.Enabled = btnThanhToan.Enabled = true;
            try
            {
                banDTO ban = lvHoaDon.Tag as banDTO;
                if (ban != null)
                {


                    int mahd = hoaDonXuatDAO.Instance.getidhdbyidban(ban.MaBan);//lấy mã hóa đơn từ mã bàn
                    if (mahd == -1)
                    {
                        Frm_ChonMon.maBan = ban.MaBan;
                        Frm_ChonMon f = new Frm_ChonMon();
                        f.ShowDialog();
                    }
                    else
                    {
                        Frm_ThemMonAn.maHoaDon = mahd;
                        Frm_ThemMonAn f = new Frm_ThemMonAn();
                        f.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn bàn");
                }
            }
            catch
            {

            }

            loadlistbanan();//load lại danh sách bàn
        }
    }
}

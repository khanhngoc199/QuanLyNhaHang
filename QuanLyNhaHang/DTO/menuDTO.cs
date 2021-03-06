using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class menuDTO
    {
        int maHD;
        string tenBan;
        string tenMonAn;
        int soLuong;
        float donGia;
        string donViTinh;
        float tongTien;
        private menuDTO() { }
        public menuDTO(int maHD, string tenBan, string tenMonAn, int soLuong, float donGia, string donViTinh, float tongTien=0)
        {
            this.maHD = maHD;
            this.tenBan = tenBan;
            this.tenMonAn = tenMonAn;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.donViTinh = donViTinh;
            this.tongTien = tongTien;
        }
        public menuDTO(DataRow row)
        {
            this.maHD = int.Parse(row["MAHD"].ToString());
            this.tenBan = row["TENBAN"].ToString();    
            this.tenMonAn = row["TENMONAN"].ToString();
            this.soLuong = int.Parse(row["SOLUONG"].ToString());
            this.donGia = (float)Convert.ToDouble(row["DONGIA"].ToString());
            this.donViTinh = row["DONVITINH"].ToString();
            this.tongTien = (float)Convert.ToDouble(row["TONGTIEN"].ToString());
        }
        public int MaHD { get { return maHD; } set { this.maHD = value; } }
        public string TenBan { get { return tenBan; } set { this.tenBan = value; } }
        public string TenMonAn { get { return tenMonAn; } set { this.tenMonAn = value; } }
        public float DonGia { get { return donGia; } set { this.donGia = value; } }
        public string DonViTinh { get { return donViTinh; } set { this.donViTinh = value; } }
        public int SoLuong { get { return soLuong; } set { this.soLuong = value; } }
        public float TongTien { get { return tongTien; } set { this.tongTien = value; } }
    }
}

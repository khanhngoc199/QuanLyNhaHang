using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class monAnDTO
    {
        int maMonAn;
        string tenMonAn;
        float donGia;
        string tenNhomMonAn;
        int soLuong;
        private monAnDTO() { }
        public monAnDTO(int maMon, string tenMon, float donGia, string tenNhomMonAn, int soLuong)
        {
            this.maMonAn = maMon;
            this.tenMonAn = tenMon;
            this.donGia = donGia;
            this.tenNhomMonAn = tenNhomMonAn;
            this.soLuong = soLuong;
        }
        public monAnDTO(DataRow row)
        {
            this.maMonAn = int.Parse(row["MAMA"].ToString());
            this.tenMonAn = row["TENMA"].ToString();
            this.donGia = float.Parse(row["DONGIA"].ToString());
            this.tenNhomMonAn = row["TENNMA"].ToString();
            this.soLuong = int.Parse(row["SOLUONG"].ToString());
        }

        public int MaMonAn { get { return maMonAn; } set { this.maMonAn = value; } }
        public string TenMonAn { get { return tenMonAn; } set { this.tenMonAn = value; } }
        public float DonGia { get { return donGia; } set { this.donGia = value; } }
        public string TenNhomMonAn { get { return tenNhomMonAn; } set { this.tenNhomMonAn = value; } }
        public int SoLuong { get { return soLuong; } set { this.soLuong = value; } }
    }
}

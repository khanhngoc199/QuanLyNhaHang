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
        private monAnDTO() { }
        public monAnDTO(int maMon, string tenMon, float donGia)
        {
            this.maMonAn = maMon;
            this.tenMonAn = tenMon;
            this.donGia = donGia;
        }
        public monAnDTO(DataRow row)
        {
            this.maMonAn = int.Parse(row["MAMA"].ToString());
            this.tenMonAn = row["TENMA"].ToString();
            this.donGia = float.Parse(row["DONGIA"].ToString());
        }

        public int MaMonAn { get { return maMonAn; } set { this.maMonAn = value; } }
        public string TenMonAn { get { return tenMonAn; } set { this.tenMonAn = value; } }
        public float DonGia { get { return donGia; } set { this.donGia = value; } }
    }
}

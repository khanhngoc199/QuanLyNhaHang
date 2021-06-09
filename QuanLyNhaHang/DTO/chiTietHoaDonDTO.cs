using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class chiTietHoaDonDTO
    {
        int maCTHD;
        int maHD;
        int maMonAn;
        float soLuong;
        private chiTietHoaDonDTO() { }
        public chiTietHoaDonDTO(int macthd, int mahd, int mamonan, float soluong)
        {
            this.maCTHD = macthd;
            this.maHD = mahd;
            this.maMonAn = mamonan;
            this.soLuong = soluong;
        }
        public chiTietHoaDonDTO(DataRow row)
        {
            this.maCTHD = int.Parse(row["MACTHDX"].ToString());
            this.maHD = int.Parse(row["MAHDX"].ToString());
            this.maMonAn = int.Parse(row["MAMA"].ToString());
            this.soLuong = float.Parse(row["SOLUONG"].ToString());
        }

        public int MaCTHD { get { return maCTHD; } set { this.maCTHD = value; } }
        public int MaHD { get { return maHD; } set { this.maHD = value; } }
        public int MaMonAn { get { return maMonAn; } set { this.maMonAn = value; } }
        public float SoLuong { get { return soLuong; } set { this.soLuong = value; } }
    }
}

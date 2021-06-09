using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class hoaDonXuatDTO
    {
        int maHD;
        int maBan;
        private hoaDonXuatDTO() { }
        public hoaDonXuatDTO(int mahd, int maban)
        {
            this.maHD = mahd;
            this.maBan = maban;
        }
        public hoaDonXuatDTO(DataRow row)
        {
            this.maHD = int.Parse(row["MAHDX"].ToString());
            this.maBan = int.Parse(row["MABAN"].ToString());
        }
        public int MaHD { get { return maHD; } set { this.maHD = value; } }
        public int MaBan { get { return maBan; } set { this.maBan = value; } }
    }
}

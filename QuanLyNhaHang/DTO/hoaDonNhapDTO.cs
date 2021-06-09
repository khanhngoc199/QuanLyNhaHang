using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class hoaDonNhapDTO
    {
        float tien;
        float soLuong;

        private hoaDonNhapDTO() { }
        public hoaDonNhapDTO(float tien, float sl)
        {
            this.tien = tien;
            this.soLuong = sl;
        }
        public hoaDonNhapDTO(DataRow row)
        {
            this.tien = float.Parse(row["DONGIA"].ToString());
            this.soLuong = float.Parse(row["SOLUONG"].ToString());
        }
        public float Tien { get { return tien; } set { this.tien = value; } }

        public float SLuong { get { return soLuong; } set { this.soLuong = value; } }
    }
}

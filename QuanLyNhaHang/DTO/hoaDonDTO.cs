using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class hoaDonDTO
    {
        int maHD;
        int maBan;
        DateTime? thoiGianVao;
        DateTime? thoiGianRa;
        int trangThai;
        float giamGia;
        private hoaDonDTO() { }
        public hoaDonDTO(int mahd, int maban, DateTime? thoigianvao, DateTime? thoigianra, int trangthai, int giamgia=0)
        {
            this.maHD = mahd;
            this.maBan = maban;
            this.thoiGianVao = thoigianvao;
            this.thoiGianRa = thoigianra;
            this.trangThai = trangthai;
            this.giamGia = giamgia;
        }
        public hoaDonDTO(DataRow row)
        {
            this.maHD = int.Parse(row["MAHDX"].ToString());
            this.maBan = int.Parse(row["MABAN"].ToString());
            this.thoiGianVao = (DateTime?)row["THOIGIANVAO"];
            var datacheckOutTemp = row["THOIGIANRA"];
            if (datacheckOutTemp.ToString() != "")
                this.thoiGianRa = (DateTime?)datacheckOutTemp;
            this.TrangThai = int.Parse(row["TRANGTHAI"].ToString());
            if (row["GIAMGIA"].ToString() != "")
                this.GiamGia = (int)row["GIAMGIA"];
        }
        public int MaHD { get { return maHD; } set { this.maHD = value; } }
        public int MaBan { get { return maBan; } set { this.maBan = value; } }
        public int TrangThai { get { return trangThai; } set { this.trangThai = value; } }
        public float GiamGia { get { return giamGia; } set { this.giamGia = value; } }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class nguyenLieuDTO
    {
        int maNL;
        int maNNL;
        string tenNL;
        float soLuong;
        string donVi;
        string tenNNL;

        public int MaNL { get { return maNL; } set { this.maNL = value; } }
        public int MaNNL { get { return maNNL; } set { this.maNNL = value; } }
        public string TenNL { get { return tenNL; } set { this.tenNL = value; } }
        public float SoLuong { get { return soLuong; } set { this.soLuong = value; } }
        public string DonVi { get { return donVi; } set { this.donVi = value; } }
        public string TenNNL { get { return tenNNL; } set { this.tenNNL = value; } }

        private nguyenLieuDTO() { }
        public nguyenLieuDTO(int manl, int mannl, string ten, float sol, string dv,string tennnl)
        {
            this.MaNL = manl;
            this.MaNNL = mannl;
            this.TenNL = ten;
            this.SoLuong = sol;
            this.DonVi = dv;
            this.TenNNL = tennnl;
        }
        public nguyenLieuDTO(DataRow row)
        {
            this.MaNL = int.Parse(row["MANL"].ToString());
            this.MaNNL = int.Parse(row["MANNL"].ToString());
            this.TenNL = row["TENNL"].ToString();
            this.SoLuong = float.Parse(row["DONGIA"].ToString());
            this.DonVi = row["DONVITINH"].ToString();
            this.TenNNL= row["TENNNL"].ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class nhomNguyenLieuDTO
    {
        int maNNL;
        string tenNNL;
        private nhomNguyenLieuDTO() { }
        public nhomNguyenLieuDTO(int mannl, string tennnl)
        {
            this.maNNL = mannl;
            this.tenNNL = tennnl;
        }
        public nhomNguyenLieuDTO(DataRow row)
        {
            this.maNNL = int.Parse(row["MANNL"].ToString());
            this.tenNNL = row["TENNNL"].ToString();
        }
        public int MaNNL { get { return maNNL; } set { this.maNNL = value; } }
        public string TenNNL { get { return tenNNL; } set { this.tenNNL = value; } }

    }
}

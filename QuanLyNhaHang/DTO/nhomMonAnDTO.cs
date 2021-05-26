using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class nhomMonAnDTO
    {
        private int maNhom;
        private string tenNhom;
        public nhomMonAnDTO() { }
        public nhomMonAnDTO(int manhom, string tennhom)
        {
            this.maNhom = manhom;
            this.tenNhom = tennhom;

        }
        public nhomMonAnDTO(DataRow data)
        {
            this.maNhom = int.Parse(data["MANMA"].ToString());
            this.tenNhom = data["TENNMA"].ToString();
        }
        public int MaNhom
        {
            get
            {
                return maNhom;
            }
            set
            {
                maNhom = value;
            }
        }
        public string TenNhom
        {
            get
            {
                return tenNhom;
            }
            set
            {
                tenNhom = value;
            }
        }
    }
}

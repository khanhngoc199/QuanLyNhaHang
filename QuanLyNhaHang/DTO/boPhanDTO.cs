using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class boPhanDTO
    {
        int ma;
        string ten;

        public boPhanDTO(int ma, string ten)
        {
            this.Ma = ma;
            this.Ten = ten;
        }
        public boPhanDTO(DataRow row)
        {
            this.Ma = int.Parse(row["MABP"].ToString());
            this.Ten = row["TENBP"].ToString();
        }

        public int Ma { get { return ma; } set { this.ma = value; } }
        public string Ten { get { return ten; } set { this.ten = value; } }
    }
}

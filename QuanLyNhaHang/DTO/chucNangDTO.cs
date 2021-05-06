using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class chucNangDTO
    {
        int maChucNang;
        string tenChucNang;

        public chucNangDTO(int maChucNang, string tenChucNang)
        {
            this.MaChucNang = maChucNang;
            this.TenChucNang = tenChucNang;
        }
        public chucNangDTO(DataRow row)
        {
            this.MaChucNang = int.Parse(row["MACHUCNANG"].ToString());
            this.TenChucNang = row["TENCHUCNANG"].ToString();
        }

        public int MaChucNang { get { return maChucNang; } set { this.maChucNang = value; } }
        public string TenChucNang { get { return tenChucNang; } set { this.tenChucNang = value; } }
    }
}

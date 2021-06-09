using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class baoCaoDTO
    {
        //lớp đối tượng báo cáo
        string ban;
        DateTime ngay;
        float tongTien;

        public baoCaoDTO(string ban, DateTime ngay, float tongtien)
        {
            this.Ban = ban;
            this.Ngay = ngay;
            this.TongTien = tongtien;
        }
        public baoCaoDTO(DataRow row)
        {
            this.Ban = row["TENBAN"].ToString();
            this.Ngay = (DateTime)row["NGAY"];
            this.TongTien = float.Parse(row["TONGTIEN"].ToString());
        }

        public string Ban { get { return ban; } set { this.ban = value; } }
        public DateTime Ngay { get { return ngay; } set { this.ngay = value; } }
        public float TongTien { get { return tongTien; } set { this.tongTien = value; } }
    }
}

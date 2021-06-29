using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class banDTO
    {
        private int maBan;
        private string tenBan;
        private int maKhuVuc;
        private string trangThai;
        private string tenKhuVuc;

        public static int with = 90;
        public static int hight = 90;
        public banDTO() { }

        public banDTO(int maBan, int maKV, string tenBan, string trangThai, string tenKhuVuc)
        {
            this.maBan = maBan;
            this.maKhuVuc = maKV;
            this.tenBan = tenBan;
            this.trangThai = trangThai;
            this.tenKhuVuc = tenKhuVuc;

        }
        public banDTO(DataRow data)
        {
            this.maBan = int.Parse(data["MABAN"].ToString());
            this.maKhuVuc = int.Parse(data["MAKV"].ToString());
            this.tenBan = data["TENBAN"].ToString();
            this.trangThai = data["TRANGTHAI"].ToString();
            this.tenKhuVuc = data["TENKV"].ToString();
        }

        public int MaBan
        {
            get { return maBan; }
            set { this.maBan = value; }
        }
        public string TenBan
        {
            get { return tenBan; }
            set { this.tenBan = value; }
        }
        public int MaKhuVuc { get { return maKhuVuc; } set { this.maKhuVuc = value; } }
        public string TrangThai { get { return trangThai; } set { this.trangThai = value; } }
        public string TenKhuVuc { get { return tenKhuVuc; } set { this.tenKhuVuc = value; } }
        
    }
}

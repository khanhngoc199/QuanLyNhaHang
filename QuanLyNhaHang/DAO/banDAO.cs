using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class banDAO
    {
        private static banDAO instance;//tạo đối tượng ban_DAO

        public static banDAO Instance//phương thức get & set
        {
            get
            {
                if (instance == null)
                    instance = new banDAO();

                return banDAO.instance;
            }

            private set
            {
                banDAO.instance = value;
            }
        }
        private banDAO() { }
        public DataTable getBan()//hàm lấy danh sách bàn từ database
        {
            return Database.Instrance.ExecuteQuery("SELECT * FROM DBO.BAN");//thực hiện câu truy vấn trên sql thông qua code c#
        }
        public bool insertBan(int maBan, string tenBan, string tenKhuVuc, string trangThai)//hàm insert thông tin bàn
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_insertBan @maban , @tenban , @tenkhuvuc , @trangthai ", new object[] { maBan, tenBan, tenKhuVuc, trangThai });
            return n > 0;
        }
        public bool updatetBan(int maBan, string tenBan, string tenKhuVuc, string trangThai)//hàm update bàn
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_updateBan @maban , @tenban , @tenkhuvuc , @trangthai ", new object[] { maBan, tenBan, tenKhuVuc, trangThai });
            return n > 0;
        }
        public bool deleteban(int maBan)//hàm xóa bàn
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_deleteBan @maban", new object[] { maBan });
            return n > 0;
        }
        public List<banDTO> getlistban()//hàm lấy danh sách bàn và add vào mảng
        {
            List<banDTO> listban = new List<banDTO>();

            DataTable table = Database.Instrance.ExecuteQuery("SELECT * FROM DBO.BAN");
            foreach (DataRow row in table.Rows)
            {
                banDTO ban = new banDTO(row);
                listban.Add(ban);
            }

            return listban;
        }
    }
}

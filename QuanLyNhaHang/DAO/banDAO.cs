using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            return Database.Instance.ExecuteQuery("SELECT * FROM DBO.BAN");//thực hiện câu truy vấn trên sql thông qua code c#
        }
        public bool insertBan(int maBan, string tenBan, string tenKhuVuc, string trangThai)//hàm insert thông tin bàn
        {
            //int n = Database.Instance.ExecuteNonQuery("EXEC USP_insertBan @maban , @tenban , @tenkhuvuc , @trangthai ", new object[] { maBan, tenBan, tenKhuVuc, trangThai });
            int n = Database.Instance.ExecuteNonQuery("USP_insertBan", new SqlParameter("@maban", maBan), new SqlParameter("@tenban", tenBan), new SqlParameter("@tenkhuvuc", tenKhuVuc), new SqlParameter("@trangthai", trangThai));
            return n > 0;
        }
        public bool updatetBan(int maBan, string tenBan, string tenKhuVuc, string trangThai)//hàm update bàn
        {
            //int n = Database.Instance.ExecuteNonQuery("EXEC USP_updateBan @maban , @tenban , @tenkhuvuc , @trangthai ", new object[] { maBan, tenBan, tenKhuVuc, trangThai });
            int n = Database.Instance.ExecuteNonQuery("USP_updateBan", new SqlParameter("@maban", maBan), new SqlParameter("@tenban", tenBan), new SqlParameter("@tenkhuvuc", tenKhuVuc), new SqlParameter("@trangthai", trangThai));
            return n > 0;
        }
        public bool deleteban(int maBan)//hàm xóa bàn
        {
            //int n = Database.Instance.ExecuteNonQuery("EXEC USP_deleteBan @maban", new object[] { maBan });
            int n = Database.Instance.ExecuteNonQuery("USP_deleteBan", new SqlParameter("@maban", maBan));
            return n > 0;
        }
        public List<banDTO> getListBan()//hàm lấy danh sách bàn và add vào mảng
        {
            List<banDTO> listban = new List<banDTO>();

            DataTable table = Database.Instance.ExecuteQuery("USP_getListBan");
            foreach (DataRow row in table.Rows)
            {
                banDTO ban = new banDTO(row);
                listban.Add(ban);
            }

            return listban;
        }
        public static int TableWidth = 110;
        public static int TableHeight = 110;
        
    }

}

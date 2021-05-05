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
        public bool insertBan(int maban, string tenban, string tenkhuvuc, string trangthai)//hàm insert thông tin bàn
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC usp_insertban @maban , @tenban , @tenkhuvuc , @trangthai ", new object[] { maban, tenban, tenkhuvuc, trangthai });
            return n > 0;
        }
        public bool updatetBan(int maban, string tenban, string tenkhuvuc, string trangthai)//hàm update bàn
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC usp_updateban @maban , @tenban , @tenkhuvuc , @trangthai ", new object[] { maban, tenban, tenkhuvuc, trangthai });
            return n > 0;
        }
        public bool deleteban(int maban)//hàm xóa bàn
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC usp_deleteban @maban", new object[] { maban });
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

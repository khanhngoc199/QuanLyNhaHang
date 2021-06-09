using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class menuDAO
    {
        private static menuDAO instance;

        public static menuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new menuDAO();

                return menuDAO.instance;
            }

            private set
            {
                menuDAO.instance = value;
            }
        }
        private menuDAO() { }
        public List<menuDTO> getmenu(int maBan)
        {
            List<menuDTO> list = new List<menuDTO>();
            DataTable tb = Database.Instrance.ExecuteQuery("EXEC USP_getMenu @maban ", new object[] { maBan });
            foreach (DataRow row in tb.Rows)
            {
                menuDTO menu = new menuDTO(row);
                list.Add(menu);
            }
            return list;
        }
        public bool addbaocao(string ban, DateTime ngay, float tong)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_insertBaoCao @tenban , @ngay , @tongtien ", new object[] { ban, ngay, tong });
            return n > 0;
        }
        public List<baoCaoDTO> getbaocao()
        {
            List<baoCaoDTO> list = new List<baoCaoDTO>();
            DataTable tb = Database.Instrance.ExecuteQuery("SELECT * FROM dbo.BAOCAO ");
            foreach (DataRow row in tb.Rows)
            {
                baoCaoDTO menu = new baoCaoDTO(row);
                list.Add(menu);
            }
            return list;
        }
        public DataTable getl()
        {
            return Database.Instrance.ExecuteQuery("SELECT * FROM dbo.BAOCAO");
        }

    }
}

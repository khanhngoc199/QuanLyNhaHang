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
        

    }
}

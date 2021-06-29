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
        public List<menuDTO> getListMenuByTable(int id)
        {
            List<menuDTO> listMenu = new List<menuDTO>();
            string query= "SELECT f.MAMA, bi.SOLUONG, f.DONGIA, f.DONGIA* bi.SOLUONG AS TONGTIEN FROM dbo.CHITIETHOADONXUAT AS bi, dbo.HOADONXUAT AS b, dbo.MONAN AS f WHERE bi.MAHDX = b.MABAN AND bi.MAMA = f.MAMA AND b.TRANGTHAI = 0 AND b.MABAN = " + id;
            DataTable data = Database.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                menuDTO menu = new menuDTO(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }

    }
}

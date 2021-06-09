using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class chiTietHoaDonDAO
    {
        private static chiTietHoaDonDAO instance;

        public static chiTietHoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new chiTietHoaDonDAO();

                return chiTietHoaDonDAO.instance;
            }

            private set
            {
                chiTietHoaDonDAO.instance = value;
            }
        }
        private chiTietHoaDonDAO() { }
        public List<chiTietHoaDonDTO> getlistbyhdid(int mahd)//lấy danh sách chi tiết hóa đơn theo mã hóa đơn
        {
            List<chiTietHoaDonDTO> list = new List<chiTietHoaDonDTO>();
            DataTable tb = Database.Instrance.ExecuteQuery("EXEC USP_getCTHD @mahd ", new object[] { mahd });
            foreach (DataRow row in tb.Rows)
            {
                chiTietHoaDonDTO hd = new chiTietHoaDonDTO(row);
                list.Add(hd);
            }
            return list;
        }
    }
}

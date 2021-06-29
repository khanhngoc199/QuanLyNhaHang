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
        public void DeleteBillInfoByFoodID(int idfood)
        {
            Database.Instance.ExecuteQuery("DELETE DBO.CHITIETHOADONXUAT WHERE MAMA =" + idfood);
        }

        public List<chiTietHoaDonDTO> GetListBillInfo(int id)
        {
            List<chiTietHoaDonDTO> listBillInfo = new List<chiTietHoaDonDTO>();
            DataTable data = Database.Instance.ExecuteQuery("select * from DBO.CHITIETHOADONXUAT where MAHDX = " + id);
            foreach (DataRow item in data.Rows)
            {
                chiTietHoaDonDTO info = new chiTietHoaDonDTO(item);
                listBillInfo.Add(info);
            }

            

            return listBillInfo;
        }

        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            Database.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @MAHDX , @MAMA , @SOLUONG", new object[] { idBill, idFood, count });
        }
        public void DeleteBillInforByFoofID(int id)
        {
            Database.Instance.ExecuteNonQuery("delete DBO.CHITIETHOADONXUAT where MAMA=" + id);
        }
    }
}

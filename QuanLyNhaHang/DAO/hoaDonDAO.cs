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
    public class hoaDonDAO
    {
        private static hoaDonDAO instance;

        public static hoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new hoaDonDAO();

                return hoaDonDAO.instance;
            }

            private set
            {
                hoaDonDAO.instance = value;
            }
        }
        private hoaDonDAO() { }
        public int GetUncheckBillIdByTableID(int id)
        {
            DataTable data = Database.Instance.ExecuteQuery("select * from dbo.HOADONXUAT where MABAN = " + id + "  and TRANGTHAI = 0");
            if (data.Rows.Count > 0)
            {
                hoaDonDTO bill = new hoaDonDTO(data.Rows[0]);
                return bill.MaHD;
            }
            return -1;
        }

        public void InsertBill(int id)
        {
            Database.Instance.ExecuteNonQuery("USP_insertBILL", new SqlParameter("@MABAN", id));
        }
        public void DeleteBill(int id)
        {
            Database.Instance.ExecuteNonQuery("USP_deleteHDX", new SqlParameter("@MAHDX", id));
        }

        public void CheckOut(int id, int giamgia, float tongtien_hoadon, float tongtien_thanhtoan)
        {
            string query = "UPDATE dbo.HOADONXUAT set THOIGIANRA = GETDATE(), STATUS =1," + "GIAMGIA=" + giamgia + ", TONGTIEN_HOADON =" + tongtien_hoadon + ", TONGTIEN_THANHTOAN =" + tongtien_thanhtoan + " where id =" + id;
            Database.Instance.ExecuteQuery(query);
        }

        // HÀM THỐNG KÊ DS HÓA ĐƠN THEO NGÀY
        public DataTable GetListBillByDate(DateTime thoigianvao, DateTime thoigianra)
        {
            return Database.Instance.ExecuteQuery("EXEC USP_GETLISTBILLBYDATE @THOIGIANVAO , @THOIGIANRA", new object[] { thoigianvao, thoigianra });
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)Database.Instance.ExecuteSalar("select MAX(MAHDX) from DBO.HOADONXUAT");

            }
            catch
            {
                return 1;
            }
        }

      
    }
}

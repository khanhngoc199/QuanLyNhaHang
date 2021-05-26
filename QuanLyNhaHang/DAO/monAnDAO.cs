using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class monAnDAO
    {
        private static monAnDAO instance;

        public static monAnDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new monAnDAO();

                return monAnDAO.instance;
            }

            private set
            {
                monAnDAO.instance = value;
            }
        }
        private monAnDAO() { }
        public DataTable getNhommonan()
        {
            return Database.Instrance.ExecuteQuery("SELECT * FROM DBO.MONAN");
        }
        public bool insertmonan(string tenNhom, int maMon, string tenMonAn, float donGia, string donViTinh, string trangThai)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_insertMonAn @tennhommonan , @mamonan , @tenmonan , @dongia , @donvitinh , @trangthai ", new object[] { tenNhom, maMon, tenMonAn, donGia, donViTinh, trangThai });
            return n > 0;
        }
        public bool updatetmonan(string tenNhom, int maMon, string tenMonAn, float donGia, string donViTinh, string trangThai)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_updateMonAn @tennhommonan , @mamonan , @tenmonan , @dongia , @donvitinh , @trangthai ", new object[] { tenNhom, maMon, tenMonAn, donGia, donViTinh, trangThai });
            return n > 0;
        }
        public bool deletemonan(int maMon)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_deleteMonAn @mamon ", new object[] { maMon });
            return n > 0;
        }
        public List<monAnDTO> getlisbyID(int id)
        {
            List<monAnDTO> list = new List<monAnDTO>();
            DataTable td = Database.Instrance.ExecuteQuery("EXEC USP_getListFood @id ", new object[] { id });
            foreach (DataRow row in td.Rows)
            {
                monAnDTO mon = new monAnDTO(row);
                list.Add(mon);
            }
            return list;
        }
        public int getmamon(string ten)
        {

            return (int)Database.Instrance.ExecuteSalar("EXEC USP_getMaMon @ten ", new object[] { ten });
        }
    }
}

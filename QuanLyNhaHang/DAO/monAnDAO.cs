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
            return Database.Instance.ExecuteQuery("SELECT * FROM DBO.MONAN");
        }
        public bool insertmonan(string tenNhom, int maMon, string tenMonAn, float donGia, string donViTinh, string trangThai,int soLuong)
        {
            int n = Database.Instance.ExecuteNonQuery("USP_insertMonAn", new SqlParameter("@tennhommonan", tenNhom), new SqlParameter("@mamonan", maMon), new SqlParameter("@mamonan", maMon), new SqlParameter("@tenmonan", tenMonAn), new SqlParameter("@dongia", donGia), new SqlParameter("@donvitinh", donViTinh), new SqlParameter("@trangthai", trangThai),new SqlParameter("@soluong",soLuong));
            return n > 0;
        }
        public bool updatetmonan(string tenNhom, int maMon, string tenMonAn, float donGia, string donViTinh, string trangThai,int soLuong)
        {
            int n = Database.Instance.ExecuteNonQuery("USP_updateMonAn", new SqlParameter("@tennhommonan", tenNhom), new SqlParameter("@mamonan", maMon), new SqlParameter("@tenmonan", tenMonAn), new SqlParameter("@dongia", donGia), new SqlParameter("@donvitinh", donViTinh), new SqlParameter("@trangthai", trangThai),new SqlParameter("@soluong",soLuong));
            return n > 0;
        }
        public bool deletemonan(int maMon)
        {
            int n = Database.Instance.ExecuteNonQuery("USP_deleteMonAn", new SqlParameter("@mamon", maMon));
            return n > 0;
        }
        public List<monAnDTO> getLisByID(int id)
        {
            List<monAnDTO> list = new List<monAnDTO>();
            DataTable td = Database.Instance.ExecuteQuery("EXEC USP_getListFood @id ", new object[] { id });
            foreach (DataRow row in td.Rows)
            {
                monAnDTO mon = new monAnDTO(row);
                list.Add(mon);
            }
            return list;
        }
        public int getmamon(string ten)
        {
            return (int)Database.Instance.ExecuteSalar("EXEC USP_getMaMon @ten ", new object[] { ten });
        }
        public monAnDTO getFoodByName(string name)
        {
            monAnDTO monan = null;         
            string query = string.Format("SELECT a.MAMA ,a.TENMA as 'Name' , B.TENNMA as 'TENNMA', A.DONGIA as 'Gia' FROM DBO.MONAN a, DBO.NHOMMONAN B where a.TENMA like  N'{0}' and a.MAMA=b.MANMA",name);
            DataTable data = Database.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                monan = new monAnDTO(item);
                return monan;
            }
            return monan;
        }
    }
}

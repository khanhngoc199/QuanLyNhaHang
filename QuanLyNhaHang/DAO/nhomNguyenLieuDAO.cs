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
    public class nhomNguyenLieuDAO
    {
        private static nhomNguyenLieuDAO instance;

        public static nhomNguyenLieuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new nhomNguyenLieuDAO();

                return nhomNguyenLieuDAO.instance;
            }

            private set
            {
                nhomNguyenLieuDAO.instance = value;
            }
        }
        private nhomNguyenLieuDAO() { }
        public DataTable getnhomnl()
        {
            return Database.Instance.ExecuteQuery("SELECT * FROM dbo.NHOMNGUYENLIEU");
        }
        public bool insertnhomnl(int maNNL, string tenNNL)
        {
            int n = Database.Instance.ExecuteNonQuery("USP_insertNhomNL", new SqlParameter("@mannl", maNNL), new SqlParameter("@tennnl", tenNNL));
            return n > 0;
        }
        public bool updatennl(int maNNL, string tenNNL)
        {
            int n = Database.Instance.ExecuteNonQuery("USP_updateNhomNL", new SqlParameter("@mannl", maNNL), new SqlParameter("@tennnl", tenNNL));
            return n > 0;
        }
        public bool delete(int maNNL)
        {

            int n = Database.Instance.ExecuteNonQuery("USP_deleteNhomNL", new SqlParameter("@mannl", maNNL));
            return n > 1;

        }
        public List<nhomNguyenLieuDTO> getlisnhom()
        {
            DataTable tb = Database.Instance.ExecuteQuery("SELECT * FROM dbo.NHOMNGUYENLIEU");
            List<nhomNguyenLieuDTO> list = new List<nhomNguyenLieuDTO>();
            foreach (DataRow row in tb.Rows)
            {
                nhomNguyenLieuDTO x = new nhomNguyenLieuDTO(row);
                list.Add(x);
            }
            return list;
        }
    }
}

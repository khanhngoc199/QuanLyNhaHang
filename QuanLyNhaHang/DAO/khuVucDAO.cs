using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class khuVucDAO
    {
        private static khuVucDAO instance;

        public static khuVucDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new khuVucDAO();

                return khuVucDAO.instance;
            }

            private set
            {
                khuVucDAO.instance = value;
            }
        }
        private khuVucDAO() { }
        public DataTable getKV()
        {
            return Database.Instance.ExecuteQuery("SELECT * FROM DBO.KHUVUC");
        }
        public bool insertkv(int maKV, string tenKV, string trangThai)
        {
            //int n = Database.Instance.ExecuteNonQuery("EXEC USP_insertKhuVuc @makv , @tenkv , @trangthai ", new object[] { maKV, tenKV, trangThai });
            int n = Database.Instance.ExecuteNonQuery("USP_insertKhuVuc", new SqlParameter("@makv", maKV), new SqlParameter("@tenkv", tenKV), new SqlParameter("@trangthai", trangThai));
            return n > 0;
        }
        public bool updatetkv(int maKV, string tenKV, string trangThai)
        {
            //int n = Database.Instance.ExecuteNonQuery("EXEC USP_updateKhuVuc @makv , @tenkv , @trangthai ", new object[] { maKV, tenKV, trangThai });
            int n = Database.Instance.ExecuteNonQuery("USP_updateKhuVuc", new SqlParameter("@makv", maKV), new SqlParameter("@tenkv", tenKV), new SqlParameter("@trangthai", trangThai));
            return n > 0;
        }
    }
}

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
    public class nhomMonAnDAO
    {
        private static nhomMonAnDAO instance;

        public static nhomMonAnDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new nhomMonAnDAO();

                return nhomMonAnDAO.instance;
            }

            private set
            {
                nhomMonAnDAO.instance = value;
            }
        }
        private nhomMonAnDAO() { }
        public DataTable getNhommonan()
        {
            return Database.Instance.ExecuteQuery("SELECT * FROM DBO.NHOMMONAN");
        }
        public bool insertnhommonan(int manhom, string tennhom)
        {
            int n = Database.Instance.ExecuteNonQuery("USP_insertMaMA", new SqlParameter("@manma", manhom), new SqlParameter("@tennma", tennhom));
            return n > 0;
        }
        public bool updatenhommonan(int manhom, string tennhom)
        {
            int n = Database.Instance.ExecuteNonQuery("USP_updateMaMA", new SqlParameter("@manma", manhom), new SqlParameter("@tennma", tennhom));
            return n > 0;
        }
        public bool deletenhommonan(int manhom)
        {
            int n = Database.Instance.ExecuteNonQuery("USP_deleteMaMA", new SqlParameter("@manma", manhom));
            return n > 0;
        }
        public List<nhomMonAnDTO> loadTenNhom()
        {
            List<nhomMonAnDTO> list = new List<nhomMonAnDTO>();
            DataTable table = Database.Instance.ExecuteQuery("SELECT * FROM dbo.NHOMMONAN");
            foreach (DataRow row in table.Rows)
            {
                nhomMonAnDTO nhom = new nhomMonAnDTO(row);
                list.Add(nhom);
            }
            return list;
        }
    }
}

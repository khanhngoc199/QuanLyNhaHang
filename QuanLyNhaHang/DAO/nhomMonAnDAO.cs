using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
            return Database.Instrance.ExecuteQuery("SELECT * FROM DBO.NHOMMONAN");
        }
        public bool insertnhommonan(int manhom, string tennhom)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_insertMaMA @manma , @tennma ", new object[] { manhom, tennhom });
            return n > 0;
        }
        public bool updatenhommonan(int manhom, string tennhom)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_updateMaMA @manma , @tennma ", new object[] { manhom, tennhom });
            return n > 0;
        }
        public bool deletenhommonan(int manhom)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_deleteMaMA @manma  ", new object[] { manhom });
            return n > 0;
        }
        public List<nhomMonAnDTO> loadtennhom()
        {
            List<nhomMonAnDTO> group = new List<nhomMonAnDTO>();
            DataTable table = Database.Instrance.ExecuteQuery("SELECT * FROM dbo.NHOMMONAN");
            foreach (DataRow row in table.Rows)
            {
                nhomMonAnDTO nhom = new nhomMonAnDTO(row);
                group.Add(nhom);
            }
            return group;
        }
    }
}

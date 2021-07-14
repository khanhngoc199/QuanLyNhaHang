using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class goiMonDAO
    {
        private static goiMonDAO instance;

        public static goiMonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new goiMonDAO();

                return goiMonDAO.instance;
            }

            private set
            {
                goiMonDAO.instance = value;
            }
        }
        private goiMonDAO() { }
        public bool updatesttban(int maBan)
        {
            int n = Database.Instance.ExecuteNonQuery("USP_updateSTTBan", new SqlParameter("@maban", maBan));
            return n > 0;
        }
        public bool insertHD(int MAHDX, int MABAN, int MANV, DateTime THOIGIANVAO)
        {
            int n = Database.Instance.ExecuteNonQuery("USP_insertHD", new SqlParameter("@maban", MABAN),new SqlParameter( "@mahd ", MAHDX),new SqlParameter("@manhanvien", MANV),new SqlParameter ("@thoigianvao",THOIGIANVAO));           
            return n > 0;
        }
        public bool insertCTHD(int MACTHDX, int MAHDX, int MAMA, float SOLUONG)
        {
            int n = Database.Instance.ExecuteNonQuery("USP_insertHDX", new SqlParameter("@macthd", MACTHDX), new SqlParameter("@mahd", MAHDX), new SqlParameter("@maman", MAMA), new SqlParameter("@soluong", SOLUONG));
            return n > 0;
        }
        public bool gopban(int mb1, int mb2)
        {
            int n = Database.Instance.ExecuteNonQuery("USP_gopBanAn", new SqlParameter("@idban1", mb1), new SqlParameter("@idban2", mb2));
            return n > 0;
        }
    }
}

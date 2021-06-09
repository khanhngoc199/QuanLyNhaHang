using System;
using System.Collections.Generic;
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
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_updateSTTBan @maban ", new object[] { maBan });
            return n > 0;
        }
        public bool insertHD(int MAHDX, int MABAN, int MANV, DateTime THOIGIANVAO)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_insertHD @mahd , @maban , @manhanvien , @thoigianvao  ", new object[] { MAHDX, MABAN, MANV, THOIGIANVAO });
            return n > 0;
        }
        public bool insertCTHD(int MACTHDX, int MAHDX, int MAMA, float SOLUONG)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_insertHDX @macthd , @mahd , @maman , @soluong ", new object[] { MACTHDX, MAHDX, MAMA, SOLUONG });
            return n > 0;
        }
        public bool gopban(int mb1, int mb2)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_gopBanAn @idban1 , @idban2 ", new object[] { mb1, mb2 });
            return n > 0;
        }
    }
}

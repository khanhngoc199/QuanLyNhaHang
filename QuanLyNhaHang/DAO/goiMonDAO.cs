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
        public bool updatesttban(int maban)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_Updatesttban @maban ", new object[] { maban });
            return n > 0;
        }
        public bool insertHD(int MAHDX, int MABAN, int MANV, DateTime THOIGIANVAO, int MAKH)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_InsertHD @mahd , @maban , @manhanvien , @thoigianvao , @makh ", new object[] { MAHDX, MABAN, MANV, THOIGIANVAO, MAKH });
            return n > 0;
        }
        public bool insertCTHD(int MACTHDX, int MAHDX, int MAMA, float SOLUONG)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_InsertHDX @macthd , @mahd , @maman , @soluong ", new object[] { MACTHDX, MAHDX, MAMA, SOLUONG });
            return n > 0;
        }
        public bool gopban(int mb1, int mb2)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_Gopbananc @idban1 , @idban2 ", new object[] { mb1, mb2 });
            return n > 0;
        }
    }
}

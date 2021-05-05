using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class userDAO
    {
        private static userDAO instance;

        public static userDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new userDAO();
                return instance;
            }

            set
            {
                userDAO.instance = value;
            }
        }
        private userDAO() { }
        public bool login(string username, string password)
        {
            string query = "USP_Login @tenTaiKhoan , @matKhau";
            DataTable result = Database.Instrance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool createUser(int ma, string user, string pass)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_Creatuser @manv , @user , @matkhau ", new object[] { ma, user, pass });
            return n > 0;
        }
        public bool updateUser(string user, string pass, string pass1)
        {
            int n = Database.Instrance.ExecuteNonQuery("EXEC USP_Updateuser2 @user , @pass , @pass1 ", new object[] { user, pass, pass1 });
            return n > 0;
        }
    }
}

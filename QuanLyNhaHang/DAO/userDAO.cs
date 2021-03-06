using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            string query = "SELECT * FROM DBO.NGUOIDUNG WHERE TENND=N'" + username + " ' AND MATKHAU=N'" + password + " '";
            DataTable result = Database.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool createND(int ma, string user, string pass)
        {
            //int n = Database.Instance.ExecuteNonQuery("EXEC USP_creatUser @manv , @user , @matkhau ", new object[] { ma, user, pass });
            int n = Database.Instance.ExecuteNonQuery("USP_creatUser", new SqlParameter("@manv", ma), new SqlParameter("@user", user), new SqlParameter("@matkhau", pass));
            return n > 0;
        }
        public bool updateuser(string user, string pass, string pass1)
        {
            //int n = Database.Instance.ExecuteNonQuery("EXEC USP_updateUser @user , @pass , @pass1 ", new object[] { user, pass, pass1 });
            int n = Database.Instance.ExecuteNonQuery("USP_updateUser", new SqlParameter("@user", user), new SqlParameter("@pass", pass), new SqlParameter("@pass1", pass1));
            return n > 0;
        }
    }
}

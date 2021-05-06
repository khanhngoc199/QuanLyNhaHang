using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Database
    {
        //lớp conection để kết nối chương trình với sql
        private static Database instrance;
        SqlDataAdapter adapter;

        public static Database Instrance
        {
            get
            {
                if (instrance == null)
                    instrance = new Database();
                return instrance;
            }

            private set
            {
                Database.instrance = value;
            }
        }

        public static DataTable excutequery { get; internal set; }

        private Database() { }
        //chuỗi kết nối sql
        private string ConnectionSTR = @"Data Source=DESKTOP-8GCG3PG ;Initial Catalog=QLNH;Integrated Security=True";

        public DataTable ExecuteQuery(string query,params SqlParameter[] parameter)
        {
            DataTable data;

            using (SqlConnection connection = new SqlConnection(ConnectionSTR))//mở kết nối sql
            {
                if(connection.State==ConnectionState.Open)
                {
                    connection.Close();
                }
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 600;
                if (parameter != null)
                {
                    //kiểm tra câu lệnh truy vấn và các tham số truyền vào
                    
                    foreach (SqlParameter item in parameter)
                    {

                        command.Parameters.Add(item);
                           
                    }
                }

                 adapter = new SqlDataAdapter(command);//tạo adapter sql
                data = new DataTable();
                adapter.Fill(data);//đổ dữ liệu vào biến data.

                connection.Close();//đóng kết nối
            }

            return data;// trả về kết quả cho hàm
        }


        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionSTR))//mở kết nối với sql
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }
        public object ExecuteSalar(string query, object[] parameter = null)
        {
            object ob = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                ob = command.ExecuteNonQuery();
                connection.Close();
            }

            return ob;// trả về số dòng đc thực thi
            //sd:insert, update, delete
        }
    }
}

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
        private static Database instance;

        public static Database Instance
        {
            get
            {
                if (instance == null)
                    instance = new Database();
                return instance;
            }

            private set
            {
                Database.instance = value;
            }
        }

        public static DataTable excutequery { get; internal set; }

        private Database() { }
        //chuỗi kết nối sql
        private string ConnectionSTR = @"Data Source=DESKTOP-8GCG3PG ;Initial Catalog=QLNHang;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionSTR))//mở kết nối sql
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    //kiểm tra câu lệnh truy vấn và các tham số truyền vào
                    string[] listPara = query.Split(' ');// cắt chuỗi để lấy các tham số
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))//kiểm tra phần tử nào trong mảng có tý tự @ trước.
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);//add vào mảng các tham số
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);//tạo adapter sql

                adapter.Fill(data);//đổ dữ liệu vào biến data.

                connection.Close();//đóng kết nối
            }

            return data;// trả về kết quả cho hàm
        }


        public int ExecuteNonQuery(string query,params SqlParameter[] parameter)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionSTR))//mở kết nối với sql
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                if (parameter != null)
                {
                    foreach (SqlParameter item in parameter)
                    {
                        command.Parameters.Add(item);
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
        public object ExecuteSalarToDouble(string query, object[] parameter = null)
        {
            object dt = 0;
            using (SqlConnection connect = new SqlConnection(ConnectionSTR))
            {
                connect.Open();
                SqlCommand comd = new SqlCommand(query, connect);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            comd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }

                    }
                }
                dt = comd.ExecuteScalar().ToString();
                connect.Close();
                return dt;
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanAo.Data
{
    class dataProvider
    {
        

        //khai báo một chuỗi kết nối và tạo kết nối
        public static string connectionSTR = "Data Source=Quynh\\SQLEXPRESS;Initial Catalog=NhaHang;Integrated Security=True";
        public static DataTable GetDataTable(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))//du lieu duoc khai bao trong ngoac tu duoc giai phong
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);//thuc thi query tren ket noi connection
                SqlDataAdapter adapter = new SqlDataAdapter(command);//trung gian dua ra ket qua
                adapter.Fill(data);
                connection.Close();
            }


            return data;

        }
        public static DataTable exc(string query)
        {
            DataTable data = new DataTable();
            // string connectionSTR = "Data Source= DESKTOP-0JUE26U\\SQLEXPRESS;Initial Catalog = QuanLiquanCafe;Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connectionSTR))//du lieu duoc khai bao trong ngoac tu duoc giai phong
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);//thuc thi query tren ket noi connection
                command.ExecuteNonQuery();
               // SqlDataAdapter adapter = new SqlDataAdapter(command);//trung gian dua ra ket qua
                //adapter.Fill(data);
                connection.Close();
            }


            return data;

        }
        public static object ExcScalar(string query)
        {
            object data = 0;
            // string connectionSTR = "Data Source= DESKTOP-0JUE26U\\SQLEXPRESS;Initial Catalog = QuanLiquanCafe;Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connectionSTR))//du lieu duoc khai bao trong ngoac tu duoc giai phong
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);//thuc thi query tren ket noi connection
                data = command.ExecuteScalar();
                // SqlDataAdapter adapter = new SqlDataAdapter(command);//trung gian dua ra ket qua
                //adapter.Fill(data);
                connection.Close();
            }


            return data;
        }

    }
}
//sqlCommand: thực thi SQL query, câu lệnh hoặc lưu trữ thủ tục
//sqlConnection: tạo kết nối với SQL Server
//SQL Adapter: cầu nối trung gian giữa dataset và data source

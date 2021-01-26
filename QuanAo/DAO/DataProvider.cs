using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    +DATASET chứa nhiều DataTable
    +DATA ADAPTER là cầu nối giữa Dataset và DataSource
    +Lớp SqlCommand cho phép tạo ra đối tượng mà từ đó có thể thi hành các lệnh SQL như các lệnh UPDATE|INSERT|CREATE TABLE|SELECT ... 
cũng như cho phép thi hành các hàm, các stored procedure của Database.
     +Đối tượng SqlParameter là tham số trong phương thức Add() của property Parameters của đối tượng SqlCommand trên.
Bạn phải thêm một SqlParameter duy nhất cho mỗi parameter đã định nghĩa trong câu lệnh SQL của đối tượng SqlCommand.
*/

namespace QuanAo
{
    public class DataProvider   // DataProvider trả về data table
    {
        private static DataProvider instance;  // đóng gói Ctrl +R +E

        private string connectionSTR = "Data Source=Quynh\\SQLEXPRESS;Initial Catalog=NhaHang;Integrated Security=True";  // kết nối với thằng nào

        SqlConnection connection = new SqlConnection();
        public DataProvider()
        {
            try
            {
                connection.ConnectionString = connectionSTR;
                connection.Open();
            }
            catch { }
        }
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
       

        public bool TestConnect()
        {
            if (connection.State == ConnectionState.Open) return true;
            return false;
        }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable(); // Khai báo một Dataset

            // Sử dụng using là để khi thực hiện xong thì nó tự giải phóng bộ nhớ
            using (SqlConnection connection = new SqlConnection(connectionSTR)) // Kết nối với database
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);   // Câu truy vẫn để thực thi

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');  // Trả về các chuỗi được phân cách bởi dấu cách
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))   // Nếu item chứa kí tự @
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }


                SqlDataAdapter adapter = new SqlDataAdapter(command);   // trung gian thực hiện câu truy vấn lấy dữ liệu

                adapter.Fill(data); // Đổ dữ liệu vào data

                connection.Close();
            }

            return data; // Trả về một bảng dữ liệu
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0; // số dòng thêm ,sửa , xóa thành công (thêm , sửa , xóa ...)

            // Sử dụng using là để khi thực hiện xong thì nó tự giải phóng bộ nhớ
            using (SqlConnection connection = new SqlConnection(connectionSTR)) // Kết nối với database
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);   // Câu truy vẫn để thực thi

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


        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0; // Trả về ô đầu tiên trong dataset

            // Sử dụng using là để khi thực hiện xong thì nó tự giải phóng bộ nhớ
            using (SqlConnection connection = new SqlConnection(connectionSTR)) // Kết nối với database
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);   // Câu truy vẫn để thực thi

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
                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }

//==================================================================================================================================================--
        // Load lên danh sách Account từ bảng Account
        public DataTable loadAccount()
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_load_account";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }


        /// <summary>
        /// Thêm mới 1 tài khoản Account
        /// </summary>
      
        public void AddAccount(string ID,string USERNAME, string PASSWORD)
        {
            SqlCommand command = new SqlCommand("sp_Add_Account", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ID", SqlDbType.NVarChar).Value = ID;
            command.Parameters.AddWithValue("@USERNAME", SqlDbType.NVarChar).Value = USERNAME;
            command.Parameters.AddWithValue("@PASSWORD", SqlDbType.NVarChar).Value = PASSWORD;
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Xoá 1 tài khoản Account
        /// </summary>
      
        public void DelAccount(string USERNAME)
        {
            SqlCommand command = new SqlCommand("sp_Del_Account", connection);
         //   command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
         //   command.CommandText = "sp_Del_Account";
            command.Parameters.AddWithValue("@USERNAME", SqlDbType.NVarChar).Value = USERNAME;
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Sửa đổi 1 tài khoản Account
        /// </summary>
       
        public void UpdateAccount(string ID,string USERNAME, string PASSWORD, string Where)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_Update_Account";
            command.Parameters.AddWithValue("@ID", SqlDbType.NVarChar).Value = ID;
            command.Parameters.AddWithValue("@USERNAME", SqlDbType.NVarChar).Value = USERNAME;
            command.Parameters.AddWithValue("@PASSWORD", SqlDbType.NVarChar).Value = PASSWORD;
            command.Parameters.AddWithValue("@Where_USERNAME", SqlDbType.NVarChar).Value = Where;
            command.ExecuteNonQuery();
            connection.Close();
        }
//===================================================================================================================================================-
        // Load lên danh sách Nhân viên từ bảng NhanVien
        public DataTable loadNhanVien()
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_load_nhanvien";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }

        /// <summary>
        /// Thêm mới 1 Nhân Viên
        /// </summary>

        public void AddNhanVien(string ID, string USERNAME, string GT, string NS, string CV, string SDT, string LUONG,string KN)
        {
            SqlCommand command = new SqlCommand("sp_Add_NhanVien", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ID", SqlDbType.NVarChar).Value = ID;
            command.Parameters.AddWithValue("@USERNAME", SqlDbType.NVarChar).Value = USERNAME;
            command.Parameters.AddWithValue("@GT", SqlDbType.NVarChar).Value = GT;
            command.Parameters.AddWithValue("@NS", SqlDbType.DateTime).Value = DateTime.Parse(NS);
            command.Parameters.AddWithValue("@CV", SqlDbType.NVarChar).Value = CV;
            command.Parameters.AddWithValue("@SDT", SqlDbType.NVarChar).Value = SDT;
            command.Parameters.AddWithValue("@LUONG", SqlDbType.Float).Value = Convert.ToDouble(LUONG);
            command.Parameters.AddWithValue("@KN", SqlDbType.NVarChar).Value = KN;
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Xoá 1 Nhân Viên khỏi danh sách
        /// </summary>

        public void DelNhanVien(string USERNAME)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_Del_NhanVien";
            command.Parameters.AddWithValue("@USERNAME", SqlDbType.NVarChar).Value = USERNAME;
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Sửa đổi 1 thông tin của một nhân viên
        /// </summary>

        public void UpdateNhanVien( string ID, string USERNAME, string GT, string NS, string CV, string SDT, string LUONG, string KN,string Where)
        {
            SqlCommand command = new SqlCommand("sp_Update_NhanVien", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ID", SqlDbType.NVarChar).Value = ID;
            command.Parameters.AddWithValue("@USERNAME", SqlDbType.NVarChar).Value = USERNAME;
            command.Parameters.AddWithValue("@GT", SqlDbType.NVarChar).Value = GT;
            command.Parameters.AddWithValue("@NS", SqlDbType.Date).Value = DateTime.Parse(NS);
            command.Parameters.AddWithValue("@CV", SqlDbType.NVarChar).Value = CV;
            command.Parameters.AddWithValue("@SDT", SqlDbType.NVarChar).Value = SDT;
            command.Parameters.AddWithValue("@LUONG", SqlDbType.Float).Value = Convert.ToDouble(LUONG);
            command.Parameters.AddWithValue("@KN", SqlDbType.NVarChar).Value = KN;
            command.Parameters.AddWithValue("@Where_USERNAME", SqlDbType.NVarChar).Value = Where;
            command.ExecuteNonQuery();
            connection.Close();
        }



    }
}

using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace NhaHang
{
    class KetNoi
    {
        public static string connectionstr = @"Data Source=DESKTOP-F9OV7A9\SQLEXPRESS;Initial Catalog=NhaHang2;Integrated Security=True";
        SqlConnection connection;
        DataTable data;
        SqlDataAdapter adapter;
        SqlCommand command;
        public SqlConnection open()
        {
            connection = new SqlConnection(connectionstr);

            if (connection.State == ConnectionState.Closed)
                connection.Open();

            return connection;
        }
        public SqlConnection close()
        {
            connection = new SqlConnection(connectionstr);

            if (connection.State == ConnectionState.Open)
                connection.Close();

            return connection;
        }
        public DataTable truyvanSQL (string query)
        {
            open();
            data = new DataTable();
            command = new SqlCommand(query,connection);
            adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            close();
            return data;
        }
        public DataTable truyvanTSql(string query)
        {
            open();
            data = new DataTable();
            command = new SqlCommand(query,connection);
            command.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            close();
            return data;
        }
        public SqlCommand Them_NL(string TenNL, int SL)
        {
            open();
            command = new SqlCommand("add_NL", connection);
            command.Parameters.Add(new SqlParameter("@ten_NL", TenNL));
            command.Parameters.Add(new SqlParameter("@SL", SL));
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            close();
            return command;
        }
        public SqlCommand Sua_NL(int MaNL,string TenNL, int SL)
        {
            open();
            command = new SqlCommand("update_NL", connection);
            command.Parameters.Add(new SqlParameter("@ma_NL", MaNL));
            command.Parameters.Add(new SqlParameter("@ten_NL", TenNL));
            command.Parameters.Add(new SqlParameter("@SL", SL));
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            close();
            return command;
        }
        public SqlCommand Xoa_NL(int MaNL)
        {
            open();
            command = new SqlCommand("delete_NL", connection);
            command.Parameters.Add(new SqlParameter("@ma_NL", MaNL));
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            close();
            return command;
        }
        public SqlCommand Them_CTNK(int MaPNK, int MaNL, int SL, int Gia)
        {
            open();
            command = new SqlCommand("add_CTNK", connection);
            command.Parameters.Add(new SqlParameter("@ma_PNK", MaPNK));
            command.Parameters.Add(new SqlParameter("@ma_NL", MaNL));
            command.Parameters.Add(new SqlParameter("@SL", SL));
            command.Parameters.Add(new SqlParameter("@GIa", Gia));
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            close();
            return command;
        }
        public SqlCommand Them_PNK(string MaNV,DateTime NgayNhap)
        {
            open();
            command = new SqlCommand("add_PNK", connection);
            command.Parameters.Add(new SqlParameter("@ma_NV", MaNV));
            command.Parameters.Add(new SqlParameter("@ngayNhap", NgayNhap));
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            close();
            return command;
        }
        public DataTable Xem_PNK(int MaPNK)
        {
            data = new DataTable();
            open();
            command = new SqlCommand("PNK", connection);
            command.Parameters.Add(new SqlParameter("@ma_PNK", MaPNK));
            command.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            close();
            return data;
        }
        public void loadCombobox(System.Windows.Forms.ComboBox tencombobox,string table,string ten)
        {
            DataTable data = new DataTable();
            string query = "select * from " + table;
            data = truyvanSQL(query);
            tencombobox.DataSource = data;
            tencombobox.DisplayMember = ten;    // cột mà combobox muốn thể hiện ra
        }
        public int GetMaPNK()
        {
            int maPNK = 0;
            DataTable data = new DataTable();
            string query = "select max(id_PhieuNhapKho) from PhieuNhapKho";
            data = truyvanSQL(query);
            maPNK = Convert.ToInt32(data.Rows[0][0].ToString());
            return maPNK;
        }
    }
}

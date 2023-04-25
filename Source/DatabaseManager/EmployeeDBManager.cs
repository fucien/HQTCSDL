using HQTCSDL_G6.DatabaseManager.DTOs;
using HQTCSDL_G6.DatabaseManager;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace HQTCSDL_G6.DatabaseManager
{
    public class EmployeeDBManager
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["nhanvien"].ConnectionString;

        public DataTable GetAccount()
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "select * from TaiKhoan where Loai in (N'NV', N'AD')"
                };
                using var adapter = new SqlDataAdapter(command);
                using var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}

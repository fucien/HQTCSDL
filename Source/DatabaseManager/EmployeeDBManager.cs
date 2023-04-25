using HQTCSDL_G6.DatabaseManager.DTOs;
using HQTCSDL_G6.DatabaseManager;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace HQTCSDL_G6.DatabaseManager
{
    public class EmployeeDBManager
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["nhanvien"].ConnectionString;

        public DataTable GetActiveHD()
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "select * from HopDong where HD_Status = 1"
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

        public DataTable GetInactiveHD()
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "select * from HopDong where HD_Status = 0"
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


        public void SendNotification(int hd)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "update HopDong set IsNotified = 1 where MaHD = @hd"
                };
                command.Parameters.AddWithValue("@hd", hd);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void AcceptHD(int hd)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "update HopDong set IsNotified = 2 where MaHD = @hd;" +
                                  "update HopDong set HD_Status = 1 where MaHD = @hd"
                };
                command.Parameters.AddWithValue("@hd", hd);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void RejectHD (int hd)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "delete from HopDong where MaHD = @num"
                };
                command.Parameters.AddWithValue("@num", hd);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
    
}

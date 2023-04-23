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
    public class AdminDBManager
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["admin"].ConnectionString;

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
                    CommandText = "Select * from TaiKhoan"
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
        public void AddAccount (string username, string password, string role, int isLocked)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "Insert into TaiKhoan values (@username, @password, @role, @isLocked)"
                };
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@role", role);
                command.Parameters.AddWithValue("@isLocked", isLocked);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void DeleteAccount (string username)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "Delete from TaiKhoan where TaiKhoan = @username"
                };
                command.Parameters.AddWithValue("@username", username);
                command.ExecuteNonQuery();
                 }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }   

        public void UpdateAccount (string username,string password, string role, int isLocked)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "Update TaiKhoan set password = @password, role = @role, isLocked = @isLocked where TaiKhoan = @username"
                };
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@role", role);
                command.Parameters.AddWithValue("@isLocked", isLocked);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public bool LockAccount (string username)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "Update TaiKhoan set Lock = 1 where TaiKhoan = @username"
                };
                command.Parameters.AddWithValue("@username", username);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool UnlockAccount(string username)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "Update TaiKhoan set Lock = 0 where TaiKhoan = @username"
                };
                command.Parameters.AddWithValue("@username", username);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
    }

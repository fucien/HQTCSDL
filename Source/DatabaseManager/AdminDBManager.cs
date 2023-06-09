﻿using HQTCSDL_G6.DatabaseManager.DTOs;
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

        public DataTable GetTable(string tableName)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "select * from " + tableName
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

        public void AddAccount(string username, string password, string role)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "Insert into TaiKhoan (TaiKhoan, Pass, Loai) values (@username, @password, @role)"
                };
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@role", role);
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
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
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }   

        public void UpdateAccount (string username,string password)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "Update TaiKhoan set Pass = @password where TaiKhoan = @username"
                };
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.ExecuteNonQuery();

                MessageBox.Show("Sửa thành công");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

      
        public bool LockAccount (string username, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "Admin_lock"
                };
                command.Parameters.AddWithValue("@tk", username);
                command.Parameters.AddWithValue("@delay", delay);
                command.ExecuteNonQuery();
                MessageBox.Show("Khóa thành công");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool LockAccount_Error(string username, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "Admin_lock_error"
                };
                command.Parameters.AddWithValue("@tk", username);
                command.Parameters.AddWithValue("@delay", delay);
                command.ExecuteNonQuery();
                MessageBox.Show("Khóa thành công");
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
                MessageBox.Show("Mở khóa thành công");
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

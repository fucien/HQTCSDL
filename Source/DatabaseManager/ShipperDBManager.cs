using HQTCSDL_G6.DatabaseManager.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HQTCSDL_G6.DatabaseManager
{
    public class ShipperDBManager
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["shipper"].ConnectionString;
        public bool AcceptOrderError(int orderID, int shipperID, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "NhanDH_ERROR"
                };
                command.Parameters.AddWithValue("@ma_dh", orderID);
                command.Parameters.AddWithValue("@ma_tx", shipperID);
                command.Parameters.AddWithValue("@delay", delay);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool AcceptOrder(int orderID, int shipperID, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "NhanDH"
                };
                command.Parameters.AddWithValue("@ma_dh", orderID);
                command.Parameters.AddWithValue("@ma_tx", shipperID);
                command.Parameters.AddWithValue("@delay", delay);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Statistics GetStatistics(int shipperID, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "GetThongKe"
                };
                command.Parameters.AddWithValue("@ma_tx", shipperID);
                command.Parameters.AddWithValue("@delay", delay);
                using var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var total = new TotalStatistics(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                    var shipping = new TotalStatistics(0, 0, 0);
                    var done = new TotalStatistics(0, 0, 0);
                    reader.NextResult();
                    reader.Read();
                    if (!reader.IsDBNull(2))
                        shipping = new TotalStatistics(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                    reader.NextResult();
                    reader.Read();
                    if (!reader.IsDBNull(2))
                        done = new TotalStatistics(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                    return new Statistics(total, shipping, done);
                }

                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Statistics GetStatisticsError(int shipperID, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "GetThongKe_ERROR"
                };
                command.Parameters.AddWithValue("@ma_tx", shipperID);
                command.Parameters.AddWithValue("@delay", delay);
                using var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var total = new TotalStatistics(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                    var shipping = new TotalStatistics(0, 0, 0);
                    var done = new TotalStatistics(0, 0, 0);
                    reader.NextResult();
                    reader.Read();
                    if (!reader.IsDBNull(2))
                        shipping = new TotalStatistics(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                    reader.NextResult();
                    reader.Read();
                    if (!reader.IsDBNull(2))
                        done = new TotalStatistics(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                    return new Statistics(total, shipping, done);
                }
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool UpdateOrder(int orderID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "UPDATE DonHang SET Status = N'Thành công' WHERE MaDH = @order_id"
                };
                command.Parameters.AddWithValue("@order_id", orderID);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public IEnumerable<Order> GetAvailableOrders()
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT dh.MaDH, dh.MaCN, dh.MaKH, dh.MaTX, dh.CachThanhToan, dh.DiaChi, dh.Status, dh.Gia, dh.PhiVanChuyen FROM DonHang dh WHERE dh.MaTX IS NULL AND dh.Status = N'Đang xử lý'"
                };
                using var reader = command.ExecuteReader();
                while (reader.Read())
                    yield return new Order(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), (reader[3] as int?).GetValueOrDefault(-1), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7), reader.GetInt32(8));
            }
            finally { }
        }

        public IEnumerable<Order> GetShippingOrders(int shipperID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT dh.MaDH, dh.MaCN, dh.MaKH, dh.MaTX, dh.CachThanhToan, dh.DiaChi, dh.Status, dh.Gia, dh.PhiVanChuyen FROM DonHang dh WHERE dh.MaTX = @shipper_id AND dh.Status = N'Đang giao'"
                };
                command.Parameters.AddWithValue("@shipper_id", shipperID);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                    yield return new Order(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), (reader[3] as int?).GetValueOrDefault(-1), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7), reader.GetInt32(8));
            }
            finally { }
        }
    }
}

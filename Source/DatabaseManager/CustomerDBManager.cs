using HQTCSDL_Group01.DatabaseManager.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HQTCSDL_Group01.DatabaseManager
{
    public class CustomerDBManager
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["customer"].ConnectionString;

        public IEnumerable<Order> GetOrders(int customerID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT dh.MaDH, dh.MaCN, dh.MaKH, dh.MaTX, dh.CachThanhToan, dh.DiaChi, dh.Status, dh.Gia, dh.PhiVanChuyen FROM DonHang dh WHERE dh.MaKH = @customer_id"
                };
                command.Parameters.AddWithValue("@customer_id", customerID);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    yield return new Order(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), (reader[3] as int?).GetValueOrDefault(-1), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7), reader.GetInt32(8));
                }
            }
            finally { }
        }

        public Statistics GetStatistics(int customerID, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "khach_hang_thong_ke"
                };
                command.Parameters.AddWithValue("@ma_kh", customerID);
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

        public Statistics GetStatisticsError(int customerID, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "khach_hang_thong_ke_ERROR"
                };
                command.Parameters.AddWithValue("@ma_kh", customerID);
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

        public IEnumerable<int> GetProductIDs(int branchID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT sp.MaSP FROM SanPham sp JOIN ChiNhanh_SanPham cnsp ON sp.MaSP = cnsp.MaSP WHERE cnsp.MaCN = @branch_id"
                };
                command.Parameters.AddWithValue("@branch_id", branchID);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                    yield return reader.GetInt32(0);
            }
            finally { };
        }


        public bool CreateOrder(Order order, IEnumerable<ProductAmount> products, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "tao_don_dat_hang"
                };
                command.Parameters.AddWithValue("@ma_cn", order.BranchID);
                command.Parameters.AddWithValue("@ma_kh", order.CustomerID);
                command.Parameters.AddWithValue("@hinh_thuc_tt", order.ShippingMethod);
                command.Parameters.AddWithValue("@dia_chi_gh", order.Address);
                command.Parameters.AddWithValue("@phi_vc", order.ShippingPrice);
                command.Parameters.AddWithValue("@delay", delay);

                DataTable dt = new DataTable();
                dt.Columns.Add("MaSP", typeof(int));
                dt.Columns.Add("SO_LUONG", typeof(int));
                foreach (var product in products)
                    dt.Rows.Add(product.Product.ID, product.Amount);
                SqlParameter param = new SqlParameter("@san_pham_so_luong", SqlDbType.Structured)
                {
                    TypeName = "dbo.SAN_PHAM_SO_LUONG",
                    Value = dt
                };
                command.Parameters.Add(param);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool CreateOrderError(Order order, IEnumerable<ProductAmount> products, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "tao_don_dat_hang_ERROR"
                };
                command.Parameters.AddWithValue("@ma_cn", order.BranchID);
                command.Parameters.AddWithValue("@ma_kh", order.CustomerID);
                command.Parameters.AddWithValue("@hinh_thuc_tt", order.ShippingMethod);
                command.Parameters.AddWithValue("@dia_chi_gh", order.Address);
                command.Parameters.AddWithValue("@phi_vc", order.ShippingPrice);
                command.Parameters.AddWithValue("@delay", delay);

                DataTable dt = new DataTable();
                dt.Columns.Add("MaSP", typeof(int));
                dt.Columns.Add("SO_LUONG", typeof(int));
                foreach (var product in products)
                    dt.Rows.Add(product.Product.ID, product.Amount);
                SqlParameter param = new SqlParameter("@san_pham_so_luong", SqlDbType.Structured)
                {
                    TypeName = "dbo.SAN_PHAM_SO_LUONG",
                    Value = dt
                };
                command.Parameters.Add(param);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool CancelOrderError(int orderID, TimeSpan delay)
         {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "huy_don_dat_hang_ERROR"
                };
                command.Parameters.AddWithValue("@ma_dh", orderID);
                command.Parameters.AddWithValue("@delay", delay);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool CancelOrder(int orderID, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "huy_don_dat_hang"
                };
                command.Parameters.AddWithValue("@ma_dh", orderID);
                command.Parameters.AddWithValue("@delay", delay);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}

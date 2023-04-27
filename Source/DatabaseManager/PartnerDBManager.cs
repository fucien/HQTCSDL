using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using HQTCSDL_G6.DatabaseManager.DTOs;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace HQTCSDL_G6.DatabaseManager
{
    class PartnerDBManager
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["partner"].ConnectionString;

        public IEnumerable<int> GetPartnerIDs()
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT dt.MaDT FROM DoiTac dt"
                };
                using var reader = command.ExecuteReader();
                while (reader.Read())
                    yield return reader.GetInt32(0);
            }
            finally { };
        }

        public string GetPartnerName(int partnerID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT dt.TenDT FROM DoiTac dt WHERE dt.MaDT = @partner_id"
                };

                command.Parameters.AddWithValue("@partner_id", partnerID);

                using var reader = command.ExecuteReader();
                if (reader.Read())
                    return reader.GetString(0);
                return String.Empty;
            }
            catch (Exception e)
            {
                return String.Empty;
            }
        }

        public IEnumerable<int> GetBranchIDs(int partnerID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    //CommandText = "chi_nhanh_chua_ki_hd"
                    CommandText = "SELECT cn.MaCN FROM ChiNhanh cn WHERE cn.MaDT = @ma_dt"
                };
                
                command.Parameters.AddWithValue("@ma_dt", partnerID);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                    yield return reader.GetInt32(0);
            }
            finally { };
        }

        public string GetBranchAddress(int branchID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT cn.DiaChi FROM ChiNhanh cn WHERE cn.MaCN = @branch_id"
                };

                command.Parameters.AddWithValue("@branch_id", branchID);

                using var reader = command.ExecuteReader();
                if (reader.Read())
                    return reader.GetString(0);
                return String.Empty;
            }
            catch (Exception e)
            {
                return String.Empty;
            }
        }

     

        public bool ExtendContractError(int contractID, int addDays, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "GiaHanHD_ERROR"
                };
                command.Parameters.AddWithValue("@ma_hd", contractID);
                command.Parameters.AddWithValue("@so_ngay_them", addDays);
                command.Parameters.AddWithValue("@delay", delay);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool ExtendContract(int contractID, int addDays, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "GiaHanHD"
                };
                command.Parameters.AddWithValue("@ma_hd", contractID);
                command.Parameters.AddWithValue("@so_ngay_them", addDays);
                command.Parameters.AddWithValue("@delay", delay);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public IEnumerable<int> GetContractIDs(int partnerID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT hd.MaHD FROM HopDong hd WHERE hd.MaDT = @partner_id"
                };
                command.Parameters.AddWithValue("@partner_id", partnerID);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                    yield return reader.GetInt32(0);
            }
            finally { }
        }

        public IEnumerable<Contract> GetContracts(int partnerID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT hd.MaHD, hd.MaSoThue, hd.NguoiDaiDien, hd.NgayBatDau, hd.NgayKetThuc , hd.isNotified FROM HopDong hd WHERE hd.MaDT = @partner_id"
                };
                command.Parameters.AddWithValue("@partner_id", partnerID);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetInt32(5) == 1)
                    {
                        MessageBox.Show("Thông báo từ hệ thống: Hợp đồng " + reader.GetInt32(0) + " sắp hết hạn.");
                    }
                    if (reader.GetInt32(5) == 2)
                    {
                        MessageBox.Show("Thông báo từ hệ thống: Hợp đồng " + reader.GetInt32(0) + " đã được duyệt.");
                    }
                    yield return new Contract(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetDateTime(4));
                }
            }
            finally { }
        }

        public IEnumerable<Branch> GetBranches(int contractID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT cn.MaCN, cn.Ten, cn.DiaChi FROM ChiNhanh cn WHERE cn.MaHD = @contract_id"
                };
                command.Parameters.AddWithValue("@contract_id", contractID);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                    yield return new Branch(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
            }
            finally { }
        }

        public int GetContractDuration(int contractID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT DATEDIFF(DAY, hd.NgayBatDau, hd.NgayKetThuc) FROM HopDong hd WHERE hd.MaHD = @ma_hd"
                };
                command.Parameters.AddWithValue("@ma_hd", contractID);
                return (command.ExecuteScalar() as int?).GetValueOrDefault(-1);
            }
            catch (Exception e)
            {
                return -1;
            }
        }


        public bool AddProduct(Product product, int partnerID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "INSERT INTO SanPham(MaDT, Ten, Description, GIA_SP) VALUES (@ma_dt, @ten_sp, @mo_ta, @gia)"
                };
                command.Parameters.AddWithValue("@ma_dt", partnerID);
                command.Parameters.AddWithValue("@ten_sp", product.Name);
                command.Parameters.AddWithValue("@mo_ta", product.Description);
                command.Parameters.AddWithValue("@gia", product.Price);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public IEnumerable<int> GetProductIDs(int partnerID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    //CommandText = "SELECT sp.MaSP, sp.Ten, sp.Description, sp.GIA_SP FROM SanPham sp WHERE sp.MaDT = @partner_id"
                    CommandText = "SELECT sp.MaSP FROM SanPham sp WHERE sp.MaDT = @partner_id"
                };
                command.Parameters.AddWithValue("@partner_id", partnerID);

                using var reader = command.ExecuteReader();
                while (reader.Read())
                    yield return reader.GetInt32(0);
            }
            finally { }
        }

        public Product GetProduct(int productID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                var transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT TOP 1 sp.MaSP, sp.Ten, sp.Description, sp.GIA_SP FROM SanPham sp WHERE sp.MaSP = @ma_sp",
                    Transaction = transaction
                };
                command.Parameters.AddWithValue("@ma_sp", productID);

                using var reader = command.ExecuteReader();
                if (reader.Read())
                    return new Product(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Product GetProductError(int productID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT TOP 1 sp.MaSP, sp.Ten, sp.Description, sp.GIA_SP FROM SanPham sp WHERE sp.MaSP = @ma_sp"
                };
                command.Parameters.AddWithValue("@ma_sp", productID);

                using var reader = command.ExecuteReader();
                if (reader.Read())
                    return new Product(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool DeleteProduct(int productID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "DELETE FROM SanPham WHERE MaSP = @ma_sp"
                };
                command.Parameters.AddWithValue("@ma_sp", productID);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool UpdateProduct(Product update, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "CapNhatSP"
                };
                command.Parameters.AddWithValue("@ma_sp", update.ID);
                command.Parameters.AddWithValue("@ten_sp", update.Name);
                command.Parameters.AddWithValue("@mo_ta", update.Description);
                command.Parameters.AddWithValue("@gia", update.Price);
                command.Parameters.AddWithValue("@delay", delay);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool UpdateProductError(Product update)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "CapNhatSP_ERROR"
                };
                command.Parameters.AddWithValue("@ma_sp", update.ID);
                command.Parameters.AddWithValue("@ten_sp", update.Name);
                command.Parameters.AddWithValue("@mo_ta", update.Description);
                command.Parameters.AddWithValue("@gia", update.Price);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public int GetProductAmount(int productID, int branchID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT cnsp.SoLuong_CS FROM ChiNhanh_SanPham cnsp WHERE cnsp.MaSP = @ma_sp AND cnsp.MaCN = @ma_cn"
                };
                command.Parameters.AddWithValue("@ma_sp", productID);
                command.Parameters.AddWithValue("@ma_cn", branchID);

                using var reader = command.ExecuteReader();
                if (reader.Read())
                    return reader.GetInt32(0);
                return 0;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public bool UpdateProductAmountError(int productID, int branchID, int different, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "CapNhatSoLuongSP_ERROR"
                };
                command.Parameters.AddWithValue("@ma_sp", productID);
                command.Parameters.AddWithValue("@ma_cn", branchID);
                command.Parameters.AddWithValue("@chenh_lech", different);
                command.Parameters.AddWithValue("@delay", delay);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool UpdateProductAmount(int productID, int branchID, int different, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "CapNhatSoLuongSP"
                };
                command.Parameters.AddWithValue("@ma_sp", productID);
                command.Parameters.AddWithValue("@ma_cn", branchID);
                command.Parameters.AddWithValue("@chenh_lech", different);
                command.Parameters.AddWithValue("@delay", delay);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public IEnumerable<Order> GetOrders(int partnerID)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT dh.MaDH, dh.MaCN, dh.MaKH, dh.MaTX, dh.CachThanhToan, dh.DiaChi, dh.Status, dh.Gia, dh.PhiVanChuyen FROM DonHang dh JOIN ChiNhanh cn ON dh.MaCN = cn.MaCN WHERE cn.MaDT = @partner_id"
                };
                command.Parameters.AddWithValue("@partner_id", partnerID);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                    yield return new Order(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), (reader[3] as int?).GetValueOrDefault(-1), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7), reader.GetInt32(8));
            }
            finally { }
        }

        public IEnumerable<ProductAmount> GetProductAmountFromOrder(int orderID)
        {
            
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT sp.MaSP, sp.Ten, dhsp.SoLuong_SD, dhsp.Gia_SD FROM DonHang_SanPham dhsp JOIN SanPham sp ON dhsp.MaSP = sp.MaSP WHERE dhsp.MaDH = @order_id"
                };
                command.Parameters.AddWithValue("@order_id", orderID);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                    yield return new ProductAmount(new Product(reader.GetInt32(0), reader.GetString(1), "", reader.GetInt32(3)), reader.GetInt32(2));
            }
            finally { }
        }

        public PartnerStatistics GetStatistics(int partnerID, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "DoiTacThongKe"
                };
                command.Parameters.AddWithValue("@ma_dt", partnerID);
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

                    reader.NextResult();
                    reader.Read();
                    var maxAmount = new ProductAmount(new Product(reader.GetInt32(1), reader.GetString(2), "", 0), reader.GetInt32(3));
                    return new PartnerStatistics(total, shipping, done, maxAmount);
                }


                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }


        public PartnerStatistics GetStatisticsError(int partnerID, TimeSpan delay)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "DoiTacThongKe_ERROR"
                };
                command.Parameters.AddWithValue("@ma_dt", partnerID);
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

                    reader.NextResult();
                    reader.Read();
                    var maxAmount = new ProductAmount(new Product(reader.GetInt32(1), reader.GetString(2), "", 0), reader.GetInt32(3));
                    return new PartnerStatistics(total, shipping, done, maxAmount);
                }

                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }


}

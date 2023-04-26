using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HQTCSDL_G6.DatabaseManager
{
    class DBManager
    {
        //Use singleton
        private static readonly Lazy<DBManager> lazySingleton = new Lazy<DBManager>();

        public static DBManager Init => lazySingleton.Value;

        public AdminDBManager Admin { get; } = new AdminDBManager();

        public EmployeeDBManager Employee { get; } = new EmployeeDBManager();

        public PartnerDBManager Partner { get; } = new PartnerDBManager();

        public CustomerDBManager Customer { get; } = new CustomerDBManager();

        public ShipperDBManager Shipper { get; } = new ShipperDBManager();

        public void SignupKH(string account, string password, string name, string address, string sdt, string email)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["admin"].ConnectionString))
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = ("Insert into TaiKhoan (TaiKhoan , pass) values (@account, @password);"
                        + "Insert into KhachHang (TaiKhoan, HoTen, DiaChi, SDT, Email) values (@account, @name, @address, @sdt, @email");
                    command.Parameters.AddWithValue("@account", account);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@sdt", sdt);
                    command.Parameters.AddWithValue("@email", email);
                    command.ExecuteNonQuery();

                    connection.Open();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SignupDT(string account, string password, string partner, string name, string city, string dis, string address, string amount, string type, string sdt, string email)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["admin"].ConnectionString))
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = ("Insert into TaiKhoan (TaiKhoan , pass) values (@account, @password);"
                        + "Insert into DoiTac (TaiKhoan, TenDT, DaiDien, ThanhPho, Quan, DiaChi, SoChiNhanh, LoaiAmThuc, Sdt, Email) values (@account,@password,@partner,@name,@city,@dis,@address,@amount,@type,@sdt,@email);");
                    command.Parameters.AddWithValue("@account", account);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@partner", partner);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@dis", dis);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@amount", amount);
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@sdt", sdt);
                    command.Parameters.AddWithValue("@email", email);
                    


                    connection.Open();
                    command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SignupTX(string account, string password, string name, string cmnd, string sdt, string bienso, string area, string email, string bank)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["admin"].ConnectionString))
                { 
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = ("Insert into TaiKhoan (TaiKhoan , pass) values (@account, @password);"
                        + "Insert into TaiXe (TaiKhoan, HoTen, CMND, SDT, BienSo, KhuVuc, Email, Bank) values (@account,@password,@name,@cmnd,@sdt,@bienso,@area,@email,@bank);");
                    command.Parameters.AddWithValue("@account", account);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@cmnd", cmnd);
                    command.Parameters.AddWithValue("@sdt", sdt);
                    command.Parameters.AddWithValue("@bienso", bienso);
                    command.Parameters.AddWithValue("@area", area);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@bank", bank);
                    connection.Open();
                    command.ExecuteNonQuery();

                }
            }
            catch (Exception e)
            { Console.WriteLine(e.Message); }
        }


        public AccountTypeWithID Login(string account, string password)
        {
            try
            {

                using(SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["login"].ConnectionString))
                {
                    
                    
                    /*var command = new SqlCommand()
                    {
                        Connection = connection,
                        CommandType = System.Data.CommandType.StoredProcedure,
                        CommandText = "dbo.dang_nhap"
                    };*/
                    SqlCommand command = new SqlCommand("dang_nhap", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@tai_khoan", account);
                    command.Parameters.AddWithValue("@mat_khau", password);
                    connection.Open();
                    
                    
                    try
                    {

                        var reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            MessageBox.Show(reader.GetString(0));
                            return new AccountTypeWithID(reader.GetString(0), reader.GetInt32(1),reader.GetString(2));
                        }
                        return null;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        return null;
                    }
                    /*var reader = command.ExecuteReader();
                    reader.Close();
                    command.Dispose();*/
                    
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }

    public class AccountTypeWithID
    {
        public AccountTypeWithID(string type, int id, string name)
        {
            Type = type;
            ID = id;
            Name = name;
        }
        public string Type { get; }
        public int ID { get; }
        public string Name { get; }
    }

}

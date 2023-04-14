using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HQTCSDL_Group01.DatabaseManager
{
    class DBManager
    {
        //Use singleton
        private static readonly Lazy<DBManager> lazySingleton = new Lazy<DBManager>();

        public static DBManager Init => lazySingleton.Value;

        public PartnerDBManager Partner { get; } = new PartnerDBManager();

        public CustomerDBManager Customer { get; } = new CustomerDBManager();

        public ShipperDBManager Shipper { get; } = new ShipperDBManager();

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
                    MessageBox.Show("Connection Open  !");
                    
                    try
                    {
                        var reader = command.ExecuteReader();


                        if (reader.Read())
                        {
                            MessageBox.Show(reader.GetString(0));
                            return new AccountTypeWithID(reader.GetString(0), reader.GetInt32(1));
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
        public AccountTypeWithID(string type, int id)
        {
            Type = type;
            ID = id;
        }
        public string Type { get; }
        public int ID { get; }
    }

}

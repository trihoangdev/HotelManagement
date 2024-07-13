using System;
using System.Data.SqlClient;

namespace HotelManagement.ClassFolder
{
    public sealed class DatabaseConnection
    {
        private static readonly Lazy<DatabaseConnection> lazyInstance =
            new Lazy<DatabaseConnection>(() => new DatabaseConnection());

        private SqlConnection connection;

        private DatabaseConnection()
        {
            // Chuỗi kết nối đến SQL Server
            string connectionString = "Data Source=HOANGMINHTRI\\SQLEXPRESS;Initial Catalog=HotelManagement;Integrated Security=True;TrustServerCertificate=true";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public static DatabaseConnection Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        public SqlConnection Connection
        {
            get
            {
                return connection;
            }
        }
    }
}

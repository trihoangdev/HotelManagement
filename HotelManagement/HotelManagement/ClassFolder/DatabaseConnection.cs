using System;
using System.Data.SqlClient;

namespace HotelManagement.ClassFolder
{
    public static class DatabaseConnection
    {
        private static SqlConnection connection;
        private static readonly string connString = "Data Source=HOANGMINHTRI\\SQLEXPRESS;Initial Catalog=HotelManagement;Integrated Security=True;TrustServerCertificate=true";

        public static SqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new SqlConnection(connString);
                }
                return connection;
            }
        }

        public static void OpenConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(connString); // Khởi tạo db nếu chưa có
            }

            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}

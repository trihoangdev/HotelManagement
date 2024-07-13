
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagement.ClassFolder
{
    public static class DataProvider
    {
        private static readonly DatabaseConnection dbConnection;
        public static List<Login> Logins = new List<Login>();
        public static List<Employee> Employees = new List<Employee>();
        public static List<Customer> Customers = new List<Customer>();
        static DataProvider()
        {
            dbConnection = DatabaseConnection.Instance;
        }

        public static void GetAllLogins()
        {
            using (SqlCommand command = new SqlCommand("SELECT * from login", DatabaseConnection.Instance.Connection))
            {
                try
                {
                    // Kiểm tra trạng thái kết nối trước khi mở
                    if (DatabaseConnection.Instance.Connection.State == System.Data.ConnectionState.Closed)
                    {
                        DatabaseConnection.Instance.Connection.Open();
                    }
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Xóa danh sách cũ trước khi tải mới
                        Logins.Clear();
                        while (reader.Read())
                        {
                            string username = reader["Username"].ToString();
                            string password = reader["Password"].ToString();
                            string role = reader["Role"].ToString();

                            Login login = new Login(username, password, role);
                            Logins.Add(login);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý các lỗi nếu có
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
                finally
                {
                    // Đảm bảo rằng kết nối được đóng
                    if (DatabaseConnection.Instance.Connection.State == System.Data.ConnectionState.Open)
                    {
                        DatabaseConnection.Instance.Connection.Close();
                    }
                }
            }
        }

        public static void GettAllEmployee()
        {
            using (SqlCommand command = new SqlCommand("SELECT * from employees", DatabaseConnection.Instance.Connection))
            {
                try
                {
                    // Kiểm tra trạng thái kết nối trước khi mở
                    if (DatabaseConnection.Instance.Connection.State == System.Data.ConnectionState.Closed)
                    {
                        DatabaseConnection.Instance.Connection.Open();
                    }
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Xóa danh sách cũ trước khi tải mới
                        Employees.Clear();
                        while (reader.Read())
                        {
                            string id = reader["EmployeeID"].ToString();
                            string fullname = reader["FullName"].ToString();
                            DateTime birthDate = (DateTime)reader["DateOfBirth"];
                            string gender = reader["Gender"].ToString();
                            string address = reader["Address"].ToString();
                            string phone = reader["PhoneNumber"].ToString();
                            string email = reader["Email"].ToString();
                            string role = reader["Role"].ToString();
                            string pos = reader["Position"].ToString();
                            DateTime dateHired = (DateTime)reader["DateHired"];
                            string status = reader["Status"].ToString();
                            string notes = reader["Notes"].ToString();

                            Employee employee = new Employee(fullname, birthDate, gender, address, phone, email, id, role, pos, dateHired, status, notes);

                            Employees.Add(employee);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý các lỗi nếu có
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
                finally
                {
                    // Đảm bảo rằng kết nối được đóng
                    if (DatabaseConnection.Instance.Connection.State == System.Data.ConnectionState.Open)
                    {
                        DatabaseConnection.Instance.Connection.Close();
                    }
                }
            }
        }

        public static void GetAllCustomer()
        {
            using (SqlCommand command = new SqlCommand("SELECT * from customers", DatabaseConnection.Instance.Connection))
            {
                try
                {
                    // Kiểm tra trạng thái kết nối trước khi mở
                    if (DatabaseConnection.Instance.Connection.State == System.Data.ConnectionState.Closed)
                    {
                        DatabaseConnection.Instance.Connection.Open();
                    }
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Xóa danh sách cũ trước khi tải mới
                        Customers.Clear();
                        while (reader.Read())
                        {
                            string id = reader["CustomerID"].ToString();
                            string fullname = reader["FullName"].ToString();
                            DateTime birthDate = (DateTime)reader["DateOfBirth"];
                            string gender = reader["Gender"].ToString();
                            string address = reader["Address"].ToString();
                            string phone = reader["PhoneNumber"].ToString();
                            string email = reader["Email"].ToString();
                            DateTime dateJoined = (DateTime)reader["DateJoined"];
                            string notes = reader["Notes"].ToString();

                            Customer customer = new Customer(fullname, dateJoined, gender, address, phone, email, id, dateJoined, notes);

                            Customers.Add(customer);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý các lỗi nếu có
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
                finally
                {
                    // Đảm bảo rằng kết nối được đóng
                    if (DatabaseConnection.Instance.Connection.State == System.Data.ConnectionState.Open)
                    {
                        DatabaseConnection.Instance.Connection.Close();
                    }
                }
            }
        }

    }
}

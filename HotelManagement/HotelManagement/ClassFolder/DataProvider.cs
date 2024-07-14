
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace HotelManagement.ClassFolder
{
    public static class DataProvider
    {
        private static readonly DatabaseConnection dbConnection;
        public static List<Login> Logins = new List<Login>();
        public static List<Employee> Employees = new List<Employee>();
        public static List<Customer> Customers = new List<Customer>();
        public static List<Room> Rooms = new List<Room>();
        public static List<Room> EmptyRooms = new List<Room>();
        public static List<Room> RoomFilter = new List<Room>();
        public static List<RoomBooking> RoomBookings = new List<RoomBooking>();
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

        public static void GetAllRooms()
        {
            using (SqlCommand command = new SqlCommand("SELECT * from Rooms", DatabaseConnection.Instance.Connection))
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
                        Rooms.Clear();
                        while (reader.Read())
                        {
                            string id = reader["RoomID"].ToString();
                            string type = reader["RoomType"].ToString();
                            int capacity = (int)reader["Capacity"];
                            double price = Convert.ToDouble(reader["Price"]);
                            string status = reader["Status"].ToString();
                            string des = reader["Description"].ToString();

                            Room r = new Room(id, type, capacity, price, status, des);

                            Rooms.Add(r);
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

        public static void GetAllEmptyRooms()
        {
            using (SqlCommand command = new SqlCommand("SELECT * from Rooms WHERE Status = N'Trống'", DatabaseConnection.Instance.Connection))
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
                        Rooms.Clear();
                        while (reader.Read())
                        {
                            string id = reader["RoomID"].ToString();
                            string type = reader["RoomType"].ToString();
                            int capacity = (int)reader["Capacity"];
                            double price = Convert.ToDouble(reader["Price"]);
                            string status = reader["Status"].ToString();
                            string des = reader["Description"].ToString();

                            Room r = new Room(id, type, capacity, price, status, des);

                            EmptyRooms.Add(r);
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

        public static void InsertRoomToDB(string id, string cap, string type, double price, string des)
        {
            using (SqlCommand command = new SqlCommand(
                "INSERT INTO Rooms (RoomID, Capacity, RoomType, Price, Description, Status) VALUES (@RoomID, @Capacity, @RoomType, @Price, @Description, @Status)",
                DatabaseConnection.Instance.Connection))
            {
                command.Parameters.AddWithValue("@RoomID", id);
                command.Parameters.AddWithValue("@Capacity", cap);
                command.Parameters.AddWithValue("@RoomType", type);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Status", "Trống");
                command.Parameters.AddWithValue("@Description", des);

                try
                {
                    DatabaseConnection.Instance.Connection.Open(); // Mở kết nối đến cơ sở dữ liệu
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Thêm phòng thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    DatabaseConnection.Instance.Connection.Close(); // Đóng kết nối sau khi hoàn thành
                }
            }
        }

        //Lưu thông tin Customer vào CSDL
        public static void InsertCustomerToDB(string id, string name,DateTime birthDate, string gender, string address, string phone, string email, DateTime dateJoined, string note)
        {
            using (SqlCommand command = new SqlCommand(
                "INSERT INTO Customers (CustomerID, FullName, DateOfBirth, Gender, Address, PhoneNumber, Email, DateJoined, Notes) " +
                "VALUES (@CustomerID, @FullName, @DateOfBirth, @Gender, @Address, @PhoneNumber, @Email, @DateJoined, @Notes)",
                DatabaseConnection.Instance.Connection))
            {
                command.Parameters.AddWithValue("@CustomerID", id);
                command.Parameters.AddWithValue("@FullName", name);
                command.Parameters.AddWithValue("@DateOfBirth", birthDate);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@PhoneNumber", phone);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@DateJoined", dateJoined);
                command.Parameters.AddWithValue("@Notes", note);

                try
                {
                    DatabaseConnection.Instance.Connection.Open(); // Mở kết nối đến cơ sở dữ liệu
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Thêm khách hàng thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    DatabaseConnection.Instance.Connection.Close(); // Đóng kết nối sau khi hoàn thành
                }
            }
        }

        public static void UpdateRoom(string id, string cap, string type, double price, string des)
        {
            using (SqlCommand command = new SqlCommand(
                "UPDATE Rooms " +
                   "SET Capacity = @Capacity, RoomType = @RoomType, Price = @Price, Description = @Description " +
                   "WHERE RoomId = @RoomId",
                DatabaseConnection.Instance.Connection))
            {
                command.Parameters.AddWithValue("@RoomID", id);
                command.Parameters.AddWithValue("@Capacity", cap);
                command.Parameters.AddWithValue("@RoomType", type);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Description", des);

                try
                {
                    DatabaseConnection.Instance.Connection.Open(); // Mở kết nối đến cơ sở dữ liệu
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật phòng thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    DatabaseConnection.Instance.Connection.Close(); // Đóng kết nối sau khi hoàn thành
                }
            }
        }

        public static void FillDataGridView(Guna2DataGridView dtgv, string tableName)
        {
            try
            {
                string connectionString = "Data Source=HOANGMINHTRI\\SQLEXPRESS;Initial Catalog=HotelManagement;Integrated Security=True;TrustServerCertificate=true";
                string selectQuery = $"SELECT * FROM {tableName}";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    dtgv.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi điền dữ liệu vào DataGridView: " + ex.Message);
            }
        }
        public static void FillDataGridViewBooking(Guna2DataGridView dtgv, List<Room> rooms)
        {
            //xóa các dòng trong bảng
            dtgv.Rows.Clear();

            //điền dữ liệu vào bảng
            foreach (Room room in rooms)
            {
                dtgv.Rows.Add(room.Id, room.Type, room.Price, "Thêm");
            }
        }

        public static void RemoveRoom(string id)
        {
            using (SqlCommand command = new SqlCommand(
               "DELETE Rooms WHERE RoomId = @RoomId",
               DatabaseConnection.Instance.Connection))
            {
                command.Parameters.AddWithValue("@RoomID", id);
                try
                {
                    DatabaseConnection.Instance.Connection.Open(); // Mở kết nối đến cơ sở dữ liệu
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Xóa phòng thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    DatabaseConnection.Instance.Connection.Close(); // Đóng kết nối sau khi hoàn thành
                }
            }
        }
        public static List<Room> FindEmptyRoomByCapacity(string capacity)
        {
            if (RoomFilter.Count == 0)
            {
                if (capacity == "Phòng đơn")
                {
                    foreach (var room in EmptyRooms)
                        if (room.Capacity <= 2)
                            RoomFilter.Add(room);
                }
                else
                {
                    foreach (var room in EmptyRooms)
                        if (room.Capacity > 2)
                            RoomFilter.Add(room);
                }
                return RoomFilter;
            }
            else
            {
                //đã có ít nhất 1 phần tử thì tự filter trong nó
                var filter2 = new List<Room>();
                if (capacity == "Phòng đơn")
                {
                    foreach (var room in RoomFilter)
                        if (room.Capacity <= 2)
                            filter2.Add(room);
                }
                else
                {
                    foreach (var room in RoomFilter)
                        if (room.Capacity > 2)
                            filter2.Add(room);
                }
                RoomFilter = filter2; //lọc hoàn tất
                return RoomFilter;
            }
        }
        public static List<Room> FindRoomByCapacity(string capacity)
        {
            if (RoomFilter.Count == 0)
            {
                if (capacity == "Phòng đơn")
                {
                    foreach (var room in Rooms)
                        if (room.Capacity <= 2)
                            RoomFilter.Add(room);
                }
                else
                {
                    foreach (var room in Rooms)
                        if (room.Capacity > 2)
                            RoomFilter.Add(room);
                }
                return RoomFilter;
            }
            else
            {
                //đã có ít nhất 1 phần tử thì tự filter trong nó
                var filter2 = new List<Room>();
                if (capacity == "Phòng đơn")
                {
                    foreach (var room in RoomFilter)
                        if (room.Capacity <= 2)
                            filter2.Add(room);
                }
                else
                {
                    foreach (var room in RoomFilter)
                        if (room.Capacity > 2)
                            filter2.Add(room);
                }
                RoomFilter = filter2; //lọc hoàn tất
                return RoomFilter;
            }
        }

        public static List<Room> FindEmptyRoomByType(string type)
        {
            if (RoomFilter.Count == 0)
            {
                foreach (var room in EmptyRooms)
                    if (room.Type == type)
                        RoomFilter.Add(room);
                return RoomFilter;
            }
            else
            {
                //đã có ít nhất 1 phần tử thì tự filter trong nó
                var filter2 = new List<Room>();

                foreach (var room in RoomFilter)
                    if (room.Type == type)
                        filter2.Add(room);
                RoomFilter = filter2;
                return RoomFilter;
            }
        }

        public static List<Room> FindRoomByType(string type)
        {
            if (RoomFilter.Count == 0)
            {
                foreach (var room in Rooms)
                    if (room.Type == type)
                        RoomFilter.Add(room);
                return RoomFilter;
            }
            else
            {
                //đã có ít nhất 1 phần tử thì tự filter trong nó
                var filter2 = new List<Room>();

                foreach (var room in RoomFilter)
                    if (room.Type == type)
                        filter2.Add(room);
                RoomFilter = filter2;
                return RoomFilter;
            }
        }

        public static void ClearDataGridView(Guna2DataGridView dtgvBookingSelectedRoom)
        {
            // Xóa tất cả các dòng trong DataGridView
            dtgvBookingSelectedRoom.Rows.Clear();
        }

        public static Room FindRoomById(string id)
        {
            foreach (var room in Rooms)
                if (room.Id == id)
                    return room;
            return null;
        }

        //Lưu thông tin book phòng vào csdl đồng thời cập nhật trạng thái phòng
        public static void SaveBookingRoom(RoomBooking roomBooking)
        {
            //Lưu thông tin vào CSDL
            using (SqlCommand command = new SqlCommand(
              "INSERT INTO RoomBookings (CustomerID, RoomID, CheckInDate, CheckOutDate, NumberOfGuests,TotalPrice,BookingStatus,Notes)" +
              " VALUES ( @CustomerID, @RoomID, @CheckInDate, @CheckOutDate, @NumberOfGuests, @TotalPrice, @BookingStatus, @Notes)",
              DatabaseConnection.Instance.Connection))
            {
                command.Parameters.AddWithValue("@RoomID", roomBooking.RoomId);
                command.Parameters.AddWithValue("@CustomerID", roomBooking.CustomerId);
                command.Parameters.AddWithValue("@CheckInDate", roomBooking.CheckInDate);
                command.Parameters.AddWithValue("@CheckOutDate", roomBooking.CheckOutDate);
                command.Parameters.AddWithValue("@NumberOfGuests", roomBooking.NumberOfGuests);
                command.Parameters.AddWithValue("@TotalPrice", roomBooking.TotalPrice);
                command.Parameters.AddWithValue("@BookingStatus", roomBooking.BookingStatus);
                command.Parameters.AddWithValue("@Notes", roomBooking.Notes);
                try
                {
                    DatabaseConnection.Instance.Connection.Open(); // Mở kết nối đến cơ sở dữ liệu
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Thêm dữ liệu đặt phòng thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    DatabaseConnection.Instance.Connection.Close(); // Đóng kết nối sau khi hoàn thành
                }
            }

            //Cập nhật trạng thái phòng
            using (SqlCommand command = new SqlCommand("" +
                "Update Rooms Set Status = N'Đã đặt' Where RoomID = @RoomID",
                DatabaseConnection.Instance.Connection))
            {
                command.Parameters.AddWithValue("@RoomID", roomBooking.RoomId);
                try
                {
                    DatabaseConnection.Instance.Connection.Open(); // Mở kết nối đến cơ sở dữ liệu
                    int rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    DatabaseConnection.Instance.Connection.Close(); // Đóng kết nối sau khi hoàn thành
                }
            }


        }

        
    }
}

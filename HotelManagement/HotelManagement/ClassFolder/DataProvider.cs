
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
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
        public static List<Invoice> Invoices = new List<Invoice>();
        public static List<Invoice> InvoiceFilter = new List<Invoice>();
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
                    if (DatabaseConnection.Instance.Connection.State == ConnectionState.Closed)
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

                            Customer customer = new Customer(fullname, birthDate, gender, address, phone, email, id, dateJoined, notes);

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
                    if (DatabaseConnection.Instance.Connection.State == ConnectionState.Open)
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

        public static void GetAllRoomBooking()
        {
            using (SqlCommand command = new SqlCommand("SELECT * from RoomBookings", DatabaseConnection.Instance.Connection))
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
                            int id = (int)reader["BookingID"];
                            string customerID = reader["CustomerID"].ToString();
                            string roomId = reader["RoomId"].ToString();
                            DateTime checkInDate = (DateTime)reader["CheckInDate"];
                            DateTime checkOutDate = (DateTime)reader["CheckOutDate"];
                            int numberOfGuests = (int)reader["NumberOfGuests"];
                            double totalPrice = Convert.ToDouble(reader["TotalPrice"]);
                            string bookingStatus = reader["BookingStatus"].ToString();
                            string notes = reader["Notes"].ToString();

                            RoomBooking roomBooking = new RoomBooking(id, customerID, roomId, checkInDate, checkOutDate, numberOfGuests, totalPrice, bookingStatus, notes);

                            RoomBookings.Add(roomBooking);
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

        public static void GetAllInvoice()
        {
            using (SqlCommand command = new SqlCommand("SELECT * from Invoices", DatabaseConnection.Instance.Connection))
            {
                try
                {
                    // Kiểm tra trạng thái kết nối trước khi mở
                    if (DatabaseConnection.Instance.Connection.State == ConnectionState.Closed)
                    {
                        DatabaseConnection.Instance.Connection.Open();
                    }
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Xóa danh sách cũ trước khi tải mới
                        Invoices.Clear();
                        while (reader.Read())
                        {
                            int invoiceID = (int)reader["InvoiceID"];
                            int bookingID = (int)reader["BookingID"];
                            DateTime invoiceDate = (DateTime)reader["InvoiceDate"];
                            double totalAmount = Convert.ToDouble(reader["TotalAmount"]);
                            double paidAmount = Convert.ToDouble(reader["PaidAmount"]);
                            string paymentStatus = reader["PaymentStatus"].ToString();
                            string notes = reader["Notes"].ToString();

                            Invoice invoice = new Invoice(invoiceID, bookingID, invoiceDate, totalAmount, paidAmount, paymentStatus, notes);

                            Invoices.Add(invoice);
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

        //lấy thông tin các hóa đơn đã thanh toán
        public static void GetAllPaidInvoice()
        {
            string query = @"SELECT * FROM Invoices WHERE PaymentStatus = N'Đã thanh toán'";
            using (SqlCommand command = new SqlCommand(query, DatabaseConnection.Instance.Connection))
            {
                try
                {
                    // Kiểm tra trạng thái kết nối trước khi mở
                    if (DatabaseConnection.Instance.Connection.State == ConnectionState.Closed)
                    {
                        DatabaseConnection.Instance.Connection.Open();
                    }
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Xóa danh sách cũ trước khi tải được thanh toán
                        InvoiceFilter.Clear();
                        while (reader.Read())
                        {
                            int invoiceID = (int)reader["InvoiceID"];
                            int bookingID = (int)reader["BookingID"];
                            DateTime invoiceDate = (DateTime)reader["InvoiceDate"];
                            double totalAmount = Convert.ToDouble(reader["TotalAmount"]);
                            double paidAmount = Convert.ToDouble(reader["PaidAmount"]);
                            string paymentStatus = reader["PaymentStatus"].ToString();
                            string notes = reader["Notes"].ToString();

                            Invoice invoice = new Invoice(invoiceID, bookingID, invoiceDate, totalAmount, paidAmount, paymentStatus, notes);
                            InvoiceFilter.Add(invoice);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý các lỗi nếu có
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
        }
        //lấy thông tin các hóa đơn chưa thanh toán
        public static void GetAllNotPaidInvoice()
        {
            string query = @"SELECT * FROM Invoices WHERE PaymentStatus = N'Chưa thanh toán'";
            using (SqlCommand command = new SqlCommand(query, DatabaseConnection.Instance.Connection))
            {
                try
                {
                    // Kiểm tra trạng thái kết nối trước khi mở
                    if (DatabaseConnection.Instance.Connection.State == ConnectionState.Closed)
                    {
                        DatabaseConnection.Instance.Connection.Open();
                    }
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Xóa danh sách cũ trước khi tải được thanh toán
                        InvoiceFilter.Clear();
                        while (reader.Read())
                        {
                            int invoiceID = (int)reader["InvoiceID"];
                            int bookingID = (int)reader["BookingID"];
                            DateTime invoiceDate = (DateTime)reader["InvoiceDate"];
                            double totalAmount = Convert.ToDouble(reader["TotalAmount"]);
                            double paidAmount = Convert.ToDouble(reader["PaidAmount"]);
                            string paymentStatus = reader["PaymentStatus"].ToString();
                            string notes = reader["Notes"].ToString();

                            Invoice invoice = new Invoice(invoiceID, bookingID, invoiceDate, totalAmount, paidAmount, paymentStatus, notes);
                            InvoiceFilter.Add(invoice);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý các lỗi nếu có
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
        }

        //Lưu thông tin phòng vào CSDL
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
        public static void InsertCustomerToDB(string id, string name, DateTime birthDate, string gender, string address, string phone, string email, DateTime dateJoined, string note)
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

        //Lưu thông tin book phòng vào csdl đồng thời cập nhật trạng thái phòng
        public static void InsertBookingRoomToDB(RoomBooking roomBooking)
        {
            //Lưu thông tin vào CSDL
            using (SqlCommand command = new SqlCommand(
              "INSERT INTO RoomBookings (BookingID, CustomerID, RoomID, CheckInDate, CheckOutDate, NumberOfGuests,TotalPrice,BookingStatus,Notes)" +
              " VALUES (@BookingID, @CustomerID, @RoomID, @CheckInDate, @CheckOutDate, @NumberOfGuests, @TotalPrice, @BookingStatus, @Notes)",
              DatabaseConnection.Instance.Connection))
            {
                command.Parameters.AddWithValue("@BookingID", roomBooking.Id);
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

        //Lưu thông tin của hóa đơn mới
        public static void InsertInvoicesToDB(Invoice invoice)
        {
            using (SqlCommand command = new SqlCommand(
                 "INSERT INTO Invoices (InvoiceID ,BookingID, InvoiceDate, TotalAmount, PaidAmount, PaymentStatus, Notes) " +
                 "VALUES (@InvoiceID, @BookingID, @InvoiceDate, @TotalAmount, @PaidAmount, @PaymentStatus, @Notes)",
                 DatabaseConnection.Instance.Connection))
            {
                command.Parameters.AddWithValue("@InvoiceID", invoice.InvoiceID);
                command.Parameters.AddWithValue("@BookingID", invoice.BookingID);
                command.Parameters.AddWithValue("@InvoiceDate", invoice.InvoiceDate);
                command.Parameters.AddWithValue("@TotalAmount", invoice.TotalAmount);
                command.Parameters.AddWithValue("@PaidAmount", invoice.PaidAmount);
                command.Parameters.AddWithValue("@PaymentStatus", invoice.PaymentStatus);
                command.Parameters.AddWithValue("@Notes", invoice.Notes);

                try
                {
                    DatabaseConnection.Instance.Connection.Open(); // Mở kết nối đến cơ sở dữ liệu
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Thêm hóa đơn thành công!");
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

        //Cập nhật lại hóa đơn sau khi thanh toán
        internal static void UpdateInvoice(object id)
        {
            using (SqlCommand command = new SqlCommand(
                "UPDATE Invoices " +
                   "SET PaymentStatus = N'Đã thanh toán' " +
                   "WHERE InvoiceID = @InvoiceID",
                DatabaseConnection.Instance.Connection))
            {
                command.Parameters.AddWithValue("@InvoiceID", id);

                try
                {
                    DatabaseConnection.Instance.Connection.Open(); // Mở kết nối đến cơ sở dữ liệu
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật hóa đơn thành công!");
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

        public static void FillDataGridViewCustomer(Guna2DataGridView dtgv, List<Customer> customers)
        {
            //xóa các dòng trong bảng
            dtgv.Rows.Clear();

            //điền dữ liệu vào bảng
            foreach (Customer c in customers)
            {
                dtgv.Rows.Add(c.CustomerID, c.FullName, c.DateOfBirth.ToString("dd/MM/yyyy"),
                    c.Gender, c.Email, c.PhoneNumber, c.DateJoined.ToString("dd/MM/yyyy"), c.Notes, "Sửa");
            }
        }

        public static void FillDataGridViewInvoice(Guna2DataGridView dtgv, List<Invoice> invoices)
        {
            // Xóa các dòng trong bảng
            dtgv.Rows.Clear();
            // Load lại dữ liệu của hóa đơn và đặt phòng
            GetAllInvoice();
            GetAllRoomBooking();

            // Điền dữ liệu vào bảng
            foreach (Invoice invoice in invoices)
            {
                RoomBooking b = FindRoomBookingById(invoice.BookingID); // Tìm phòng có mã hợp
                Customer customer = FindCustomerById(b.CustomerId);

                // Add a new row to the DataGridView
                int rowIndex = dtgv.Rows.Add(invoice.InvoiceID, customer.CustomerID, customer.FullName, b.RoomId, b.CheckInDate.ToString("dd/MM/yyyy"), invoice.PaymentStatus.ToString(), "Thanh toán");

                // Get the newly added row
                DataGridViewRow row = dtgv.Rows[rowIndex];

                // Enable or disable the last cell based on PaymentStatus
                DataGridViewCell paymentCell = row.Cells[row.Cells.Count - 1];

                if (invoice.PaymentStatus.ToString() == "Đã thanh toán")
                {
                    paymentCell.ReadOnly = true;
                    paymentCell.Style.ForeColor = Color.Gray;
                    paymentCell.Style.SelectionForeColor = Color.Gray;
                }
                else
                {
                    paymentCell.ReadOnly = false;
                    paymentCell.Style.ForeColor = Color.Black;
                    paymentCell.Style.SelectionForeColor = Color.Black;
                }
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

        public static List<Customer> FindCustomer(string columnName, string content)
        {
            var foundedCustomers = new List<Customer>();

            string query = $"SELECT * FROM Customers WHERE {columnName} LIKE @content";

            using (SqlCommand command = new SqlCommand(query, DatabaseConnection.Instance.Connection))
            {
                command.Parameters.AddWithValue("@content", "%" + content + "%");

                try
                {
                    DatabaseConnection.Instance.Connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer customer = new Customer
                            {
                                CustomerID = reader["CustomerID"].ToString(),
                                FullName = reader["FullName"].ToString(),
                                DateOfBirth = reader["DateOfBirth"] != DBNull.Value ? Convert.ToDateTime(reader["DateOfBirth"]) : DateTime.MinValue,
                                Gender = reader["Gender"].ToString(),
                                Address = reader["Address"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                Email = reader["Email"].ToString(),
                                DateJoined = reader["DateJoined"] != DBNull.Value ? Convert.ToDateTime(reader["DateJoined"]) : DateTime.MinValue,
                                Notes = reader["Notes"].ToString()
                            };
                            foundedCustomers.Add(customer);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    DatabaseConnection.Instance.Connection.Close();
                }
            }

            return foundedCustomers;
        }

        public static void ClearDataGridView(Guna2DataGridView dtgvBookingSelectedRoom)
        {
            // Xóa tất cả các dòng trong DataGridView
            dtgvBookingSelectedRoom.Rows.Clear();
        }

        public static Room FindRoomById(string id)
        {
            foreach (var room in EmptyRooms)
                if (room.Id == id.Trim())
                    return room;
            return null;
        }

        public static RoomBooking FindRoomBookingById(int bookingID)
        {
            foreach (var r in RoomBookings)
                if (r.Id == bookingID)
                    return r;
            return null;
        }

        public static Customer FindCustomerById(string customerId)
        {
            foreach (var customer in Customers)
                if (customer.CustomerID == customerId.Trim())
                    return customer;
            return null;
        }

        
    }
}

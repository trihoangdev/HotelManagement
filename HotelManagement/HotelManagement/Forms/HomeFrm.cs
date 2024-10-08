﻿using Guna.UI2.WinForms;
using HotelManagement.ClassFolder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HotelManagement.Forms
{
    public partial class HomeFrm : Form
    {
        private string empId;
        private Employee emp = new Employee(); //đối tượng nhân viên hiện tại trong form
        private List<Room> selectedRoom = new List<Room>();
        public HomeFrm(string empId)
        {
            this.empId = empId;
            InitializeComponent();
        }

        //Chức năng load form
        private void HomeFrm_Load(object sender, EventArgs e)
        {
            //Load các danh sách lên
            DataProvider.GetAllEmployee();
            DataProvider.GetAllCustomer();
            DataProvider.GetAllLogins();
            DataProvider.GetAllRooms();
            DataProvider.GetAllEmptyRooms();
            DataProvider.GetAllRoomBooking();
            DataProvider.GetAllInvoice();

            //Tìm đối tượng nhân viên của form
            emp = emp.FindEmpById(DataProvider.Employees, empId);

            //setup các tab control tùy theo chức năng
            if (emp.Role != "Admin")
            {
                controlTabHome.Controls.Remove(tabEmployeeDetail);
                controlTabHome.Controls.Remove(tabRegisterEmp);
            }
            roomsTableAdapter.Fill(this.hotelManagementDataSet.Rooms);

            //Load mặc định tab quản lý phòng lên đầu tiên
            SetupManageRoomTab();
        }

        //Chức năng thêm mới khách hàng
        private void btnCreateNewCustomer_Click(object sender, EventArgs e)
        {
            //Kích hoạt các control
            txtRegisCustomerId.Enabled = true;
            txtRegisCustomerName.Enabled = true;
            txtRegisCustomerAddress.Enabled = true;
            txtRegisCustomerEmail.Enabled = true;
            txtRegisCustomerPhone.Enabled = true;
            dtRegisCustomerBirthDate.Enabled = true;
            dtRegisCustomerDateJoined.Value = DateTime.Now;
            gbRegisCustomerGender.Enabled = true;
            txtRegisCustomerNote.Enabled = true;

        }

        //Chức năng tạo mới phòng
        private void btnCreateNewRoom_Click(object sender, EventArgs e)
        {
            //Khởi tạo mã phòng tự động tăng
            DataProvider.GetAllRooms(); //Load lại danh sách
            var idInt = DataProvider.Rooms.Count;//Lấy mã phòng hiện tại
            idInt = idInt + 1;//Tăng mã phòng lên 1

            var id = "RM" + idInt + "";
            txtRoomId.Text = id;//set id ch text

            //Set các control rỗng
            txtRoomDes.Clear();
            txtRoomPrice.Clear();
            comboRoomType.SelectedIndex = -1;
            numbericRoomCapacity.Text = "0";

            btnUpdateRoom.Enabled = false;
            //btnDeleteRoom.Enabled = false;
            btnAddNewRoom.Enabled = true;
        }

        //Sự kiện điều khiển các tab control của form
        private void controlTabHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (controlTabHome.SelectedTab.Text.ToString())
            {
                //Quản Lý Phòng
                case "Quản Lý Phòng":
                    {
                        SetupManageRoomTab();
                        break;
                    }
                //Đặt Phòng
                case "Đặt Phòng":
                    {
                        SetupBookingtab();
                        break;
                    }
                //Đăng Ký Khách Hàng
                case "Đăng Ký Khách Hàng":
                    {
                        SetupRegisCustomerTab();
                        break;
                    }
                //Quản Lý Khách Hàng
                case "Quản Lý Khách Hàng":
                    {
                        SetupManageCustomerTab();
                        break;
                    }
                //Quản Lý Nhân Viên
                case "Quản Lý Nhân Viên":
                    {
                        SetupManageEmployeTab();
                        break;
                    }
                //Đăng Ký Nhân Viên
                case "Đăng Ký Nhân Viên":
                    {
                        SetupRegisEmpTab();
                        break;
                    }
                //Thanh Toán
                case "Thanh Toán":
                    {
                        SetupInvoiceTab();
                        break;
                    }
                //Thống kê
                case "Thống kê":
                    {
                        break;
                    }

                //Trang Cá Nhân
                case "Trang Cá Nhân":
                    {
                        txtInfoEmpName.Text = emp.FullName.ToString();
                        txtInfoEmpId.Text = emp.EmployeeID.ToString();
                        txtInfoEmpGender.Text = emp.Gender.ToString();
                        txtInfoEmpAddress.Text = emp.Address.ToString();
                        txtInfoEmpPhone.Text = emp.PhoneNumber.ToString();
                        txtInfoEmpUsername.Text = emp.EmployeeID.ToString();
                        txtInfoEmpPassword.Text = emp.FindLoginById(DataProvider.Logins, empId).Password.ToString();
                        txtInfoEmpPos.Text = emp.Position.ToString();
                        txtInfoEmpStatus.Text = emp.Status.ToString();
                        dtInfoEmpDateHired.Value = emp.DateHired;
                        break;
                    }
            }
        }

        //setup tab đăng ký nhân viên
        private void SetupRegisEmpTab()
        {
            //Xóa các ký tự trong form
            ControlHelper.ClearDataInControls(new List<Control> { txtRegisEmpId ,txtRegisEmpAddress,
                txtRegisEmpEmail, txtRegisEmpName,txtRegisEmpNote,txtRegisEmpPhone,txtRegisEmpPos});
            //Chỉnh ngày về ngày hiện tại
            dtRegisEmpBirthDate.Value = DateTime.Now;
            dtRegisEmpHiredDate.Value = DateTime.Now;
        }

        //Setup cho tab Đăng ký khách hàng
        private void SetupRegisCustomerTab()
        {
            //Xóa các ký tự trong form
            ControlHelper.ClearDataInControls(new List<Control> { txtRegisCustomerId ,
                txtRegisCustomerAddress,txtRegisCustomerEmail, txtRegisCustomerName,
                txtRegisCustomerNote,txtRegisCustomerPhone});
            //Chỉnh ngày về ngày hiện tại
            dtRegisCustomerBirthDate.Value = DateTime.Now;
            //Ngày tham gia là ngày hiện tại
            dtRegisCustomerDateJoined.Value = DateTime.Now;
        }

        //Setup cho tab quản lý phòng
        public void SetupManageEmployeTab()
        {
            DataProvider.GetAllEmployee();

            //Xóa dữ liệu trong bảng hiện tại
            dtgvInfoEmp.Rows.Clear();

            //Truyền dữ liệu từ danh sách vào DataGridView
            DataProvider.FillDataGridViewEmployee(dtgvInfoEmp, DataProvider.Employees);
        }

        //setup cho tab quản lý khách hàng
        private void SetupManageCustomerTab()
        {
            //Lấy dữ liệu khách hàng
            DataProvider.GetAllCustomer();

            //Xóa dữ liệu trong bảng hiện tại
            dtgvInfoCustomer.Rows.Clear();

            //Truyền dữ liệu từ danh sách vào DataGridView
            DataProvider.FillDataGridViewCustomer(dtgvInfoCustomer, DataProvider.Customers);

            //Xóa các textbox 
            ControlHelper.ClearDataInControls(new List<Control> { txtInfoCustomerId, txtInfoCustomerName, txtInfoCustomerEmail, txtInfoCustomerPhone, txtInfoCustomerAddress, txtInfoCustomerNote });
        }

        //setup cho tab hóa đơn
        private void SetupInvoiceTab()
        {
            dtgvInfoCustomer.Rows.Clear();
            DataProvider.FillDataGridViewInvoice(dtgvInvoice, DataProvider.Invoices);
        }

        //set up cho tab quản lý phòng
        private void SetupManageRoomTab()
        {
            DataProvider.FillDataGridView(dtgvRoom, "Rooms");
        }

        //Setup cho tab Booking
        private void SetupBookingtab()
        {
            //Clear all data cũ
            ControlHelper.ClearDataInControls(new List<Control> { txtBookingCustomerIdInfo, txtBookingCustomerGenderInfo, txtBookingCustomerIAddressnfo, txtBookingCustomerNameInfo, txtBookingCustomerPhoneInfo });

            //set ngày là ngày hiện tại
            ControlHelper.SetDateTimeNow(new List<Guna2DateTimePicker> { dtBookingStart, dtBookingEnd });

            //Xóa data cũ của bảng room
            DataProvider.ClearDataGridView(dtgvBookingRoom);

            //Load data vào bảng phòng
            DataProvider.FillDataGridViewBooking(dtgvBookingRoom, DataProvider.EmptyRooms);

            //Clear data của bảng select room
            DataProvider.ClearDataGridView(dtgvBookingSelectedRoom);

            //set bộ lọc room
            DataProvider.RoomFilter = new List<Room>();

            //reset selected room
            selectedRoom.Clear();
        }

        //Sự kiện click vào dòng của bảng danh sách phòng -> fill data vào các control
        private void dtgvRoom_SelectionChanged(object sender, EventArgs e)
        {
            //Enable cac control
            ControlHelper.EnableControls(new List<Control> { comboRoomType, numbericRoomCapacity,
                txtRoomPrice, txtRoomDes, btnUpdateRoom });
            btnAddNewRoom.Enabled = false;

            //Fill data vào các ô
            var row = dtgvRoom.CurrentRow;
            var id = row.Cells[0].Value;
            var type = row.Cells[1].Value;
            var cap = row.Cells[2].Value;
            var price = row.Cells[3].Value;
            var status = row.Cells[4].Value;
            var des = row.Cells[5].Value;

            txtRoomId.Text = id.ToString();
            comboRoomType.Text = type.ToString();
            numbericRoomCapacity.Text = cap.ToString();
            txtRoomPrice.Text = price.ToString();
            txtRoomDes.Text = des.ToString();

        }

        //Sự kiện thêm mới phòng
        private void btnAddNewRoom_Click(object sender, EventArgs e)
        {
            if (ControlHelper.IsAnyControlEmpty(new List<Control> { txtRoomId, txtRoomPrice, comboRoomType, numbericRoomCapacity }))
                MessageBox.Show("Không được để trống bất kì thông tin nào ngoại trừ \"Mô tả\"");
            //Kiểm tra định dạng của các textbox
            else if (!ControlHelper.IsAllTextIsNumber(new List<Control> { txtRoomPrice }))
            {
                MessageBox.Show("Giá tiền phải là số!");
                txtRoomPrice.Focus();
            }
            else if (comboRoomType.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng");
                comboRoomType.Focus();
            }
            else if (numbericRoomCapacity.Text == "0")
            {
                MessageBox.Show("Vui lòng chọn sức chứa!");
                numbericRoomCapacity.Focus();
            }
            else
            {
                //Lưu vào CSDL
                DataProvider.InsertRoomToDB(txtRoomId.Text, numbericRoomCapacity.Text,
                    comboRoomType.SelectedItem.ToString(), Double.Parse(txtRoomPrice.Text), txtRoomDes.Text);
                //Load lai dữ liệu
                DataProvider.FillDataGridView(dtgvRoom, "Rooms");
            }
        }

        //Sự kiện cập nhật thông tin phòng
        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            if (ControlHelper.IsAnyControlEmpty(new List<Control> { txtRoomId, txtRoomPrice, comboRoomType, numbericRoomCapacity }))
                MessageBox.Show("Không được để trống bất kì thông tin nào ngoại trừ \"Mô tả\"");
            //Kiểm tra định dạng của các textbox
            if (!ControlHelper.IsAllTextIsNumber(new List<Control> { txtRoomPrice }))
            {
                MessageBox.Show("Giá tiền phải là số!");
                txtRoomPrice.Focus();
            }
            else if (comboRoomType.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng");
                comboRoomType.Focus();
            }
            else if (numbericRoomCapacity.Text == "0")
            {
                MessageBox.Show("Vui lòng chọn sức chứa!");
                numbericRoomCapacity.Focus();
            }
            else
            {
                //Lưu vào CSDL
                DataProvider.UpdateRoom(txtRoomId.Text, numbericRoomCapacity.Text,
                    comboRoomType.SelectedItem.ToString(), Double.Parse(txtRoomPrice.Text), txtRoomDes.Text);
                //Fill lại data vào dtgv
                DataProvider.FillDataGridView(dtgvRoom, "Rooms");
            }
        }

        //Sự kiện xóa phòng --> Bỏ
        /*private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                //Xóa phòng khỏi csdl
                if (DataProvider.RemoveRoom(txtRoomId.Text) == 0)
                    ShowMessageInfo("Không thể xóa phòng đang được sử dụng!");
                else 
                    ShowMessageInfo("Xóa phòng thành công!");
                //fill lại dtgv
                DataProvider.FillDataGridView(dtgvRoom, "Rooms");
            }
        }*/

        //Sự kiện tìm khách hàng đặt phòng bằng CCCD
        private void imgBookingFindCustomer_Click(object sender, EventArgs e)
        {
            var id = txtBookingCustomerIdInfo.Text;
            if (id == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {
                //Tìm Customer trong CSDL
                Customer customer = new Customer();
                customer = customer.FindCustomerById(DataProvider.Customers, id);
                if (customer != null)
                {
                    //Fill data của cus vào textbox tương ứng
                    txtBookingCustomerIdInfo.Text = customer.CustomerID.ToString();
                    txtBookingCustomerGenderInfo.Text = customer.Gender.ToString();
                    txtBookingCustomerIAddressnfo.Text = customer.Address.ToString();
                    txtBookingCustomerNameInfo.Text = customer.FullName.ToString();
                    txtBookingCustomerPhoneInfo.Text = customer.PhoneNumber.ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách nào có mã trên!");
                }
            }
        }

        //Sự kiện lọc phòng theo số người
        private void radCapacity_CheckedChanged(object sender, EventArgs e)
        {
            var rooms = new List<Room>();
            if (radBookingSingleRoom.Checked)
            {
                //lọc các phòng đơn
                rooms = DataProvider.FindEmptyRoomByCapacity(radBookingSingleRoom.Text);
            }
            else
            {
                //lọc các phòng đôi
                rooms = DataProvider.FindEmptyRoomByCapacity(radBookingDoubleRoom.Text);
            }
            DataProvider.FillDataGridViewBooking(dtgvBookingRoom, rooms);
        }

        //Sự kiện lọc phòng theo kiểu phòng
        private void radTypeRoom_CheckedChanged(object sender, EventArgs e)
        {
            var rooms = new List<Room>();
            if (radBookingTypeStandard.Checked)
            {
                //lọc các phòng standard
                rooms = DataProvider.FindRoomByType(radBookingTypeStandard.Text);
            }
            else if (radBookingTypeDeluxe.Checked)
            {
                //lọc các phòng Deluxe
                rooms = DataProvider.FindRoomByType(radBookingTypeDeluxe.Text);
            }
            else
            {
                //lọc các phòng Suite
                rooms = DataProvider.FindRoomByType(radBookingTypeSuite.Text);
            }
            DataProvider.FillDataGridViewBooking(dtgvBookingRoom, rooms);
        }

        //Sự kiện chọn phòng từ danh sách
        private void dtgvBookingRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int lastColumnIndex = dtgvBookingRoom.Columns.Count - 1; // Chỉ số của cột cuối cùng

            // Kiểm tra nếu người dùng click vào cell cuối cùng của hàng được chọn
            if (e.ColumnIndex == lastColumnIndex && e.RowIndex != -1) // e.RowIndex != -1 để loại trừ trường hợp người dùng click vào header
            {
                // Lấy dữ liệu từ row được chọn
                DataGridViewRow selectedRow = dtgvBookingRoom.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cells của row được chọn
                string id = selectedRow.Cells[0].Value.ToString();
                string type = selectedRow.Cells[1].Value.ToString();
                double price = Convert.ToDouble(dtgvBookingRoom.Rows[e.RowIndex].Cells[2].Value);

                //thêm dòng
                int rowIndex = dtgvBookingSelectedRoom.Rows.Add();

                if (dtgvBookingSelectedRoom.Rows.Count > 1)
                {
                    ShowMessageInfo("Mỗi người chỉ được đặt tối đa 1 phòng");
                    // Xóa dòng vừa được thêm vào để ngăn không cho thêm dòng đó
                    dtgvBookingSelectedRoom.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    // Thêm dữ liệu vào dtgvBookingSelectedRoom

                    dtgvBookingSelectedRoom.Rows[rowIndex].Cells[0].Value = id;
                    dtgvBookingSelectedRoom.Rows[rowIndex].Cells[1].Value = type;
                    dtgvBookingSelectedRoom.Rows[rowIndex].Cells[2].Value = price;
                    dtgvBookingSelectedRoom.Rows[rowIndex].Cells[3].Value = "Xóa";
                }

            }
            // Xóa row hiện tại trong dtgvBookingRoom
            dtgvBookingRoom.Rows.RemoveAt(e.RowIndex);
        }

        //Sự kiện xóa phòng khỏi ds phòng đã chọn
        private void dtgvBookingSelectedRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int lastColumnIndex = dtgvBookingSelectedRoom.Columns.Count - 1; // Chỉ số của cột cuối cùng

            // Kiểm tra nếu người dùng click vào cell cuối cùng của hàng được chọn
            if (e.ColumnIndex == lastColumnIndex && e.RowIndex != -1) // e.RowIndex != -1 để loại trừ trường hợp người dùng click vào header
            {
                // Lấy dữ liệu từ row được chọn trong dtgvBookingSelectedRoom
                DataGridViewRow selectedRow = dtgvBookingSelectedRoom.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cells của row được chọn trong dtgvBookingSelectedRoom
                string id = selectedRow.Cells[0].Value.ToString();
                string type = selectedRow.Cells[1].Value.ToString();
                double price = 0;

                // Chuyển đổi giá trị từ dtgvBookingSelectedRoom sang kiểu double
                if (double.TryParse(selectedRow.Cells[2].Value?.ToString(), out price))
                {
                    // Thêm dữ liệu vào dtgvBookingRoom
                    int rowIndex = dtgvBookingRoom.Rows.Add();
                    dtgvBookingRoom.Rows[rowIndex].Cells[0].Value = id;
                    dtgvBookingRoom.Rows[rowIndex].Cells[1].Value = type;
                    dtgvBookingRoom.Rows[rowIndex].Cells[2].Value = price;
                    dtgvBookingRoom.Rows[rowIndex].Cells[3].Value = "Thêm";

                    // Xóa row hiện tại trong dtgvBookingSelectedRoom
                    dtgvBookingSelectedRoom.Rows.RemoveAt(e.RowIndex);
                }
                else
                {
                    MessageBox.Show("Không thể chuyển đổi giá trị giá thành double.");
                }
            }
        }

        //Sự kiện đặt phòng
        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (dtBookingEnd.Value <= dtBookingStart.Value)
                ShowMessageInfo("Ngày trả phòng phải > ngày đặt phòng!");
            else if (txtBookingCustomerIdInfo.Text == "")
                ShowMessageInfo("Vui lòng điền thông tin khách hoặc đăng ký rồi điền!");
            else if (dtBookingStart.Value.Date < DateTime.Now.Date)
                ShowMessageInfo("Ngày đặt phòng phải >= ngày hiện tại!");
            else if (txtBookingCustomerNameInfo.Text == "")
                ShowMessageInfo("Vui lòng điền đúng thông tin người đặt phòng bằng CCCD hoặc đăng ký thông tin người đặt phòng");
            else
            {
                //Lấy danh sách phòng từ dtgv
                foreach (DataGridViewRow row in dtgvBookingSelectedRoom.Rows)
                {
                    string id = row.Cells[0].Value.ToString();
                    selectedRoom.Add(DataProvider.FindRoomById(id));
                }
                //Cho người nhận xác nhận thông tin 
                string name = txtBookingCustomerNameInfo.Text;
                string startDate = dtBookingStart.Value.ToString("dd/MM/yyyy");
                string endDate = dtBookingEnd.Value.ToString("dd/MM/yyyy");
                TimeSpan difference = dtBookingEnd.Value - dtBookingStart.Value;
                int numOfDays = difference.Days + 1;
                string info = $"Người đặt phòng: {name}\n" +
                    $"Ngày nhận phòng: {startDate}\n" +
                    $"Ngày trả phòng: {endDate}\n" +
                    $"Tổng số ngày ở: {numOfDays} ngày\n" +
                    $"\n=> DANH SÁCH PHÒNG <==\n";

                string roomId = selectedRoom[0].Id.ToString();
                string price = ConvertToCurrencyString(selectedRoom[0].Price);
                info += $"\tSố phòng: {roomId}\n" +
                    $"\tGiá phòng: {price}VNĐ\n\n";

                info += $"\n==> TỔNG TIỀN: {ConvertToCurrencyString(CalculateTotalPrice(selectedRoom))}VNĐ\n\n" +
                    $"BẠN CÓ MUỐN THANH TOÁN? \nCHỌN YES ĐỂ THANH TOÁN, NO ĐỂ QUAY LẠI";
                var res = MessageBox.Show(info, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    //Lưu đối tượng vào lớp
                    string cusId = txtBookingCustomerIdInfo.Text;
                    DateTime checkin = dtBookingStart.Value;
                    DateTime checkout = dtBookingEnd.Value;
                    int numOfGuest = (radBookingSingleRoom.Checked) ? 2 : 4;
                    double totalPrice = CalculateTotalPrice(selectedRoom);
                    string bookingStatus = "Đã đặt";
                    string notes = "";

                    RoomBooking roomBooking =
                        new RoomBooking(cusId, roomId, checkin, checkout, numOfGuest, totalPrice, bookingStatus, notes);

                    //Lưu phòng đã đặt vào CSDL
                    DataProvider.InsertBookingRoomToDB(roomBooking);

                    //Tạo đối tượng phiếu hóa đơn
                    Invoice invoice = new Invoice(roomBooking.Id, checkin, totalPrice, 0, "Chưa thanh toán", notes);

                    //Tiến hành thanh toán
                    DataProvider.InsertInvoicesToDB(invoice);

                    //reset tab
                    SetupBookingtab();
                }
                else
                {
                    //clear selected room
                    selectedRoom.Clear();
                }

            }
        }

        //Phương thức tính tổng tiền phòng
        public double CalculateTotalPrice(List<Room> rooms)
        {
            TimeSpan difference = dtBookingEnd.Value - dtBookingStart.Value;
            int numOfDays = difference.Days + 1;
            return rooms[0].Price * numOfDays;
        }

        //Hàm show info
        public void ShowMessageInfo(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OKCancel);
        }

        //hàm chuyển định dạng tiền
        public string ConvertToCurrencyString(double amount)
        {
            // Định dạng số thành tiền tệ theo tiêu chuẩn quốc gia của Việt Nam
            string formattedAmount = string.Format(new CultureInfo("vi-VN"), "{0:C}", amount);

            // Loại bỏ ký hiệu VNĐ
            string vndAmount = formattedAmount.Replace(" ₫", "");

            return vndAmount;
        }

        //Chức năng đăng ký tài khoản cho khách hàng
        private void btnRegisAddNewCustomer_Click(object sender, EventArgs e)
        {
            if (ControlHelper.IsAnyControlEmpty(new List<Control> { txtRegisCustomerId, txtRegisCustomerAddress,
                txtRegisCustomerEmail, txtRegisCustomerName, txtRegisCustomerPhone }))
            {
                ShowMessageInfo("Phải điền tất cả thông tin ngoại trừ Ghi chú có thể điền hoặc không");
            }
            else if (ControlHelper.IsDateTimeValid(dtRegisCustomerBirthDate))
            {
                ShowMessageInfo("Chỉ đăng ký cho khách hàng trên 18 tuổi");
            }
            else if (!radioRegisGenderFemale.Checked && !radioRegisGenderMale.Checked)
            {
                ShowMessageInfo("Vui lòng chọn giới tính");
            }
            else
            {
                // Lưu thông tin vào lớp
                var id = txtRegisCustomerId.Text;
                var name = txtRegisCustomerName.Text;
                var birthDate = dtRegisCustomerBirthDate.Value;
                var gender = (radioRegisGenderFemale.Checked) ? "Nữ" : "Nam";
                var address = txtRegisCustomerAddress.Text;
                var phone = txtRegisCustomerPhone.Text;
                var email = txtRegisCustomerEmail.Text;
                var dateJoined = dtRegisCustomerDateJoined.Value;
                var note = txtRegisCustomerNote.Text;

                Customer customer = new Customer(name, birthDate, gender, address, phone, email, id, dateJoined, note);
                DataProvider.Customers.Add(customer);

                //lưu thông tin vào csdl
                DataProvider.InsertCustomerToDB(id, name, birthDate, gender, address, phone, email, dateJoined, note);

                //reset tab
                SetupRegisCustomerTab();
            }
        }

        //Chức năng tìm kiếm thông tin khách hàng
        private void btnInfoFindCustomer_Click(object sender, EventArgs e)
        {
            if (comboInfoCusCriteria.SelectedIndex < 0)
            {
                ShowMessageInfo("Vui lòng chọn tiêu chí");
            }
            else if (txtInfoContentCusFind.Text == "")
            {
                ShowMessageInfo("Vui lòng điền nội dung tìm kiếm");
            }
            else
            {
                var content = txtInfoContentCusFind.Text;
                string columnSearch = "";
                switch (comboInfoCusCriteria.SelectedIndex)
                {

                    case 0:
                        {
                            //Tìm theo CCCD
                            columnSearch = "CustomerId";
                            break;
                        }
                    case 1:
                        {
                            //Tìm theo họ tên
                            columnSearch = "FullName";
                            break;
                        }
                    case 2:
                        {
                            //TÌm theo ngày sinh
                            columnSearch = "DateOfBirth";
                            break;
                        }
                    case 3:
                        {
                            //TÌm theo Giới tính
                            columnSearch = "Gender";
                            break;
                        }
                    case 4:
                        {
                            //TÌm theo SĐT
                            columnSearch = "PhoneNumber";
                            break;
                        }
                    case 5:
                        {
                            //TÌm theo Email
                            columnSearch = "Email";
                            break;
                        }
                    case 6:
                        {
                            //TÌm theo ngày tham gia
                            columnSearch = "DateJoined";
                            break;
                        }
                }
                var foundCustomer = DataProvider.FindCustomer(columnSearch, content);
                DataProvider.FillDataGridViewCustomer(dtgvInfoCustomer, foundCustomer);
            }
        }

        //Refresh lại bảng customer
        private void btnInfoCustomerRefresh_Click(object sender, EventArgs e)
        {
            txtInfoContentCusFind.Text = "";
            comboInfoCusCriteria.SelectedIndex = -1;
            DataProvider.GetAllCustomer();
            DataProvider.FillDataGridViewCustomer(dtgvInfoCustomer, DataProvider.Customers);

            //reset các button unenable
            ControlHelper.UnEnableControl(new List<Control> { btnInfoCustomerUpdate });
        }

        //Handler các radio trong hóa đơn
        private void radInvoice_CheckedChanged(object sender, EventArgs e)
        {
            if (radInvoiceAll.Checked)
            {
                //show tất cả
                DataProvider.GetAllInvoice();
                DataProvider.FillDataGridViewInvoice(dtgvInvoice, DataProvider.Invoices);
            }
            else if (radInvoicePaid.Checked)
            {
                //Show hóa đơn đã trả
                DataProvider.GetAllPaidInvoice();
                DataProvider.FillDataGridViewInvoice(dtgvInvoice, DataProvider.InvoiceFilter);
            }
            else
            {
                //Show hóa đơn chưa trả
                DataProvider.GetAllNotPaidInvoice();
                DataProvider.FillDataGridViewInvoice(dtgvInvoice, DataProvider.InvoiceFilter);
            }
        }

        //Chức năng thanh toán hóa đơn
        private void dtgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvInvoice.Columns[e.ColumnIndex].Name == "colBillPay")
            {
                // Lấy payment status
                string paymentStatus = dtgvInvoice.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString();

                if (paymentStatus == "Đã thanh toán")
                {
                    MessageBox.Show("Hóa đơn này đã được thanh toán.");
                }
                else
                {
                    var res = MessageBox.Show("Bạn có muốn thanh toán hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        //lấy dòng đang xét
                        DataGridViewRow row = dtgvInvoice.Rows[e.RowIndex];
                        //Cập nhật lại danh sách hóa đơn và lưu vào CSDL
                        var id = row.Cells["colBillId"].Value;
                        DataProvider.UpdateInvoice(id.ToString());
                        //Load lại bảng
                        DataProvider.GetAllInvoice();
                        DataProvider.FillDataGridViewInvoice(dtgvInvoice, DataProvider.Invoices);
                    }
                }
            }
        }

        //Chức năng tìm kiếm hóa đơn
        private void btnInvoiceFind_Click(object sender, EventArgs e)
        {
            if (comboInvoiceCriteria.SelectedIndex < 0)
                ShowMessageInfo("Vui lòng chọn tiêu chí tìm kiếm");
            else if (txtInvoiceContentFind.Text == string.Empty)
                ShowMessageInfo("Vui lòng điển nội dung tìm kiếm");
            else
            {
                //Tìm kiếm
                switch (comboInvoiceCriteria.SelectedIndex)
                {
                    case 0:
                        {
                            //Tìm bằng mã HĐ
                            DataProvider.FilterInvoiceById(txtInvoiceContentFind.Text);
                            DataProvider.FillDataGridViewInvoice(dtgvInvoice, DataProvider.InvoiceFilter);
                            break;
                        }
                    case 1:
                        {
                            //Tìm bằng mã KH
                            DataProvider.FindInvoiceByCustomerId(txtInvoiceContentFind.Text);
                            DataProvider.FillDataGridViewInvoice(dtgvInvoice, DataProvider.InvoiceFilter);
                            break;
                        }
                    case 2:
                        {
                            //Tìm theo tên KH
                            DataProvider.FindInvoiceByCustomerName(dtgvInvoice, txtInvoiceContentFind.Text);
                            break;
                        }
                    case 3:
                        {
                            //Tìm theo mã phòng
                            DataProvider.FindInvoiceByRoomId(dtgvInvoice, txtInvoiceContentFind.Text);
                            break;
                        }
                }
            }
        }

        //Chức năng đổi mật khẩu
        private void txtChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePasswordFrm f = new ChangePasswordFrm(emp); //mở form đổi mật khẩu
            f.ShowDialog();
        }

        //Sửa thông tin cá nhân
        private void btnInfoUpdateEmpInfo_Click(object sender, EventArgs e)
        {
            if (ControlHelper.IsAnyControlEmpty(new List<Control> { txtInfoEmpName, txtInfoEmpAddress, txtInfoEmpGender, txtInfoEmpPhone }))
            {
                ShowMessageInfo("Không được để trống bất kì thông tin nào!");
            }
            else if (!ControlHelper.IsAllTextIsNumber(new List<Control> { txtInfoEmpPhone }))
            {
                ShowMessageInfo("SĐT phải là số có 10 chữ số");
            }
            else
            {
                //Lưu vào CSDL
                var id = txtInfoEmpId.Text;
                var name = txtInfoEmpName.Text;
                var phone = txtInfoEmpPhone.Text;
                var gender = txtInfoEmpGender.Text;
                var address = txtInfoEmpAddress.Text;
                DataProvider.UpdateEmployee(id, name, phone, address);

                DataProvider.GetAllEmployee();//Load lại ds EMP
                emp = emp.FindEmpById(DataProvider.Employees, empId);//cập nhật lại đối tượng emp của form này
            }

        }

        //Phương thức chọn dòng của bảng customer
        //Đẩy data lên các textbox tương ứng
        private void dtgvInfoCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy dòng cần chọn
            var row = dtgvInfoCustomer.SelectedRows[0];
            if (row != null)
            {
                //Tìm KH tương ứng với id của dòng
                var colId = row.Cells[0].Value.ToString();
                var customer = DataProvider.FindCustomerById(colId);

                //Đẩy data tương ứng lên các control tương ứng
                txtInfoCustomerId.Text = customer.CustomerID;
                txtInfoCustomerName.Text = customer.FullName;
                txtInfoCustomerPhone.Text = customer.PhoneNumber;
                txtInfoCustomerEmail.Text = customer.Email;
                dateTimeInfoCustomerBirthDate.Value = customer.DateOfBirth;
                if (customer.Gender == "Nam") radioInfoCustomerGenderMale.Checked = true;
                else radioInfoCustomerGenderFemale.Checked = true;
                txtInfoCustomerAddress.Text = customer.Address;
                txtInfoCustomerNote.Text = customer.Notes;

                //Hiện các button sửa/xóa
                //btnInfoCustomerDelete.Enabled = true;
                btnInfoCustomerUpdate.Enabled = true;
            }
        }

        //Chức năng sửa thông tin khách hàng
        private void btnInfoCustomerUpdate_Click(object sender, EventArgs e)
        {
            //Check có thông tin nào trống không
            if (ControlHelper.IsAnyControlEmpty(new List<Control> { txtInfoCustomerId, txtInfoCustomerName, txtInfoCustomerEmail, txtInfoCustomerPhone, txtInfoCustomerAddress }))
                ShowMessageInfo("Các thông tin phải được điền đầy đủ");
            else if (ControlHelper.IsDateTimeValid(dateTimeInfoCustomerBirthDate))
                ShowMessageInfo("Ngày sinh không hợp lệ");
            else
            {
                string id = txtInfoCustomerId.Text;
                string name = txtInfoCustomerName.Text;
                string phone = txtInfoCustomerPhone.Text;
                string email = txtInfoCustomerEmail.Text;
                DateTime birthDate = dateTimeInfoCustomerBirthDate.Value;
                string gender = (radioInfoCustomerGenderMale.Checked == true) ? "Nam" : "Nữ";
                string address = txtInfoCustomerAddress.Text;
                string note = txtInfoCustomerNote.Text;
                if (DataProvider.UpdateCustomer(id, name, phone, email, birthDate, gender, address, note) > 0)
                    ShowMessageInfo("Sửa thông tin khách hàng thành công!");
                else
                {
                    ShowMessageInfo("Không thể sửa thông tin khách hàng. Vui lòng xem lại!");
                }
            }
            DataProvider.FillDataGridViewCustomer(dtgvInfoCustomer, DataProvider.Customers);
        }

        //Chức năng xóa khách hàng --> bỏ
        /*
         private void btnInfoCustomerDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                string sql = $"DELETE Customers where CustomerId = {txtInfoCustomerId.Text}";
                if (DataProvider.ModifyDB(sql) > 0)
                {
                    MessageBox.Show("Xóa khách hàng thành công!");
                    SetupManageCustomerTab();
                }
                else
                    ShowMessageInfo("Xóa khách hàng thất bại");
            }

        }*/

        //Click vào nút Xem chi tiết hiện form thông tin nhân viên
        private void dtgvInfoEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int lastColumnIndex = dtgvInfoEmp.Columns.Count - 1; // Chỉ số của cột cuối cùng

            // Kiểm tra nếu người dùng click vào cell cuối cùng của hàng được chọn
            if (e.ColumnIndex == lastColumnIndex && e.RowIndex != -1) // e.RowIndex != -1 để loại trừ trường hợp người dùng click vào header
            {
                // Lấy dữ liệu từ row được chọn
                DataGridViewRow selectedRow = dtgvInfoEmp.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cells của row được chọn
                string id = selectedRow.Cells[0].Value.ToString();

                //truyền id của nhân viên đó vào form mới
                EmployeeInfoFrm empInfoFrm = new EmployeeInfoFrm(id, this);
                empInfoFrm.ShowDialog();
            }
        }

        //Chức năng refresh bảng nhân viên
        private void btnInfoEmpRefresh_Click(object sender, EventArgs e)
        {
            SetupManageEmployeTab();
            ControlHelper.ClearDataInControls(new List<Control> { txtInfoContentEmpFind });
            comboInfoEmpCriteria.SelectedIndex = -1;
        }

        //Chức năng tìm kếm nhân viên
        private void btnInfoEmpFind_Click(object sender, EventArgs e)
        {
            if (comboInfoEmpCriteria.SelectedIndex < 0)
            {
                ShowMessageInfo("Vui lòng chọn tiêu chí");
            }
            else if (txtInfoContentEmpFind.Text == "")
            {
                ShowMessageInfo("Vui lòng điền nội dung tìm kiếm");
            }
            else
            {
                string sql = "";
                switch (comboInfoEmpCriteria.SelectedItem.ToString())
                {
                    case "Tìm theo CCCD":
                        {
                            sql = $@"SELECT EmployeeID, FullName, Position, Status 
                                        from Employees where EmployeeID LIKE '%{txtInfoContentEmpFind.Text}%'";
                            break;
                        }

                    case "Tìm theo tên nhân viên":
                        {
                            sql = $@"SELECT EmployeeID, FullName, Position, Status 
                                        from Employees where FullName LIKE '%{txtInfoContentEmpFind.Text}%'";
                            break;
                        }
                }
                var dt = DataProvider.LoadDB(sql);
                DataProvider.FillDataGridViewEmployee(dtgvInfoEmp, dt);
            }
        }

        //Chức năng đăng ký nhân viên
        private void btnRegisEmp_Click(object sender, EventArgs e)
        {
            if (ControlHelper.IsAnyControlEmpty(new List<Control> { txtRegisEmpId, txtRegisEmpName,
                txtRegisEmpAddress, txtRegisEmpPhone,
                txtRegisEmpEmail,txtRegisEmpPos ,txtRegisEmpNote}))
            {
                ShowMessageInfo("Không được để trống thông tin!");
            }
            else if (!ControlHelper.IsDateTimeValid(dtRegisCustomerBirthDate))
            {
                ShowMessageInfo("Nhân viên phải trên 18 tuổi!");
            }
            else if (Employee.IsEmpIdExist(DataProvider.Employees, txtRegisEmpPhone.Text))
            {
                ShowMessageInfo("SĐT nhân viên đã tồn tại!");
                txtRegisEmpPhone.Focus();
            }
            else if (Employee.IsEmpIdExist(DataProvider.Employees, txtRegisEmpEmail.Text))
            {
                ShowMessageInfo("Email nhân viên đã tồn tại!");
                txtRegisEmpEmail.Focus();
            }
            else if (Employee.IsEmpIdExist(DataProvider.Employees, txtRegisEmpId.Text))
            {
                ShowMessageInfo("Mã nhân viên đã tồn tại!");
                txtRegisEmpId.Focus();
            }
            else
            {
                string id = txtRegisEmpId.Text;
                string name = txtRegisEmpName.Text;
                string address = txtRegisEmpAddress.Text;
                string phone = txtRegisEmpPhone.Text;
                string email = txtRegisEmpEmail.Text;
                string pos = txtRegisEmpPos.Text;
                string note = txtRegisEmpNote.Text;
                string gender = (radRegisEmpMale.Checked) ? "Nam" : "Nữ";
                string role = (radRegisEmpAdmin.Checked) ? "Admin" : "Nhân viên";
                var birthDate = dtRegisEmpBirthDate.Value;
                var hiredDate = dtRegisEmpHiredDate.Value;
                string status = "Đang làm việc";
                string pass = id + "@123";
                //Thêm mới nhân viên
                string sql1 = $@"INSERT INTO Employees VALUES
                            ('{id}', N'{name}','{birthDate}',N'{gender}',N'{address}','{phone}',
                            '{email}',N'{role}',N'{pos}','{hiredDate}',N'{status}',N'{note}');";
                string sql2 = $@"INSERT INTO Login Values
                            ('{id}', '{pass}',N'{role}')";
                if (DataProvider.ModifyDB(sql1) > 0 && DataProvider.ModifyDB(sql2) > 0)
                {
                    ShowMessageInfo($"Đăng ký tài khoản nhân viên thành công!\nTHÔNG TIN TÀI KHOẢN:\nTài khoản: {id}\nMật khẩu: {pass}");
                    //Load lại DS nhân viên
                    DataProvider.GetAllEmployee();
                }
                else
                    ShowMessageInfo("Đăng ký không thành công!");
            }
        }

        //Chức năng lấy thống kê
        private void btnGetStat_Click(object sender, EventArgs e)
        {
            if (comboCriteriaStat.SelectedIndex == -1)
            {
                ShowMessageInfo("Vui phòng chọn tiêu chí thống kê!");
            }
            else
            {
                switch (comboCriteriaStat.SelectedItem.ToString())
                {
                    case "Theo loại phòng":
                        {
                            string query = @"SELECT RoomType, COUNT(*) AS RoomCount
                                             FROM Rooms
                                             GROUP BY RoomType;";
                            DataTable dt = DataProvider.LoadDB(query);
                            chart1.DataSource = dt;

                            // Đặt tên cho trục X và Y
                            chart1.Series[0].XValueMember = "RoomType";
                            chart1.Series[0].YValueMembers = "RoomCount";

                            // Đặt tên biểu đồ
                            chart1.Series[0].Name = "Số lượng phòng theo loại";

                            // Đặt tiêu đề cho biểu đồ (nếu cần)
                            chart1.Titles.Clear();
                            Title chartTitle = chart1.Titles.Add("Biểu đồ số lượng phòng theo loại");

                            chartTitle.Font = new Font("Arial", 16, FontStyle.Bold); // Chỉnh cỡ chữ cho tiêu đề biểu đồ

                            // Làm mới lại biểu đồ để hiển thị dữ liệu mới
                            chart1.DataBind();

                            break;
                        }
                    case "Theo giới tính khách hàng":
                        {
                            string query = @"SELECT Gender, COUNT(*) AS GenderCount
                                                FROM Customers
                                                GROUP BY Gender;
                                                ";
                            DataTable dt = DataProvider.LoadDB(query);
                            chart1.DataSource = dt;

                            // Đặt tên cho trục X và Y
                            chart1.Series[0].XValueMember = "Gender";
                            chart1.Series[0].YValueMembers = "GenderCount";

                            // Đặt tên biểu đồ
                            chart1.Series[0].Name = "Số lượng khách hàng theo giới tính";

                            // Đặt tiêu đề cho biểu đồ (nếu cần)
                            chart1.Titles.Clear();
                            Title chartTitle = chart1.Titles.Add("Biểu đồ số lượng khách hàng theo giới tính");

                            chartTitle.Font = new Font("Arial", 16, FontStyle.Bold); // Chỉnh cỡ chữ cho tiêu đề biểu đồ

                            // Làm mới lại biểu đồ để hiển thị dữ liệu mới
                            chart1.DataBind();

                            break;
                        }
                    case "Theo tuổi khách hàng":
                        {
                            string query = @"SELECT Age, COUNT(*) AS NumberOfCustomers
                                                FROM (
                                                    SELECT 
                                                        DATEDIFF(YEAR, DateOfBirth, GETDATE()) - 
                                                        CASE 
                                                            WHEN MONTH(GETDATE()) < MONTH(DateOfBirth) OR 
                                                                 (MONTH(GETDATE()) = MONTH(DateOfBirth) AND DAY(GETDATE()) < DAY(DateOfBirth))
                                                            THEN 1
                                                            ELSE 0
                                                        END AS Age
                                                    FROM Customers
                                                ) AS AgeTable
                                                GROUP BY Age
                                                ORDER BY Age;

                                                ";
                            DataTable dt = DataProvider.LoadDB(query);
                            chart1.DataSource = dt;

                            // Đặt tên cho trục X và Y
                            chart1.Series[0].XValueMember = "Age";
                            chart1.Series[0].YValueMembers = "NumberOfCustomers";

                            // Đặt tên biểu đồ
                            chart1.Series[0].Name = "Số lượng khách hàng theo tuổi";

                            // Đặt tiêu đề cho biểu đồ (nếu cần)
                            chart1.Titles.Clear();
                            Title chartTitle = chart1.Titles.Add("Biểu đồ số lượng khách hàng theo tuổi");

                            chartTitle.Font = new Font("Arial", 16, FontStyle.Bold); // Chỉnh cỡ chữ cho tiêu đề biểu đồ

                            // Làm mới lại biểu đồ để hiển thị dữ liệu mới
                            chart1.DataBind();

                            break;
                        }
                    case "Theo giới tính nhân viên":
                        {
                            string query = @"SELECT Gender, COUNT(*) AS GenderCount
                                                FROM Employees
                                                GROUP BY Gender;
                                                ";
                            DataTable dt = DataProvider.LoadDB(query);
                            chart1.DataSource = dt;

                            // Đặt tên cho trục X và Y
                            chart1.Series[0].XValueMember = "Gender";
                            chart1.Series[0].YValueMembers = "GenderCount";

                            // Đặt tên biểu đồ
                            chart1.Series[0].Name = "Số lượng nhân viên theo giới tính";

                            // Đặt tiêu đề cho biểu đồ (nếu cần)
                            chart1.Titles.Clear();
                            Title chartTitle = chart1.Titles.Add("Biểu đồ số lượng nhân viên theo giới tính");

                            chartTitle.Font = new Font("Arial", 16, FontStyle.Bold); // Chỉnh cỡ chữ cho tiêu đề biểu đồ

                            // Làm mới lại biểu đồ để hiển thị dữ liệu mới
                            chart1.DataBind();

                            break;
                        }
                    case "Theo tuổi nhân viên":
                        {
                            string query = @"SELECT Age, COUNT(*) AS NumberOfEmployees
                                                FROM (
                                                    SELECT 
                                                        DATEDIFF(YEAR, DateOfBirth, GETDATE()) - 
                                                        CASE 
                                                            WHEN MONTH(GETDATE()) < MONTH(DateOfBirth) OR 
                                                                 (MONTH(GETDATE()) = MONTH(DateOfBirth) AND DAY(GETDATE()) < DAY(DateOfBirth))
                                                            THEN 1
                                                            ELSE 0
                                                        END AS Age
                                                    FROM Employees
                                                ) AS AgeTable
                                                GROUP BY Age
                                                ORDER BY Age;

                                                ";
                            DataTable dt = DataProvider.LoadDB(query);
                            chart1.DataSource = dt;

                            // Đặt tên cho trục X và Y
                            chart1.Series[0].XValueMember = "Age";
                            chart1.Series[0].YValueMembers = "NumberOfEmployees";

                            // Đặt tên biểu đồ
                            chart1.Series[0].Name = "Số lượng nhân viên theo tuổi";

                            // Đặt tiêu đề cho biểu đồ (nếu cần)
                            chart1.Titles.Clear();
                            Title chartTitle = chart1.Titles.Add("Biểu đồ số lượng nhân viên theo tuổi");

                            chartTitle.Font = new Font("Arial", 16, FontStyle.Bold); // Chỉnh cỡ chữ cho tiêu đề biểu đồ

                            // Làm mới lại biểu đồ để hiển thị dữ liệu mới
                            chart1.DataBind();

                            break;
                        }

                }
                // Chỉnh cỡ chữ cho trục X
                chart1.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 14, FontStyle.Bold); // Tiêu đề trục X
                chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 12); // Nhãn trục X

                // Chỉnh cỡ chữ cho trục Y
                chart1.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 14, FontStyle.Bold); // Tiêu đề trục Y
                chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 12); // Nhãn trục Y

            }
        }
    }
}

﻿using Guna.UI2.WinForms;
using HotelManagement.ClassFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Forms
{
    public partial class HomeFrm : Form
    {
        private string empId;
        private Employee emp = new Employee();
        private List<Room> selectedRoom = new List<Room>();
        public HomeFrm(string empId)
        {
            this.empId = empId;
            InitializeComponent();
        }

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
            btnDeleteRoom.Enabled = false;
            btnAddNewRoom.Enabled = true;



        }

        private void HomeFrm_Load(object sender, EventArgs e)
        {
            this.roomsTableAdapter.Fill(this.hotelManagementDataSet.Rooms);

            //Load các danh sách lên
            DataProvider.GettAllEmployee();
            DataProvider.GetAllCustomer();
            DataProvider.GetAllLogins();
            DataProvider.GetAllRooms();

            emp = emp.FindEmpById(DataProvider.Employees, empId);
        }

        private void controlTabHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (controlTabHome.SelectedIndex)
            {
                case 0:
                    {
                        SetupManageRoomTab();
                        break;
                    }
                case 1:
                    {
                        SetupBookingtab();
                        break;
                    }

                case 3:
                    {
                        DataProvider.GetAllCustomer();
                        //Xóa dữ liệu trong bảng hiện tại
                        dtgvCustomer.Rows.Clear();

                        //Truyền dữ liệu từ danh sách vào DataGridView
                        foreach (var customer in DataProvider.Customers)
                        {
                            dtgvCustomer.Rows.Add(
                                customer.CustomerID,
                                customer.FullName,
                                customer.DateOfBirth.ToString("dd/MM/yyyy"),
                                customer.Gender,
                                customer.Email,
                                customer.PhoneNumber,
                                customer.DateJoined.ToString("dd/MM/yyyy"),
                                customer.Notes,
                                "Sửa");
                        }
                        break;
                    }

                case 6:
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

        //set up cho tab quản lý phòng
        private void SetupManageRoomTab()
        {
            DataProvider.GetAllRooms();
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
            DataProvider.FillDataGridViewBooking(dtgvBookingRoom, "Rooms", new List<string> { "RoomId", "RoomType", "Price" });

            //Clear data của bảng select room
            DataProvider.ClearDataGridView(dtgvBookingSelectedRoom);

            //set bộ lọc room
            DataProvider.RoomFilter = new List<Room>();
        }

        //Sự kiện click vào dòng của bảng danh sách phòng -> fill data vào các control

        private void dtgvRoom_SelectionChanged(object sender, EventArgs e)
        {
            //Enable cac control
            ControlHelper.EnableControls(new List<Control> { comboRoomType, numbericRoomCapacity,
                txtRoomPrice, txtRoomDes, btnUpdateRoom, btnDeleteRoom });
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
            if (ControlHelper.IsAllControlEmpty(new List<Control> { txtRoomId, txtRoomPrice, comboRoomType, numbericRoomCapacity }))
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
                DataProvider.SaveAllRooms(txtRoomId.Text, numbericRoomCapacity.Text,
                    comboRoomType.SelectedItem.ToString(), Double.Parse(txtRoomPrice.Text), txtRoomDes.Text);
            }
        }

        //Sự kiện cập nhật thông tin phòng
        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            if (ControlHelper.IsAllControlEmpty(new List<Control> { txtRoomId, txtRoomPrice, comboRoomType, numbericRoomCapacity }))
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

        //Sự kiện xóa phòng
        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                //Xóa phòng khỏi csdl
                DataProvider.RemoveRoom(txtRoomId.Text);
                //fill lại dtgv
                DataProvider.FillDataGridView(dtgvRoom, "Rooms");
            }
        }

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
                rooms = DataProvider.FindRoomByCapacity(radBookingSingleRoom.Text);
            }
            else
            {
                //lọc các phòng đôi
                rooms = DataProvider.FindRoomByCapacity(radBookingDoubleRoom.Text);
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
                string info = $"Người đặt phòng: {txtBookingCustomerNameInfo.Text}\n" +
                    $"Ngày nhận phòng: {dtBookingStart.Value.ToString("dd/MM/yyyy")}\n" +
                    $"Ngày trả phòng: {dtBookingEnd.Value.ToString("dd/MM/yyyy")}\n" +
                    $"Tổng số ngày ở: {dtBookingEnd.Value.Day - dtBookingStart.Value.Day} ngày\n" +
                    $"\n=> DANH SÁCH PHÒNG <==\n";
                int index = 0;
                foreach (var room in selectedRoom)
                {
                    index++;
                    info += $"- Phòng số {index}\n" +
                        $"\tSố phòng: {room.Id}\n" +
                        $"\tGiá phòng: {ConvertToCurrencyString(room.Price)}VNĐ\n\n";
                }
                info += $"\n==> TỔNG TIỀN: {ConvertToCurrencyString(CalculateTotalPrice(selectedRoom))}VNĐ\n\n" +
                    $"BẠN CÓ MUỐN THANH TOÁN? \nCHỌN YES ĐỂ THANH TOÁN, NO ĐỂ QUAY LẠI";
                var res = MessageBox.Show(info, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    //Lưu đối tượng vào lớp
                    string cusId = txtBookingCustomerIdInfo.Text;
                    string roomId = selectedRoom[0].Id.ToString();
                    DateTime checkin = dtBookingStart.Value;
                    DateTime checkout = dtBookingEnd.Value;
                    int numOfGuest = (radBookingSingleRoom.Checked) ? 2 : 4;
                    double totalPrice = selectedRoom[0].Price;
                    string bookingStatus = "Đã đặt";
                    string notes = "";

                    RoomBooking roomBooking =
                        new RoomBooking(cusId, roomId, checkin, checkout, numOfGuest, totalPrice, bookingStatus, notes);

                    //Tiến hành thanh toán
                    DataProvider.SaveBookingRoom(roomBooking);
                    //reset tab
                    SetupBookingtab();
                }
                else
                {
                    //Do nothing
                }

            }
        }

        //Phương thức tính tổng tiền phòng
        public double CalculateTotalPrice(List<Room> rooms)
        {
            int numOfDate = dtBookingEnd.Value.Day - dtBookingStart.Value.Day;
            double totalPrice = 0;
            foreach (var room in rooms)
            {
                totalPrice += room.Price;
            }
            return totalPrice * numOfDate;
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

        //Kiểm soát số phòng mà người đó đặt -> Mỗi người chỉ dc đặt 1 phòng
        private void dtgvBookingSelectedRoom_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }
    }
}

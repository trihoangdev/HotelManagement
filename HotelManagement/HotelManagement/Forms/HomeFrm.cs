using Guna.UI2.WinForms;
using HotelManagement.ClassFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            // TODO: This line of code loads data into the 'hotelManagementDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.hotelManagementDataSet.Rooms);
            //Load thông tin của Emp đó vào form

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
                        break;
                    }
                case 1:
                    {
                        //Clear all data cũ
                        ControlHelper.ClearDataInControls(new List<Control> { txtBookingCustomerIdInfo, txtBookingCustomerGenderInfo, txtBookingCustomerIAddressnfo, txtBookingCustomerNameInfo, txtBookingCustomerPhoneInfo });

                        //set ngày là ngày hiện tại
                        ControlHelper.SetDateTimeNow(new List<Guna2DateTimePicker> { dtBookingStart, dtBookingEnd });

                        //Load data vào bảng phòng
                        DataProvider.FillDataGridViewBooking(dtgvBookingRoom, "Rooms", new List<string> { "RoomId", "RoomType", "Price" });

                        //set bộ lọc room
                        DataProvider.RoomFilter = new List<Room>();
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

        private void radTypeRoom_CheckedChanged(object sender, EventArgs e)
        {
            var rooms = new List<Room>();
            if (radBookingTypeStandard.Checked)
            {
                //lọc các phòng standard
                rooms = DataProvider.FindRoomByType(radBookingTypeStandard.Text);
            }
            else if(radBookingTypeDeluxe.Checked) 
            {
                //lọc các phòng Deluxe
                rooms = DataProvider.FindRoomByType(radBookingTypeDeluxe.Text);
            }
            else
            {
                //lọc các phòng Suite
                rooms = DataProvider.FindRoomByType(radBookingTypeSuite.Text);
            }
            DataProvider.FillDataGridViewBooking(dtgvBookingRoom,rooms);
        }
    }
}

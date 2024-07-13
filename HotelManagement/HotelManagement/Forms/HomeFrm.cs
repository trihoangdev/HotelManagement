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
            //Kích hoạt các control
            numbericCapacity.Enabled = true;
            txtRoomPrice.Enabled = true;
            comboRoomType.Enabled = true;
            btnRegisAddNewCustomer.Enabled = true;

            //Khởi tạo mã phòng tự động tăng
        }

        private void HomeFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagementDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.hotelManagementDataSet.Rooms);
            //Load thông tin của Emp đó vào form
            DataProvider.GettAllEmployee();

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
    }
}

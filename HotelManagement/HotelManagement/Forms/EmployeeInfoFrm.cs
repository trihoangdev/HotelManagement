using HotelManagement.ClassFolder;
using System;
using System.Windows.Forms;

namespace HotelManagement.Forms
{
    public partial class EmployeeInfoFrm : Form
    {
        private string _id;
        private Employee _emp;
        private Login _login = new Login();
        private HomeFrm _parentFrm;
        public EmployeeInfoFrm(string id, HomeFrm parentFrm)
        {
            InitializeComponent();
            _id = id;
            _emp = new Employee();
            _parentFrm = parentFrm;
            _emp = _emp.FindEmpById(DataProvider.Employees, _id);
            _login = _login.FindLoginById(DataProvider.Logins, _id);
        }

        private void EmployeeInfoFrm_Load(object sender, System.EventArgs e)
        {
            //Đẩy data của emp đó lên các ô
            txtId.Text = _emp.EmployeeID;
            txtFullname.Text = _emp.FullName;
            txtPassword.Text = _login.Password;
            txtPhone.Text = _emp.PhoneNumber;
            txtEmail.Text = _emp.Email;
            txtAddress.Text = _emp.Address;
            txtRole.Text = _emp.Role;
            txtPos.Text = _emp.Position;
            if (_emp.Gender == "Nam") radioMale.Checked = true;
            else radioFemale.Checked = true;
            dtBirthDate.Value = _emp.DateOfBirth;
            dtStartDate.Value = _emp.DateHired;
            txtNote.Text = _emp.Notes;
            comboStatus.SelectedIndex = (_emp.Status.CompareTo("Đang làm việc") == 0) ? 0 : 1;
        }

        private void btnUpdateEmp_Click(object sender, System.EventArgs e)
        {
            string id = txtId.Text;
            string name = txtFullname.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string role = txtRole.Text;
            string pos = txtPos.Text;
            DateTime birthDate = dtBirthDate.Value;
            DateTime startDate = dtStartDate.Value;
            string note = txtNote.Text;
            string status = (comboStatus.SelectedIndex == 0) ? "Đang làm việc" : "Đã nghỉ việc";
            string gender = (radioMale.Checked) ? "Nam" : "Nữ";
            string pass = txtPassword.Text;

            string sql1 = $@"
                            UPDATE Employees 
                            SET FullName = N'{name}', 
                                PhoneNumber = '{phone}', 
                                Email = '{email}', 
                                Address = N'{address}', 
                                Position = N'{pos}', 
                                DateOfBirth = '{birthDate}', 
                                DateHired = '{startDate}', 
                                Notes = N'{note}', 
                                Status = N'{status}', 
                                Gender = N'{gender}' 
                            WHERE EmployeeID = '{id}'";

            string sql2 = $@"
                            UPDATE Login 
                            SET Password = '{pass}' 
                            WHERE Username = '{id}'";


            if (DataProvider.ModifyDB(sql1) > 0 && DataProvider.ModifyDB(sql2) > 0)
            {
                MessageBox.Show("Sửa thông tin nhân viên thành công!");
                _parentFrm.SetupManageEmployeTab();
                Close();
            }
            else
                MessageBox.Show("Sửa thông tin nhân viên thất bại!");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                //Xóa khỏi ds nhân viên
                string sql1 = $@"DELETE Employees where EmployeeID = {txtId.Text}";
                //Xóa khỏi ds tài khoản
                string sql2 = $@"DELETE Login where Username = {txtId.Text}";
                if (DataProvider.ModifyDB(sql1) > 0 && DataProvider.ModifyDB(sql2) > 0)
                {
                    MessageBox.Show("Xóa nhân viên thành công!");
                    _parentFrm.SetupManageEmployeTab();
                    Close();
                }
                else
                    MessageBox.Show("Xóa nhân viên thất bại!");
            }
        }
    }
}

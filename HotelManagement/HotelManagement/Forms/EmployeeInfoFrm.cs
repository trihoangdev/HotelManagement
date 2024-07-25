using HotelManagement.ClassFolder;
using System.Windows.Forms;

namespace HotelManagement.Forms
{
    public partial class EmployeeInfoFrm : Form
    {
        private string _id;
        private Employee _emp;
        private Login _login = new Login();
        public EmployeeInfoFrm(string id)
        {
            InitializeComponent();
            _id = id;
            _emp = new Employee();
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
            comboStatus.SelectedIndex = (_emp.Status.CompareTo("Đang làm việc") ==0) ? 0 : 1;
        }
    }
}

using HotelManagement.ClassFolder;
using System;
using System.Windows.Forms;

namespace HotelManagement.Forms
{
    public partial class ChangePasswordFrm : Form
    {
        private Employee _emp;
        public ChangePasswordFrm(Employee emp)
        {
            InitializeComponent();
            _emp = emp;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var curPass = txtCurPass.Text;
            var newPass = txtNewPass.Text;
            var reNewPass = txtNewPassAgain.Text;

            if (!DataProvider.IsCurrentPassCorrect(_emp.EmployeeID, curPass))
            {
                MessageBox.Show("Mật khẩu hiện tại không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurPass.Focus();
            }
            else if(newPass != reNewPass)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassAgain.Focus();
            }
            else
            {
                //Lưu vào CSDL
                DataProvider.UpdatePassword(_emp.EmployeeID, newPass);
                Close();
            }
        }
    }
}

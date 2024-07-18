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

            
        }
    }
}

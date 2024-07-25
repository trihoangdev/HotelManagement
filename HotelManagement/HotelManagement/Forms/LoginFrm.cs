using HotelManagement.ClassFolder;
using HotelManagement.Forms;
using System;
using System.Windows.Forms;
namespace HotelManagement
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = comboRole.SelectedItem.ToString().Trim();
            if (CheckLogin(username,password,role))
            {
                HomeFrm homeFrm = new HomeFrm(username);
                homeFrm.ShowDialog();
            }
            else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
        }

        private bool CheckLogin(string username, string password, string role)
        {
            string sql = "SELECT * from login";
            DataProvider.GetAllLogins(sql);
            foreach (var login in DataProvider.Logins)
            {
                if (login.Username == username && login.Password == password && login.Role == role)
                    return true;
            }
            return false;
        }
    }
}

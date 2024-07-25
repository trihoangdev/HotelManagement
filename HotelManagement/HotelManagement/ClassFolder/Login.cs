
using System;
using System.Collections.Generic;

namespace HotelManagement.ClassFolder
{
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public Login(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
        public Login() { }

        internal Login FindLoginById(List<Login> logins, string id)
        {
            foreach (Login login in logins)
                if (login.Username == id)
                    return login;
            return null;
        }
    }
}

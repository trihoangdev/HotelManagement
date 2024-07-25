using System;
using System.Collections.Generic;

namespace HotelManagement.ClassFolder
{
    public class Employee : Person
    {
        public string EmployeeID { get; set; }
        public string Role { get; set; }
        public string Position { get; set; }
        public DateTime DateHired { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        // Constructor
        public Employee(string fullName, DateTime dateOfBirth, string gender, string address, string phoneNumber, string email,
                        string employeeID, string role, string position, DateTime dateHired, string status, string notes)
                        : base(fullName, dateOfBirth, gender, address, phoneNumber, email)
        {
            EmployeeID = employeeID;
            Role = role;
            Position = position;
            DateHired = dateHired;
            Status = status;
            Notes = notes;
        }
        public Employee() : base() { }

        public Employee FindEmpById(List<Employee> emps, string id)
        {
            foreach (Employee emp in emps)
                if (emp.EmployeeID == id)
                    return emp;
            return null;
        }
        public Login FindLoginById(List<Login> logins, string id)
        {
            foreach (Login login in logins)
                if (login.Username == id)
                    return login;
            return null;
        }
        public static bool IsEmpIdExist(List<Employee> emps, string id)
        {
            foreach (Employee emp in emps)
                if (emp.EmployeeID == id)
                    return true;
            return false;
        }
        public static bool IsEmpEmailExsit(List<Employee> emps, string email)
        {
            foreach (Employee emp in emps)
                if (emp.Email == email)
                    return true;
            return false;
        }
        public static bool IsEmpPhoneExsit(List<Employee> emps, string phone)
        {
            foreach (Employee emp in emps)
                if (emp.PhoneNumber == phone)
                    return true;
            return false;
        }
    }
}
using System;
using System.Collections.Generic;

namespace HotelManagement.ClassFolder
{
    public class Customer : Person
    {
        public string CustomerID { get; set; }
        public DateTime DateJoined { get; set; }
        public string Notes { get; set; }

        // Constructor
        public Customer(string fullName, DateTime dateOfBirth, string gender, string address, string phoneNumber, string email,
                        string customerID, DateTime dateJoined, string notes)
                        : base(fullName, dateOfBirth, gender, address, phoneNumber, email)
        {
            CustomerID = customerID;
            DateJoined = dateJoined;
            Notes = notes;
        }
        public Customer() : base() { }
        public void AddNewCustomer(string customerID, string fullName,
            DateTime dateOfBirth, string gender, string address,
            string phoneNumber, string email, DateTime dateJoined, string notes)
        {
            DataProvider.Customers.Add(new Customer(fullName, dateOfBirth, gender, address, phoneNumber, email, customerID, dateJoined, notes));
        }

        public Customer FindCustomerById(List<Customer> customers, string id)
        {
            foreach (Customer customer in customers)
                if (customer.CustomerID == id) return customer;
            return null;
        }
    }
}

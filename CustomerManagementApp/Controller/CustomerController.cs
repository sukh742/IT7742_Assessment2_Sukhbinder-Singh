using System;
using System.Collections.Generic;
using CustomerManagementApp.Model;   // Make sure this matches the namespace above

namespace CustomerManagementApp.Controller
{
    // Handles logic for adding, updating, and deleting customers
    public class CustomerController
    {
        private List<Customer> customers = new List<Customer>();

        // Return all customers
        public List<Customer> GetCustomers()
        {
            return customers;
        }

        // Add new customer
        public void AddCustomer(Customer c)
        {
            if (string.IsNullOrWhiteSpace(c.CustomerID) || string.IsNullOrWhiteSpace(c.CustomerName))
                throw new Exception("Customer ID and Name cannot be empty.");

            customers.Add(c);
        }

        // Update existing customer
        public void UpdateCustomer(string id, string newName)
        {
            Customer existing = customers.Find(x => x.CustomerID == id);
            if (existing == null)
                throw new Exception("Customer not found.");

            existing.CustomerName = newName;
        }

        // Delete customer
        public void DeleteCustomer(string id)
        {
            Customer existing = customers.Find(x => x.CustomerID == id);
            if (existing == null)
                throw new Exception("Customer not found.");

            customers.Remove(existing);
        }
    }
}

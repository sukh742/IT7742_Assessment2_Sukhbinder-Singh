using System;

namespace CustomerManagementApp.Model
{
    // Model class for customer data
    public class Customer
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }

        // Constructor with parameters
        public Customer(string id, string name)
        {
            CustomerID = id;
            CustomerName = name;
        }

        // Empty constructor
        public Customer() { }
    }
}

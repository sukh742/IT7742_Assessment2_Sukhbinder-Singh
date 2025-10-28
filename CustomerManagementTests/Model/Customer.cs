namespace CustomerManagementTests.Model
{
    // Only for Account references
    public class Customer
    {
        public string Name { get; set; }

        public Customer(string name)
        {
            Name = name;
        }

        public Customer() { }
    }
}

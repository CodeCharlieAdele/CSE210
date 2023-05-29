
public class Customer
    {
        public string _name { get; }
        public Address Address { get; }

        public Customer(string name, Address address)
        {
            _name = name;
            Address = address;
        }

        public bool IsInUSA()
        {
            return Address.IsInUSA();
        }
    }
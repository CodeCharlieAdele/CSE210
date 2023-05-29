
 public class Address
    {
        private string Street;
        private string City;
        private string State;
        private string ZipCode;

        // Constructor to initialize the address
        public Address(string street, string city, string state, string zipCode)
        {
            this.Street = street;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
        }

        // Method to return a string representation of the address
        public string GetAddressString()
        {
            return $"{Street}, {City}, {State} {ZipCode}";
        }
    }
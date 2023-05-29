public class Order
    {
        private List<Product> products;
        private Customer customer;
        private decimal shippingCost = 0.0m;

        public Order(Customer customer, List<Product> products)
        {
            this.customer = customer;
            this.products = products;

            if (customer.Address.IsInUSA())
            {
                shippingCost = 5.0m;
            }
            else
            {
                shippingCost = 35.0m;
            }
        }

        public decimal GetTotalCost()
        {
            decimal totalCost = 0.0m;

            foreach (Product product in products)
            {
                totalCost += product.Price * product.Quantity;
            }

            totalCost += shippingCost;

            return totalCost;
        }

        public string GetPackingLabel()
        {
            string label = "";

            foreach (Product product in products)
            {
                label += "Product Name: " + product.Name + "\n" +
                         "Product ID: " + product.Id + "\n\n";
            }

            return label;
        }

        public string GetShippingLabel()
        {
            string label = "";

            label += customer.Name + "\n" +
                     customer.Address.ToString() + "\n";

            return label;
        }
    }
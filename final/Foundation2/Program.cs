using System;

class Program
{
    static void Main(string[] args)
    {
            Product product1 = new Product("Berty Botts Every Flavor Beans", "98450-56", 9.99m, 5);
            Product product2 = new Product("Lemon Drops", "19990-56", 4.99m, 2);
            Product product3 = new Product("Chocolate Frogs", "58012-56", 7.99m, 3);

            Address address = new Address("12 Grimauld Place", "London", "United Kingdom", "England");
            Customer customer = new Customer("Ronald Weasley", address);

            List<Product> products = new List<Product>();
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            Order order = new Order(customer, products);

            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("Total Cost: $" + order.GetTotalCost().ToString("0.00"));
    }
}
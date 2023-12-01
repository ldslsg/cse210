class Program
{
    static void Main(string[] args)
    {
        // Create some products
        Product product1 = new Product { Name = "Product 1", ProductId = 1, Price = 10, Quantity = 2 };
        Product product2 = new Product { Name = "Product 2", ProductId = 2, Price = 20, Quantity = 1 };

        // Create an address
        Address address = new Address { Street = "123 Main St", City = "Anytown", State = "CA", Country = "USA" };

        // Create a customer
        Customer customer = new Customer { Name = "John Doe", Address = address };

        // Create an order
        Order order = new Order { Products = new List<Product> { product1, product2 }, Customer = customer };

        // Display the packing label, shipping label, and total cost
        Console.WriteLine("Packing Label:\n" + order.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order.GetTotalCost());
    }
}
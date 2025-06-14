using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main Street", "Salt Lake City", "UT", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LP100", 850.00, 1));
        order1.AddProduct(new Product("Wireless Mouse", "WM200", 25.00, 2));


        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());


        Address address2 = new Address("42 Labadi Ave", "Accra", "Greater Accra", "Ghana");
        Customer customer2 = new Customer("Adzo Mannavi", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "PH500", 400.00, 1));
        order2.AddProduct(new Product("Headphone", "CH110", 20.00, 1));


        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}
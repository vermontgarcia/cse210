using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to OnlineOrdering Project!");
        Console.WriteLine();

        // Order 1 
        Address address1 = new("50 S University Ave", "Provo", "Utah", 84601, "USA");

        Product product1 = new(100, "Watch", 25.67, 10);
        Product product2 = new(101, "Phone", 99.99, 6);
        Product product3 = new(102, "Tablet", 65.83);

        product3.SetQuantity(8);

        Customer customer = new("Jonh", "Dow", address1);

        Order order1 = new(customer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine("Order 1001 Details");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total order cost: {order1.GetTotalCost():C}");
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        // Order 2 Same content Order 1 but international $35 USD Shipping Fee
        Address address2 = new("Av. Juarez", "Centro", "CDMX", 06050, "MEX");

        Customer customer2 = new("Juan", "Dominguez", address2);

        Order order2 = new(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1002 Details");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total order cost: {order2.GetTotalCost():C}");
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();

        // Order 3
        Address address3 = new("8 E Broadway No 550", "Salt Lake City", "UT", 84111, "USA");

        Customer customer3 = new("Goerge", "Smith", address3);

        Product product4 = new(204, "Sirloinn Steak", 39.99, 5);
        Product product5 = new(205, "Asadero Cheese", 14.99, 6);
        Product product6 = new(206, "Sweet Onion", 15.83, 7);
        Product product7 = new(207, "Asparagus", 5.83, 10);

        List<Product> productsOrder3 = [product4, product5, product6, product7];

        Order order3 = new(customer3, productsOrder3);

        Console.WriteLine("Order 2001 Details");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine($"Total order cost: {order3.GetTotalCost():C}");
        Console.WriteLine();
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine();
    }
}
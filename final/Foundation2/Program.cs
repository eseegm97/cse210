using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer cust1 = new Customer("John Smith", addr1);

        Product prod1 = new Product("Book", "B001", 12.99, 2);
        Product prod2 = new Product("Pen", "P045", 1.50, 5);

        Order order1 = new Order(cust1);
        order1.AddProduct(prod1);
        order1.AddProduct(prod2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}\n");

        Address addr2 = new Address("456 Oak Ave", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Alice Johnson", addr2);

        Product prod3 = new Product("Notebook", "N123", 5.75, 3);
        Product prod4 = new Product("Marker", "M456", 2.00, 4);
        Product prod5 = new Product("Eraser", "E789", 0.99, 2);

        Order order2 = new Order(cust2);
        order2.AddProduct(prod3);
        order2.AddProduct(prod4);
        order2.AddProduct(prod5);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
    }
}
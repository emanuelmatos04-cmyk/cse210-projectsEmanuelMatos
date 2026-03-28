using System;

public class Program
{
    public static void Main()
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Emanuel Matos", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 101, 999.99f, 1));
        order1.AddProduct(new Product("Mouse", 102, 25.50f, 2));

        Console.WriteLine("Packing List:");
        Console.WriteLine(order1.GetPacking());

        Console.WriteLine("\nShipping Label:");
        foreach (string line in order1.GetShippingLabel())
        {
            Console.WriteLine(line);
        }

        Console.WriteLine($"\nTotal Price: ${order1.GetTotalPrice()}");
    }
}

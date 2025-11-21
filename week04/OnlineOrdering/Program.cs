using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Totally Real St.", "Nashville","TN", "USA");
        Customer customer1 = new Customer("Defforeel Guy", address1);
        List<Product> productlist1 = new List<Product>()
        {
            new Product("Drain B Gone", 12345, 14.99, 2),
            new Product("Literal Actual Flamethrower", 60179, 145.78, 1),
            new Product("Like, the Best Milk", 81163, 5.99, 3)
        };
        
        Order order1 = new Order(customer1, productlist1);

        Address address2 = new Address("78 Goofyburg", "The Boyzone","QT", "Letheria");
        Customer customer2 = new Customer("Lord Von Hildensnurp", address2);
        List<Product> productlist2 = new List<Product>()
        {
            new Product("The Sword of Throngling", 4869, 175.69, 1),
            new Product("Fire Ant Farm", 1473, 9.87, 5),
            new Product("Trash Can Filled With Resin and Fake Trash", 48059, 12.75, 1)
        };
        
        Order order2 = new Order(customer2, productlist2);

        Console.WriteLine("Order #1");
        Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}\n");
        Console.WriteLine($"Packing Label:\n{order1.GetPackingLabel()}\n");
        Console.WriteLine($"Total Cost: {order1.ComputeTotalCost()}\n");

        Console.WriteLine("Order #2");
        Console.WriteLine($"Shipping Label:\n{order2.GetShippingLabel()}\n");
        Console.WriteLine($"Packing Label:\n{order2.GetPackingLabel()}\n");
        Console.WriteLine($"Total Cost: {order2.ComputeTotalCost()}\n");
    }
}
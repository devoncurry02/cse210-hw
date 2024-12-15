using System;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Lamp", 1, 79.99m, 4);
        Product product2 = new Product("Iphone16", 2, 739.99m, 1);
        Product product3 = new Product("Mousetraps", 3, 8.49m, 10);
        Product product4 = new Product("Adidas", 4, 89.99m, 1);

        Address address1 = new Address("141 S 1st W", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Devon Curry", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(product2);
        order1.AddProduct(product4);
        PrintFullLabel(order1.PackingLabel(), order1.ShippingLabel(), order1.CalculatePrice());

        Address address2 = new Address("72 Rue Eugene Pottier", "Guyancourt", "BFC", "France");
        Customer customer2 = new Customer("Hunter Nye", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(product1);
        PrintFullLabel(order2.PackingLabel(), order2.ShippingLabel(), order2.CalculatePrice());

        Address address3 = new Address("9923 Rue Jean Paul", "Nangis", "BUC", "France");
        Customer customer3 = new Customer("Ben Harlin", address3);
        Order order3 = new Order(customer3);
        order3.AddProduct(product3);
        order3.AddProduct(product3);
        order3.AddProduct(product3);
        order3.AddProduct(product4);
        PrintFullLabel(order3.PackingLabel(), order3.ShippingLabel(), order3.CalculatePrice());
    }

    static void PrintFullLabel(string packLabel, string shipLabel, decimal price) {
        Console.WriteLine(packLabel);
        Console.WriteLine(shipLabel);
        Console.WriteLine($"Total Price: {price:C}\n\n");
    }
}
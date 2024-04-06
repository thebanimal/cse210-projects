using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Fake Street", "False City", "California", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        Product milk = new Product("milk", "123abc", 3.28, 1);
        order1.AddProduct(milk);
        Product apple = new Product("apple", "456def", 1.27, 3);
        order1.AddProduct(apple);
        Product cheese = new Product("cheese", "789123", 2.22, 2);
        order1.AddProduct(cheese);

        order1.CreatePackingLabel();
        order1.CreateShippingLabel();
        Console.WriteLine($"${order1.TotalPrice()}");

        Address address2 = new Address("321 Untrue Street", "Counterfeit Town", "Alberta", "CAN");
        Customer customer2 = new Customer("Jane Doe", address2);
        Order order2 = new Order(customer2);
        Product bannana = new Product("bannana", "abc456", 0.27, 6);
        order2.AddProduct(bannana);
        Product eggs = new Product("eggs", "def789", 2.06, 1);
        order2.AddProduct(eggs);
        Product bread = new Product("bread", "123123", 2.82, 1);
        order2.AddProduct(bread);

        Console.WriteLine("");
        order2.CreatePackingLabel();
        order2.CreateShippingLabel();
        Console.WriteLine($"${order2.TotalPrice()}");
    }
}
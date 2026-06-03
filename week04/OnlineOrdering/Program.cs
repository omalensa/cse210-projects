class Program
{
    static void Main(string[] args)
    {
        // First Order - USA Customer
        Address addr1 = new Address("123 Oak St", "Chicago", "IL", "USA");
        Customer cust1 = new Customer("Maria Garcia", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Wireless Mouse", "M001", 29.99, 2));
        order1.AddProduct(new Product("USB Cable", "C202", 9.99, 3));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: ${order1.CalculateTotal():F2}\n");

        // Second Order - International Customer
        Address addr2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Ahmed Khan", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Laptop", "L505", 899.99, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: ${order2.CalculateTotal():F2}");
    }
}
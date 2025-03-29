using System;

class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer("David", new Address("456 Oak Ave", "Springfield", "Illinois", "USA"));
        Customer c2 = new Customer("Eva", new Address("Avenida Brasil 125", "Rio de Janeiro", "Rio de Janeiro", "Brazil"));
        Customer c3 = new Customer("Frank", new Address("Rua Silva 78", "São Paulo", "São Paulo", "Brazil"));

        List<Order> orders = new List<Order>();
        orders.Add(new Order(c1, new List<Product> { new Product("C# for Beginners", 15, 15, 1), new Product("Java Programming", 18, 20, 1) }));
        orders.Add(new Order(c2, new List<Product> { new Product("Learning Python", 16, 18, 1), new Product("C++ for Experts", 19, 22, 1), new Product("Introduction to Assembly", 14, 16, 1) }));
        orders.Add(new Order(c3, new List<Product> { new Product("JavaScript Mastery", 17, 19, 1), new Product("HTML & CSS for Web Dev", 20, 25, 1) }));

        foreach (Order o in orders)
        {
            Console.WriteLine("=========================================================");
            Console.WriteLine("Packing Label: ");
            Console.WriteLine(o.GetPackingLabel());
            Console.WriteLine("Shipping Label: ");
            Console.WriteLine(o.GetShippingLabel());
            Console.WriteLine("Total Cost: ");
            Console.WriteLine(o.TotalCost());
            Console.WriteLine("Shipping Cost: ");
            Console.WriteLine(o.GetShippingCost());
            Console.WriteLine("=========================================================");
        }
    }
}

using EFCodeFirstSQLServer.Data;
using EFCodeFirstSQLServer.Models;

namespace EFCodeFirstSQLServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            using EFCodeFirstSQLServerDBContext context = new EFCodeFirstSQLServerDBContext();

            Product veggieSpecial = new Product()
            {
                Name = "Veggie Special Pizza",
                Price = 9.99M
            };
            context.Products.Add(veggieSpecial);

            Product deluxeMeat = new Product()
            {
                Name = "Deluxe Meat Pizza",
                Price = 12.99M
            };
            context.Add(deluxeMeat);

            context.SaveChanges();

            var products = context.Products
                                .Where(p => p.Price > 10.00M)
                                .OrderBy(p => p.Name);


            foreach (Product p in products)
            {
                Console.WriteLine($"Id:    {p.Id}");
                Console.WriteLine($"Name:  {p.Name}");
                Console.WriteLine($"Price: {p.Price}");
                Console.WriteLine(new string('-', 20));
            }

            var veggieSpecial1 = context.Products
                                   .Where(p => p.Name == "Veggie Special Pizza")
                                   .FirstOrDefault();

            if (veggieSpecial1 is Product)
            {
                veggieSpecial1.Price = 10.99M;
            }

            context.SaveChanges();
        }
    }
}
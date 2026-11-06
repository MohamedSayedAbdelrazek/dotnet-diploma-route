using System.Collections;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace G_NET68_ADVC__Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> catalog = new()
            {
                new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
                new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
                new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
                new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
                new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
                new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
                new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
                new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
                new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
                new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 }
            };

            Console.WriteLine("--------Electronics---------");
            Product.PrintProducts(Product.SearchProducts(catalog, p => p.Category == "Electronics"));
            Console.WriteLine("\n--------Under 50---------");
            Product.PrintProducts(Product.SearchProducts(catalog, p => p.Price < 50));
            Console.WriteLine("\n--------In Stock---------");
            Product.PrintProducts(Product.SearchProducts(catalog, p => p.Stock > 0));
            Console.WriteLine("\n--------Clothing under $100---------");
            Product.PrintProducts(Product.SearchProducts(catalog, p => p.Category == "Clothing" && p.Price < 100));

            Console.WriteLine("\n--------Short Report---------");
            Product.PrintReport(catalog, p => Console.WriteLine($"{p.Name} - ${p.Price:C}"));
            Console.WriteLine("\n--------Detailed Report---------");
            Product.PrintReport(catalog, p => Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}"));

            Console.WriteLine("\n--------Summary List---------");
            List<string>Summary= Product.TransformProducts(catalog, p => $"{p.Name}({p.Price:C})");
            foreach(string s in Summary)
                Console.WriteLine(s);
            Console.WriteLine("\n--------Price Lables---------");
            List<string> PriceLabels = Product.TransformProducts(catalog, p => p.Price > 100 ? $"{p.Name}: Expensive!" : $"{p.Name}: Affordable");
            foreach(string s in PriceLabels)
                Console.WriteLine(s);

            Console.WriteLine("\n--------Low Stock Alert---------");
            List<Product>LowStockProducts = Product.FilterProducts(catalog, p => p.Stock < 20);
            foreach(Product product in LowStockProducts)
            {
                Console.WriteLine($"[LOW STOCK] {product.Name}: only {product.Stock} left!");
            }
        }
    }
}

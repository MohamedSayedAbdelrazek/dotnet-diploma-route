using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET68_ADVC__Assignment_2
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> predicate)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in products)
            {
                if (predicate(product))
                    result.Add(product);
            }
            return result;
        }

        public override string ToString()
        {
            return $"{Name} - {Price:C} (Stock: {Stock})";
        }

        public static void PrintProducts(List<Product> products)
        {
            foreach (Product product in products)
                Console.WriteLine(product);
        }
        
        public static void PrintReport(List<Product>products,Action<Product>action)
        {
            foreach(Product product in products)
            {
                action(product);
            }
        }

        public static List<string> TransformProducts(List<Product>products,Func<Product,string> fun)
        {
            List<string> result = new List<string>();
            foreach (Product p in products)
                result.Add(fun(p));
            return result;
        }

        public static List<Product> FilterProducts(List<Product> products, Predicate<Product> predicate) 
        { 
            List<Product>result = new List<Product>();
            foreach (Product product in products)
                if (predicate(product))
                    result.Add(product);
            return result;
        }
    }
}

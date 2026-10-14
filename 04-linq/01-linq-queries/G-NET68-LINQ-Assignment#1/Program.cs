using System.Data.Common;
using G_NET68_LINQ_Assignment_1.DataSources;
using G_NET68_LINQ_Assignment_1.Models;
namespace G_NET68_LINQ_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*1. Get all products from the "Seafood" category. Print each
                product's name and price.*/

            //var result = Source.ProductList.Where(product => product.Category == "Seafood").Select(Product => new { Product.ProductName, Product.UnitPrice }).ToList();
            //foreach (var product in result)
            //    Console.WriteLine(product);

            #endregion

            #region Q2
            /*2. Get a list of only the product names from ProductList. Print
                each name.*/

            //var productNames = Source.ProductList.Select(p => p.ProductName).ToList();
            //foreach (var product in productNames)
            //    Console.WriteLine(product);

            #endregion

            #region Q3
            /*3. Sort all products by UnitPrice (ascending). Print each
                product's name and price.*/

            //var result = Source.ProductList.OrderBy(p => p.UnitPrice).Select(p => new { p.ProductName, p.UnitPrice });
            //foreach (var product in result)
            //    Console.WriteLine(product);


            #endregion

            #region Q4
            /*4. Get all products where UnitPrice is between 10 and 30*/

            //var products = Source.ProductList.Where(product => product.UnitPrice is >= 10 and <= 30).ToList();
            //foreach (var product in products)
            //    Console.WriteLine(product);

            #endregion

            #region Q5
            /*5. Get all products that are in stock (UnitsInStock > 0) and
                belong to the "Condiments" category.*/

            //var products = Source.ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            //foreach (var product in products)
            //    Console.WriteLine(product);
            #endregion

            #region Q6
            /*6. Create a new anonymous type with three properties:
                - Name -> the product name
                - Price -> the unit price
                - StockStatus -> a string: "Available" if UnitsInStock > 0,
                  otherwise "Out of Stock"
                - Print the result.*/

            //var result = Source.ProductList.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});

            //foreach (var Product in result)
            //    Console.WriteLine(Product);
            #endregion

            #region Q7
            /*7. Print each product's name along with its position (1-based)
                in the list. Expected format: 1. Chai, 2. Chang, etc.*/
            #endregion

            #region Q8
            /*8. Sort ProductList by Category ascending, then within each
                category, sort by UnitPrice descending.*/
            #endregion

            #region Q9
            /*9. Get all products from the "Beverages" category, sorted by
                UnitsInStock descending. Print name and stock.*/
            #endregion

            #region Q10
            /*10. Using QUERY SYNTAX with a compound from clause, list
                 all orders placed in 1997 or later showing CustomerID and
                 OrderDate.*/
            #endregion

            #region Q11
            /*11. Show position number alongside ProductName*/
            #endregion

            #region Q12
            /*12. Sort first by word length and then by a
                 case-insensitive sort of the words in an array.

                 String[] Arr = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};*/
            #endregion

            #region Q13
            /*13. Create a list of all digits in the array whose second
                 letter is 'i' that is reversed from the order in the
                 original array.*/
            #endregion
        }
    }
}

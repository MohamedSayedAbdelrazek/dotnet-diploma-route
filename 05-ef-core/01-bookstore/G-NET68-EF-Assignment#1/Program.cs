

using G_NET68_EF_Assignment_1.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace G_NET68_EF_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new BookStoreDbContext();

            var category = context.Categories
                        .FirstOrDefault(c => c.Name == "Fantasy");

            if (category is null)
            {
                category = new Category
                {
                    Name = "Fantasy",
                    Description = "Fantasy books",
                    IsActive = true
                };

                context.Categories.Add(category);
                context.SaveChanges();
            }



            if (!context.Books.Any())
            {

                context.Books.AddRange(
                    new Book {
                        Title = "Harry Potter1",
                        ISBN = "111111",
                        InStock = true,
                        Price = 500,
                        NoPages = 400,
                        PublishedYear = 2000,
                        CategoryId = category.Id
                    },
                    new Book {
                        Title = "Harry Potter2",
                        ISBN = "222222",
                        InStock = false,
                        Price = 500,
                        NoPages = 400, 
                        PublishedYear = 2001,
                        CategoryId = category.Id
                    },
                    new Book { 
                        Title = "Harry Potter3",
                        ISBN = "333333", 
                        InStock = true, 
                        Price = 1000, 
                        NoPages = 400,
                        PublishedYear = 2002,
                        CategoryId = category.Id
                    }
                    );

                context.SaveChanges();

            }

            var books = context.Books.Where(b => b.InStock).OrderBy(b => b.Price);

            foreach (var book in books)
                Console.WriteLine($"{book.Title}: {book.Price}");
        }
    }
}

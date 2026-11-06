using G_NET68_EF_Assignment_1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_1
{
    internal class BookStoreDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.; Database=BookStore;Trusted_Connection=True; TrustServerCertificate=true"
                );
        }
       public DbSet<Book> Books { get; set; }
       public  DbSet<Author> Authors { get; set; }
       public  DbSet<Category> Categories { get; set; }
    }
}

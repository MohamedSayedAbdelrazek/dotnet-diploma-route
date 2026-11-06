using G_NET68_EF_Assignment_2.Contexts;
using Microsoft.EntityFrameworkCore;

namespace G_NET68_EF_Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var db = new EventHubDbContext();
            //db.Database.Migrate();

            Console.WriteLine("Doneee");
        }
    }
}

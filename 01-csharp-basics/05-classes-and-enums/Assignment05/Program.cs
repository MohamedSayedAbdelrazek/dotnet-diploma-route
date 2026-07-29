namespace Assignment05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
             Add a private string password = "secret"; field to a Book class. Try to print it from Main
                (outside the class). What happens, and why?
             */

            //Book book = new Book();
            //book.password = "mySecretPassword";
            // The above line will cause a compilation error because the 'password' field is private and cannot be accessed from outside the Book class.
            #endregion

            #region Q2
            /*
             Add an internal int copiesInStock = 5; 
            field to Book. Print it from Main. Does it compile?
            Why?
             */

            //Book book = new Book();
            //book.copiesInStock = 5; 
            // This line will compile successfully because 'copiesInStock' is an internal field and can be accessed from all classes in the same assembly.
            #endregion

            #region Q3
            /*
             Add a public string Title; field to Book. Set it and print it from Main.
             */

            //Book book = new Book();
            //book.Title = "C#";
            //Console.WriteLine($"Book Title: {book.Title}");
            #endregion

        }
    }
}

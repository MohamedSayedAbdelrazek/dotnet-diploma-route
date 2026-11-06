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

            #region Q4
            /*
             Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book,
                assign it Genre.Science, and print it.
             */

            //Book book = new Book();
            //book.genre = Genre.Science;
            //Console.WriteLine($"Book Genre: {book.genre}");
            #endregion

            #region Q5
            /*
             Using the Genre enum above, print the underlying int value of
            Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
             */

            //Console.WriteLine($"Genre.Fiction: {(int)Genre.Fiction}");
            //Console.WriteLine($"Genre.NonFiction: {(int)Genre.NonFiction}");
            //Console.WriteLine($"Genre.Science: {(int)Genre.Science}");

            #endregion

            #region Q6
            /*
             Given int genreNumber = 1;
            , cast it into a Genre value and print the result.
             */

            //int genreNumber = 1;
            //Genre genreValue = (Genre)genreNumber;
            //Console.WriteLine($"Genre value after casting: {genreValue}");
            #endregion

            #region Q7
            /*
             Given Genre genre = Genre.Fiction;
            , convert it into a string using ToString() and print it.
             */

            //Genre genre = Genre.Fiction;
            //Console.WriteLine(genre.ToString());
            #endregion

            #region Q8
            /*
             Given string genreText = "Science";
            , convert it into a Genre value using Enum.Parse() and
            print the result.
             */

            //string genreText = "Science";
            //Genre parsedGenre = (Genre)Enum.Parse(typeof(Genre), genreText);
            //Console.WriteLine($"Parsed Genre: {parsedGenre}");
            #endregion

            #region Q9
            /*
             Given string genreText = "Mystery"; (not a valid Genre value), use Enum.TryParse() to
                attempt the conversion. Print "Unknown genre" if it fails.
             */

            //string genreText = "Fiction";
            //bool isParsed = Enum.TryParse(genreText, out Genre parsedGenre);
            //Console.WriteLine(isParsed? $"Parsed Genre: {parsedGenre}" : "Unknown genre");
            #endregion
        }
    }
}

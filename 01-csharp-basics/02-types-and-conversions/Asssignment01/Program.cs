using System.Security.Cryptography.X509Certificates;

namespace Asssignment01
{
    internal class Book
    {
        public string Title;
        public int Pages;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01 
            //1.Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object.Print it.

            // This class should put inside the namespace Asssignment01 but I put it to be inside the region.

            //internal class Book  
            //{
            //    public string Title;                 
            //    public int Pages; 
            //}

            //object book01 = new Book();
            //Console.WriteLine(book01); // Asssignment01.Book
            //

            #endregion

            #region Question02
            //Book book = new Book();
            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());
            #endregion

            #region Question03
            /*
             Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            int pages = "464";

            Compile-time error — you can't put text (string) into an int variable.
            int pages = 464;
            */
            #endregion
        }
    }
}

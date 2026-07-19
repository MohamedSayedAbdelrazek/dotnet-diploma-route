using System.Drawing;
using System.Runtime.Intrinsics.X86;
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

            #region Question04
            /* 4.Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot
            divide by zero", and then prints "Done" in a finally block.*/

            //int x=10,y= 0;
            //try
            //{
            //    int result = x / y;
            //}
            //catch (DivideByZeroException ex) {
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An error occurred: " + ex.Message);
            //}
            //finally {
            //    Console.WriteLine("Done");
            //}
            #endregion

            #region Question05
            //5.Declare an int pages = 300; then store it in a double variable without using a cast.
            //int pages = 300;
            //double pagesDouble = pages; // Implicit conversion from int to double
            #endregion

            #region Question06
            //6.Declare a double price = 49.99; then convert it into an int using a cast.
            //double price = 44.99;
            //int priceInt = (int)price; // Explicit conversion from double to int
            #endregion

            #region Question07
            // 7.Given string pagesText = "464";, convert it into an int using the Convert class.
            //string pagesText = "464";
            //int pages = Convert.ToInt32(pagesText); // Convert string to int
            #endregion

            #region Question08
            /* 8.Given string yearText = "2023";, convert it using int.Parse(). Then given string badText =
            "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.*/

            //string yearText = "2023";
            //int year = int.Parse(yearText); // Convert string to int using Parse method
            //string badText ="abc";
            //if (int.TryParse(badText, out int result))
            //{
            //    Console.WriteLine($"The converted number: {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}

            #endregion

            #region Question09
            /*Given int pages = 464;, convert it into a string using ToString() and print its type using
            GetType() to prove it's now a string.*/

            //int pages = 464;
            //string pagesText = pages.ToString();
            //Console.WriteLine(pagesText.GetType());
            #endregion


            #region Question10
            /*
             10.Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
             variable, and print both.
             */
            //int copies = 100;
            //object boxedCopies = copies; // Boxing
            //int unboxedCopies = (int)boxedCopies; // Unboxing
            //Console.WriteLine($"Original: {copies}");
            //Console.WriteLine($"Boxed: {boxedCopies}");
            //Console.WriteLine($"Unboxed: {unboxedCopies}");

            #endregion

        }
    }
}

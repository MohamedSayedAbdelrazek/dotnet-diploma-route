using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace Asssignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            /*
            Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle.
            Print both title and upperTitle to show that title did not change.
            */


            //string title = "clean code";
            //string upperTitle = title.ToUpper();

            //Console.WriteLine($"Title: {title}");
            //Console.WriteLine($"Upper Title: {upperTitle}");


            #endregion

            #region Q2
            /*
             * Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
               to check if they point to the same object in memory.
             */

            //string s01 = "Clean Code", s02 = "Clean Code";
            //Console.WriteLine(ReferenceEquals(s01,s02)); // true because of string interning in C#

            #endregion

            #region Q3

            /*
              Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
               object. Print the final result.
             */

            //StringBuilder sb = new ();
            //sb.Append("Book List");
            //sb.Append(" - Updated");
            //Console.WriteLine(sb.ToString());
            #endregion

            #region Q4

            /*
             Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
             Print the result.
             */

            //StringBuilder sb = new();
            //sb.Append("Book List");
            //sb.Append(" - Updated");
            //sb.Replace("Book List", "Library");
            //Console.WriteLine(sb.ToString());
            #endregion

            #region Q5

            /*
             Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
            Pages: 464" using the + operator.
             */

            //string title = "Clean Code";
            //int pages = 464;

            //Console.WriteLine("Book:" + title + ",Pages: " + pages);

            #endregion

            #region Q6
            /*Build the same sentence as above, but using string interpolation ($"...")*/

            //string title = "Clean Code";
            //int pages = 464;

            //Console.WriteLine($"Book: {title}, Pages: {pages}");

            #endregion

            #region Q7
            /* Build the same sentence again, but using string.Format() */

            //string title = "Clean Code";
            //int pages = 464;

            //Console.WriteLine(String.Format("Book: {0}, Pages: {1}", title, pages));
            #endregion

            #region Q8

            /*
             Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
            300, otherwise prints "Short Book".
             */

            //int pages = 464;
            //if(pages > 300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");
            //}

            #endregion

            #region Q9
            /*
             Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
                greater than 300 and isAvailable is true. Use the && operator
             */

            //int pages = 464;
            //bool isAvailable = true;
            //if (pages > 300 && isAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}
            //{
            //    Console.WriteLine("You cannot borrow this book");
            //}


            #endregion

            #region Q10

            /*
             Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is
            "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.
             */

            string title = "Refactoring";

            switch (title) {
                case "Clean Code":
                    Console.WriteLine("Great Choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice Pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion

            #region Q11

            /*
             Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a
            variable sizeLabel (same rule as question 8: long if pages > 300).
             */

           //int pages = 464;
           //string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
           //Console.WriteLine(sizeLabel);

            #endregion



        }
    }
}

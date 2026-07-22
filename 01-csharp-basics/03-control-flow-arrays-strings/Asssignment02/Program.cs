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
        }
    }
}

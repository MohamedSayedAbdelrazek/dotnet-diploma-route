using System.Security.Cryptography;
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
        }
    }
}

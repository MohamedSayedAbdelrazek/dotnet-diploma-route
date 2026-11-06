using System.Security.Cryptography.X509Certificates;

namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
             Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
                the second price (index 1).
             */

            //double[] prices = [25.5, 40.0, 33.75];
            //Console.WriteLine($"Second price: {prices[1]}");

            #endregion

            #region Q2
            /*
             Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
                shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.
             */

            //int[,] shelfCopies = new int [2,2] { { 3, 5 }, { 1, 4 }, };
            //Console.WriteLine($"Number of copies on shelf 1, slot 0: {shelfCopies[1, 0]}");

            #endregion

            #region Q3
            //PrintWelcomeMessage();
            #endregion

            #region Q4
            /*
             Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
                "Clean Code".
             */

            //PrintBookTitle("Clean Code");

            #endregion

            #region Q5

            /*
             Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
                int pages = 400; and print pages afterward. What do you expect to see, and why?
             */

            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine($"Total pages: {pages}");

            // pass by value, so the original variable is not modified
            // The output will be 400 because the AddBonusPages method does not modify the original variable, it only modifies a copy of it.

            #endregion

            #region Q6
            /*
             Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
                with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to
                see, and why?
             */

            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine($"First price after discount: {prices[0]}");
            // The output will be 20.5 because the ApplyDiscount method modifies the first element of the prices array.
            #endregion

            #region Q7
            /*
             Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
                Call it and print pages afterward. How is the result different from question 5?
             */

            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine($"Total pages: {pages}");

            // The output will be 450 because the AddBonusPagesByRef method modifies the original variable Because it is passed by reference.
            #endregion

            #region Q8
            /*
             Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
                new array { 10.0, 12.5, 15.0 }. Call it with your prices array and print prices.Length
                afterward.
             */

            //double[] prices = { 25.5, 40.0 };
            //ReplaceArray(ref prices);
            //Console.WriteLine($"Length of prices array: {prices.Length}");
            #endregion

            #region Q9
            /*
             Write a method bool TryGetPrice(string title, out double price) that returns true and sets
                price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0. Call it and print the price if found
             */

            //string title = "Clean Code";
            //if (TryGetPrice(title, out double price)) {
            //    Console.WriteLine($"Price of {title}: {price}");
            //} else {
            //    Console.WriteLine($"Book not found: {title}");
            //}
            #endregion

            #region Q10
            /*
             Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call
                it once with only a title, and once passing both a title and pages.
             */

            //PrintBookInfo("Clean Code");
            //PrintBookInfo("Clean Code", 352);

            #endregion

            #region Q11
            /*
             Using the PrintBookInfo method from the question above, call it by naming the
                parameters, passing pages before title.
             */

            //PrintBookInfo(pages: 352,title:"Clean Code");
            #endregion

            #region Q12
            /*
             Write a method PrintAllTitles(params string[] titles) that prints each title on its own line.
                Call it with three book titles.
             */

            PrintAllTitles("C#", "PHP", "Java");
            #endregion
        }

        public static void PrintWelcomeMessage() {
            Console.WriteLine("Welcome to the Library!");
        }

        public static void PrintBookTitle(string title) {
            Console.WriteLine($"Book Title: {title}");
        }

        public static void AddBonusPages(int pages) {
            pages += 50;
        }
        public static void ApplyDiscount(double[] prices) {
            prices[0] -= 5;

        }

        public static void AddBonusPagesByRef(ref int pages) { 
            pages += 50;
        }

        public static void ReplaceArray(ref double[] prices) { 
            prices = new double[] { 10.0, 12.5, 15 };
        }

        public static bool TryGetPrice(string title, out double price) {
            switch (title) { 
                case "Clean Code":
                    price = 25.5;
                    return true;
                default:
                    price = 0;
                    return false;
            }
        }

        public static void PrintBookInfo(string title, int pages = 300) {
                Console.WriteLine($"Book Title: {title}, Pages: {pages}");
        }

        public static void PrintAllTitles(params string[] titles)
        {
            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
        }
    }
}

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
    }
}

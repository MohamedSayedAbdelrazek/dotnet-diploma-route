using System.Linq.Expressions;

namespace G_NET68_ADVC__Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];

            ////Print grades
            //grades.ForEach(x => Console.Write($"{x} "));

            ////Print grades count
            //Console.WriteLine($"\ngrades count: {grades.Count}");

            ////First & Last element
            //Console.WriteLine($"First Element: {grades[0]}");
            //Console.WriteLine($"Last Element: {grades[grades.Count-1]}");

            //grades.Sort();
            //Console.WriteLine("After Sorting: ");
            //grades.ForEach(x => Console.Write($"{x} "));

            ////first grade above 90
            //Console.WriteLine($"\nFirst grade above 90 is {grades.Find(x => x > 90)}");

            ////Get all grades below 75
            //List<int> grades_below75 = grades.FindAll(x => x < 75);
            //grades.ForEach(x => Console.Write($"{x} "));

            ////Remove all failing grades
            //grades.RemoveAll(x => x < 75);

            //Console.WriteLine("\nAfter Removing all failed grades");
            //grades.ForEach(x => Console.Write($"{x} "));

            //Console.WriteLine($"\nIs grade 100 exist? {grades.Contains(100)}");

            //List<string> grades_strings = new List<string>();
            //grades.ForEach(x => grades_strings.Add($"Grade: {x}"));
            //Console.WriteLine("All string grades");
            //grades_strings.ForEach(x => Console.WriteLine(x));
            #endregion

            #region Q2

            //SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>()
            //{
            //    { 500, "Ahmed" },
            //    { 200, "Sara" },
            //    { 800, "Ali"  },
            //    { 350, "Mona" }
            //};

            //Console.WriteLine("Leaderboard:");
            //foreach (var player in leaderboard)
            //{
            //    Console.WriteLine($"{player.Key} = {player.Value}");
            //}

            //Console.WriteLine($"\nFirst Key: {leaderboard.First().Key}");
            //Console.WriteLine($"First Value: {leaderboard.First().Value}");

            //Console.WriteLine($"\nScore 500 exists: {leaderboard.ContainsKey(500)}");

            //if (leaderboard.TryGetValue(999, out string name))
            //{
            //    Console.WriteLine($"Player with score 999: {name}");
            //}
            //else
            //{
            //    Console.WriteLine("No player with score 999");
            //}

            //leaderboard.Remove(200);

            //Console.WriteLine("\nAfter removing score 200:");

            //foreach (var player in leaderboard)
            //{
            //    Console.WriteLine($"{player.Key} = {player.Value}");
            //}
            #endregion


            #region Q3

            Dictionary<string,string> Phone_Book = new Dictionary<string,string>();
            Phone_Book["Mohamed"] = "01000000001";

            Phone_Book["Ahmed"] = "01000000002";

            try{
                Phone_Book.Add("Mohamed", "01000000003");
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }

            if(Phone_Book.TryAdd("Ali", "0123564898"))
                Console.WriteLine("Ali's phone added successfully.");
            else
                Console.WriteLine("Failed to add Ali's phone number.");

            // Search for a contact that doesn't exist
            if (Phone_Book.ContainsKey("Khaled"))
            {
                Console.WriteLine("Khaled exists");
            }
            else
            {
                Console.WriteLine("Khaled does not exist");
            }

            // Get a contact with a fallback
            string phone = Phone_Book.GetValueOrDefault("Khaled", "Not Found");
            Console.WriteLine("Khaled's phone: " + phone);

            // Print all Keys on one line
            Console.WriteLine("\nKeys:");
            Console.WriteLine(string.Join(", ", Phone_Book.Keys));

            // Print all Values on another line
            Console.WriteLine("Values:");
            Console.WriteLine(string.Join(", ", Phone_Book.Values));
            #endregion
        }
    }
}

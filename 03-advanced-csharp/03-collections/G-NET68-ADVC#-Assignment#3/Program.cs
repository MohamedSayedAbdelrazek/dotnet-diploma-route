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

        }
    }
}

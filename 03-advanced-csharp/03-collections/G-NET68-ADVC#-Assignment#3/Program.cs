namespace G_NET68_ADVC__Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];

            //Print grades
            grades.ForEach(x => Console.Write($"{x} "));

            //Print grades count
            Console.WriteLine($"\ngrades count: {grades.Count}");

            //First & Last element
            Console.WriteLine($"First Element: {grades[0]}");
            Console.WriteLine($"Last Element: {grades[grades.Count-1]}");

            grades.Sort();
            Console.WriteLine("After Sorting: ");
            grades.ForEach(x => Console.Write($"{x} "));

            //first grade above 90
            Console.WriteLine($"\nFirst grade above 90 is {grades.Find(x => x > 90)}");

            //Get all grades below 75
            List<int> grades_below75 = grades.FindAll(x => x < 75);
            grades.ForEach(x => Console.Write($"{x} "));

            //Remove all failing grades
            grades.RemoveAll(x => x < 75);

            Console.WriteLine("\nAfter Removing all failed grades");
            grades.ForEach(x => Console.Write($"{x} "));

            Console.WriteLine($"\nIs grade 100 exist? {grades.Contains(100)}");

            List<string> grades_strings = new List<string>();
            grades.ForEach(x => grades_strings.Add($"Grade: {x}"));
            Console.WriteLine("All string grades");
            grades_strings.ForEach(x => Console.WriteLine(x));
            #endregion


        }
    }
}

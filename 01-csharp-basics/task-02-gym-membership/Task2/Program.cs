namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member member01 = new Member() ;

            // get member details from user input
            Console.WriteLine("Enter Member Details:");

            // get member Id
            int id;
            bool isParsed;
            do
            {
                Console.Write("Enter Member ID: ");
                isParsed = int.TryParse(Console.ReadLine(), out id);
            }
            while (!isParsed || id<=0);
            member01.Id = id;


            //get member Name
            string name;
            do
            {
                Console.Write("Enter Member Name: ");
                name = Console.ReadLine();
            } while (name == null);
            member01.Name = name;

            // get member Age
            int age;
            do
            {
                Console.Write("Enter Member Age: ");
                isParsed = int.TryParse(Console.ReadLine(), out age);
            } while (!isParsed || age<16 || age>50);
            member01.Age = age;

            // get member Gender
            Gender memGender;
            do
            {
                Console.Write("Choose Gender (1. Male, 2. Female): ");
                isParsed = Enum.TryParse<Gender>(Console.ReadLine(), true, out memGender);
            }
            while (!isParsed || !Enum.IsDefined(typeof(Gender), memGender));
            member01.gender = memGender;

            // get member Membership Type
            MembershipType memType;
            do
            {
                Console.Write("Choose Membership Type (1. Standard, 2. Premium): ");
                isParsed = Enum.TryParse<MembershipType>(Console.ReadLine(), true, out memType);
            }
            while (!isParsed || !Enum.IsDefined(typeof(MembershipType), memType));
            member01.membershipType = memType;

            // calculate membership price based on membership type
            member01.MembershipPrice = member01.membershipType == MembershipType.Standard ? 500 : 700;



            // display member details
            Console.WriteLine("\nMember Details:");
            Console.WriteLine($"ID: {member01.Id}");
            Console.WriteLine($"Name: {member01.Name}");
            Console.WriteLine($"Age: {member01.Age}");
            Console.WriteLine($"Gender: {member01.gender}");
            Console.WriteLine($"Membership Type: {member01.membershipType}");
            Console.WriteLine($"Membership Price: {member01.MembershipPrice}");
        }
    }
}

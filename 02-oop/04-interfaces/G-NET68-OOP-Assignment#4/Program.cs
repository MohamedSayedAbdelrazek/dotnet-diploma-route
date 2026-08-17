namespace G_NET68_OOP_Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Q1 
            //a) What is Abstraction in Object-Oriented Programming?
            //Abstraction is the process of hiding complex implementation details and exposing only the essential features of an object.

            //b) Why is abstraction considered one of the four pillars of OOP?
            //Abstraction is one of the four pillars of OOP because it hides unnecessary implementation details and exposes only the essential features, making complex systems easier to understand and manage.

            #endregion

            #region Part 01 — Q2 
            //a)  What is the difference between an Abstract Class and an Interface?
            /*
             Both abstract classes and interfaces are used to achieve abstraction. 
            An abstract class can contain both abstract and non-abstract members and can have fields and constructors,
            while an interface mainly defines a contract that a class must implement. 
            C# does not support multiple inheritance between classes, but a class can implement multiple interfaces.



            //b)  When would you choose an Interface instead of an Abstract Class?
            /*We choose an Interface when unrelated classes need to follow the same contract or behavior, 
            or when a class needs to implement multiple behaviors through multiple interfaces.
             */

            //
            //C)Can a class inherit from multiple abstract classes? No
            //Can it implement multiple interfaces? Yes
            #endregion


            DeliveryCenter dc = new DeliveryCenter(3);

            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");

            //1. Standard Shipment 
            Console.WriteLine("\nStandard Shipment ");
            Console.Write("Tracking Code: ");
            string stdCode = Console.ReadLine();
            Console.Write("Description: ");
            string stdDesc = Console.ReadLine();
            Console.Write("Estimated Cost: ");
            double estimatedCost = double.Parse(Console.ReadLine());
            StandardShipment standardShipment = new StandardShipment(stdCode, stdDesc, 100, 100, "Cairo", "Cairo", 10);
            dc.AddShipment(standardShipment);
            Console.WriteLine("Shipment Added Successfully.");

            //2. Express Shipment
            Console.WriteLine("\nExpress Shipment ");
            Console.Write("Tracking Code: ");
            string expCode = Console.ReadLine();
            Console.Write("Description: ");
            string expDesc = Console.ReadLine();
            Console.Write("Weight: ");
            double expWeight = double.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            double expFee = double.Parse(Console.ReadLine());
            Console.Write("Extra Fee: ");
            double extraFee = double.Parse(Console.ReadLine());
            DeliveryAddress expAddr = new DeliveryAddress();
            ExpressShipment eship = new ExpressShipment(expCode,expDesc,expWeight,expFee,"Cairo","Cairo",15,extraFee);
            dc.AddShipment(eship);
            Console.WriteLine("Shipment Added Successfully.");

            //3. International Shipment
            Console.WriteLine("\nInternational Shipment");
            Console.Write("Tracking Code: ");
            string intCode = Console.ReadLine();
            Console.Write("Description: ");
            string intDesc = Console.ReadLine();
            Console.Write("Weight: ");
            double intWeight = double.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            double intFee = double.Parse(Console.ReadLine());
            Console.Write("Destination Country: ");
            string country = Console.ReadLine();
            Console.Write("Customs Fee: ");
            double customsFee = double.Parse(Console.ReadLine());
            DeliveryAddress intAddr = new DeliveryAddress();
            InternationalShipment iship = new InternationalShipment(intCode,intDesc,intWeight,intFee,"Egypt","Cairo",15,country,customsFee);
            dc.AddShipment(iship);
            Console.WriteLine("Shipment Added Successfully.");


            dc.PrintAllShipments();

            dc.PrintTrackingStatuses();
            dc.PrintInsuranceValues();

            ITrackable[] shipments_track = { standardShipment, eship, iship };
            IInsurable[] shipments_Insure = { standardShipment, eship, iship };

            foreach(ITrackable track in shipments_track)
                Console.WriteLine(track.GetTrackingStatus());

            foreach(IInsurable insure in shipments_Insure)
                Console.WriteLine(insure.CalculateInsurance());
        }
    }
}

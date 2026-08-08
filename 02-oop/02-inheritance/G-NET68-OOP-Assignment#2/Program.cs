namespace G_NET68_OOP_Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
             Question 1
                Answer the following questions:
                a) What is the difference between a class and a struct?
                b) Why are classes more suitable than structs for large applications?
             */

            //a
            //Inheritance: Classes support inheritance and polymorphism; structs do not (in C#)
            //Structs copy the value by value, class copy the value by reference
            //The struct is a value type data type used to store short-leaved & small data size
            //The class is a reference type data type used to store long-leaved & more large data

            //b
            //Inheritance & polymorphism 
            //multiple parts of the app can share and modify the same object without copying
            //large structs copied on the stack can cause stack overflow
            #endregion

            #region Q2
            /*
             a) Which class is the parent class?
                => Shipment

            b) Which class is the child class? 
                => ExpressShipment

            c) What members are inherited by ExpressShipment? 
                => TrackingCode

            d) Why is inheritance better than duplicating the same code in multiple classes?
                Maintainability => fix a bug once in the parent class, not in every copy
                Consistency => all subclasses behave the same way
                Readability 
             */
            #endregion

            DeliveryCenter dc = new DeliveryCenter(3);

            Console.WriteLine("Enter Delivery Center Name:");
            dc.CenterName = Console.ReadLine();

            //1. Standard Shipment 
            Console.WriteLine("\nStandard Shipment ");
            Console.Write("Tracking Code: ");
            string stdCode = Console.ReadLine();
            Console.Write("Description: ");
            string stdDesc = Console.ReadLine();
            Console.Write("Weight: ");
            double stdWeight = double.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            double stdFee = double.Parse(Console.ReadLine());

            DeliveryAddress stdAddr = new DeliveryAddress();
            StandardShipment sship = new StandardShipment(stdCode, stdDesc, stdWeight, stdFee, stdAddr);
            dc.AddShipment(sship);
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
            ExpressShipment eship = new ExpressShipment(expCode, expDesc, expWeight, expFee, expAddr, extraFee);
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
            InternationalShipment iship = new InternationalShipment(intCode, intDesc, intWeight, intFee, intAddr, country, customsFee);
            dc.AddShipment(iship);
            Console.WriteLine("Shipment Added Successfully.");

            // Print & Search & Remove 
            dc.PrintAllShipments();

            Console.WriteLine("\nEnter Tracking Code to Search:");
            Shipment found = dc[Console.ReadLine()];
            if (found != null)
                Console.WriteLine("Found: " + found.TrackingCode);
            else
                Console.WriteLine("Not found.");

            Console.WriteLine("\nEnter Tracking Code to Remove:");
            string removeCode = Console.ReadLine();
            if (dc.RemoveShipment(removeCode))
                Console.WriteLine("Shipment Removed Successfully.");
            else
                Console.WriteLine("Shipment not found.");

            Console.WriteLine("\nRemaining Shipments:");
            dc.PrintAllShipments();

        }
    }
}

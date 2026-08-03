using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
             a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
             b) What happens when a Customer variable is copied into another variable and one variable modifies the object?
             */

            //a
            //DeliveryAddress da1 = new DeliveryAddress();
            //da1.City = "Cairo";
            //DeliveryAddress da2 = da1; // copy by value
            //da2.City = "Giza";
            //Console.WriteLine(da1.City);
            //// The City for da1 is still Cairo, because it has a different location at memory from da2


            //b
            //Customer c1 = new Customer();
            //c1.Name = "Mo";
            //Customer c2 = c1; // copy by ref, share the same location

            //c2.Name = "Ahmed";
            //Console.WriteLine(c1.Name); // Ahmed
            //// c1&c2 is refer to the same address at heap, so any change will affect on the other.
            #endregion

            #region Q2
            /*
            public class Shipment
            {
            public string Description;
            public double Weight;
            public decimal DeliveryFee;
            }
             a) Identify at least three problems with this design from an encapsulation perspective.
             b) How can private fields and public properties improve this design?
             */

            //a
            //1. No validation — Weight and DeliveryFee are public fields, any code can set them to invalid values
            //2. No read/write control — public fields give everyone full read and write access.
            //3.any change to how the class stores the data...the outer code will affect. 


            //b
            /*
             Private fields hide the actual storage so nothing outside the class can touch them directly.
             Public properties become the only door in/out, and that door can have logic.
             */

            #endregion

            #region Q3
            /*
             Create one DeliveryAddress value, copy it into a second variable, modify the copy, and print both values to prove that
                the original did not change.
             */
            //DeliveryAddress d1 = new DeliveryAddress();
            //DeliveryAddress d2 = d1;
            //d2.City = "Cairo";
            //d2.Street = "Tahreer";
            //d2.BuildingNumber = 1;

            //Console.WriteLine($"d1 Information: {d1.GetFullAddress()}");
            //Console.WriteLine($"d2 Information: {d2.GetFullAddress()}");
            #endregion

            // All other questions are solved inside its files.

            #region Last Part- Last Ques
            /*
             a) Create a DeliveryCenter object.
                b) Ask the user to enter data for three shipments.
                c) Create each Shipment and add it to the DeliveryCenter.
                d) Print the three shipments using the integer indexer.
                e) Ask the user to enter a tracking code.
                f) Search for the shipment using the string indexer.
                g) Print the shipment when found, or print "Shipment not found."
                h) Demonstrate the DeliveryAddress struct copy behavior.
             
             */
            DeliveryCenter deliveryCenter = new DeliveryCenter(3);
            // take the data
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter Shipment {i + 1} data: ");
                Console.WriteLine("TrackingCode: ");
                string? trackingCode = Console.ReadLine();


                Console.WriteLine("Description: ");
                string description = Console.ReadLine();

                Console.WriteLine("Weight: ");
                double weight = double.Parse(Console.ReadLine());

                Console.WriteLine("Delivery Fee: ");
                double deliveryFee = double.Parse(Console.ReadLine());

                DeliveryAddress deliveryAddress = new DeliveryAddress();
                Console.WriteLine("City: ");
                deliveryAddress.City = Console.ReadLine();

                Console.WriteLine("Street: ");
                deliveryAddress.Street = Console.ReadLine();

                Console.WriteLine("Building Number: ");
                deliveryAddress.BuildingNumber = int.Parse(Console.ReadLine());

                Shipment tempShipment = new Shipment(trackingCode, description, weight, deliveryFee, deliveryAddress);

                bool added = deliveryCenter.AddShipment(tempShipment);
                if (!added)
                {
                    Console.WriteLine("Delivery center is full, shipment was not added.");
                }
            }


            // d) print all three shipments using the integer indexer
            Console.WriteLine("\n--- All Shipments ---");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(deliveryCenter[i]);
            }

            // e) ask for a tracking code
            Console.WriteLine("\nEnter a tracking code to search: ");
            string? searchCode = Console.ReadLine();

            // f) search using the string indexer
            Shipment? found = deliveryCenter[searchCode];


            if (found != null)
            {
                Console.WriteLine("Shipment found: ");
                Console.WriteLine(found);
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }

            // h) demonstrate DeliveryAddress struct copy behavior
            Console.WriteLine("\n-Struct Copy-");
            if (deliveryCenter[0] != null)
            {
                DeliveryAddress originalAddress = deliveryCenter[0].Destination;
                DeliveryAddress copiedAddress = originalAddress;             // struct: this copies by VALUE

                copiedAddress.City = "ModifiedCityName";

                Console.WriteLine($"Original address city: {originalAddress.City}");
                Console.WriteLine($"Copied address city (after modification): {copiedAddress.City}");
                Console.WriteLine("Notice the original is unchanged — structs are copied by value, not by reference.");
            } 
            #endregion

        }
    }
}

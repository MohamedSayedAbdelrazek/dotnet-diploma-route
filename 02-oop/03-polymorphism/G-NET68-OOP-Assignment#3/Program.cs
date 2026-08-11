using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_NET68_OOP_Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01-Q1

            /*
             a) What is the difference between Method Overloading and Method Overriding?
            - Method Overloading means having multiple methods with the same name but different signatures, usually within the same class.
            - Method Overriding means a derived class provides a new implementation for an inherited virtual method with the same signature.
             */

            #endregion

            #region Part01-Q1-B
            /*
             b) What is the difference between Static Binding and Dynamic Binding?
             - Static Binding is resolved by the compiler at compile time. It is based on the reference type and is used with non-virtual methods.

             - Dynamic Binding is resolved at runtime by the CLR. It is based on the actual object type and is used with virtual/override methods.
             */
            #endregion

            #region Part01-Q2-A&B&C
            /*
             a) What is the purpose of the sealed keyword when applied to a class?
            - It means that the class cannot be inherited by any other class.
             */

            /*
             b) What is the difference between a sealed class and a sealed method?
            - A sealed class cannot be inherited by any other class.
            - A sealed method cannot be overridden by any derived class.
             */

            /*
             c) Can a sealed method be overridden? Why?
            No, a sealed method cannot be overridden because the sealed keyword prevents further overriding in derived classes.
             */
            #endregion
            //a
            Driver driver = new Driver(10, "Mohamed Sayed", "01000000001");

            //b
            DeliveryCenter deliveryCenter = new DeliveryCenter(3);

            //c
            deliveryCenter.Driver = driver;

            //d
            StandardShipment standardShipment = new StandardShipment("SH01", "standard shipment", 5, 100, "Cairo", "Elshaheed", 15);

            //e
            ExpressShipment expressShipment = new ExpressShipment("SH02", "standard shipment", 5, 100, "Cairo", "Elshaheed", 15, 50);

            //f
            InternationalShipment internationalShipment = new InternationalShipment("SH03", "standard shipment", 5, 100, "Cairo", "Elshaheed", 15, "Egypt", 50);

            //g
            deliveryCenter.AddShipment(standardShipment);
            deliveryCenter.AddShipment(expressShipment);
            deliveryCenter.AddShipment(internationalShipment);

            //h
            deliveryCenter.PrintAllShipments();

            //i
            DeliveryHelper.PrintShipmentDetails(standardShipment);
            DeliveryHelper.PrintShipmentDetails(expressShipment);
            DeliveryHelper.PrintShipmentDetails(internationalShipment);

            //j
            Console.WriteLine("Updating Weight...");
            standardShipment.UpdateWeight(10);
            Console.WriteLine($"Standard Weight: {standardShipment.Weight}");
            expressShipment.UpdateWeight(10, 2);
            Console.WriteLine($"Express Weight: {expressShipment.Weight}");

            //k
            Shipment[] shipments = {
                standardShipment, expressShipment, internationalShipment
            };

            foreach (Shipment shipment in shipments)
            {
                shipment.PrintShipment();
            }

            //l
            // CompletedShipment is sealed, so it cannot be inherited.
            // PriorityInternationalShipment.GenerateCustomsReport() is sealed,
            // so further derived classes cannot override it.
        }
    }
}

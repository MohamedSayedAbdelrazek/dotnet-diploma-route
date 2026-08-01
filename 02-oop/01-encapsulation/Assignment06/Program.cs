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





        }
    }
}

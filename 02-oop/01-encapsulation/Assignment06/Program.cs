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



        }
    }
}

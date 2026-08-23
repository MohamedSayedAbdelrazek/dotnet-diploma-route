namespace G_NET68_OOP_Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01-Q1
            /*
             Q1 Object Copying
                a) What happens when you assign one object variable to another object variable?
                    - For reference types, assigning one object variable to another copies the reference, not the object itself.
                b) Does assigning one object to another create a new object? Explain.
                    - no new object is created, and both variables refer to the same object
                c) What is the difference between copying an object and copying its reference?
                    - Copying an object means creating a new object with copied data,
                      while copying a reference only copies the reference to the existing object, so no new object is created.      
             */
            #endregion

            #region Part01-Q2
            /*
             Q2 Shallow Copy vs Deep Copy

            a) What is a Shallow Copy?
               - A shallow copy creates a new object and copies the values of its fields. For value-type fields, the actual value is copied.
              For reference-type fields, the reference is copied, so both objects refer to the same referenced object.
            
            b) What is a Deep Copy?
               - A deep copy creates a new object and also creates new copies of the referenced objects inside it,
                so the copied object has an independent object graph.

            c) What happens to reference-type members when a Shallow Copy is created?
               - The reference is copied, not the referenced object. 
                Therefore, both the original and copied objects refer to the same reference-type object.

            d) What happens to reference-type members when a Deep Copy is created?
               - A new referenced object is created with the same data, 
                 so the original and copied objects have separate references to separate objects.

            e) Give one situation where Deep Copy would be safer than Shallow Copy.
               - Deep Copy is safer when we want to modify the copied object without affecting the original object.
                For example, when creating an editable copy of a customer's profile, changes to the copied address should not affect the original customer's address.
             */
            #endregion

            #region Part01-Q3
            /*
             Q3 Static Members

                a) What is a static field, and how is it different from an instance field?
                    - A static field belongs to the type itself, not to a specific object. 
                      There is one shared copy of the field that is shared among all instances of that type.

                 b) What is a static method? Can a static method directly access instance members?
                    - A static method belongs to the type and can be called without creating an instance. 
                    A static method cannot directly access instance members because it does not have an object (this) to access them through.

                c) What is a static constructor, and when is it executed?
                    - A static constructor is a special constructor used to initialize static members. 
                      It is executed automatically once for the type, before the type is first used in a way that requires initialization.

                d) What is a static class? Can you create an object from a static class?
                    A static class is a class that cannot be instantiated and can contain only static members.
                    You cannot create an object from a static class.
            */
            #endregion

            #region Part01-Q4

            /*
             Q4 Extension Methods
                a) What is an Extension Method?
                    - Extension methods let you "add" new methods to existing types without modifying the original type or creating a new derived type.

                b) What keyword must be used in the first parameter of an extension method? 
                    - this keyword

                c) Where must an extension method be declared?
                    - Extension methods must be declared as static methods inside a static, non-nested class.

                d) Can an extension method access private members of the class it extends?
                    -   No. An extension method does not become a member of the extended type, 
                        so it cannot directly access its private members.

             */

            #endregion

            #region Part01-Q5
            /*
             Q5 Partial Classes and Partial Methods

                a) What is a Partial Class?
                    - A partial class allows a class to be split across multiple source files. 
                      At compile time, the compiler combines the parts into one type.

                b) Why would a developer split one class into multiple files?
                    - A developer may split a class into multiple files to organize a large class, separate generated code from handwritten code,
                      or allow multiple developers to work on different parts of the same type.

                c) What is a Partial Method?
                    - A partial method is a method declared in one part of a partial type and optionally implemented in another part of that same partial type.

                d) What happens if a declared partial method has no implementation?
                    - For an optional partial method that follows the applicable rules,
                      the compiler can remove the method declaration and calls to it
                      from the compiled code.
             */
            #endregion

            #region Part02-Q1
            //Shipment shipment1 = new StandardShipment("sh01", "description01", 10, 10, "Cairo", "street01", 10);

            //// Reference assignment
            //Shipment shipment2 = shipment1;

            //shipment2.Weight = 50;

            //Console.WriteLine($"shipment1 weight: {shipment1.Weight}");
            //Console.WriteLine($"shipment2 weight: {shipment2.Weight}");

            //// Actual copy
            //Shipment shipment3 = shipment1.CopyShipment();

            //shipment3.Weight = 100;

            //Console.WriteLine($"shipment1 weight: {shipment1.Weight}");
            //Console.WriteLine($"shipment3 weight: {shipment3.Weight}"); 
            #endregion

            #region Part02-Q2
            Shipment shipment1 = new StandardShipment("sh01", "description01", 10, 10, "Cairo", "street01", 10);

            Shipment shipment02 = shipment1.ShallowCopy();

            Console.WriteLine("Before Change");
            Console.WriteLine(shipment1.Destination);
            Console.WriteLine(shipment02.Destination);

            shipment02.Destination.City = "Giza";

            Console.WriteLine("After Change");
            Console.WriteLine(shipment1.Destination);
            Console.WriteLine(shipment02.Destination);
            #endregion
        }
    }
}

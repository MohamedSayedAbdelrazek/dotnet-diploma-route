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


        }
    }
}

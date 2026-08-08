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



        }
    }
}

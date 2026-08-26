namespace G_NET68_ADVC__Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Q1: What is a generic class? Why use generics?

            // A generic class is a class that uses a type parameter, such as T,
            // which is specified when we create an object from the class.
            //
            // We use generics to write a class once and reuse it with different
            // data types without duplicating the same code for each type.

            #endregion

            #region Q2
            //Container<int> container = new(10);
            #endregion

            #region Q3
            // Q3: What are multiple type parameters? Write Pair<TKey,TValue>.

            // Multiple type parameters allow a generic class or method
            // to work with more than one type at the same time.
            // Each type parameter can represent a different data type.

            //Example
            //Pair<string, int> p = new Pair<string,int>("Mohamed", 21);
            //Console.WriteLine($"{p.First} , {p.Second}");


            #endregion

            #region Q4
            //Q4: What is a generic method? Write Swap<T> method.

            // A generic method is a method that uses one or more type parameters.
            // We write the method once, and it can work with different data types
            // without duplicating the same method for each type.

            //string first = "Mohamed", second = "Ahmed";
            //Swap(ref first, ref second);
            //Console.WriteLine($"{first} , {second}");
            #endregion

            #region Q5
            //int[] items = { 1, 5, 6, 17, 2 };
            //int max= Utility.FindMax(items);
            //Console.WriteLine(max);
            #endregion

            #region Q6
            //Q6: What is a generic interface? Write IRepository<T>.

            // A generic interface is an interface that uses one or more type parameters.
            // It is defined once and can be implemented with different types.
            // The implementing class must implement all members of the interface
            // using the specified type.
            #endregion

        }
    }
}

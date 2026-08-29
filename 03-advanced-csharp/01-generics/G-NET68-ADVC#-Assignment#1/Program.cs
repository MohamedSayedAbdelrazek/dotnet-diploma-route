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

            #region Q7
            //Q7: What is the 'struct' constraint? Write an example.
            // we used struct constraint with Generics to ensure that the parameter type must be a value type.

            // Example:
            //public class Container<T> where T : struct {}

            #endregion

            #region Q8
            //Q8: What is the 'class' constraint? Write an example.
            // We used class constraint with Generics to ensure that the parameter type must be a reference type.

            // Example:
            //public class Container<T> where T : class {}
            #endregion

            #region Q9
            //Q9: What is the 'new()' constraint? Write an example.

            // When the new() constraint is used with generics,
            // it means that the type parameter must have an accessible
            // parameterless constructor.

            // Example:
            //public class Container<T> where T : new() {}
            #endregion

            #region Q10
            //Q10: What is the interface constraint? Write an example.

            // When the interface constraint is used with Generic, it means that the type parameter must implement this interface.

            //Example
            //public class Container<T> where T : Icomparable<T> {}
            #endregion

            #region Q11
            //Q11: What is the base class constraint? Write an example.

            // When a base class constraint is used with generics,
            // it means that the type parameter must be the specified base class
            // or must derive from that base class.

            //Example
            //public class Box<T> where T : Animal { public T Value { get; set; } }
            //var b = new Box<Dog>();
            #endregion

            #region Q12
            //Q12: How do you apply multiple constraints? Write an example.

            // We can apply multiple constraints with generics by separating
            // them with commas. The order of some constraints matters.

            //Example

            // public class Box<T> where T : Animal,Icomparable<T>,new() { public T Value { get; set; } }
            //var b = new Box<Dog>();
            #endregion

            #region Q13
            //Q13: What does the 'default' keyword do in generics?

            // The default keyword returns the default value of the type parameter T.
            // It is useful in generic code because we do not know what T will be.

            #endregion

            #region Q15
            //Q15: What is covariance? Explain the 'out' keyword.
            //Covariance allows a generic type with a more derived type to be assigned to a generic type with a less derived type.
            //The out keyword specifies that a generic type parameter is used only as an output. It enables covariance and allows the type parameter to be used in return positions.
            #endregion

            #region Q16
            //Q16: What is contravariance? Explain the 'in' keyword.
            //Contravariance allows a generic type with a less derived type to be assigned to a generic type with a more derived type.
            //The in keyword specifies that a generic type parameter is used only as an input.It enables contravariance and allows the type parameter to be used in parameter positions.
            #endregion

            #region Q17
            //Q17: What is the difference between covariance and contravariance ?
            //Covariance uses the out keyword and applies to output positions.
            //Contravariance uses the in keyword and applies to input positions.
            #endregion
        }
    }
}

namespace CSharpKurs
{
    public class FunWithGenerics3
    {
        /* 
       * Now add a method Add that takes a paramater of type T, adds it at the end of the array of T, and returns the new array.
       * HINT: You will need a temporary variable to hold your existing array.
       */

        public class MyVeryOwnListWithGenericAddMethod<T>
        {
            public T[] List { get; set; }
        }
    }
}
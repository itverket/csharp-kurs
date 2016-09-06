namespace CSharpKurs
{
    public class FunWithGenerics3
    {
        /* 
       * Now we want to add a method that will allow us to add a new element to our array. 
       * To do this, create a new method to the class called 'Add'.
       * The Add method should take a parameter of type T, add it to the end of the array, and return the new array.
       * HINT: You will need a temporary variable to hold your existing array.
       */

        public class MyVeryOwnListWithGenericAddMethod<T>
        {
            public T[] List { get; set; }
        }
    }
}
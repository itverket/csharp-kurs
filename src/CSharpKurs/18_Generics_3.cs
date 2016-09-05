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

            public T[] Add(T addThis)
            {
                var temp = List;
                List = new T[temp.Length + 1];
                for (int i = 0; i < temp.Length; i++)
                {
                    List[i] = temp[i];
                }
                List[temp.Length] = addThis;

                return List;
            }
        }
    }
}
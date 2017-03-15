namespace CSharpKurs
{

    /* 
    * In this next sections we will work with what we call constraint parameters. 
    * This is a way of saying that our generic parameter has to implement some specific functionality
    * In this case we wish to add a SumAll method to our generic class. 
    * However, we can't be sure that all types of objects can be summed, therefore we have to introduce a constraint!
    */

    public class FunWithGenerics4
    {
 

        /* 
         * First, add a Sum() method to the ISummable interface. This should return an int.
         */

        public interface ISummable
        {
        }

        /* 
         * Now add a SumAll() method that returns an int to the generic class we made earlier. 
         * This method should return the total Sum of all the items in the list.
         * It should do this by invoking the Sum() method on each item in the list.
         * Calling Sum() on the elements in the list will lead to a compilation error.
         * To fix this error, add a type constraint to the class that specifies that T should contain the Sum() method.
         * HINT: You add a type constraint with the "where T : " syntax
         */

        public class MyVeryOwnListWithSumAll<T>
        {
            public T[] List { get; set; }

            public T[] Add(T addThis)
            {
                if (List == null)
                {
                    return new T[] {addThis};
                }
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
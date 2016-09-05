namespace CSharpKurs
{
    public class FunWithGenerics4
    {
        /* 
        * In this next sections we will work with what we call constraint parameters. THis is a way of saying that our generic parameter has to implement some specific functionality to be usable.
        * In this case we wish to add a SumAll method to our generic class. However, we can't be sure that all types of objects can be summed, therefore we have to introduce a constraint!
        */

        /* 
         First, add a Sum() method to the ISummable interface. This should return an int.
         */

        public interface ISummable
        {
            
        }

        /* 
         * Now add a SumAll() method that returns an int to the generic class we made earlier. This method should return the total Sum of all the items in the list, by invoking the Sum() method on each item in the list and return the total sum.
         * You will see that this leads to a compilation error. Try to add a type constraint to the class to fix this.
         * HINT: You add a type constraint with the "where T : " syntax
         */

        public class MyVeryOwnListWithSumAll<T> where T : ISummable
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
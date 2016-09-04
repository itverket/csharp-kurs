namespace CSharpKurs
{
    /* 
     * Now we will attempt to solve some exercises where we will have to work with generics. This should be fun!
     * We will attempt to create an implementation of a list that can hold any objects. Almost like 
     * .NETs very own List!
     * 
     * Then we will try to play around with type constraints, meaning we can add more specific methods to
     * our generic class.
     */
    public class FunWithGenerics
    {
        /* 
         * The first task is to make the class MyVeryOwnList take a generic parameter
         */

            //Remove <T> to make test fail
        public class MyVeryOwnListOfGenericType<T>
        {
            
        }

        /* 
         * Now add property that is an array of the generic type parameter called 'list' to the class. We will use this array
         * to hold the elements of our list
         */
         //TODO: HOW TO TEST THIS LÅL
        public class MyVeryOwnListWithGenericArray<T>
        {
            public T[] list { get; set; }
        }

        /* 
         * Now add a method Add that takes a paramater of type T, adds it at the end of the array of T, and returns the new array.
         * HINT: You will need a temporary variable to hold your existing array.
         */
        public class MyVeryOwnListWithGenericAddMethod<T>
        {
            public T[] list { get; set; }

            public T[] Add(T addThis)
            {
                var temp = list;
                list = new T[temp.Length + 1];
                for (int i = 0; i < temp.Length; i++)
                {
                    list[i] = temp[i];
                }
                list[temp.Length] = addThis;

                return list;
            }
        }

        /* 
         * In this next sections we will work with what we call constraint parameters. THis is a way of saying that our generic parameter has to implement some specific functionality to be usable.
         * In this case we wish to add a SumAll method to our generic class. However, we can't be sure that all types of objects can be summed, therefore we have to introduce a constraint!
         */

        /* 
         * First, create an interface called ISummable that has one method called Sum that takes no parameters and returns an int.
         */
        public interface ISummable
        {
            int Sum();
        }

        /* 
         * Now add a SumAll() method to the generic class we made earlier. You will see that this leads to a compilation error. Try to add a type constraint to the class to fix this.
         * HINT: You add a type constraint with the "where T : " syntax
         */
        public class MyVeryOwnListWithSumAll<T> where T : ISummable
        {
            public T[] list { get; set; }

            public T[] Add(T addThis)
            {
                if (list == null)
                {
                    return new T[] { addThis };
                }
                var temp = list;
                list = new T[temp.Length + 1];
                for (int i = 0; i < temp.Length; i++)
                {
                    list[i] = temp[i];
                }
                list[temp.Length] = addThis;

                return list;
            }

            public int SumAll()
            {
                var sum = 0;

                foreach (var item in list)
                {
                    sum += item.Sum();
                }

                return sum;
            }
        }

    }
}

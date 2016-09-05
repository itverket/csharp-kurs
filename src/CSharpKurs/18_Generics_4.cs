namespace CSharpKurs
{
    public class FunWithGenerics4
    {
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
                    return new T[] {addThis};
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
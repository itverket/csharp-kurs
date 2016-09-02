
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CSharpKurs
{
    /*
    Try to solve the following tasks in one line, using linq.
     */
    public class ManipulateCollections
    {
        /*
        Given a e.g. {"Keep", "It", "Stupid", "Simple"} as input, 
        should return a new list with the following {"K", "I", "S", "S"}
        */
        public List<string> FirstCharacterOfEachString(IEnumerable<string> listOfStrings)
        {
            return listOfStrings.Select(x => x.Substring(0, 1)).ToList();
        }


        /*
        Given a list of strings, e.g. {"Anders", "Michael", "John", "Anna", "Julie"}
        should return a new list containing only the once starting with A, in this
        example {"Anders", "Anna"} should be retruned
         */
        public List<string> FilterElementsStartingWithA(IEnumerable<string> listOfStrings)
        {
            return listOfStrings.Where(x => x[0] == 'A').ToList();
        }

        /*
        Given a list of strings, {"Anders", "Ole", "Kato"},
        should return the list sorted by length {"Ole", "Kato", "Anders"} 
        */
        public List<string> OrderByLengthOfStrings(IEnumerable<string> listOfStrings)
        {
            return listOfStrings.OrderBy(x => x.Length).ToList();
        }

        /*
        Given a list of integers {1, 2, 3, 4, 5, 6, 7, 8}
        return the average of all the even numbers.
        In this case 5.
        */
        public double GetAverageOfAllEvenNumbers(IEnumerable<int> listOfInt)
        {
            return listOfInt.Where(i => i%2 == 0).Average();
        }

    }
}
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpKurs
{
    public class Iterators
    {
        /*
         * Use "yield return" to return numbers from 0 to 9 in sequence. 
         * This methos returns an IEnumerator. 
         */
        public IEnumerator<int> ReturnNumbersFromZeroToNineEnumerator()
        {
            return null;
        }

        /*
        * Use "yield return" to return numbers from 0 to 9 in sequence. 
        * This methos returns an IEnumerable. 
        */
        public IEnumerable<int> ReturnNumbersFromZeroToNineEnumerable()
        {
            return null;
        }

        /*
         * The implementation for the two previous tasks should be equal.
         * In this task you will see the difference between the interfaces. 
         * Return the elements in both the enumerator and the enumerable.
         * Hint: use MoveNext for the enumerator and foreach for the enumerable,
         * and yield return for the result. 
         */

        public IEnumerable<string> ReturnAllElements(IEnumerator<string> enumerator, IEnumerable<string> enumerable)
        {
            return Enumerable.Empty<string>();
        }

        /*
         * Complete this implementation so that it is possible to enumerate this class
         */ 
        public class DaysOfTheWeek : IEnumerable<string>
        {
            string[] days = { "Sun", "Mon", "Tue", "Wed", "Thr", "Fri", "Sat" };          

            public IEnumerator<string> GetEnumerator()
            {
                return null;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        /*
         * Iterate the class from last task. 
         * Use yield return to return the days until Thursday.         *          * 
         */
        public IEnumerable<string> GetDaysUntilThursday(DaysOfTheWeek days)
        {
            return Enumerable.Empty<string>();
        }

        /*
         * Add one item to the collection and return it.  
         * Hint: use ToList()
         */ 
        public IEnumerable<decimal> AddOneItem(IEnumerable<decimal> numbers)
        {
            return numbers;
        }

    }
}

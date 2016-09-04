using System;
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
            for (var i = 0; i < 10; i++)
            {
                yield return i;
            }
        }

        /*
        * Use "yield return" to return numbers from 0 to 9 in sequence. 
        * This methos returns an IEnumerable. 
        */
        public IEnumerable<int> ReturnNumbersFromZeroToNineEnumerable()
        {
            for (var i = 0; i < 10; i++)
            {
                yield return i;
            }
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
            while (enumerator.MoveNext())
            {
                yield return enumerator.Current;
            }

            foreach (var item in enumerable)
            {
                yield return item;
            }
        }

        /*
         * Complete this implementation so that it is possible to enumerate this class
         */ 
        public class DaysOfTheWeek : IEnumerable<string>
        {
            string[] days = { "Sun", "Mon", "Tue", "Wed", "Thr", "Fri", "Sat" };
            int position = -1;


            public IEnumerator<string> GetEnumerator()
            {
                return days.AsEnumerable().GetEnumerator();
            }

            public void Reset()
            { position = 0; }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();

            }

            public object Current
            {
                get { return days[position]; }
            }
        }

        /*
         * Iterate the class from last task. 
         * Use yield return to return the days until Thursday.         *          * 
         */
        public IEnumerable<string> GetDaysUntilThursday(DaysOfTheWeek days)
        {
            return days.TakeWhile(day => day != "Thr" && day != "Fri" && day != "Sat");
        }

        /*
         * Add one item to the collection and return it.  
         * Hint: use ToList()
         */ 
        public IEnumerable<decimal> AddOneItem(IEnumerable<decimal> numbers)
        {
            var list = numbers.ToList();
            list.Add(1);
            return list;
        }

    }
}

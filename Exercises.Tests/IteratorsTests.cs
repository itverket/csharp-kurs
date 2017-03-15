using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CSharpKurs.TestMethods
{
    [TestClass]
    public class IteratorsTestMethods
    {
        private Iterators _iterators;

        [TestInitialize]
        public void SetUp()
        {
            _iterators = new Iterators();
        }

        [TestMethod]
        public void ReturnNumbersFromZeroToNineEnumerator_should_return_numbers_0_to_9()
        {
            var iterator = _iterators.ReturnNumbersFromZeroToNineEnumerator();
            var result = "";
            while(iterator.MoveNext())
            {
                result += $"{iterator.Current}";
            }
            Assert.AreEqual("0123456789", result);
        }

        [TestMethod]
        public void ReturnNumbersFromZeroToNineEnumerable_should_return_numbers_0_to_9()
        {
            var iterator = _iterators.ReturnNumbersFromZeroToNineEnumerable();
            var result = "";
            foreach(var num in iterator)
            {
                result += $"{num}";
            }
            Assert.AreEqual("0123456789", result);
        }

        [TestMethod]
        public void ReturnAllElements_should_return_all_elements()
        {
            var result = _iterators.ReturnAllElements(new[] { "DO", "YOU" }.Cast<string>().GetEnumerator(), new[] { "EVEN", "C#" });

            var name = string.Join(" ", result);
            Assert.AreEqual("DO YOU EVEN C#", name.Trim());            
        }

        [TestMethod]
        public void DaysOfTheWeek_should_be_possible_to_iterate()
        {
            var days = new Iterators.DaysOfTheWeek();
            days.ToList();
            Assert.AreEqual(7, days.Count());
        }

        [TestMethod]
        public void GetDaysUntilThursday_should_return_days_until_thursday()
        {
            var result = _iterators.GetDaysUntilThursday(new Iterators.DaysOfTheWeek());
            var days = string.Join("", result);
            Assert.AreEqual("SunMonTueWed", days);
        }

        [TestMethod]
        public void AddOneItem_should_add_one_item()
        {
            var result = _iterators.AddOneItem(new List<decimal> { 1m, 2m });
            Assert.AreEqual(3, result.Count());
        }
    }
}

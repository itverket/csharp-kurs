using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

namespace CSharpKurs.Test
{
    [TestFixture]
    public class ManipulateCollectionsTests
    {

        private readonly ManipulateCollections _task = new ManipulateCollections();


        [Test]
        public void Should_change_elements_to_be_only_first_character()
        {
            IEnumerable<string> listOfStrings = new List<string> {"Keep", "It", "Stupid", "Simple"};
            Assert.AreEqual(_task.FirstCharacterOfEachString(listOfStrings).Aggregate((x, y) => x + y), "KISS");
        }

        [Test]
        public void Should_contain_only_elements_starting_with_A()
        {
            IEnumerable<string> listOfStrings = new List<string> { "Anders", "Michael", "John", "Anna", "Julie"};
            var result = _task.FilterElementsStartingWithA(listOfStrings);
            Assert.That(result, Contains.Item("Anders"));
            Assert.That(result, Contains.Item("Anna"));
            Assert.That(result.Count, Is.EqualTo(2));
        }

        [Test]
        public void Should_order_by_length()
        {
            IEnumerable<string> listOfStrings = new List<string> {"Anders", "Ole", "Kato"};
            var result = _task.OrderByLengthOfStrings(listOfStrings);

            Assert.AreEqual(result[0], "Ole");
            Assert.AreEqual(result[1], "Kato");
            Assert.AreEqual(result[2], "Anders");
        }



    }
}
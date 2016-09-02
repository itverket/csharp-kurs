using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

namespace CSharpKurs.Tests
{
    [TestFixture]
    public class ManipulateCollectionsTests
    {

        private readonly ManipulateCollections _task = new ManipulateCollections();
        private readonly ManipulateCollectionsAdvanced _task2 = new ManipulateCollectionsAdvanced();


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

        [Test]
        public void Should_return_avrage_of_even_numbers()
        {
            var listOfDigits = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Assert.That(_task.GetAverageOfAllEvenNumbers(listOfDigits), Is.EqualTo(6));
        }

        [Test]
        public void Should_get_person_older_than20_storted_by_height()
        {
            var filteredPersons = _task2.PersonsOlderThan20SortedByHeight(TestData.TestPersons);

            Assert.That(filteredPersons[0].Name, Is.EqualTo("Ole"));
            Assert.That(filteredPersons[1].Name, Is.EqualTo("Kato"));
        }


        [Test]
        public void Should_correlate_person_with_dog_on_dogId()
        {
            var personsWithDogNames = _task2.PersonsWithDogs(TestData.TestPersons, TestData.TestDogs);

            Assert.That(personsWithDogNames[0].Name, Is.EqualTo("Anders"));
            Assert.That(personsWithDogNames[0].DogName, Is.EqualTo("Alex"));

            Assert.That(personsWithDogNames[1].Name, Is.EqualTo("Kato"));
            Assert.That(personsWithDogNames[1].DogName, Is.EqualTo("Bota"));
        }

        [Test]
        public void Should_add_one_to_each_int()
        {
            var listOfInts = new List<int> {1, 2, 3, 4};

            var result = _task2.Add1TooAll(listOfInts);

            Assert.That(result[0], Is.EqualTo(2));
            Assert.That(result[1], Is.EqualTo(3));
            Assert.That(result[2], Is.EqualTo(4));
            Assert.That(result[3], Is.EqualTo(5));
        }
    }
}
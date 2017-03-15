using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CSharpKurs.TestMethods
{
    [TestClass]
    public class ManipulateCollectionsTestMethods
    {

        private readonly ManipulateCollections _task = new ManipulateCollections();
        private readonly ManipulateCollectionsAdvanced _task2 = new ManipulateCollectionsAdvanced();


        [TestMethod]
        public void Should_change_elements_to_be_only_first_character()
        {
            IEnumerable<string> listOfStrings = new List<string> {"Keep", "It", "Stupid", "Simple"};
            Assert.AreEqual(_task.FirstCharacterOfEachString(listOfStrings).Aggregate((x, y) => x + y), "KISS");
        }

        [TestMethod]
        public void Should_contain_only_elements_starting_with_A()
        {
            IEnumerable<string> listOfStrings = new List<string> { "Anders", "Michael", "John", "Anna", "Julie"};
            var result = _task.FilterElementsStartingWithA(listOfStrings);
            Assert.IsTrue(result.Contains("Anders"));
            Assert.IsTrue(result.Contains("Anna"));
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void Should_order_by_length()
        {
            IEnumerable<string> listOfStrings = new List<string> {"Anders", "Ole", "Kato"};
            var result = _task.OrderByLengthOfStrings(listOfStrings);

            Assert.AreEqual(result[0], "Ole");
            Assert.AreEqual(result[1], "Kato");
            Assert.AreEqual(result[2], "Anders");
        }

        [TestMethod]
        public void Should_return_avrage_of_even_numbers()
        {
            var listOfDigits = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Assert.AreEqual(6, _task.GetAverageOfAllEvenNumbers(listOfDigits));
        }

        [TestMethod]
        public void Should_get_person_older_than20_storted_by_height()
        {
            var filteredPersons = _task2.PersonsOlderThan20SortedByHeight(TestMethodData.TestMethodPersons);

            Assert.AreEqual("Ole", filteredPersons[0].Name);
            Assert.AreEqual("Kato", filteredPersons[1].Name);
        }


        [TestMethod]
        public void Should_correlate_person_with_dog_on_dogId()
        {
            var personsWithDogNames = _task2.PersonsWithDogs(TestMethodData.TestMethodPersons, TestMethodData.TestMethodDogs);

            Assert.AreEqual("Anders", personsWithDogNames[0].Name);
            Assert.AreEqual("Alex", personsWithDogNames[0].DogName);

            Assert.AreEqual("Kato", personsWithDogNames[1].Name);
            Assert.AreEqual("Bota", personsWithDogNames[1].DogName);
        }

        [TestMethod]
        public void Should_add_one_to_each_int()
        {
            var listOfInts = new List<int> {1, 2, 3, 4};

            var result = _task2.Add1TooAll(listOfInts);

            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(3, result[1]);
            Assert.AreEqual(4, result[2]);
            Assert.AreEqual(5, result[3]);
        }
    }
}
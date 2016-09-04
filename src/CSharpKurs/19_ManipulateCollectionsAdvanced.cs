using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpKurs
{
    public class ManipulateCollectionsAdvanced
    {




        /*
        Given a list of Persons, get all that are older than 25 years old, and sort them by height.
         */
        public List<Person> PersonsOlderThan20SortedByHeight(IEnumerable<Person> listOfPersons)
        {
            return new List<Person>();
        }

        /*
        Given a list of integers, add 1 to all of them. Do this in one line, no for loops!
         */
        public List<int> Add1TooAll(IEnumerable<int> listOfInts)
        {
            return new List<int>();
        }


        /*
        Given a list of Persons, and a list of Dogs, return a new list of Persons with DogNames.
        The person with dogId = 1 should have the dog with the same Id.    
         */

        public List<Person> PersonsWithDogs(List<Person> persons, List<Dog> dogs)
        {
            return new List<Person>();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int DogId { get; set; }
        public string DogName { get; set; }

    }

    public class Dog
    {
        public string Name { get; set; }
        public int DogId { get; set; }
    }
}


using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CSharpKurs
{
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
        Given a list of Persons, get all that are older than 25 years old, and sort them by height.
         */
        public List<Person> PersonsOlderThan20SortedByHeight(IEnumerable<Person> listOfPersons)
        {
            return listOfPersons
                .Where(p => p.Age > 25)
                .OrderBy(p => p.Height).ToList();
        }

        /*
        Given a list of integers, add 1 to all of them. Do this in one line, no for loops!
         */
        public List<int> Add1TooAll(IEnumerable<int> listOfInts)
        {
            return listOfInts.Select(i => i + 1).ToList();
        }


        /*
        Given a list of Persons, and a list of Dogs, return a new list of Persons with DogNames.
        The person with dogId = 1 should have the dog with the same Id.    
         */

        public List<Person> PersonsWithDogs(List<Person> persons, List<Dog> dogs)
        {
            return persons
                    .Where(p => dogs.Any(d => d.DogId == p.DogId))
                    .Select(p =>
                    {
                        p.DogName = dogs.First(d => d.DogId == p.DogId).Name;
                        return p;
                    })
                    .ToList();
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
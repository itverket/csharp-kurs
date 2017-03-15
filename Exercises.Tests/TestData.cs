using System.Collections.Generic;

namespace CSharpKurs.TestMethods
{
    public class TestMethodData
    {
        public static List<Person> TestMethodPersons => new List<Person>
        {
            new Person
            {
                Name = "Anders",
                Age = 25,
                Height = 185,
                Weight = 70,
                DogId = 1
            },
            new Person
            {
                Name = "Kato",
                Age = 28,
                Height = 195,
                Weight = 90,
                DogId = 2
            },
            new Person
            {
                Name = "Ole",
                Age = 28,
                Height = 192,
                Weight = 110
            },
            new Person
            {
                Name = "John",
                Age = 22,
                Height = 192,
                Weight = 60
            }

        };

        public static List<Dog> TestMethodDogs => new List<Dog>
        {
            new Dog
            {
                Name = "Alex",
                DogId = 1
            },
            new Dog
            {
                Name = "Bota",
                DogId = 2
            },
            new Dog
            {
                Name = "Beef",
                DogId = 3
            },
            new Dog
            {
                Name = "Hendricks",
                DogId = 4
            }
        };
    }
}
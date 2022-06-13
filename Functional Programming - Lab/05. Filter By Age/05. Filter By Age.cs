using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Person
    {
        public Person(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }

        public int Age { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ReadInputPeople();
            List<Person> filteredListOfPeople = FilterListByCondition(people);
            PrintListOfPeopleBYFormating(filteredListOfPeople);
        }
        private static void PrintListOfPeopleBYFormating(List<Person> people)
        {
            string format = Console.ReadLine();
            if (format == "name age")
            {
                foreach (var person in people)
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
            }
            else if (format == "name")
            {
                foreach (var person in people)
                {
                    Console.WriteLine(person.Name);
                }
            }
            else if (format == "age")
            {
                foreach (var person in people)
                {
                    Console.WriteLine(person.Age);
                }
            }
        }

        private static List<Person> FilterListByCondition(List<Person> people)
        {
            string condition = Console.ReadLine();
            int conditionAge = int.Parse(Console.ReadLine());
            var filteredList = new List<Person>();
            if (condition == "younger")
            {
                filteredList = people.Where(x => x.Age < conditionAge).ToList();
            }
            else if (condition == "older")
            {
                filteredList = people.Where(x => x.Age >= conditionAge).ToList();
            }

            return filteredList;
        }

        private static List<Person> ReadInputPeople()
        {
            int n = int.Parse(Console.ReadLine());
            var people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var age = int.Parse(tokens[1]);
                people.Add(new Person(name, age));
            }
            return people;
        }
    }
}

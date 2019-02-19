using System;
using System.Collections.Generic;

namespace Problem6.StrategyPattern
{
    public class Program
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());

            SortedSet<Person> sortByName= new SortedSet<Person>(new PersonLenghtComperar());
            SortedSet<Person> sortedByAge= new SortedSet<Person>(new PersonAgeComperar());
            for (int i = 0; i < linesCount; i++)
            {
                string[] personValues = Console.ReadLine()
                    .Split();
                string name = personValues[0];
                int age = int.Parse(personValues[1]);

                Person person= new Person(name,age);
                sortByName.Add(person);
                sortedByAge.Add(person);
            }

            foreach (var person in sortByName)
            {
                Console.WriteLine(person);
            }

            foreach (var person in sortedByAge)
            {
                Console.WriteLine(person);
            }
        }
    }
}

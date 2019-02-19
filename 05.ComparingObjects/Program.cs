using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            List<Person> people = new List<Person>();

            while (input != "END")
            {
                string[] personsValues=input.Split();

                string name = personsValues[0];
                int age = int.Parse(personsValues[1]);
                string town = personsValues[2];

                Person person = new Person(name,age,town);
                    people.Add(person);
                input = Console.ReadLine();
            }

            int personNum = int.Parse(Console.ReadLine());

            Person currentPerson = people[personNum - 1];
            int equalPeople = 0;
            int diffrentPeople = 0;
            for (int pers = 0; pers < people.Count; pers++)
            {
                if (currentPerson.CompareTo(people[pers]) == 0)
                {
                    equalPeople++;
                }
                else
                {
                    diffrentPeople++;
                }
            }

            if (equalPeople > 1)
            {
                Console.WriteLine($"{equalPeople} {diffrentPeople} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}

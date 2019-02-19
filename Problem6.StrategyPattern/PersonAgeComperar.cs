using System;
using System.Collections.Generic;
using System.Text;

namespace Problem6.StrategyPattern
{
    public class PersonAgeComperar : IComparer<Person>
    {
        public int Compare(Person firsPerson, Person secondPerson)
        {
            return firsPerson.Age - secondPerson.Age;
        }
    }
}

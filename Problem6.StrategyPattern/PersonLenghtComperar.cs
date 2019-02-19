using System;
using System.Collections.Generic;
using System.Text;

namespace Problem6.StrategyPattern
{
    public class PersonLenghtComperar : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person seconPerson)
        {
            int nameLengthResult = firstPerson.Name.Length.CompareTo(seconPerson.Name.Length);
            if (nameLengthResult==0)
            {
                return firstPerson.Name.ToLower()[0].CompareTo(seconPerson.Name.ToLower()[0]);
            }

            return nameLengthResult;
        }
    }
}

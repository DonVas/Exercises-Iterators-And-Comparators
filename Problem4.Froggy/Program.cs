using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem4.Froggy
{
    public class Program
    {
        public static void Main()
        {
            List<int> stoneValus = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToList();
            Lake lake=new Lake(stoneValus.ToArray());

            Console.WriteLine(string.Join(", ",lake));
        }
    }
}

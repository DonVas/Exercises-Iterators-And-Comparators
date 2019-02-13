using System;
using System.Linq;

namespace Problem3.Stack
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            CustomStack<int> stack = new CustomStack<int>();
            while (input != "END")
            {
                string[] tokensi = input
                    .Split(" ",2);
                string tokens = tokensi[0];
                if (tokens == "Push")
                {
                    int[] numbers = tokensi[1]
                        .Split(", ")
                        .Select(int.Parse)
                        .ToArray();
                    stack.Push(numbers);
                }
                else if (tokens == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                }
               
                input = Console.ReadLine();
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var num in stack)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}

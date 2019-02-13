using System;
using System.Linq;

namespace Problem1.ListyIterator
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            ListyIterator<string> listyIterator =null;
            while (input!="END")
            {
                string[] tokens = input
                    .Split();
                if (tokens[0]=="Create")
                {
                    listyIterator= new ListyIterator<string>(tokens.Skip(1).ToList());
                }
                else if (tokens[0] == "Move")
                {
                    Console.WriteLine(listyIterator.Move());
                }
                else if (tokens[0] == "Print")
                {
                    Console.WriteLine(listyIterator.Print());
                }
                else if (tokens[0] == "HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext());
                }
                else if (tokens[0] == "PrintAll")
                {
                    Console.WriteLine(string.Join(" ",listyIterator));
                }

                input = Console.ReadLine();
            }
        }
    }
}

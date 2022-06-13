using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine($"{numbers.Count()}\n{numbers.Sum()}") ;
        }
    }
}

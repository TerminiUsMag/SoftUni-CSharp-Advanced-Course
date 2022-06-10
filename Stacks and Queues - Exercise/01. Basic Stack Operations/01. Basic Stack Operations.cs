using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stak = new Stack<int>();
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = input[0];
            int s = input[1];
            int x = input[2];

            input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < n; i++)
            {
                stak.Push(input[i]);
            }
            for (int j = 0; j < s; j++)
            {
                stak.Pop();
            }
            if (stak.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stak.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stak.Min());
            }
        }
    }
}

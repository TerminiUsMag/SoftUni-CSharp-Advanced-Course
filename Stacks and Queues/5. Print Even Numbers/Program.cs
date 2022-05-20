using System;
using System.Collections.Generic;
using System.Linq;


namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var evenNumbers = new Queue<int>();

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    evenNumbers.Enqueue(intArray[i]);
                }
            }
            Console.WriteLine(String.Join(", ", evenNumbers));
        }
    }
}

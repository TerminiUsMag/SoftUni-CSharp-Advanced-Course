using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();

            list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).OrderByDescending(x => x).ToList();

            for (int i = 0; i < 3; i++)
            {
                if (i < list.Count)
                {
                    Console.Write(list[i] + " ");
                }
            }

        }
    }
}

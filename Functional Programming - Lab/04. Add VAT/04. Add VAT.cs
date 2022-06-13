using System;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine(string.Join('\n',Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .Select(x=>x*1.20m)
                .Select(x=>Math.Round(x,2)
                ))
                );
        }
    }
}

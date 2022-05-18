using System;
using System.Collections.Generic;

namespace _1._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<char>();

            string input = Console.ReadLine();

            foreach(var ch in input)
            {
                stack.Push(ch);
            }

            foreach(var ch in stack)
            {
                Console.Write(ch);
            }
        }
    }
}

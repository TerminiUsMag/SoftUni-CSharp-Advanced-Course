using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stak = new Stack<char>();

            char[] input = Console.ReadLine().ToCharArray();

            for(int i = 0; i < input.Length; i++)
            {
                stak.Push(input[i]);
            }
            char lastCh = stak.Pop();
            char currCh = ' ';
            for(int i = 0; i < input.Length; i++)
            {
                if (i != 0) lastCh = currCh;

               currCh = stak.Pop();

            }
        }
    }
}

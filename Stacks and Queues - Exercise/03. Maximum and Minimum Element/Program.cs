using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stak = new Stack<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] cmd = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                switch (cmd[0])
                {
                    case 1:
                        int x = cmd[1];
                        stak.Push(x);
                        break;
                    case 2:
                        stak.Pop();
                        break;
                    case 3:
                        if(stak.Count>0)
                            Console.WriteLine(stak.Max());
                        break;
                    case 4:
                        if (stak.Count > 0)
                            Console.WriteLine(stak.Max());
                        break;
                }
            }

            Console.WriteLine(String.Join(", ",stak));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var expression = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            expression = expression.Reverse().ToArray();

            var stack = new Stack<string>(expression);

            while (stack.Count > 1)
            {
                int n1 = int.Parse(stack.Pop());
                string op = stack.Pop();
                int n2 = int.Parse(stack.Pop());

                if (op == "+")
                {

                    stack.Push((n1 + n2).ToString());
                }
                else if (op == "-")
                {
                    stack.Push((n1 - n2).ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}

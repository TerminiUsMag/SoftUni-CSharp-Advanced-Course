using System;
using System.Collections.Generic;
using System.Linq;


namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();

            string expression = Console.ReadLine();

            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];

                if (c == '(')
                {
                    stack.Push(i);
                }
                if (c == ')')
                {
                    int startIndex = stack.Pop();
                    int endIndex = i;
                    string subExpression = expression.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(subExpression);
                }
            }


        }
    }
}

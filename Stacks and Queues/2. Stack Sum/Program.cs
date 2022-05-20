using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var stack = new Stack<int>(elements);

            string command;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {

                var commandTokens = command.Split(' ');
                if (commandTokens[0] == "add")
                {
                    int n1 = int.Parse(commandTokens[1]);
                    int n2 = int.Parse(commandTokens[2]);
                    stack.Push(n1);
                    stack.Push(n2);
                }
                else if (commandTokens[0] == "remove")
                {
                    int count = int.Parse(commandTokens[1]);
                    if (stack.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");

        }
    }
}

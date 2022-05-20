using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Paid")
                {
                    int queueCount = queue.Count;
                    for (int i = 0; i < queueCount; i++)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else if (command == "End")
                {
                    Console.WriteLine($"{queue.Count} people remaining.");
                    break;
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
        }
    }
}

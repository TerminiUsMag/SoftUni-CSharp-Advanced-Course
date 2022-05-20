using System;
using System.Collections.Generic;
using System.Linq;


namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var queue = new Queue<string>();

            int carsPassed = 0;
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (1 <= queue.Count)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            carsPassed++;
                        }
                    }
                }
                else if (command == "end") break;
                else
                {
                    queue.Enqueue(command);
                }
            }
            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}

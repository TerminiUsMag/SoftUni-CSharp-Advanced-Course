using System;
using System.Collections.Generic;
using System.Linq;


namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));

            int n = int.Parse(Console.ReadLine());
            while (queue.Count > 1)
            {

                for (int i = 1; i <= n; i++)
                {
                    if (i != n)
                    {
                        var alivePlayer = queue.Dequeue();
                        queue.Enqueue(alivePlayer);
                    }
                    else
                    {
                        var deadPlayer = queue.Dequeue();
                        Console.WriteLine($"Removed {deadPlayer}");
                    }
                }

            }
            Console.WriteLine($"Last is {queue.Peek()}");
        }
    }
}

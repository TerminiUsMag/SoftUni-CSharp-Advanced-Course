using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var orders = new Queue<int>();

            int food = int.Parse(Console.ReadLine());

            int[] order = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < order.Length; i++)
            {
                orders.Enqueue(order[i]);
            }

            Console.WriteLine(orders.Max());
            int numberOfOrders = orders.Count;

            for (int j = 0; j < numberOfOrders; j++)
            {
                int currOrder = orders.Peek();

                if (food >= currOrder)
                {
                    food -= currOrder;
                    orders.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (orders.Count != 0)
            {
                Console.WriteLine($"Orders left: {string.Join(' ', orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}

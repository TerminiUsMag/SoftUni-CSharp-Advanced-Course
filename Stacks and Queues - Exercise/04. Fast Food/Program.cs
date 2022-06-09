using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables.
            var orders = new Queue<int>();
            int food = int.Parse(Console.ReadLine());
            int[] order = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            //Getting the orders inside the Queue
            for (int i = 0; i < order.Length; i++)
            {
                orders.Enqueue(order[i]);
            }
            //Printing the biggest order.
            Console.WriteLine(orders.Max());
            //Getting the number of all orders to be static for the FOR cicle.
            int numberOfOrders = orders.Count;
            //The FOR cicle used for the logic of the example.
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
            //Printing the result.
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

using System;
using System.Linq;

namespace _01.Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[n[0], n[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] values = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = values[j];
                }
            }
            int sum = 0;
            foreach (var el in matrix)
            {
                sum += el;
            }
            Console.WriteLine($"{n[0]}\n{n[1]}\n{sum}");
        }
    }
}

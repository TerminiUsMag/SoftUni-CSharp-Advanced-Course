using System;
using System.Linq;

namespace _02.Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[n[0], n[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] values = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = values[j];
                }
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int sumCol = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    sumCol += matrix[j, i];
                }
                Console.WriteLine(sumCol);
            }
        }
    }
}

using System;
using System.Linq;

namespace _03.Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            long diagonalSum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] values = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = values[j];
                    if (i == j)
                    {
                        diagonalSum += matrix[i, j];
                    }
                }
            }

            Console.WriteLine(diagonalSum);


        }
    }
}

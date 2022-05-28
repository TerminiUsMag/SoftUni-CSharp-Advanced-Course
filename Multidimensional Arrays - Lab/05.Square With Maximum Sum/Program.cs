using System;
using System.Linq;

namespace _05.Square_With_Maximum_Sum
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
            long maxSum = long.MinValue;
            string bestSquare = string.Empty;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    long sumOFSquare =
                        matrix[i, j] +
                        matrix[i, j + 1] +
                        matrix[i + 1, j] +
                        matrix[i + 1, j + 1];

                    if (sumOFSquare > maxSum)
                    {
                        maxSum = sumOFSquare;
                        bestSquare =
                            $"{matrix[i, j]} {matrix[i, j + 1]} \n" +
                            $"{matrix[i + 1, j]} {matrix[i + 1, j + 1]}";
                    }

                }
            }
            Console.WriteLine(bestSquare);
            Console.WriteLine(maxSum);


        }
    }
}

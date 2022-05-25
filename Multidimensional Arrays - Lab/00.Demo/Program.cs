using System;

namespace _00.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            PrintMatrix(matrix);

            matrix[0, 4] = 10;

        }
        static void PrintMatrix(int[,] matrixToPrint)
        {
            for (int i = 0; i < matrixToPrint.GetLength(0); i++)
            {
                for (int j = 0; j < matrixToPrint.GetLength(1); j++)
                {
                    Console.Write(matrixToPrint[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}

using System;

namespace _07.Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] pascal = new long[n][];
            //pascal[0] = new int[] { n };

            for (int i = 0; i < n; i++)
            {
                pascal[i] = new long[i + 1];
            }
            pascal[0][0] = 1;

            for (int row = 1; row < n; row++)
            {
                long[] cols = pascal[row];
                long maxcol = cols.Length - 1;
                for (int col = 0; col < cols.Length; col++)
                {
                    if (col == maxcol)
                    {
                        pascal[row][col] = pascal[row - 1][col - 1];
                    }
                    else if (col == 0)
                    {
                        pascal[row][col] = pascal[row - 1][col];
                    }
                    else
                    {
                        pascal[row][col] = pascal[row - 1][col] + pascal[row - 1][col - 1];
                    }
                }
            }
            for (int rows = 0; rows < n; rows++)
            {
                long[] cols = pascal[rows];
                for (int col = 0; col < cols.Length; col++)
                {
                    Console.Write(pascal[rows][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

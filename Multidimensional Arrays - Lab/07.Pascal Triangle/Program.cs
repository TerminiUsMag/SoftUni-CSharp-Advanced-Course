using System;
using System.Numerics;

namespace _07.Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger[][] pascal = new BigInteger[n][];

            for (int i = 0; i < n; i++)
            {
                pascal[i] = new BigInteger[i + 1];
            }
            pascal[0][0] = 1;

            for (int row = 1; row < n; row++)
            {
                BigInteger[] cols = pascal[row];
                BigInteger maxcol = cols.Length - 1;
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
            PrintJaggedArray(pascal,n);
        }
        static void PrintJaggedArray(BigInteger[][] array,int rowsCount)
        {
            int n = rowsCount;

            for (int rows = 0; rows < n; rows++)
            {
                BigInteger[] cols = array[rows];
                for (int col = 0; col < cols.Length; col++)
                {
                    Console.Write(array[rows][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

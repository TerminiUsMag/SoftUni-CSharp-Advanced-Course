using System;
using System.Linq;

namespace _04.Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string characters = Console.ReadLine();
                foreach (char c in characters)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = c;
                    }
                }
            }

            char toFind = char.Parse(Console.ReadLine());
            bool found = false;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == toFind)
                    {
                        Console.WriteLine($"({i}, {j})");
                        found = true;
                    }
                }
                if (found) break;
            }

            if (!found)
            {
                Console.WriteLine($"{toFind} does not occur in the matrix");
            }

        }
    }
}

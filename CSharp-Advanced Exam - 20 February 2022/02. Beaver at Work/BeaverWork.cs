using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Beaver_at_Work
{
    public class BeaverWork
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var pond = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int x = 0; x < n; x++)
                {
                    pond[i, x] = line[x];
                }
            }
            var branches = new List<char>();
            while (true)
            {
                var coordinates = BeaverCoordinates(pond, n);
                var row = coordinates[0];
                var col = coordinates[1];
                string cmd = Console.ReadLine();
                char nextStep = default;
                int[] nextStepCoordinates = new int[2];
                nextStepCoordinates[0] = row;
                nextStepCoordinates[1] = col;
                switch (cmd)
                {
                    case "up":
                        if (row == 0)
                            if (branches.Count > 0)
                                branches.RemoveAt(branches.Count - 1);
                            else
                            {
                                nextStepCoordinates[0] = row - 1;
                                nextStep = pond[row - 1, col];
                            }
                        break;
                    case "down":
                        if (row == n - 1)
                            if (branches.Count > 0)
                                branches.RemoveAt(branches.Count - 1);
                            else
                                nextStep = pond[row + 1, col];
                        break;
                    case "left":
                        if (col == 0)
                            if (branches.Count > 0)
                                branches.RemoveAt(branches.Count - 1);
                            else
                                nextStep = pond[row, col - 1];
                        break;
                    case "right":
                        if (col == n - 1)
                            if (branches.Count > 0)
                                branches.RemoveAt(branches.Count - 1);
                            else
                                nextStep = pond[row, col + 1];
                        break;
                }
                if(char.IsLetter(nextStep))
                    if(char.IsLower)
            }


        }
        public static int[] BeaverCoordinates(char[,] pond, int size)
        {
            var result = new int[2];
            for (int i = 0; i < size; i++)
            {
                for (int x = 0; x < size; x++)
                {
                    if (pond[i, x] == 'B')
                    {
                        result[0] = i;
                        result[1] = x;
                    }
                }
            }

            return result;
        }
    }
}

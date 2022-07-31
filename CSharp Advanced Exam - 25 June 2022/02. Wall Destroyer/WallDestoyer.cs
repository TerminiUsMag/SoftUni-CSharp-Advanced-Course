using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Wall_Destroyer
{
    public class WallDestoyer
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var wall = new char[n, n];
            int[] vPosition = new int[2];
            bool firstMove = true;
            int numberOfHoles = 0;
            int rodsHit = 0;
            var electrocuted = false;

            for (int i = 0; i < n; i++)
            {
                char[] row = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    wall[i, j] = row[j];
                    if (row[j] == 'V')
                    {
                        vPosition[0] = i;
                        vPosition[1] = j;
                    }
                }
            }
            string cmd = Console.ReadLine();
            while (cmd != "End" && electrocuted != true)
            {
                var currRow = vPosition[0];
                var currCol = vPosition[1];
                char nextStepValue = default;
                int[] nextStepCoordinates = new int[2];
                bool validStep = false;
                if (cmd == "left")
                {
                    if (currCol != 0)
                    {
                        nextStepValue = wall[currRow, currCol - 1];
                        nextStepCoordinates[0] = currRow;
                        nextStepCoordinates[1] = currCol - 1;
                        validStep = true;
                    }
                }
                else if (cmd == "right")
                {
                    if (currCol != n-1)
                    {
                        nextStepValue = wall[currRow, currCol + 1];
                        nextStepCoordinates[0] = currRow;
                        nextStepCoordinates[1] = currCol + 1;
                        validStep = true;
                    }
                }
                else if (cmd == "up")
                {
                    if (currRow != 0)
                    {
                        nextStepValue = wall[currRow - 1, currCol];
                        nextStepCoordinates[0] = currRow - 1;
                        nextStepCoordinates[1] = currCol;
                        validStep = true;
                    }
                }
                else if (cmd == "down")
                {
                    if (currRow != n-1)
                    {
                        nextStepValue = wall[currRow + 1, currCol];
                        nextStepCoordinates[0] = currRow + 1;
                        nextStepCoordinates[1] = currCol;
                        validStep = true;
                    }
                }

                if (nextStepValue == 'R' && validStep)
                {
                    Console.WriteLine("Vanko hit a rod!");
                    rodsHit++;
                    //cmd = Console.ReadLine();
                    //continue;
                }
                else if (nextStepValue == 'C' && validStep)
                {
                    wall[nextStepCoordinates[0], nextStepCoordinates[1]] = 'E';
                    if (firstMove)
                    {
                        numberOfHoles++;
                        wall[currRow, currCol] = '*';
                        firstMove = false;
                    }
                    numberOfHoles++;
                    Console.WriteLine($"Vanko got electrocuted, but he managed to make {numberOfHoles} hole(s).");
                    electrocuted = true;
                }
                else if (nextStepValue == '*' && validStep)
                {
                    //if (firstMove)
                    //{
                    //    numberOfHoles++;
                    //    wall[currRow, currCol] = '*';
                    //}
                    Console.WriteLine($"The wall is already destroyed at position [{nextStepCoordinates[0]}, {nextStepCoordinates[1]}]!");
                    vPosition[0] = nextStepCoordinates[0];
                    vPosition[1] = nextStepCoordinates[1];
                }
                else if (nextStepValue == '-' && validStep)
                {
                    //if (firstMove)
                    //{
                    //    wall[currRow, currCol] = '*';
                    //    numberOfHoles++;
                    //}
                    vPosition[0] = nextStepCoordinates[0];
                    vPosition[1] = nextStepCoordinates[1];
                    wall[vPosition[0], vPosition[1]] = '*';
                    numberOfHoles++;
                }

                if (firstMove)
                {
                    numberOfHoles++;
                    wall[currRow, currCol] = '*';
                    firstMove = false;
                }

                if (!electrocuted)
                    cmd = Console.ReadLine();
                if (cmd == "End" || electrocuted)
                {
                    if (!electrocuted)
                        wall[nextStepCoordinates[0], nextStepCoordinates[1]] = 'V';
                    if (cmd == "End" && !electrocuted)
                    {
                        Console.WriteLine($"Vanko managed to make {numberOfHoles} hole(s) and he hit only {rodsHit} rod(s).");
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int y = 0; y < n; y++)
                        {
                            Console.Write(wall[i, y]);
                        }
                        Console.Write("\n");
                    }
                }
            }
        }
    }
}

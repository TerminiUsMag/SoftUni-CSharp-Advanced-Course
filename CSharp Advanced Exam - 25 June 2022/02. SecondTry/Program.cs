using System;

namespace _02._SecondTry
{
    public class Program
    {
        public static int countOfHoles = 0;
        public static int countOfRods = 0;
        public static bool fmSuccess = false;
        public static bool ex = false;
        static void Main(string[] args)
        {
            int n;
            while ((n = int.Parse(Console.ReadLine())) < 2 || n > 10)
            { }

            var wall = new char[n, n];
            wall = EnterRows(n, wall);
            int[] vPosition = DetermineVPosition(n, wall);
            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {
                if (!fmSuccess)
                    wall = FirstMove(n, wall, vPosition, cmd);
                else
                    wall = Move(n, wall, vPosition, cmd);
                if (wall != null)
                    vPosition = DetermineVPosition(n, wall);
                else
                    return;
            }
            Console.WriteLine($"Vanko managed to make {countOfHoles} hole(s) and he hit only {countOfRods} rod(s).");
            PrintWall(n, wall);
        }

        public static char[,] FirstMove(int n, char[,] wall, int[] vPosition, string cmd)
        {
            var vX = vPosition[0];
            var vY = vPosition[1];
            var countOfHitRodsAtMoment = countOfRods;
            wall = Move(n, wall, vPosition, cmd);
            if (!ex && wall != null)
            {
                wall[vX, vY] = '*';
                countOfHoles++;
                fmSuccess = true;
                if (countOfHitRodsAtMoment < countOfRods)
                    wall[vX, vY] = 'V';
            }
            ex = false;
            return wall;
        }
        public static char[,] Move(int n, char[,] wall, int[] vPosition, string cmd)
        {
            var vX = vPosition[0];
            var vY = vPosition[1];
            char nextPosValue = ' ';
            int[] nextPos = new int[2];
            try
            {
                switch (cmd)
                {
                    case "up":
                        nextPosValue = wall[vX - 1, vY];
                        nextPos[0] = vX - 1;
                        nextPos[1] = vY;
                        break;
                    case "down":
                        nextPosValue = wall[vX + 1, vY];
                        nextPos[0] = vX + 1;
                        nextPos[1] = vY;
                        break;
                    case "left":
                        nextPosValue = wall[vX, vY - 1];
                        nextPos[0] = vX;
                        nextPos[1] = vY - 1;
                        break;
                    case "right":
                        nextPosValue = wall[vX, vY + 1];
                        nextPos[0] = vX;
                        nextPos[1] = vY + 1;
                        break;
                }
            }
            catch (IndexOutOfRangeException)
            {
                ex = true;
                return wall;
            }
            if (nextPosValue == 'C')
            {
                countOfHoles++;

                wall[nextPos[0], nextPos[1]] = 'E';

                if (fmSuccess)
                    wall[vX, vY] = '*';
                else
                {
                    wall[vX, vY] = '*';
                    countOfHoles++;
                }
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {countOfHoles} hole(s).");
                PrintWall(n, wall);

                return null;

            }
            else if (nextPosValue == 'R')
            {
                Console.WriteLine("Vanko hit a rod!");
                countOfRods++;
            }
            else if (nextPosValue == '*')
            {
                Console.WriteLine($"The wall is already destroyed at position [{nextPos[0]}, {nextPos[1]}]!");
                wall[nextPos[0], nextPos[1]] = 'V';
                wall[vX, vY] = '*';
            }
            else
            {
                wall[nextPos[0], nextPos[1]] = 'V';
                wall[vX, vY] = '*';
                countOfHoles++;
            }
            return wall;
        }
        public static void PrintWall(int n, char[,] wall)
        {
            for (int i = 0; i < n; i++)
            {
                for (int x = 0; x < n; x++)
                {
                    Console.Write(wall[i, x]);
                }
                Console.WriteLine();
            }
        }
        public static char[,] EnterRows(int numberOfRows, char[,] wall)
        {
            for (int i = 0; i < numberOfRows; i++)
            {
                string currRow = Console.ReadLine();
                for (int j = 0; j < numberOfRows; j++)
                {
                    if (currRow.Length > j)
                        wall[i, j] = currRow[j];
                    else wall[i, j] = '-';
                }
            }
            return wall;
        }
        public static int[] DetermineVPosition(int numberOfRows, char[,] wall)
        {
            int[] vPosition = new int[2];
            if (wall[vPosition[0], vPosition[1]] != 'V')
                for (int i = 0; i < numberOfRows; i++)
                {
                    for (int x = 0; x < numberOfRows; x++)
                    {
                        if (wall[i, x] == 'V')
                        {
                            vPosition[0] = i;
                            vPosition[1] = x;
                        }
                    }
                }
            return vPosition;
        }
    }
}

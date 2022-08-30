using System;

namespace HelpAMole
{
    internal class Program
    {
        static int totalPoints = 0;
        static void Main(string[] args)
        {
            int n;
            while ((n = int.Parse(Console.ReadLine())) < 2 || n > 10)
            { }

            var wall = new char[n, n];
            wall = EnterRows(n, wall);
            int[] mPosition = DetermineMPosition(n, wall);
            string cmd;
            while ((cmd = Console.ReadLine()) != "End" && totalPoints < 25)
            {
                wall = Move(n, wall, mPosition, cmd);
                mPosition = DetermineMPosition(n, wall);
            }
            if (totalPoints >= 25)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {totalPoints} points.");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {totalPoints} points.");
            }
            PrintWall(n, wall);
        }

        public static char[,] Move(int n, char[,] wall, int[] mPosition, string cmd)
        {
            var mX = mPosition[0];
            var mY = mPosition[1];
            char nextPosValue = ' ';
            int[] nextPos = new int[2];
            try
            {
                switch (cmd)
                {
                    case "up":
                        nextPosValue = wall[mX - 1, mY];
                        nextPos[0] = mX - 1;
                        nextPos[1] = mY;
                        break;
                    case "down":
                        nextPosValue = wall[mX + 1, mY];
                        nextPos[0] = mX + 1;
                        nextPos[1] = mY;
                        break;
                    case "left":
                        nextPosValue = wall[mX, mY - 1];
                        nextPos[0] = mX;
                        nextPos[1] = mY - 1;
                        break;
                    case "right":
                        nextPosValue = wall[mX, mY + 1];
                        nextPos[0] = mX;
                        nextPos[1] = mY + 1;
                        break;
                    default:
                        return wall;

                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Don't try to escape the playing field!");
                return wall;
            }
            if (nextPosValue == 'S')
            {
                wall[nextPos[0], nextPos[1]] = '-';
                var findSecondS = DetermineSPosition(n, wall);
                wall[findSecondS[0], findSecondS[1]] = 'M';
                totalPoints -= 3;

                //if (fmSuccess)
                //    wall[mX, mY] = '*';
                //else
                //{
                //    wall[mX, mY] = '*';
                //    countOfHoles++;
                //}
                //Console.WriteLine($"Vanko got electrocuted, but he managed to make {countOfHoles} hole(s).");
                //PrintWall(n, wall);

                //return null;

            }
            else if (nextPosValue == '-')
            {
                wall[nextPos[0], nextPos[1]] = 'M';
            }
            //else if (nextPosValue == '*')
            //{
            //    Console.WriteLine($"The wall is already destroyed at position [{nextPos[0]}, {nextPos[1]}]!");
            //    wall[nextPos[0], nextPos[1]] = 'V';
            //    wall[mX, mY] = '*';
            //}
            else
            {
                var pointsToCollect = nextPosValue - '0';
                wall[nextPos[0], nextPos[1]] = 'M';
                totalPoints += pointsToCollect;
            }
            wall[mX, mY] = '-';
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
        public static int[] DetermineMPosition(int numberOfRows, char[,] wall)
        {
            int[] mPosition = new int[2];
            if (wall[mPosition[0], mPosition[1]] != 'M')
                for (int i = 0; i < numberOfRows; i++)
                {
                    for (int x = 0; x < numberOfRows; x++)
                    {
                        if (wall[i, x] == 'M')
                        {
                            mPosition[0] = i;
                            mPosition[1] = x;
                        }
                    }
                }
            return mPosition;
        }
        public static int[] DetermineSPosition(int numberOfRows, char[,] wall)
        {
            int[] sPosition = new int[2];
            if (wall[sPosition[0], sPosition[1]] != 'S')
                for (int i = 0; i < numberOfRows; i++)
                {
                    for (int x = 0; x < numberOfRows; x++)
                    {
                        if (wall[i, x] == 'S')
                        {
                            sPosition[0] = i;
                            sPosition[1] = x;
                        }
                    }
                }
            return sPosition;
        }
    }
}

using System;
using System.Linq;

namespace _06.Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jagged = new int[n][];

            for (int i = 0; i < n; i++)
            {
                int[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                jagged[i] = line;
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandTokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).ToArray();

                int row = int.Parse(commandTokens[1]);
                int col = int.Parse(commandTokens[2]);

                bool valid = true;

                if (int.Parse(commandTokens[1]) < n)
                {
                    if (int.Parse(commandTokens[2]) < jagged[int.Parse(commandTokens[1])].Length)
                    {

                        switch (commandTokens[0])
                        {
                            case "add":

                                break;
                            case "subtract":

                                break;
                        }
                    }
                    else valid = false;
                }
                else valid = false;
            }
        }
    }
}

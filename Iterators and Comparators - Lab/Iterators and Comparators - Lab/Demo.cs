using System;
using System.Linq;

namespace Iterators_and_Comparators___Lab
{
    internal class Demo
    {
        static void Main(string[] args)
        {
            var firstPile = new PileOfCash();
            var secondPile = new PileOfCash();
            string cmd;
            while ((cmd = Console.ReadLine()) != "Compare")
            {
                var cmdTokens = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                Console.WriteLine($"Add notes to which Pile? ");
                var pile = Console.ReadLine();
                pile = pile.ToLower();
                var type = cmdTokens[0];
                var number = int.Parse(cmdTokens[1]);
                if(pile == "first")
                {
                    firstPile.AddNotes(type, number);
                }
                else if (pile == "second")
                {
                    secondPile.AddNotes(type, number);
                }
                else
                {
                    Console.WriteLine("Incorrect pile to add to, try again!");
                }
            }

            Console.WriteLine(firstPile.CompareTo(secondPile));
        }
    }
}

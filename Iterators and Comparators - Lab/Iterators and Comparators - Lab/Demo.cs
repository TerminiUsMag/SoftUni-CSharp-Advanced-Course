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
            Console.WriteLine("Enter {numberOfNotes} {typeOfNotes} , Example: \"5 10\" which means five notes of 10 lv. Or \"Compare\" if you want to compare the two piles. ");
            while ((cmd = Console.ReadLine()) != "Compare")
            {
                var cmdTokens = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                Console.WriteLine($"Add notes to which Pile? (first or second)");
                var pile = Console.ReadLine();
                pile = pile.ToLower();
                var number = int.Parse(cmdTokens[0]);
                var type = cmdTokens[1];
                if (pile == "first")
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

                Console.WriteLine("Enter {numberOfNotes} {typeOfNotes} , Example: \"5 10\" which means five notes of 10 lv. Or \"Compare\" if you want to compare the two piles. ");
            }
            var result = firstPile.CompareTo(secondPile);
            if (result > 0)
            {
                Console.WriteLine("First Pile's value is greater than Second Pile's value.");
            }
            else if (result < 0)
            {
                Console.WriteLine("First Pile's value is smaller than Second Pile's value.");
            }
            else
            {
                Console.WriteLine("First Pile and Second Pile's values are equal.");
            }
            result = new PileComparerByNumberOfNotes().Compare(firstPile, secondPile);
            if (result > 0)
            {
                Console.WriteLine("First Pile has more notes tha Second Pile.");
            }
            else if (result < 0)
            {
                Console.WriteLine("First Pile has less notes than Second Pile.");
            }
            else
            {
                Console.WriteLine("First and Second Piles have the same amount of notes in them.");
            }
        }
    }
}

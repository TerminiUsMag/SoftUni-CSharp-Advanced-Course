using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables.
            var deliveryBox = new Stack<int>();
            int numberOfRacksUsed = 1;
            int[] inputClothes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rackSize = int.Parse(Console.ReadLine());

            //Pushing the values of the clothes in the "deliveryBox" Stack.
            for (int i = 0; i < inputClothes.Length; i++)
            {
                deliveryBox.Push(inputClothes[i]);
            }
            //Declaring more variables used for the logic of the example.
            int deliveryBoxQuantity = deliveryBox.Count;
            int currRack = 0;
            //For cicle used to calculate the number of racks used for the clothes in the delivery box.
            for (int j = 0; j < deliveryBoxQuantity; j++)
            {
                int currClothing = deliveryBox.Pop();

                if (currRack == rackSize)
                {
                    numberOfRacksUsed++;
                    currRack = 0;
                }

                if (currRack + currClothing > rackSize)
                {
                    numberOfRacksUsed++;
                    currRack = currClothing;
                }
                else if (currRack + currClothing <= rackSize)
                {
                    currRack += currClothing;
                }
            }
            //Printing the result.
            Console.WriteLine(numberOfRacksUsed);
        }
    }
}

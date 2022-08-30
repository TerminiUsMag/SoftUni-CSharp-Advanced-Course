using System;
using System.Collections.Generic;
using System.Linq;

namespace BaristaContest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coffee = new Queue<int>();
            var milk = new Stack<int>();
            var madeDrinks = new Dictionary<string, int>();

            var coffeeInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var milkInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < coffeeInput.Length; i++)
            {
                coffee.Enqueue(coffeeInput[i]);
            }
            for (int y = 0; y < milkInput.Length; y++)
            {
                milk.Push(milkInput[y]);
            }

            while (coffee.Count > 0 && milk.Count > 0)
            {
                var sum = coffee.Peek() + milk.Peek();
                switch (sum)
                {
                    case 50://Cortado
                        coffee.Dequeue();
                        milk.Pop();
                        AddToDict(madeDrinks, "Cortado");

                        break;
                    case 75://Espresso

                        coffee.Dequeue();
                        milk.Pop();
                        AddToDict(madeDrinks, "Espresso");

                        break;
                    case 100://Capuccino

                        coffee.Dequeue();
                        milk.Pop();
                        AddToDict(madeDrinks, "Capuccino");

                        break;
                    case 150://Americano

                        coffee.Dequeue();
                        milk.Pop();
                        AddToDict(madeDrinks, "Americano");

                        break;
                    case 200://Latte

                        coffee.Dequeue();
                        milk.Pop();
                        AddToDict(madeDrinks, "Latte");

                        break;
                    default://None

                        coffee.Dequeue();
                        var milkToDecrease = milk.Pop();
                        milkToDecrease -= 5;
                        milk.Push(milkToDecrease);
                        //var tempMilk = new Stack<int>();
                        //for (int x = 0; x < milk.Count; x++)
                        //{
                        //    tempMilk.Push(milk.Pop());
                        //}

                        break;
                }
            }

            if (coffee.Count > 0 || milk.Count > 0)
            {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
            }
            else
            {
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
            }

            var coffeeLeft = coffee.Count == 0 ? "none" : String.Join(", ", coffee);
            var milkLeft = milk.Count == 0 ? "none" : String.Join(", ", milk);

            Console.WriteLine($"Coffee left: {coffeeLeft}");
            Console.WriteLine($"Milk left: {milkLeft}");

            var orderedDrinksDict = madeDrinks.OrderBy(d => d.Value).ThenByDescending(d => d.Key);

            foreach (var drink in orderedDrinksDict)
            {
                Console.WriteLine($"{drink.Key}: {drink.Value}");
            }

        }
        public static void AddToDict(Dictionary<string, int> dict, string key)
        {
            if (!dict.ContainsKey(key))
            {
                dict.Add(key, 1);
            }
            else
            {
                dict[key]++;
            }
        }
    }
}

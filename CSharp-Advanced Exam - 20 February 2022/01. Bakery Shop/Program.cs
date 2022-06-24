using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bakery_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Croissant – consists of 50 % water and 50 % flour
            //•	Muffin – consists of 40 % water and 60 % flour
            //•	Baguette – consists of 30 % water and 70 % flour
            //•	Bagel – consists of 20 % water and 80 % flour

            var baked = new Dictionary<string, int>();
            var water = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var flour = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            var waterCounter = 0;
            var flourCounter = flour.Length - 1;
            var bake = string.Empty;
            while (true)
            {
                var waterRatio = water[waterCounter] * 100 / (water[waterCounter] + flour[flourCounter]);
                waterRatio = Math.Round(waterRatio, 0);
                switch (waterRatio)
                {
                    case 50://•	Croissant – consists of 50 % water and 50 % flour
                        bake = "Croissant";
                        water[waterCounter] = flour[flourCounter] = 0;
                        break;
                    case 40://•	Muffin – consists of 40 % water and 60 % flour
                        bake = "Muffin";
                        water[waterCounter] = flour[flourCounter] = 0;
                        break;
                    case 30://•	Baguette – consists of 30 % water and 70 % flour
                        bake = "Baguette";
                        water[waterCounter] = flour[flourCounter] = 0;
                        break;
                    case 20://•	Bagel – consists of 20 % water and 80 % flour
                        bake = "Bagel";
                        water[waterCounter] = flour[flourCounter] = 0;
                        break;
                    default:
                        bake = "Croissant";
                        var flourLeft = flour[flourCounter] - water[waterCounter];
                        water[waterCounter] = 0;
                        flour[flourCounter] = flourLeft;
                        break;
                }
                if (!baked.ContainsKey(bake)) baked.Add(bake, 1);
                else baked[bake]++;

                waterCounter++;
                flourCounter--;
                if (waterCounter >= water.Length || flourCounter < 0)
                    break;
            }

            var orderedBakedDictionary = baked.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            foreach(var item in orderedBakedDictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            bool isWaterLeft = false;
            var waterLeft = new List<double>();
            foreach(var bucket in water)
            {
                if (bucket > 0)
                {
                    isWaterLeft = true;
                    waterLeft.Add(bucket);
                }
            }
            if (isWaterLeft)
            {
                Console.WriteLine($"Water left: {string.Join(", ",waterLeft)}");
            }
            else
            {
                Console.WriteLine("Water left: None");
            }
            bool isFlourLeft = false;
            var flourLeftAfter = new List<double>();
            foreach(var package in flour)
            {
                if(package>0)
                {
                    isFlourLeft = true;
                    flourLeftAfter.Add(package);
                }
            }
            flourLeftAfter.Reverse();
            if (isFlourLeft)
            {
                Console.WriteLine($"Flour left: {string.Join(", ",flourLeftAfter)}");
            }
            else
            {
                Console.WriteLine("Flour left: None");
            }
        }
    }
}

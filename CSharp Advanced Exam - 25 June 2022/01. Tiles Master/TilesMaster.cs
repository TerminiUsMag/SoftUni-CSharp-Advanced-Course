using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Tiles_Master
{
    internal class TilesMaster
    {
        static void Main(string[] args)
        {
            //Location   Tile area needed
            //Sink        40
            //Oven        50
            //Countertop  60
            //Wall        70

            var whiteTilesInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var greyTilesInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var whiteTilesStack = new Stack<int>(whiteTilesInput);
            var greyTilesQueue = new Queue<int>(greyTilesInput);

            var locations = new Dictionary<string, int>();

            while (whiteTilesStack.Any() && greyTilesQueue.Any())
            {
                var currentWhite = whiteTilesStack.Peek();
                var currentGray = greyTilesQueue.Peek();
                var sumOfTiles = currentWhite + currentGray;
                var location = string.Empty;
                var isUsed = false;
                if (currentWhite != currentGray)
                {
                    whiteTilesStack.Pop();
                    greyTilesQueue.Dequeue();
                    currentWhite /= 2;
                    whiteTilesStack.Push(currentWhite);
                    greyTilesQueue.Enqueue(currentGray);
                }
                else if (sumOfTiles == 40)//Sink
                {
                    whiteTilesStack.Pop();
                    greyTilesQueue.Dequeue();
                    location = "Sink";
                    isUsed = true;
                }
                else if (sumOfTiles == 50)//Oven
                {
                    whiteTilesStack.Pop();
                    greyTilesQueue.Dequeue();
                    location = "Oven";
                    isUsed = true;
                }
                else if (sumOfTiles == 60)//Countertop
                {
                    whiteTilesStack.Pop();
                    greyTilesQueue.Dequeue();
                    location = "Countertop";
                    isUsed = true;
                }
                else if (sumOfTiles == 70)//Wall
                {
                    whiteTilesStack.Pop();
                    greyTilesQueue.Dequeue();
                    location = "Wall";
                    isUsed = true;
                }
                else//Floor
                {
                    whiteTilesStack.Pop();
                    greyTilesQueue.Dequeue();
                    location = "Floor";
                    isUsed = true;
                }

                if (isUsed)
                {
                    if (!locations.ContainsKey(location))
                    {
                        locations.Add(location, 1);
                    }
                    else
                    {
                        locations[location]++;
                    }
                }
            }

            var whiteTilesLeft = whiteTilesStack.Count == 0 ? "none" : String.Join(", ", whiteTilesStack);
            var greyTilesLeft = greyTilesQueue.Count == 0 ? "none" : String.Join(", ", greyTilesQueue);
            Console.WriteLine($"White tiles left: {whiteTilesLeft}");
            Console.WriteLine($"Grey tiles left: {greyTilesLeft}");

            foreach (var item in locations.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}

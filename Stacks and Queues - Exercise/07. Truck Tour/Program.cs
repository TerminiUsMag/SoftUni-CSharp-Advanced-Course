using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Truck_Tour
{
    class PetrolPump
    {
        public PetrolPump(int petrol, int distance)
        {
            this.AmountOfPetrol = petrol;
            this.DistanceToNextPetrolStation = distance;
        }
        public int AmountOfPetrol { get; set; }
        public int DistanceToNextPetrolStation { get; set; }
    }
    class Tank
    {
        public Tank(int petrol)
        {
            this.Petrol = petrol;
        }

        public int Petrol { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //var petrolPumps = new Dictionary<int, PetrolPump>();
            var petrolPumps = new Queue<PetrolPump>();

            int n = int.Parse(Console.ReadLine());
            bool success = false;
            int indexCounter = 0;
            //PetrolPump[] petrolPumps = new PetrolPump[n];
            //PetrolPump[] petrolPumps2 = new PetrolPump[n];

            for (int i = 0; i < n; i++)
            {
                int[] inputLine = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int amountOfPetrol = inputLine[0];
                int distanceToNext = inputLine[1];

                //petrolPumps[i] = new PetrolPump(amountOfPetrol, distanceToNext);
                //petrolPumps.Add(i, new PetrolPump(amountOfPetrol, distanceToNext));
                petrolPumps.Enqueue(new PetrolPump(amountOfPetrol, distanceToNext));
            }
            while (!success)
            {
                var truck = new Tank(0);
                int i = 0;
                var lastpump = petrolPumps.Last();
                foreach (var pump in petrolPumps)
                {
                    truck.Petrol += pump.AmountOfPetrol;
                    truck.Petrol -= pump.DistanceToNextPetrolStation;
                    if (truck.Petrol < 0)
                    {
                        var reset = petrolPumps.Dequeue();
                        petrolPumps.Enqueue(reset);
                        indexCounter++;
                        break;
                    }
                    i++;
                    if (i == n) { success = true; };
                }
            }
            Console.WriteLine(indexCounter);



        }
    }
}

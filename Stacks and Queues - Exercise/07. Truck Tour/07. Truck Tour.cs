using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Truck_Tour
{
    //Declaring Petrol Pump class with two properties.
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
    //Declaring Tank class with only one property.
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
            //Declaring variables.
            var petrolPumps = new Queue<PetrolPump>();
            int n = int.Parse(Console.ReadLine());
            bool success = false;
            int indexCounter = 0;

            //PetrolPump[] petrolPumps = new PetrolPump[n];
            //PetrolPump[] petrolPumps2 = new PetrolPump[n];

            //FOR loop to enqueue all the pumps with their properties.
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
            //While loop for the main logic of the exercise.
            while (!success)
            {
                //Declaring the truck with class TANK and the int i which is used as a counter to determine the last pump in the collection every time the while loop is iterated.
                var truck = new Tank(0);
                int i = 0;
                //var lastpump = petrolPumps.Last();
                //FOREACH loop is used to check if the current starting point in the circle is valid.
                foreach (var pump in petrolPumps)
                {
                    truck.Petrol += pump.AmountOfPetrol;//Adds the petrol from the pump to the tank of the truck.
                    truck.Petrol -= pump.DistanceToNextPetrolStation;//Removes the petrol necessary to get the truck to the next pump.
                    if (truck.Petrol < 0)//Checks if the petrol was enough to get to the next pump.If not the starting point pump is moved to the last position in the queue.The indexCounter is used to determine which is the first possible index to complete the circle.
                    {
                        var reset = petrolPumps.Dequeue();
                        petrolPumps.Enqueue(reset);
                        indexCounter++;
                        break;
                    }
                    i++;//Last pump counter.
                    if (i == n) { success = true; }//Checks if i == n (pump counter == number of pumps) and if so sets success to true, which ends the while loop.
                }
            }
            //Print the result.
            Console.WriteLine(indexCounter);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var parkingLot = new HashSet<string>();
            string command;

            while ((command = Console.ReadLine())!="END")
            {
                string[] cmd = command.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string operation = cmd[0];
                string plate = cmd[1];

                if (operation == "IN")
                    parkingLot.Add(plate);

                if (operation == "OUT")
                    parkingLot.Remove(plate);


            }

            if(parkingLot.Count > 0)
            {
                foreach(var car in parkingLot)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }

        }
    }
}

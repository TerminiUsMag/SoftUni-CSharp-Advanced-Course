using System;
using System.Collections.Generic;
using System.Linq;

namespace Special_Cars
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var allTirePairs = new List<Tire[]>();
            var allEngines = new List<Engine>();
            string cmd;
            while ((cmd = Console.ReadLine()) != "No more tires")
            {
                var tiresInfo = cmd
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                var tires = new Tire[4]{
                    new Tire((int)tiresInfo[0], tiresInfo[1]),
                    new Tire((int)tiresInfo[2], tiresInfo[3]),
                    new Tire((int)tiresInfo[4], tiresInfo[5]),
                    new Tire((int)tiresInfo[6], tiresInfo[7]),
                };
                allTirePairs.Add(tires);
            }
            string command;
            while ((command = Console.ReadLine()) != "Engines done")
            {
                var enginesInfo = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
                var engine = new Engine((int)enginesInfo[0], enginesInfo[1]);
                allEngines.Add(engine);
            }
            var cars = new List<Car>();
            while ((cmd = Console.ReadLine()) != "Show special")
            {
                var tokens = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string make = tokens[0];
                string model = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQuantity = double.Parse(tokens[3]);
                double fuelConsumption = double.Parse(tokens[4]);
                int engineIndex = int.Parse(tokens[5]);
                int tireIndex = int.Parse(tokens[6]);
                var tiresForVehicle = allTirePairs[tireIndex];
                var engineForVehicle = allEngines[engineIndex];

                var newCar = new Car(make, model, year, fuelQuantity, fuelConsumption, engineForVehicle, tiresForVehicle);
                cars.Add(newCar);
            }
            foreach (var car in cars)
            {
                double sumOfTirePressures = car.PressureInTires();
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && sumOfTirePressures >= 9 && sumOfTirePressures <= 10)
                {
                    car.Drive(20);
                }
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}\nHorsePowers: {car.Engine.HorsePower}\nFuelQuantity: {car.FuelQuantity}");
            }
        }
    }
}

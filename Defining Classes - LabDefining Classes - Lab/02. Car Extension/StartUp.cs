﻿using System;
using CarManufacturer;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // TODO: define the Main() method here ...
            var car = new Car();

            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;
            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());
            
        }
    }
}

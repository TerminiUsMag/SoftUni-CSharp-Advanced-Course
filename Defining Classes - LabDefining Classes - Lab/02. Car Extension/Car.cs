using System;

namespace CarManufacturer
{
    public class Car
    {
        // TODO: define the Car class members here …
        int year;
        string make;
        string model;
        private double fuelQuantity;
        private double fuelConsumption;

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public int Year { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        public void Drive(double distance)
        {
            double distanceWithCurrQuantity = this.fuelQuantity * this.fuelConsumption;
            if (distance <= distanceWithCurrQuantity)
            {
                double fuelForDistance = distance * this.fuelConsumption;
                this.fuelQuantity -= fuelForDistance;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}";
        }
    }
}


using System;

namespace CarManufacturer
{
    public class Car
    {
        // TODO: define the Car class members here 
        private int year;
        private string make;
        private string model;
        private double fuelQuantity;
        private double fuelConsumption;
        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }
        public Car(string make, string model, int year)
        : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
        : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
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


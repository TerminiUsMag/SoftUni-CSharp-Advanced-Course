using System;
using System.Collections.Generic;
using System.Linq;

namespace Special_Cars_2
{
    public class Tire
    {
        private int year;

        private double pressure;

        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }
    
        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
    }
}

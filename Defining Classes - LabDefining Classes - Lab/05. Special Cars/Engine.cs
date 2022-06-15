using System;
using System.Collections.Generic;
using System.Text;

namespace Special_Cars
{
    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;
        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }

        public double CubicCapacity
        {
            get { return cubicCapacity; }
            set { cubicCapacity = value; }
        }

        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }

    }
}

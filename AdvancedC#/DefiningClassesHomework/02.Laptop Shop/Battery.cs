using System;

namespace _02.Laptop_Shop
{
    public class Battery
    {
        private double batteryLife;

        public double BatteryLife
        {
            get { return this.batteryLife; }

            set
            {
                if (value<=0 || value>20)
                {
                    throw new ArgumentOutOfRangeException("This is not a real battery life value.");
                }
                this.batteryLife = value;
            }
        }
    }
}
using System;
using System.Text;

namespace _02.Laptop_Shop
{
    public class Laptop
    {
        private string model;
        private string manifacturer;
        private string processor;
        private int ram;
        private string graphicsCart;
        private int hardDisk;
        private string screen;
        private decimal price;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, decimal price, Battery battery) : this(model, price)
        {
            this.manifacturer = manifacturer;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model cannot be empty");
                }
                this.model = value;
            }
        }

        public decimal Price
        {
            
            get { return this.price; }
            set
            {
                if (value <0 )
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative");
                }
                this.price = value;
            }
        }

        public string Manifacturer
        {
            get { return this.manifacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Manifacturer cannot be empty");
                }
                this.manifacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Processor cannot be empty");
                }
                this.processor = value;
            }
        }

        public int Ram
        {
            get { return this.ram; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Ram memory cannot be negative   ");
                }
                this.ram = value;
            }
        }

        public string GraphicsCart
        {
            get { return this.graphicsCart; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The graphics card cannot be empty");
                }
                this.graphicsCart = value;

            }
        }

        public int HardDisk
        {
            get {return this.hardDisk; }
            set
            {
                if (value<1)
                {
                    throw new ArgumentOutOfRangeException("The HDD cannot be negative value");
                }
                this.hardDisk = value;
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The screen cannot be empty value");
                }
                this.screen = value;
            }
        }  

        public Battery Batt { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Laptop description:");
            result.AppendLine("Model: " + this.Model);

            if (manifacturer != null)
            {
                result.AppendLine("Manufacturer: " + this.Manifacturer);
            }
            if (processor != null)
            {
                result.AppendLine("Processor: " + this.Processor);
            }
            if (ram > 0)
            {
                result.AppendLine("RAM: " + this.Ram + " GB");
            }
            if (graphicsCart != null)
            {
                result.AppendLine("Graphics Card: " + this.GraphicsCart);
            }
            if (hardDisk > 0)
            {
                result.AppendLine("HDD: " + this.hardDisk + " GB");
            }
            if (screen != null)
            {
                result.AppendLine("Screen: " + this.Screen);
            }
            //if (Batt.BatteryLife > 0)
            //{
            //    result.AppendLine("Battery: " + this.Batt.BatteryLife);
            //}
           
            result.AppendLine("Price: " + this.Price + " lv.");
            return result.ToString();

        }

    }
}
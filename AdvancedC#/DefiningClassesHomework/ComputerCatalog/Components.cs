using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerCatalog
{
    class Components
    {
        private string name;
        private decimal price;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Component name cannot be empty");

                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentNullException("Price cannot be negative!");
                }
                this.price = value;
            }
        }

        public string  Details { get; set; }

        public Components(string name,decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Components(string name, decimal price,string details):this(name,price)
        {
            this.Details = details;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ComputerCatalog
{
    class Computer
    {
        private string name;
        private decimal price;
        private List<Components> components;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Computer name cannot be empty!");

                }
                this.name = value;
            }
        }

        public List<Components> Components
        {
            get { return this.components; }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentNullException("You should specify at least one component!");
                }
                this.components = value;
            }
        }

        public decimal Price
        {
            get { return CalculatedPrice(this); }

        }

        public Computer(string name, List<Components> components)
        {
            this.Name = name;
            this.Components = components;

        }
        private decimal CalculatedPrice(Computer computer)
        {
            var components = computer.Components;
            decimal price = components.Sum(component => component.Price);
            return price;
        }

        public override string ToString()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg");
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Computer name: {0}", this.Name));
            foreach (var component in components)
            {
                result.AppendLine(string.Format("{0}{2} {1:c2}", component.Name, component.Price, string.IsNullOrWhiteSpace(component.Details) ? ":" : ":" + " " + component.Details + ":"));
            }
            result.AppendLine(string.Format("Total price: {0:c2}", this.Price));
            return result.ToString();
        }

    }
}

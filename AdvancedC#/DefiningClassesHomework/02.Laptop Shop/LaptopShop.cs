using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Laptop_Shop
{
    class LaptopShop
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop("Asus", 2259.00m, new Battery());
            laptop.Manifacturer = "Asus";
            laptop.Processor = "Intel Core i5-4210U";
            laptop.Ram = 8;
            laptop.GraphicsCart = "Intel HD Graphics 4400";
            laptop.HardDisk = 1024;
            laptop.Screen = @"13.3"" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display";

            Console.WriteLine(laptop);
          
        }
    }
}

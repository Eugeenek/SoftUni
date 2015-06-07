using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerCatalog
{
    class ComputerCatalog
    {
        static void Main()
        {
            List<Computer> catalogComputers = new List<Computer>();
            List<Components> components= new List<Components>();
            components.Add(new Components("Hard Disk",133.00m));
            components.Add(new Components("Graphics card",250.00m,"Nvidia"));
            components.Add(new Components("Screen",150.00m ));
            Computer asus = new Computer("Asus",components);

            List<Components> components1 = new List<Components>();
            components1.Add(new Components("HDD-SSD", 200.00m));
            components1.Add(new Components("Processor", 300.00m, "2.5 Ghz"));
            components1.Add(new Components("Screen", 150.00m));
            Computer hpComputer = new Computer("HP", components1);

            

            catalogComputers.Add(asus);
            catalogComputers.Add(hpComputer);

            var sortedComputerCatalog = catalogComputers.OrderBy(computer => computer.Price);

            foreach (var computer in sortedComputerCatalog)
            {
                Console.WriteLine(computer);
            }
        }
    }
}

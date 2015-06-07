using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CopyBinaryFile
{
    class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            FileStream source = new FileStream(@"..\..\SoftUni.jpg", FileMode.Open);
            FileStream destination = new FileStream(@"..\..\Destination.jpg", FileMode.Create);


            try
            {
                byte[] bufer = new byte[4096];

                while (true)
                {
                    int readBYtes = source.Read(bufer, 0, bufer.Length);
                    if (readBYtes == 0)
                    {
                        break;
                    }
                    destination.Write(bufer, 0, readBYtes);
                   
                }
                Console.WriteLine("Check the Destination.jpg file to see the result");

            }
            finally
            {
                source.Close();
                destination.Close();
            }
        }
    }
}

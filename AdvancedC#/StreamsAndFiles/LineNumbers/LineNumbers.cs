using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            StreamReader reader = null;
            StreamWriter writer = null;

            reader = new StreamReader(@"..\..\Linenumbers.txt");
            writer = new StreamWriter(@"..\..\LinenumbersNew.txt");

            string readLine;
            int lineNumber = 1;
            using (reader)
            using (writer)
            {
                do
                {
                    readLine = reader.ReadLine();
                    writer.WriteLine("{0} {1}", lineNumber, readLine);
                    lineNumber++;
                } while (readLine != null);
            }
            string fileContents = File.ReadAllText(@"..\..\LinenumbersNew.txt");
            Console.WriteLine(fileContents);
        }
    }
}

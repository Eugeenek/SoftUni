using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddLineNumbers
{
    class OddLineNumbers
    {
        static void Main(string[] args)
        {
               StreamReader reader = new StreamReader(@"..\..\OddLineNumbers.cs", Encoding.GetEncoding("windows-1251"));

            string s;
            int lineNumber = 0;

            using (reader)
            {
                do
                {
                    s = reader.ReadLine();
                    lineNumber++;
                    s = reader.ReadLine();
                    Console.WriteLine("Line {0, 2}: {1}", lineNumber, s);
                    lineNumber++;
                } while (s != null);
            }
        }
    }
}

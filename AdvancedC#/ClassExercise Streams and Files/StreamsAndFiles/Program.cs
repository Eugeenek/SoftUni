using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace StreamsAndFiles
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string pattern = @"\s+";
            Regex regex = new Regex(pattern);
            string replacer = " ";
            StreamReader reader = new StreamReader("Mecanismo.cs");
            StreamWriter writer = new StreamWriter("FormatedCode.txt");

            using (reader)
            {
                using (writer)
                {
                    string text = reader.ReadToEnd();
                    string textReplaced = Regex.Replace(pattern, replacer, text);
                    
                    Console.WriteLine(textReplaced);
                }
            }
        }
    }
}

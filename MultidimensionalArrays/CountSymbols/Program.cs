using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();
            foreach (char symbol in input)
            {
                if (symbols.ContainsKey(symbol))
                {
                    symbols[symbol]++;
                }
                else
                {
                    symbols.Add(symbol, 1);
                }
            }

            foreach (KeyValuePair<char, int> pair in symbols)
            {
                Console.WriteLine("{0}: {1} time/s", pair.Key, pair.Value);
            }
        }
    }
}

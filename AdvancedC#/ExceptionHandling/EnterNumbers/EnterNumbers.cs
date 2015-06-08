using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class EnterNumbers
    {
        static void Main()
        {
            int count = 1;
            int start = 1;
            string input = Console.ReadLine();

            while (count<=10)
            {
                try
                {
                    int number = int.Parse(input);
                    ReadNumbers(start, number);
                    count++;
                    start = number;
                }
                catch (FormatException)
                {

                    Console.Error.WriteLine("You should enter numeric value!");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.Error.WriteLine("The numbers you are entering should be in range [{0}...100]", start);
                }
                finally
                {
                    Console.WriteLine("Enter new number in range [{0}...100]", start);
                    input = Console.ReadLine();
                }
            }
        }

        private static void ReadNumbers(int start, int n)
        {
            if (n<=start||n>=100)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}

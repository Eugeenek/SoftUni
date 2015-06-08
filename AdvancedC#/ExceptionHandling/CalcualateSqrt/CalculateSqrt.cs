using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcualateSqrt
{
    class CalculateSqrt
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                double result = Math.Sqrt(number);
                Console.WriteLine("Sqrt of the number you have entered is {0}", result);
            }
            catch(ArgumentOutOfRangeException)  
            {
                Console.Error.WriteLine("You should enter a positive number!");
            }            
            catch (FormatException)
            {

                Console.WriteLine("You need to enter valid numeric value!");
            }
            catch (OverflowException)
            {
                Console.Error.WriteLine("The number you have entered is outside of the range of Int32");
            }
            finally
            {
                Console.WriteLine("Good Bye!");
            }
            
        }
    }
}

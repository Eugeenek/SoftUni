using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArraySort
{
    class GenericArraySort
    {
        static void Main(string[] args)
        {
            
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
            string[] strings = { "zaz", "cba", "baa", "azis" };
            DateTime[] dates = 
            {
            new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1),
            };
            Console.WriteLine(SortArray(numbers));
            Console.WriteLine(SortArray(strings));
            Console.WriteLine( SortArray(dates));
        }

        static string SortArray<T>(IEnumerable<T> array)
        {
            List<T> tempList = array.ToList();
            List<T> sortedInput = new List<T>();

            while (tempList.Count!=0)
            {
                var currentNumber = tempList.Min();
                sortedInput.Add(currentNumber);
                tempList.Remove(currentNumber);
                
            }
              
         

            return PrintArray(sortedInput);
        }

        static string PrintArray<T>(IEnumerable<T> array)
        {
           return String.Join(", ",array);
        }
    }
}

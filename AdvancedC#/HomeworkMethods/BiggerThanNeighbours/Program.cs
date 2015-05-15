using System;
using System.Linq;

class Program
{

    
    static bool IsBiggerThanNeighbours(int[] array, int i)
    {
        bool isGreater = false;
       
            if (i==0)
            {
                isGreater = array[i] > array[i + 1];
            }
            else if ( i== array.Length - 1)
            {
                isGreater = array[i] > array[i-1];
            }
            else
            {
                isGreater = array[i] > array[i - 1] && array[i] > array[i + 1];
            }
            return isGreater;
      
    }

    static void Main(string[] args)
    {
       
        int [] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(IsBiggerThanNeighbours(array,i));
            
        }
    }
}


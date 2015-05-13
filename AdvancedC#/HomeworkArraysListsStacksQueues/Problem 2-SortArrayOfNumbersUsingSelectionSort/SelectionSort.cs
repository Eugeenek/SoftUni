using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class SelectionSort
    {
        static void Main()
        {
            Console.WriteLine("Please enter your numbers");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int temp = 0;
            int min = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                min = i;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[j]<numbers[min])
                    {
                        min = j;
                    }
                }
                temp = numbers[min];
                numbers[min] = numbers[i];
                numbers[i] = temp;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
            }
        }
    }


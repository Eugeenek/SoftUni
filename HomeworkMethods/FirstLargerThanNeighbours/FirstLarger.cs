using System;
using System.Linq;

class FirstLarger
    {
        static bool GetFirstLarger(int[] array, int i)
        {
            bool firstLarger;

            if (i == 0)
            {
                firstLarger = array[i] > array[i + 1];
            }
            else if (i == array.Length - 1)
            {
                firstLarger = array[i] > array[i - 1];
            }
            else
            {
                firstLarger = array[i] > array[i - 1] && array[i] > array[i + 1];
            }
            return firstLarger;

        }

        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool isFound = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (GetFirstLarger(array, i))
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine(-1);
            }

        }
    }


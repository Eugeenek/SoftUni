using System;
using System.Diagnostics;
using System.Linq;

class LongestIncreasingSequence
{
    static void Main()
    {
        string input = Console.ReadLine();
        int [] numbers = input.Split().Select(int.Parse).ToArray();

        int count = 1;
        int maxLength = 1;
        int end = 0;

        Console.Write(numbers[0] + " ");
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i]>numbers[i-1])
            {
                count++;
                Console.Write(numbers[i] + " ");
            }
            else
            {
                count = 1;
                Console.WriteLine();
                Console.Write(numbers[i]+ " ");
            }
            if (count>maxLength)
            {
                maxLength = count;
                end = i;
            }
           
        }
        Console.WriteLine();
        Console.Write("Longest: ");
        for (int j = end - maxLength + 1; j <=end; j++)
        {
            Console.Write(numbers[j] + " ");
        }
    }
}


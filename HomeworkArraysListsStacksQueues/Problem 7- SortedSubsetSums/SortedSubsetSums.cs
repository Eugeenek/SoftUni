using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class SortedSubsetSums
{

    static List<List<int>> subsets=new List<List<int>>();
    static int[] numbers;
    static int N;
    static bool solution = false;

    private static void PrintSubsets(IEnumerable<List<int>>sorted)
    {

        foreach (var item in sorted)
        {
            Console.WriteLine(string.Join(" + ", item) + " = " + N);
        }
       
    }

    static void SumsOfSubsets(int index, List<int> subset)
    { 
        if (subset.Sum() == N && subset.Count > 0) 
        {
            subsets.Add(new List<int>(subset));
            solution = true; // set solution to true, and we will not be printing that there is no solution
        }

        if (subset.Count == numbers.Length)
            return;

        for (int i = index; i < numbers.Length; i++)
        {
            subset.Add(numbers[i]);

            SumsOfSubsets(i + 1, subset);
            subset.RemoveAt(subset.Count - 1);
        }
    }
    static void Main()
    {
        N = int.Parse(Console.ReadLine());
        numbers = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToArray();

        Array.Sort(numbers);
        List<int> subset = new List<int>();

        SumsOfSubsets(0, subset);
        var sorted = subsets.OrderBy(x => x.Count);

        PrintSubsets(sorted);

        if (!solution)
        {
            Console.WriteLine("No matching subsets");
        }
    }
}

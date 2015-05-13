using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

// This task was incredibly hard for me. After spending a whole day on researching different sites and articles i came to the conclusion
//that there are two possible effective solutions. One is using recursion and the other one using bitwise operations.
// More about solution using bits you can find here:https://medium.com/@mustbeadevil/sum-of-subset-problem-ff8f38990ada 
//As recursion is new to me and I do not completely understand it i used the solution of the problem from a SoftUni colleague KatyaMarincheva
//and spent another couple of hours debugging in order to understand it.

class SubsetSums
{

    static int[] numbers;
    static int N;
    static bool solution = false;

    private static void PrintSubset(List<int> subset)
    {
        Console.WriteLine(string.Join(" + ", subset) + " = " + N);
    }

    static void SumsOfSubsets(int index, List<int> subset)
    {
        int sum = subset.Sum();
        if (sum == N)
        {
            PrintSubset(subset);
            solution = true; 
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
        List<int> subset = new List<int>();

        SumsOfSubsets(0,subset);

        if (!solution)
        {
            Console.WriteLine("No matching subsets");
        }
    }
}

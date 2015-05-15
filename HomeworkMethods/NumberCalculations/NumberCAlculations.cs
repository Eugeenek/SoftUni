using System;
using System.Linq;

class NumberCalculations
{
    static void GetMin(int[]array)
    {
        int minValue = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (minValue > array[i])
            {
                minValue = array[i];
            }
        }
        Console.WriteLine(minValue);
    }
    static void GetMax(int[] array)
    {
        int maxValue = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (maxValue < array[i])
            {
                maxValue = array[i];
            }
        }
        Console.WriteLine(maxValue);
    }
    static void GetSum(int[] array)
    {
        int sum = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            sum += array[i];
        }
        Console.WriteLine(sum);
    }

    private static void GetProduct(int[] array)
    {
        int product = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            product *= array[i];
        }
        Console.WriteLine(product);
    }

    static void GetAverage(int[] array)
    {
        int sum = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            sum += array[i];
        }
        sum = sum / array.Length;
        Console.WriteLine(sum);
    }

    static void GetMin(double[] array)
    {
        double minValue = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (minValue > array[i])
            {
                minValue = array[i];
            }
        }
        Console.WriteLine(minValue);
    }
    static void GetMax(double[] array)
    {
        double maxValue = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (maxValue < array[i])
            {
                maxValue = array[i];
            }
        }
        Console.WriteLine(maxValue);
    }
    static void GetSum(double[] array)
    {
        double sum = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            sum += array[i];
        }
        Console.WriteLine(sum);
    }

    private static void GetProduct(double[] array)
    {
        double product = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            product *= array[i];
        }
        Console.WriteLine(product);
    }

    static void GetAverage(double[] array)
    {
        double sum = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            sum += array[i];
        }
        sum = sum / array.Length;
        Console.WriteLine(sum);
    }
      
    static void Main()
    {
        Console.WriteLine("Enter a set of integer numbers separated by space");
        int[] inputInt = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Console.WriteLine("Enter a set of double numbers separated by space");
        double[] inputDouble = Console.ReadLine().Split().Select(double.Parse).ToArray();
        Console.WriteLine("Min values");
        GetMin(inputInt);
        GetMin(inputDouble);
        Console.WriteLine("Max values");
        GetMax(inputInt);
        GetMax(inputDouble);
        Console.WriteLine("Average values");
        GetAverage(inputInt);
        GetAverage(inputDouble);
        Console.WriteLine("Product");
        GetProduct(inputInt);
        GetProduct(inputDouble);
        Console.WriteLine("Sum");
        GetSum(inputInt);
        GetSum(inputDouble);
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        double[] numbers = input.Split().Select(double.Parse).ToArray();
        List<double> roundNum=new List<double>();
        List<double> floatinPointNumbers=new List<double>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i]%1 != 0)
            {
                floatinPointNumbers.Add(numbers[i]);
            }
            else
            {
                roundNum.Add(numbers[i]);
            }
        }
        foreach (var number in floatinPointNumbers)
        {
            Console.Write(number+" ");
        }
        Console.Write("-> ");
        Console.Write("min:{0:f2}, ",floatinPointNumbers.Min());
        Console.Write("max:{0:f2}, ", floatinPointNumbers.Max());
        Console.Write("Sum:{0:f2}, ",floatinPointNumbers.Sum());
        Console.Write("Sum:{0:f2}, ",floatinPointNumbers.Average());
        Console.WriteLine();

        foreach (var number in roundNum)
        {
            Console.Write(number+" ");
        }
        Console.Write("-> ");
        Console.Write("min:{0:f2}, ",roundNum.Min());
        Console.Write("max:{0:f2}, ", roundNum.Max());
        Console.Write("Sum:{0:f2}, ",roundNum.Sum());
        Console.Write("Sum:{0:f2}, ",roundNum.Average());
    }
    }



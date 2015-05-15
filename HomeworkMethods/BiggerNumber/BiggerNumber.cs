using System;

class BiggerNumber
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        int max = GetBiggerNumber(firstNum, secondNum);
        Console.WriteLine(max);

    }

    static int GetBiggerNumber(int a, int b)
    {
        if (a>b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}


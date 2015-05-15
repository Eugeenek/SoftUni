using System;
class Program
{
    static double NumberReversed(double num)
    {
        string number = num.ToString();
        char[] reversed = number.ToCharArray();
        Array.Reverse(reversed);
        string numReversed = new string(reversed);
        double reversedNumber = double.Parse(numReversed);
        return reversedNumber;
    }
    static void Main()
    {
        double num = double.Parse(Console.ReadLine());

        Console.WriteLine(NumberReversed(num));
    }
}


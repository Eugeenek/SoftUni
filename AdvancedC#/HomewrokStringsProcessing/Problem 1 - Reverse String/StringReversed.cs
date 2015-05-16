using System;
using System.Linq;
using System.Runtime.InteropServices;

class StringReversed
{
    static void Main()
    {
        string input = Console.ReadLine();
        string reversedInput = new string(input.Reverse().ToArray());
        Console.WriteLine(reversedInput);
    }
}


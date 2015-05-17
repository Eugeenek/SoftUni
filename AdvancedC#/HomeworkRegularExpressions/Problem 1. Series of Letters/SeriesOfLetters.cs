using System;
using System.Text.RegularExpressions;

internal class SeriesOfLetters
{
    private static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"(\w)\1+";
        string replace = "$1";

        string result = Regex.Replace(input, pattern, replace);
        Console.WriteLine(result);
    }
}

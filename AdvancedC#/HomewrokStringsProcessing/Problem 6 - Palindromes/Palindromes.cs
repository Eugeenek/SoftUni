using System;
using System.Linq;
using System.Text.RegularExpressions;

class Palindromes
{
    static void Main(string[] args)
    {
        string words = Console.ReadLine();
        var result = Regex.Matches(words, @"\w+").Cast<Match>()
                    .Select(m => m.Value)
                    .Where(w => String.Join("", w.Reverse()) == w).ToList();
        result.Sort();
        Console.WriteLine(string.Join(", ", result));
    }
}

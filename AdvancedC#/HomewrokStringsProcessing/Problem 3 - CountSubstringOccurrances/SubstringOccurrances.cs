using System;
class SubstringOccurences
{
    static void Main()
    {
        string input = Console.ReadLine();
        string substring = Console.ReadLine();
        int occurences = 0;
        int startIndex = 0;
        
        while (input.IndexOf(substring, startIndex, StringComparison.OrdinalIgnoreCase) >= 0)
        {
            occurences++;
            startIndex = input.IndexOf(substring, startIndex, StringComparison.OrdinalIgnoreCase) + 1;
        }
        Console.WriteLine(occurences);
    }
}

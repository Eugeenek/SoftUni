using System;

class UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();
        string inputAsUnicode = string.Empty;

        foreach (var character in input)
        {
            inputAsUnicode += "\\u" + ((int) character).ToString("X4");
        }
        Console.WriteLine(inputAsUnicode);
    }
}


using System;
using System.Text.RegularExpressions;

internal class ReplaceATag
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string pattern = @"<a\s+href=([^>]+)>([^<]+)</a>";
        Regex regex = new Regex(pattern);
        string replace = "[URL href=$1]$2[/URL]";
        string output = Regex.Replace(input, pattern, replace);
        Console.WriteLine(output);
    }
}   

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ValidUsernames
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine().Trim();
        string[] usernames = Regex.Split(input,@"[\s/\\\(\)]+");

        List<string> extractedUsernames = new List<string>();

        string pattern = @"^[A-Za-z]\w+$";

        foreach (var username in usernames)
        {
            if (username.Length>=3&&username.Length<=25&& Regex.IsMatch(username,pattern))
            {
                extractedUsernames.Add(username);
            }
        }

        int maxSum = int.MinValue;
        int currentSum = 0;
        int index = 0;

        for (int i = 0; i < extractedUsernames.Count-1; i++)
        {
            currentSum = extractedUsernames[i].Length + extractedUsernames[i + 1].Length;
            if (currentSum>maxSum)
            {
                maxSum = currentSum;
                index = i;
            }
        }
        Console.Write(extractedUsernames[index]);
        Console.WriteLine();
        Console.Write(extractedUsernames[index+1]);
        Console.WriteLine();
    }
}


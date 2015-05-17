using System;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;

class SentenceExtractor
{
    static void Main()
    {
        string keyword = Console.ReadLine().Trim();
        keyword = @"\b" + keyword + @"\b";
        string input = Console.ReadLine();

        string pattern = @"[A-Z][A-Za-z\s\-\,\:\'\u2029\u2013]*[\.\?\!]";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);

        foreach (Match match in matches)
        {
            string sentence = match.Value;
            if (Regex.IsMatch(sentence,keyword))
            {
                Console.WriteLine(sentence);
            }
        }
    }
}


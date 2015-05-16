using System;
using System.Text.RegularExpressions;

class TextReplace
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] bannedWords = Regex.Split(input, @"[, ]+");
            string text = Console.ReadLine();

            foreach (var replace in bannedWords)
            {
                Regex word = new Regex("\\b" + replace.ToString() + "\\b");
                text = word.Replace(text, delegate(Match match)
                {
                    string forRemoving = match.ToString();
                    return new string('*', forRemoving.Length);
                });
            }
            Console.WriteLine(text);
        }
    }


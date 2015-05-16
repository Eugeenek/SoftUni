using System;
using System.Linq;
using System.Text.RegularExpressions;

class LettersChangeNumbers
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        decimal totalResult = 0;
        decimal currentResult = 0;
        foreach (var word in input)
        {
           
            
            char first = word.First();
            char third   = word.Last();
            int number = int.Parse(Regex.Match(word, @"\d+").Value);

            if (char.IsUpper(first))
            {
                currentResult += number/(decimal) (first - 'A' + 1);
            }
            else if (Char.IsLower(first))
            {
                currentResult += number * (decimal)(first - 'a' + 1);
            }

            if (Char.IsUpper(third))
            {
                currentResult -= (decimal)(third - 'A' + 1);
            }
            else if (Char.IsLower(third))
            {
                currentResult += (decimal)(third - 'a' + 1);
            }
            totalResult += currentResult;
            currentResult = 0;

        }
        Console.WriteLine("{0:F2}",totalResult);

    }
}

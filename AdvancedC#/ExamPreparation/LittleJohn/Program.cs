using System;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        const string smallArrow = ">----->";
        const string mediumArrow = ">>----->";
        const string largeArrow = ">>>----->>";

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < 4; i++)
        {
            sb.AppendFormat(" {0}",Console.ReadLine());
        }
        string arrowPattern = @"(>>>----->>)|(>>----->)|(>----->)";
        Regex arrowMatcher = new Regex(arrowPattern);
        var arrows = arrowMatcher.Matches(sb.ToString());

        int largeArrowCount = 0;
        int mediumArrowCount = 0;
        int smalArrowCount = 0;
    }
}



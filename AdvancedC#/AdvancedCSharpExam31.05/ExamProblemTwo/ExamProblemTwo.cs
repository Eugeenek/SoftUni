using System;
using System.Linq;
using System.Text;

class ExamProblemTwo
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        string inputCommands = Console.ReadLine();

        while (inputCommands!="end")
        {
            StringBuilder sb = new StringBuilder();

            string[] commands = inputCommands.Split(' ');
            if (commands.Contains("reverse"))
            {
                int startIndex = int.Parse(commands[2]);
                int count = int.Parse(commands[4]);
                string toReverse = input.ToString().Substring(startIndex, count);
                sb.Replace(toReverse, toReverse.Reverse());
                Console.WriteLine("{0}",toReverse);
            }
        }
    }
}


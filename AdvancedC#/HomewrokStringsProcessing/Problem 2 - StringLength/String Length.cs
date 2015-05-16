using System;

class StringLength
{
    static void Main()
    {
        string input = Console.ReadLine();
        int length = 20;

        if (input.Length<length)
        {
            string addStars = new string('*', length - input.Length);
            Console.WriteLine(input+addStars);
        }
        else
        {
            string output = input.Substring(0, length);
            Console.WriteLine(output);
        }
    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

class ExamProblemFour
{
    static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<string, Player> playerByCountry =
                new Dictionary<string, Player>();


        while (input!="report")
        {
            string[] data = input.Split('|');
            string name = data[0];
            string country = data[1];
            if (!playerByCountry.ContainsKey(country))
            {
                playerByCountry[country]=new Player();
            }

            Player currentPlayer = playerByCountry[country];
            currentPlayer.Name = name;
            if (playerByCountry.ContainsKey(country) )
            {
                currentPlayer.WinCount++;
                currentPlayer.Participations++;
            }

            input = Console.ReadLine();
        }

        foreach (var player in playerByCountry)
        {
            Console.WriteLine("{0} ({1} participants): {2} wins", player.Key,player.Value.Participations,player.Value.WinCount);
        }

    }
}

class Player
{
    public string Name { get; set; }
    public int WinCount { get; set; }
    public int Participations { get; set;}

}


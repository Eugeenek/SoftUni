using System;
class CollectCoins
{
    static void Main()
    {
        string[] matrix = new string[4];

        string boardLine = String.Empty;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            matrix[row] = Console.ReadLine();

        }

        int boardRow = 0;
        int boardCol = 0;
        int coins = 0;
        int wallHits = 0;
        string commands = Console.ReadLine();
        foreach (char command in commands)
        {
            if (command == 'V')
            {
                boardRow++;
                if (boardRow >= matrix.GetLength(0))
                {
                    boardRow--;
                    wallHits++;
                    continue;
                }
                else if (boardCol >= matrix[boardRow].Length)
                {
                    boardRow--;
                    wallHits++;
                    continue;
                }
            }
            else if (command == '>')
            {
                boardCol++;
                if (boardCol >= matrix[boardRow].Length)
                {
                    boardCol--;
                    wallHits++;
                    continue;
                }
            }
            else if (command == '<')
            {
                boardCol--;
                if (boardCol < 0)
                {
                    boardCol++;
                    wallHits++;
                    continue;
                }
            }
            else if (command == '^')
            {
                boardRow--;
                if (boardRow < 0)
                {
                    boardRow++;
                    wallHits++;
                    continue;
                }
                else if (boardCol >= matrix[boardRow].Length)
                {
                    boardRow++;
                    wallHits++;
                    continue;
                }
            }

            if (matrix[boardRow][boardCol].Equals('$'))
            {
                coins++;
            }
        }
        Console.WriteLine("Coins collected: {0}", coins);
        Console.WriteLine("Walls hit: {0}", wallHits);
    }
}
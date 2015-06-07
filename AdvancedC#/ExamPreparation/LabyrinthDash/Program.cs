using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        const string obsticles = "*@#";
        int numberOfRows = int.Parse(Console.ReadLine());

        char[][] matrix = new char[numberOfRows][];

        for (int i = 0; i < numberOfRows; i++)
        {
            string inputLine = Console.ReadLine();
            matrix[i] = inputLine.ToCharArray();
        }

        string commands = Console.ReadLine();
        int livesLeft = 3;
        int row = 0;
        int col = 0;
        int movesMade = 0;


        foreach (var direction in commands)
        { 
                int previousRow = 0;
                int previousCol = 0;
            switch (direction)
            {
                   
                case'<':
                    col--;
                    break;
                case '>':
                    col++;
                    break;
                case 'v':
                    row++;
                    break;
                case '^':
                    row--;
                    break;
            }

            if (!IsCellInsideeMatrix(row,col,matrix)|| matrix[row][col]==' ')
            {
                Console.WriteLine("Fell off a cliff! Game Over!");
                movesMade++;
                break;
            }
            else if (matrix[row][col]=='_' || matrix[row][col]=='|')
            {
                Console.WriteLine("Bumped a wall.");
                row = previousRow;
                col = previousCol;
            }
            else if (obsticles.Contains(matrix[row][col].ToString()))
            {
                livesLeft--;
                movesMade++;
                Console.WriteLine("Ouch! That hurt! Lives left: {0}",livesLeft);
                if (livesLeft <= 0)
                {
                    Console.WriteLine("No lives left! Game over!");
                    break;
                }
            }
            else if (matrix[row][col]=='$')
            {
                livesLeft++;
                matrix[row][col] = '.';
                movesMade++;
                Console.WriteLine("Awesome! Lives left: {0}",livesLeft);
                
            }
            else
            {
                movesMade++;
                Console.WriteLine("Made a move!");
            }
        }
        Console.WriteLine("Total moves made: {0}",movesMade);
    }

    private static bool IsCellInsideeMatrix(int row, int col, char[][] matrix)
    {
        bool IsRowInsideMatrix = 0 <= row && row < matrix.Length;
        if (!IsRowInsideMatrix)
        {
            return false;
        }

        bool isColInRange = 0 <= col && col < matrix[row].Length;
        return isColInRange;
    }
}


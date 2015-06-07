
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] matrixSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rows = matrixSize[0];
        int cols = matrixSize[1];

        string input = Console.ReadLine();
        //int[] shotParameters = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //int shotRow = shotParameters[0];
        //int shotcol = shotParameters[1];
        //int shotRadius = shotParameters[2];

        char[,] matrix = new char[rows, cols];

        int snakeindex = 0 ;
        int startCol = 0;

        for (int i = rows - 1; i >= 0; i--)
        {

            for (int j = cols-1; j >=0; j--)
            {
                matrix[i,j] = input[snakeindex];
                snakeindex++;
                if (snakeindex > input.Length-1)
                {
                    snakeindex = 0;
                }
            }
        }

        //for (int i = shotRow; i < matrix.GetLength(0); i++)
        //{
        //    for (int j = shotcol; j <matrix.GetLength(1); j++)
        //    {
        //        matrix[i, j] = ' ';
        //    }
        //}

        PrintMatrix(matrix);
    }

    public static void PrintMatrix(char[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(" {0}",matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}


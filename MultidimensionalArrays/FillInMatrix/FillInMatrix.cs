using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillInMatrix
{
    internal class FillInMatrix
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintMatrixUsingPatternA(n);
            Console.WriteLine();
            PrintMatrixUsingPatternB(n);
        }
        
       
    private static void PrintMatrixUsingPatternA(int n)
        {
            int[,] matrix = new int[n, n];
            int startNumber = 1;

            Console.WriteLine("Sort the matrix using the first pattern");
            Console.WriteLine();
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = startNumber;
                    startNumber++;
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,2} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void PrintMatrixUsingPatternB(int n)
        {
            int[,] matrix = new int[n, n];
            int startNumber = 1;

            Console.WriteLine("Print the matrix using pattern B");
            Console.WriteLine();
            for (int col = 0; col < n; col++)
            {
                if (col%2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = startNumber;
                        startNumber++;
                    }
                }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        matrix[row, col] = startNumber;
                        startNumber++;
                    }
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,2} ", matrix[row, col]);
                }
                Console.WriteLine();
            }

        }
    }
}





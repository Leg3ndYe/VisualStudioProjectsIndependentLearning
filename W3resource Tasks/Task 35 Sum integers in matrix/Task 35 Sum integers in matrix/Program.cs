using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_35_Sum_integers_in_matrix
{
    /* Task:  Write a C# program to calculate the sum of all the integers of a rectangular 
    matrix except those integers which are located below an intger of value 0. 
    Sample Example:
    matrix = [[0, 2, 3, 2], [0, 6, 0, 1], [4, 0, 3, 0]]
    Eligible integers which will be participated to calculate the sum -
    matrix = [[X, 2, 3, 2], [X, 6, X, 1], [4, X, 3, X]]
    Therefore sum will be: 2 + 3 + 2 + 6 + 1 = 14*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[,] matrix  = {{ 0, 2, 3, 2 },{0, 6, 0, 1 },{ 4, 0, 3, 0 }};
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}

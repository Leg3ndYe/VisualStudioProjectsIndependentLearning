using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_23_Write_a_program_to_sum_all_array_int
{
    /* Task: Write a C# program to compute the sum of all the elements of an array of integers.
     Test Data:
        Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
        Sample Output
        Sum: 69*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int result = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                result += intArray[i];
            }
            Console.WriteLine("Sum: {0}",result);
        }
    }
}

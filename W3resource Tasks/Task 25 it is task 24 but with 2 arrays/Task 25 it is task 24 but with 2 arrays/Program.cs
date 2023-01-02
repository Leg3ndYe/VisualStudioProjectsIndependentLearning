using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_25_it_is_task_24_but_with_2_arrays
{
    /* Task 25: Write a C# program to check if the first element or the last element of the two arrays 
    ( length 1 or more) are equal.
    Test Data:
        Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
        Array2: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5]
        Check if the first element or the last element of the two arrays ( leng th 1 or more) are equal.
        Sample Output
        True*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int[] numArray2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            bool isTrue = false;
            if (numArray1.Length >= 1 && numArray2.Length >= 1)
            {
                if (numArray1[0] == numArray2[0])
                {
                    isTrue = true;
                }
                else if (numArray1[numArray1.Length-1] == numArray2[numArray2.Length-1])
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                }
            }
            Console.WriteLine(isTrue);

        }
    }
}

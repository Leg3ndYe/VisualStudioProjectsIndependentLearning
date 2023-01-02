using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_24_Check_ints_and_lenght_in_array
{
    /* Task: Write a C# program to check if the first element and the last element are equal of an array of integers and 
       the length is 1 or more.
       Test Data:
        Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
        Sample Output
        True */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            bool isTrue = false;
            if(numArray.Length >= 1 && numArray[0] == numArray[numArray.Length-1])
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }
            Console.WriteLine(isTrue);
        }
    }
}

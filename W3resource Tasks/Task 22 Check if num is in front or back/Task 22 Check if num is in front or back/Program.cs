using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_22_Check_if_num_is_in_front_or_back
{
    /* Task: Write a C# program to check if a number appears as either the first or last element 
     of an array of integers and the length is 1 or more.
    Test Data:
        Input an integer: 25
        Sample Output
        False */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            bool isTrue = false;
            int num = 0;
            Console.WriteLine("Input an integer: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (numArray.Length == num || numArray.Length-numArray.Length+1 == num)
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

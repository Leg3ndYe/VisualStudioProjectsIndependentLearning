using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_27_Check_for_biggest_in_array
{
    /* Task: Write a C# program to get the larger value between first and last element of an array (length 3) of integers.
     Test Data:
        Array1: [1, 2, 5, 7, 8]
        Highest value between first and last values of the said array: 8 */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 1, 2, 5, 7, 8 };
            int highest = 0;
            if (numArray.Length >= 3)
            {
                for (int i = 0; i < numArray.Length; i++)
                {
                    if (numArray[i] > highest)
                    {
                        highest = numArray[i];
                    }
                    else
                    {
                        continue;
                    }

                }
                Console.WriteLine(highest);
            }
            else
            {
                Console.WriteLine("Your array of numbers is shorter than 3");
            }
        }
    }
}

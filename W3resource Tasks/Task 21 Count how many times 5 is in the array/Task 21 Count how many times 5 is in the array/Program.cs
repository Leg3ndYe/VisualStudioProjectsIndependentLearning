using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_Count_how_many_times_5_is_in_the_array
{
    /* Task: Write a C# program to count a specified number in a given array of integers. 
     Test Data:
        Input an integer: 5
        Sample Output
        Numbers of 5 present in the said array: 2 */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int numCount = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] == 5)
                {
                    numCount++;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Number of 5's present in the said array: {0}",numCount);
            
        }
    }
}

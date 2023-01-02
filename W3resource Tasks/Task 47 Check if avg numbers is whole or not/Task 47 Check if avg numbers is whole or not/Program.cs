using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_47_Check_if_avg_numbers_is_whole_or_not
{
    /* Task: Write a C# Sharp program to check whether the average value of the elements of 
    a given array of numbers is a whole number or not. 
    Sample Output:
        nums = { 1, 2, 3, 5, 4, 2, 3, 4 }
    Check the average value of the said array is a whole number or not: True
        nums1 = { 2, 4, 2, 6, 4, 8 }
    Check the average value of the said array is a whole number or not: False*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 5, 4, 2, 3, 4 };
            int[] nums1 = { 2, 4, 2, 6, 4, 8 };
            Console.WriteLine("Check the average value of the said array is a whole number or not: {0} ",IsAverage(nums));
            Console.WriteLine("Check the average value of the said array is a whole number or not: {0}", IsAverage(nums1));

        }
        public static bool IsAverage(int[] nums)
        {
            return nums.Average() % 1 == 0;
        }
    }
}
